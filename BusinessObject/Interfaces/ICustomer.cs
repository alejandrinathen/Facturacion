using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Interfaces
{
    public interface ICustomer
    {
         int Id { get; set; }
         string CustName { get; set; }
         string Adress { get; set; }
         bool Status { get; set; }
         int CustomerTypeId { get; set; }
    }
}
