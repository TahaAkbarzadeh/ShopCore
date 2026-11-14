using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Core.DTO
{
    public class ProductCreateDTO
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }

        public int StockQuantity { get; set; }

        public int CategoryId { get; set; }




    }
}
