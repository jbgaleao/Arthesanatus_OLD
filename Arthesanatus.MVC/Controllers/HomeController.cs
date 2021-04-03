using Arthesanatus.Data.Context;
using Arthesanatus.Domain.Entities;
using Arthesanatus.Repository.Implements;
using Arthesanatus.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arthesanatus.MVC.Controllers
{
    public class HomeController : Controller
    {
        protected readonly ArthesContext contexto = new ArthesContext();
        // GET: Home
        public ActionResult Index( )
        {
            IncluiRevista();
            return View();
        }
        
        private void IncluiRevista( )
        {
            Revista revista = new Revista()
            {
                AnoEdicao = 2021,
                MesEdicao = Mes.MARÇO,
                NumeroEdicao = 59,
                Tema = "Espacial"
            };
            //contexto.REVISTAS.Add( revista );
            //contexto.SaveChanges();

            IRepositorio<Revista> repositorio = new Repositorio<Revista>();
            repositorio.Adicionar( revista );

        }
    }
}