using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    internal class SignUp
    {
        public string Name;
        public string Surname;
        public string PhoneNum;
        public string Password;
        public DateTime Birthday;
        public string Gender;

        public SignUp()
        {
            
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} Surname:{Surname} PhoneNum:{PhoneNum} BirthDay:{Birthday} Gender:{Gender}");
        }
       
        
    }

}
