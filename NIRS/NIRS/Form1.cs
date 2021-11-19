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
    public partial class Form1 : Form
    {
        BindingList<NIRS> nirs = new BindingList<NIRS>();

        BindingList<Teacher> teacher = new BindingList<Teacher>();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = nirs;

            dataGridView1.Columns[0].HeaderText = "Студент";
            dataGridView1.Columns[1].HeaderText = "Направление";
            dataGridView1.Columns[2].HeaderText = "Тема";
            dataGridView1.Columns[3].HeaderText = "Срок выполнения(месяцев)";
            dataGridView1.Columns[4].HeaderText = "Результат";

            dataGridView2.DataSource = teacher;

            dataGridView2.Columns[0].HeaderText = "Руководитель";
            dataGridView2.Columns[1].HeaderText = "Должность";
            dataGridView2.Columns[2].HeaderText = "Телефон";
            dataGridView2.Columns[3].HeaderText = "Адрес";
        }
        // Вкладка - НИРС
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name_st = textBox1.Text;
            string naprav = textBox2.Text;
            string tema = textBox3.Text;
            int srok = Convert.ToInt32(textBox4.Text);
            int mark = Convert.ToInt32(textBox5.Text);
            nirs.Add(new NIRS(name_st, naprav, tema, srok, mark));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NIRS temp;
            for (int i = 0; i < nirs.Count - 1; i++)
            {
                for (int j = 1; j < nirs.Count; j++)
                {
                    if (String.Compare(nirs[j].name_st, nirs[j - 1].name_st) < 0)
                    {
                        temp = nirs[j];
                        nirs[j] = nirs[j - 1];
                        nirs[j - 1] = temp;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NIRS temp;
            for (int i = 0; i < nirs.Count - 1; i++)
            {
                for (int j = 1; j < nirs.Count; j++)
                {
                    if (String.Compare(nirs[j].naprav, nirs[j - 1].naprav) < 0)
                    {
                        temp = nirs[j];
                        nirs[j] = nirs[j - 1];
                        nirs[j - 1] = temp;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NIRS temp;
            for (int i = 0; i < nirs.Count - 1; i++)
            {
                for (int j = 1; j < nirs.Count; j++)
                {
                    if (String.Compare(nirs[j].tema, nirs[j - 1].tema) < 0)
                    {
                        temp = nirs[j];
                        nirs[j] = nirs[j - 1];
                        nirs[j - 1] = temp;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NIRS temp;
            for (int i = 0; i < nirs.Count - 1; i++)
            {
                for (int j = 1; j < nirs.Count; j++)
                {
                    if (nirs[j].srok< nirs[j - 1].srok)
                    {
                        temp = nirs[j];
                        nirs[j] = nirs[j - 1];
                        nirs[j - 1] = temp;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NIRS temp;
            for (int i = 0; i < nirs.Count - 1; i++)
            {
                for (int j = 1; j < nirs.Count; j++)
                {
                    if (nirs[j].mark < nirs[j - 1].mark)
                    {
                        temp = nirs[j];
                        nirs[j] = nirs[j - 1];
                        nirs[j - 1] = temp;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strToFind = textBox6.Text;
            BindingList<NIRS> list = new BindingList<NIRS>();
            for (int i = 0; i < nirs.Count; i++)
            {
                string data = nirs[i].name_st + nirs[i].naprav + nirs[i].tema + nirs[i].srok + nirs[i].mark;
                if (data.Contains(strToFind))
                {
                    list.Add(nirs[i]);
                }
            }
            Form2 search = new Form2(list);
            search.Show();

        }
      
        
        // Вкладка - Руководители тем
        private void button8_Click(object sender, EventArgs e)
        {
            string name_t = textBox7.Text;
            string dolg = textBox8.Text;
            int phone = Convert.ToInt32(textBox9.Text);
            string address = textBox10.Text;
            
         
            teacher.Add(new Teacher(name_t, dolg, phone, address));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Teacher temp;
            for (int i = 0; i < teacher.Count - 1; i++)
            {
                for (int j = 1; j < teacher.Count; j++)
                {
                    if (String.Compare(teacher[j].name_t, teacher[j - 1].name_t) < 0)
                    {
                        temp = teacher[j];
                        teacher[j] = teacher[j - 1];
                        teacher[j - 1] = temp;
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Teacher temp;
            for (int i = 0; i < teacher.Count - 1; i++)
            {
                for (int j = 1; j < teacher.Count; j++)
                {
                    if (teacher[j].phone < teacher[j - 1].phone)
                    {
                        temp = teacher[j];
                        teacher[j] = teacher[j - 1];
                        teacher[j - 1] = temp;
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Teacher temp;
            for (int i = 0; i < teacher.Count - 1; i++)
            {
                for (int j = 1; j < teacher.Count; j++)
                {
                    if (String.Compare(teacher[j].dolg, teacher[j - 1].dolg) < 0)
                    {
                        temp = teacher[j];
                        teacher[j] = teacher[j - 1];
                        teacher[j - 1] = temp;
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Teacher temp;
            for (int i = 0; i < teacher.Count - 1; i++)
            {
                for (int j = 1; j < teacher.Count; j++)
                {
                    if (String.Compare(teacher[j].address, teacher[j - 1].address) < 0)
                    {
                        temp = teacher[j];
                        teacher[j] = teacher[j - 1];
                        teacher[j - 1] = temp;
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string strToFind = textBox11.Text;
            BindingList<Teacher> list = new BindingList<Teacher>();
            for (int i = 0; i < teacher.Count; i++)
            {
                string data = teacher[i].name_t + teacher[i].dolg + teacher[i].phone + teacher[i].address;
                if (data.Contains(strToFind))
                {
                    list.Add(teacher[i]);
                }
            }
            Form3 search = new Form3(list);
            search.Show();
        }
    }
}

