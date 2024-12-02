using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Interface for aggregate classes that define a contract for iterating over elements.
/// </summary>
public interface IIterable
{
    IIterator CreateIterator();
}

/// <summary>
/// Interface for iterators that provide access to elements in the collection.
/// </summary>
public interface IIterator
{
    bool HasNext();
    object Next();
}

/// <summary>
/// Concrete class representing a collection of items (aggregate).
/// </summary>
public class ItemCollection : IIterable
{
    private List<string> _items = new List<string>();

    /// <summary>
    /// Adds an item to the collection.
    /// </summary>
    /// <param name="item">Item to be added.</param>
    public void AddItem(string item)
    {
        _items.Add(item);
    }

    /// <summary>
    /// Creates an iterator for the collection.
    /// </summary>
    /// <returns>An instance of ItemIterator.</returns>
    public IIterator CreateIterator()
    {
        return new ItemIterator(_items);
    }
}

/// <summary>
/// Concrete iterator class for iterating over items in ItemCollection.
/// </summary>
public class ItemIterator : IIterator
{
    private List<string> _items;
    private int _currentIndex = 0;

    /// <summary>
    /// Initializes a new instance of the ItemIterator class.
    /// </summary>
    /// <param name="items">The collection of items to iterate over.</param>
    public ItemIterator(List<string> items)
    {
        _items = items;
    }

    /// <summary>
    /// Checks if there is a next item in the collection.
    /// </summary>
    /// <returns>True if there is a next item, otherwise false.</returns>
    public bool HasNext()
    {
        return _currentIndex < _items.Count;
    }

    /// <summary>
    /// Returns the next item in the collection.
    /// </summary>
    /// <returns>The next item.</returns>
    public object Next()
    {
        if (HasNext())
        {
            return _items[_currentIndex++];
        }
        throw new InvalidOperationException("No more items to iterate.");
    }
}

/// <summary>
/// Client code for using the Iterator pattern.
/// </summary>
public class Program
{
    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    public static void Main()
    {
        // Create a collection of items.
        ItemCollection collection = new ItemCollection();
        collection.AddItem("Item 1");
        collection.AddItem("Item 2");
        collection.AddItem("Item 3");
        collection.AddItem("Item 4");

        // Create an iterator to traverse the collection.
        IIterator iterator = collection.CreateIterator();

        // Iterate over the collection and display each item.
        Console.WriteLine("Iterating over the collection:");
        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}
