// See https://aka.ms/new-console-template for more information
int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

int minimum = nums.Min(); //returns 1 value
int maximum = nums.Max();
int minValue = nums.Where(x => x < 10000).Max();
int[] firstValues = nums.Where(x => x > 10 && x < 100).ToArray(); //returns multiple values
int[] nextValues = nums.Where(x => x <= 999999 && x >= 100000).ToArray();
int evenNumbers = nums.Count(x => x % 2 == 0);