using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OopDemo.Models;

namespace OopDemo.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GameTime()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Square()
        {          
            Square sq = new Square(6.0,100);

            ViewBag.SquareSide = 6.0;
            ViewBag.SquareArea = sq.Area();

            return View();
        }

        [HttpPost]
        public int Square(int move)
        {
            Square sq = new Square(3.0, move);

            return sq.Left();
        }

        [HttpGet]
        public ActionResult Circle()
        {
            Circle cr = new Circle(5.0,100);

            ViewBag.CircleRadius = 5.0;
            ViewBag.CircleArea = cr.Area();

            return View();
        }

        [HttpPost]
        public int Circle(int move)
        {
            Circle cr = new Circle(3.0, move);

            return cr.Right();
        }

        [HttpGet]
        public ActionResult Triangle()
        {
            Triangle tr = new Triangle(3.0, 4.0,100);

            ViewBag.TriangleBase = 3.0;
            ViewBag.TriangleHeight = 4.0;
            ViewBag.TriangleArea = tr.Area();

            return View();
        }

        [HttpPost]
        public int Triangle(int move)
        {
            Triangle tr = new Triangle(3.0, 4.0, move);

            return tr.Up();
        }

        [HttpGet]
        public ActionResult Ecks()
        {
            Ecks ec = new Ecks(100);

            ViewBag.EcksArea = ec.Area();

            return View();
        }

        [HttpPost]
        public int Ecks(int move)
        {
            Ecks ec = new Ecks(move);

            return ec.Down();
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