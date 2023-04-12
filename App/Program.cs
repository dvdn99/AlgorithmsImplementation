using Algorithms;


int[] arr = { 2, 12, 5, 1, 4, 3, 11, 9, 10, 6 };
Action<Object> print = (e) => Console.WriteLine(e);

print("Before Sort:");
arr.ToList().ForEach(e => print(e));

Sort.QuickSort(arr, 0, arr.Length - 1);

print("\nAfter sort:");
arr.ToList().ForEach(e => print(e));

