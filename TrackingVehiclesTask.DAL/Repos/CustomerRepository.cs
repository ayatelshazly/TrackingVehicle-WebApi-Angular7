using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingVehiclesTask.DAL.Repos
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository( DBDataContext context) : base(context)
        {

        }

    }

}
