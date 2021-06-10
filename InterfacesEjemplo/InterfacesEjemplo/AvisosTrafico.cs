using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesEjemplo
{
    class AvisosTrafico : IAvisos
    {
        //implementados dos constructores uno sin parametros y otro con parametros 

        public AvisosTrafico()
        {
            remitente = "Transito";
            mensaje = "Tienes una infacción, pague antes de tres días y s ebeneficiara en una reducción del 50%";
            fecha =""; 
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public string GetFecha()
        {

            return fecha;
            //throw new NotImplementedException();
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido emviado por {1}, el día {2}",mensaje,remitente,fecha);
            //throw new NotImplementedException();
        }

        private string remitente;
        private string mensaje;
        private string fecha;
    }
}
