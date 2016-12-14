using System;

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

	public class Application
	{
		/**********************************************************************************/

		public event EventHandler<VersionUpdatedEventArgs> VersionChanged;
		public event EventHandler<NewNameEventArgs> NameChanged;

		protected virtual void OnVersionChanged(VersionUpdatedEventArgs e) {
			EventHandler<VersionUpdatedEventArgs> handler = VersionChanged;

			if (handler != null ) {  // If someone subscribed to event
				handler (this, e);
			}
		}

		protected virtual void OnNameChanged(NewNameEventArgs e) {
			EventHandler<NewNameEventArgs> handler = NameChanged;

			if (handler != null ) {  // If someone subscribed to event
				handler (this, e);
			}
		}

		/**********************************************************************************/

		private string m_name;
		private string m_os_type;
		private DateTime m_installation_date;
		private double m_min_cpu_freq;
		private double m_min_ram;
		private double m_min_gpu_mem;
		private string m_producer;
		private Version m_version;

		private Random m_rand_generator;

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

		public DateTime InstallationDate {
			get { return m_installation_date; }
			set { m_installation_date = value; }
		}

		/**********************************************************************************/

		public double MinCpuFreq {
			get {
				return m_min_cpu_freq;
			}
			set {
				PositiveValue.CheckValue (value, "CPU frequency");

				m_min_cpu_freq = value;
			}
		}

		/**********************************************************************************/

		public double MinRamCapacity {
			get {
				return m_min_ram;
			}
			set {
				PositiveValue.CheckValue (value, "RAM capacity");

				m_min_ram = value;
			}
		}

		/**********************************************************************************/

		public double MinGpuMem {
			get {
				return m_min_gpu_mem;
			}
			set {
				PositiveValue.CheckValue (value, "GPU memory capacity");

				m_min_gpu_mem = value;
			}
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

		/**********************************************************************************/

		public Application (string _name, string _producer)
			: this(_name, _producer, new Version())
		{}

		private Application (string _name, string _producer, Version _version)
		{
			m_rand_generator = new Random ();
			Name = _name;
			Producer = _producer;
			AppVersion = new Version ();
		}

		public Application (string _name, string _os_type, DateTime _installed_date,
			double _min_cpu_freq, double _min_ram_capacity, double _min_gpu_mem,
			string _producer, Version _version
		)
			: this(_name, _producer, _version)
		{
			m_os_type = _os_type;
			InstallationDate = _installed_date;
			MinCpuFreq = _min_cpu_freq;
			MinRamCapacity = _min_ram_capacity;
			MinGpuMem = _min_gpu_mem;
			AppVersion = _version;
		}

		/**********************************************************************************/

		public void Update() {
			m_min_cpu_freq += m_rand_generator.NextDouble();
			m_min_ram += m_rand_generator.NextDouble();
			m_min_gpu_mem += m_rand_generator.NextDouble();

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

	}
}

