using System;
using System.Data;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace CoVID
{
    class PdfConverter : IConverter
    {
        FileStream fs;
        Document document;
        PdfWriter writer;
        Table dataTable;
        String path;
        String headerName;

        public PdfConverter (Table dataTable, String path, string headerName)
        {
            this.dataTable = dataTable;
            this.path = path;
            this.headerName = headerName;
        }
        private void Open()
        {
            fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            document = new Document();
            document.SetPageSize(PageSize.A4);
            writer = PdfWriter.GetInstance(document, fs);
            document.Open();
        }
        private void Close()
        {
            document.Close();
            writer.Close();
            fs.Close();
        }
        public void Convert()
        {
            Open();

            //Header
            var defaultFont = FontFactory.GetFont("Helvetica", 18, Font.NORMAL);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(headerName.ToUpper(), defaultFont));
            document.Add(prgHeading);
            
            //Write the table
            PdfPTable table = new PdfPTable(dataTable.Columns.Count);

            var mainFont = FontFactory.GetFont("Helvetica", 16, Font.NORMAL, BaseColor.BLACK);
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.CYAN;
                cell.AddElement(new Chunk(dataTable.Columns[i].ColumnName.ToUpper(), defaultFont));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    table.AddCell(dataTable.Rows[i][j].ToString());
                }
            }
            document.Add(table);

            Close();
        }
    }
}
