using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Non_Primitive_Data_Type : MonoBehaviour
{

    void Start()
    {
        // AddFunction();
        // FindFunction();
        // RemoveFunction();
        // AddNCallFunction();
        // LengthFunction();
        // boolContain();
        // IndexOfFunction();
        // InsertFunction();
        // SortFunction();
        // FLI();
        // ClearFunction();

        AddData();
        PrintData();
    }

    #region Part 1

    //Part 1
    //Create a list of 5 names and then print them out to the console.
    //Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.

    List<string> NameList = new List<string>();

    private void AddFunction()
    {
        NameList.Add("NA");
        NameList.Add("CHAD");
        NameList.Add("AN");
        NameList.Add("BRIGHT");
    }

    private void CallFunction()
    {
        Debug.Log("Updated List");

        foreach (string name in NameList)
        {
            Debug.Log(name);
        }
    }

    #endregion


    #region Part 2

    //Part 2
    //Using the list of names and find the name in the 3rd position and print it out to the console.

    private void FindFunction()
    {
        string name_1 = NameList[2];
        Debug.Log(name_1);
    }

    #endregion

    //Part 3
    //Using the list of names, remove the name in the 2nd position and then print the list out to the console.
    //Hint: You can use the RemoveAt() method to remove an item from the list.

    private void RemoveFunction()
    {
        NameList.RemoveAt(2);
    }

    //Part 4
    //Using the list of names, add a new name to the list and then print the list out to the console.
    //Hint: You can use the Add() method to add a new name to the list.

    private void AddNCallFunction()
    {
        NameList.Add("KOKO");
        CallFunction();
    }

    //Part 5
    //Using the list of names , find the length of the list and print it out to the console.
    //Hint: You can use the Count property to find the length of the list.

    private void LengthFunction()
    {
        int length = NameList.Count;
        Debug.Log(length);

    }

    //Part 6
    //Using the list of names , check if a name exists in the list and print out if it exists or not.
    //Hint: You can use the Contains() method to check if a name exists in the list.

    private void boolContain()
    {
        bool result_1 = NameList.Contains("NA");
        Debug.Log(result_1);
    }

    //Part 7
    //Using the list of names, find the index of a name in the list and print it out to the console.
    //Hint: You can use the IndexOf() method to find the index of a name in the list.

    private void IndexOfFunction()
    {
        int result_2 = NameList.IndexOf("BRIGHT");
        Debug.Log(result_2);
    }

    //Part 8
    //Using the list of names, insert a new name at the 3rd position and print the list out to the console.
    //Hint: You can use the Insert() method to insert a new name at a specific position in the list.

    private void InsertFunction()
    {
        NameList.Insert(0, "HEHE");
    }

    //Part 9
    //Using the list of names, sort the list and print it out to the console.
    //Hint: You can use the Sort() method to sort the list.

    private void SortFunction()
    {
        NameList.Sort();
    }

    //Part 10
    //Using the list of names , use findlastindex() method to find the last index of a name in the list and print it out to the console.
    //Hint: You can use the FindLastIndex() method to find the last index of a name in the list.

    private void FLI()
    {
        int result_3 = NameList.FindLastIndex(fli);
        Debug.Log(result_3);
    }

    private bool fli(string name)
    {
        return name == "AN";
    }

    //Part 11
    //Using the list of names, clear the list and print the list out to the console.
    //Hint: You can use the Clear() method to clear the list.


    private void ClearFunction()
    {
        NameList.Clear();
        Debug.Log("List CLeared");
    }

    //Part 12
    //Create a new list of strings and integers and print them out to the console.
    //Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.

    List<string> nameList = new List<string>();
    List<int> numberList = new List<int>();

    public void AddData()
    {
        // Add strings
        nameList.Add("Alice");
        nameList.Add("Bob");
        nameList.Add("Charlie");

        // Add integers
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
    }

    void PrintData()
    {
        Debug.Log("Names:");
        foreach (string name in nameList)
        {
            Debug.Log(name);
        }

        Debug.Log("Numbers:");
        foreach (int number in numberList)
        {
            Debug.Log(number);
        }
    }
}

    



