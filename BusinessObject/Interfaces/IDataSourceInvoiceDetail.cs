using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Interfaces
{
    public interface IDataSourceInvoiceDetail
    {
        object DataSourceDetail { get; set; }
        DataTable dataTable();
    }
}
