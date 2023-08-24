using Ahsel.DataAccess.General;
using Ahsel.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ahsel.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeneralController : ControllerBase
    {
        private readonly IGeneralDal GeneralDal;

        public GeneralController(IGeneralDal generalDal)
        {
            GeneralDal = generalDal;
        }

        [HttpGet("get-client-list")]
        public async Task<List<Client>> GetClientsAsync(int projectRef)
        {
            return await GeneralDal.GetClientListAsync(projectRef);
        }

        [HttpGet("get-payment-list")]
        public async Task<List<PaymentDto>> GetPaymentListAsync(int projectRef)
        {
            return await GeneralDal.GetPaymentListAsync(projectRef);
        }

        [HttpGet("get-project-list")]
        public async Task<List<Project>> GetProjectListAsync()
        {
            return await GeneralDal.GetProjectListAsync();
        }

        [HttpPost("create-client")]
        public async Task<Client> CreateClientAsync(Client client)
        {
            return await GeneralDal.CreateClientAsync(client);
        }

        [HttpPost("create-payment")]
        public async Task<Payment> CreatePaymentAsync(Payment payment)
        {
            return await GeneralDal.CreatePaymentAsync(payment);
        }
    }
}
