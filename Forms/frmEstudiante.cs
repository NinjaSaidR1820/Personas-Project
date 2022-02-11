using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class frmEstudiante : Form
    {
        List<Ingenieria> lista = new List<Ingenieria>(); 

        Ingenieria ing;



        public frmEstudiante()
        {
            InitializeComponent();
            lista = new List<Ingenieria>();

        }

        public void guardar1()
        {

            ing = new Ingenieria(txtNombreyApellido.Text, int.Parse(txtEdad.Text), txtCarnet.Text,cbNivelAcademico.Text,
                txtUniversidad.Text,cbCarrera.Text,cbMateriasInscritas.Text,int.Parse(txtNotas.Text),txtCUM.Text,
                txtNombreProyecto.Text,int.Parse(txtHoraTotales.Text),int.Parse(txtHoraCompletadas.Text));

            lista.Add(ing);

            dgvPersona.DataSource = null;
             dgvPersona.DataSource = lista;

           

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            guardar1();


        }
    }
}
