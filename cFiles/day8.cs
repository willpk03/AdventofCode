using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
    int numbers = ReadNumbersFromFile("day8data2.txt");

// Print the number of duplicates
Console.WriteLine("The number of duplicates is: " + numbers);

int ReadNumbersFromFile(string filePath)
{
    List<int[]> lineArrays = new List<int[]>();
    int num = 0;
    int x = 0;
    try
    {
    

    string[] lines = File.ReadAllLines(filePath);
    foreach (string input in lines){ 
        if (string.IsNullOrEmpty(input))
            {
                break; 
            }

            int[] intArray = new int[input.Length];

            
            for (int i = 0; i < input.Length; i++)
            {
                intArray[i] = int.Parse(input[i].ToString());
            }
            
            
            lineArrays.Add(intArray);

        
    }
    int rowNum = 0;
   foreach (int[] array in lineArrays){
        Console.WriteLine("New ROW ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        for (int i = 0; i < array.Length; i++){
           
            if(rowNum == 0 || i == 0 || i == array.Length - 1 || rowNum == lineArrays.Count -1) {
                num++;
                Console.Write("Border (" + i + ", " + rowNum + ")");
            } else {
                Boolean checker = false;
                for(x=rowNum-1; x >= 0; x--) {
                    if(lineArrays[x][i] >= array[i]){
                        checker = true;
                        Console.Write(lineArrays[x][i]);
                    }

                }
                if(checker != true) {
                    num++;
                    Console.Write("row UP (" + i + ", " + rowNum + ")");
                }else{
                    checker = false;
                    for(x=i+1; x < array.Length; x++) {
                        if(array[x] >= array[i]){
                            checker = true;
                            Console.Write(array[x]);
                        }

                    }
                    if(checker != true) {
                        num++;
                        Console.Write("row RIGHT (" + i + ", " + rowNum + ")");
                    }else{
                        checker = false;
                        Console.Write("-");
                        for(x=rowNum+1; x <= lineArrays.Count; x++) {
                            Console.Write(lineArrays[x][i]);
                            if(lineArrays[x][i] >= array[i]){
                                checker = true;
                                Console.Write(lineArrays[x][i]);
                            }
                        }
                        if(checker != true) {
                            num++;
                            Console.Write("row Down (" + i + ", " + rowNum + ")");
                        }
                    }
                }
            }
             Console.WriteLine(array[i]);
            //Console.Write(i);
            //Console.Write(array[i] + " ");
        }
        rowNum++;
    }


    return num;
        
    

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