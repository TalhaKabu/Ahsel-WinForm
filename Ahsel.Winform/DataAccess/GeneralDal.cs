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

        public async Task<List<ClientDto>> GetClientListAsync(int projectRef)
        {
            await using var connection = Configuration.Create();

            var clients = (await connection.QueryAsync<ClientDto>($@"
						SELECT *
                        FROM Clients
                        Where ProjectRef = @projectRef", new { projectRef = projectRef })).ToList();

            return clients;
        }

        public async Task<List<PaymentDto>> GetPaymentListAsync(int projectRef)
        {
            await using var connection = Configuration.Create();

            var payments = (await connection.QueryAsync<PaymentDto>($@"
						SELECT 
                             Py.*
                            ,Cl.Name ClientName 
                        FROM Payments Py
                        LEFT JOIN Clients Cl WITH(NOLOCK) ON Cl.Id = Py.ClientRef
                        WHERE Py.ProjectRef = @projectRef
                        ORDER BY Py.Date DESC", new { projectRef = projectRef })).ToList();

            return payments;
        }

        public async Task<int> CreateClientAsync(string name, int projectRef)
        {
            await using var connection = Configuration.Create();

            var id = (await connection.ExecuteScalarAsync<int>($@"
                    INSERT INTO Clients
                          ([Name]
                           ,[ProjectRef])
                    VALUES
                          ('{name}'
                           ,'{projectRef}')
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
                          ,[Description]
                          ,[ProjectRef])
                    VALUES
                          (@ClientRef
                          ,@Quantity
                          ,@Price
                          ,@Date
                          ,@Description
                          ,@ProjectRef)", create));

            return id;
        }

        public async Task<List<ProjectDto>> GetProjectsAsync()
        {
            await using var connection = Configuration.Create();

            var projects = (await connection.QueryAsync<ProjectDto>($@"
						SELECT 
                            *
                        FROM Projects")).ToList();

            return projects;
        }
    }
}
