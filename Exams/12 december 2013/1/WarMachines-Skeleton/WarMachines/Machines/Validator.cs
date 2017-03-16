
namespace WarMachines.Machines
{
    using System;
    public static class Validator
    {
        public static void NullOrEmptyString(string input, string message = null)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(message);
            }
        }
        public static void NullObject(object input, string message = null)
        {
            if (input == null)
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
