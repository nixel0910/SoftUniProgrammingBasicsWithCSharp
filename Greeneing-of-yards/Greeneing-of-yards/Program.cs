
int yard = int.Parse(Console.ReadLine());
double discount = (yard * 7.61)*0.18;
double price = yard * 7.61 - discount;
Console.WriteLine(	$"The final price is: {price} lv.");
Console.WriteLine($"The discount is: {discount} lv.");
