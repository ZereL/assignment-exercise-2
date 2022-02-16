namespace FourPrimeNums
{
	public class FindNumbers
	{
		/// List of Prime Numbers to find inside
		public List<int> _ListOfPrimeNumbers { get; }

		/// constractor to init properties
		/// <param name="ListOfPrimeNumbers">Pass in the numbers finding from when init the class</param>
		public FindNumbers(List<int> ListOfPrimeNumbers)
		{
			_ListOfPrimeNumbers = ListOfPrimeNumbers;
		}

		/// Find the four prime numbers in the list
		public List<int> GetFourPrimeNumbers()
		{
			var rst = new List<int>();

			for (int index1 = 0; index1 < _ListOfPrimeNumbers.Count; index1++)
			{
				int num1 = _ListOfPrimeNumbers[index1];
				for (int index2 = index1 + 1; index2 < _ListOfPrimeNumbers.Count; index2++)
				{
					int num2 = _ListOfPrimeNumbers[index2];
					for (int index3 = index2 + 1; index3 < _ListOfPrimeNumbers.Count; index3++)
					{
						int num3 = _ListOfPrimeNumbers[index3];
						for (int index4 = index3 + 1; index4 < _ListOfPrimeNumbers.Count; index4++)
						{
							int num4 = _ListOfPrimeNumbers[index4];

							long productOfPrimes = (long)num1 * num2 * num3 * num4;

							if (CheckIsNumMeetCriteria(productOfPrimes))
							{
								var fourPrimeNums = new List<int> { num1, num2, num3, num4 };
								rst.AddRange(fourPrimeNums);
								return rst;
							}

						}
					}
				}
			}
			// return empty array if not found 
			return rst;
		}

		/// Help to check if one number meet the criteria, if meet, it is the number to find
		private static bool CheckIsNumMeetCriteria(long num)
		{
			char[] numStringArr = num.ToString().ToCharArray();
			if (numStringArr.Length != 12)
			{
				return false;
			}

			for (int i = 1; i < numStringArr.Length; i++)
			{
				if (Convert.ToInt32(numStringArr[i]) < Convert.ToInt32(numStringArr[i - 1]))
				{
					return false;
				}
			}

			return true;
		}
	}
}