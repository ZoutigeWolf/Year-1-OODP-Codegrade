﻿int[] numbers = new int[] { -32, 2, 49, 46, -33, 3, 17, 64, -13, -4, -79, 89, 20, -61, -64, -34, -86, -82, 51, -35, 31, 13, 18, -72, -20, 42, 77, 4, -88, -28, 1, -70, 99, -22, 93, 24, -65, 60, -15, 0, -59, 6, -80, 48, 98, 16, 80, -71, 45, 33, -9, -30, -89, -26, 27, -55, 69, -95, -31, -2, 75, 41, -46, 72, -44, -68, -50, 59, 39, -60, 22, 26, -58, -87, -14, 38, 83 };


Console.WriteLine("Divisble by 2:");
numbers.Where(i => i % 2 == 0).OrderBy(_ => _).ToList().ForEach(Console.WriteLine);

Console.WriteLine();
Console.WriteLine("Divisble by 2 and positive:");
numbers.Where(i => i % 2 == 0 && i > 0).OrderByDescending(_ => _).ToList().ForEach(Console.WriteLine);