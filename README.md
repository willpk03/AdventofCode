# Advent of Code

Advent of code is a 25 day event occuring each year with different Code problems to do. The days I entered were for the 2022 version. This will give you a simple explaination of each day and links to my code.

Advent of Code 2022: <a href="https://adventofcode.com/2022"> Click Here </a>

### Day 1
> Look at my code here: <a href=" https://github.com/willpk03/AdventofCode/blob/main/cFiles/day1.cs"> Day 1 </a>

Day 1 was calculating the Elf with the most Calories from a List similar to: 
  
    1000
    2000
    3000
    
    4000
    
    5000
    6000
    
    7000
    8000
    9000
    
    10000

The break between line representing when it begins tracking a new elf. 

This was the code I used to read the file of data to grab all the different Elfs and their Total Calories.
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
The code to then grab the Largest out of that list was done by using this function: 
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

> In the second part of the challenge the top three totals would need be grabbed and combined to get the total which would be the answer. 

# Day 2
For an indepth explaination I'd recommend reading through the <a href="https://adventofcode.com/2022/day/2"> Advent Of Code site </a>

The second day was to calculate your total score for a Rock Paper Sciccor Tournament if you were to follow a guide (the input). 

An example of how this input would look like is the following. 
    
    A Y
    B X
    C Z

> The first column was what the opponent would choose, and the Second was what you should choose.

I used the following function to parse through the input, 

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

### Day 3
The goal of day 3 is too analyze the input to grab letters (case sensitive) that appear in each half of the string.

> A indepth description can be found on the Advent of code website: <a href="https://adventofcode.com/2022/day/3"> Click Here</a>

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

### Day 4
The job for Day 4 were to analyze the inputs to get the range given a min and max and comparing it to another min and max to see if one range sits completely inside the other range. 

> A indepth description can be found on the Advent of code website: <a href="https://adventofcode.com/2022/day/4"> Click Here</a>

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
