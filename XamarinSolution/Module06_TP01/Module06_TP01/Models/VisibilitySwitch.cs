using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Module06_TP01.Models
{
    class VisibilitySwitch
    {
        public View currentValue{ get; }

        public View nextValue { get; }

        public VisibilitySwitch(View currentValue, View nextValue)
        {
            this.currentValue = currentValue;
            this.nextValue = nextValue;
      
        }

        
    }
}
