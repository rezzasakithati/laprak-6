using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsuletion
{
    internal class handphone
    {
        //field
        public string MEREK;
        public string MODEL;
        protected string TAHUN;

        //properties
        public string merek
        {
            get { return MEREK; }
            set { MEREK = value; }
        }
        public string model
        {
            get { return MODEL; }
            set { MODEL = value; }
        }
        public string tahun
        {
            get { return TAHUN; }
            set { TAHUN = value; }
        }
        //method
        public void SetHandphone(string merek, string model)
        {
            this.merek = merek;
            this.model = model;
            Console.WriteLine("Merek Handphone : {0}", this.MEREK);
            Console.WriteLine("Model Handphone : {0}", this.MODEL);

        }
        public void SetTahunkeluar(string tahun)
        {
            this.TAHUN = tahun;
            Console.WriteLine("Tahun Keluaran : {0}", this.TAHUN);
        }
    }
}
