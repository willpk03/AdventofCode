using System;
using System.Collections.Generic;
using System.Linq;

    
        List<char> charList = new List<char> { 'a', 'b', 'c', 'd', 'e', 'a' };
        char targetCharacter = 'a';

        int occurrences = CountCharacterOccurrences(charList, targetCharacter);
        Console.WriteLine($"The character '{targetCharacter}' appears {occurrences} times in the list.");
    

    int CountCharacterOccurrences(List<char> charList, char character)
    {
        return charList.Count(c => c == character);
    }