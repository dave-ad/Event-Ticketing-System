using LinearSearch;

namespace Algorithms;

class Program
{
    /// <summary>
    /// Use to seach values on int arrays
    /// </summary>
    /// <param name="collection">The colllection that the search is going to be executed on</param>
    /// <param name="itemToSearch">The integer value that we search in the collection</param>
    /// <returns>The index of the search item. Returns -1 if not found</returns>
    static int Search(int[] collection, int itemToSearch)
    {
        for (int i = 0; i < collection.Length; i++)
        {
            if (collection[i] == itemToSearch)
            {
                return i;
            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        // Searching Algorithm - Linear search
        // Returns the first element that applies for the condition
        // The longer the collection the more step it needs to succeed
        // Works even if the collections is not oredered

        int[] collection = { 0, 1, 2, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("The collections: ");
        for (int i = 0; i < collection.Length; i++)
            Console.Write(collection[i] + ", ");

        Console.WriteLine();

        //int objectOfSearch = int.Parse(Console.ReadLine());
        int objectOfSearch = 2;
        Console.WriteLine($"Searching item {objectOfSearch} in the collection...");
        int searchResult = Search(collection, objectOfSearch);

        if (searchResult != -1)
            Console.WriteLine($"Value found at index {searchResult}");
        else
            Console.WriteLine("Value not found in the collection");

        Console.WriteLine("\n--------------------------------------------------------------------------------------------------\n");
        Console.ReadLine();

        Person[] persons =
        {
            new Person
            {
                Name = "Adam",
                Age = 31,
            },

            new Person
            {
                Name = "Melissa",
                Age = 30,
            },

            new Person
            {
                Name = "Perselus",
                Age = 45,
            },

            new Person
            {
                Name = "Clark",
                Age = 31,
            },

            new Person
            {
                Name = "Jane",
                Age = 21,
            }
        };

        persons.ToList().ForEach(x => { Console.WriteLine(x); });

        //string nameToFind = Console.ReadLine();
        string nameToFind = "Adam";
        Person resultOfTheSearch = FindPersonByName(persons, nameToFind);

        Console.WriteLine($"Searching for {nameToFind} in the database...");

        if (resultOfTheSearch !=null)
            Console.WriteLine(resultOfTheSearch.ToString());
        else
            Console.WriteLine("Sorry, this guy is not present here");

        Console.ReadLine();

    }

    // Working with complex data
    static Person FindPersonByName(Person[] persons, string nameToSearch)
    {
        foreach (var person in persons)
        {
            if (person.Name == nameToSearch)
            {
                return person;
            }
        }
        return null;
    }
}
