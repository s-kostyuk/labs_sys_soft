using NUnit.Framework;
using System;

namespace lab4_v2
{
	[TestFixture ()]
	public class TestUser
	{
		[Test ()]
		public void TestUserInit ()
		{
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
			string name = "common_name";
			string pass = "common_pass";

			User u1 = new User (name, pass);
			User u2 = new User (name, pass);

			u2.AddProgram ("test_program");

			Assert.AreNotEqual (u1, u2);
		}

		[Test()]
		public void TestUsersWithSameProgramsEqual()
		{
			string name = "common_name";
			string pass = "common_pass";
			string program = "test_program";

			User u1 = new User (name, pass);
			User u2 = new User (name, pass);

			u1.AddProgram (program);
			u2.AddProgram (program);

			Assert.AreEqual (u1, u2);
		}

		[Test()]
		public void TestUsersWithDifferentProgramsNotEqual()
		{
			string name = "common_name";
			string pass = "common_pass";

			User u1 = new User (name, pass);
			User u2 = new User (name, pass);

			u1.AddProgram ("test_program1");
			u2.AddProgram ("test_program2");

			Assert.AreNotEqual (u1, u2);
		}

		[Test()]
		public void TestUsersWithDifferentProgramsNotEqualOperator()
		{
			string name = "common_name";
			string pass = "common_pass";

			User u1 = new User (name, pass);
			User u2 = new User (name, pass);

			u1.AddProgram ("test_program1");
			u2.AddProgram ("test_program2");

			Assert.IsTrue (u1 != u2);
		}
	}
}

