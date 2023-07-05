using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Exceptions
{
    public class NotAnEmailAddress : Exception
    {
        public override string? Message { get; } //= "[no message provided]";
        public string? Description { get; } //= "[no description provided]";

        public NotAnEmailAddress() : base() { }
        public NotAnEmailAddress(string message, string description)
        {
            Message = message;
            Description = description;
        }

        public override string ToString()
        {
            return $"Exception: {this.GetType().ToString()} --> {this.Message}\n" +
                $"Exception Description: {this.Description}\n" +
                $"Exception StackTrace:\n{this.StackTrace}";
        }
    }
}
