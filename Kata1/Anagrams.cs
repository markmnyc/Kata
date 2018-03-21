using System;
using System.Collections.Generic;
using System.Text;

namespace Kata1
{
    public class Anagrams
    {
        public static List<string> Of(string s)
        {
            var anagrams = new List<string>();
            anagrams.Add(s.Substring(0, 1) + Anagrams.Of(DropCharacter(s, 0))[0]);
            anagrams.Add(s.Substring(0, 1) + Anagrams.Of(DropCharacter(s, 0))[1]);
            anagrams.Add(s.Substring(1, 1) + Anagrams.Of(DropCharacter(s, 1))[0]);
            anagrams.Add(s.Substring(1, 1) + Anagrams.Of(DropCharacter(s, 1))[1]);
            anagrams.Add(s.Substring(2, 1) + Anagrams.Of(DropCharacter(s, 2))[0]);
            anagrams.Add(s.Substring(2, 1) + Anagrams.Of(DropCharacter(s, 2))[1]);
            return anagrams;

            //if (s.Length <= 1)
            //{
            //    return new List<string> { s };
            //}
            //if (s.Length == 2)
            //{
            //    return new List<string> {
            //    s,
            //    s.Substring(1,1) + s.Substring(0,1)
            //    };
            //}
            //return new List<string>
            //{
            //   s.Substring(0,1) + Anagrams.Of(DropCharacter(s,0))[0],
            //   s.Substring(0,1) + Anagrams.Of(DropCharacter(s,0))[1],
            //   s.Substring(1,1) + Anagrams.Of(DropCharacter(s,1))[0],
            //   s.Substring(1,1) + Anagrams.Of(DropCharacter(s,1))[1],
            //   s.Substring(2,1) + Anagrams.Of(DropCharacter(s,2))[0],
            //   s.Substring(2,1) + Anagrams.Of(DropCharacter(s,2))[1]
            //};
        }

        public static string DropCharacter(string y, int index)
        {
            var before = y.Substring(0, index);
            var after = y.Substring(index + 1, y.Length - (index + 1));
            return before + after;
            //if (index == 0)
            //    return after;
            //if (index == 1)
            //    return before + after;
            //return before;
        }
    }
}
