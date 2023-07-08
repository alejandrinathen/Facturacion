using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Interfaces
{
    public interface IPresenter
    {
        void Add();
        bool Delete();
        bool Find(long id);
        bool Save();
    }
}
