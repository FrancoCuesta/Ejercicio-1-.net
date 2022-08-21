using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared
{
    public class Persona
    {
        private DateTime fechaNacimiento;
        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }
        public void SetFechaNacimiento(DateTime value)
        {
            fechaNacimiento = value;
        }
        public string Nombre { get; set; } = "--Sin Nombre--";
        private string documento = "";
        public string Documento
        {
            get { return documento; }
            set
            {
                if (value.Length < 7)
                    throw new Exception("Formato de documento incorrecto");
                else
                    documento = value.ToUpper();
            }
        }
        public string Mostrar()
        {
            return "Nombre: " + Nombre + "\n Documento: "+Documento + "\n Naciminento: " + fechaNacimiento+ "\n";
        }
    }
}
