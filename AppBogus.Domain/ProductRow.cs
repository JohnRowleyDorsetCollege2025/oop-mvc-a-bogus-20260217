using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBogus.Domain
{
    public class ProductRow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
    }
}

// Repeat for product what you did for people.
// Create a ProductRow class with properties Id, Name, Price, Category, and Stock.
// Then create a method in the FakeDataService to generate fake products using Bogus.
// Finally, create API and MVC controllers to return the list of products.

