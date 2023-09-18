﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MyFirstMvc.Models.ViewModels.Home
{
	public class CartItemsVm
	{
		/// <summary>
		/// 購物車明細ID
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// 房型
		/// </summary>
		[Display(Name = "房型")]
		public string RoomType { get; set; }

		/// <summary>
		/// 房號
		/// </summary>
		[Display(Name = "房號")]
		public string RoomNumber { get; set; }

		/// <summary>
		/// 入住日
		/// </summary>
		[Display(Name = "入住日")]
		public string CheckInDate { get; set; }

		/// <summary>
		/// 退房日
		/// </summary>
		[Display(Name = "退房日")]
		public string CheckOutDate { get; set; }

		/// <summary>
		/// 夜數
		/// </summary>
		[Display(Name = "夜數")]
		public int Days { get; set; }

		/// <summary>
		/// 單價
		/// </summary>
		[Display(Name = "單價")]
		public int RoomPrice { get; set; }

		/// <summary>
		/// 是否加床
		/// </summary>
		[Display(Name = "是否加床")]
		public bool ExtraBed { get; set; }

		/// <summary>
		/// 加床金額
		/// </summary>
		[Display(Name = "加床金額")]
		public int ExtraPrice { get; set; }

		/// <summary>
		/// 金額
		/// </summary>
		[Display(Name = "金額")]
		public int SubTotal { get; set; }
	}
}