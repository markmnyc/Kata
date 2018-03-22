using System;
using System.Collections.Generic;
using System.Text;

namespace Kata1
{
    public class Anagrams
    {
        public class Anagrams
        {
            public static List<string> Of(string s)
            {
                if (s.Length <= 1)
                    return new List<string> { s };
                var anagrams = new List<string>();
                for (var i = 0; i < s.Length; i++)
                {
                    var droppedCharacter = s.Substring(i, 1);
                    var anagramsOfRest = Anagrams.Of(DropCharacter(s, i));
                    foreach (var anagramOfRest in anagramsOfRest)
                        anagrams.Add(droppedCharacter + anagramOfRest);
                }
                return anagrams;
            }
            private static string DropCharacter(string s, int index)
            {
                return s.Substring(0, index) + s.Substring(index + 1, s.Length - (index + 1));
            }
        }

        public static string DropCharacter(string y, int index)
        {
            return y.Substring(0, index) +  y.Substring(index + 1, y.Length - (index + 1));
        }
    }
}
