using BusinessObject.Helper;
using BusinessObject.Interfaces;
using BusinessObject.Models;
using BusinessObject.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Services
{
    public class InvoiceDetailPresenter : IPresenter
    {
        private readonly IDataSource _dataSource;
        private readonly IDataSourceInvoiceDetail _dataSourceInvoiceDetail;
        private IInvoiceDetail _invoiceDetailSender;
        private InvoiceDetail invoiceDetail;
        private MyContext _context;


        public InvoiceDetailPresenter(MyContext context, IInvoiceDetail invoiceDetailSender)
        {
            _context = context;
            _invoiceDetailSender = invoiceDetailSender;
            Add();
            _dataSource = invoiceDetailSender as IDataSource;
            _dataSourceInvoiceDetail = invoiceDetailSender as IDataSourceInvoiceDetail;
        }


        private void gather()
        {
            invoiceDetail.Id = _invoiceDetailSender.Id;
            invoiceDetail.InvoiceId = _invoiceDetailSender.InvoiceId;
            invoiceDetail.CustomerId = _invoiceDetailSender.CustomerId;
            invoiceDetail.Qty = _invoiceDetailSender.Qty;
            invoiceDetail.Price = _invoiceDetailSender.Price;
            invoiceDetail.TotalItbis = _invoiceDetailSender.TotalItbis;
            invoiceDetail.SubTotal = _invoiceDetailSender.SubTotal;
            invoiceDetail.Total = _invoiceDetailSender.Total;
        }

        private void scatter()
        {
            _invoiceDetailSender.Id = invoiceDetail.Id;
            _invoiceDetailSender.InvoiceId = invoiceDetail.InvoiceId;
            _invoiceDetailSender.CustomerId = invoiceDetail.CustomerId;
            _invoiceDetailSender.Qty = invoiceDetail.Qty;
            _invoiceDetailSender.Price = invoiceDetail.Price;
            _invoiceDetailSender.TotalItbis = invoiceDetail.TotalItbis;
            _invoiceDetailSender.SubTotal = invoiceDetail.SubTotal;
            _invoiceDetailSender.Total = invoiceDetail.Total;
        }

        public void Add()
        {
            invoiceDetail = new InvoiceDetail();
            scatter();
        }

        public bool Delete()
        {
            if (invoiceDetail.Id == 0)
            {
                Add();
                scatter();
                return false;
            }
            _context.Entry(invoiceDetail).State = System.Data.Entity.EntityState.Deleted;
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
            var found = _context.InvoiceDetail.Find(id);
            if (found == null)
            {

                Add();
                scatter();
                return false;
            }
            invoiceDetail = found;
            _context.Entry(invoiceDetail).State = System.Data.Entity.EntityState.Modified;
            scatter();
            return true;
        }

        public bool Save()
        {
            gather();

            if (invoiceDetail.Id == 0)
                _context.InvoiceDetail.Add(invoiceDetail);


            var state = _context.Entry(invoiceDetail).State;
            var result = _context.SaveChanges() > 0;

            if (result && state == System.Data.Entity.EntityState.Deleted)
                Add();

            scatter();

            return result;
        }

        public void FillDataSource()
        {

            var result = (from detalle in _context.InvoiceDetail
                          join header in _context.Invoice on detalle.InvoiceId equals header.Id
                          where header.Id == invoiceDetail.InvoiceId
                          select new InvoiceDetail
                          {
                              Qty = detalle.Qty,
                              Price = detalle.Price,
                              TotalItbis = detalle.TotalItbis,
                              SubTotal = detalle.SubTotal,
                              Total = detalle.Total
                          }
                          ).ToDataTable("InvoiceDetail");
        }

        public DataTable FillDataSourceInvoiceDetails()
        {
            return _context.InvoiceDetail.Where(a => a.InvoiceId == this.invoiceDetail.InvoiceId).ToList().ToDataTable("InvoiceDetail");
        }

    }
}
