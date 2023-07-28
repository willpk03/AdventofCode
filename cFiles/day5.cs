using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

int numbers = ReadNumbersFromFile("day5data.txt");

// Print the number of duplicates
Console.WriteLine("The number of duplicates is: " + numbers);

int ReadNumbersFromFile(string filePath)
{
    int num = 0;
    
    try
    {
        string[] lines = File.ReadAllLines(filePath);
        Boolean checker = false;
        List<int> positions = new List<int>();
        foreach (string line in lines)
        {
            if(line.Contains("1")) {
                int pos = 0;
                foreach (char c in line)
                    {
                        pos++;
                        if(!char.IsWhiteSpace(c)){
                            Console.WriteLine(pos);
                            positions.Add(pos);
                        }
                        
                    }
                break;
            } else {
                num++;
            }
        }

        
        List<List<char>> towers = new List<List<char>>();

        for (int a = 0; a <= 9; a++)
        {
            List<char> newArray = new List<char>();
            towers.Add(newArray);
            Console.WriteLine(a);
        }
        Console.WriteLine(num);
        for(int i = 6; i >= 0; i--) {
            string input = lines[i];
            char[] characters = input.ToCharArray();
            int x = 0;
            foreach(int position in positions){
                Console.WriteLine(characters[position-1] + " (" + position + ")");
                if(!char.IsWhiteSpace(characters[position-1])){
                        towers[(position+2)/4].Add(characters[position-1]);
                        Console.WriteLine(position-1);
                } else {
                    Console.WriteLine("Blank space (" + position + ")");
                }
                
                x++;
            }
        }
        Console.WriteLine(num);
        for(int i = 1; i <= towers.Count - 1; i++){
            Console.WriteLine("Tower: " + i);
            for(int y = 0; y <= towers[i].Count -1; y++){
                Console.WriteLine(towers[i][y]);
            }
        }
        foreach (string line in lines)
        {
            int commandline = 0;
            if(line.Contains("move")){
                String text = line;
                
                // Define the regular expression pattern to match numbers
                string pattern = @"\d+";

                // Find all matches of the pattern in the text
                MatchCollection matches = Regex.Matches(text, pattern);

                // Extract the numbers and their order of appearance
                int[] numbers = new int[matches.Count];
                int index = 0;

                foreach (Match match in matches)
                {
                    if (int.TryParse(match.Value, out int number))
                    {
                        numbers[index] = number;
                        index++;
                    }
                }

                // Print the extracted numbers and their order of appearance
                
                Console.WriteLine("The extracted numbers are:");
                for (int i = 0; i < index; i++)
                {
                    Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
                    
                }
                
                int move = numbers[0];
                int from = numbers[1];
                int to = numbers[2];
                for(int i=1; i < move+1; i++) {
                    Console.WriteLine(towers[from].Count); 
                    towers[to].Add(towers[from][towers[from].Count - 1]);
                    towers[from].RemoveAt(towers[from].Count);
                    //Console.WriteLine(towers[to][towers[to].Count-1]);
                    
                }
            }
            
        }
        for(int i = 1; i <= towers.Count - 1; i++){
            Console.WriteLine("Tower: " + i);
            for(int y = 0; y <= towers[i].Count -1; y++){
                Console.WriteLine(towers[i][y]);
            }

            /*
        
            int commandline = 0;
            if(line.Contains("move")){
                char[] lineparts = line.ToCharArray();
                for (int i = 1; i <= lineparts.Length; i++) {
                    Boolean checker2 = false;
                    if(char.IsWhiteSpace(lineparts[i])){
                        Console.WriteLine(lineparts[i]);
                        int commandNum = 0;
                        while(commandline != 1) {
                            i++;
                            if(char.IsWhiteSpace(lineparts[i])){
                                checker2 = true;
                                Console.WriteLine(lineparts[i]+ "Number: " + commandNum);
                                commandline++;
                                commandNum = 0;
                            }else {
                                Console.WriteLine(commandNum + "Num " + lineparts[i]);
                                commandNum = commandNum * 10 + lineparts[i];
                                
                            }
                        }
                        Console.WriteLine("end" + i);
                    }
                }
            }
            */
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

    return num;
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