using System;
using System.Collections.Generic;
using System.IO;

int numbers = ReadNumbersFromFile("day4data.txt");

// Print the number of duplicates
Console.WriteLine("The number of duplicates is: " + numbers);

int ReadNumbersFromFile(string filePath)
{
    int numofdups = 0;

    try
    {
        string[] lines = File.ReadAllLines(filePath);
        
        foreach (string line in lines)
        {
            string input = line;
            Console.WriteLine(input);
            string[] result = input.Split(',');
            Console.WriteLine(result[0]);  
            string[] resulthalf1 = result[0].Split('-');
            string[] resulthalf2 = result[1].Split('-');
            if (int.Parse(resulthalf1[0]) >= int.Parse(resulthalf2[0]) && int.Parse(resulthalf1[0]) <= int.Parse(resulthalf2[1]) || int.Parse(resulthalf1[1]) <= int.Parse(resulthalf2[1]) && int.Parse(resulthalf1[1]) >= int.Parse(resulthalf2[0]) || int.Parse(resulthalf1[0]) <= int.Parse(resulthalf2[0]) && int.Parse(resulthalf1[1]) >= int.Parse(resulthalf2[0]))
            {
                numofdups++;
                Console.WriteLine("dupe");
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

    return numofdups;
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