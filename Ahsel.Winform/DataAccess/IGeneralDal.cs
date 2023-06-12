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
        Task<List<ClientDto>> GetClientListAsync();
        Task<List<PaymentDto>> GetPaymentListAsync();
        Task<int> CreateClientAsync(string name);
        Task<int> CreatePaymentAsync(PaymentCreateDto create);
    }
}
