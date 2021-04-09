using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sailing_Rocks.Models;

namespace Sailing_Rocks.Extensions
{
    public interface ISelectList
    {
        

        Rock GetRockBySerial(string serial);
         
    }
}
