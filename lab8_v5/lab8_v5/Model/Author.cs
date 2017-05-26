using System;
using System.Text;


/*****************************************************************************/

namespace lab8_v5.Model
{
    public class Author : BasicEntity
    {
        
        /*-------------------------------------------------------------------*/

        public string Name { get; set; }

        /*-------------------------------------------------------------------*/

        public Author() { }

        /*-------------------------------------------------------------------*/

        public Author(Guid id, string name)
            : base(id)
        {
			this.Name = name;
		}

        /*-------------------------------------------------------------------*/

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Id: {0}, Name: {1}", Id, Name);

            return sb.ToString();
        }

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
