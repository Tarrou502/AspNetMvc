using MeuEcommerce.DAL;
using MeuEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuEcommerce.Controllers
{
    public class CheckoutController : BaseController
    {
       

        // GET: Chekout
        public ActionResult Index()
        {
            var model = new CheckoutIndexViewModel();
            //preencher
            model.Carrinho = GetCarrinho(); 
            return View(model);
        }

        public ActionResult Incrementa(int id)
        {
            var model = new CheckoutIndexViewModel();
            model.Carrinho = GetCarrinho();
            model.Carrinho.Incrementa(id);
            //Session["Carrinho"] = model.Carrinho;
            return RedirectToAction("Index");            
        }

        public ActionResult Decrementa(int id)
        {
            var model = new CheckoutIndexViewModel();
            //preencher
            model.Carrinho = GetCarrinho();
            model.Carrinho.Decrementa(id);
            
            return RedirectToAction("Index");

        }
        public ActionResult Remover(int id)
        {
            var model = new CheckoutIndexViewModel();
            //preencher
            model.Carrinho = GetCarrinho();
            model.Carrinho.Remove(id);
           // Session["Carrinho"] = model.Carrinho;

            return RedirectToAction("Index");

        }

        public ActionResult Limpar()
        {
            //preencher
            Carrinho Carrinho = GetCarrinho();
            Carrinho.Limpar();


            //return Redirect("/Home/Index");
            return RedirectToAction(ActionName: "Index", ControllerName:"Home");

        }
        /*
        public ActionResult Index(String acao, int produtoId)
        {
            var model = new CheckoutIndexViewModel();
            model.Carrinho = GetCarrinho();

            switch (acao){
                case "incrementa":
                    Produto _produto = GetProdutos().First(p => p.Id == produtoId);
                    model.Carrinho.Add(_produto);
                    Session["Carrinho"] = model.Carrinho;
                    break;
                case "decrementa":

                    break;
                case "remover":
                    break;
            }
            return View(model);
        }
        */
    }
}