using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    /// <summary>
    /// Этот класс хранит информацию об отделах и их работниках
    /// </summary>
    public class Hierarchy
    {
        public Hierarchy(Departament departament)
        {
            this.departament_name = departament.departament_name;
            this.fio_boss = departament.boss.fio;
            foreach (Worker worker in departament.Get_workers())
            {
                this.workers_fio.Add (worker.fio);
            }  
        }
        public string departament_name;
        public FIO fio_boss;
        List<FIO> workers_fio;
    }
}
