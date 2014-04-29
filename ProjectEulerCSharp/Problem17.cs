using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectEulerCSharp {
	public class Problem17 {
//		If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
//
//			If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
//
//
//		NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
		private readonly Dictionary<int, int> lettersInNumbers;

		public Problem17() {
			lettersInNumbers = new Dictionary<int, int> {
				{ 1, 3 },
				{ 2, 3 },
				{ 3, 5 },
				{ 4, 4 },
				{ 5, 4 },
				{ 6, 3 },
				{ 7, 5 },
				{ 8, 5 },
				{ 9, 4 },
				{ 10, 3 },
				{ 11, 6 },
				{ 12, 6 },
				{ 13, 8 },
				{ 14, 8 },
				{ 15, 7 },
				{ 16, 7 },
				{ 17, 9 },
				{ 18, 8 },
				{ 19, 8 },
				{ 20, 6 },
				{ 30, 6 },
				{ 40, 5 },
				{ 50, 5 },
				{ 60, 5 },
				{ 70, 7 },
				{ 80, 6 },
				{ 90, 6 },
				{ 100, 7 },
				{ 1000, 8 },
			};
		}

		public string GetLettersFromNumbers(int start, int end) {
			int sum = 0;
			Parallel.For(start, end + 1, i => {
				Interlocked.Add(ref sum, GetLettersFromNumber(i));
			});
			return sum.ToString();
		}
			
		private int GetLettersFromNumber(int n) {
			var numberAsString = n.ToString();
			int sum = 0;
			bool stop = false;
			bool addedAnd = false;
			for (int i = 0; i < numberAsString.Length; ++i) {
				if (stop) {
					break;
				}
				var number = int.Parse(numberAsString[i].ToString());
				switch(-i + numberAsString.Length) {
					case 4:
						sum += lettersInNumbers[number] + lettersInNumbers[1000];
						break;
					case 3:
						if(number == 0) {
							break;
						}
						sum += lettersInNumbers[number] + lettersInNumbers[100];
						break;
					case 2:
						if(number == 0) {
							break;
						}
						if (numberAsString.Length > 2) {
							sum += 3;
							addedAnd = true;
						}
						if(number == 1) {
							number = int.Parse(numberAsString.Substring(numberAsString.Length - 2));
							sum += lettersInNumbers[number];
							stop = true;
							break;
						}
						sum += lettersInNumbers[number * 10];
						break;
					case 1:
						if(number == 0) {
							break;
						}
						if (numberAsString.Length > 2 && !addedAnd) {
							sum += 3;
						}
						sum += lettersInNumbers[number];
						break;
				}
			}
			return sum;
		}
	}
}

