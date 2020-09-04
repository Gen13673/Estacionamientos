using System;
using System.Collections.Generic;
using System.Text;

namespace Estacionamientos
{
    class Cajero
    {
        public int importe;
        public int cambio;
        public Respuesta respuesta;

        public Respuesta calcularRespuesta(string ticket)
        {
            importe = Int32.Parse(ticket);
            respuesta.importe = importe;
            if (cambio>0)
            {
                respuesta.hayCambio = true;
            }
            else
            {
                respuesta.hayCambio = false;
            }
            return respuesta;
        }
        public int devolverCambio(int dinero)
        {
            int cambioADevolver = 0;

            if ((dinero - respuesta.importe) > 0)
            {
                cambioADevolver = dinero - respuesta.importe;
            }
            return cambioADevolver;
        }
        public string devolverTicket()
        {
            string ticket = importe.ToString();
            return ticket;
        }
        public void sonarPitido()
        {

        }
        public void tragarTicket()
        {

        }

    }
}
