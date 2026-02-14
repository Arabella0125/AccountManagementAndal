namespace AccountManagementAndal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Account Management System");

            string username = "arabella";
            string password = "andal123";

            Console.Write("Enter username: ");
            string usernameInput = Console.ReadLine();
            Console.Write("Enter password: ");
            string passwordInput = Console.ReadLine();

            if (usernameInput == username && passwordInput == password)
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                Console.WriteLine("Incorrect info. Please, try again.");

            }
        }
    }
}
