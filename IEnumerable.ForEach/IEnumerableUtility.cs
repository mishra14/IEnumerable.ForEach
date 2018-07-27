using System;
using System.Collections.Generic;

namespace IEnumerable.ForEach
{
	public static class IEnumerableUtility
	{
		/// <summary>
		/// An extension method to perform an action for each element in an IEnumerable types.
		/// </summary>
		/// <typeparam name="T">Type of the IEnumerable.</typeparam>
		/// <param name="collection">IEnumerable collection.</param>
		/// <param name="action">Action to be performed on the Ienumerable elements.</param>
		public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
		{
			foreach (var item in collection)
			{
				action(item);
			}
		}
	}
}
