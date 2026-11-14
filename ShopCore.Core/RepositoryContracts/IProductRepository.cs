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
        Task<Product?> GetProductByIdAsync(Guid productId);
        /// <summary>
        /// Get Pri
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<List<Product>> GetProductByNameAsync(string name);
        
        /// <summary>
        /// Add Product To DataBase
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<bool> AddProductAsync(Product product);

        /// <summary>
        /// Update Product Attributes
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Return Updated Product</returns>
        Task<Product> UpdateProductAsync(Product product);

        /// <summary>
        /// Delete Product From DataBase By Id
        /// </summary>
        /// <param name="productId">Delete Product By This Param</param>
        /// <returns>If Deleting Is Successful Would Be True </returns>
        Task<bool> DeleteProductByIdAsync(Guid productId);
         
    }
}
