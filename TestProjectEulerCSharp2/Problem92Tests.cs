using System;
using ProjectEulerCSharp;
using NUnit.Framework;

namespace TestProjectEulerCSharp2 {
	[TestFixture]
	public class Problem92Tests {
		[Test]
		public void Run() {
			var problem92 = new Problem92();

			var start = DateTime.UtcNow;
			var n = problem92.FindNumberOfChainsArrivingAt89ForNumbersBelow(10000000);
			var end = DateTime.UtcNow;

			Console.WriteLine(n);
			Console.WriteLine("Duration: " + (end - start));
		}
	}
}

