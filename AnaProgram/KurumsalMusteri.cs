using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaProgram
{
    public class KurumsalMusteri:Musteri
    {
       public void TelnoYaz()
        {
            Console.WriteLine(telno.Substring(telno.Length-4));
        }
        public void KKNOYaz4()
        {
            
        }
    }
}
