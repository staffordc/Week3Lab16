using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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

            string UserInput = Console.ReadLine();
            do
            {
                if (File.Exists(UserInput))
                {
                    //Menu for list/add/exit
                    StreamReader CountriesFile = new StreamReader(UserInput);
                    while (true)
                    {
                        //switch()
                        {

                           // case 1:
                        string line = CountriesFile.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(line);
                        }
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
                            //wl
                            //append:
                        }
                    }
                    else
                    {
                        break;
                    }
                    UserInput = "Countries.txt";
                }
                Console.Read();

                //Menu #3

                Console.WriteLine("want continue?");
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
