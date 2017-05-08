using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_v8.Model
{
    public class Author
    {
        public string Name { get; set; }

		public Author() {}

		public Author(string name) {
			this.Name = name;
		}
    }
}
