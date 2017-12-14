using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary
{

    // Aggregate
    public interface Aggregate
    {
        Iterator CreateIterator();
    }

    // Concrete Aggregate: Array
    public class ArrayAggregate : Aggregate
    {
        private string[] _items;
        public ArrayAggregate()
        {
            _items = new[] {
                "How",
                "are",
                "you",
                "doing?"
            };
        }

        public Iterator CreateIterator()
        {
            return new ArrayIterator(_items);
        }
    }

    // Concrete Aggregate: List
    public class ListAggregate : Aggregate
    {
        private List<string> _items;
        public ListAggregate()
        {
            _items = new List<string> {
                "How",
                "are",
                "you",
                "doing?"
            };
        }

        public Iterator CreateIterator()
        {
            return new ListIterator(_items);
        }
    }

    // Iterator
    public interface Iterator
    {
        void First();
        string Next();
        bool IsDone();
        string CurrentItem();
    }

    // Concrete Iterator: Arrays
    public class ArrayIterator : Iterator
    {
        private string[] _items;
        private int _current;

        public ArrayIterator(string[] _items)
        {
            this._items = _items;
            First();
        }

        public void First()
        {
            _current = 0;
        }

        public string Next()
        {
            return _items[_current++];
        }

        public bool IsDone()
        {
            return _current >= _items.Length;
        }

        public string CurrentItem()
        {
            return _items[_current];
        }
    }

    // Concrete Iterator: List
    public class ListIterator : Iterator
    {
        private List<string> _items;
        private int _current;

        public ListIterator(List<string> _items)
        {
            this._items = _items;
            First();
        }

        public void First()
        {
            _current = 0;
        }

        public string Next()
        {
            return _items.ElementAt(_current++);
        }

        public bool IsDone()
        {
            return _current >= _items.Count;
        }

        public string CurrentItem()
        {
            return _items.ElementAt(_current);
        }
    }
}
