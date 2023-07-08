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
    public class InvoicePresenter : IPresenter
    {
        private IInvoice _invoiceSender;
        private Invoice invoice;
        private MyContext _context;

        public InvoicePresenter(MyContext context, IInvoice invoiceSender)
        {
            _context = context;
            _invoiceSender = invoiceSender;
            Add();
        }


        private void gather()
        {
            invoice.Id = _invoiceSender.Id;
            invoice.CustomerId = _invoiceSender.CustomerId;
            invoice.TotalItbis = _invoiceSender.TotalItbis;
            invoice.SubTotal = _invoiceSender.SubTotal;
            invoice.Total = _invoiceSender.Total;
        }

        private void scatter()
        {
            _invoiceSender.Id = invoice.Id;
            _invoiceSender.CustomerId = invoice.CustomerId;
            _invoiceSender.TotalItbis = invoice.TotalItbis;
            _invoiceSender.SubTotal = invoice.SubTotal;
            _invoiceSender.Total = invoice.Total;
        }

        public void Add()
        {
            invoice = new Invoice();
            scatter();
        }

        public bool Delete()
        {
            if (invoice.Id == 0)
            {
                Add();
                scatter();
                return false;
            }
            _context.Entry(invoice).State = System.Data.Entity.EntityState.Deleted;
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
            var found = _context.Invoice.Find(id);
            if (found == null)
            {

                Add();
                scatter();
                return false;
            }
            invoice = found;
            _context.Entry(invoice).State = System.Data.Entity.EntityState.Modified;
            scatter();
            return true;
        }

        public bool Save()
        {
            gather();

            if (invoice.Id == 0)
                _context.Invoice.Add(invoice);


            var state = _context.Entry(invoice).State;
            var result = _context.SaveChanges() > 0;

            if (result && state == System.Data.Entity.EntityState.Deleted)
                Add();

            scatter();

            return result;
        }

        public void SumarizarDetalle()
        {
            decimal subtotalItbis = 0;
            decimal subotal = 0;
            decimal total = 0;
            foreach (var item in _context.InvoiceDetail.Where(a => a.InvoiceId == invoice.Id).ToList())
            {
                subtotalItbis += item.TotalItbis;
                subotal += item.SubTotal;
                total += item.Total;
            }

            _invoiceSender.SubTotal = subotal;
            _invoiceSender.TotalItbis = subtotalItbis;
            _invoiceSender.Total = total;

        }

    }
}
