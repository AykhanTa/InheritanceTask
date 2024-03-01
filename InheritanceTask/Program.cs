namespace InheritanceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account user= new Account();
            //user.Username = Console.ReadLine();
            //user.Password = Console.ReadLine();
            //user.Login(user.Username,user.Password);

            SignUp register= new SignUp();
            Console.WriteLine("Enter name:");
            string name= Console.ReadLine();
            register.Name = name;
            Console.WriteLine("Enter surname:");
            string surname = Console.ReadLine();
            register.Surname = surname;
            Console.WriteLine("Enter phone number:");
            string phoneNum = Console.ReadLine();
            register.PhoneNum = phoneNum;
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            register.Password = password;
            Console.WriteLine("Enter birthday date:");
            DateTime birthDay= DateTime.Parse(Console.ReadLine());
            register.Birthday=birthDay;
            Console.WriteLine("Enter gender: ");
            string gender = Console.ReadLine();
            register.Gender = gender;
            register.ShowInfo();
        }
    }
}