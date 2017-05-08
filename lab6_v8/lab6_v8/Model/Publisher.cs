using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_v8.Model
{
    public class Publisher
    {
        public string Name { get; set; }

		public Publisher() {
		}

		public Publisher(string name) {
			this.Name = name;
		}
    }
}
