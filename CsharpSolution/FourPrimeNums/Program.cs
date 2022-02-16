// Problem
// I have four different prime numbers all under 1000. I have noticed that the product of these primes is a
// twelve-digit number whose digits are either sequential in ascending order or the same as the previous digit
// so:
// 111233456678 is valid however:
// 113445566777, 998876554321, 112344556567 are not.

using FourPrimeNums;

// store time stamp 1
DateTime dt1 = DateTime.UtcNow;

// Calculate prime numbers in smaller than 1000 and greater than 100.
// Note: Prime number has to be greater than 100 otherwise the product of nums can't be 12 digitals
List<int> primes = Helper.ListOfPrimeNumsInRange(100, 1000);

// Find the numbers meet criteria in the prime numbers array
var findNums = new FindNumbers(primes);
List<int> result = findNums.GetFourPrimeNumbers();

foreach (int num in result)
{
	Console.WriteLine("result :" + num);
}

// store time stamp 2
var dt2 = DateTime.UtcNow;

// calculateTime spent
var calculatTime = dt2 - dt1;
Console.WriteLine("Calculation Time:" + calculatTime.TotalSeconds);

// result :167
// result :719
// result :953
// result :971
// Calculation Time:0.432615
