using System;
using System.Collections.Generic;
using System.Text;

namespace lv2
{
    public static class EmailHelper
    {
        public static bool provjera(string mail)
        {
            return mail.Contains("@") && (mail.EndsWith("ferit.hr") || mail.EndsWith("gmail.com"));
        }
        public static bool provjeraFerit(string mail)
        {
            return mail.EndsWith("ferit.hr");
        }
    }
}
