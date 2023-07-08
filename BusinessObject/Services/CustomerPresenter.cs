using BusinessObject.Interfaces;
using BusinessObject.Models;
using BusinessObject.Repository;

namespace BusinessObject.Services
{
    public class CustomerPresenter : IPresenter
    {
        private ICustomer _customerSender;
        private Customer customer;
        private MyContext _context;

        public CustomerPresenter(MyContext context, ICustomer customerSender)
        {
            _context = context;
            _customerSender = customerSender;
            Add();
        }

        private void gather()
        {
            customer.Id = _customerSender.Id;
            customer.CustName = _customerSender.CustName;
            customer.Adress = _customerSender.Adress;
            customer.Status = _customerSender.Status;
            customer.CustomerTypeId = _customerSender.CustomerTypeId;
        }

        private void scatter()
        {
            _customerSender.Id = customer.Id;
            _customerSender.CustName = customer.CustName;
            _customerSender.Adress = customer.Adress;
            _customerSender.Status = customer.Status;
            _customerSender.CustomerTypeId = customer.CustomerTypeId;
        }

        public void Add()
        {
            customer = new Customer();
            customer.Status = true;
            scatter();
        }

        public bool Delete()
        {
            if (customer.Id == 0)
            {
                Add();
                scatter();
                return false;
            }
            _context.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
            return Save();
        }

        public bool Find(long id)
        {
            if (id == 0)
            {
                Add();
                scatter();
                return false;
            }
            var found = _context.Customer.Find(id);
            if (found == null)
            {

                Add();
                scatter();
                return false;
            }
            customer = found;
            _context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            scatter();
            return true;
        }

        public bool Save()
        {
            gather();

            if (customer.Id == 0)
                _context.Customer.Add(customer);


            var state = _context.Entry(customer).State;
            var result = _context.SaveChanges() > 0;

            if (result && state == System.Data.Entity.EntityState.Deleted)
                Add();

            scatter();

            return result;
        }
    }
}
