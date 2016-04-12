using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Boss
    {
        public FIO boss_fio { get; set; }
        public Contacts contacts { get; set; }
        Role.ERole role;
    }
}
