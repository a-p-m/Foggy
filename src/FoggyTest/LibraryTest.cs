using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace FoggyTest
{
	[TestFixture]
	public class LibraryTest
	{
		[Test]
		public void TestRandom()
		{
			FoggyLib.Report r = new FoggyLib.Report();
			int x = r.GetRandom(1, 10);
			Assert.LessOrEqual(1, x);
			Assert.GreaterOrEqual(10, x);
		}

		[Test]
		public void TestReport()
		{
			FoggyLib.Report r = new FoggyLib.Report();

			string result = r.MakeReport(20, 2, 7);
			Assert.IsNotNullOrEmpty(result);
		}
	}
}
