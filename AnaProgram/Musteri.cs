using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaProgram
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Unvan { get; set; }

        private string kKNO;
        public int vv { get; set; }
        public string GetKKNO()
        {
            return kKNO;
        }

        public void SetKKNO(string value)
        {
            kKNO = "****" + value.Substring(value.Length-4);
        }

        protected internal string telno;

        public  string GetTelno()
        {
            return telno;
        }

        public void SetTelno(string value)
        {
            telno =  "****" + value.Substring(value.Length-2);
        }

       


    }
}
