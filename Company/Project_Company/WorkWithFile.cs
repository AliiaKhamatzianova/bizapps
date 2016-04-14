using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project_Company
{
    /// <summary>
    /// Это класс для записи данных о департаментах в файл и чтения этой информации из файла
    /// </summary>
    public class WorkWithFile
    {
        string file_name;

        public WorkWithFile (string file_name)
        {
            this.file_name = file_name;
        }

        public List<Departament> Read_from_file ()
        {
            
            BinaryFormatter formatter = new BinaryFormatter();
            System.IO.Stream stream = new FileStream(this.file_name,FileMode.Open);
            ListOfDepartaments list_of_departaments=(ListOfDepartaments)formatter.Deserialize(stream);
            stream.Close();
            return list_of_departaments.list_of_departaments;
        }

        public void Write_to_file( List<Departament> departaments)
        {
            ListOfDepartaments list_of_departaments = new ListOfDepartaments();
            list_of_departaments.list_of_departaments = departaments;
            BinaryFormatter formatter = new BinaryFormatter();
            System.IO.Stream stream = new FileStream(this.file_name, FileMode.OpenOrCreate);
            formatter.Serialize(stream, list_of_departaments);
            stream.Close();
        }
    }
}
