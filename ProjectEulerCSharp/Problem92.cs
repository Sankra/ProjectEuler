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

		public int FindNumberOfChainsArrivingAt89ForNumbersBelow(int limit) {
			int n = 0;
			Parallel.For(2, limit, i => {
				if (NumberChainArrivesAt89(i)) {
					Interlocked.Increment(ref n);
				}
			});
			return n;
		}
		// For alle tall under 10 000 000
		// Hente siffer ut av tall
		// Opphøyd i andre og summer
		// Gjenta så lenge vi ikke har nådd 89

		// Hva om vi husker tall som har oppstått før?
		private static bool NumberChainArrivesAt89(int number) {
			while (true) {
				var digits = Digitize(number);
				number = SquareOfDigits(digits);
				if (number == 1) {
					return false;
				}

				if (number == 89) {
					return true;
				}
			}
		}

		private static int[] Digitize(int number) {
			var s = number.ToString();
			var digits = new int[s.Length];
			for(int i = 0; i < s.Length; ++i) {
				digits[i] = int.Parse(s[i].ToString());
			}

			return digits;
		}

		private static int SquareOfDigits(int[] digits) {
			var squareOfDigits = 0;
			for(int i = 0; i < digits.Length; ++i) {
				squareOfDigits += digits[i] * digits[i];
			}

			return squareOfDigits;
		}
	}
}

