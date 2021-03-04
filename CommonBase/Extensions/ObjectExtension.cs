using System;
using System.Collections.Generic;
using System.Text;

namespace CommonBase.Extensions
{
    public static class ObjectExtension
    {
        public static void CheckArgument(this object obj, string name)
        {
            if(obj == null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
