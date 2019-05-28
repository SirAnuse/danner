/*
 * Created by SharpDevelop.
 * User: DEV0003
 * Date: 23/05/2019
 * Time: 12:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gauntlet
{
	/// <summary>
	/// Description of AddListInputForm.
	/// </summary>
	public partial class AddListInputForm : Form
	{
		public string Value { get { return inputBox.Text; } }
		public AddListInputForm()
		{
			InitializeComponent();
		}
		
		void AddButtonClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
		void CancelButtonClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
