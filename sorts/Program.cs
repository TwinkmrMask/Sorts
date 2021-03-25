using System;
using System.Collections.Generic;
using System.Linq;

namespace sorts
{
	class Program : defaultList
	{
		
		static void print(List<int> list)
		{
			foreach (int i in list)
				Console.Write(i + " ");
			Console.WriteLine();

		}
		static Action load = () =>
		{
			using (PanecakeSort sort = new PanecakeSort())
			{
				var listBySort = List.ToList();
				print(listBySort);
				print(sort.Sort(listBySort).ToList());
			}
			using (BubbleSort sort = new BubbleSort())
			{
				var listBySort = List.ToList();
				print(listBySort);
				print(sort.Sort(listBySort).ToList());
			}
			using (InsertionSort sort = new InsertionSort())
			{
				var listBySort = List.ToList();
				print(listBySort);
				print(sort.Sort(listBySort).ToList());
			}
			Console.ReadKey(true);
		};
		static void Main(string[] args)
		{
			load();
		}
	}
	public class PanecakeSort : IDisposable
	{
		//the algorithm of Bill Gates and Christos Papadimitriou
		public IList<T> Sort<T>(IList<T> arr, int cutoffValue = 2) where T : IComparable
		{
			for (int i = arr.Count - 1; i >= 0; --i)
			{
				int pos = i;
				for (int j = 0; j < i; j++)
				{
					if (arr[j].CompareTo(arr[pos]) > 0)
					{
						pos = j;
					}
				}
				if (pos == i)
				{
					continue;
				}
				if (pos != 0)
				{
					Flip(arr, pos + 1);
				}
				Flip(arr, i + 1);
			}
			return arr;
		}
		private static void Flip<T>(IList<T> arr, int n) where T : IComparable
		{
			for (int i = 0; i < n; i++)
			{
				--n;
				T tmp = arr[i];
				arr[i] = arr[n];
				arr[n] = tmp;
			}
		}
		public void Dispose() { Console.WriteLine("Sorted by Panecake sort\n"); }
	}
	public class BubbleSort : IDisposable
	{
		static void swap(List<int> list, int i, int j)
		{
			int temp = list[i];
			list[i] = list[j];
			list[j] = temp;
		}
		public List<int> Sort(List<int> arr)
		{
			for (int i = 0; i < arr.Count; i++)
				for (int j = 0; j < arr.Count; j++)
					if (arr[i] < arr[j])
						swap(arr, i, j);
			return arr;
		}
		public void Dispose()
		{
			Console.WriteLine("Sorted by Bubble Sort\n");
		}
	}
	public class InsertionSort : IDisposable
    {
		static void swap(List<int> list, int i, int j)
		{
			int temp = list[i];
			list[i] = list[j];
			list[j] = temp;
		}
		public void Dispose()
        {
			Console.WriteLine("Sorted by Insertion Sort");
        }

        //сортировка вставками
        public List<int> Sort(List<int> arr)
		{
			for (int i = 1; i < arr.Count; i++)
				for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
					swap( arr, j - 1, j);
			return arr;
		}
	}
}

