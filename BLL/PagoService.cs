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
        public string Guardar(Pago pago)
        {
            bool seleccion = pagoRepository.Guardar(pago);
            if (seleccion == true)
            {
                return "*Guardado correctamente*";
            }
            else
            {
                return "*No se pudo almacenar*";
            }
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

        public List<Pago> ConsultarFecha(DateTime fecha)
        {
            return pagoRepository.ConsultarFecha(fecha);
        }
        public int CantidadServicioPublico()
        {
            return pagoRepository.CantidadServicioPublico();
        }
        public int CantidadComprasProveedores()
        {
            return pagoRepository.CantidadComprasProveedores();
        }
        public int CantidadPagosContratistas()
        {
            return pagoRepository.CantidadPagosContratistas();
        }
        public double SumaServicioPublico()
        {
            return pagoRepository.SumaServicioPublico();
        }
        public double SumaComprasProveedores()
        {
            return pagoRepository.SumaComprasProveedores();
        }
        public double SumaPagosContratistas()
        {
            return pagoRepository.SumaPagosContratistas();
        }
        public void GenerarArchivo(DateTime fecha)
        {
            pagoRepository.GenerarArchivo(fecha);
        }
    }
}
