﻿using System;

namespace lab4_v2
{
	//--------------------------------------------------------------------------------------

	public class NewNameEventArgs : EventArgs
	{
		public NewNameEventArgs( string _new_name ) {
			NewName = _new_name;
		}

		public string NewName { get; private set; }
	}

	//--------------------------------------------------------------------------------------

	public class VersionUpdatedEventArgs : EventArgs
	{
		public VersionUpdatedEventArgs( Version _new_version ) {
			NewVersion = _new_version;
		}

		public Version NewVersion { get; private set; }
	}

	//--------------------------------------------------------------------------------------

	public class App
	{
        /**********************************************************************************/

        #region Events

        /**********************************************************************************/

        public event EventHandler<VersionUpdatedEventArgs> VersionChanged;
		public event EventHandler<NewNameEventArgs> NameChanged;

        /**********************************************************************************/

        protected virtual void OnVersionChanged(VersionUpdatedEventArgs e) {
            VersionChanged?.Invoke(this, e);  // Executes the specified delegate. Alternative for bottom code
        }

        /**********************************************************************************/

        protected virtual void OnNameChanged(NewNameEventArgs e) {
			EventHandler<NewNameEventArgs> handler = NameChanged;

			if (handler != null ) {  // If someone subscribed to event
				handler (this, e);
			}
		}

        /**********************************************************************************/

        #endregion Events

        /**********************************************************************************/

        #region Constructors

        /**********************************************************************************/

        public App (string _name, string _producer)
			: this(_name, _producer, new Version())
		{}

        /**********************************************************************************/

        private App (string _name, string _producer, Version _version)
		{
			m_rand_generator = new Random ();
			Name = _name;
			Producer = _producer;
			AppVersion = new Version ();
			ID = string.Format("{0}.{1}", Producer, Name );
		}

        /**********************************************************************************/

        public App (string _name, string _producer, Version _version,
			DateTime _installed_date, ComputerInfo _min_req
		)
			: this(_name, _producer, _version)
		{
			m_min_requirements = _min_req;
			InstallationDate = _installed_date;
			AppVersion = _version;
		}

        #endregion Constructors

        /**********************************************************************************/

        private string m_name;
		private ComputerInfo m_min_requirements;
		private DateTime m_installation_date;
		private string m_producer;
		private Version m_version;
		private string m_id;

		private Random m_rand_generator;

        /**********************************************************************************/

        #region Properties

        /**********************************************************************************/

        public string Name {
			get {
				return m_name;
			}
			set {
				NonEmptyString.CheckValue (value, "Name of program");

				m_name = value;

				NewNameEventArgs e_args = new NewNameEventArgs (m_name);

				OnNameChanged (e_args);
			}
		}

		/**********************************************************************************/

		public ComputerInfo MinRequirements {
			get {
				return m_min_requirements;
			}
			set {
				m_min_requirements = value;
			}
		}

		/**********************************************************************************/

		public string ID {
			get { return m_id; }
			private set { m_id = value; }
		}

		/**********************************************************************************/

		public DateTime InstallationDate {
			get { return m_installation_date; }
			set { m_installation_date = value; }
		}

		/**********************************************************************************/

		public Version AppVersion {
			get {
				return m_version;
			}
			set {
				m_version = value;

				VersionUpdatedEventArgs e_args = new VersionUpdatedEventArgs (m_version);

				OnVersionChanged (e_args);
			}
		}

		/**********************************************************************************/

		public string Producer {
			get {
				return m_producer;
			}
			set {
				NonEmptyString.CheckValue (value, "Producer name");

				m_producer = value;
			}
		}

        #endregion Properties

        /**********************************************************************************/

        public void Update() {
			m_min_requirements.CpuFreq += m_rand_generator.NextDouble();
			m_min_requirements.RamCapacity += m_rand_generator.NextDouble();
			m_min_requirements.GpuMem += m_rand_generator.NextDouble();

			int new_build    = (AppVersion.Build    == -1) ? 0 : AppVersion.Build;
			int new_revision = (AppVersion.Revision == -1) ? 0 : AppVersion.Revision;

			AppVersion = new Version(
				AppVersion.Major,
				AppVersion.Minor,
				new_build,
				new_revision + m_rand_generator.Next() % 100000
			);
		}

        /**********************************************************************************/

        #region Comparison methods an operators

        /**********************************************************************************/

        public static bool operator == (App _a1, App _a2) {
			return _a1.Equals(_a2);
		}

        /**********************************************************************************/

        public static bool operator != (App _a1, App _a2) {
			return !( _a1 == _a2 );
		}

        /**********************************************************************************/

        public override bool Equals (object obj)
		{
			App p = obj as App;

			return Equals (p);
		}

        /**********************************************************************************/

        public bool Equals (App _a) {
			if ((object)_a == null) {
				return false;
			}

			return this.ID == _a.ID;
		}

        /**********************************************************************************/

        #endregion Comparison methods an operators

        /**********************************************************************************/

        public override int GetHashCode ()
		{
			return this.ID.GetHashCode ();
		}

		/**********************************************************************************/

	}
}

