using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using static System.Console;
using System.Text.RegularExpressions;



namespace PenaltiesAccounting
{
    [Serializable]
    internal class User: Account,ISerializable
    {
        public User(int? identificationCode, string? name, string? surname, string? lastName) 
            :base(name, surname, lastName) 
        {
            IdentificationCode = identificationCode;
            
        }
        public User():base(){
            IdentificationCode = null;
        }
        public long? IdentificationCode { get; set; }
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
                this.Surname = surname;
                this.LastName = lastName;
                this.IdentificationCode = RegularExpressinLogin.CreateLoginUser();
                this.Name = name;
                this.Password = RegularExpressinLogin.CreatePassword(); ;
            }
            catch (IndexOutOfRangeException exR)
            {
                WriteLine(exR.Message.ToString());
            }catch(NullReferenceException exN)
            {
                WriteLine(exN.Message.ToString());
            }catch(Exception ex)
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
            info.AddValue("Identification Code", IdentificationCode);
        }
    }
}
