using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary
{
    // Component
    public abstract class Component
    {
        public abstract void Operation();
    }

    // Concrete Component
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Operating on the Concrete Component");
        }
    }

    // Decorator
    public class Decorator : Component
    {
        protected Component _component;
        public Decorator(Component component)
        {
            _component = component;
        }
        public override void Operation() => _component.Operation();
    }

    // Concrete Decorator
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component) { }

        public override void Operation()
        {
            Console.WriteLine("Operating on a Concrete Decorator");
            base.Operation();
        }
    }
}
