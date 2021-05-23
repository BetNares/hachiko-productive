using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HachickoProductive
{
    public partial class AssignmentModel : DbContext
    {
        public AssignmentModel()
            : base("name=AssignmentModel")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
