using System;

namespace hard_to_throw_out
{
	public class MutableVersion
	{
		/**********************************************************************************/

		public MutableVersion ()
			: this(0, 0, 0, 0)
		{}

		public MutableVersion( int _major = 0, int _minor = 0, int _revision = 0, int _build = 0 ) {
			Major = _major;
			Minor = _minor;
			Revision = _revision;
			Build = _build;
		}

		/**********************************************************************************/

		private void CheckValue(int _value, string _value_name) {
			if (_value < 0) {
				throw new ArgumentOutOfRangeException (
					_value_name, 
					String.Format("{0} value can't be negative", _value_name)
				);
			}
		}

		/**********************************************************************************/

		int m_major;
		int m_minor;
		int m_revision;
		int m_build;

		/**********************************************************************************/

		public int Major {
			get {
				return m_major;
			}

			set {
				CheckValue (value, "Major");
				m_major = value;
			}
		}

		public int Minor {
			get {
				return m_minor;
			}

			set {
				CheckValue (value, "Minor");
				m_minor = value;
			}
		}

		public int Revision {
			get {
				return m_revision;
			}

			set {
				CheckValue (value, "Revision");
				m_revision = value;
			}
		}

		public int Build {
			get {
				return m_build;
			}

			set {
				CheckValue (value, "Build");
				m_build = value;
			}
		}

		/**********************************************************************************/

		public static bool operator == (MutableVersion _v1, MutableVersion _v2) {
			return _v1.Equals(_v2);
		}

		public static bool operator != (MutableVersion _v1, MutableVersion _v2) {
			return !( _v1 == _v2 );
		}

		public static bool operator  < (MutableVersion _v1, MutableVersion _v2) {
			if (_v1.Major < _v2.Major) {
				return true;
			}

			if (_v1.Minor < _v2.Minor) {
				return true;
			}

			if (_v1.Revision < _v2.Revision) {
				return true;
			}

			return (_v1.Build < _v2.Build);
		}

		public static bool operator  > (MutableVersion _v1, MutableVersion _v2) {
			return _v2 < _v1;
		}

		/**********************************************************************************/

		public override bool Equals (object _o)
		{
			MutableVersion p = _o as MutableVersion;

			return Equals (p);
		}

		public bool Equals (MutableVersion _p)
		{
			if ((object)_p == null) {
				return false;
			}

			return Major    == _p.Major
				&& Minor    == _p.Minor
				&& Revision == _p.Revision
				&& Build    == _p.Build;
		}

		/**********************************************************************************/

		public override string ToString ()
		{
			return string.Format ("{0}.{1}.{2}.{3}", Major, Minor, Revision, Build);
		}

		public override int GetHashCode ()
		{
			return base.GetHashCode ();
		}

		/**********************************************************************************/
	}


}

