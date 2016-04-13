using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    /// <summary>
    /// Этот класс позволяет посмотреть иерархию отделов компании
    /// </summary>
    public class Company
    {
        List<Departament> departaments; 

        public List <Hierarchy> Show_Hierarchy ()
        {
            List<Hierarchy> hierarchy_departament = new List<Hierarchy> ();
            foreach (Departament departament in this.departaments)
            {
                hierarchy_departament.Add(new Hierarchy(departament));
            }
            return hierarchy_departament;
        }
    }
}
