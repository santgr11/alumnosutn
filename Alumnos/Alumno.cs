using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class Alumno

   

    {
        private string nombre;
        private double nota1;
        private double nota2;
        private double nota3;
        private int legajo;

        public Alumno(string nombre, int legajo, double nota1, double nota2, double nota3)
        {
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Nombre = nombre;
            this.legajo = legajo;
        }

        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Boolean notasExisten()
        {
            return (this.Nota1 == null || this.Nota2 == null || this.Nota3 == null);
           
        }

        public double getPromedio() {
            return Math.Round((Nota1 + Nota2 + Nota3) / 3.0, 2);
        }
        public int condicion()
        {
            if (this.getPromedio() >=8) {

                return 1; // "Promocional";


            } else if (this.getPromedio() >=6 ) {
                return 2; // "Regular";

            }else{
                return 3; // "Libre";

            }
       
        }
        public string mostrarCondicion()
        {
            switch (this.condicion()) 
            {
                case 1:
                    return "Promocional";
                    
                case 2:
                    return "Regular";
                   
                case 3:
                    return "Libre";
                    
                default:
                    return "Error";
                    
                   
            }
        }
	

	}
 }

