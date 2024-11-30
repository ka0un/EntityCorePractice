using EntityCorePractice.data;
using EntityCorePractice.models;
using Microsoft.AspNetCore.Builder;

//create instance of database context
using EntityCorePractice.data.ContosoPizzaContext context = new ContosoPizzaContext();

// create a new product
var productx = new Product();
productx.Name = "Apple";
productx.Price = 100;
context.Products.Add(productx);
context.SaveChanges();

//update a product
var producty = context.Products.First();
producty.Price = 200;
context.SaveChanges();


// this is a LINQ query
var products = from product in context.Products 
                                                                    where product.Price > 10 
                                                                    orderby product.Name 
                                                                    select product;

// same thing with fluent syntax
var products2 = context.Products.Where(product => product.Price > 10)
                                                                                                .OrderBy(product => product.Name);

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/", () => products);

app.Run();

// if you alredy have a database and you want to create entities from it
// you can use the following command
// dotnet ef dbcontext scaffold "Data Source=contosoPizza.db" Microsoft.EntityFrameworkCore.Sqlite -o Models