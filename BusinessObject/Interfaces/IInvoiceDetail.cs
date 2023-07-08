using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Interfaces
{
    public interface IInvoiceDetail
    {
         int Id { get; set; }
         int InvoiceId { get; set; }
        int CustomerId { get; set; }
         int Qty { get; set; }
        decimal Price {get; set; }
    decimal TotalItbis {get; set; }
decimal SubTotal {get; set; }
decimal Total {get; set; }
    }
}
