using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern.Application.Exceptions
{
    public class ValidationExpection : Exception
    {
        public ValidationExpection(): this("validation error occured")
        {

        }
        public ValidationExpection(string Message): base(Message)
        {

        }
        public ValidationExpection(Exception ex): this(ex.Message) // 3 ündede validation error fırlatıyoruz.
        {

        }
    }
}
