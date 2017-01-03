using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WISPushNoticationsTestClient.Exceptions
{
    public class LoadRegistrationsException : Exception
    {
        public LoadRegistrationsException()
        {
        }

        public LoadRegistrationsException(string message)
        : base(message)
    {
        }

        public LoadRegistrationsException(string message, Exception inner)
        : base(message, inner)
    {
        }

    }
}
