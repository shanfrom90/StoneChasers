using Sailing_Rocks.Models;
using Sailing_Rocks.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Repositories
{
    public class RockRepository : Repository<Rock>, IRepository<Rock>
    {
        public RockRepository(SailingRocksContext db) : base(db)
        {


        }

    }
}
