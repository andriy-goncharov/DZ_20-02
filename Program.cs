using System;
using System.Collections.Generic;

namespace DZ_20_02 {
	class Program {
		static void Main(string[] args) {
			int[] array1 = new int[10] { 22, 3, 4, 55, 6, 7, 78, 9, 10, 7 };

			//Console.WriteLine(AVG(array1));
			//Console.WriteLine(SumEven(array1));

			ReversArr(array1);
			foreach (var item in array1) {
				Console.Write(item + " ");
			}





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
		static int[] ReversArr(int[] arr) {
			int count = 0;
			int tmp;
			for (int i = 0; i < arr.Length / 2; i++) {
				tmp = arr[i];
				arr[i] = arr[arr.Length - i -1];
				arr[arr.Length - i -1] = tmp;
			}

			return arr;
		}
	}
}
