using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace tpThread
{
    public partial class fTraitement : Form
    {
        public fTraitement()
        {
            InitializeComponent();
            this.btnAsynchrome.Click += new EventHandler(btnAsynchrome_Click);
        }

        void btnAsynchrome_Click(object sender, EventArgs e)
        {
            Traitement leTraitement = new Traitement(pbTraitement.Maximum,10);
            leTraitement.valueChanged += new PrototypeValueChanged(leTraitement_valueChanged);
            Thread leThread = new Thread(leTraitement.TraitementLong);
            leThread.Start();            
        }

        void leTraitement_valueChanged(object o, ValueChangedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                PrototypeValueChanged callback = leTraitement_valueChanged;
                object[] args = new object[] { o, e };
                this.Invoke(callback, args);
            }
            else
            {
                int value = e.Value;
                this.pbTraitement.Value = value;

            }
        }
    }
}
