// Problem
// I have four different prime numbers all under 1000. I have noticed that the product of these primes is a
// twelve-digit number whose digits are either sequential in ascending order or the same as the previous digit
// so:
// 111233456678 is valid however:
// 113445566777, 998876554321, 112344556567 are not.

import { listOfPrimeNumsInRange, findListOfFourNumbers } from './utils.js';

// store time stamp 1
const date1 = new Date();

// Calculate prime numbers in smaller than 1000 and greater than 100.
// Note: Prime number has to be greater than 100 otherwise the product of nums can't be 12 digitals
const primeArray = listOfPrimeNumsInRange(100, 1000);
console.log('primeArray: ', primeArray);

// Find the numbers meet criteria in the prime numbers array
const listOfFourNumbers = findListOfFourNumbers(primeArray);
console.log('listOfFourNumbers: ', listOfFourNumbers);

// store time stamp 2
const date2 = new Date();

// calculateTime spent
const calculationTime = (date2.getTime() - date1.getTime()) / 1000;
console.log('Calculation Time:', calculationTime);

// listOfFourNumbers:  [ 167, 719, 953, 971 ]
// Calculation Time: 9.004
