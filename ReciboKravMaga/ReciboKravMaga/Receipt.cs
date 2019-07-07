using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciboKravMaga
{
    public class Receipt
    {
        public Receipt(ReceiptInfo info)
        {
            receiptInfo = info;
        }

        private ReceiptInfo receiptInfo;

        public void GenerateReceipt(string filepath)
        {
            var document = new PdfDocument();

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XTextFormatter tf = new XTextFormatter(gfx);

            Document doc = new Document();
            Section s = doc.AddSection();
            Table receipt;
            Column c;
            Row r;

            receipt = s.AddTable();
            receipt.Format.Font.Name = "Arial";
            receipt.Format.Font.Size = new Unit(12, UnitType.Point);
            receipt.Borders.Width = 0;
            receipt.Style = "Table";
            receipt.BottomPadding = new Unit(10, UnitType.Point);

            c = receipt.AddColumn(new Unit(60, UnitType.Point));
            c = receipt.AddColumn(new Unit(125, UnitType.Point));
            c.Format.Alignment = ParagraphAlignment.Right;
            c = receipt.AddColumn(new Unit(225, UnitType.Point));
            c.Format.Alignment = ParagraphAlignment.Left;
            c = receipt.AddColumn(new Unit(60, UnitType.Point));
            c.Format.Alignment = ParagraphAlignment.Right;

            r = receipt.AddRow();
            r.BottomPadding = 0;
            r.Cells[2].MergeRight = 1;
            r.Cells[2].Format.Font.Size = new Unit(7, UnitType.Point);
            r.Cells[2].Format.Alignment = ParagraphAlignment.Right;
            r.Cells[2].AddParagraph(string.Format("Gerado em: {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));

            r = receipt.AddRow();
            r.Borders.Top.Width = 1;
            r.Cells[0].Borders.Left.Width = 1;
            r.Cells[3].Borders.Right.Width = 1;
            r.TopPadding = new Unit(10, UnitType.Point);
            var krav_maga_moema_logo = r.Cells[0].AddImage(AppDomain.CurrentDomain.BaseDirectory + "logo_krav_maga_moema.jpg");
            krav_maga_moema_logo.Height = new Unit(40, UnitType.Point);
            krav_maga_moema_logo.LockAspectRatio = true;

            var krav_maga_sa_logo = r.Cells[3].AddImage(AppDomain.CurrentDomain.BaseDirectory + "logo_kravmaga.png");
            krav_maga_sa_logo.Height = new Unit(40, UnitType.Point);
            krav_maga_sa_logo.LockAspectRatio = true;

            r.Format.Font.Bold = true;
            r.Cells[0].Borders.Left.Width = 1;
            r.Cells[3].Borders.Right.Width = 1;
            r.Format.Alignment = ParagraphAlignment.Center;
            r.Format.Font.Size = new Unit(15, UnitType.Point);
            r.Cells[1].MergeRight = 1;
            r.Cells[1].AddParagraph("RECIBO DE PAGAMENTO");

            r = receipt.AddRow();
            r.Cells[0].Borders.Left.Width = 1;
            r.Cells[3].Borders.Right.Width = 1;
            r.Cells[1].AddParagraph("Nome do Aluno:");
            r.Cells[2].MergeRight = 1;
            r.Cells[2].AddParagraph(receiptInfo.StudentName.ToUpper());

            r = receipt.AddRow();
            r.Cells[0].Borders.Left.Width = 1;
            r.Cells[3].Borders.Right.Width = 1;
            r.Cells[1].AddParagraph("Valor do Pagamento:");
            r.Cells[2].AddParagraph(receiptInfo.PaymentValue.ToString("R$ 0,0.00"));

            r = receipt.AddRow();
            r.Cells[0].Borders.Left.Width = 1;
            r.Cells[3].Borders.Right.Width = 1;
            r.Cells[1].AddParagraph("Data do Pagamento:");
            r.Cells[2].AddParagraph(receiptInfo.PaymentDate.ToString("dd/MM/yyyy"));

            r = receipt.AddRow();
            r.Cells[0].Borders.Left.Width = 1;
            r.Cells[3].Borders.Right.Width = 1;
            r.Cells[1].AddParagraph("Tipo do Pagamento:");
            r.Cells[2].AddParagraph(receiptInfo.PaymentType.ToUpper());
            r.Borders.Bottom.Width = 1;

            MigraDoc.Rendering.DocumentRenderer docRender = new MigraDoc.Rendering.DocumentRenderer(doc);
            docRender.PrepareDocument();

            docRender.RenderObject(gfx, XUnit.FromPoint(50), XUnit.FromPoint(30), XUnit.FromPoint(470), receipt);

            document.Save(filepath);
        }
    }
}
