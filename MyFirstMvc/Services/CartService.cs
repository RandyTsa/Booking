using MyFirstMvc.Models.Repositories;
using MyFirstMvc.Models.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static MyFirstMvc.MvcApplication;

namespace MyFirstMvc.Services
{
	public class CartService
	{
		public CartVm Get(int memberId)
		{
			var vm = new CartVm();
			var cartRepo = new CartRepository();
			var cartItemRepo = new CartItemsRepository();

			var cart = cartRepo.GetByMember(memberId);
			var cartItem = cartItemRepo.GetByCart(cart.Id);

			vm = AutoMapperHelper.MapperObj.Map<CartVm>(cart);
			vm.Items = AutoMapperHelper.MapperObj.Map<List<CartItemsVm>>(cartItem);

			return vm;
		}
	}
}