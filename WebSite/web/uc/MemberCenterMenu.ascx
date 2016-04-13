<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MemberCenterMenu.ascx.cs" Inherits="web_uc_MemberCenterMenu" %>
<div class="member-sidebar">
	<ul class="ui pointing vertical menu">
		<li class="header item">用户中心</li>
		<%--<li class="active teal item"><a role="menuitem" tabindex="-1" href="<%= ResolveClientUrl("../../web/MemberCenter.aspx") %>">首页</a></li>--%>
		<%--<li class="item"><a role="menuitem" tabindex="-1" href="Cart.aspx">购物车</a></li>--%>
		<li class="item"><a role="menuitem" tabindex="-1" href="<%= ResolveClientUrl("../../web/OrderList.aspx") %>">订单管理</a></li>
		<%--<li class="item"><a role="menuitem" tabindex="-1" href="Favorite.aspx">收藏夹</a></li>--%>
		<li class="header item">我的配置</li>
		<%--<li class="item"><a role="menuitem" tabindex="-1" href="PointManage.aspx">积分管理</a></li>--%>
		<li class="item"><a role="menuitem" tabindex="-1" href="<%= ResolveClientUrl("../../web/AddressList.aspx") %>">收货地址</a></li>
		<li class="item"><a role="menuitem" tabindex="-1" href="<%= ResolveClientUrl("../MyData.aspx") %>">个人资料</a></li>
		<%--<li class="item"><a role="menuitem" tabindex="-1" href="SafeConfig.aspx">安全设置</a></li>--%>
		<li class="item"><a role="menuitem" tabindex="-1" href="<%= ResolveClientUrl("../../web/ModifyPass.aspx") %>">修改密码</a></li>
		<li class="item"><a role="menuitem" tabindex="-1" href="<%= ResolveClientUrl("../../Logout.aspx") %>">退出</a></li>
	</ul>
</div>