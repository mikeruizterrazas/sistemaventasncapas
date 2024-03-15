﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
    public class ClienteDAL
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values('" + cliente.idcliente + "','" + cliente.tipocliente + "','" + cliente.codigoclie + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }


    }
}
