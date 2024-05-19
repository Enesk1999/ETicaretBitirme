﻿using ETicaretWebUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public UnitOfWork(ApplicationDbContext rr)
        {
            applicationDbContext = rr;
            Category = new CategoryRepository(applicationDbContext);
            Product = new ProductRepository(applicationDbContext);
        }

        public void Save()
        {
            applicationDbContext.SaveChanges();
        }
    }
}
