using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void setReport_Click(object sender, EventArgs e)
        {
            DateTime date1 = StartPeriodDate.Value.Date;
            DateTime date2 = EndPeriodDate.Value.Date;

            ReportError.Visible = false;
            if (date1 >= date2) {
                ReportError.Text = "Даты должны идти от старой к новой";
                ReportError.Visible = true;
                return;
            }

            ReportView.Visible = true;
            ExportMSWord.Visible = true;

            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                
            }
        }
    }
}
