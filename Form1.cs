using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analiza06_zad2
{
    public partial class Form1 : Form
    {
        List<vjesala> listarijeci = new List<vjesala>();
        string path = "TextFile1.txt";
        string trazena_rijec;
        StringBuilder zamjena = new StringBuilder();
        int br = 0;
        int br_pok = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(@path))
            {
                string line;
                while((line=reader.ReadLine())!= null)
                {
                    vjesala i = new vjesala(line);
                    listarijeci.Add(i);
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lrijec.Text = "";
            Random rand = new Random();
            int redni_broj = rand.Next(0, listarijeci.Count);
            trazena_rijec = Convert.ToString(listarijeci[redni_broj]);
            for(int i = 0; i < trazena_rijec.Length; i++)
            {
                lrijec.Text = lrijec.Text + " _ ";
            }
            StringBuilder nova_rijec = new StringBuilder(lrijec.Text);
            zamjena = nova_rijec;
            br_pok = 7;
            lbrpok.Text = Convert.ToString(br_pok);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lrijec.Text = "";
            string tslovo;
            tslovo = textBox1.Text;
            for (int i = 0; i < trazena_rijec.Length; i++)
            {
                if (trazena_rijec[i] == tslovo[0])
                {
                    zamjena[i*2] = tslovo[0];
                    br++;
                }
            }
            lrijec.Text = zamjena.ToString();
            if (br == 0)
            {
                br_pok--;
                lbrpok.Text = Convert.ToString(br_pok);
            }
            br = 0;
            if (br_pok == 0)
            {
                MessageBox.Show("Izgubili ste!");
                lrijec.Text = trazena_rijec;
            }
        }
    }
}
