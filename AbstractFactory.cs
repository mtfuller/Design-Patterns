using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary
{
    // Abstractions of the Abstract Factory Pattern
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    public interface AbstractProductA { }

    public interface AbstractProductB { }

    // Example concrete products and factory
    public class ProductA1 : AbstractProductA { }
    public class ProductB1 : AbstractProductB { }

    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    // Example concrete products and factory
    public class ProductA2 : AbstractProductA { }
    public class ProductB2 : AbstractProductB { }

    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

}
