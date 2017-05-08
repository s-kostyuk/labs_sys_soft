using NUnit.Framework;
using System;

namespace lab6_v8
{
	[TestFixture ()]
	public class TestController
	{
		private Controller controller;// = new Controller();

		public TestController() {
			this.controller = new Controller();
			this.controller.AddSampleData ();
		}

		[Test ()]
		public void TestCountByAuthorName ()
		{
			Assert.AreEqual(1, controller.BooksByAuthor("Henry Ford"));
		}

		[Test ()]
		public void TestCountByPublisherName ()
		{
			Assert.AreEqual(2, controller.BooksByPublisher("Addison-Wesley Professional"));
		}
	}
}

