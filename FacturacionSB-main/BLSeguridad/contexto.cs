using BLFacturacionSB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLSeguridad
{
    public class contexto: DbContext
    {
        public contexto(): base("ClientesBL")
        {
               
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Cliente> cliente { get; set; }
    }
}
