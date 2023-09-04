using Ahsel.DataAccess.Models;
using Ahsel.DataAccess.MyModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ahsel.DataAccess.General
{
    public class GeneralDal : IGeneralDal
    {
        public async Task<Client> CreateClientAsync(Client client)
        {
            await using var db = new AhselContext();
            var cl = (await db.AddAsync(client)).Entity;
            await db.SaveChangesAsync();
            return cl;
        }

        public async Task<Payment> CreatePaymentAsync(Payment payment)
        {
            await using var db = new AhselContext();
            var py = (await db.AddAsync(payment)).Entity;
            await db.SaveChangesAsync();
            return py;
        }
        public async Task<List<Description>> GetDescriptionListAsync(int projectRef)
        {
            await using var db = new AhselContext();

            var dc = (from description in db.Descriptions
                      where description.ProjectRef == projectRef
                      select new Description
                      {
                          Id = description.Id,
                          ProjectRef = description.ProjectRef,
                          Name = description.Name
                      }).ToList().DistinctBy(x => new { x.Name, x.ProjectRef }).ToList();

            return dc;
        }

        public async Task<List<Project>> GetProjectListAsync()
        {
            await using var db = new AhselContext();

            return await db.Projects.ToListAsync();
        }

        public async Task<List<Client>> GetClientListAsync(int projectRef)
        {
            await using var db = new AhselContext();

            return await db.Clients
                .Where(x => x.ProjectRef == projectRef)
                .ToListAsync();
        }

        public async Task<List<PaymentDto>> GetPaymentListAsync(int projectRef)
        {
            await using var db = new AhselContext();

            var payments = (from payment in db.Payments
                            join client in db.Clients on payment.ClientRef equals client.Id
                            where payment.ProjectRef == projectRef
                            orderby payment.Date descending
                            select new PaymentDto
                            {
                                Id = payment.Id,
                                Price = payment.Price,
                                ClientName = client.Name,
                                ClientRef = payment.ClientRef,
                                Quantity = payment.Quantity,
                                Date = payment.Date,
                                Description = payment.Description,
                                ProjectRef = payment.ProjectRef
                            }).ToList();

            return payments;
        }

        public async Task<List<ClientGroupDto>> GetGroupPaymentListAsync(int projectRef)
        {
            await using var db = new AhselContext();

            var groupedPayments = (from client in db.Clients
                                   where client.ProjectRef == projectRef
                                   select new ClientGroupDto
                                   {
                                       Id = client.Id,
                                       Name = client.Name,
                                       ProjectRef = client.ProjectRef,
                                       Total = 0,
                                       PaymentList = (from payment in db.Payments
                                                      where payment.ClientRef == client.Id && payment.ProjectRef == projectRef
                                                      select new Payment
                                                      {
                                                          Id = payment.Id,
                                                          ClientRef = payment.ClientRef,
                                                          Date = payment.Date,
                                                          ProjectRef = payment.ProjectRef,
                                                          Description = payment.Description,
                                                          Price = payment.Price,
                                                          Quantity = payment.Quantity
                                                      }).ToList()
                                   }).ToList();

            float generalTotal = 0;
            int clientCount = 0;
            float highestClientTotal = 0;
            foreach (var item in groupedPayments)
            {
                item.Total = item.PaymentList.Sum(x => x.Quantity * x.Price);
                if (!item.Name.Equals("Gider", StringComparison.OrdinalIgnoreCase) && !item.Name.Equals("Satış", StringComparison.OrdinalIgnoreCase))
                {
                    if (item.Total >= highestClientTotal)
                        highestClientTotal = item.Total;

                    generalTotal += item.Total;
                    clientCount++;
                }
            }

            foreach (var item in groupedPayments)
            {
                if (!item.Name.Equals("Gider", StringComparison.OrdinalIgnoreCase) && !item.Name.Equals("Satış", StringComparison.OrdinalIgnoreCase))
                    item.RemainPayment = highestClientTotal - item.Total;
            }

            return groupedPayments;
        }
    }
}
