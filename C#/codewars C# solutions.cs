// Completed

// https://www.codewars.com/kata/571d42206414b103dc0006a1/train/csharp

// We want an array, but not just any old array, an array with contents!

// Write a function that produces an array with the numbers 0 to N-1 in it.

// For example, the following code will result in an array containing the numbers 0 to 4:

// arr(5) // => [0,1,2,3,4]

using System.Collections.Generic;

public class Kata
{
  public static int[] Arr(int N)
  {
    if(N == 0){
      return new int[]{};
    };
    var intList = new List<int>();
    while(N != 0){
      N = N -1;
      intList.Add(N);
    }
    intList.Reverse();
    return intList.ToArray();  
  }
}


// https://www.codewars.com/kata/54ba84be607a92aa900000f1/train/csharp

// An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

// isIsogram "Dermatoglyphics" == true
// isIsogram "aba" == false
// isIsogram "moOse" == false -- ignore letter case

using System;
using System.Collections.Generic;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    if(str == null){
      return true;
    } else {
      var strList = new List<string>();
      str = str.ToLower();
      foreach(char c in str){
        if(strList.Contains(c.ToString())){
          return false;
        } else {
          strList.Add(c.ToString());
        }
      }
      return true;
    }
  }
}

// https://www.codewars.com/kata/554e4a2f232cdd87d9000038/train/csharp

// Deoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.

// If you want to know more http://en.wikipedia.org/wiki/DNA

// In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". You have a function with one side of the DNA (string, except for Haskell); you need to get the other complementary side. DNA strand is never empty or there is no DNA at all (again, except for Haskell).

// More similar exercise are found here http://rosalind.info/problems/list-view/ (source)

// MakeComplement("ATTGC") => "TAACG"

// MakeComplement("GTAT") => "CATA"

public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
          var newString = "";
          foreach(var letter in dna){
            if(letter == 'A')
            {
              newString += "T";
            } else if(letter == 'T')
            {
              newString += "A";
            } else if(letter == 'G')
            {
              newString += "C";
            } else if(letter == 'C')
            {
              newString += "G";
            }
          }
          return newString;
        }
    }
    
// https://www.codewars.com/kata/55b42574ff091733d900002f/train/csharp

// Make a program that filters a list of strings and returns a list with only your friends name in it.

// If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...

// Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]

// i.e.

// friend ["Ryan", "Kieran", "Mark"] `shouldBe` ["Ryan", "Mark"]

using System;
using System.Collections.Generic;

public static class Kata {
  public static IEnumerable<string> FriendOrFoe (string[] names) {
    var friendList = new List<string>();
    foreach(string friend in names)
    {
      if(friend.Length == 4)
      {
        friendList.Add(friend);
      }
    }
    return friendList;
  }
}

// https://www.codewars.com/kata/54da539698b8a2ad76000228/train/csharp

// You live in the city of Cartesia where all roads are laid out in a perfect grid. You arrived ten minutes too early to an appointment, so you decided to take the opportunity to go for a short walk. The city provides its citizens with a Walk Generating App on their phones -- everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block, so create a function that will return true if the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!) and will, of course, return you to your starting point. Return false otherwise.

// Note: you will always receive a valid array containing a random assortment of direction letters ('n', 's', 'e', or 'w' only). It will never give you an empty array (that's not a walk, that's standing still!).

using System.Collections.Generic;

public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    var nList = new List<string>();
    var eList = new List<string>();
    var sList = new List<string>();
    var wList = new List<string>();
    if(walk.Length == 10)
    {
      foreach(string direction in walk)
      {
        if(direction == "n")
        {
          nList.Add(direction);
        } else if(direction == "e")
        {
          eList.Add(direction);
        } else if(direction == "s")
        {
          sList.Add(direction);
        } else
        {
          eList.Add(direction);
        }
      }
      if(nList.Count == sList.Count && eList.Count == wList.Count)
      {
        return true;
      } else 
      {
        return false;
      }
    } else {
      return false;
    }
  }
} // this was failing two tests but I couldn't see the inputs or outputs to resolve and couldn't think of a reason it was failing

// Started

// Planned