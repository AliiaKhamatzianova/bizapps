using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    /// <summary>
    /// Этот класс хранит информацию о сотруднике
    /// </summary>
    [Serializable]
    public class Worker
    {
        public Worker (FIO fio1,Role.ERole role1)
        {
            this.fio = fio1;
            this.role = role1;
        }
        public FIO fio { get; set; }
        Role.ERole role;
        public Contacts contacts { get; set; }
        Departament departament;

        public void Translate (Departament new_departament, Role.ERole new_role)
        {
            if (this.departament!=null)
                this.departament.Remove(this);

            this.departament = new_departament;
            this.role = new_role;
            this.departament.Add(this);
        }

        public void Change_role (Role.ERole new_role)
        {
            this.role = new_role;
        }
       
    }
}
