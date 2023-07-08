using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Interfaces
{
    public interface IDataSource
    {
        long Id { get; set; }
        object DataSource { get; set; }
        string TextToSearch { get; set; }
    }
}
