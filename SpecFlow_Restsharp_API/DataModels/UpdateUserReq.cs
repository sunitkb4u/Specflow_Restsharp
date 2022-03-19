using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Restsharp_API.DataModels
{
    public class UpdateUserReq
    {
        public string name { get; set; }
        public string job { get; set; }
        public DateTime createdAt { get; set; }
    }
}
