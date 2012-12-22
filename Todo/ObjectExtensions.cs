using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    public static class ObjectExtensions
    {
        public static void ThrowIfNull(this object input, [CallerMemberName]string paramName = "value")
        {
            if (input == null) throw new ArgumentNullException(paramName);
        }
    }
}
