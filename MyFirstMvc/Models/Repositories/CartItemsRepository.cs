using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMvc.Models.Repositories
{
	public class CartItemsRepository : BaseRepository<CartItem>
	{
		private AppDbContext _db = new AppDbContext();

		/// <summary>
		/// 取得購物車明細
		/// </summary>
		/// <param name="cartId">購物車key</param>
		/// <returns></returns>
		public List<CartItem> GetByCart(int cartId)
		{
			return _db.CartItems.Where(x => x.CartId == cartId).ToList();
		}
	}
}