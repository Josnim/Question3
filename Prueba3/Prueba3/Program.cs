using System; 
using System.Linq;  
namespace Prueba3 {   
    class Program     
    {         
        public static bool palindrome(int mainint)         
        {
            string mainString = mainint.ToString();
            string fh = mainString.Substring(0, mainString.Length / 2);             
            char[] arr = mainString.ToCharArray();              
            Array.Reverse(arr);              
            string temp = new string(arr);             
            string sh = temp.Substring(0, temp.Length / 2);              
            return fh.Equals(sh);         
        }         static void Main(string[] args)         
        {
            int input = int.Parse(Console.ReadLine());
            bool result = palindrome(input);             
            Console.WriteLine(result);
            Console.ReadKey();
        }     
    } 
}