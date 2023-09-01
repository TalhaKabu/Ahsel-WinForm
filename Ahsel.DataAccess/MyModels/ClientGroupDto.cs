using Ahsel.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahsel.DataAccess.MyModels
{
    public class ClientGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProjectRef { get; set; }
        public float Total { get; set; }
        public float? RemainPayment { get; set; }
        public List<Payment> PaymentList { get; set; }
    }
}
