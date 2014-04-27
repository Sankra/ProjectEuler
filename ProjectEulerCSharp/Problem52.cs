using System;
using System.Linq;

namespace ProjectEulerCSharp {
//	It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.
//
//	Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits.
	public class Problem52 {
		public Problem52() {
		}

		public int FindSmallestIntegerWhereMultiplesContainsSameDigits() {
			int i = 1;
			while (true) {
				if (ContainsSameDigits(i)) {
					return i;
				}

				++i;
			}
		}

		private bool ContainsSameDigits(int number) {
			var s = number.ToString();
			var digits = GetDigits(s);
			for(int i = 2; i < 7; i++) {
				var newNumber = number * i;
				var s2 = newNumber.ToString();
				if (digits.Length != s2.Length) {
					return false;
				}

				var digits2 = GetDigits(s2);
				for (int j = 0; j < digits.Length; j++) {
					if (!digits.Contains(digits2[j])) {
						return false;
					}
				}
			}

			return true;
		}

		private static int[] GetDigits(string s) {
			var digits = new int[s.Length];
			for(int i = 0; i < digits.Length; i++) {
				digits[i] = int.Parse(s[i].ToString());
			}
			return digits;
		}
	}
}

