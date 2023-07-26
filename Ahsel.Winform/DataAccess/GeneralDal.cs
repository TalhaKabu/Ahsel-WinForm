using Ahsel.Winform.Connection;
using Ahsel.Winform.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahsel.Winform.DataAccess
{
    public class GeneralDal : IGeneralDal
    {
        private readonly IConnectionConfiguration Configuration;

        public GeneralDal(IConnectionConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<List<ClientDto>> GetClientListAsync()
        {
            await using var connection = Configuration.Create();

            var clients = (await connection.QueryAsync<ClientDto>($@"
						SELECT *
                        FROM Clients")).ToList();

            return clients;
        }

        public async Task<List<PaymentDto>> GetPaymentListAsync()
        {
            await using var connection = Configuration.Create();

            var payments = (await connection.QueryAsync<PaymentDto>($@"
						SELECT 
                             Py.*
                            ,Cl.Name ClientName 
                        FROM Payments Py
                        LEFT JOIN Clients Cl WITH(NOLOCK) ON Cl.Id = Py.ClientRef
                        ORDER BY Py.Date DESC")).ToList();

            return payments;
        }

        public async Task<int> CreateClientAsync(string name)
        {
            await using var connection = Configuration.Create();

            var id = (await connection.ExecuteScalarAsync<int>($@"
                    INSERT INTO Clients
                          ([Name])
                    VALUES
                          ('{name}')
                    SELECT SCOPE_IDENTITY()"));

            return id;
        }

        public async Task<int> CreatePaymentAsync(PaymentCreateDto create)
        {
            await using var connection = Configuration.Create();

            var id = (await connection.ExecuteAsync($@"
                    INSERT INTO [dbo].[Payments]
                          ([ClientRef]
                          ,[Quantity]
                          ,[Price]
                          ,[Date]
                          ,[Description])
                    VALUES
                          (@ClientRef
                          ,@Quantity
                          ,@Price
                          ,@Date
                          ,@Description)", create));

            return id;
        }
    }
}
