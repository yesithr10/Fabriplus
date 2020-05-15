using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class PagoRepository
    {
        string ruta = "pago.txt";
        public bool Guardar(Pago pago)
        {
            try
            {
                FileStream file = new FileStream(ruta, FileMode.Append);
                StreamWriter escritor = new StreamWriter(file);
                escritor.WriteLine($"{pago.TipoPago};{pago.Identificacion};{pago.Nombre};{pago.Fecha};{pago.ValorPagar}");
                escritor.Close();
                file.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
                
        }
    }
}
