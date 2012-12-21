﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    internal static class StringExtensions
    {
        public static void ThrowIfNullOrEmpty(this string value, [CallerMemberName]string parameterName = "value")
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(parameterName);
            }
        }

        public static void ThrowIfInvalidEmailAddress(this string value)
        {
            var mailAddress = new MailAddress(value);
        }
    }
}