namespace FourPrimeNums
{
	public class Helper
	{
		/// Helper to find List of prime numbers in a range
		/// <param name="min">Min number of the range</param>
		/// <param name="max">Max numbe of the range</param>
		public static List<int> ListOfPrimeNumsInRange(int min, int max)
		{
            var rst = new List<int>();
			for (int i = min; i < max; i++)
			{
				if (CheckIsPrime(i))
				{
                    rst.Add(i);
				}
			}
            return rst;
		}
		/// Helper to find if a number if a prime number
		/// <param name="num">number to check</param>
		private static bool CheckIsPrime(int num)
		{
			if (num <= 0)
			{
				return false; // handle edge case
			}

			if (num == 1)
			{
				return false; // 1 is not prime
			}

			// if number can be exact divided by a number from 2 to Math.Sqrt(num) then it is not a prime number  
			for (int i = 2; i < (int)Math.Sqrt(num); i++)
			{
				if (num % i == 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}