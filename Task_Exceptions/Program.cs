using System;

namespace Task_Exceptions
{
    public static class EmailValidator
    {
        public static bool Validate(string email, string validExtension = "@mail.com")
        {
            int length = email.Length;
            if (length < 10) throw new ShortEmailException(
                message: "Invalid string length",
                description: $"Provided string does not have a valid length (--> {length}) for an email. ");

            if (!email.EndsWith(validExtension)) throw new NotAnEmailAddress(
                message: "Invalid email",
                description: $"Provided string does not conincide with given mail template: ...{validExtension}");

            return true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the email: ");
                string email = Console.ReadLine();

                bool success = EmailValidator.Validate(email);

                if (success) { Console.WriteLine("Inputted email is valid"); }
            }

            catch (ShortEmailException ex)
            {
                Console.WriteLine(ex);
            }
            catch (NotAnEmailAddress ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
