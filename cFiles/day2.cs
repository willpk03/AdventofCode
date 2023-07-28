using System;
using System.Collections.Generic;
using System.IO;

// Read the numbers from the file
List<int> numbers = ReadNumbersFromFile("day2data.txt");

// Find the largest number
//int largestNumber = FindLargestNumber(numbers);

// Print the largest number
Console.WriteLine("The largest number is: " + numbers.Sum());

List<int> ReadNumbersFromFile(string filePath)
{
    List<string> numbersWon = new List<string>();
    List<string> numbersLost = new List<string>();
    List<int> numbersPoints = new List<int>();

    try
    {
        string[] lines = File.ReadAllLines(filePath);
        int sumNum = 0;
        foreach (string line in lines)
        {
            string[] codes = line.Split(' ');
            numbersWon.Add(codes[1]);
            numbersLost.Add(codes[0]);
            Console.WriteLine(codes[0]);
            switch (codes[1]) {
                case "X": //lose
                    switch (codes[0]) {
                        case "A": //Rock 1
                            numbersPoints.Add(0 + 3);
                            Console.WriteLine(0+2);
                            break;
                        case "B": //Paper 2
                            numbersPoints.Add(0 + 1);
                            break;
                        case "C":
                            numbersPoints.Add(0 + 2);
                            break;
                    }
                    break;
                case "Y": //draw
                    switch (codes[0]) {
                        case "A":
                            numbersPoints.Add(3 + 1);
                            break;
                        case "B":
                            numbersPoints.Add(3 + 2);
                            break;
                        case "C":
                            numbersPoints.Add(3 + 3);
                            break;
                    }
                    break;
                case "Z": //Win
                    switch (codes[0]) {
                        case "A":
                            numbersPoints.Add(6 + 2);
                            break;
                        case "B":
                            numbersPoints.Add(6 + 3);
                            break;
                        case  "C":
                            numbersPoints.Add(6 + 1);
                            break;
                    }
                    break;
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

    return numbersPoints;
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