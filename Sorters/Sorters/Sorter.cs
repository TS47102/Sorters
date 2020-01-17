using System;

namespace Sorters
{
	public static class Sorter
	{
		/// <summary>
		/// Sorts the <paramref name="array"/>, using the given <see cref="SortType"/>.
		/// </summary>
		/// <remarks>This method mutates the given <paramref name="array"/>, rather than creating and returning a new array.</remarks>
		/// <typeparam name="T">The datatype of the <paramref name="array"/> to be sorted.</typeparam>
		/// <param name="array">The array to be sorted.</param>
		/// <param name="sortType">The <see cref="SortType"/> to detemine which sorting algorithm to use.</param>
		public static void sort<T> (this T [] array, SortType sortType) where T : IComparable<T>
		{
			switch (sortType)
			{
				case SortType.Bubble:
					bubbleSort (array);
					break;
				case SortType.Merge:
					mergeSort (array);
					break;
				case SortType.Quick:
					quickSort (array);
					break;
			}
		}

		private static void bubbleSort<T> (T [] array) where T : IComparable<T>
		{

		}

		private static void mergeSort<T> (T [] array) where T : IComparable<T>
		{

		}

		private static void quickSort<T> (T [] array) where T : IComparable<T> => quickSort (array, 0, array.Length - 1);
		private static void quickSort<T> (T [] array, int leftPointerIndex, int rightPointerIndex) where T : IComparable<T>
		{
			if (array.Length <= 1 || leftPointerIndex >= rightPointerIndex)
				return;

			int pivotIndex = quickSortPartition (array, leftPointerIndex, rightPointerIndex);
			quickSort (array, leftPointerIndex, pivotIndex);
			quickSort (array, pivotIndex + 1, rightPointerIndex);
		}

		private static int quickSortPartition<T> (T [] array, int leftPointerIndex, int rightPointerIndex) where T : IComparable<T>
		{
			T pivotValue = array [leftPointerIndex + (rightPointerIndex - leftPointerIndex) / 2];

			while (true)
			{
				T rightPointerValue = array [rightPointerIndex];
				T leftPointerValue = array [leftPointerIndex];

				while (pivotValue.CompareTo (rightPointerValue) < 0)
					rightPointerValue = array [--rightPointerIndex];

				while (pivotValue.CompareTo (leftPointerValue) > 0)
					leftPointerValue = array [++leftPointerIndex];

				if (leftPointerIndex >= rightPointerIndex)
					return rightPointerIndex;
				else
				{
					array [leftPointerIndex] = rightPointerValue;
					array [rightPointerIndex] = leftPointerValue;
				}
			}
		}

		public enum SortType
		{
			Bubble,
			Merge,
			Quick
		}
	}
}
