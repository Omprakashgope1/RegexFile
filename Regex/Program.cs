using System.Globalization;

namespace RegexClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation number you want to perform");
            int val = Convert.ToInt32(Console.ReadLine());  
            switch(val)
            {
                case 1:
                    Class1 cl = new Class1();
                    bool wantToCheck = true;
                    while(wantToCheck) 
                    {
                        Console.WriteLine("Please enter the string you want to check");
                        string check = Console.ReadLine();
                        bool ans = cl.IsMatching(check);
                        Console.WriteLine("The given string matches or not : " + ans);
                        Console.WriteLine("if want to check another string(Y)");
                        String find = Console.ReadLine().ToUpper();
                        if(find != "Y")wantToCheck = false;
                    }
                    break;
                case 2:
                    Class2 cl2 = new Class2();
                    wantToCheck = true;
                    while (wantToCheck)
                    {
                        Console.WriteLine("Please enter the string you want to check");
                        string check = Console.ReadLine();
                        bool ans = cl2.FindPattern(check);
                        Console.WriteLine("The given string matches or not : " + ans);
                        Console.WriteLine("if want to check another string(Y)");
                        String find = Console.ReadLine().ToUpper();
                        if (find != "Y") wantToCheck = false;
                    }
                    break;
                case 3:
                    Class3 class3 = new Class3();
                    wantToCheck = true;
                    while (wantToCheck)
                    {
                        Console.WriteLine("Please enter the string you want to check");
                        string check = Console.ReadLine();
                        class3.FindPattern(check);
                        String find = Console.ReadLine().ToUpper();
                        Console.WriteLine("if want to check another string(Y)");
                        if (find != "Y") wantToCheck = false;
                    }
                    break;
                case 4:
                    Console.WriteLine("Please enter the patter from which you want to check");
                    string pattern = Console.ReadLine();
                    Console.WriteLine("Please enter the string you want to check with");
                    Class4 class4 = new Class4();
                    string input = (Console.ReadLine());
                    class4.FindPatterns(pattern, input);
                    break;
                case 5:
                    Console.WriteLine("Please enter the string you want to check for");
                    Class5 class5 = new Class5();
                    input = (Console.ReadLine());
                    class5.FindMatch(input);
                    break;
                case 6:
                    Console.WriteLine("Please enter you want to check for");
                    input = Console.ReadLine();
                    Class6 class6 = new Class6();   
                    class6.FindMatch(input);
                    break;

            }
        }
    }
}
