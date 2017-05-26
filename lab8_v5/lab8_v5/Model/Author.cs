﻿using System;


/*****************************************************************************/

namespace lab8_v5.Model
{
    public class Author : BasicEntity
    {
        
        /*-------------------------------------------------------------------*/

        public string Name { get; set; }

        /*-------------------------------------------------------------------*/

        public Author(Guid id, string name)
            : base(id)
        {
			this.Name = name;
		}

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/