using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumToWord
  {
    private static Dictionary<int, string> _onesPlace = new Dictionary<int, string>()
    {
      {1, "one"},
      {2, "two"},
      {3, "three"},
      {4, "four"},
      {5, "five"},
      {6, "six"},
      {7, "seven"},
      {8, "eight"},
      {9, "nine"}
    };
    private static Dictionary<int, string> _teens = new Dictionary<int, string>()
    {
      {10, "ten"},
      {11, "eleven"},
      {12, "twelve"},
      {13, "thirteen"},
      {14, "fourteen"},
      {15, "fifteen"},
      {16, "sixteen"},
      {17, "seventeen"},
      {18, "eighteen"},
      {19, "nineteen"}
    };
    private static Dictionary<int, string> _tensPlace = new Dictionary<int, string>()
    {
      {20, "twenty"},
      {30, "thirty"},
      {40, "forty"},
      {50, "fifty"},
      {60, "sixty"},
      {70, "seventy"},
      {80, "eighty"},
      {90, "ninety"}
    };
    private static Dictionary<int, string> _hundredsPlace = new Dictionary<int, string>()
    {
      {100, "one hundred"},
      {200, "two hundred"},
      {300, "three hundred"},
      {400, "four hundred"},
      {500, "five hundred"},
      {600, "six hundred"},
      {700, "seven hundred"},
      {800, "eight hundred"},
      {900, "nine hundred"}
    };
    
  
    public NumToWord()
    {

    }

    public static int[] NumberToChunks(int number)
    {
      
      string numberString = number.ToString();
      int arraySize;
      int offset = numberString.Length % 3;
      if (offset == 0)
      {
        arraySize = numberString.Length / 3;
      }
      else
      {
        arraySize = numberString.Length / 3 + 1;
      }
      int[] result = new int[arraySize];

      string chunk;
      for (int i = 0; i < arraySize; i++)
      {
        if (i == 0 && offset != 0)
        {
          chunk = numberString.Substring(0, offset);
        }
        else if (offset != 0)
        {
          chunk = numberString.Substring((i-1)*3 + offset, 3);
        }
        else
        {
          chunk = numberString.Substring(i*3, 3);
        }
        result[i] = int.Parse(chunk);
      }
      return result;
    }

    public static string ChunkToWord(int chunk)
    {
      return "";
    }

    public static string ChunkToWord(int chunk, string chunkName)
    {
      return ChunkToWord(chunk) + " " + chunkName;
    }

    public static string Convert(int number)
    {
      return "";
    }
  }
}