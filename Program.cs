// This is a comment to my code
//rakendus küsib kasutajal nime
//rakendus tervitab kasutajat nimepidi 

Console.WriteLine("Enter your nime"); //Output
//string-sõne
string userName;
userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");
userName = Console.ReadLine();
//string Interpolation
Console.WriteLine($"Hello, (userName);!");
