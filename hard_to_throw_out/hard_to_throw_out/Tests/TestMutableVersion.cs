using NUnit.Framework;
using System;

namespace hard_to_throw_out
{
	[TestFixture ()]
	public class TestMutableVersion
	{
		
		#region Test init validity

		[Test ()]
		public void TestDefaultConstructor ()
		{
			MutableVersion v = new MutableVersion ();

			Assert.AreEqual (0, v.Major);
			Assert.AreEqual (0, v.Minor);
			Assert.AreEqual (0, v.Revision);
			Assert.AreEqual (0, v.Build);
		}

		[Test ()]
		public void TestConstructorWith1Param ()
		{
			MutableVersion v = new MutableVersion (1);

			Assert.AreEqual (1, v.Major);
			Assert.AreEqual (0, v.Minor);
			Assert.AreEqual (0, v.Revision);
			Assert.AreEqual (0, v.Build);
		}

		[Test ()]
		public void TestConstructorWith2Params ()
		{
			MutableVersion v = new MutableVersion (1, 2);

			Assert.AreEqual (1, v.Major);
			Assert.AreEqual (2, v.Minor);
			Assert.AreEqual (0, v.Revision);
			Assert.AreEqual (0, v.Build);
		}

		[Test ()]
		public void TestConstructorWith3Params ()
		{
			MutableVersion v = new MutableVersion (1, 2, 3);

			Assert.AreEqual (1, v.Major);
			Assert.AreEqual (2, v.Minor);
			Assert.AreEqual (3, v.Revision);
			Assert.AreEqual (0, v.Build);
		}

		[Test ()]
		public void TestConstructorWithAllParams ()
		{
			MutableVersion v = new MutableVersion (1, 2, 3, 4);

			Assert.AreEqual (1, v.Major);
			Assert.AreEqual (2, v.Minor);
			Assert.AreEqual (3, v.Revision);
			Assert.AreEqual (4, v.Build);
		}

		#endregion

		#region Test constructor invariants

		[Test()]
		public void TestConstructorNegativeMajor()
		{
			Assert.That ( () => {
				new MutableVersion (-1, 2, 3, 4);
			},
				Throws.InstanceOf<ArgumentOutOfRangeException>()
			);
		}

		[Test()]
		public void TestConstructorNegativeMinor()
		{
			Assert.That ( () => {
				new MutableVersion (1, -2, 3, 4);
			},
				Throws.InstanceOf<ArgumentOutOfRangeException>()
			);
		}

		[Test()]
		public void TestConstructorNegativeRevision()
		{
			Assert.That ( () => {
				new MutableVersion (1, 2, -3, 4);
			},
				Throws.InstanceOf<ArgumentOutOfRangeException>()
			);
		}

		[Test()]
		public void TestConstructorNegativeBuild()
		{
			Assert.That ( () => {
				new MutableVersion (1, 2, 3, -4);
			},
				Throws.InstanceOf<ArgumentOutOfRangeException>()
			);
		}

		#endregion

		#region Test setters with valid params

		[Test()]
		public void TestSetMajor()
		{
			MutableVersion v = new MutableVersion ();

			v.Major = 100;

			Assert.AreEqual (100, v.Major);
		}

		[Test()]
		public void TestSetMinor()
		{
			MutableVersion v = new MutableVersion ();

			v.Minor = 100;

			Assert.AreEqual (100, v.Minor);
		}

		[Test()]
		public void TestSetRevision()
		{
			MutableVersion v = new MutableVersion ();

			v.Revision = 100;

			Assert.AreEqual (100, v.Revision);
		}

		[Test()]
		public void TestSetBuild()
		{
			MutableVersion v = new MutableVersion ();

			v.Build = 100;

			Assert.AreEqual (100, v.Build);
		}

		#endregion

		#region Test setters invariants

		[Test()]
		public void TestSetNegativeMajor()
		{
			MutableVersion v = new MutableVersion ();

			Assert.That ( () => {
				v.Major = -1;
			},
				Throws.InstanceOf<ArgumentOutOfRangeException>()
			);
		}

		[Test()]
		public void TestSetNegativeMinor()
		{
			MutableVersion v = new MutableVersion ();

			Assert.That ( () => {
				v.Minor = -1;
			},
				Throws.InstanceOf<ArgumentOutOfRangeException>()
			);
		}

		[Test()]
		public void TestSetNegativeRevision()
		{
			MutableVersion v = new MutableVersion ();

			Assert.That ( () => {
				v.Revision = -1;
			},
				Throws.InstanceOf<ArgumentOutOfRangeException>()
			);
		}

		[Test()]
		public void TestSetNegativeBuild()
		{
			MutableVersion v = new MutableVersion ();

			Assert.That ( () => {
				v.Build = -1;
			},
				Throws.InstanceOf<ArgumentOutOfRangeException>()
			);
		}

		#endregion

		[Test()]
		public void TestToString()
		{
			MutableVersion v = new MutableVersion (11, 0, 1, 22234);

			Assert.AreEqual ("11.0.1.22234", v.ToString());
		}
	}
}

