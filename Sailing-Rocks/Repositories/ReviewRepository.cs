using Sailing_Rocks.Models;
using Sailing_Rocks.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Repositories
{
    public class ReviewRepository : Repository<Review>, IRepository<Review>
    {
        public ReviewRepository(SailingRocksContext db) : base(db) 
        { 


        }



    }
}
