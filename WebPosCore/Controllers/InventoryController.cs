using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using WebPOSApi.Models;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class InventoryController : ControllerBase
    {
        [HttpPost]
        public dynamic AddInventory(InventoryVM inventoryVM)
        {
            return InventoryVM.AddInventory(inventoryVM);
        }

        [HttpPost]
        public VendorBill AddVendorBill(VendorBillVM inventoryVM)
        {
            return InventoryVM.AddVendorBill(inventoryVM);
        }

        [HttpPost]
        public dynamic UpdateVendorBill(VendorBillVM inventoryVM)
        {
           return  InventoryVM.UpdateVendorBill(inventoryVM);
        }
        [HttpPost]
        public string[] UpdateInventory(InventoryVM inventoryVM)
        {
            return InventoryVM.UpdateInventory(inventoryVM);
        }
        [HttpGet]
        public dynamic GetInventories(DateTime fromDate,DateTime toDate, int branchId)
        {
            return InventoryVM.GetInventories(fromDate, toDate, branchId);
        }

        [HttpPost]
        public dynamic DeleteInventory(InventoryVM inventory)
        {
            return InventoryVM.Delete(inventory);
        }

        [HttpGet]
        public dynamic FindInventoryById(int inventoryId, int branchId)
        {
            return InventoryVM.FindInventoryById(inventoryId, branchId);
        }
        [HttpGet]
        public dynamic FilterInventories(int searchBy,string term,int branchId)
        {
            return InventoryVM.FilterInventories(searchBy, term, branchId);
        }
        [HttpGet]
        public dynamic FilterInventoryByItemCode(int searchBy,int branchId)
        {
            return InventoryVM.FilterInventoryByItemCode(searchBy, branchId);
        }
         [HttpGet]
        public dynamic GetAvailableStockDetail(int branchId,int productId)
        {
            return InventoryVM.GetAvailableStockDetail(branchId, productId);
        }
         public dynamic GetVendorBillById(int branchId, int id, string vendorBillNumber)
         {
             return InventoryVM.GetVendorBillById(branchId, id, vendorBillNumber);
         }
         [HttpGet]
         public dynamic GetVendorBills(DateTime fromDate, DateTime toDate, int branchId)
         {
             return InventoryVM.GetVendorBills(fromDate, toDate, branchId);
         }
    }
}
