using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Console;
using System.Runtime.Serialization;

namespace PenaltiesAccounting
{
    [Serializable]
    public class ExecutiveAgency:Account,ISerializable
    {
        public string? StructuralUnit { get; set; }
        public string ? PoliceID { get; set; }
        public override void CreatedAccount()
        {
            try
            {
                TextArrayOutput.TextOutput();
                WriteLine(TextArrayOutput.TextForOutPut[0]);
                string? name = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[1]);
                string? surname = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[2]);
                string? lastName = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[7]);
                string? StructUnit=ReadLine();
                this.StructuralUnit = StructUnit;
                this.Surname = surname;
                this.LastName = lastName;
                this.Name = name;
                this.PoliceID = RegularExpressinLogin.CreateLoginAgency();
                this.Password = RegularExpressinLogin.CreatePassword();
            }
            catch (IndexOutOfRangeException exR)
            {
                WriteLine(exR.Message.ToString());
            }
            catch (NullReferenceException exN)
            {
                WriteLine(exN.Message.ToString());
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name:", Name);
            info.AddValue("Surname:", Surname);
            info.AddValue("LastName:", LastName);
            info.AddValue("Created:", Created);
            info.AddValue("NumberID", numberID);
            info.AddValue("Police ID", PoliceID);
            info.AddValue("Password", Password);
            info.AddValue("Structural Unit", StructuralUnit);

        }
    }
}
