using AppPresencial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AppPresencial.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Descripcion()
        {
            var empleados = new ClsEmpleado { Usuario = "Alex", DUI = 1111 };
            
            return View(empleados);
        }

        public ActionResult Editar(string Nombre, int Hora)
        {
            ClsEmpleado emp = new ClsEmpleado();
            emp.Nombre = Nombre;
            emp.Hora = Hora;

            ViewBag.Nombe = Nombre;
            ViewBag.Hora = Hora;

            double U = 30;
            double A = 1;
            double DESCUENTO = 13;
            double HORASTRABAJADAS = 2;

            U* A;

            
           
     
            return View(emp);
        }
  
        //private bool IsValid (string usuario,int DUI)
        //{
        //   // throw new NotImplementedException();
        //}
        //ViewBag.Usuario = "";
        //ViewBag.DUI = "";

        //return Redirect("/Empleado/Editar");
    }

       
    }
