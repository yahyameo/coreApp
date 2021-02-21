using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using WebPOSApi.Models;
using WebPOSApi.Models.InvoiceVM;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class InvoiceController : ControllerBase
    {
        [HttpPost]
        public dynamic AddInvoice(InvoiceVM invoice)
        {
            return InvoiceVM.AddInvoice(invoice) ;
        }
        [HttpPost]
        public dynamic ReturnAndSalesInvoice(InvoiceVM invoice)
        {
            return InvoiceVM.ReturnAndSalesInvoice(invoice);
        }

        [HttpGet]
        public dynamic GetInvoices(int branchId, DateTime fromDate, DateTime toDate)
        {
            return InvoiceVM.GetInvoices(branchId,fromDate,toDate);
        }
        
        [HttpGet]
        public dynamic GetInvoiceById(int invoiceId)
        {
            return InvoiceVM.GetInvoiceById(invoiceId);
        }
        [HttpPost]
        public dynamic ReturnInvoice(dynamic invoice)
        {
            return InvoiceVM.ReturnInvoice(invoice);
        }
        [HttpGet]
        public dynamic GetDashboardSalesCountByDays(int branchId)
        {
           return InvoiceVM.GetDashboardSalesCountByDays(branchId);
        }
        [HttpPost]
        public dynamic VoidInvoice(InvoiceVM model)
        {
            return InvoiceVM.VoidInvoice(model);
        }
        [HttpGet]
        public dynamic ReturnedInvoices(int branchId, DateTime fromDate, DateTime toDate)
        {
            return InvoiceVM.ReturnedInvoices(branchId, fromDate, toDate);
        }
        [HttpGet]
        public dynamic GetReturnedItems(int branchId, DateTime fromDate, DateTime toDate,int companyId)
        {
            return InvoiceVM.GetReturnedItem(fromDate, toDate, branchId, companyId);
        }
        [HttpPost]
        public dynamic GetItemSales(InventoryVM inventoryVM)
        {
            return InvoiceVM.GetItemSales(inventoryVM);
        }

        [HttpGet]
        public dynamic InvoiceDetails(int invoiceId)
        {
            return InvoiceVM.InvoiceDetails(invoiceId);
        }

        [HttpPost]
        public dynamic EditInvoice(InvoiceVM invoiceVM)
        {
            return InvoiceVM.EditInvoice(invoiceVM);
        }

        public dynamic GetSalesByUsers(int branchId, DateTime fromDate, DateTime toDate)
        {
            return InvoiceVM.GetSalesByUsers(branchId, fromDate, toDate);
        }
        public dynamic GetSalesByCompany(int branchId, DateTime fromDate, DateTime toDate)
        {
            return InvoiceVM.GetSalesByCompany(branchId, fromDate, toDate);
        }
        public dynamic GetStockByBranch(int branchId, int companyId)
        {
            return InvoiceVM.GetStockByBranch(branchId, companyId);
        }

        public dynamic GetRemainingStock(int branchId)
        {
            return InvoiceVM.GetRemainingStock(branchId);
        }

        public dynamic GetRemainingStockByProduct(int branchId, int companyId)
        {
            return InvoiceVM.GetRemainingStockByProduct(branchId, companyId);
        }

        public dynamic ReturnInvoiceItemList(WebPOSApi.Models.InvoiceVM.InvoiceVM.ReturnInvoiceVM returnInvoiceVM)
        {
            return InvoiceVM.ReturnInvoiceItemList(returnInvoiceVM);
        }

        public dynamic ReturnBreakUpItem(InvoiceBreakUpVM invoiceBreakUp)
        {
            return InvoiceVM.ReturnBreakUpItem(invoiceBreakUp);
        }
        public dynamic GetDashboardSales(int branchId)
        {
            return InvoiceVM.GetDashboardSales(branchId);
        }
        public dynamic GetLast12MonthSales(int branchId)
        {
            return InvoiceVM.GetLast12MonthSales(branchId);
        }
        public dynamic GetProfitByProduct(int branchId, DateTime fromDate, DateTime toDate)
        {
            return InvoiceVM.GetProfitByProduct(branchId,fromDate,toDate);
        }
    }
}
