/*
 * Created by SharpDevelop.
 * User: DEV0003
 * Date: 28/05/2019
 * Time: 10:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DarrenGarbage
{
	/// <summary>
	/// Description of Input.
	/// </summary>
	public static class Inputs
	{
		public static string MenuInput (string headerText, string[] options, bool overflow = false) {
			
			int index = 0;
			bool selected = false;
			
			while (!selected) {
				Console.Clear();
				Console.WriteLine(headerText);
				for (int i = 0; i < options.Length; i++) {
					Console.WriteLine(i != index ? options[i] : "> " + options[i]);
				}
				
				var input = Console.ReadKey();
				switch (input.Key) {
					case ConsoleKey.UpArrow:
						index = index > 0 ? index - 1 : overflow ? options.Length - 1 : index;
						break;
					case ConsoleKey.DownArrow:
						// basically don't overflow if overflow is disabled, do if it is
						// to get the grasp of what this is, it's a nested ternary
						index = index < options.Length - 1 ? index + 1 : overflow ? 0 : index;
						break;
					case ConsoleKey.Enter:
						selected = true;
						break;
				}
			}
			
			return options[index];
		}
	}
}
