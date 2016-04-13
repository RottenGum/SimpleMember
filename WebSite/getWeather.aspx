<%@ Page Language="C#" AutoEventWireup="true" CodeFile="getWeather.aspx.cs" Inherits="getWeather" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >  
<HTML>  
<HEAD>  
<title>GetWeather</title>  
<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">  
<meta name="CODE_LANGUAGE" Content="C#">  
<meta name="vs_defaultClientScript" content="JavaScript">  
<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">  
</HEAD>  
<body>  
<form id="GetWeather" method="post" runat="server">  
<FONT face="宋体">  
<P>  
<asp:Label id="lblWeather" runat="server">Weather</asp:Label></P>  
<P>  
<asp:Button id="btnGet" runat="server" Text="Get Weather"> 
</asp:Button></P>  
<P>  
<asp:Label id="Weather2" runat="server">24小时天气</asp:Label></P>  
<P>  
<asp:Button id="btnGet2" runat="server" Text="天气预报"> 
</asp:Button></P>  
</FONT>  
</form>  
</body>  
</HTML>
