using BusinessObject.Interfaces;
using BusinessObject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Services
{
    public class SearchCustomerPresenter : ISearchCustomerPresenter
    {
        MyContext _context;
        IDataSource _dataSource;
        public SearchCustomerPresenter(MyContext context, IDataSource dataSource)
        {
            _context = context;
            _dataSource = dataSource;
            Find();
        }
        public void Find()
        {
            this._dataSource.DataSource = _context.Customer.Where(a => a.CustName.Contains(_dataSource.TextToSearch) ||  a.Adress.Contains(_dataSource.TextToSearch)).ToList();
        }
    }
}
