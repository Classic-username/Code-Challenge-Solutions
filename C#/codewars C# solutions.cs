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
    // Code on you crazy diamond!
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

// Started



// Planned