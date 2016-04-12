using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Departament
    {
        public Boss boss { get; set; }
        public string departament_name { get; set; }
        List<Workers> workers;

        public void Remove (Workers worker)
        {
            if (this.workers.Contains(worker)==true)
                this.workers.Remove(worker);
        }

        public void Add (Workers worker)
        {
            if (this.workers.Contains(worker) == false)
                this.workers.Add(worker);
        }

        public List<Workers> Get_workers ()
        {
            return this.workers;
        }

    }
}
