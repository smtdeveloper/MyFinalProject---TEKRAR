﻿    using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object

            ProduckManager();

            //IoC - Öğreneceyiz 

            //CategoryManager();



        }

        private static void CategoryManager()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(" CategoryName : " + item.CategoryName);
            }
        }

        private static void ProduckManager()
        {
            ProductManager productManager = new ProductManager(new EfProduckDal());

            productManager.Add(new Product
            {
                
                ProductName = "Suluk",
                CategoryId = 2,
                UnitPrice = 9999,
                UnitsInStock = 1
            });
          
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" Product Name  : " + item.ProductName );
                Console.WriteLine(" Category Name : " + item.CategoryName);
                Console.WriteLine(" Stok          : " + item.UnitsInStock);
                Console.WriteLine("   " );
            }
        }
    }
}
