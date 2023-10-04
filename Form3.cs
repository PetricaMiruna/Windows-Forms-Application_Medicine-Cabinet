using System;
using System.Collections;
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
    public partial class Form3 : Form
    {
        List<Medic> lista3;
        public Form3(List<Medic> lista)
        {
            InitializeComponent();
            lista3 = lista;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbIDmed.Text == "")
                errorProvider1.SetError(tbIDmed, "Introduceti ID-ul medicului!");
            if (tbVechime.Text == "")
                errorProvider1.SetError(tbVechime, "Introduceti vechimea!");
            if (tbNumeMed.Text == "")
                errorProvider1.SetError(tbNumeMed, "Introduceti numele medicului!");
            if (tbPrenMed.Text == "")
                errorProvider1.SetError(tbPrenMed, "Introduceti prenumele medicului!");
            if (cbSpecializare.Text == "")
                errorProvider1.SetError(cbSpecializare, "Selectati specializarea!");
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                int id = Convert.ToInt32(tbIDmed.Text);
                string nume = tbNumeMed.Text;
                string prenume = tbPrenMed.Text;
                string specializare = cbSpecializare.Text;
                float vechime = Convert.ToSingle(tbVechime.Text);

                Medic m = new Medic(specializare, id, vechime);
                lista3.Add(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbIDmed.Clear();
                tbVechime.Clear();
                tbNumeMed.Clear();
                tbPrenMed.Clear();
                cbSpecializare.Items.Clear();
                cbSpecializare.ResetText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
