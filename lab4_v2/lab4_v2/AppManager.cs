using System;
using System.Collections.Generic;

namespace lab4_v2
{
    //--------------------------------------------------------------------------------------

    public class NewElementEventArgs : EventArgs
    {
        public NewElementEventArgs(string _new_element_name)
        {
            NewElementName = _new_element_name;
        }

        public string NewElementName { get; private set; }
    }

    //--------------------------------------------------------------------------------------

    public class AppManager
	{
		/**********************************************************************************/

		public AppManager ()
			: this(new ComputerInfo())
		{}

		/**********************************************************************************/

		public AppManager (ComputerInfo _info) {
			m_apps = new SortedDictionary<string, App>();
			m_users = new SortedDictionary<string, User> ();
			m_comp_info = _info;
			m_ram_usage = new Dictionary<string, double> ();
		}

		/**********************************************************************************/

		private SortedDictionary<string, App> m_apps;
		private SortedDictionary<string, User> m_users;
		private ComputerInfo m_comp_info;
		private Dictionary<string, double> m_ram_usage;

        /**********************************************************************************/

        public SortedDictionary<string, App> Apps
        {
            get
            {
                return m_apps;
            }
        }

        /**********************************************************************************/

        public SortedDictionary<string, User> Users
        {
            get
            {
                return m_users;
            }
        }

        /**********************************************************************************/

        public ComputerInfo ComputerInfo {
			get { return m_comp_info; }
			set
            {
                m_comp_info = value;
                OnSomeChange(ComputerInfoUpdated);
            }
		}

		/**********************************************************************************/

		public event EventHandler AllAppsRemoved;
		public event EventHandler AllUsersRemoved;
        public event EventHandler ComputerInfoUpdated;
        public event EventHandler<NewElementEventArgs> NewUserAdded;
        public event EventHandler<NewElementEventArgs> NewAppAdded;

        /**********************************************************************************/

        protected virtual void OnSomeChange(EventHandler _handler)
        {
            if (_handler != null)
            {
                _handler(this, EventArgs.Empty);
            }
        }

        protected virtual void OnNewUserAdded(string _new_username)
        {
            if (NewUserAdded != null)
            {
                NewElementEventArgs args = new NewElementEventArgs(_new_username);
                NewUserAdded(this, args);
            }
        }

        protected virtual void OnNewAppAdded(string _new_app_name)
        {
            if (NewAppAdded != null)
            {
                NewElementEventArgs args = new NewElementEventArgs(_new_app_name);
                NewAppAdded(this, args);
            }
        }

        /**********************************************************************************/

        public void AllowUsage (string _app_id, string _username)
		{
			User u1 = m_users [_username];
			App app;

			if (!m_apps.TryGetValue (_app_id, out app)) {
				throw new ArgumentException ("Unable to find an app with such id");
			}

			if (app.MinRequirements > m_comp_info) {
				throw new ArgumentException ("Unsatisfied system requirements");
			}

			double target_ram_usage = m_ram_usage [_username];
			target_ram_usage += app.MinRequirements.RamCapacity;

			if (target_ram_usage > m_comp_info.RamCapacity) {
				throw new ArgumentException ("Not enough RAM left");
			}

			u1.AddApplication (_app_id);
		}

		/**********************************************************************************/

		public void DenyUsage (string _app_id, string _username)
		{
			User u1 = m_users [_username];
			App app = m_apps [_app_id];

			u1.Apps.Remove (_app_id);

			m_ram_usage [_username] -= app.MinRequirements.RamCapacity;
		}

		/**********************************************************************************/

		public bool AreUsersEqual (string _username1, string _username2)
		{
			User u1 = m_users [_username1];
			User u2 = m_users [_username2];

			return u1.Equals (u2);
		}

		/**********************************************************************************/

		public void AddApplication (App _app)
		{
			m_apps.Add (_app.FullName, _app);

            OnNewAppAdded(_app.FullName);
		}

		/**********************************************************************************/

		public void UpdateApplication (string _app_id)
		{
			App app = m_apps [_app_id];

			app.Update ();
		}

		/**********************************************************************************/

		public App GetApplication (string _app_id)
		{
            //App returned;
            //m_apps.TryGetValue(_app_id, out returned);

            //return returned;

            return m_apps[_app_id];
        }

		/**********************************************************************************/

		public void RemoveApplication (string _app_id)
		{
			m_apps.Remove (_app_id);

			if (m_apps.Count == 0) {
				OnSomeChange (AllAppsRemoved);
			}
		}

		/**********************************************************************************/

		public void AddUser (string _username, string _password)
		{
			AddUser (new User (_username, _password));
		}

		/**********************************************************************************/

		public void AddUser (User _u)
		{
            m_users.Add (_u.Username, _u);
			m_ram_usage.Add (_u.Username, 0);

            OnNewUserAdded(_u.Username);
        }

		/**********************************************************************************/

        public void RemoveUser (string _username)
		{
			m_users.Remove (_username);
			m_ram_usage.Remove (_username);

			if (m_users.Count == 0) {
                OnSomeChange(AllUsersRemoved);
            }
		}

		/**********************************************************************************/

		public void ChangeUserPassword (string _username, string _old_pass, string _new_pass)
		{
			User u = m_users [_username];

			u.ChangePassword (_old_pass, _new_pass);
		}

		/**********************************************************************************/

		public void ChangeOSType (string _os_type)
		{
			RemoveAllApps ();

			m_comp_info.OSType = _os_type;
		}

		/**********************************************************************************/

		public void ChangeComputerInfo (
			double _cpu_freq, double _ram_capacity, double _gpu_mem
		)
		{
			m_comp_info.CpuFreq = _cpu_freq;
			m_comp_info.RamCapacity = _ram_capacity;
			m_comp_info.GpuMem = _gpu_mem;

            OnSomeChange(ComputerInfoUpdated);
        }

		/**********************************************************************************/

		public void RemoveAllUsers ()
		{
			m_users.Clear ();
            m_ram_usage.Clear();
			OnSomeChange (AllUsersRemoved);
		}

		/**********************************************************************************/

		public void RemoveAllApps ()
		{
			m_apps.Clear ();
			OnSomeChange (AllAppsRemoved);
		}

		/**********************************************************************************/

	}
}

