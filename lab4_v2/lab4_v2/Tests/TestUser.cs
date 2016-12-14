using NUnit.Framework;
using System;

namespace lab4_v2
{
	[TestFixture ()]
	public class TestUser
	{
		const string name = "common_name";
		const string pass = "common_pass";
		const string app_name = "test_app";

		[Test ()]
		public void TestUserInit ()
		{
			User u1 = new User (name, pass);

			Assert.AreEqual (name, u1.Username);
		}

		[Test ()]
		public void TestUsersAreEqual()
		{
			User u1 = new User ("name1", "pass1");
			User u2 = new User ("name2", "pass2");

			Assert.AreEqual (u1, u2);
		}

		[Test ()]
		public void TestUsersEqualOperator()
		{
			User u1 = new User ("name1", "pass1");
			User u2 = new User ("name2", "pass2");

			Assert.IsTrue (u1 == u2);
		}

		[Test()]
		public void TestUsersNotEqualOperator()
		{
			User u1 = new User ("name1", "pass1");
			User u2 = new User ("name2", "pass2");

			Assert.IsFalse (u1 != u2);
		}

		[Test()]
		public void TestUsersAreNotEqual()
		{
			User u1 = new User (name, pass);
			User u2 = new User (name, pass);

			u2.AddApplication (app_name);

			Assert.AreNotEqual (u1, u2);
		}

		[Test()]
		public void TestUsersWithSameAppsEqual()
		{
			User u1 = new User (name, pass);
			User u2 = new User (name, pass);

			u1.AddApplication (app_name);
			u2.AddApplication (app_name);

			Assert.AreEqual (u1, u2);
		}

		[Test()]
		public void TestUsersWithAppsNotEqual()
		{
			User u1 = new User (name, pass);
			User u2 = new User (name, pass);

			u1.AddApplication ("test_app1");
			u2.AddApplication ("test_app2");

			Assert.AreNotEqual (u1, u2);
		}

		[Test()]
		public void TestUsersWithAppsNotEqualOperator()
		{
			User u1 = new User (name, pass);
			User u2 = new User (name, pass);

			u1.AddApplication ("test_app1");
			u2.AddApplication ("test_app2");

			Assert.IsTrue (u1 != u2);
		}

		[Test()]
		public void TestUserAuthSuccessful()
		{
			User u1 = new User (name, pass);

			Assert.IsTrue(u1.IsAuthSuccessful(pass));
		}

		[Test()]
		public void TestUserAuthUnsuccessful()
		{
			User u1 = new User (name, pass + " ");

			Assert.IsFalse(u1.IsAuthSuccessful(pass));
		}
	}
}

