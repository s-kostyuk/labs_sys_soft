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
		public VersionUpdatedEventArgs( double _new_version ) {
			NewVersion = _new_version;
		}

		public double NewVersion { get; private set; }
	}

	//--------------------------------------------------------------------------------------

	public abstract class PositiveValue {
		public static void CheckValue(double _value, string _value_name) {
			if (_value <= 0) {
				throw new ArgumentOutOfRangeException ("value", String.Format("{0} must be positive", _value_name));
			}
		}
	}

	//--------------------------------------------------------------------------------------

	public class Program
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
		private double m_min_cpu_freq;
		private double m_min_ram;
		private double m_min_gpu_mem;
		private double m_version;
		private string m_producer;
		private Random m_rand_generator;

		/**********************************************************************************/

		public string name {
			get {
				return m_name;
			}
			set {
				if (value.Length == 0) {
					throw new ArgumentException ("Name of program can't be empty");
				}

				m_name = value;

				NewNameEventArgs e_args = new NewNameEventArgs (m_name);

				OnNameChanged (e_args);
			}
		}

		/**********************************************************************************/

		public DateTime installation_date { get; set; }

		/**********************************************************************************/

		public double min_cpu_freq { 
			get {
				return m_min_cpu_freq;
			}
			set {
				PositiveValue.CheckValue (value, "CPU frequency");

				m_min_cpu_freq = value;
			}
		}

		/**********************************************************************************/

		public double min_ram {
			get {
				return m_min_ram;
			}
			set {
				PositiveValue.CheckValue (value, "RAM capacity");

				m_min_ram = value;
			}
		}

		/**********************************************************************************/

		public double min_gpu_mem {
			get {
				return m_min_gpu_mem;
			}
			set {
				PositiveValue.CheckValue (value, "GPU memory capacity");

				m_min_gpu_mem = value;
			}
		}

		/**********************************************************************************/

		public double version {
			get {
				return m_version;
			}
			set {
				PositiveValue.CheckValue (value, "Version number");

				m_version = value;

				VersionUpdatedEventArgs e_args = new VersionUpdatedEventArgs (m_version);

				OnVersionChanged (e_args);
			}
		}

		/**********************************************************************************/

		public Program ()
		{
			m_rand_generator = new Random ();
		}

		/**********************************************************************************/

		public void Update() {
			m_min_cpu_freq += m_rand_generator.NextDouble();
			m_min_ram += m_rand_generator.NextDouble();
			m_min_gpu_mem += m_rand_generator.NextDouble();
			version += m_rand_generator.NextDouble ();
		}

		/**********************************************************************************/

	}
}

