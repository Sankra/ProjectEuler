using System;
using ProjectEulerCSharp;
using NUnit.Framework;

namespace TestProjectEulerCSharp2 {
	[TestFixture]
	public class ProblemTests {
		[Test]
		public void Problem92() {
			var problem92 = new Problem92();
			SolveProblemAndPrintResults(() => problem92.FindNumberOfChainsArrivingAt89ForNumbersBelow(10000000));
		}

		[Test]
		public void Problem97() {
			var problem97 = new Problem97();
			SolveProblemAndPrintResults(problem97.GetTenLastDigits);
		}

		[Test]
		public void Problem52() {
			var problem52 = new Problem52();
			SolveProblemAndPrintResults(problem52.FindSmallestIntegerWhereMultiplesContainsSameDigits);
		}

		[Test]
		public void Problem17() {
			var problem17 = new Problem17();
			Assert.AreEqual("19", problem17.GetLettersFromNumbers(1, 5));
			Assert.AreEqual("23", problem17.GetLettersFromNumbers(342, 342));
			Assert.AreEqual("20", problem17.GetLettersFromNumbers(115, 115));
			SolveProblemAndPrintResults(() => problem17.GetLettersFromNumbers(1, 1000));
		}

		[Test]
		public void Problem19() {
			var problem19 = new Problem19();
			SolveProblemAndPrintResults(() => problem19.GetSundaysOnTheFirstOfTheMonth(new DateTime(1901, 1, 1), new DateTime(2000, 12, 31)));
		}

		[Test]
		public void Problem24() {
			var problem24 = new Problem24();
			Assert.AreEqual("210", problem24.GetNthLexicographicPermutation(new [] { 0,1,2 }, 6));
			SolveProblemAndPrintResults(() => problem24.GetNthLexicographicPermutation(new [] { 0,1,2,3,4,5,6,7,8,9 }, 999999));
		}

		private void SolveProblemAndPrintResults(Func<string> problem) {
			var start = DateTime.UtcNow;
			var result = problem();
			var end = DateTime.UtcNow;

			Console.WriteLine(result);
			Console.WriteLine("Duration: " + (end - start));
		}
	}
}

