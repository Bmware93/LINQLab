// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

int minimum = nums.Min();
int maximum = nums.Max();
int minValue = nums.Where(x => x < 10000).Max();
int maxValue = nums.Where(x => x > 10 && x < 100).;
