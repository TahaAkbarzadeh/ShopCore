using ShopCore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Core.RepositoryContracts
{
    internal interface IProductRepository
    {
        /// <summary>
        /// Get All Product From DataBase
        /// </summary>
        /// <returns>return List of Product</returns>
        Task<List<Product>> GetAllProductAsync();
        /// <summary>
        /// Get All Product
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        Task<Product> GetProductByIdAsync(Guid ProductId);
        /// <summary>
        /// Get Pri
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        Task<Product> GetProductByNameAsync(string Name);
    }
}
