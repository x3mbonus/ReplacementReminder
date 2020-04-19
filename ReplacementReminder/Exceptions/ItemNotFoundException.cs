using System;

namespace ReplacementReminder.Exceptions
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string message = null) : base(message)
        {
        }
    }
}
