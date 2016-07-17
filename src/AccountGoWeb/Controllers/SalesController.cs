﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AccountGoWeb.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("SalesOrders");
        }

        public IActionResult SalesOrders()
        {
            ViewBag.PageContentHeader = "Sales Orders";

            return View();
        }

        public IActionResult AddSalesOrder()
        {
            ViewBag.PageContentHeader = "Add Sales Order";

            return View();
        }

        [HttpPost]
        public IActionResult AddSalesOrder(object Dto)
        {
            return Ok();
        }

        public IActionResult GetAddSalesOrderDto()
        {
            var Dto = new object();

            //Dto.Customers = new HashSet<Microsoft.AspNet.Mvc.Rendering.SelectListItem>();
            //Dto.Customers.Add(new Microsoft.AspNet.Mvc.Rendering.SelectListItem() { Value = "0", Text = "Choose customer..." });
            //Dto.Customers.Add(new Microsoft.AspNet.Mvc.Rendering.SelectListItem() { Value = "1", Text = "John Doe" });
            //Dto.Customers.Add(new Microsoft.AspNet.Mvc.Rendering.SelectListItem() { Value = "2", Text = "Joe Blogs" });
            //Dto.Customers.Add(new Microsoft.AspNet.Mvc.Rendering.SelectListItem() { Value = "3", Text = "Mary Walter" });

            //Dto.Items = new HashSet<Microsoft.AspNet.Mvc.Rendering.SelectListItem>();
            //Dto.Items.Add(new Microsoft.AspNet.Mvc.Rendering.SelectListItem() { Value = "0", Text = "Choose item..." });
            //Dto.Items.Add(new Microsoft.AspNet.Mvc.Rendering.SelectListItem() { Value = "1", Text = "Mouse" });
            //Dto.Items.Add(new Microsoft.AspNet.Mvc.Rendering.SelectListItem() { Value = "2", Text = "Keyboard" });
            //Dto.Items.Add(new Microsoft.AspNet.Mvc.Rendering.SelectListItem() { Value = "3", Text = "Monitor" });

            return new ObjectResult(Dto);
        }

        public IActionResult SalesInvoices()
        {
            ViewBag.PageContentHeader = "Sales Invoices";

            return View();
        }

        public IActionResult AddSalesInvoice()
        {
            ViewBag.PageContentHeader = "Add Sales Invoice";

            return View();
        }

        public IActionResult SalesReceipts()
        {
            ViewBag.PageContentHeader = "Sales Receipts";

            return View();
        }

        public IActionResult AddSalesReceipt()
        {
            ViewBag.PageContentHeader = "Add Sales Receipt";

            return View();
        }
    }
}
