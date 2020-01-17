using System;

namespace Sorters
{
	public static class Program
	{
		private static int[] values = { 8, 1, 6, 2, 4 };

		public static void Main ()
		{
			Console.WriteLine ($"Quicksorting values: {{ {string.Join (", ", values)} }}");
			values.sort (Sorter.SortType.Quick);
			Console.WriteLine ($"Sorted values: {{ {string.Join (", ", values)} }}");

			Console.ReadKey ();
		}
	}
}
