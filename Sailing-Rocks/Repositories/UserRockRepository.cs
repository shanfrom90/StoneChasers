using Sailing_Rocks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Repositories
{
    public class UserRockRepository : Repository<UserRock>
    {
        public UserRockRepository(SailingRocksContext db) : base(db)
        {

        }
    }
}
