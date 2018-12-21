using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuEcommerce.Controllers
{
    public class HomeController  : BaseController
    {
        public ActionResult AddItem(int id, int? categoria)
        {
            var produto = _dal.GetProdutoPorId(id);
            var carrinho = GetCarrinho();
            carrinho.Add(produto);

            return RedirectToAction("Index", new { categoria = categoria });
        }

        public ActionResult Index(int? categoria)
        {
            //ViewBag.Carrinho = GetCarrinho();

            /*
            var model = new Models.HomeIndexViewModel();
            model.Produtos = new Models.Produto[4];
            model.Produtos[0] = new Models.Produto();
            model.Produtos[1] = new Models.Produto();
            model.Produtos[2] = new Models.Produto();
            model.Produtos[3] = new Models.Produto();
            */
            var model = new Models.HomeIndexViewModel();

            model.Produtos = _dal.GetProdutos();

            model.CategoriaSelecionada = categoria;

            model.Categorias = _dal.GetCategorias();




            if (categoria != null)
            {
                model.Produtos = model.Produtos
                    .Where(x => x.IdCategoria == categoria)
                    .ToArray();

            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}