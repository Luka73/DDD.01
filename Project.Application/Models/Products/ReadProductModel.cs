using Project.Application.Models.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.Models.Products
{
    public class ReadProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public ReadStockModel Stock { get; set; }
    }
}
