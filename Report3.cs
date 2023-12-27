using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Model;

namespace Library
{
    public partial class Report3 : Form
    {
        DateTime nullDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified);
        string reportName = "Отчёт \"Популярные жанры\"";
        public Report3()
        {
            InitializeComponent();

            ReportName.Text = reportName;

            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                var items5 = db.Worker.Select(p =>
                    p.Name1.ToString()[0] + "." + p.Name3.ToString()[0] + "." + p.Name2.ToString() + " - " + p.Position.Name.ToString()).ToList();
                ReportOwner.DataSource = items5;
            }
        }

        private void setReport_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ReportView.Rows)
            {
                ReportView.Rows.Remove(row);
            }
            try
            {
                foreach (DataGridViewRow row in ReportView.Rows)
                {
                    ReportView.Rows.Remove(row);
                }
            }
            catch { }
            DateTime date1 = StartPeriodDate.Value.Date;
            DateTime date2 = EndPeriodDate.Value.Date;

            ReportError.Visible = false;
            if (date1 >= date2)
            {
                ReportError.Text = "Даты должны идти от старой к новой";
                ReportError.Visible = true;
                return;
            }

            ReportView.Visible = true;
            ExportMSWord.Visible = true;
            ExportExcel.Visible = true;

            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                var rep = (from entry in db.Entry
                           join book in db.Book on entry.BookId equals book.Id
                           from genre in book.Genres
                           where entry.PlanReturnDate.Date >= date1 &&
                                 entry.PlanReturnDate.Date < date2 &&
                                 entry.PlanReturnDate.Date < DateTime.Now.Date &&
                                 entry.FactReturnDate == nullDate
                           group genre by new
                           {
                               genre.Name,
                           } into genreGroup
                           orderby genreGroup.Count() descending
                           select new
                           {
                               genreGroup.Key.Name,
                               Count = genreGroup.Count()
                           }).Take(10);
                ReportView.ColumnCount = 2;
                foreach (var item in rep)
                {
                    ReportView.Rows.Add(
                        item.Name,
                        item.Count
                        );
                }
                ReportView.Columns[0].HeaderText = "Автор";
                ReportView.Columns[1].HeaderText = "Кол-во отданных книг";
                //ReportView.Columns[2].HeaderText = "дата выдачи";
                //ReportView.Columns[3].HeaderText = "дата возврата";
                //ReportView.Columns[4].HeaderText = "контакт для связи";
                //фио, книга, когда взял, когда должен был вернуть, контактные данные
            }
        }

        private void exportExcel(string repName, DateTime date1, DateTime date2, DataGridView dgv, string owner)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                ExcelRange cells;
                var worksheet = package.Workbook.Worksheets.Add("Отчёт");
                worksheet.Cells.Style.Font.Size = 14;

                // Заголовок
                cells = worksheet.Cells["A1:E2"];

                cells.Value = repName;
                cells.Style.WrapText = true;
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Style.Font.Size = 16;
                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                cells.Merge = true;

                // даты
                cells = worksheet.Cells["A3:E3"];

                cells.Value = "Период с " + date1.ToString().Split(' ')[0] + " по " + date2.ToString().Split(' ')[0];
                cells.Style.WrapText = true;
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                cells.Merge = true;

                // таблица
                worksheet.Cells[4, 2, 4, 5].Merge = true;
                worksheet.Cells[4, 2, 4, 5].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells["A4"].Value = ReportView.Columns[0].HeaderText;
                worksheet.Cells["B4"].Value = ReportView.Columns[1].HeaderText;
                worksheet.Cells["B4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                int tableStartRow = 5;
                int tableEndRow = tableStartRow + dgv.RowCount - 1;

                worksheet.Cells[5, 1, tableEndRow, 5].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    worksheet.Cells[tableStartRow + i, 2, tableStartRow + i, 5].Merge = true;
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        try
                        {
                            worksheet.Cells[i + tableStartRow, j + 1].Value = Int32.Parse(dgv[j, i].Value.ToString());
                        }
                        catch { worksheet.Cells[i + tableStartRow, j + 1].Value = dgv[j, i].Value.ToString(); }

                    }
                }

                // итого
                int row = tableEndRow + 1;
                cells = worksheet.Cells[tableEndRow + 1, 1, tableEndRow + 1, 2];

                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Merge = true;
                cells.Value = "Итого:";

                cells = worksheet.Cells[tableEndRow + 1, 3, tableEndRow + 1, 5];

                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Merge = true;
                cells.Formula = "=SUM(" + worksheet.Cells[tableStartRow, 2].Address + ":" + worksheet.Cells[tableEndRow, 2] + ")";

                //skip
                row = tableEndRow + 2;
                cells = worksheet.Cells[tableEndRow + 2, 1, tableEndRow + 2, 5];

                cells.Merge = true;
                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);

                //дата
                row = tableEndRow + 3;
                cells = worksheet.Cells[row, 1, row, 2];

                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Merge = true;
                cells.Value = "Дата:";

                cells = worksheet.Cells[row, 3, row, 5];

                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Merge = true;
                cells.Value = DateTime.Now.Date.ToString().Split(' ')[0];

                //ФИО должность
                row = tableEndRow + 4;
                cells = worksheet.Cells[row, 1, row, 2];

                worksheet.Columns[1].Width = 15;
                worksheet.Columns[3].Width = 50;


                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Value = "ФИО / Должность:";
                cells.Merge = true;
                

                cells = worksheet.Cells[row, 3, row, 5];
                

                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Value = owner.Split(" - ")[0] + " / " + owner.Split(" - ")[1];
                worksheet.Cells[tableEndRow + 4, 3].AutoFitColumns();
                cells.Merge = true;
                

                //подпись
                row = tableEndRow + 5;

                cells = worksheet.Cells[row, 1, row, 2];

                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Merge = true;
                cells.Value = "Подпись:";

                cells = worksheet.Cells[row, 3, row, 5];

                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Merge = true;

                for (int i = 1; i <= worksheet.Dimension.End.Column; i++)
                    worksheet.Column(i).Style.WrapText = false;
                worksheet.Row(row).Height = 50;

                // Сохранение файла Excel
                var fileInfo = new FileInfo("ReportBadPeoples.xlsx");
                package.SaveAs("C:\\Users\\Дмитрий\\Desktop\\" + fileInfo);
            }
        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            DateTime date1 = StartPeriodDate.Value.Date;
            DateTime date2 = EndPeriodDate.Value.Date;

            exportExcel(reportName, date1, date2, ReportView, ReportOwner.SelectedItem.ToString());
        }

        private void ReportOwnerAdd_Click(object sender, EventArgs e)
        {
            List<string[]>? rows = Functions.OpenNewWin("Работники", WinEnum.Librarians, true, this);
            if (rows == null) return;
            ReportOwner.SelectedItem = rows[0][3][0] + "." + rows[0][4][0] + "." + rows[0][2] + " - " + rows[0][1];
        }
    }
}
