using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace PenaltiesAccounting
{
    internal static class TextArrayOutput
    {
        public  static string [] ?TextForOutPut;
        public static int Size = 20;
        static TextArrayOutput()
        {
            TextForOutPut = new string[Size];
        }
        public static void TextOutput()
        {
            TextForOutPut[0]= "Input name: ";
            TextForOutPut[1] = "Surname: ";
            TextForOutPut[2] = "Lastname: ";
            TextForOutPut[3] = "Identification code: ";
            TextForOutPut[4] = "Create password: ";
            TextForOutPut[5] = "Repeat the password: ";
            TextForOutPut[6] = "Police ID:   ";
            TextForOutPut[7] = "Structural Unit: ";
            TextForOutPut[8] = "Date creating of account: ";
            TextForOutPut[9] = "Uncorrect format!";

        }

    }
}
