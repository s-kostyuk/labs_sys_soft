using System;
using System.Collections.Generic;

namespace lab4_v2
{
	public class User
	{
		
		/**********************************************************************************/

		private string m_username;
		private string m_password;
		private HashSet<string> m_apps;

		/**********************************************************************************/

		public HashSet<string> Apps {
			get {
				return m_apps;
			}
		}

		public string Username {
			get {
				return m_username;
			}
		}

		/**********************************************************************************/

		public User ()
		{
			m_apps = new HashSet<string>();
		}

		public User( string _username, string _password ) 
			: this() 
		{
			m_username = _username;
			m_password = _password;
		}

		/**********************************************************************************/

		public void AddApplication( string _program_id )
		{
			m_apps.Add( _program_id );
		}

		/**********************************************************************************/

		public bool IsAuthSuccessful( string _pass ) {
			return m_password == _pass;
		}

		/**********************************************************************************/

		public void ChangePassword( string _old_pass, string _new_pass ) {
			if (IsAuthSuccessful (_old_pass)) {
				m_password = _new_pass;
			} else {
				throw new UnauthorizedAccessException ("Invalid password");
			}
		}

		/**********************************************************************************/


		public static bool operator == (User _u1, User _u2) {
			return _u1.Equals(_u2);
		}

		public static bool operator != (User _u1, User _u2) {
			return !( _u1 == _u2 );
		}

		public override bool Equals (object obj)
		{
			User p = obj as User;

			return Equals (p);
		}

		// NOTE: Comparing of users by their apps instead of names is quite strange.
		// But thoose requiement is mentioned in lab's specification
		public bool Equals (User _p) {
			if ((object)_p == null) {
				return false;
			}

			return this.Apps.SetEquals(_p.Apps);
		}

		public override int GetHashCode ()
		{
			return base.GetHashCode ();
		}

		/**********************************************************************************/

	}
}

