using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumToWord
  {
    private static Dictionary<int, string> _onesPlace = new Dictionary<int, string>();
    private static Dictionary<int, string> _teens = new Dictionary<int, string>();
    private static Dictionary<int, string> _tensPlace = new Dictionary<int, string>();
    private static Dictionary<int, string> _hundredsPlace = new Dictionary<int, string>();
    public NumToWord()
    {

    }
    
    private int[] NumberToChunks(int number)
    {
      return new int[1];
    }
    public string ChunkToWord(int chunk)
    {
      return "";
    }

    public string ChunkToWord(int chunk, string chunkName)
    {
      return ChunkToWord(chunk) + " " + chunkName;
    }
  }
}