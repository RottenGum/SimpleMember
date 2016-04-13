using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPiculet.Draw2D;

public partial class modules_common_verifycode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
	{
		//取得验证码数据
		string outValue;
		Bitmap img = Create(4, 50, 20, 38, out outValue);

		//输出到浏览器
		MemoryStream ms = new MemoryStream();
		img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
		HttpContext.Current.Response.ClearContent();
		HttpContext.Current.Response.ContentType = "image/Jpeg";
		HttpContext.Current.Response.BinaryWrite(ms.ToArray());

		Session["_VerifyCode_"] = outValue;
    }

	private Bitmap Create(int charNumber, int mixNumber, int charWidth, int imgHeight, out string outValue) {
		outValue = String.Empty;

		Bitmap img = new Bitmap(charWidth * charNumber + charNumber, imgHeight);//建立图片
		Graphics g = Graphics.FromImage(img);//建立画板
		g.Clear(Color.White);//清理画板

		//字符随机颜色
		Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.DarkGreen, Color.DarkOrchid, Color.Brown, Color.DarkCyan, Color.Purple };
		//杂点随机颜色
		Color[] cs = { Color.PapayaWhip, Color.PaleTurquoise, Color.PaleGreen, Color.Pink };
		//随机式样
		FontStyle[] fs = { FontStyle.Bold, FontStyle.Italic, FontStyle.Regular };
		//定义随机数
		Random rnd = new Random();
		//生成糙点
		for (int i = 0; i < mixNumber; i++) {
			Brush b = new SolidBrush(cs[rnd.Next(4)]);
			Pen p = new Pen(b);
			Point p1 = new Point(rnd.Next(img.Width), rnd.Next(img.Height));
			Point p2 = new Point(rnd.Next(img.Width), rnd.Next(img.Height));
			g.DrawLine(p, p1, p2);
		}
		//生成文字
		for (int i = 0; i < charNumber; i++) {
			//设置字体
			Font f = new Font(FontFamily.GenericMonospace, charWidth, fs[rnd.Next(3)]);
			Brush b = new SolidBrush(c[rnd.Next(8)]);

			//生成随机字符
			string chars = "123456789abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ";
			int index = rnd.Next(chars.Length);
			string chr = chars.Substring(index, 1);

			outValue += chr;
			g.DrawString(chr, f, b, i * charWidth, rnd.Next(imgHeight - imgHeight / 2) - 6);
		}

		g.Dispose();
		return img;
	}

}