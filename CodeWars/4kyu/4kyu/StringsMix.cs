using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4kyu
{
    public class StringsMix
    {
        public string Mix(string s1, string s2)
        {
            if(s1 == s2) {
            	return "";
            }

			//get values where is lowerCase and letter and select with counter
			var lowLetters = (String.Concat(s1.Where(a => !Char.IsWhiteSpace(a))) + " " + String.Concat(s2.Where(b => !Char.IsWhiteSpace(b))))
			.Split(" ").Select(f => f.ToCharArray()
			.Where(g => g == Char.ToLower(g) && Char.IsLetter(g)))
			.Select(c => c.Select(d => new {
				Character = d,
				CharCount = c.Count(f => f == d)
			}).Distinct()
			.OrderByDescending(d => d.CharCount)
			.ThenBy(e => e.Character).Where(x => x.CharCount > 1).ToList()).ToArray();

			

			int mostCharCount = lowLetters[1].Count() == 0 ? lowLetters[0].Count() : lowLetters[0].Count() == 0 ? lowLetters[1].Count() :
			Math.Max(lowLetters[0][0].CharCount, lowLetters[1][0].CharCount);

			List<string> mixes = new List<string>();
			var builder = new StringBuilder();

			//build string through loop
			for (int i = mostCharCount; i >= 2; i--)
			{

				var firstarr = lowLetters[0].Where(d => (d.CharCount == i) &&
				lowLetters[1].Any(c => (c.Character == d.Character && d.CharCount > c.CharCount))
				);
				var concatFirst = firstarr.Concat(lowLetters[0].Where(d => d.CharCount == i && !lowLetters[1].Any(e => e.Character == d.Character)))
				.OrderBy(c => c.Character);
				
				foreach (var item in concatFirst)
				{
					mixes.Add(string.Concat($"1:{new string(item.Character, item.CharCount)}/"));
				}
				
				var secondarr = lowLetters[1].Where(d => (d.CharCount == i) &&
				lowLetters[0].Any(c => (c.Character == d.Character && d.CharCount > c.CharCount))
				);
				var concatSecond = secondarr.Concat(lowLetters[1].Where(d => d.CharCount == i && !lowLetters[0].Any(e => e.Character == d.Character)))
					.OrderBy(c => c.Character);
				foreach (var item in concatSecond)
				{
					mixes.Add(string.Concat($"2:{new string(item.Character, item.CharCount)}/"));
				}
				//concatSecond.Dump();
			}
			var equalValues = lowLetters[0].Where(d => lowLetters[1].Any(e => e.Character == d.Character && e.CharCount == d.CharCount));
			//equalValues.Dump();
			foreach (var item in equalValues)
			{
				mixes.Add(string.Concat($"=:{new string(item.Character, item.CharCount)}/"));
			}
			mixes = mixes.OrderByDescending(d => d.Length).ToList(); ;
			
			foreach (var item in mixes)
			{
				builder.Append(item);
			}

			return builder.ToString().Substring(0, builder.Length - 1);
		}
    }
}
