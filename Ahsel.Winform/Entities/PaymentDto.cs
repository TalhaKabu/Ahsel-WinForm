using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahsel.Winform.Entities
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public int ClientRef { get; set; }
        public string ClientName { get; set; }
        public int ProjectRef { get; set; }
    }
}
