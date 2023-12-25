namespace Library
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            ReportName = new Label();
            panel1 = new Panel();
            ReportError = new Label();
            label2 = new Label();
            EndPeriodDate = new DateTimePicker();
            setReport = new Button();
            StartPeriodDate = new DateTimePicker();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ExportMSWord = new Button();
            ReportView = new DataGridView();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            отчётыToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(ReportName, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(784, 537);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ReportName
            // 
            ReportName.AutoSize = true;
            ReportName.Location = new Point(10, 20);
            ReportName.Margin = new Padding(10, 20, 3, 0);
            ReportName.Name = "ReportName";
            ReportName.Size = new Size(235, 15);
            ReportName.TabIndex = 0;
            ReportName.Text = "Отчёт \"Задолженности по возврату книг\"";
            // 
            // panel1
            // 
            panel1.Controls.Add(ReportError);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(EndPeriodDate);
            panel1.Controls.Add(setReport);
            panel1.Controls.Add(StartPeriodDate);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 50);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 60);
            panel1.TabIndex = 1;
            // 
            // ReportError
            // 
            ReportError.AutoSize = true;
            ReportError.ForeColor = Color.Red;
            ReportError.Location = new Point(76, 11);
            ReportError.Name = "ReportError";
            ReportError.Size = new Size(32, 15);
            ReportError.TabIndex = 4;
            ReportError.Text = "error";
            ReportError.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 35);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 3;
            label2.Text = "-";
            // 
            // EndPeriodDate
            // 
            EndPeriodDate.Location = new Point(236, 29);
            EndPeriodDate.Name = "EndPeriodDate";
            EndPeriodDate.Size = new Size(200, 23);
            EndPeriodDate.TabIndex = 2;
            // 
            // setReport
            // 
            setReport.Anchor = AnchorStyles.Left;
            setReport.Location = new Point(459, 29);
            setReport.Name = "setReport";
            setReport.Size = new Size(128, 23);
            setReport.TabIndex = 2;
            setReport.Text = "Сформировать";
            setReport.UseVisualStyleBackColor = true;
            setReport.Click += setReport_Click;
            // 
            // StartPeriodDate
            // 
            StartPeriodDate.Location = new Point(12, 29);
            StartPeriodDate.Name = "StartPeriodDate";
            StartPeriodDate.Size = new Size(200, 23);
            StartPeriodDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Период";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(ReportView, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 110);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(784, 427);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(ExportMSWord, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(627, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(157, 427);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // ExportMSWord
            // 
            ExportMSWord.Anchor = AnchorStyles.Left;
            ExportMSWord.Location = new Point(3, 3);
            ExportMSWord.Name = "ExportMSWord";
            ExportMSWord.Size = new Size(128, 23);
            ExportMSWord.TabIndex = 4;
            ExportMSWord.Text = "MS Word";
            ExportMSWord.UseVisualStyleBackColor = true;
            ExportMSWord.Visible = false;
            // 
            // ReportView
            // 
            ReportView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportView.Dock = DockStyle.Fill;
            ReportView.Location = new Point(3, 3);
            ReportView.Name = "ReportView";
            ReportView.RowTemplate.Height = 25;
            ReportView.Size = new Size(621, 421);
            ReportView.TabIndex = 6;
            ReportView.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справочникиToolStripMenuItem, отчётыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // отчётыToolStripMenuItem
            // 
            отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            отчётыToolStripMenuItem.Size = new Size(60, 20);
            отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Name = "Report";
            Text = "Report";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReportView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label ReportName;
        private Panel panel1;
        private Label label2;
        private DateTimePicker EndPeriodDate;
        private DateTimePicker StartPeriodDate;
        private Label label1;
        private Button setReport;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ExportMSWord;
        private TableLayoutPanel tableLayoutPanel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem отчётыToolStripMenuItem;
        private DataGridView ReportView;
        private Label ReportError;
    }
}