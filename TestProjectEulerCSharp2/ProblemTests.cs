using System;
using ProjectEulerCSharp;
using NUnit.Framework;

namespace TestProjectEulerCSharp2 {
	[TestFixture]
	public class ProblemTests {
		[Test]
		public void Problem92() {
			var problem92 = new Problem92();

			var start = DateTime.UtcNow;
			var n = problem92.FindNumberOfChainsArrivingAt89ForNumbersBelow(10000000);
			var end = DateTime.UtcNow;

			Console.WriteLine(n);
			Console.WriteLine("Duration: " + (end - start));
		}

		[Test]
		public void Problem97() {
			var problem97 = new Problem97();

			var start = DateTime.UtcNow;
			var lastDigits = problem97.GetTenLastDigits();
			var end = DateTime.UtcNow;

			Console.WriteLine(lastDigits);
			Console.WriteLine("Duration: " + (end - start));
		}

		[Test]
		public void Problem52() {
			var problem52 = new Problem52();

			var start = DateTime.UtcNow;
			var smallest = problem52.FindSmallestIntegerWhereMultiplesContainsSameDigits();
			var end = DateTime.UtcNow;

			Console.WriteLine(smallest);
			Console.WriteLine("Duration: " + (end - start));
		}
	}
}

