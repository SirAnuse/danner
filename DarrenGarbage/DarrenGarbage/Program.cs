/*
 * Created by SharpDevelop.
 * User: DEV0003
 * Date: 28/05/2019
 * Time: 10:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DarrenGarbage
{
	class Program
	{
		public static void Main(string[] args)
		{
			string menu = " ______   ___  ______ ______  _____  _   _ \n" +
						  " |  _  \\ / _ \\ | ___ \\| ___ \\|  ___|| \\ | |\n" +
						  " | | | |/ /_\\ \\| |_/ /| |_/ /| |__  |  \\| |\n" +
						  " | | | ||  _  ||    / |    / |  __| | . ` |\n" +
						  " | |/ / | | | || |\\ \\ | |\\ \\ | |___ | |\\  |\n" +
				" |___/  \\_| |_/\\_| \\_|\\_| \\_|\\____/ \\_| \\_/\n";

                                          
			string input = Inputs.MenuInput(menu, new string[]{ "Play", "Options", "Exit" }, true);
			
			Console.WriteLine(input);
			
			Console.ReadKey(true);
		}
	}
}