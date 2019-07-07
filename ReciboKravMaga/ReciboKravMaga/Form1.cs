using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReciboKravMaga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oneMonth_CheckedChanged(object sender, EventArgs e)
        {
            otherPaymentType.Enabled = otherType.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oneMonth.Checked || threeMonths.Checked || (otherType.Checked && otherPaymentType.Text.Length > 5))
            {
                decimal _amountPaid = 0;
                string paymentType = otherPaymentType.Text;

                if (oneMonth.Checked) paymentType = "MENSALIDADE";
                if (threeMonths.Checked) paymentType = "TRIMESTRALIDADE";

                if (decimal.TryParse(amountPaid.Text, out _amountPaid))
                {
                    var receiptInfo = new ReceiptInfo(studentName.Text, _amountPaid, paymentType, paymentDate.Value.Date);

                    if (receiptInfo.Valid())
                    {
                        var fileDialog = new SaveFileDialog
                        {
                            AddExtension = true,
                            CheckPathExists = true,
                            DefaultExt = "pdf",
                            Filter = "PDF (*.pdf)|*.pdf",
                            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                            OverwritePrompt = true,
                            ValidateNames = true
                        };

                        if (fileDialog.ShowDialog() == DialogResult.OK)
                        {
                            new Receipt(receiptInfo).GenerateReceipt(fileDialog.FileName);
                            MessageBox.Show("Recibo gerado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Process.Start(Path.GetDirectoryName(fileDialog.FileName));
                        }
                    }
                    else
                    {
                        Util.ShowError(receiptInfo.ErrorMesage());
                    }
                }
                else
                {
                    Util.ShowError("Valor deve ser um número.");
                }
            }
            else
            {
                Util.ShowError("Tipo de Pagamento obrigatório.");
            }
        }
    }
}
