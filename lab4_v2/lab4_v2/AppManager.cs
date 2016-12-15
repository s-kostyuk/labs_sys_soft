using System;
using System.Collections.Generic;

namespace lab4_v2
{
	public class AppManager
	{
		/**********************************************************************************/

		public AppManager ()
		{

		}

		/**********************************************************************************/

		private Dictionary<string, Application> m_apps;
		private Dictionary<string, User> m_users;
		private ComputerInfo m_comp_info;

		/**********************************************************************************/

		public ComputerInfo ComputerInfo {
			get { return m_comp_info; }
			set { m_comp_info = value; }
		}

		/**********************************************************************************/

		public void AllowUsage( string _app_id, string _username ) {
			User u1 = m_users [_username];

			if (! m_apps.ContainsKey(_app_id)) {
				throw new ArgumentException ();
			}

			u1.AddApplication (_app_id);
		}

		/**********************************************************************************/

		public void DenyUsage( string _app_id, string _username ) {
			User u1 = m_users [_username];

			u1.Apps.Remove (_app_id);
		}

		/**********************************************************************************/

		public bool AreUsersEqual(string _username1, string _username2 ) {
			User u1 = m_users [_username1];
			User u2 = m_users [_username2];

			return u1.Equals (u2);
		}

		/**********************************************************************************/

		public void AddApplication () {
			throw new NotImplementedException ();
		}

		/**********************************************************************************/

		public void UpdateApplication( string _app_id ) {
			Application app = m_apps [_app_id];

			app.Update ();
		}

		/**********************************************************************************/

		public void RemoveApplication( string _app_id ) {
			m_apps.Remove (_app_id);
		}

		/**********************************************************************************/

		public void AddUser () {
			throw new NotImplementedException ();
		}

		/**********************************************************************************/

		public void RemoveUser( string _username ) {
			m_users.Remove (_username);
		}

		/**********************************************************************************/

		public void ChangeOSVersion() {
			throw new NotImplementedException ();
		}

		/**********************************************************************************/

		public void ChangeComputerInfo() {
			throw new NotImplementedException ();
		}

		/**********************************************************************************/

		public void RemoveAllUsers() {
			throw new NotImplementedException ();
		}

		/**********************************************************************************/

		public void RemoveAllApps() {
			throw new NotImplementedException ();
		}

		/**********************************************************************************/

	}
}

