namespace InheritanceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Account user= new Account();
            user.Username = Console.ReadLine();
            user.Password = Console.ReadLine();
            user.Login(user.Username,user.Password);



             
        }
    }
}