using System;
using System.Collections;
using System.Globalization;
//palabra reservada, using estara trabajando con el entorno de system
namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            CultureInfo uiCulture1 = CultureInfo.CurrentUICulture;
            string myLanguage = uiCulture1.TwoLetterISOLanguageName.ToString();
            string test = "en";
                
            if (myLanguage == test)
            {
                Console.WriteLine("Hello World");
            }
            else 
            {
                Console.WriteLine("Hello, Hola, Konnichiwa");   
            }

        }
    }
}
