using System;
using System.Collections.Generic;

namespace oddOccurencesInArray
{
  class Program
  {
    static void Main(string[] args)
    {
      var list = new int[] { 9, 3, 9, 3, 9, 7, 9 };
      var result = solution(list);

      Console.WriteLine("Hello World!");
    }

    static int solution(int[] A)
    {
      var foundList = new Dictionary<int, int>();
      foreach (var number in A)
      {
        if (foundList.ContainsKey(number))
        {
          foundList[number] = foundList[number] + 1;
        }
        else
        {
          foundList[number] = 1;
        }
      }

      var result = -1;
      foreach (var item in foundList)
      {
        if (item.Value % 2 != 0)
        {
          result = item.Key;
          break;
        }
      }

      return result;
    }
  }
}
