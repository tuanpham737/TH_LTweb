﻿using Microsoft.AspNetCore.Mvc;
using Thuchanh_LTweb.Models;

namespace ThucHanh1.ViewComponents
{
	public class RenderViewComponent : ViewComponent
	{
		private List<MenuItem> MenuItems = new List<MenuItem>();
		public RenderViewComponent()
		{
			MenuItems = new List<MenuItem>()
			{
				new MenuItem() {Id = 1,Name="Branches",Link= "Branches/list"},
				new MenuItem() {Id = 2,Name="Students",Link= "Students/list"},
				new MenuItem() {Id = 3,Name="Subjects",Link= "Subjects/list"},
				new MenuItem() {Id = 4,Name="Courses",Link= "Courses/list"},
			};
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View("RenderLeftMenu", MenuItems);
		}
	}
}