using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_Etudiant
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void miseÀJourToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etudiant vu = new Etudiant();
            vu.Show();
            this.Hide();

        }

        private void matièreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matiere vu = new Matiere();
            vu.Show();
            this.Hide();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultation vu = new Consultation();
           
            vu.Show();
            this.Hide();
        }

        private void gestionDesNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes vu = new Notes();
            vu.Show();
            this.Hide();
        }
    }
}
