// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//string[] favorite = { "Beans","Beans2","Porrige yam","Yam and egg sauce"};
//foreach (string f in favorite)
//{
//    Console.WriteLine(f);
//}


List<string> cars = new List<string>();
cars.Add("Tesla");
cars.Add("Puegeot");
cars.Add("Jeep");
cars.Add("Honda");

cars.Remove("Tesla");

/*cars.Insert(0, "john best car is tesla");
cars.Insert(2, "Shedrack best car is Jeep");
cars.Insert(3, "Abigail best car is Honda");
cars.Insert(1, "Miracle best car is puegeot");*/

foreach (string a in cars)
{
    Console.WriteLine(a);

}

