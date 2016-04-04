﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaObjectFinder.Logica
{
    public static class LogObjectFinder
    {
        /// <summary>
        /// Obtiene el número de objetos de acuerdo al estado
        /// 1- Activo
        /// 2- Inactivo
        /// </summary>
        /// <param name="idEstado"></param>
        /// <returns></returns>
       public static int getNroObjetos(int idEstado)
        {
            WsObjectfinder.WsObjectFinderClient objservicio = new WsObjectfinder.WsObjectFinderClient();

            try
            {
                //Estado: 1- Activos
                return objservicio.Get_Nro_Objetos(idEstado);
            }
            catch(Exception)
            {
                throw;
            }


        }

        public static ICollection<WsObjectfinder.entObjeto> getObjetos(int idEstado)
        {
            WsObjectfinder.WsObjectFinderClient objservicio = new WsObjectfinder.WsObjectFinderClient();

            try
            {
                return objservicio.Get_Objeto(idEstado);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static ICollection<WsObjectfinder.entMedia> GetImage(int idObjeto)
        {
            WsObjectfinder.WsObjectFinderClient objServicio = new WsObjectfinder.WsObjectFinderClient();

            try
            {
                return objServicio.Get_MediaxObjeto(idObjeto);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static void insertarObjeto(WsObjectfinder.entObjeto objeto)
        {
            WsObjectfinder.WsObjectFinderClient objServicio = new WsObjectfinder.WsObjectFinderClient();

            try
            {
                objServicio.Crear_Objeto(objeto);
            }
            catch(Exception)
            {

                throw;
            }
        }

        public static ICollection<WsObjectfinder.entCategoria> getCategoria()
        {
            WsObjectfinder.WsObjectFinderClient objServicio = new WsObjectfinder.WsObjectFinderClient();

            try
            {
                return objServicio.Get_Categoria();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}