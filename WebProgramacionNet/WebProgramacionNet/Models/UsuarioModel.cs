using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProgramacionNet.Entities;

namespace WebProgramacionNet.Models
{
    public class UsuarioModel
    {
        //logica de negocio

        public void IniciarSesion (UsuarioEnt entidad)
        {
            // LLAMAR A LA BASE DE DATOS PARA VALIDAR EL ACCESO DEL USUARIO
            // EN ESTE CASO POR TEMAS DE REQUERIMIENTOS NO SE LLAMARÁ DIRECTAMENTE A LA BASE DE DATOS
            // SE LLAMARA AL WEB API, EL WEB API ACCEDE A LA BD Y PROCESA LA LOGICA DE NEGOCIOS


        }


        public void RecuperarCuenta(UsuarioEnt entidad)
        {
            // LLAMAR A LA BASE DE DATOS PARA REGISTRAR EL USUARIO
            // EN ESTE CASO POR TEMAS DE REQUERIMIENTOS NO SE LLAMARÁ DIRECTAMENTE A LA BASE DE DATOS
            // SE LLAMARA AL WEB API, EL WEB API ACCEDE A LA BD Y PROCESA LA LOGICA DE NEGOCIOS


        }


        public void RegistarCuenta(UsuarioEnt entidad)
        {
            // LLAMAR A LA BASE DE DATOS PARA VALIDAR SI ES UN USUARIO VALIDO Y LE MANDO UN CORREO
            // EN ESTE CASO POR TEMAS DE REQUERIMIENTOS NO SE LLAMARÁ DIRECTAMENTE A LA BASE DE DATOS
            // SE LLAMARA AL WEB API, EL WEB API ACCEDE A LA BD Y PROCESA LA LOGICA DE NEGOCIOS
        }




    }
}