using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using System.Text.RegularExpressions;
namespace PenaltiesAccounting
{
    static public class RegularExpressinLogin
    {
        public static  string? UserPattern;
        public static string? AgencyPattern;
        public static string? PasswordPatern;
        static RegularExpressinLogin()
        {
            UserPattern = @"[0-9]{10}";
            AgencyPattern= @"[a-z][0-9]{6}";
            PasswordPatern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$";
        }
       public static string? CreatePassword()
        {
            WriteLine(TextArrayOutput.TextForOutPut[4]);
            string? Password1 = ReadLine();
            WriteLine(TextArrayOutput.TextForOutPut[5]);
            string? Password2 = ReadLine();
            Regex regex = new Regex(PasswordPatern);
            while (!regex.IsMatch(Password1)|| Password1!= Password2)
            {
                WriteLine(TextArrayOutput.TextForOutPut[9]);
                WriteLine(TextArrayOutput.TextForOutPut[4]);
                Password1 = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[5]);
                Password2 = ReadLine();
            }
               return Password1;
        }
        public static long? CreateLoginUser()
        {
            Regex regex = new Regex(UserPattern);
            WriteLine(TextArrayOutput.TextForOutPut[3]);
            long? IdentifcationCode = Convert.ToInt32(ReadLine());
            while (!regex.IsMatch(IdentifcationCode.ToString()))
            {
                WriteLine(TextArrayOutput.TextForOutPut[9]);
                WriteLine(TextArrayOutput.TextForOutPut[3]);
                IdentifcationCode = Convert.ToInt32(ReadLine());
            }
            return IdentifcationCode;
        }
        public static string? CreateLoginAgency()
        {
            Regex regex = new Regex(AgencyPattern);
            WriteLine(TextArrayOutput.TextForOutPut[6]);
            string? IdPolice = ReadLine();
            while (!regex.IsMatch(IdPolice))
            {
                WriteLine(TextArrayOutput.TextForOutPut[9]);
                WriteLine(TextArrayOutput.TextForOutPut[6]);
                IdPolice = ReadLine();
            }
            return IdPolice;
        }
    }
}
