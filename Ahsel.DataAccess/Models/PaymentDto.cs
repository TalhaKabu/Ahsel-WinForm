using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahsel.DataAccess.Models
{
    public class PaymentDto : Payment
    {
        public string ClientName { get; set; }
    }
}
