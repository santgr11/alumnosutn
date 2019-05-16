using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class frmAlumnos : Form
    {
        int ctlib = 0;
        int ctreg = 0;
        int ctpro = 0;
    
        double acu = 0;
        IDictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
        
            if (boxNota1.Text == "" || boxNota2.Text == "" || boxNota3.Text == "") {
                boxPromedio.Text = "Complete las notas";
                boxAprueba.Text = "Complete las notas";
            } else {

                try {
                    Alumno alumno;

                    if (alumnos.ContainsKey(Convert.ToInt32(boxLegajo.Text))) {
                        alumno = alumnos[Convert.ToInt32(boxLegajo.Text)];
                        System.Windows.Forms.MessageBox.Show("Alumno ya cargado");

                    } else if (td(boxNota1.Text) > 10 ||
                        td(boxNota2.Text) > 10 ||
                        td(boxNota3.Text) > 10 ||
                        td(boxNota1.Text) < 0 ||
                        td(boxNota2.Text) < 0 ||
                        td(boxNota3.Text) < 0) {
                        boxPromedio.Text = "Nota Invalida";
                        boxAprueba.Text = "Indeterminado";
                    } else {
                        alumno = new Alumno(boxNombre.Text, Convert.ToInt16(boxLegajo.Text), td(boxNota1.Text), td(boxNota2.Text), td(boxNota3.Text));
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
                        lblProGeneral.Text = "" + acu / alumnos.Values.Count();

                        double prom = Math.Round(alumno.getPromedio(), 2);
                        boxPromedio.Text = Convert.ToString(prom);
                    }                    
  
                } catch (FormatException exc) {
                    System.Windows.Forms.MessageBox.Show("Datos Invalidos");
                }
              }
           
        }

        public double td(string coso)
        {
            
            return Convert.ToDouble(coso);
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            
            Alumno alumno;

            if (boxLegajo.Text == ""){
                System.Windows.Forms.MessageBox.Show("Ingrese un legajo");
            } else if(!IsDigitsOnly(boxLegajo.Text)) {
                System.Windows.Forms.MessageBox.Show("Ingrese un legajo valido");
            } else if(!alumnos.ContainsKey(Convert.ToInt16(boxLegajo.Text))){
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
    }

    
}
