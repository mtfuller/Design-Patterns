using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary
{
    // Product
    public abstract class Product
    {
        public int num { get; set; }
    }

    // ConcreteProduct Example 1
    public class ConcreteProduct1 : Product
    {
        public ConcreteProduct1()
        {
            num = 1;
        }
    }

    // ConcreteProduct Example 2
    public class ConcreteProduct2 : Product
    {
        public ConcreteProduct2()
        {
            num = 2;
        }
    }

    // Creator
    interface Factory
    {
        Product getConcreteProduct(string product);
    }

    // Concrete Creator
    public class ConcreteProductFactory : Factory
    {
        public Product getConcreteProduct(string product)
        {
            if (product.Equals("Product1"))
            {
                return new ConcreteProduct1();
            }
            else if (product.Equals("Product2"))
            {
                return new ConcreteProduct2();
            }
            else throw new ArgumentException("Invalid Product Name");
        }
    }
}
