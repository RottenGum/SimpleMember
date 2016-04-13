<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DashBoard.aspx.cs" Inherits="modules_DashBoard" %>

<%@ Register Src="common/CssScriptQuote.ascx" TagName="CssScriptQuote" TagPrefix="uc" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>DashBoard</title>
	<uc:CssScriptQuote ID="CssScriptQuote1" runat="server" />
	<script src="../scripts/charts/highcharts.js" type="text/javascript"></script>
	<script src="../scripts/charts/themes/grid.js" type="text/javascript"></script>
	<style type="text/css">
		.dashboard-warp { padding: 10px; }
		ul li { line-height: 2em; color: #666; }
		.htitle { height: 38px; background-color: #e9f2f7; padding-top: 5px; font-size: 16px; padding-left: 10px; color: #3386e8; }
		.widget { border: 1px solid #c2c2c2; margin-bottom: 10px; margin-right: 5px; margin-top: 30px; }
		
		#total td { border-bottom: 1px #c2c2c2 dashed; }
	</style>
	<script type="text/javascript">
		var chart;
		$(function () {
			chart = new Highcharts.Chart({
				chart: {
					renderTo : 'container',
					type: 'area'
				},
				title: {
					text: '最近 48 小时会员新增量分析'
				},
				subtitle: {
					text: '（5分钟/每点）'
				},
				xAxis: {
					categories: [<%= GetChartXAxis() %>],
					tickInterval: 20,
					labels: {
						formatter: function() {
							return this.value; // clean, unformatted number for year
						}
					}
				},
				yAxis: {
					title: {
						text: '会员人数'
					},
					labels: {
						formatter: function() {
							return this.value;
						}
					}
				},
				tooltip: {
					pointFormat: '{series.name} <b>{point.y:,.0f}</b>'
				},
				plotOptions: {
					area: {
						pointStart: 0,
						marker: {
							enabled: false,
							symbol: 'circle',
							radius: 2,
							states: {
								hover: {
									enabled: true
								}
							}
						}
					}
				},
				series: [{
					name: '时段新增量',
					data: [<%= GetChartSeries() %>]
				}]
			});
		});
		var timer = setInterval(function() {
			$.ajax({
				type: "post",
				url: "../api/chart-reg-analyze",
				dataType: "json",
				success : function(data) {
					try {
						console.log(JSON.stringify(data.series));
						console.log(JSON.stringify(data.categories));
						chart.series[0].setData(data.series);
						chart.xAxis[0].setCategories(data.categories);
					} catch (ex) { }
				}
			});
		}, 30000);
	</script>
</head>

<body>

<form id="frm" runat="server">
    <div>
		<div>
			<section class="dashboard-warp">
				<div>
					<div class="ui grid">
						<div class="eight wide column">
							<hr />
							<h3>欢迎回来，<%= this.CurrentUserName %></h3>
							<hr />
                               <iframe width="800" scrolling="no" height="120" frameborder="0" allowtransparency="true" src="http://i.tianqi.com/index.php?c=code&id=19&icon=1&temp=1&num=3"></iframe>
						</div>
						<div class="eight wide column">
							<hr />
							<h3>登录日志</h3>
							<hr />
							<p>
								<ul>
									<asp:Repeater runat="server" ID="loglist">
										<ItemTemplate>
											<li>登录时间：<%# Eval("Date", "{0:yyyy-MM-dd HH:mm:ss}") %>，登录信息：<%# Eval("Comment") %></li>
										</ItemTemplate>
									</asp:Repeater>
								</ul>
							</p>
						</div>
					</div>
				</div>
				<div class="clear">
					&nbsp;</div>
			</section>
		</div>
	
	</div>
    <div style="padding:10px;width:100%;height:100%;">
		<div style="padding:10px;font-size:14px;">今日新增会员：<asp:Literal runat="server" ID="regToday"></asp:Literal>&nbsp;&nbsp;&nbsp;&nbsp;昨日新增会员：<asp:Literal runat="server" ID="regYesterday"></asp:Literal>&nbsp;&nbsp;&nbsp;&nbsp;前日新增会员：<asp:Literal runat="server" ID="regBeforeYesterday"></asp:Literal>&nbsp;&nbsp;&nbsp;&nbsp;会员总数：<asp:Literal runat="server" ID="totalCount"></asp:Literal></div>
		<div id="container" style="min-width:500px;width:100%;height:100%;margin:0 auto;"></div>
	</div>
</form>
</body>

</html>
