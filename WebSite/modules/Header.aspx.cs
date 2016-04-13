﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Logic.Base;
using NPiculet.Logic.Business;
using NPiculet.Logic.Data;
using NPiculet.Logic.Sys;

public partial class modules_Header : AdminPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
	    //if (!Page.IsPostBack) { }
    }

	protected string GetMenuList()
	{
		SysMenuBus _bus = new SysMenuBus();
		List<SysMenu> menus = _bus.GetMainMenu();
		//string menuString = "", formatString = "<li><a href=\"Sidebar.aspx?id={0}\" target=\"sideFrame\">{1}</a></li>";
		string menuString = "", formatString = "<li><a href=\"#\" onclick=\"showSidebar(this, 'Sidebar.aspx?id={0}')\">{1}</a></li>";
		foreach (SysMenu menu in menus) {
			menuString += string.Format(formatString, menu.Id, menu.Name);
		}
		return menuString;
	}

	protected string GetPlatformName()
	{
		return new ConfigManager().GetWebConfig("PlatformName");
	}

	public string GetHeadIcon()
	{
		int userid = this.CurrentUserId;
		SysUserInfoBus bus = new SysUserInfoBus();
		string url = bus.GetUserHeadIcon(userid);
		if (url.Length < 3) {
			return "images/person.png";
		} else {
			return "../upFile/" + url;
		}
	}
}