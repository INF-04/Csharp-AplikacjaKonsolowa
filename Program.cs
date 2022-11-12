using inf04_c;

var arr = new int[50];
arr.Fill();

Console.WriteLine("Podaj liczbe do wyszukania: ");

var number = int.Parse(Console.ReadLine() ?? "0");

var index = Solution.Search(arr, number);

Console.WriteLine($"index liczby: {number} to: {index}");

Console.WriteLine(arr[index] == number ? "Liczba jest poprawna" : "Liczba nie jest poprawna");