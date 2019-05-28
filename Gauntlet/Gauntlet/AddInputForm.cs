/*
 * Created by SharpDevelop.
 * User: DEV0003
 * Date: 14/05/2019
 * Time: 10:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gauntlet
{
	/// <summary>
	/// Description of AddInputForm.
	/// </summary>
	public partial class AddInputForm : Form
	{
		public string Value { get { return valueBox.Text; } }
		public AddInputForm()
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
