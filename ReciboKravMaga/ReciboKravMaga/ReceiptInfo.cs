using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ReciboKravMaga.Util;

namespace ReciboKravMaga
{
    public class ReceiptInfo
    {
        public ReceiptInfo(string student, decimal value, string type, DateTime date)
        {
            StudentName = student;
            PaymentValue = value;
            PaymentType = type;
            PaymentDate = date;
        }

        public string StudentName { get; private set; }

        public decimal PaymentValue { get; private set; }

        public string PaymentType { get; private set; }

        public DateTime PaymentDate { get; private set; }

        public bool Valid()
        {
            return StudentName.Length >= 3 && StudentName.Length <= 120 && PaymentValue > 0 && PaymentDate < DateTime.Now;
        }

        public string ErrorMesage()
        {
            StringBuilder errorMessage = new StringBuilder("Dados inválidos:\n\n");

            if (StudentName.Length < 3 || StudentName.Length > 120) errorMessage.AppendLine("\t- Nome do aluno deve ter entre 3 e 120 caracteres;");
            if (PaymentValue < 1) errorMessage.AppendLine("\t- Valor deve ser maior que 0;");
            if (PaymentDate > DateTime.Now) errorMessage.AppendLine("\t- Data do Pagamento não pode ser no futuro;");

            if (errorMessage != new StringBuilder("Dados inválidos:\n\n"))
                return errorMessage.ToString();
            else
                return null;
        }
    }
}
