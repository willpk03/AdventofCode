using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

int numbers = ReadNumbersFromFile("day6data.txt");

// Print the number of duplicates
Console.WriteLine("The number of duplicates is: " + numbers);
 int CountCharacterOccurrences(List<char> charList, char character)
    {
        return charList.Count(c => c == character);
    }
int FindFirstNonRepeatingGroup(string input, int numCharacters)
    {
        if (numCharacters < 2 || numCharacters > input.Length)
        {
            throw new ArgumentException("Invalid number of characters to check.");
        }

        for (int i = 0; i <= input.Length - numCharacters; i++)
        {
            bool hasRepeats = false;
            for (int j = 0; j < numCharacters - 1; j++)
            {
                for (int k = j + 1; k < numCharacters; k++)
                {
                    if (input[i + j] == input[i + k])
                    {
                        hasRepeats = true;
                        break;
                    }
                }
                if (hasRepeats)
                    break;
            }

            if (!hasRepeats)
            {
                return i + numCharacters;
            }
        }

        return -1;
    }
int ReadNumbersFromFile(string filePath)
{
    
    int num = 0;
    int x = 0;
    try
    {
    
    List<char> characters = new List<char>();
    string[] lines = File.ReadAllLines(filePath);
    foreach (string input in lines){ 
        Console.WriteLine(FindFirstNonRepeatingGroup(input, 14));
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
     return x;
}

/*
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
            rdlargest = ndlargest;
            ndlargest = largest;
            largest = number;
        }
    }
    sumgroup = rdlargest + ndlargest + largest;
    Console.WriteLine(" 1st:" + largest + " 2nd:" + ndlargest + " 3rd:" + rdlargest + " Sum:" + sumgroup);
    return largest;
}
*/