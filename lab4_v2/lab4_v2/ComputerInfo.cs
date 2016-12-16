using System;

namespace lab4_v2
{
	public class ComputerInfo
	{
		
		/**********************************************************************************/

		private string m_os_type;
		private double m_cpu_freq;
		private double m_ram;
		private double m_gpu_mem;

		/**********************************************************************************/

		public string OSType {
			get { return m_os_type; }
			set { m_os_type = value; }
		}

		/**********************************************************************************/

		public double CpuFreq {
			get {
				return m_cpu_freq;
			}
			set {
				PositiveValue.CheckValue (value, "CPU frequency");

				m_cpu_freq = value;
			}
		}

		/**********************************************************************************/

		public double RamCapacity {
			get {
				return m_ram;
			}
			set {
				PositiveValue.CheckValue (value, "RAM capacity");

				m_ram = value;
			}
		}

		/**********************************************************************************/

		public double GpuMem {
			get {
				return m_gpu_mem;
			}
			set {
				PositiveValue.CheckValue (value, "GPU memory capacity");

				m_gpu_mem = value;
			}
		}

		/**********************************************************************************/

		public static bool operator  < (ComputerInfo _c1, ComputerInfo _c2) {
			return _c1.CpuFreq     < _c2.CpuFreq
				|| _c1.GpuMem      < _c2.GpuMem
				|| _c1.RamCapacity < _c2.RamCapacity;
		}

		public static bool operator  > (ComputerInfo _c1, ComputerInfo _c2) {
			return _c2 < _c1;
		}

		/**********************************************************************************/

	}
}

