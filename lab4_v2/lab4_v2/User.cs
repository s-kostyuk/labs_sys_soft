using System;
using System.Collections.Generic;

namespace lab4_v2
{
	public class User
	{
		private string m_username;
		private string m_password;
		private HashSet<string> m_programs;

		public HashSet<string> programs {
			get {
				return m_programs;
			}
		}

		public User ()
		{
			m_programs = new HashSet<string>();
		}

		public User( string _username, string _password ) 
			: this() 
		{
			m_username = _username;
			m_password = _password;
		}

		public void AddProgram( string _program_name ) 
		{
			m_programs.Add( _program_name );
		}

		public static bool operator == (User _u1, User _u2) {
			return _u1.programs.SetEquals(_u2.programs);
		}

		public static bool operator != (User _u1, User _u2) {
			return !( _u1 == _u2 );
		}

		public override bool Equals (object obj)
		{
			return this == (User)obj;
		}

		public override int GetHashCode ()
		{
			return base.GetHashCode ();
		}
	}
}

