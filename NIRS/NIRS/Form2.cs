using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIRS_
{
    public partial class Form2 : Form
    {
        public Form2(BindingList<NIRS> data)
        {
            InitializeComponent();
            dataGridView1.DataSource = data;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
