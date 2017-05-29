using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*****************************************************************************/

namespace lab7_v1.Utils
{
    public static class CheckPositive
    {
        /*-------------------------------------------------------------------*/

        public static void Check(int value, string msg_param_name)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    get_message(msg_param_name)
                    );
            }
        }

        /*-------------------------------------------------------------------*/

        public static void Check(int value, string msg_param_name, string param_name)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    param_name, get_message(msg_param_name)
                    );
            }
        }

        /*-------------------------------------------------------------------*/

        private static string get_message(string msg_param_name)
        {
            return string.Format("{0} must be positive", msg_param_name);
        }

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
