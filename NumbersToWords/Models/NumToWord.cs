using System;
using System.Collections.Generic;


namespace NumbersToWords.Models
{
  public class NumToWord
  {
    private static Dictionary<char, string> _onesPlace = new Dictionary<char, string>()
    {
      {'0', ""},
      {'1', "one"},
      {'2', "two"},
      {'3', "three"},
      {'4', "four"},
      {'5', "five"},
      {'6', "six"},
      {'7', "seven"},
      {'8', "eight"},
      {'9', "nine"}
    };
    private static Dictionary<char, string> _teens = new Dictionary<char, string>()
    {
      {'0', "ten"},
      {'1', "eleven"},
      {'2', "twelve"},
      {'3', "thirteen"},
      {'4', "fourteen"},
      {'5', "fifteen"},
      {'6', "sixteen"},
      {'7', "seventeen"},
      {'8', "eighteen"},
      {'9', "nineteen"}
    };
    private static Dictionary<char, string> _tensPlace = new Dictionary<char, string>()
    {
      {'2', "twenty"},
      {'3', "thirty"},
      {'4', "forty"},
      {'5', "fifty"},
      {'6', "sixty"},
      {'7', "seventy"},
      {'8', "eighty"},
      {'9', "ninety"}
    };
    private static Dictionary<char, string> _hundredsPlace = new Dictionary<char, string>()
    {
      {'1', "one hundred"},
      {'2', "two hundred"},
      {'3', "three hundred"},
      {'4', "four hundred"},
      {'5', "five hundred"},
      {'6', "six hundred"},
      {'7', "seven hundred"},
      {'8', "eight hundred"},
      {'9', "nine hundred"}
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
      string chunkString = chunk.ToString();
      char onesDigit;
      char tensDigit;
      char hundredsDigit;
      string output = "";

      if (chunkString.Length == 3)
      {
        hundredsDigit = chunkString[0];
        tensDigit = chunkString[1];
        onesDigit = chunkString[2];
        output += _hundredsPlace[hundredsDigit] + " ";
        if (tensDigit == '0')
        {
          output += _onesPlace[onesDigit];
        }
        else if (tensDigit == '1')
        {
          output += _teens[onesDigit];
        }
        else
        {
          output += _tensPlace[tensDigit] + " " + _onesPlace[onesDigit];
        }
      }
      else if (chunkString.Length == 2)
      {
        tensDigit = chunkString[0];
        onesDigit = chunkString[1];
        if (tensDigit == '1')
        {
          output += _teens[onesDigit];
        }
        else
        {
          output += _tensPlace[tensDigit] + " " + _onesPlace[onesDigit];
        }
      }
      else
      {
        return _onesPlace[chunkString[0]];
      }
      return output;
    }

    public static string ChunkToWord(int chunk, string chunkName)
    {
      return ChunkToWord(chunk) + " " + chunkName;
    }

    public static string Convert(int number)
    {
      int[] chunks = NumberToChunks(number);
      foreach (int chunk in chunks)
      {
        ChunkToWord(chunk);
      }
      return "";
    }
  }
}