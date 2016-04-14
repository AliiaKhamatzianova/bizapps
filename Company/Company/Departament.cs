using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    /// <summary>
    /// Этот класс хранит информацию об отделе
    /// </summary>
    [Serializable]
    public class Departament
    {
        public Departament (string name)
        {
            this.departament_name = name;
        }

        public Boss boss { get; set; }
        public string departament_name { get; set; }
        List<Worker> workers=new List<Worker>();

        public Worker Get_worker_by_name (FIO fio)
        {
            foreach (Worker worker in this.workers)
            {
                if ((worker.fio.last_name == fio.last_name) && (worker.fio.name == fio.name) && (worker.fio.given_name == fio.given_name))
                    return worker;
            }
            return null;
            
        }

        public void Remove (Worker worker)
        {
            if (this.workers.Contains(worker)==true)
                this.workers.Remove(worker);
        }

        public void Add (Worker worker)
        {
            if (this.workers.Contains(worker) == false)
                this.workers.Add(worker);
        }

        public List<Worker> Get_workers ()
        {
            return this.workers;
        }

    }
}
