using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    /// <summary>
    /// Этот класс хранит информацию о руководителе отдела
    /// </summary>
    public class Boss:Worker
    {
        public Boss (FIO fio1, Role.ERole role1):base(fio1,role1)
        {
        }
        
    }
}
