using System;

/*
*	Create a function that takes a string as an argument and returns a coded (h4ck3r *	5p34k) version of the string.
*	Examples
*	HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"
*	HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"
*	HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
*	Notes
*	In order to work properly, the function should replace all "a"s with 4, "e"s with *		3, "i"s with 1, "o"s with 0, and "s"s with 5.
*/

namespace challenges
{
	class Speak
	{
		public static string HackerSpeak(string str)
		{
			char[] charArray = str.ToCharArray();
			char[] newSentence = new char[charArray.Length];
			for (int i = 0; i < charArray.Length; i++)
			{
				char currentLetter;

				switch (charArray[i])
				{
					case 'a':
						currentLetter = '4';
						break;
					case 'e':
						currentLetter = '3';
						break;
					case 'i':
						currentLetter = '1';
						break;
					case 'o':
						currentLetter = '0';
						break;
					case 's':
						currentLetter = '5';
						break;
					default:
						currentLetter = charArray[i];
						break;
				}
				newSentence[i] = currentLetter;
			}
			return string.Join("", newSentence);
		}
	}
}