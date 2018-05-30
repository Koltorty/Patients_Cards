using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patients.Models
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection") { }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Visit> Visits { get; set; }
    }
}
