using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<Pacient> listaPac = new List<Pacient>();
        List<Persoana> listaPers = new List<Persoana>();
        List<Medic> listaMedici = new List<Medic>();
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (tbID.Text == "")
                errorProvider1.SetError(tbID, "Introduceti ID-ul pacientului!");
            if (tbVarstaPacient.Text=="")
                errorProvider1.SetError(tbID, "Introduceti varsta pacientului!");
            if (tbNumePacient.Text == "")
                errorProvider1.SetError(tbID, "Introduceti numele pacientului!");
            if (tbPrenPacient.Text == "")
                errorProvider1.SetError(tbID, "Introduceti prenumele pacientului!");
            if (tbTelPac.Text == "")
                errorProvider1.SetError(tbID, "Introduceti numarul de telefon!");
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                int id = Convert.ToInt32(tbID.Text);
                int varsta = Convert.ToInt32(tbVarstaPacient.Text);
                string nume = tbNumePacient.Text;
                string prenume = tbPrenPacient.Text;
                string nr_telefon = tbTelPac.Text;
                string[] afectiuniP = tbAfectiuni.Text.Trim().Split(',');
                string[] afectiuni = new string[afectiuniP.Length];
                for (int i = 0; i < afectiuniP.Length; i++)
                    afectiuni[i] = afectiuniP[i];

                Pacient p = new Pacient(id, varsta, afectiuni, nume, prenume, nr_telefon);

                listaPac.Add(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbID.Clear();
                tbVarstaPacient.Clear();
                tbNumePacient.Clear();
                tbAfectiuni.Clear();
                tbPrenPacient.Clear();
                tbTelPac.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaPac);
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 frm = new Form3(listaMedici);
            frm.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
