﻿using ApiSample.DA.Interfaces;
using ApiSample.DA.Tables;
using ApiSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample.DA.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ShopContext ShopContext { get; set; }

        public ProductRepository(ShopContext context)
        {
            this.ShopContext = context;
        }

        public IEnumerable<ProductForCategoryModel> GetProductByCategoryId(int categoryId)
        {
            var result = this.ShopContext.Products.Where(i => i.ListingStartTime < DateTime.Now &&
                                                              i.ListingEndTime >= DateTime.Now &&
                                                              i.Category.Id == categoryId)
                                                  .Select(i => new ProductForCategoryModel()
                                                  {
                                                      Id = i.Id,
                                                      Name = i.Name,
                                                      Price = i.Price
                                                  });

            return result;
        }
    }
}