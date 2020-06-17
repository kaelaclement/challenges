using System;

namespace challenges
{
	class Slices
	{
		public static bool EqualSlices(int slices, int recipients, int slicesEach)
		{
			int slicesNeeded = recipients * slicesEach;
			bool enough = slices >= slicesNeeded;
			if (enough)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}