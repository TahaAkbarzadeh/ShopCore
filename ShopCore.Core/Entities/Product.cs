using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Core.Entities
{
    public class Product
    {
       
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }

        public int StockQuantity { get; set; }

        public int CategoryId { get; set; }

         public Category catagory { get; set; }

    }
}
