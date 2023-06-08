namespace ProyectoFinalUSPG
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listasEnlazadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno formAlumno = new frmAlumno();
            formAlumno.MdiParent = this;
            formAlumno.Show();
        }

        private void circularSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircular form = new frmCircular();
            form.MdiParent = this;
            form.Show();
        }

        private void doblementeEnlazadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDobleEnlazada form = new frmDobleEnlazada();
            form.MdiParent = this;
            form.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola form = new frmCola();
            form.MdiParent = this;
            form.Show();
        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila form = new frmPila();
            form.MdiParent = this;
            form.Show();
        }

        private void tablaHashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaHash form = new frmTablaHash();
            form.MdiParent = this;
            form.Show();
        }
    }
}