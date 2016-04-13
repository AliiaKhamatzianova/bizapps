using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    /// <summary>
    /// Этот класс для хранения ФИО сотрудника
    /// </summary>
    public class FIO
    {
        public FIO (string last, string first, string given)
        {
            this.last_name = last;
            this.name = first;
            this.given_name = given;
        }
            
        public string last_name;
        public string name;
        public string given_name;
    }
}
