using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Workers
    {
        public FIO fio { get; set; }
        Role.ERole role;
        public Contacts contacts { get; set; }
        Departament departament;

        public void Translate (Departament new_departament)
        {
            this.departament.Remove(this);
            this.departament = new_departament;
            this.departament.Add(this);
        }

        public void Change_role (Role.ERole new_role)
        {
            this.role = new_role;
        }
       
    }
}
