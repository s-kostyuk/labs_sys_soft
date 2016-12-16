using System;

namespace lab4_v2
{
	public abstract class NonEmptyString {
		public static void CheckValue(string _value, string _value_name) {
			if (_value.Length == 0) {
				throw new ArgumentException (
					_value_name,
                    string.Format("{0} value can't be empty", _value_name)
				);
			}
		}
	}
}

