using Ahsel.DataAccess.Models;
using Ahsel.DataAccess.MyModels;
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
        Task<Description> CreateDescriptionAsync(Description description);
        Task<Payment> UpdatePaymentAsync(Payment payment);
        Task<List<Description>> GetDescriptionListAsync(int projectRef);
        Task<List<Project>> GetProjectListAsync();
        Task<List<Client>> GetClientListAsync(int projectRef);
        Task<List<PaymentDto>> GetPaymentListAsync(int projectRef);
        Task<List<ClientGroupDto>> GetGroupPaymentListAsync(int projectRef);
    }
}
