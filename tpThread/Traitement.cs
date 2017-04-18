using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace tpThread
{
    delegate void PrototypeValueChanged(object o, ValueChangedEventArgs e);

    class Traitement
    {
        public event PrototypeValueChanged valueChanged;
        int valeurMax;
        int parCombien;

        public Traitement(int valMax, int parCombien) 
        { 
            this.valeurMax = valMax; 
            this.parCombien = parCombien;
        }

        public void TraitementLong()
        {

            for (int i = 0; i<= valeurMax; i++)
            {
                Thread.Sleep(100);
                if(i%parCombien == 0)
                    OnValueChanged(i);
            }
        }

        public void OnValueChanged(int value)
        {
            if (valueChanged != null)
            {
                valueChanged(this, new ValueChangedEventArgs(value));
                if (value == this.valeurMax)
                {
                        MessageBox.Show("traitement terminé");
                }
            }
        }
    }
}
