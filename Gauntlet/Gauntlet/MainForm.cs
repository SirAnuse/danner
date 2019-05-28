/*
 * Created by SharpDevelop.
 * User: DEV0003
 * Date: 14/05/2019
 * Time: 9:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gauntlet
{
	/// <summary>
	/// 	Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public const string VERSION = "0.1";
		
		private List<string> _values;
		
		private bool isRemoveEnabled {
			get {
				return listView.SelectedIndex != -1 ? listView.GetSelected(listView.SelectedIndex) : false;
			}
		}
		
		public MainForm()
		{
			InitializeComponent();
			_values = new List<string>();
		}
		
		void AddButtonClick(object sender, EventArgs e)
		{
			string inputValue = String.Empty;
			
			using (var inputForm = new AddInputForm()) {
				var result = inputForm.ShowDialog();
				if (result == DialogResult.OK)
					inputValue = inputForm.Value;
			}
			
			// No input.
			if (String.IsNullOrWhiteSpace(inputValue))
				return;
			
			_values.Add(inputValue);
			
			RefreshList();
		}
		
		void RemoveButtonClick(object sender, EventArgs e)
		{
			_values.RemoveAt(listView.SelectedIndex);
			RefreshList();
		}
		
		void ExitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void SnapButtonClick(object sender, EventArgs e)
		{
			_values.Snap();
			RefreshList();
			removeButton.Enabled = isRemoveEnabled;
		}
		
		void RefreshList() {
			listView.Items.Clear();
			foreach (var item in _values)
				listView.Items.Add(item);
			
			clearButton.Enabled = _values.Count > 0;
			removeButton.Enabled = isRemoveEnabled;
			
			countLabel2.Text = _values.Count.ToString();
		}
		
		void ListViewSelectedIndexChanged(object sender, EventArgs e)
		{
			removeButton.Enabled = isRemoveEnabled;
		}
		void AddListButtonClick(object sender, EventArgs e)
		{
			string inputValue = String.Empty;
			
			using (var inputForm = new AddListInputForm()) {
				var result = inputForm.ShowDialog();
				if (result == DialogResult.OK)
					inputValue = inputForm.Value;
			}
			
			string[] inputValues = inputValue.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
			
			// No input.
			if (String.IsNullOrWhiteSpace(inputValue))
				return;
			
			foreach (var i in inputValues)
				_values.Add(i);
			
			RefreshList();
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			_values.Clear();
			RefreshList();
		}
		
	}
}
