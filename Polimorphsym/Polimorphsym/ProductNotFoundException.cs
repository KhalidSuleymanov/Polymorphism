using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskPolimorphsym
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string message) : base(message)
        {
            Console.WriteLine("Product not Found" + message);
        }
    }
}
