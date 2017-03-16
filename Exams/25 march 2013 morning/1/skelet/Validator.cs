using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public static class Validator
    {
        public static void StringValidator(string imput,string message = "")
        {
            if (string.IsNullOrWhiteSpace(imput))
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
