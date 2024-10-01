
#region Int Değişkenler

//int
//int number = 24;
//Console.WriteLine(number);

int hamburgerPrice = 300;
int cokePrice = 35;
int waterPrice = 10;
int friesPrice = 50;
int pizzaPrice = 250;
int lemonadePrice = 30;

Console.WriteLine("**** Restoran Menü Fiyatı ****");
Console.WriteLine();
Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
Console.WriteLine("-----Kola: " + cokePrice + " TL");
Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
Console.WriteLine("-----Su: " + waterPrice + " TL");
Console.WriteLine();
Console.WriteLine("**** Restoran Menü Fiyatı ****");


Console.WriteLine();
int hamburgerCount;
int cokeCount;
int waterCount;
int friesCount;
int pizzaCount;
int lemonadeCount;

int totalHamgurgerPrice;
int totalCokePrice;
int totalWaterPrice;
int totalFriesPrice;
int totalPizzaPrice;
int totalLemonadePrice;

hamburgerCount = 3;
cokeCount = 3;
waterCount = 3;
friesCount = 1;
pizzaCount = 0;
lemonadeCount = 0;

totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
totalCokePrice = cokeCount * cokePrice;
totalWaterPrice = waterCount * waterPrice;
totalLemonadePrice = lemonadeCount * lemonadePrice;
totalFriesPrice = friesCount * friesPrice;
totalPizzaPrice = pizzaCount * pizzaPrice;

Console.WriteLine("-------------------------------------");
Console.WriteLine("Hamburger Tutarı: " + totalHamgurgerPrice + " TL");
Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

Console.WriteLine();

int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

#endregion

double exam1, exam2, exam3, result;

Console.Write("Lütfen 1.Sınav notunu giriniz: ");
exam1 = double.Parse(Console.ReadLine());

Console.Write("Lütfen 2.Sınav notunu giriniz: ");
exam2 = double.Parse(Console.ReadLine());

Console.Write("Lütfen 3.Sınav notunu giriniz: ");
exam3 = double.Parse(Console.ReadLine());

result = (exam1 + exam2 + exam3) / 3;

Console.WriteLine();
Console.WriteLine("Sınav Ortalamanız: " + result);

Console.Read();
