using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Exceptions
{
    public class ShortEmailException : Exception
    {
        public override string? Message { get; } = "[no message provided]";
        public string? Description { get; } = "[no description provided]";

        public ShortEmailException() : base() { }
        public ShortEmailException(string message, string description)
        {
            Message = message;
            Description = description;
        }

        public override string ToString()
        {
            return $"Exception: {this.GetType().ToString()} --> {this.Message}\n" +
                $"Exception Description: {this.Description}\n" +
                $"Exception StackTrace:\n{this.StackTrace}"; ;
        }
    }
}
