using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Agregamos esta biblioteca

namespace My_NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir archivo
            Stream stm;
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() ==System.Windows.Forms.DialogResult.OK)
            {
                if((stm = ofd.OpenFile())!=null)
                {
                    string str = ofd.FileName;
                    string ftxt = File.ReadAllText(str);
                    richTextBox1.Text = ftxt;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //guardar archivo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de texto(*.txt)|*.txt|Archivo de C#(*.cs)*.cs";
            sfd.ShowDialog();
            File.WriteAllText(sfd.FileName, richTextBox1.Text);
            MessageBox.Show("Archivo de textto guardado exitosamente.");
        }
    }
}
