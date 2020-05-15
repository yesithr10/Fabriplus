using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{

    public class PagoService
    {
        PagoRepository pagoRepository = new PagoRepository();
        public void Guardar(Pago pago)
        {
            pagoRepository.Guardar(pago);
        }
        public List<Pago> Consultar()
        {
            return pagoRepository.Consultar();
        }
        public List<Pago> BuscarTipo(string tipo)
        {
            return pagoRepository.BuscarTipo(tipo);
        }

        public int CantidadPagos()
        {
            return pagoRepository.CantidadPagos();
        }
        public double SumarPagos()
        {
            return pagoRepository.SumarPagos();
        }
    }
}
