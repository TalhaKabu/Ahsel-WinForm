using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahsel.Winform.Entities
{
    public class TotalPaymentDto
    {
        public string ClientName { get; set; }
        public float TotalPayment { get; set; }
        public float RemainPayment { get; set; }
    }
}
