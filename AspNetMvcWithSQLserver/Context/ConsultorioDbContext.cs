using AspNetMvcWithSQLserver;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AspNetMvcWithSQLserver.Context
{
    public class ConsultorioDbContext: DbContext
    {
        public ConsultorioDbContext():base("ConsultorioEntities")
        {

        }

        public DbSet<PACIENTE> Pacientes { get; set; }
        public DbSet<MEDICO> Medicos { get; set; }
        public DbSet<HOSPITAL> Hospitais { get; set; }
        public DbSet<CONSULTA> Consultas { get; set; }
        public DbSet<INTERNACAO> Internacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}