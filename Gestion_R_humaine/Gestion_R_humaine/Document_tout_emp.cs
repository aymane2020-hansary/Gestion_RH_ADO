using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Gestion_R_humaine
{
    public partial class Document_tout_emp : UserControl
    {
        ADO d = new ADO();
        public Document_tout_emp()
        {
            InitializeComponent();
        }

        private void Document_tout_emp_Load(object sender, System.EventArgs e)
        {
            d.connecter();

            remplirGrid();
        }

        public void remplirGrid()
        {
            if (d.dt.Rows != null)
            {
                //Vider la datatable
                d.dt.Clear();
            }
            d.cmd.CommandText = $"SELECT * FROM employé";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            //2 méthode pour lire les données soit avec la boucle while et l'objet read mais prend beaucoup du temps
            //Je charge le reader dans datatable
            d.dt.Load(d.dr);
            dtg_doc_infos_tout.DataSource = d.dt;
            d.dr.Close(); //Je close le datareader pour qu'il ne monoplise pas la connexion
        }

        public void exportGridToPdf(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add Header
            foreach (DataGridViewColumn colmun in dtg_doc_infos_tout.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(colmun.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //Add Datarow
            foreach (DataGridViewRow row in dtg_doc_infos_tout.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void btn_imprimer_Click(object sender, System.EventArgs e)
        {
            exportGridToPdf(dtg_doc_infos_tout, "test");
        }
    }
}