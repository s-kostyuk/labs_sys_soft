﻿using System;

/*****************************************************************************/

namespace lab6_v8.library.Model
{
    public class Publisher
    {

        /*-------------------------------------------------------------------*/

        public Guid Id { get; private set; }

        /*-------------------------------------------------------------------*/

        public string Name { get; set; }

        /*-------------------------------------------------------------------*/

        public Publisher(Guid id) {
            this.Id = id;
        }

        /*-------------------------------------------------------------------*/
        
        public Publisher(Guid id, string name)
            : this(id)
        {
			this.Name = name;
		}

        /*-------------------------------------------------------------------*/

    }
}

/*****************************************************************************/
