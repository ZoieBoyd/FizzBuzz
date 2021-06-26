/*
Write a short program that prints each number from 1 to 100 on a new line. 

For each multiple of 3, print "Fizz" instead of the number. 

For each multiple of 5, print "Buzz" instead of the number. 

For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
*/

using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    for(int count = 1; count <= 100; count++)
    {
      if(count % 3 == 0 && count % 5 == 0)
      {
        Console.WriteLine("FizzBuzz");
      }
      else if(count % 3 == 0)
      {
        Console.WriteLine("Fizz");
      }
      else if(count % 5 == 0)
      {
        Console.WriteLine("Buzz");
      }
      else
      {
        Console.WriteLine(count);
      }
    }
  }
}