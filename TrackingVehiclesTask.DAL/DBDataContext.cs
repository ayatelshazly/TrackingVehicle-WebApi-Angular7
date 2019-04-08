using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingVehiclesTask.DAL
{

    public class DBDataContext : DbContext
    {
        public DBDataContext() : base("DefaultConnection")
        {

        }

        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }


}
