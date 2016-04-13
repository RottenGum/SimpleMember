﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class system_UserControls_Prompt : System.Web.UI.UserControl
{
	/// <summary>
	/// 提示内容
	/// </summary>
	public string PromptContent { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

	private void ShowPrompt(string msg, string css, params object[] args)
	{
		this.prompt.Attributes["class"] = css;
		this.promptContent.Text = string.Format(msg, args);
		this.prompt.Visible = true;
	}

	public void Hide()
	{
		this.prompt.Visible = false;
	}

	public void ShowSuccess(string msg, params object[] args)
	{
		ShowPrompt(msg, "prompt ui green message", args);
	}

	public void ShowWarning(string msg, params object[] args)
	{
		ShowPrompt(msg, "prompt ui yellow message", args);
	}

	public void ShowInfo(string msg, params object[] args)
	{
		ShowPrompt(msg, "prompt ui blue message", args);
	}

	public void ShowError(string msg, params object[] args)
	{
		ShowPrompt(msg, "prompt ui red message", args);
	}
}