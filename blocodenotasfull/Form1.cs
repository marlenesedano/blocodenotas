using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blocodenotasfull
{
    public partial class frm_blocodenotas : Form
    {
        public frm_blocodenotas()
        {
            InitializeComponent();
        }

        private void SalvarClick(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void salvarOk(object sender, CancelEventArgs e)
        {
            string caminho = saveFileDialog1.FileName;
            File.WriteAllText(caminho, txb_Texto.Text);
        }
    }
}
