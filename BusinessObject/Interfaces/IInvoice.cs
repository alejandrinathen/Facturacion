

namespace BusinessObject.Interfaces
{
    public interface IInvoice
    {
         int Id { get; set; }
         int CustomerId { get; set; }
         decimal TotalItbis {get; set; }
         decimal SubTotal {get; set; }
         decimal Total {get; set; }
    }
}
