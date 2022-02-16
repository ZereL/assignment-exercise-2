/**
 * Check a range of nubmers to see if number is prime number
 * return an array of prime numbers
 * @param {int} min - the min number of the range to check if prime number
 * @param {int} max- the max number of the range to check if prime number
 */
export const listOfPrimeNumsInRange = function (min, max) {
    let rstArr = [];
    for (let index = min; index < max; index++) {
        if (isPrime(index)) {
            rstArr.push(index);
        }
    }
    return rstArr;
};

/**
 * Check is one number to see if the number is prime number
 * return a boolean 
 * @param {int} num - the number to check if prime number
 */
function isPrime(num) {
    if ( num  <= 0 ) {
        return false; // handle edge case
    }

    if (num === 1) {
        return false; // 1 is not prime
    }

    for (let i = 2; i <= parseInt(Math.sqrt(num)); i++) {
        if (num % i === 0) {
            return false;
        }
    }

    return true;
}

/**
 * Find the numbers in array see if there are numbers meet criteria
 * return an array of the prime numbers meet criteria
 * @param {int} arr - the array to check if there are numbers meet criteria
 */
export const findListOfFourNumbers = function (arr) {
    let rstArr = [];
    for (let index1 = 0; index1 < arr.length; index1++) {
        const num1 = arr[index1];
        for (let index2 = index1 + 1; index2 < arr.length; index2++) {
            const num2 = arr[index2];
            for (let index3 = index2 + 1; index3 < arr.length; index3++) {
                const num3 = arr[index3];
                for (let index4 = index3 + 1; index4 < arr.length; index4++) {
                    const num4 = arr[index4];
                    const productOfPrimes = num1 * num2 * num3 * num4;
                    if (isNumMeetCriteria(productOfPrimes)) {
                        return (rstArr = [num1, num2, num3, num4]);
                    }
                }
            }
        }
    }
    // return empty array if not found 
    return rstArr;
};

/**
 * Find if product of the numbers meet criteria
 * return an boolean
 * @param {int} num - the num to check if meet criteria
 */
function isNumMeetCriteria(num) {
    // split string version of the number to array, sort the array and turn the array to string and compare if it is not changed.
    // also result need to be a 12 digit int
    if (num.toString().split('').sort().join('') == num.toString().split('').join('') && num.toString().length == 12) {
        return true;
    }
    return false;
}
