/*
 * Created by SharpDevelop.
 * User: DEV0003
 * Date: 28/05/2019
 * Time: 10:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using DarrenGarbage.Screens;

namespace DarrenGarbage
{
	class Program
	{
        public const string VERSION = "0.0.1";
		public static void Main(string[] args)
        {
            Screen.LoadScreens();
            Screen.GoToScreen("MAIN_MENU");
			
			Console.ReadKey(true);
		}
	}
}