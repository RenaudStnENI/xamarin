using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Module06_TP01.Models
{
    class LoginForm
    {
        public Entry Login{ get; }

        public Entry Password { get; }

        public Switch IsRemind { get; }

        public VisibilitySwitch VisibilitySwitch { get; }

        public ErrorForm Error { get; }


        public Boolean IsValid()
        {
            Boolean result = true;
            return result;
        }

    }
}
