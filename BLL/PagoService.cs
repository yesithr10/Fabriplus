﻿using System;
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
        PagoRepository pagoRepository= new PagoRepository();
        public void Guardar(Pago pago)
        {
            pagoRepository.Guardar(pago); 
        }
    }
}
