using MyFirstMvc.Models.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMvc.Models.ViewModels.Home
{
	public class CartVm
	{
		public int Total { get; set; }

		public int ExtraBedPrice { get; set; }

		public List<CartItemsVm> Items { get; set; }
	}
}