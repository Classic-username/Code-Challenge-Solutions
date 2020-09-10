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

