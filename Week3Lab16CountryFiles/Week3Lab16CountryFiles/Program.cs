using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week3Lab16CountryFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(@"
Welcome to the Countries Maintenence Applicaiton!
        1. See the list of countries
        2. Add a country
        3. Exit
What file do you want this from?");
            var IsCoolName = false;
            string UserInput = null;
            while (IsCoolName == false)
            {
                string UserInput = Console.ReadLine();
                Match UserFileCreate = RegExHome.FileCreationRegEx.Match(UserInput);
                IsCoolName = UserFileCreate.Success;
                if (UserFileCreate.Success)
                {
                    Console.WriteLine("Cool file name!");

                }
                else
                {
                    Console.WriteLine("That's no good");
                    
                }
            }

            do
            {
                if (File.Exists(UserInput))
                {
                    while (true)
                    {
                        Console.WriteLine("Which choice to use for menu? (numbos only please)");
                        string UserInputMenu = Console.ReadLine();
                        int UserIntPutMenu = int.Parse(UserInputMenu);
                        switch (UserIntPutMenu)
                        {

                            case 1:
                                using (StreamReader CountriesFile = new StreamReader(UserInput))
                                {
                                    
                                    string line = CountriesFile.ReadToEnd();
                                        Console.WriteLine(line);
                                        break;
                                    
                                }
                                
                            case 2:
                                using (StreamWriter CountriesFileWrite = new StreamWriter("Countries.txt",true))
                                {
                                    Console.WriteLine("What country? then we go to menu again");
                                    string NewCountryInput = Console.ReadLine();
                                    CountriesFileWrite.WriteLine(NewCountryInput);

                                    break;
                                }
                            case 3:
                                Console.WriteLine("want continue?");
                                string continueFileCreate2 = Console.ReadLine();
                                if (continueFileCreate2 == "Y")
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("no you");
                                    Console.ReadKey();
                                    return;
                                }
                            default:
                                Console.WriteLine("No, you!");
                                break;

                        }
                    }
                }
                else
                {
                    Console.WriteLine("I'm not finding that, do you want to make a file?");
                    string UserWantCreateFile = Console.ReadLine();
                    if (UserWantCreateFile == "Y")
                    {
                        using (StreamWriter CountriesFile = new StreamWriter("Countries.txt"))
                        {
                            
                        }
                    }
                    else
                    {
                        break;
                    }
                    UserInput = "Countries.txt";
                }
                Console.WriteLine("you sure you want continue?");
                string continueFileCreate = Console.ReadLine();
                if (continueFileCreate == "Y")
                {
                    continue;
                }
                break;
            } while (true);
        }
    }
}
