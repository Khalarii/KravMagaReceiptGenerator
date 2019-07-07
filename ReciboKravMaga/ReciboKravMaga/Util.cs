using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReciboKravMaga
{
    public static class Util
    {
        public static void ShowError(string error)
        {
            MessageBox.Show(error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
