using System;
using System.Collections.Generic;
using System.IO;

// Read the numbers from the file
List<int> numbers = ReadNumbersFromFile("day3data.txt");

// Find the largest number
//int largestNumber = FindLargestNumber(numbers);

// Print the largest number
Console.WriteLine("The largest number is: " + numbers.Sum());

List<int> ReadNumbersFromFile(string filePath)
{
    List<int> numbersWon = new List<int>();

    try
    {
        string[] lines = File.ReadAllLines(filePath);
        int sumNum = 0;
        string firstHalf= "";
        string secondHalf = "";
        foreach (string line in lines)
        {
            Console.WriteLine("Line" + sumNum);
            string input = line;
            sumNum = sumNum + 1;
            if(sumNum == 1) {
                    firstHalf = input;
            }else if(sumNum == 2) {
                    secondHalf = input;
            }else{
                Console.WriteLine(input);
                sumNum = 0;
            foreach (Char c in firstHalf) {
                Boolean checker = secondHalf.Contains(c.ToString());
                if(checker == true) {
                    Boolean checker2 = input.Contains(c.ToString());
                    if(checker2 == true) {
                        Console.WriteLine(c);
                        Char tempChar = 'A';
                        if((int) c - 96 > 0) {//Lower case
                            numbersWon.Add((int)c - 96);
                            Console.WriteLine((int)c - 96);
                        } else {
                            numbersWon.Add((int)c - 64 + 26); //Uppercase
                            Console.WriteLine((int)c- 64 + 26);
                        }
                        break;
                    }
                        
                    
                }
            }
            }
            
        }
        return numbersWon;
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("File not found: " + filePath);
    }
    catch (Exception  ex)
    {
        Console.WriteLine("Error reading file: " + ex.Message);
    }

    return numbersWon;
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