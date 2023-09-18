using MyFirstMvc.Models.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMvc.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Greet()
		{
			return View();
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

		public ActionResult Carts()
		{
			var model = new CartVm()
			{
				Items = new List<CartItemsVm>
				{
					new CartItemsVm
					{
						Id = 1,
						RoomType = "森林雙人房",
						RoomNumber = "201",
						CheckInDate = "2023-09-10",
						CheckOutDate = "2023-09-10",
						Days = 1,
						ExtraBed = false,
						ExtraPrice = 0,
						RoomPrice = 1000,
						SubTotal = 1000,
					},
					new CartItemsVm
					{
						Id = 2,
						RoomType = "河畔雙人房",
						RoomNumber = "104",
						CheckInDate = "2023-09-11",
						CheckOutDate = "2023-09-12",
						Days = 1,
						ExtraBed = true,
						ExtraPrice = 500,
						RoomPrice = 1000,
						SubTotal = 1500,
					}
				},
				Total = 2500,
				ExtraBedPrice = 500,
			};
			return View(model);
		}
	}
}