using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public abstract class ComprobanteElectronico
    {
        public string Clave { get; set; }

        public DateTime Fecha { get; set; }

        public abstract void GenerarPDF();
    }


    public class FacturaElectronica : ComprobanteElectronico
    {

        public override void GenerarPDF()
        {
            throw new NotImplementedException();
        }
    }

    public class TiqueteElectronica : ComprobanteElectronico
    {

        public override void GenerarPDF()
        {
            throw new NotImplementedException();
        }
    }

    interface ICorreoFactura
    {
        void EnviarCorreo(ComprobanteElectronico comprobante);
    }


    public class EnviarCorreoFactura : ICorreoFactura 
    {

        public void EnviarCorreo(ComprobanteElectronico comprobante)
        {

            comprobante.GenerarPDF();
        }

    }

    public class MainProgram
    {
        EnviarCorreoFactura Enviador = new();

        public void Do()
        {
            FacturaElectronica facturaElectronica = new();
            facturaElectronica.Clave = "50661621616";
            TiqueteElectronica tiqueteElectronica = new();
            tiqueteElectronica.Clave = "506181878222";

            Enviador.EnviarCorreo(facturaElectronica);
            Enviador.EnviarCorreo(tiqueteElectronica);
        }
    }
}
