using lab8_v5.Model;

using System.Data.Entity.ModelConfiguration;

/*****************************************************************************/

namespace lab8_v5.DbConfigurations
{
    public class BasicEntityConfiguration< T > : EntityTypeConfiguration< T> 
        where T : BasicEntity
    {
        /*-------------------------------------------------------------------*/

        public BasicEntityConfiguration ()
        {
            HasKey( e => e.Id );
        }

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
