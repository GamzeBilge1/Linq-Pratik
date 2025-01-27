
List<int> numbers = new List<int> { -7 ,-9, 0, 6,3,8,1,-46,17 ,-6};

var evenNumber = numbers.Where(num => num % 2 == 0); //çift sayıları bulmak için linq sorgusu

foreach( var num in evenNumber)  // foreach döngüsü ile çift sayılar ekrana yazdırılır
{
    Console.WriteLine("çift sayılar "+num);
}

Console.WriteLine("-----------------------------");

var oddNumbers = numbers.Where(num => num%2 != 0); // tek sayıları bulmak için linq sorgusu

foreach( var num in oddNumbers) // foreach döngüsü ile tek sayılar ekrana yazdırılır
{
    Console.WriteLine("Tek sayılar: "+num);
}

Console.WriteLine("-----------------------------");

var negativeNumbers = numbers.Where(num => num < 0); // negatif sayıları bulmak için linq sorgusu

foreach( var num in negativeNumbers)  // foreach döngüsü ile negatif sayılar ekrana yazdırılır
{
    Console.WriteLine("Negatif sayılar: "+ num);
}

Console.WriteLine("-----------------------------");

var positiveNumbers = numbers.Where(num => num > 0); // pozitif sayıları bulmak için linq sorgusu

foreach (var num in positiveNumbers) // foreach döngüsü ile pozitif sayılar ekrana yazdırılır
{
    Console.WriteLine("Pozitif sayılar: " + num);
}

Console.WriteLine("-----------------------------");

var filteredNumbers = numbers.Where(num => num > 15 && num < 22); // istenilen değer aralığındaki sayıları bulmak için linq sorgusu 

foreach (var num in filteredNumbers) // foreach döngüsü ile istenilen değer aralığı ekrana yazdırılır
{
    Console.WriteLine("15 ten büyük 22 den küçük sayılar: " + num);
}

Console.WriteLine("-----------------------------");

var squaredNumbers = numbers.Select(x => x * x); // sayıların karesini bulmak için linq sorgusu

List<int> squaredNumbersList = new List<int>(); // sayıların karesini yeni listeye eklemek için bir liste oluşturulur

// var squaredNumbers = numbers.Select(x => x * x).ToList();  : kısayol olarak bu şekilde de listeye dönüştürebiliyormuşuz.

foreach ( var num in squaredNumbers) // sayıların karesi yeni listeye foreach döngüsü ile eklenir
{
    squaredNumbersList.Add(num);
}

foreach (var num in squaredNumbersList) // yeni listeden sayıların karesi ekrana yazdırılır
{
    Console.WriteLine("Sayıların karesi: " + num);
}