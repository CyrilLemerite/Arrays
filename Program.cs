int[] fibonacci;


string ans = string.Empty;
do
{
    Console.Clear();
    Console.Beep();
    Console.WriteLine("______________________________________");
    Console.WriteLine("Program to compute Fibonacc's numbers");
    Console.WriteLine("______________________________________");
    Console.WriteLine();

    int numb;
    Console.Write("Enter the number of elements to compute: ");
    numb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    fibonacci = new int[numb];
    fibonacci[0] = 0;
    fibonacci[1] = 1;

    for (int i = 2; i < numb; ++i)
    {
        fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
    }
    Console.Beep();

    for (int i = 0; i < numb; ++i)
    {
        Console.Write(fibonacci[i] + " ");

    }

    Console.WriteLine();
    Console.Beep();
    Console.WriteLine();
    Console.Write("Do you want to continue Yes(Y) or No(N)? ");
    ans = Console.ReadLine();
    Console.WriteLine();

} while (ans.ToLower() == "yes" || ans.ToLower() == "y");

Console.Beep();
Console.WriteLine("Thank you for using my app!");
Console.WriteLine();








