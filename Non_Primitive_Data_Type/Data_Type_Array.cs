using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Data_Type_Array : MonoBehaviour
{
    string[] countries;
    List<string> countryList;

    void Awake()
    {
        countries = new string[] { "Japan", "Brazil", "Canada", "Germany", "Philippines" };
        countryList = new List<string>(countries);
    }

    void Start()
    {
        Array_Part1();
        // Find_1();
        // LengthFunction();
        // CountainFunction();
        // RemoveAt();
        // RemoveAtFunction();
        // CountainFunction();
        // CallFunction();
        IndexFunction();
    }

    private void CallFunction()
    {
        foreach (var name in countries)
        {
            Debug.Log(name);
        }
    }


    //**Arrays unlike lists have a fixed size and cannot be changed once they are created.**//


    //---------------------------------------------------------------------
    // Part 1: Printing Array Elements
    // Create an array of 5 countries and then print them out to the console.
    // Hint: Use a foreach loop to print the array elements.

    // Array names = new string[5] { "John", "Jane", "Jack", "Jill", "James" };
    // foreach (string name in names)
    // {
    //     Console.WriteLine(name);
    // }

    // Part 1: Create an array of 5 countries



    private void Array_Part1()
    {
        int index = System.Array.IndexOf(countries, "Japan");
        Debug.Log("Index of 'Japan': " + index);


        string asd = countries[0];
        Debug.Log("First country: " + countries[0]);


    }

    //---------------------------------------------------------------------
    // Part 2: Accessing Array Elements by Index
    // Using the array of countries, find the name in the 3rd position and print it out to the console.
    // Hint: Use the index of the array to access the name in the 3rd position.

    private void Find_1()
    {
        string name = countries[3];
        Debug.Log(name);

        // int index = System.Array.IndexOf(countries, "Canada");
        // Debug.Log(index);
    }

    //---------------------------------------------------------------------
    // Part 3: Removing an Element from the Array
    // Using the array of countries, remove the name in the 2nd position and then print the array out to the console.
    // Hint: Use the RemoveAt() method to remove an item from the array.

    public void RemoveAtFunction()
    {

        countryList.RemoveAt(2);

        countries = countryList.ToArray();
    }

    //---------------------------------------------------------------------
    // Part 4: Replacing an Element in the Array
    // Using the array of countries, replace the name in the 3rd position with a new name and then print the array out to the console.
    // Hint: Use the index of the array to replace the name in the 3rd position with a new name.

    private void RemoveAt()
    {
        countryList.RemoveAt(3);
        countryList.Insert(3, "MAMA");
        countries = countryList.ToArray();
    }

    //---------------------------------------------------------------------
    // Part 5: Finding the Length of the Array
    // Using the array of countries, find the length of the array and print it out to the console.
    // Hint: Use the Length property to find the length of the array.

    private void LengthFunction()
    {
        int lengthCheck = countries.Length;
        Debug.Log(lengthCheck);
    }


    //---------------------------------------------------------------------
    // Part 6: Checking if an Element Exists in the Array
    // Using the array of countries, check if a name exists in the array and print out if it exists or not.
    // Hint: Use the Contains() method to check if a name exists in the array.

    private void CountainFunction()
    {
        bool result_4 = System.Array.Exists(countries, IsTrue);
        Debug.Log(result_4);
    }

    private bool IsTrue(string name)
    {
        return name == "Japan";
    }

    //---------------------------------------------------------------------
    // Part 7: Finding the Index of an Element in the Array
    // Using the array of countries, find the index of a name in the array and print it out to the console.
    // Hint: Use the IndexOf() method to find the index of a name in the array.

    private void IndexFunction()
    {
        int result_5 = System.Array.IndexOf(countries, "Germany");

        Debug.Log(result_5);
    }

}
