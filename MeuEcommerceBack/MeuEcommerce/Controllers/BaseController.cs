﻿using MeuEcommerce.DAL;
using MeuEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuEcommerce.Controllers
{
    public class BaseController: Controller
    {
        protected Database _dal = new Database();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.Carrinho = GetCarrinho();
            base.OnActionExecuting(filterContext);
        }

        protected Carrinho GetCarrinho()
        {
            if (Session["carrinho"] == null)
            {
                Session["carrinho"] = new Carrinho();
            }
            return (Carrinho)Session["carrinho"];
        }



    }
}