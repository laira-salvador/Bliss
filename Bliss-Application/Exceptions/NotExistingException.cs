using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliss_Application.Exceptions
{
    public class NotExistingException : Exception
    {
        public NotExistingException(int id, string collection) : base($"The id {id} is not existing in {collection}.")
        {
            
        }
    }
}
