using BusinessObject.Interfaces;
using BusinessObject.Models;
using BusinessObject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Services
{
    public class CustomerTypePresenter : IPresenter
    {
        private ICustomerType _customerTypeSender;
        private CustomerType customerType;
        private MyContext _context;

        public CustomerTypePresenter(MyContext context, ICustomerType customerTypeSender)
        {
            _context = context;
            _customerTypeSender = customerTypeSender;
            Add();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Find(long id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
