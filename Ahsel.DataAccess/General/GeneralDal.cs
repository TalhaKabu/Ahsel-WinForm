using Ahsel.DataAccess.Models;
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
    }
}
