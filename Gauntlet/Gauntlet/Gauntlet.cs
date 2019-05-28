/*
 * Created by SharpDevelop.
 * User: DEV0003
 * Date: 14/05/2019
 * Time: 9:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauntlet
{
	public static class Gauntlet
	{
		private static string[] snapQuotes = {
			"You should've gone for the head.",
			"I... am... inevitable."
		};
		
		public static string GetRandQuote() 
		{
			return snapQuotes[new Random().Next(0, snapQuotes.Length - 1)];
		}
		
		public static void Snap<T>(this List<T> list)
		{
			List<int> indexesToRemove = new List<int>();
			
			int snapCount = 0;
			int snapTarget = list.Count / 2;
			
			Random rand = new Random();
			
			while (snapCount < snapTarget) {
				for (int i = 0; i < list.Count; i++) {
					if (snapCount >= snapTarget)
						continue;
					
					// 50% chance
					if (rand.Next(0, 2) > 0
					    && !indexesToRemove.Contains(i)) {
						snapCount++;
						indexesToRemove.Add(i);
					}
				}
			}
			
			Dictionary<int, T> tempDict = new Dictionary<int, T>();
			
			for (int i = 0; i < list.Count; i++)
				tempDict.Add(i, list[i]);
			
			for (int i = 0; i < indexesToRemove.Count; i++)
				tempDict.Remove(indexesToRemove[i]);
			
			list.Clear();
			list.AddRange(tempDict.Values);
		}
	}
}
