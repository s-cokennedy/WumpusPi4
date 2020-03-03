using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wumpus
{
    public partial class Form1 : Form
    {

        private GameObject _GameObject;

        public Form1()
        {
            InitializeComponent();
        }

        private void ConstructorButton_Click(object sender, EventArgs e)
        {
            _GameObject = new GameObject();
        }
    }
}
