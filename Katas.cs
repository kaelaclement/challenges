using System;

/**
 * Write function isPalindrome that checks if a string (case insensitive) is a palindrome.
 *
 * Dad == true
 * Mum == true
 * Dean == false
*/

namespace challenges
{
	class Katas
	{
		public static void isPalindrome(string str)
		{
			char[] charArray = str.ToLower().ToCharArray();
			Array.Reverse(charArray);
			string reversed = string.Join("", charArray);
			Console.WriteLine(reversed == str.ToLower());
		}
	}
}