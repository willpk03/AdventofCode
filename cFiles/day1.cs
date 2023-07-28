using System;
using System.Collections.Generic;
using System.IO;

// Read the numbers from the file
List<int> numbers = ReadNumbersFromFile("numbers.txt");

// Find the largest number
int largestNumber = FindLargestNumber(numbers);

// Print the largest number
Console.WriteLine("The largest number is: " + largestNumber);

List<int> ReadNumbersFromFile(string filePath)
{
    List<int> numbers = new List<int>();

    try
    {
        string[] lines = File.ReadAllLines(filePath);
        int sumNum = 0;
        foreach (string line in lines)
        {
            
            if(!String.IsNullOrEmpty(line)) {
                if (int.TryParse(line, out int number))
                    {
                        sumNum = number + sumNum;
                        Console.WriteLine(number);
                    }
            }else {
                numbers.Add(sumNum);
                sumNum = 0;
            }
        }
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("File not found: " + filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error reading file: " + ex.Message);
    }

    return numbers;
}

int FindLargestNumber(List<int> numbers)
{
    if (numbers == null || numbers.Count == 0)
    {
        throw new ArgumentException("The list is empty.");
    }

    int largest = numbers[0];

    foreach (int number in numbers)
    {
        if (number > largest)
        {
            largest = number;
        }
    }

    return largest;
}
