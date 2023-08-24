using Ahsel.Winform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahsel.Winform.DataAccess
{
    public interface IGeneralDal
    {
        Task<List<ClientDto>> GetClientListAsync(int projectRef);
        Task<List<PaymentDto>> GetPaymentListAsync(int projectRef);
        Task<int> CreateClientAsync(string name, int projectRef);
        Task<int> CreatePaymentAsync(PaymentCreateDto create);
        Task<List<ProjectDto>> GetProjectsAsync();
    }
}
