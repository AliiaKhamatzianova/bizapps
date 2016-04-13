using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company;

namespace Project_Company
{
    /// <summary>
    /// Пример работы с API библиотеками
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Departament> departaments = new List<Departament>();

            #region
            Departament dep1 = new Departament("IT");

            FIO fio1 = new FIO("Ivanov", "Ivan", "Ivanovich");
            FIO fio2 = new FIO("Petrov", "Roman", "Antonovich");
            FIO fio3 = new FIO("Sidorova", "Marina", "Olegovna");
            FIO fio_boss = new FIO("Peredreychyk", "Elza", "Rashatovna");

            Worker worker1 = new Worker(fio1, Role.ERole.Developer);
            Worker worker2 = new Worker(fio2, Role.ERole.Project_manager);
            Worker worker3 = new Worker(fio3, Role.ERole.Developer);

            Boss boss1 = new Boss(fio_boss, Role.ERole.Project_manager);

            dep1.boss = boss1;
            dep1.Add(worker1);
            dep1.Add(worker2);
            dep1.Add(worker3);

            departaments.Add(dep1);
            #endregion

            #region
            dep1 = new Departament("HR");

            fio1 = new FIO("Shishov", "Evgeny", "Albertovich");
            fio2 = new FIO("Fomin", "Vadim", "Muratovich");
            fio3 = new FIO("Kuyanova", "Irina", "Marsovna");
            fio_boss = new FIO("Zayac", "Aleksey", "Pavlovich");

            worker1 = new Worker(fio1, Role.ERole.Business_analyst);
            worker2 = new Worker(fio2, Role.ERole.Project_manager);
            worker3 = new Worker(fio3, Role.ERole.Business_analyst);

            boss1 = new Boss(fio_boss, Role.ERole.Project_manager);

            dep1.boss = boss1;
            dep1.Add(worker1);
            dep1.Add(worker2);
            dep1.Add(worker3);

            departaments.Add(dep1);
            #endregion

           Worker translate_worker = departaments[1].Get_worker_by_name(fio3);
            if (translate_worker!=null)
            {
                translate_worker.Translate(departaments[0],Role.ERole.QA);
            }

        }
    }
}
