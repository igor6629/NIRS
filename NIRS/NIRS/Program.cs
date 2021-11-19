using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIRS_
{

    public class NIRS
    {
        public string name_st { get; set; }
        public string naprav { get; set; }
        public string tema { get; set; }
        public int srok { get; set; }
        public int mark { get; set; }
        public NIRS(string name_st, string naprav, string tema, int srok, int mark)
        {
            this.name_st = name_st;
            this.naprav = naprav;
            this.tema = tema;
            this.srok = srok;
            this.mark = mark;
        }


    }
    public class Teacher
    {
        public string name_t { get; set; }
        public string dolg { get; set; }
        public int phone { get; set; }
        public string address { get; set; }
        public Teacher(string name_t, string dolg, int phone, string address)
        {
            this.name_t = name_t;
            this.dolg = dolg;
            this.phone = phone;
            this.address = address;

        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
