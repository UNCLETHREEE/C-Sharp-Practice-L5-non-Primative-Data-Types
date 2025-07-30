using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class Data_Type_String : MonoBehaviour
{
    // Part 6
    private GameObject inputObject_1;
    private GameObject inputObject_2;
    private GameObject inputObject_3;
    // Part 6

    // Part 9 10 11 12 13 14 15
    public TMP_InputField inputField_4; 
    public TMP_InputField inputField_5;
    // Part 9 10 11 12 13 14 15

    void Awake()
    {
        // Part 6 & 7
        inputObject_1 = GameObject.Find("InputField (TMP)");
        inputField_1 = inputObject_1.GetComponent<TMP_InputField>();

        inputObject_2 = GameObject.Find("InputField (TMP) (1)");
        inputField_2 = inputObject_2.GetComponent<TMP_InputField>();
        // Part 6 & 7

        // Part 8
        inputObject_3 = GameObject.Find("InputField (TMP) (2)");
        inputField_3 = inputObject_3.GetComponent<TMP_InputField>();
        // Part 8    

    }

    void Start()
    {
        // ToUpperFunction();
        // ToLowerFunction();
        // LengthFunction();
        // IndexFunction();
        // IndexFunction_1();
        // CountFunction();
        // ReplaceFunction();
        // RemoveFunction();
        // ReplaceAllFunction();
        // SubstringFunction();
        // SubstringSelectionFunction();
        // TrimFunction();
        // ParseFunction();
        // ToStringFunction();
        // Part1_Format();
        // Part2_Format();
        // Part3_Format();
        // Part4_Format();
        // Part5_Format();
        Part9_ServingSize();
        Part10_AccountBalance();
        Part11_DiscountedTicket();
        Part12_PlayerScore();
        Part13_AverageValue();
        Part14_AverageTemperature();
        Part15_StepCount();
    }

    void Update()
    {
        // InterpolationFunction();
        // ConcatenateFunction();
        // DurationFunction();
    }

    //Part 1
    //Create a program so that it concatenates three strings and then outputs the result in uppercase.
    //Hint: You can use the ToUpper() method to convert a string to uppercase.
    //Hint: You can use the Console.WriteLine() method to output the result.

    string name_1 = "Tui Ten Teo";

    void ToUpperFunction()
    {
        string result = name_1.ToUpper();
        Debug.Log(result);
    }

    //Part 2
    //Create a program so that it concatenates three strings and then outputs the result in lowercase.
    //Hint: You can use the ToLower() method to convert a string to lowercase.
    //Hint: You can use the Console.WriteLine() method to output the result.

    List<string> NameList = new List<string> { "Teo", "Koko", "AN", };

    private void ToLowerFunction()
    {
        foreach (string name in NameList)
        {
            string result_1 = name.ToLower();
            Debug.Log(result_1);
        }
    }

    //Part 3
    //Write a program to find the length of a string.
    //Hint: You can use the Length property to find the length of a string.
    //Hint: You can use the Console.WriteLine() method to output the result.

    public void LengthFunction()
    {
        string name_3 = "Teondsrglnmdbfgm,. lnfbgdl;kmbdfjnkldbfjnklohgher4346t5i89u3w4egtnuiojf";
        int result_3 = name_3.Length;

        Debug.Log(result_3);
    }

    //Part 4
    //Write a program to find the index of a character in a string.
    //Hint: You can use the IndexOf() method to find the index of a character in a string.
    //Hint: You can use the Console.WriteLine() method to output the result.

    private void IndexFunction()
    {
        string name_4 = "TeoKokoANjunberdtgnkghertrnikh";
        int result_4 = name_4.IndexOf("h");

        Debug.Log(result_4);
    }

    //Part 5
    //Write a program to find the index of a character in a string starting from a specified position.
    //Hint: You can use the IndexOf() method to find the index of a character in a string starting from a specified position.
    //Hint: You can use the Console.WriteLine() method to output the result.

    private void IndexFunction_1()
    {
        string name_5 = "werv kaasdn";
        int result_5 = name_5.IndexOf("a", 5);
        Debug.Log(result_5);

    }

    //Part 6
    //Write a program to count the occurrences of a specific character in a string.
    //Hint: You can use the Count() method to count the occurrences of a specific character in a string.
    //Hint: You can use the Console.WriteLine() method to output the result.

    private void CountFunction()
    {
        string name_6 = "reegwevefaseeceec";
        char targetChar = 'e';
        int count = 0;

        foreach (char c in name_6)
        {
            if (c == targetChar)
            {
                count++;
            }
        }

        Debug.Log(count);
    }

    //Part 7
    //Write a program to replace a character in a string with another character.
    //Hint: You can use the Replace() method to replace a character in a string with another character.
    //Hint: You can use the Console.WriteLine() method to output the result.

    private void ReplaceFunction()
    {
        string name_7 = "evwednkwe";
        string result_7 = name_7.Replace("e", "a");
        Debug.Log(result_7);
    }

    //Part 8
    //Write a program to remove a character from a string.
    //Hint: You can use the Remove() method to remove a character from a string.
    //Hint: You can use the Console.WriteLine() method to output the result.

    private void RemoveFunction()
    {
        string name_8 = "ascmaksc";

        int index = name_8.IndexOf('m');

        string result_8 = name_8.Remove(index, 1);
        // string result_8 = name_8.Remove(2,1);

        Debug.Log(result_8);
    }

    //Part 9
    //Write a program to replace all occurrences of a specific character in a string with another character.
    //Hint: You can use the Replace() method to remove all occurrences of a specific character from a string.
    //Hint: You can use the Console.WriteLine() method to output the result.

    private void ReplaceAllFunction()
    {
        string name_9 = "wrjkbngwergjkwnvqascnascwwwwwwiknvcwwwww";
        string result_9 = name_9.Replace("w", "A");
        Debug.Log(result_9);
    }

    //Part 10
    //Write a program to extract a substring from a string.
    //Hint: You can use the Substring() method to extract a substring from a string.
    //Hint: You can use the Console.WriteLine() method to output the result.

    private void SubstringFunction()
    {
        string name_10 = "wevjnwevw";

        int index = name_10.IndexOf('v');
        string result_10 = name_10.Substring(index, 1);

        // string result_11 = name_10.Substring(2);

        Debug.Log(result_10);
    }

    //Part 11
    //Write a program to extract a substring from a string starting from a specified position.
    //Hint: You can use the Substring() method to extract a substring from a string starting from a specified position.
    //Hint: You can use the Console.WriteLine() method to output the result.

    private void SubstringSelectionFunction()
    {
        string name_11 = "KeepThisPart_RemoveThisPart";
        int index = name_11.IndexOf("R");

        string result_11 = name_11.Substring(index, 14);

        Debug.Log(result_11);
    }

    //Part 12
    //Write a program to remove leading and trailing whitespace from a string.
    //Hint: You can use the Trim() method to remove leading and trailing whitespace from a string.
    //Hint: You can use the Console.WriteLine() method to output the result.

    private void TrimFunction()
    {
        string name_12 = "               Hello World                  ";

        string messy = name_12;

        string clean = name_12.Trim();

        Debug.Log(messy);
        Debug.Log(clean);
    }

    //Part 13 
    //Write a program to parse a string to a number.
    //Hint: You can use the Parse() method to parse a string to a number.
    //Hint: You can use the Console.WriteLine() method to output the result.

    public void ParseFunction()
    {
        string name_13 = "123";
        int.TryParse(name_13, out int result_13);
        Debug.Log(result_13);
    }

    //Part 14
    //Write a program to convert a number to a string.
    //Hint: You can use the ToString() method to convert a number to a string.
    //Hint: You can use the Console.WriteLine() method to output the result.

    private void ToStringFunction()
    {
        int number_14 = 123123;
        string result_14 = number_14.ToString();
        Debug.Log(result_14);
    }

    //////////////////Formating////////////////////

    // Part 1

    // You're organizing a team outing and need to print personalized event invitations.
    // Develop a C# program that uses placeholders to create customized invitations.
    // Replace the placeholders with the recipient's name, event date, and current time.
    // Hint: Use composite formatting with placeholders to create personalized invitations.
    // Test Data:
    // Recipient's name: Alice
    // Event date: January 15, 2025
    // Expected Output:
    // Hello, Alice! You're invited to our team outing on January 15, 2025. The event starts at 09:00.



    private void Part1_Format()
    {
        // 1. List of recipients
        List<string> recipients = new List<string> { "Alice", "Bob", "Charlie" };

        // 2. Static event date and time
        string eventDate = "January 15, 2025";
        string startTime = "09:00";

        // 3. Loop through recipients and send invitation
        foreach (string name in recipients)
        {
            string message = string.Format("Hello, {0}! You're invited to our team outing on {1}. The event starts at {2}.", name, eventDate, startTime);
            Debug.Log(message); // Print to Unity console
        }
    }




    // Part 2

    // Imagine you're managing an online store and need to send order confirmation emails.
    // Write a C# program that utilizes placeholders to generate order confirmation emails.
    // Fill in the placeholders with the customer's name, order ID, and purchase details.
    // Hint: Use composite formatting with placeholders to generate order confirmation emails.
    // Test Data:
    // Customer's name: John Doe
    // Order ID: 123456
    // Purchase details: 2 x T-shirts, 3 x Jeans
    // Expected Output:
    // Dear John Doe, your order (ID: 123456) has been confirmed. You've purchased: 2 x T-shirts, 3 x Jeans.


    private void Part2_Format()
    {
        string name = "John Doe";
        int orderId = 123456;
        string purchaseDetails = "2 x T-shirts, 3 x Jeans";
        string message = string.Format("Dear {0} \n Your order (ID: {1}) has been confirmed. \n You've purchased: {2} ", name, orderId, purchaseDetails);

        Debug.Log(message);
    }

    // Part 3

    // Picture yourself developing a task management application and need to display task reminders.
    // Create a C# program that employs placeholders to format task reminder messages.
    // Populate the placeholders with the task name, due date, and priority level.
    // Hint: Use composite formatting with placeholders to format task reminder messages.
    // Test Data:
    // Task name: Complete Project Proposal
    // Due date: May 10, 2025
    // Priority level: High
    // Expected Output:
    // Reminder: Complete Project Proposal is due on May 10, 2025. Priority: High.

    private void Part3_Format()
    {
        List<string> taskName = new List<string> { "CPP", "APP", "BPP" };
        List<string> dueDate = new List<string> { "May 10, 2025", "December 20, 2026", "April 15, 2027" };
        List<string> Priority = new List<string> { "High", "Mid", "Low" };

        for (int i = 0; i < taskName.Count; i++)
        {
            Injection(taskName[i], dueDate[i], Priority[i]);
        }
    }

    private void Injection(string task, string date, string priority)
    {
        string message = string.Format("Task Name: {0} Due Date {1} Priority Level {2}", task, date, priority);
        Debug.Log(message);
    }


    // Part 4

    // You're working on a scheduling application and need to generate event reminders.
    // Develop a C# program that utilizes placeholders to format event reminder notifications.
    // Fill in the placeholders with the event title, location, and start time.
    // Hint: Use composite formatting with placeholders to format event reminder notifications.
    // Test Data:
    // Event title: Team Meeting
    // Location: Conference Room A
    // Start time: 10:00 AM
    // Expected Output:
    // Reminder: Team Meeting at Conference Room A starts at 10:00 AM.

    private void Part4_Format()
    {
        List<string> EventTitle = new List<string> { "Team Meeting", "Manager Meeting", "Reward Ceremony" };
        List<string> Location = new List<string> { "Council", "TimeSquare", "Office" };
        List<int> StartTime = new List<int> { 10, 11, 12 };

        for (int i = 0; i < EventTitle.Count; i++)
        {
            Injection(EventTitle[i], Location[i], StartTime[i]);
        }
    }

    private void Injection(string title, string location, int time)
    {
        string message = string.Format("Even Tittle: {0} \n Location: {1} Start Time: {2} ", title, location, time);
        Debug.Log(message);
    }



    // Part 5

    // Imagine you're designing a travel app and need to provide flight departure information.
    // Write a C# program that employs placeholders to format flight departure notifications.
    // Populate the placeholders with the flight number, departure airport, and scheduled time.
    // Hint: Use composite formatting with placeholders to format flight departure notifications.
    // Test Data:
    // Flight number: ABC123
    // Departure airport: JFK International Airport
    // Scheduled time: 08:30 AM
    // Expected Output:
    // Flight ABC123 departing from JFK International Airport is scheduled for 08:30 AM.



    private void Part5_Format()
    {
        List<string> FlightNumber = new List<string> { "ABC123", "ASD234", "QWE567" };
        List<string> DepartureAirport = new List<string> { "JFK International Airport", "LAX International Airport", "Tan Son Nhat International Airport" };
        List<string> ScheduledTime = new List<string> { "08:30 AM", "09:45 PM", "4:55 AM" };

        for (int i = 0; i < FlightNumber.Count; i++)
        {
            Injection_1(FlightNumber[i], DepartureAirport[i], ScheduledTime[i]);
        }
    }

    private void Injection_1(string number, string location, string time)
    {
        string message = string.Format("Flight Number: {0} Departure Airport: {1} Scheduled Time: {2} ", number, location, time);
        Debug.Log(message);
    }



    // Part 6

    // You're developing a messaging application and want to greet the user.
    // Write a C# program that asks the user to enter their name.
    // Then, use interpolation to display a personalized greeting message.
    // Hint: Use the Console.ReadLine() method to get user input and string interpolation to format the message.
    // Test Data:
    // Enter your name: Alice
    // Expected Output:
    // Hello, Alice! Welcome to our messaging app.

    private TMP_InputField inputField_1;
    private TMP_InputField inputField_2;
    private string userText_1;
    private string userText_2;
    public void InterpolationFunction()
    {

        userText_1 = inputField_1.text;


        // if (Input.GetKeyDown(KeyCode.KeypadEnter))
        // {
        //     Debug.Log($"Hello {userText_1} Welcome to our messaging app ");
        // }

    }

    // Part 7

    // You're organizing a fantasy-themed event and need to print custom badges for the participants.
    // Develop a C# program that prompts the user to enter their character's name and class.
    // Then, concatenate the name and class, and print the result.
    // Hint: Use the + operator to concatenate strings and the Console.WriteLine() method to print the result.
    // Test Data:
    // Character's name: Legolas
    // Character's class: Archer
    // Expected Output:
    // Custom Badge: Legolas the Archer


    private void ConcatenateFunction()
    {
        userText_2 = inputField_2.text;
        string message = $"Character Name: {userText_1} Character Class: {userText_2}";

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log(message);

    }

    // Part 8

    // Picture yourself managing a music playlist and need to display the total duration of a song.
    // Write a C# program that calculates and formats the total duration of a song in minutes and seconds.
    // Prompt the user to enter the song's duration in seconds.
    // Then, calculate the minutes and seconds and display the formatted duration.
    // Hint: Use integer division and modulus to separate minutes and seconds, and composite formatting to display them.
    // Test Data:
    // Enter the song's duration in seconds: 245
    // Expected Output:
    // Song Duration: 4 minutes 5 seconds

    private TMP_InputField  inputField_3;
    private string userText_3;
    private void DurationFunction()
    {
        userText_3 = inputField_3.text;
        int.TryParse(userText_3, out int result_15);
        int minutes = result_15 / 60;
        int seconds = result_15 % 60;

        if (Input.GetKeyDown(KeyCode.Return))
        Debug.Log($"{minutes} minutes {seconds} seconds");
    }

    // Part 9

    // Imagine you're developing a recipe app and want to display the serving size.
    // Create a C# program that formats and displays the serving size of a recipe.
    // Prompt the user to enter the number of servings.
    // Then, display the serving size aligned to the right with a width of 5 characters.
    // Hint: Use composite formatting with alignment to display the serving size.
    // Test Data:
    // Enter the number of servings: 8
    // Expected Output:
    // Serving Size:     8


    public void Part9_ServingSize()
{
    if (int.TryParse(inputField_4.text, out int servings))
    {
        string message = $"Serving Size: {servings,5}";
        Debug.Log(message);
    }
}




    // Part 10

    // You're designing a finance application and need to show the current account balance.
    // Develop a C# program that formats and displays the account balance.
    // Prompt the user to enter the account balance.
    // Then, display the balance aligned to the right with two decimal places.
    // Hint: Use composite formatting with alignment and precision to display the account balance.
    // Test Data:
    // Enter the account balance: 1050.75
    // Expected Output:
    // Account Balance: 1050.75



public void Part10_AccountBalance()
{
    if (double.TryParse(inputField_4.text, out double balance))
    {
        string message = $"Account Balance: {balance,8:F2}";
        Debug.Log(message);
    }
}


    // Part 11

    // You're building a movie ticket booking system and need to present the ticket price.
    // Write a C# program that calculates and formats the ticket price with discounts.
    // Prompt the user to enter the ticket price and discount percentage.
    // Then, calculate the discounted price and display it aligned to the right with two decimal places.
    // Hint: Use composite formatting with alignment and precision to display the discounted price.
    // Test Data:
    // Enter the ticket price: 25.50
    // Enter the discount percentage: 15
    // Expected Output:
    // Discounted Price: 21.68

    public void Part11_DiscountedTicket()
{
    if (double.TryParse(inputField_4.text, out double price) &&
        double.TryParse(inputField_5.text, out double discount))
    {
        double discountedPrice = price - (price * discount / 100);
        string message = $"Discounted Price: {discountedPrice,6:F2}";
        Debug.Log(message);
    }
}


    // Part 12

    // Picture yourself developing a gaming platform and need to display the player's score.
    // Create a C# program that formats and displays the player's score.
    // Prompt the user to enter the player's score.
    // Then, display the score aligned to the right with a width of 8 characters.
    // Hint: Use composite formatting with alignment to display the player's score.
    // Test Data:
    // Enter the player's score: 10325
    // Expected Output:
    // Player's Score:   10325


    public void Part12_PlayerScore()
{
    if (int.TryParse(inputField_4.text, out int score))
    {
        string message = $"Player's Score: {score,8}";
        Debug.Log(message);
    }
}

    // Part 13

    // You're working on a data analysis tool and need to present the statistical results.
    // Develop a C# program that formats and displays the average value of a dataset.
    // Prompt the user to enter a series of numbers separated by spaces.
    // Then, calculate the average value and display it aligned to the right with two decimal places.
    // Hint: Use composite formatting with alignment and precision to display the average value.
    // Test Data:
    // Enter a series of numbers: 10 15 20 25 30
    // Expected Output:
    // Average Value: 20.00



public void Part13_AverageValue()
{
    string[] parts = inputField_4.text.Split(' ');
    double total = 0;
    int count = 0;

    foreach (string part in parts)
    {
        if (double.TryParse(part, out double number))
        {
            total += number;
            count++;
        }
    }

    if (count > 0)
    {
        double average = total / count;
        string message = $"Average Value: {average,6:F2}";
        Debug.Log(message);
    }
}

    // Part 14

    // Imagine you're designing a weather app and need to show the temperature forecast.
    // Write a C# program that calculates and formats the average temperature.
    // Prompt the user to enter the temperatures for three days separated by spaces.
    // Then, calculate the average temperature and display it aligned to the right with one decimal place.
    // Hint: Use composite formatting with alignment and precision to display the average temperature.
    // Test Data:
    // Enter temperatures for 3 days: 25.5 28.7 22.3
    // Expected Output:
    // Average Temperature: 25.5




public void Part14_AverageTemperature()
{
    string[] temps = inputField_4.text.Split(' ');
    if (temps.Length == 3 &&
        float.TryParse(temps[0], out float t1) &&
        float.TryParse(temps[1], out float t2) &&
        float.TryParse(temps[2], out float t3))
    {
        float average = (t1 + t2 + t3) / 3f;
        string message = $"Average Temperature: {average,5:F1}";
        Debug.Log(message);
    }
}
    // Part 15

    // You're building a fitness tracker and need to present the daily step count.
    // Create a C# program that formats and displays the total steps for a day.
    // Prompt the user to enter the steps taken.
    // Then, display the step count aligned to the right with a width of 6 characters.
    // Hint: Use composite formatting with alignment to display the step count.
    // Test Data:
    // Enter the steps taken: 12345
    // Expected Output:
    // Step Count:  12345



public void Part15_StepCount()
{
    if (int.TryParse(inputField_4.text, out int steps))
    {
        string message = $"Step Count: {steps,6}";
        Debug.Log(message);
    }
}




}
