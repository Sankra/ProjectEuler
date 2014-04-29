using System;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectEulerCSharp {
//	A number chain is created by continuously adding the square of the digits in a number to form a new number until it has been seen before.
//
//	For example,
//
//	44 → 32 → 13 → 10 → 1 → 1
//	85 → 89 → 145 → 42 → 20 → 4 → 16 → 37 → 58 → 89
//
//	Therefore any chain that arrives at 1 or 89 will become stuck in an endless loop. What is most amazing is that EVERY starting number will eventually arrive at 1 or 89.
//
//	How many starting numbers below ten million will arrive at 89?
	public class Problem92 {
		public Problem92() {
		}

		// First try: 9.4536430s
		// Second try: 7.4951470s
		public string FindNumberOfChainsArrivingAt89ForNumbersBelow(int limit) {
			int n = 0;
			Parallel.For(2, limit, i => {
				if (NumberChainArrivesAt89(i)) {
					Interlocked.Increment(ref n);
				}
			});
			return n.ToString();
		}
		// For alle tall under 10 000 000
		// Hente siffer ut av tall
		// Opphøyd i andre og summer
		// Gjenta så lenge vi ikke har nådd 89

		// Hva om vi husker tall som har oppstått før?
		private static bool NumberChainArrivesAt89(int number) {
			while (true) {
				number = DigitizeAndSquare(number);
				if (number == 1) {
					return false;
				}

				if (number == 89) {
					return true;
				}
			}
		}

		private static int DigitizeAndSquare(int number) {
			var s = number.ToString();
			var squareOfDigits = 0;
			for(int i = 0; i < s.Length; ++i) {
				var digit = int.Parse(s[i].ToString());
				squareOfDigits += digit * digit;
			}

			return squareOfDigits;
		}
	}
}

