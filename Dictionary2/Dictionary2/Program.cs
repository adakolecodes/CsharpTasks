// See https://aka.ms/new-console-template for more information
Console.WriteLine("THIS IS MY DICTIONARY");

Dictionary<int, string> myHobbies = new Dictionary<int, string>();
myHobbies.Add(1, "Singing");
myHobbies.Add(2, "Programming");
myHobbies.Add(3, "Photography");
myHobbies.Add(4, "Music Production");

foreach(var hobby in myHobbies)
{
    Console.WriteLine("My Hobby is: " + hobby.Value);
}


for(int i = 1; i <= myHobbies.Count; i++)
{
    Console.WriteLine("My Hobby is: " + myHobbies[i]);
}
