using System;
using System.Collections.Generic;

namespace DZ_20_02 {
	class Program {
		static void Main(string[] args) {
			int[] array1 = new int[10] { 22, 3, 4, 55, 6, 7, 78, 9, 10, 7 };
			int[,] sqrarr = {
				{ 1, 1, 1, 2, 2, 2},
				{ 1, 1, 1, 2, 2, 2},
				{ 1, 1, 1, 2, 2, 2},
				{ 3, 3, 3, 4, 4, 4},
				{ 3, 3, 3, 4, 4,4 },
				{ 3, 3, 3, 4, 4, 4}
			};

			for (int i = 0; i <= sqrarr.GetUpperBound(0); i++) {
				for (int j = 0; j <= sqrarr.GetUpperBound(1); j++) {
					Console.Write(sqrarr[i, j] + "\t");
				}
				Console.WriteLine();
			}

			ReversArr(sqrarr);
			Console.WriteLine("----------------------------------");

			for (int i = 0; i <= sqrarr.GetUpperBound(0); i++) {
				for (int j = 0; j <= sqrarr.GetUpperBound(1); j++) {
					Console.Write(sqrarr[i, j] + "\t");
				}
				Console.WriteLine();
			}




			//ReversArr(sqrarr);

			// Console.WriteLine(AVG(array1));
			// Console.WriteLine(SumEven(array1));


			//foreach (var item in ReversArr(array1)) {
			//	Console.Write(item + " ");
			//}





		}

		// 1. Вычислить среднее арифметическое по массиву(зарплата за год)
		static Double AVG(int[] arr) {
			int summ = 0;
			foreach (var el in arr) {
				summ += el;
			}
			return (summ / arr.Length);
		}

		// 2. Вывести каждое честное число из массива

		static List<int> Even(int[] arr) {
			List<int> res = new List<int>();
			foreach (var el in arr) {
				if (el % 2 == 0) {
					res.Add(el);
				}
			}
			return res;
		}

		// 3. Вывести сумму четных элементов в массиве
		static int SumEven(int[] arr) {
			int summ = 0;
			foreach (var el in arr) {
				if (el % 2 == 0) {
					summ += el;
				}
			}
			return summ;
		}

		// 4. для продвинутых: перевернуть массив.
		static int[,] ReversArr(int[,] arr) {
			int tmp;
			for (int i = 0; i < arr.GetLength(0) / 2; i++) {
				for (int j = 0; j < arr.GetLength(1) / 2; j++) {
					tmp = arr[i, j];
					arr[i, j] = arr[arr.GetLength(0) - i - 1, arr.GetLength(1) - j - 1];
					arr[arr.GetLength(0) - i - 1, arr.GetLength(1) - j - 1] = tmp;
				}

			}

			return arr;
		}

		static int[] ReversArr(int[] arr) {
			int tmp;
			for (int i = 0; i < arr.Length / 2; i++) {
				tmp = arr[i];
				arr[i] = arr[arr.Length - i - 1];
				arr[arr.Length - i - 1] = tmp;
			}

			return arr;
		}
	}
}
