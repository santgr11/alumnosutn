using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos {
    public partial class frmAlumnos : Form {
        int ctlib = 0;
        int ctreg = 0;
        int ctpro = 0;
        Alumno alumno;

        double acu = 0;
        IDictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

        public frmAlumnos() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnRegistro_Click(object sender, EventArgs e) {

            if( validarDatos() ) {

                alumno = new Alumno(boxNombre.Text, Convert.ToInt32(boxLegajo.Text), td(boxNota1.Text), td(boxNota2.Text), td(boxNota3.Text));
                alumnos[Convert.ToInt32(boxLegajo.Text)] = alumno;
                acu = acu + alumno.getPromedio();

                boxAprueba.Text = alumno.mostrarCondicion();

                switch (alumno.condicion()) {
                    case 3:
                        ctlib++;
                        break;
                    case 2:
                        ctreg++;
                        break;
                    case 1:
                        ctpro++;
                        break;

                    default:
                        break;
                }

                lblLibresTotal.Text = ctlib.ToString();
                lblRegularesTotal.Text = ctreg.ToString();
                lblPromocionadosTotal.Text = ctpro.ToString();

                boxCantidad.Text = Convert.ToString(alumnos.Values.Count());
                lblProGeneral.Text = "" + Math.Round((acu / alumnos.Values.Count()), 2);

                double prom = Math.Round(alumno.getPromedio(), 2);
                boxPromedio.Text = Convert.ToString(prom);

                lblPorLib.Text = Math.Round(((double)ctlib / alumnos.Values.Count()) * 100, 2).ToString();
                lblPorReg.Text = Math.Round(((double)ctreg / alumnos.Values.Count()) * 100, 2).ToString();
                lblPorPro.Text = Math.Round(((double)ctpro / alumnos.Values.Count()) * 100, 2).ToString();
            }

            Alumno mp = this.maxPro();

            lblMpNombre.Text = mp.Nombre;
            lblMpNota.Text = mp.getPromedio().ToString();
        }

        public bool isBoxEmpty(TextBox tb) {
            if (tb.Text == "") {
                return true;
            } else {
                return false;
            }
        }

        public bool validarDatos() {

            if (isBoxEmpty(boxLegajo)) {

                System.Windows.Forms.MessageBox.Show("Ingrese un legajo");
                boxLegajo.Focus();
                return false;

            } else if (alumnos.ContainsKey(Convert.ToInt32(boxLegajo.Text))) {

                alumno = alumnos[Convert.ToInt32(boxLegajo.Text)];
                System.Windows.Forms.MessageBox.Show("Alumno ya cargado");
                boxLegajo.Focus();
                return false;

            } else if (isBoxEmpty(boxNombre)) {

                System.Windows.Forms.MessageBox.Show("Ingrese el nombre del alumno");
                boxNombre.Focus();
                return false;

            } else if (isBoxEmpty(boxNota1) || isBoxEmpty(boxNota2) || isBoxEmpty(boxNota3)) {

                System.Windows.Forms.MessageBox.Show("No deje campos de notas vacios");
                boxNota1.Focus();
                return false;

            } else if (td(boxNota1.Text) < 0 || td(boxNota1.Text) > 10 ||
                       td(boxNota2.Text) < 0 || td(boxNota2.Text) > 10 ||
                       td(boxNota3.Text) < 0 || td(boxNota3.Text) > 10) {

                System.Windows.Forms.MessageBox.Show("Notas fuera de rango permitido");
                boxNota1.Focus();
                return false;

            }

            return true;

        }


        public double td(string coso) {
            return Convert.ToDouble(coso);
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void btnBuscar_Click(object sender, EventArgs e) {

            Alumno alumno;

            if (boxLegajo.Text == "") {
                System.Windows.Forms.MessageBox.Show("Ingrese un legajo");
            } else if (!IsDigitsOnly(boxLegajo.Text)) {
                System.Windows.Forms.MessageBox.Show("Ingrese un legajo valido");
            } else if (!alumnos.ContainsKey(Convert.ToInt32(boxLegajo.Text))) {
                System.Windows.Forms.MessageBox.Show("No existe un alumno con ese legajo");
            } else {
                alumno = alumnos[Convert.ToInt16(boxLegajo.Text)];

                boxNombre.Text = alumno.Nombre;
                boxNota1.Text = alumno.Nota1.ToString();
                boxNota2.Text = alumno.Nota2.ToString();
                boxNota3.Text = alumno.Nota3.ToString();

            }
        }

        bool IsDigitsOnly(string str) {
            foreach (char c in str) {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void boxAprueba_Click(object sender, EventArgs e) {

        }

        private void lblProCurso_Click(object sender, EventArgs e) {

        }

        private void boxLegajo_KeyPress(object sender, KeyPressEventArgs e) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void boxNombre_TextChanged(object sender, EventArgs e) {

        }

        private void boxNombre_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void boxNota1_TextChanged(object sender, EventArgs e) {

        }

        private void boxNota1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void boxNota2_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void boxNota3_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblRegularesTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblPromocionadosTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblLibresTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblProGeneral_Click(object sender, EventArgs e)
        {

        }

        private Alumno maxPro() {

            Alumno candidato = new Alumno("", 0, 0, 0, -1);

            foreach(Alumno alum in this.alumnos.Values) {
            
                if (alum.getPromedio() > candidato.getPromedio()) {
                    candidato = alum;
            }

        }

            return candidato;

        }
    }
}

    

