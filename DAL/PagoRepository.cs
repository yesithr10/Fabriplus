﻿using System;
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
        List<Pago> pagos = new List<Pago>();
        Pago pago;
        public bool Guardar(Pago pago)
        {
            try
            {
                FileStream file = new FileStream(ruta, FileMode.Append);
                StreamWriter escritor = new StreamWriter(file);
                escritor.WriteLine($"{pago.TipoPago};{pago.Identificacion};{pago.Nombre};{pago.FechaPago.ToString("dd/MM/yyyy")};{pago.ValorPagar}");
                escritor.Close();
                file.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
                
        }
        public List<Pago> Consultar()
        {
            string linea = string.Empty;
            List<Pago> pagos = new List<Pago>();
            FileStream SourceStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader Reader = new StreamReader(SourceStream);

            while ((linea = Reader.ReadLine()) != null)
            {
                Pago pago = Mapear(linea);
                pagos.Add(pago);
            }
            Reader.Close();
            SourceStream.Close();
            return pagos;
        }
        private static Pago Mapear(string linea)
        {
            Pago pago = new Pago();
            string[] arrayPago = linea.Split(';');
            pago.TipoPago = arrayPago[0];
            pago.Identificacion = arrayPago[1];
            pago.Nombre = arrayPago[2];
            pago.FechaPago = Convert.ToDateTime(arrayPago[3]);
            pago.ValorPagar = Convert.ToDouble(arrayPago[4]);
            return pago;
        }
         public List<Pago> BuscarTipo(string tipo)
        {
            pagos.Clear();
            pagos = Consultar();
            return pagos.Where(w => w.TipoPago == tipo).ToList();
        }
        public int CantidadPagos()
        {
            return pagos.Count(); 
        }
        public int CantidadServicioPublico()
        {
            return pagos.Where(p => p.TipoPago.Equals("Servicio publico")).Count();
        }
        public int CantidadComprasProveedores()
        {
            return pagos.Where(p => p.TipoPago.Equals("Compras a proveedores")).Count();
        }
        public int CantidadPagosContratistas()
        {
            return pagos.Where(p => p.TipoPago.Equals("Pagos a contratistas")).Count();
        }

        public double SumaServicioPublico()
        {
            return pagos.Where(p => p.TipoPago.Equals("Servicio publico")).Sum(p => p.ValorPagar);
        }
        public double SumaComprasProveedores()
        {
            return pagos.Where(p => p.TipoPago.Equals("Compras a proveedores")).Sum(p => p.ValorPagar);
        }
        public double SumaPagosContratistas()
        {
            return pagos.Where(p => p.TipoPago.Equals("Pagos a contratistas")).Sum(p => p.ValorPagar);
        }
        public double SumarPagos()
        {
            return pagos.Sum(l => l.ValorPagar);
        }
        public List<Pago> ConsultarFecha(DateTime fecha)
        {
            return pagos.Where(l => l.FechaPago.Month == fecha.Month && l.FechaPago.Year == fecha.Year).ToList();
        }
        public void GenerarArchivo(DateTime fecha)
        {
            List<Pago> busquedaFecha = ConsultarFecha(fecha);
            if (busquedaFecha.Count == 0)
                return;
            FileStream origenFlujo = new FileStream($"PAGOS{fecha.ToString("ddMMyyyy")}.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escritor = new StreamWriter(origenFlujo);

            escritor.WriteLine($"Servicio publico;{SumaServicioPublico()};{CantidadServicioPublico()}");
            escritor.WriteLine($"Compras a proveedores;{SumaComprasProveedores()};{CantidadComprasProveedores()}");
            escritor.WriteLine($"Pagos a contratistas;{SumaPagosContratistas()};{CantidadPagosContratistas()}");
            escritor.Close();
        }

    }
}
