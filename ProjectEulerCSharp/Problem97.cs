using System;
using System.Numerics;

namespace ProjectEulerCSharp {
	public class Problem97 {
//		The first known prime found to exceed one million digits was discovered in 1999, and is a Mersenne prime of the form 26972593−1; it contains exactly 2,098,960 digits. Subsequently other Mersenne primes, of the form 2p−1, have been found which contain more digits.
//
//		However, in 2004 there was found a massive non-Mersenne prime which contains 2,357,207 digits: 28433×27830457+1.
//
//		Find the last ten digits of this prime number.
		public Problem97() {
		}

		public string GetTenLastDigits() {
			var first = new BigInteger(28433);
			var second = BigInteger.Pow(2, 7830457);
			var number = first * second + new BigInteger(1D);
			var numberAsString = number.ToString();
			 

			return numberAsString;
		}
	}
}

