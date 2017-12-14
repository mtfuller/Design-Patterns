using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            Console.WriteLine("Factory Method:");
            var factory = new ConcreteProductFactory() as Factory;
            var prod1 = factory.getConcreteProduct("Product1");
            var prod2 = factory.getConcreteProduct("Product2");
            Console.WriteLine(prod2);

            // 
            Console.WriteLine("\nAbstract Factory:");
            var factory1 = new ConcreteFactory1() as AbstractFactory;
            var prodA = factory1.CreateProductA();
            var prodB = factory1.CreateProductB();
            Console.WriteLine("Products:" + prodA + " & " + prodB);

            // 
            Console.WriteLine("\nSingleton:");
            var singleton = Singleton.Instance;
            Console.WriteLine(singleton);
            Console.WriteLine("Singleton has only one instance: " + (singleton == Singleton.Instance));

            // 
            Console.WriteLine("\nDecorator:");
            var myComponent = new ConcreteComponent() as Component;
            myComponent = new ConcreteDecorator(myComponent);
            myComponent.Operation();

            // 
            Console.WriteLine("\nIterators:");
            var arrayAggregate = new ArrayAggregate();
            Iterator iter = arrayAggregate.CreateIterator();
            Console.WriteLine("Array Iteration:");
            while (!iter.IsDone())
                Console.Write(iter.Next() + " ");

            var listAggregate = new ListAggregate();
            iter = listAggregate.CreateIterator();
            Console.WriteLine("\nList Iteration:");
            while (!iter.IsDone())
                Console.Write(iter.Next() + " ");


            // 
            Console.WriteLine("\n\nObserver:");
            var subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver());
            subject.Attach(new ConcreteObserver());
            subject.Attach(new ConcreteObserver());
            subject.Value = "I changed the value!!!";
            Console.WriteLine(subject.Value);
        }
    }
}
