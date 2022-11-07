using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_del_Pañol
{
    public static class asistenteInstalador
    {
        public static bool guardar(string ip)
        {
            if (File.Exists(@"C:\Program Files(x86)\Maggical Solutions\Software Pañol\data.txt"))
            {
                File.Delete((@"C:\Program Files (x86)\Maggical Solutions\Software Pañol\data.txt"));
            }
            File.WriteAllText(@"C:\Program Files (x86)\Maggical Solutions\Software Pañol\data.txt", ip);
            return true;
        }
    }
}
