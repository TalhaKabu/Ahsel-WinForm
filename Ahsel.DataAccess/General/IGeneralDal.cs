using Ahsel.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahsel.DataAccess.General
{
    public interface IGeneralDal
    {
        Task<Client> CreateClientAsync(Client client);
        Task<Payment> CreatePaymentAsync(Payment payment);
        Task<List<Project>> GetProjectListAsync();
        Task<List<Client>> GetClientListAsync(int projectRef);
        Task<List<PaymentDto>> GetPaymentListAsync(int projectRef);
    }
}
