using OrderForProductsWithDb.Data;
using OrderForProductsWithDb.Models;

using OrderForProductsContext context = new OrderForProductsContext();

Product laptop = new Product()
{
    Name = "HP Pavillion 15",
    Price = 420M
};

context.Products.Add(laptop);

Product phone = new Product()
{
    Name = "Samsung Galaxy A9 Star",
    Price = 190M
};

context.Products.Add(phone);

context.SaveChanges();