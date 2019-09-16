using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LlamaFA
{
    public partial class F1 : Form
    {
        static List<Llamas> llama;
        static Random rnd = new Random();
        public F1()
        {
            InitializeComponent();
            Beolvas();
            Feltolt();
            tbEv.TextChanged += TbkTextChanged;
            tbNev.TextChanged += TbkTextChanged;
            tbIz.TextChanged += TbkTextChanged;

            this.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void TbkTextChanged(object sender, EventArgs e)
        {
            b1.Enabled = tbNev.Text.Length != 0 && tbEv.Text.Length != 0 && tbIz.Text.Length != 0;
        }

        private void Feltolt()
        {
            foreach (var t in llama)
            {
                cbNev.Items.Add(t.nev);
            }
        }

        private void Beolvas()
        {
            llama = new List<Llamas>();

            var sr = new StreamReader(@"lama.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {

                llama.Add(new Llamas(sr.ReadLine()));

            }
            sr.Close();
        }

        private void F1_Load(object sender, EventArgs e)
        {
            
        }

        private void CbNev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (llama[cbNev.SelectedIndex].iz == "édes")
            {
                lbSzul.ForeColor = Color.Pink;
            }
            else
            {
                lbSzul.ForeColor = Color.LightBlue;
            }

            lbSzul.Text = llama[cbNev.SelectedIndex].ev + " ";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            int ev = -1;

            if (cbNev.Items.Contains(tbNev.Text))
            {
                MessageBox.Show("Van már ilyen név!");
            }
            else if (!int.TryParse(tbEv.Text, out ev))
            {
                MessageBox.Show("A beírt születési év nem szám!");
            }
            else if (tbIz.Text != "édes" && tbIz.Text != "sós")
            {
                MessageBox.Show("Sajnos csak sós és édes ízeket kedvelő lámákkal tudunk dolgozni!");
            }
            else
            {
                MessageBox.Show("Új láma rögzítve!");

                var sw = new StreamWriter(@"lama.txt", true);
                sw.Write(tbNev.Text + ';');
                sw.Write(tbEv.Text + ';');
                sw.WriteLine(tbIz.Text);
                sw.Close();

                Application.Restart();
            }
        }
    }
}
