using System;

namespace lab4_v2
{
	// FIXME: Choose some other methods of validation
	public abstract class PositiveValue {
		public static void CheckValue(double _value, string _value_name) {
			if (_value <= 0.0) {
				throw new ArgumentOutOfRangeException (
					_value_name,
                    string.Format("{0} value must be positive", _value_name)
				);
			}
		}

		public static void CheckValue(int _value, string _value_name) {
			if (_value <= 0) {
				throw new ArgumentOutOfRangeException (
					_value_name,
                    string.Format("{0} value must be positive", _value_name)
				);
			}
		}
	}
}

