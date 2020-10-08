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
          wList.Add(direction);
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
} // this was failing two tests Because I added east to east, and also west to east

// https://www.codewars.com/kata/5264d2b162488dc400000001/train/csharp

// Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

// Examples: spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" spinWords( "This is a test") => returns "This is a test" spinWords( "This is another test" )=> returns "This is rehtona test"

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    
    var words = "";

        foreach(var word in sentence.Split(' '))
        {
            if(word.Length >= 5)
            {
                var test = word.ToCharArray();
                Array.Reverse(test);
                var secondTest = new string (test);
                words += $"{secondTest} ";
            }
            else
            {
                words += $"{word} ";
            }
        }

        return words.TrimEnd(' ');
  }
}

// https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp

// Given an array of integers, find the one that appears an odd number of times.

// There will always be only one integer that appears an odd number of times.

using System.Linq;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
            int result = 0;
            foreach(var num in seq)
            {
                if(seq.Count(x => x == num) % 2 != 0)
                {
                    result = num;
                }
            }
            return result;
        }
       
    }
}

// https://www.codewars.com/kata/5544c7a5cb454edb3c000047/train/csharp

// A child is playing with a ball on the nth floor of a tall building. The height of this floor, h, is known.

// He drops the ball out of the window. The ball bounces (for example), to two-thirds of its height (a bounce of 0.66).

// His mother looks out of a window 1.5 meters from the ground.

// How many times will the mother see the ball pass in front of her window (including when it's falling and bouncing?

// Three conditions must be met for a valid experiment:
// Float parameter "h" in meters must be greater than 0
// Float parameter "bounce" must be greater than 0 and less than 1
// Float parameter "window" must be less than h.
// If all three conditions above are fulfilled, return a positive integer, otherwise return -1.

// Note:
// The ball can only be seen if the height of the rebounding ball is strictly greater than the window parameter.

public class BouncingBall {
	
	public static int bouncingBall(double h, double bounce, double window) {
		  // your code
    int bounceCount = -1;
	    if(h > window && 1 > bounce && bounce > 0)
      {
        bounceCount = 1;
        while(h * bounce > window){
          h = h * bounce;
          bounceCount += 2;
        }
        
      }
      return bounceCount;
	}
}

// Started

// Planned