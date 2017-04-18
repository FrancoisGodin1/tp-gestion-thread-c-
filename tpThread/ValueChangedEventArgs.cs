using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpThread
{
    public class ValueChangedEventArgs
    {
        int value;

        public int Value { get { return this.value; } set { this.value = value; } }

        public ValueChangedEventArgs(int value) { this.value = value; }


    }
}
