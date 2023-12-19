namespace Library
{
    partial class main_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.выдачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.работникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.издательстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.control_panel = new System.Windows.Forms.TableLayoutPanel();
            this.add_but = new System.Windows.Forms.Button();
            this.edit_but = new System.Windows.Forms.Button();
            this.del_but = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.window = new System.Windows.Forms.TabControl();
            this.MainWin = new System.Windows.Forms.TabPage();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.AddAuthorWin = new System.Windows.Forms.TabPage();
            this.AddAuthorGroup = new System.Windows.Forms.GroupBox();
            this.AuthorError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthorCancelBut = new System.Windows.Forms.Button();
            this.authorName = new System.Windows.Forms.TextBox();
            this.AuthorOKBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.authorName2 = new System.Windows.Forms.TextBox();
            this.authorName3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPublisherWin = new System.Windows.Forms.TabPage();
            this.AddPublisherGroup = new System.Windows.Forms.GroupBox();
            this.PublisherError = new System.Windows.Forms.Label();
            this.PublisherCancelBut = new System.Windows.Forms.Button();
            this.PublisherName = new System.Windows.Forms.TextBox();
            this.PublisherOKBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PublisherAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddGenreWin = new System.Windows.Forms.TabPage();
            this.AddGenreGroup = new System.Windows.Forms.GroupBox();
            this.GenreError = new System.Windows.Forms.Label();
            this.GenreCancelBut = new System.Windows.Forms.Button();
            this.GenreName = new System.Windows.Forms.TextBox();
            this.GenreOKBut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddPositionWin = new System.Windows.Forms.TabPage();
            this.AddPositionGroup = new System.Windows.Forms.GroupBox();
            this.PositionError = new System.Windows.Forms.Label();
            this.PositionCancelBut = new System.Windows.Forms.Button();
            this.PositionName = new System.Windows.Forms.TextBox();
            this.PositionOKBut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AddUserWin = new System.Windows.Forms.TabPage();
            this.AddUserGroup = new System.Windows.Forms.GroupBox();
            this.UserError = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UserCancelBut = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserOKBut = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.UserName2 = new System.Windows.Forms.TextBox();
            this.UserName3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AddLibrarianWin = new System.Windows.Forms.TabPage();
            this.AddLibrarianGroup = new System.Windows.Forms.GroupBox();
            this.goToPositions = new System.Windows.Forms.Button();
            this.LibrarianPosition = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.LibrarianError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LibrarianCancelBut = new System.Windows.Forms.Button();
            this.LibrarianName = new System.Windows.Forms.TextBox();
            this.LibrarianOKBut = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.LibrarianName2 = new System.Windows.Forms.TextBox();
            this.LibrarianName3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AddBookWin = new System.Windows.Forms.TabPage();
            this.AddBookGroup = new System.Windows.Forms.GroupBox();
            this.BookGenresView = new System.Windows.Forms.DataGridView();
            this.BookGenreDelete = new System.Windows.Forms.Button();
            this.BookGenreAdd = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.BookAuthorDelete = new System.Windows.Forms.Button();
            this.BookAuthorAdd = new System.Windows.Forms.Button();
            this.BookAuthorsView = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.BookDate = new System.Windows.Forms.DateTimePicker();
            this.BookPublisherAdd = new System.Windows.Forms.Button();
            this.BookPublisher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BookError = new System.Windows.Forms.Label();
            this.BookCancelBut = new System.Windows.Forms.Button();
            this.BookName = new System.Windows.Forms.TextBox();
            this.BookOKBut = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.search_panel = new System.Windows.Forms.TableLayoutPanel();
            this.search_but = new System.Windows.Forms.Button();
            this.clear_search_but = new System.Windows.Forms.Button();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.UserContacts = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.control_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.window.SuspendLayout();
            this.MainWin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.AddAuthorWin.SuspendLayout();
            this.AddAuthorGroup.SuspendLayout();
            this.AddPublisherWin.SuspendLayout();
            this.AddPublisherGroup.SuspendLayout();
            this.AddGenreWin.SuspendLayout();
            this.AddGenreGroup.SuspendLayout();
            this.AddPositionWin.SuspendLayout();
            this.AddPositionGroup.SuspendLayout();
            this.AddUserWin.SuspendLayout();
            this.AddUserGroup.SuspendLayout();
            this.AddLibrarianWin.SuspendLayout();
            this.AddLibrarianGroup.SuspendLayout();
            this.AddBookWin.SuspendLayout();
            this.AddBookGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookGenresView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookAuthorsView)).BeginInit();
            this.search_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.dictSelect,
            this.отчётыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // dictSelect
            // 
            this.dictSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выдачаToolStripMenuItem,
            this.toolStripMenuItem2,
            this.читателиToolStripMenuItem,
            this.книгаToolStripMenuItem,
            this.авторToolStripMenuItem,
            this.toolStripMenuItem1,
            this.работникиToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.toolStripMenuItem3,
            this.издательстваToolStripMenuItem,
            this.жанрыToolStripMenuItem});
            this.dictSelect.Name = "dictSelect";
            this.dictSelect.Size = new System.Drawing.Size(94, 20);
            this.dictSelect.Text = "Справочники";
            // 
            // выдачаToolStripMenuItem
            // 
            this.выдачаToolStripMenuItem.Name = "выдачаToolStripMenuItem";
            this.выдачаToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.выдачаToolStripMenuItem.Text = "Выдача";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 6);
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.читателиToolStripMenuItem.Text = "Читатели";
            // 
            // книгаToolStripMenuItem
            // 
            this.книгаToolStripMenuItem.Name = "книгаToolStripMenuItem";
            this.книгаToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.книгаToolStripMenuItem.Text = "Книги";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.авторToolStripMenuItem.Text = "Авторы";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
            // 
            // работникиToolStripMenuItem
            // 
            this.работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            this.работникиToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.работникиToolStripMenuItem.Text = "Работники";
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(144, 6);
            // 
            // издательстваToolStripMenuItem
            // 
            this.издательстваToolStripMenuItem.Name = "издательстваToolStripMenuItem";
            this.издательстваToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.издательстваToolStripMenuItem.Text = "Издательства";
            // 
            // жанрыToolStripMenuItem
            // 
            this.жанрыToolStripMenuItem.Name = "жанрыToolStripMenuItem";
            this.жанрыToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.жанрыToolStripMenuItem.Text = "Жанры";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // control_panel
            // 
            this.control_panel.ColumnCount = 1;
            this.control_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.control_panel.Controls.Add(this.add_but, 0, 0);
            this.control_panel.Controls.Add(this.edit_but, 0, 1);
            this.control_panel.Controls.Add(this.del_but, 0, 3);
            this.control_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_panel.Location = new System.Drawing.Point(657, 70);
            this.control_panel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.control_panel.Name = "control_panel";
            this.control_panel.RowCount = 5;
            this.control_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.control_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.control_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.control_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.control_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.control_panel.Size = new System.Drawing.Size(124, 474);
            this.control_panel.TabIndex = 4;
            // 
            // add_but
            // 
            this.add_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.add_but.Location = new System.Drawing.Point(3, 3);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(120, 23);
            this.add_but.TabIndex = 0;
            this.add_but.Text = "Добавить";
            this.add_but.UseVisualStyleBackColor = true;
            // 
            // edit_but
            // 
            this.edit_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_but.Location = new System.Drawing.Point(3, 32);
            this.edit_but.Name = "edit_but";
            this.edit_but.Size = new System.Drawing.Size(120, 23);
            this.edit_but.TabIndex = 1;
            this.edit_but.Text = "Изменить";
            this.edit_but.UseVisualStyleBackColor = true;
            // 
            // del_but
            // 
            this.del_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.del_but.Location = new System.Drawing.Point(3, 91);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(120, 23);
            this.del_but.TabIndex = 2;
            this.del_but.Text = "Удалить";
            this.del_but.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Controls.Add(this.control_panel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.window, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.search_panel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 535);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // window
            // 
            this.window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.window.Controls.Add(this.MainWin);
            this.window.Controls.Add(this.AddAuthorWin);
            this.window.Controls.Add(this.AddPublisherWin);
            this.window.Controls.Add(this.AddGenreWin);
            this.window.Controls.Add(this.AddPositionWin);
            this.window.Controls.Add(this.AddUserWin);
            this.window.Controls.Add(this.AddLibrarianWin);
            this.window.Controls.Add(this.AddBookWin);
            this.window.Location = new System.Drawing.Point(10, 70);
            this.window.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.window.Name = "window";
            this.window.Padding = new System.Drawing.Point(0, 0);
            this.window.SelectedIndex = 0;
            this.window.Size = new System.Drawing.Size(644, 467);
            this.window.TabIndex = 7;
            // 
            // MainWin
            // 
            this.MainWin.Controls.Add(this.dataView);
            this.MainWin.Location = new System.Drawing.Point(4, 24);
            this.MainWin.Margin = new System.Windows.Forms.Padding(0);
            this.MainWin.Name = "MainWin";
            this.MainWin.Size = new System.Drawing.Size(636, 439);
            this.MainWin.TabIndex = 0;
            this.MainWin.Text = "Main";
            this.MainWin.UseVisualStyleBackColor = true;
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AllowUserToResizeRows = false;
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataView.Location = new System.Drawing.Point(0, 0);
            this.dataView.Margin = new System.Windows.Forms.Padding(0);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 25;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(636, 439);
            this.dataView.TabIndex = 0;
            // 
            // AddAuthorWin
            // 
            this.AddAuthorWin.Controls.Add(this.AddAuthorGroup);
            this.AddAuthorWin.Location = new System.Drawing.Point(4, 24);
            this.AddAuthorWin.Name = "AddAuthorWin";
            this.AddAuthorWin.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.AddAuthorWin.Size = new System.Drawing.Size(636, 439);
            this.AddAuthorWin.TabIndex = 1;
            this.AddAuthorWin.Text = "Author";
            this.AddAuthorWin.UseVisualStyleBackColor = true;
            // 
            // AddAuthorGroup
            // 
            this.AddAuthorGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAuthorGroup.Controls.Add(this.AuthorError);
            this.AddAuthorGroup.Controls.Add(this.label3);
            this.AddAuthorGroup.Controls.Add(this.AuthorCancelBut);
            this.AddAuthorGroup.Controls.Add(this.authorName);
            this.AddAuthorGroup.Controls.Add(this.AuthorOKBut);
            this.AddAuthorGroup.Controls.Add(this.label1);
            this.AddAuthorGroup.Controls.Add(this.authorName2);
            this.AddAuthorGroup.Controls.Add(this.authorName3);
            this.AddAuthorGroup.Controls.Add(this.label2);
            this.AddAuthorGroup.Location = new System.Drawing.Point(6, 3);
            this.AddAuthorGroup.Name = "AddAuthorGroup";
            this.AddAuthorGroup.Size = new System.Drawing.Size(626, 220);
            this.AddAuthorGroup.TabIndex = 8;
            this.AddAuthorGroup.TabStop = false;
            this.AddAuthorGroup.Text = "Добавление";
            // 
            // AuthorError
            // 
            this.AuthorError.AutoSize = true;
            this.AuthorError.ForeColor = System.Drawing.Color.Red;
            this.AuthorError.Location = new System.Drawing.Point(6, 166);
            this.AuthorError.Name = "AuthorError";
            this.AuthorError.Size = new System.Drawing.Size(0, 15);
            this.AuthorError.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // AuthorCancelBut
            // 
            this.AuthorCancelBut.Location = new System.Drawing.Point(545, 191);
            this.AuthorCancelBut.Name = "AuthorCancelBut";
            this.AuthorCancelBut.Size = new System.Drawing.Size(75, 23);
            this.AuthorCancelBut.TabIndex = 7;
            this.AuthorCancelBut.Text = "Отмена";
            this.AuthorCancelBut.UseVisualStyleBackColor = true;
            // 
            // authorName
            // 
            this.authorName.Location = new System.Drawing.Point(6, 43);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(191, 23);
            this.authorName.TabIndex = 0;
            // 
            // AuthorOKBut
            // 
            this.AuthorOKBut.Location = new System.Drawing.Point(464, 191);
            this.AuthorOKBut.Name = "AuthorOKBut";
            this.AuthorOKBut.Size = new System.Drawing.Size(75, 23);
            this.AuthorOKBut.TabIndex = 6;
            this.AuthorOKBut.Text = "ОК";
            this.AuthorOKBut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя*";
            // 
            // authorName2
            // 
            this.authorName2.Location = new System.Drawing.Point(6, 87);
            this.authorName2.Name = "authorName2";
            this.authorName2.Size = new System.Drawing.Size(191, 23);
            this.authorName2.TabIndex = 2;
            // 
            // authorName3
            // 
            this.authorName3.Location = new System.Drawing.Point(6, 131);
            this.authorName3.Name = "authorName3";
            this.authorName3.Size = new System.Drawing.Size(191, 23);
            this.authorName3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия*";
            // 
            // AddPublisherWin
            // 
            this.AddPublisherWin.Controls.Add(this.AddPublisherGroup);
            this.AddPublisherWin.Location = new System.Drawing.Point(4, 24);
            this.AddPublisherWin.Name = "AddPublisherWin";
            this.AddPublisherWin.Size = new System.Drawing.Size(636, 439);
            this.AddPublisherWin.TabIndex = 2;
            this.AddPublisherWin.Text = "Publisher";
            this.AddPublisherWin.UseVisualStyleBackColor = true;
            // 
            // AddPublisherGroup
            // 
            this.AddPublisherGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPublisherGroup.Controls.Add(this.PublisherError);
            this.AddPublisherGroup.Controls.Add(this.PublisherCancelBut);
            this.AddPublisherGroup.Controls.Add(this.PublisherName);
            this.AddPublisherGroup.Controls.Add(this.PublisherOKBut);
            this.AddPublisherGroup.Controls.Add(this.label6);
            this.AddPublisherGroup.Controls.Add(this.PublisherAddress);
            this.AddPublisherGroup.Controls.Add(this.label7);
            this.AddPublisherGroup.Location = new System.Drawing.Point(6, 3);
            this.AddPublisherGroup.Name = "AddPublisherGroup";
            this.AddPublisherGroup.Size = new System.Drawing.Size(626, 220);
            this.AddPublisherGroup.TabIndex = 9;
            this.AddPublisherGroup.TabStop = false;
            this.AddPublisherGroup.Text = "Добавление";
            // 
            // PublisherError
            // 
            this.PublisherError.AutoSize = true;
            this.PublisherError.ForeColor = System.Drawing.Color.Red;
            this.PublisherError.Location = new System.Drawing.Point(6, 166);
            this.PublisherError.Name = "PublisherError";
            this.PublisherError.Size = new System.Drawing.Size(0, 15);
            this.PublisherError.TabIndex = 8;
            // 
            // PublisherCancelBut
            // 
            this.PublisherCancelBut.Location = new System.Drawing.Point(545, 191);
            this.PublisherCancelBut.Name = "PublisherCancelBut";
            this.PublisherCancelBut.Size = new System.Drawing.Size(75, 23);
            this.PublisherCancelBut.TabIndex = 7;
            this.PublisherCancelBut.Text = "Отмена";
            this.PublisherCancelBut.UseVisualStyleBackColor = true;
            // 
            // PublisherName
            // 
            this.PublisherName.Location = new System.Drawing.Point(6, 43);
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.Size = new System.Drawing.Size(233, 23);
            this.PublisherName.TabIndex = 0;
            // 
            // PublisherOKBut
            // 
            this.PublisherOKBut.Location = new System.Drawing.Point(464, 191);
            this.PublisherOKBut.Name = "PublisherOKBut";
            this.PublisherOKBut.Size = new System.Drawing.Size(75, 23);
            this.PublisherOKBut.TabIndex = 6;
            this.PublisherOKBut.Text = "ОК";
            this.PublisherOKBut.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Наименование*";
            // 
            // PublisherAddress
            // 
            this.PublisherAddress.Location = new System.Drawing.Point(6, 87);
            this.PublisherAddress.Name = "PublisherAddress";
            this.PublisherAddress.Size = new System.Drawing.Size(378, 23);
            this.PublisherAddress.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Адрес*";
            // 
            // AddGenreWin
            // 
            this.AddGenreWin.Controls.Add(this.AddGenreGroup);
            this.AddGenreWin.Location = new System.Drawing.Point(4, 24);
            this.AddGenreWin.Name = "AddGenreWin";
            this.AddGenreWin.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.AddGenreWin.Size = new System.Drawing.Size(636, 439);
            this.AddGenreWin.TabIndex = 3;
            this.AddGenreWin.Text = "Genres";
            this.AddGenreWin.UseVisualStyleBackColor = true;
            // 
            // AddGenreGroup
            // 
            this.AddGenreGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddGenreGroup.Controls.Add(this.GenreError);
            this.AddGenreGroup.Controls.Add(this.GenreCancelBut);
            this.AddGenreGroup.Controls.Add(this.GenreName);
            this.AddGenreGroup.Controls.Add(this.GenreOKBut);
            this.AddGenreGroup.Controls.Add(this.label5);
            this.AddGenreGroup.Location = new System.Drawing.Point(6, 3);
            this.AddGenreGroup.Name = "AddGenreGroup";
            this.AddGenreGroup.Size = new System.Drawing.Size(626, 220);
            this.AddGenreGroup.TabIndex = 10;
            this.AddGenreGroup.TabStop = false;
            this.AddGenreGroup.Text = "Добавление";
            // 
            // GenreError
            // 
            this.GenreError.AutoSize = true;
            this.GenreError.ForeColor = System.Drawing.Color.Red;
            this.GenreError.Location = new System.Drawing.Point(6, 166);
            this.GenreError.Name = "GenreError";
            this.GenreError.Size = new System.Drawing.Size(0, 15);
            this.GenreError.TabIndex = 8;
            // 
            // GenreCancelBut
            // 
            this.GenreCancelBut.Location = new System.Drawing.Point(545, 191);
            this.GenreCancelBut.Name = "GenreCancelBut";
            this.GenreCancelBut.Size = new System.Drawing.Size(75, 23);
            this.GenreCancelBut.TabIndex = 7;
            this.GenreCancelBut.Text = "Отмена";
            this.GenreCancelBut.UseVisualStyleBackColor = true;
            // 
            // GenreName
            // 
            this.GenreName.Location = new System.Drawing.Point(6, 43);
            this.GenreName.Name = "GenreName";
            this.GenreName.Size = new System.Drawing.Size(154, 23);
            this.GenreName.TabIndex = 0;
            // 
            // GenreOKBut
            // 
            this.GenreOKBut.Location = new System.Drawing.Point(464, 191);
            this.GenreOKBut.Name = "GenreOKBut";
            this.GenreOKBut.Size = new System.Drawing.Size(75, 23);
            this.GenreOKBut.TabIndex = 6;
            this.GenreOKBut.Text = "ОК";
            this.GenreOKBut.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Наименование*";
            // 
            // AddPositionWin
            // 
            this.AddPositionWin.Controls.Add(this.AddPositionGroup);
            this.AddPositionWin.Location = new System.Drawing.Point(4, 24);
            this.AddPositionWin.Name = "AddPositionWin";
            this.AddPositionWin.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.AddPositionWin.Size = new System.Drawing.Size(636, 439);
            this.AddPositionWin.TabIndex = 4;
            this.AddPositionWin.Text = "Positions";
            this.AddPositionWin.UseVisualStyleBackColor = true;
            // 
            // AddPositionGroup
            // 
            this.AddPositionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPositionGroup.Controls.Add(this.PositionError);
            this.AddPositionGroup.Controls.Add(this.PositionCancelBut);
            this.AddPositionGroup.Controls.Add(this.PositionName);
            this.AddPositionGroup.Controls.Add(this.PositionOKBut);
            this.AddPositionGroup.Controls.Add(this.label8);
            this.AddPositionGroup.Location = new System.Drawing.Point(6, 3);
            this.AddPositionGroup.Name = "AddPositionGroup";
            this.AddPositionGroup.Size = new System.Drawing.Size(626, 220);
            this.AddPositionGroup.TabIndex = 11;
            this.AddPositionGroup.TabStop = false;
            this.AddPositionGroup.Text = "Добавление";
            // 
            // PositionError
            // 
            this.PositionError.AutoSize = true;
            this.PositionError.ForeColor = System.Drawing.Color.Red;
            this.PositionError.Location = new System.Drawing.Point(6, 166);
            this.PositionError.Name = "PositionError";
            this.PositionError.Size = new System.Drawing.Size(0, 15);
            this.PositionError.TabIndex = 8;
            // 
            // PositionCancelBut
            // 
            this.PositionCancelBut.Location = new System.Drawing.Point(545, 191);
            this.PositionCancelBut.Name = "PositionCancelBut";
            this.PositionCancelBut.Size = new System.Drawing.Size(75, 23);
            this.PositionCancelBut.TabIndex = 7;
            this.PositionCancelBut.Text = "Отмена";
            this.PositionCancelBut.UseVisualStyleBackColor = true;
            // 
            // PositionName
            // 
            this.PositionName.Location = new System.Drawing.Point(6, 43);
            this.PositionName.Name = "PositionName";
            this.PositionName.Size = new System.Drawing.Size(233, 23);
            this.PositionName.TabIndex = 0;
            // 
            // PositionOKBut
            // 
            this.PositionOKBut.Location = new System.Drawing.Point(464, 191);
            this.PositionOKBut.Name = "PositionOKBut";
            this.PositionOKBut.Size = new System.Drawing.Size(75, 23);
            this.PositionOKBut.TabIndex = 6;
            this.PositionOKBut.Text = "ОК";
            this.PositionOKBut.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Наименование*";
            // 
            // AddUserWin
            // 
            this.AddUserWin.Controls.Add(this.AddUserGroup);
            this.AddUserWin.Location = new System.Drawing.Point(4, 24);
            this.AddUserWin.Name = "AddUserWin";
            this.AddUserWin.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.AddUserWin.Size = new System.Drawing.Size(636, 439);
            this.AddUserWin.TabIndex = 5;
            this.AddUserWin.Text = "Users";
            this.AddUserWin.UseVisualStyleBackColor = true;
            // 
            // AddUserGroup
            // 
            this.AddUserGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUserGroup.Controls.Add(this.label16);
            this.AddUserGroup.Controls.Add(this.UserContacts);
            this.AddUserGroup.Controls.Add(this.UserError);
            this.AddUserGroup.Controls.Add(this.label10);
            this.AddUserGroup.Controls.Add(this.UserCancelBut);
            this.AddUserGroup.Controls.Add(this.UserName);
            this.AddUserGroup.Controls.Add(this.UserOKBut);
            this.AddUserGroup.Controls.Add(this.label11);
            this.AddUserGroup.Controls.Add(this.UserName2);
            this.AddUserGroup.Controls.Add(this.UserName3);
            this.AddUserGroup.Controls.Add(this.label12);
            this.AddUserGroup.Location = new System.Drawing.Point(6, 3);
            this.AddUserGroup.Name = "AddUserGroup";
            this.AddUserGroup.Size = new System.Drawing.Size(626, 269);
            this.AddUserGroup.TabIndex = 9;
            this.AddUserGroup.TabStop = false;
            this.AddUserGroup.Text = "Добавление";
            // 
            // UserError
            // 
            this.UserError.AutoSize = true;
            this.UserError.ForeColor = System.Drawing.Color.Red;
            this.UserError.Location = new System.Drawing.Point(6, 244);
            this.UserError.Name = "UserError";
            this.UserError.Size = new System.Drawing.Size(32, 15);
            this.UserError.TabIndex = 8;
            this.UserError.Text = "error";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Отчество";
            // 
            // UserCancelBut
            // 
            this.UserCancelBut.Location = new System.Drawing.Point(545, 240);
            this.UserCancelBut.Name = "UserCancelBut";
            this.UserCancelBut.Size = new System.Drawing.Size(75, 23);
            this.UserCancelBut.TabIndex = 7;
            this.UserCancelBut.Text = "Отмена";
            this.UserCancelBut.UseVisualStyleBackColor = true;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(6, 43);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(191, 23);
            this.UserName.TabIndex = 0;
            // 
            // UserOKBut
            // 
            this.UserOKBut.Location = new System.Drawing.Point(464, 240);
            this.UserOKBut.Name = "UserOKBut";
            this.UserOKBut.Size = new System.Drawing.Size(75, 23);
            this.UserOKBut.TabIndex = 6;
            this.UserOKBut.Text = "ОК";
            this.UserOKBut.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Имя*";
            // 
            // UserName2
            // 
            this.UserName2.Location = new System.Drawing.Point(6, 87);
            this.UserName2.Name = "UserName2";
            this.UserName2.Size = new System.Drawing.Size(191, 23);
            this.UserName2.TabIndex = 2;
            // 
            // UserName3
            // 
            this.UserName3.Location = new System.Drawing.Point(6, 131);
            this.UserName3.Name = "UserName3";
            this.UserName3.Size = new System.Drawing.Size(191, 23);
            this.UserName3.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Фамилия*";
            // 
            // AddLibrarianWin
            // 
            this.AddLibrarianWin.Controls.Add(this.AddLibrarianGroup);
            this.AddLibrarianWin.Location = new System.Drawing.Point(4, 24);
            this.AddLibrarianWin.Name = "AddLibrarianWin";
            this.AddLibrarianWin.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.AddLibrarianWin.Size = new System.Drawing.Size(636, 439);
            this.AddLibrarianWin.TabIndex = 6;
            this.AddLibrarianWin.Text = "Librarians";
            this.AddLibrarianWin.UseVisualStyleBackColor = true;
            // 
            // AddLibrarianGroup
            // 
            this.AddLibrarianGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLibrarianGroup.Controls.Add(this.goToPositions);
            this.AddLibrarianGroup.Controls.Add(this.LibrarianPosition);
            this.AddLibrarianGroup.Controls.Add(this.label15);
            this.AddLibrarianGroup.Controls.Add(this.LibrarianError);
            this.AddLibrarianGroup.Controls.Add(this.label9);
            this.AddLibrarianGroup.Controls.Add(this.LibrarianCancelBut);
            this.AddLibrarianGroup.Controls.Add(this.LibrarianName);
            this.AddLibrarianGroup.Controls.Add(this.LibrarianOKBut);
            this.AddLibrarianGroup.Controls.Add(this.label13);
            this.AddLibrarianGroup.Controls.Add(this.LibrarianName2);
            this.AddLibrarianGroup.Controls.Add(this.LibrarianName3);
            this.AddLibrarianGroup.Controls.Add(this.label14);
            this.AddLibrarianGroup.Location = new System.Drawing.Point(6, 3);
            this.AddLibrarianGroup.Name = "AddLibrarianGroup";
            this.AddLibrarianGroup.Size = new System.Drawing.Size(626, 284);
            this.AddLibrarianGroup.TabIndex = 10;
            this.AddLibrarianGroup.TabStop = false;
            this.AddLibrarianGroup.Text = "Добавление";
            // 
            // goToPositions
            // 
            this.goToPositions.Location = new System.Drawing.Point(243, 175);
            this.goToPositions.Name = "goToPositions";
            this.goToPositions.Size = new System.Drawing.Size(24, 23);
            this.goToPositions.TabIndex = 12;
            this.goToPositions.Text = "...";
            this.goToPositions.UseVisualStyleBackColor = true;
            // 
            // LibrarianPosition
            // 
            this.LibrarianPosition.FormattingEnabled = true;
            this.LibrarianPosition.Location = new System.Drawing.Point(6, 175);
            this.LibrarianPosition.Name = "LibrarianPosition";
            this.LibrarianPosition.Size = new System.Drawing.Size(231, 23);
            this.LibrarianPosition.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "Должность";
            // 
            // LibrarianError
            // 
            this.LibrarianError.AutoSize = true;
            this.LibrarianError.ForeColor = System.Drawing.Color.Red;
            this.LibrarianError.Location = new System.Drawing.Point(6, 235);
            this.LibrarianError.Name = "LibrarianError";
            this.LibrarianError.Size = new System.Drawing.Size(32, 15);
            this.LibrarianError.TabIndex = 8;
            this.LibrarianError.Text = "error";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Отчество";
            // 
            // LibrarianCancelBut
            // 
            this.LibrarianCancelBut.Location = new System.Drawing.Point(545, 255);
            this.LibrarianCancelBut.Name = "LibrarianCancelBut";
            this.LibrarianCancelBut.Size = new System.Drawing.Size(75, 23);
            this.LibrarianCancelBut.TabIndex = 7;
            this.LibrarianCancelBut.Text = "Отмена";
            this.LibrarianCancelBut.UseVisualStyleBackColor = true;
            // 
            // LibrarianName
            // 
            this.LibrarianName.Location = new System.Drawing.Point(6, 43);
            this.LibrarianName.Name = "LibrarianName";
            this.LibrarianName.Size = new System.Drawing.Size(191, 23);
            this.LibrarianName.TabIndex = 0;
            // 
            // LibrarianOKBut
            // 
            this.LibrarianOKBut.Location = new System.Drawing.Point(464, 255);
            this.LibrarianOKBut.Name = "LibrarianOKBut";
            this.LibrarianOKBut.Size = new System.Drawing.Size(75, 23);
            this.LibrarianOKBut.TabIndex = 6;
            this.LibrarianOKBut.Text = "ОК";
            this.LibrarianOKBut.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Имя*";
            // 
            // LibrarianName2
            // 
            this.LibrarianName2.Location = new System.Drawing.Point(6, 87);
            this.LibrarianName2.Name = "LibrarianName2";
            this.LibrarianName2.Size = new System.Drawing.Size(191, 23);
            this.LibrarianName2.TabIndex = 2;
            // 
            // LibrarianName3
            // 
            this.LibrarianName3.Location = new System.Drawing.Point(6, 131);
            this.LibrarianName3.Name = "LibrarianName3";
            this.LibrarianName3.Size = new System.Drawing.Size(191, 23);
            this.LibrarianName3.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Фамилия*";
            // 
            // AddBookWin
            // 
            this.AddBookWin.Controls.Add(this.AddBookGroup);
            this.AddBookWin.Location = new System.Drawing.Point(4, 24);
            this.AddBookWin.Name = "AddBookWin";
            this.AddBookWin.Size = new System.Drawing.Size(636, 439);
            this.AddBookWin.TabIndex = 7;
            this.AddBookWin.Text = "Books";
            this.AddBookWin.UseVisualStyleBackColor = true;
            // 
            // AddBookGroup
            // 
            this.AddBookGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBookGroup.Controls.Add(this.BookGenresView);
            this.AddBookGroup.Controls.Add(this.BookGenreDelete);
            this.AddBookGroup.Controls.Add(this.BookGenreAdd);
            this.AddBookGroup.Controls.Add(this.label20);
            this.AddBookGroup.Controls.Add(this.BookAuthorDelete);
            this.AddBookGroup.Controls.Add(this.BookAuthorAdd);
            this.AddBookGroup.Controls.Add(this.BookAuthorsView);
            this.AddBookGroup.Controls.Add(this.label17);
            this.AddBookGroup.Controls.Add(this.BookDate);
            this.AddBookGroup.Controls.Add(this.BookPublisherAdd);
            this.AddBookGroup.Controls.Add(this.BookPublisher);
            this.AddBookGroup.Controls.Add(this.label4);
            this.AddBookGroup.Controls.Add(this.BookError);
            this.AddBookGroup.Controls.Add(this.BookCancelBut);
            this.AddBookGroup.Controls.Add(this.BookName);
            this.AddBookGroup.Controls.Add(this.BookOKBut);
            this.AddBookGroup.Controls.Add(this.label18);
            this.AddBookGroup.Controls.Add(this.label19);
            this.AddBookGroup.Location = new System.Drawing.Point(6, 3);
            this.AddBookGroup.Name = "AddBookGroup";
            this.AddBookGroup.Size = new System.Drawing.Size(626, 433);
            this.AddBookGroup.TabIndex = 11;
            this.AddBookGroup.TabStop = false;
            this.AddBookGroup.Text = "Добавление";
            // 
            // BookGenresView
            // 
            this.BookGenresView.AllowUserToAddRows = false;
            this.BookGenresView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookGenresView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGenresView.Location = new System.Drawing.Point(6, 272);
            this.BookGenresView.Name = "BookGenresView";
            this.BookGenresView.ReadOnly = true;
            this.BookGenresView.RowHeadersWidth = 51;
            this.BookGenresView.RowTemplate.Height = 25;
            this.BookGenresView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookGenresView.Size = new System.Drawing.Size(193, 76);
            this.BookGenresView.TabIndex = 22;
            // 
            // BookGenreDelete
            // 
            this.BookGenreDelete.Location = new System.Drawing.Point(205, 310);
            this.BookGenreDelete.Name = "BookGenreDelete";
            this.BookGenreDelete.Size = new System.Drawing.Size(32, 32);
            this.BookGenreDelete.TabIndex = 21;
            this.BookGenreDelete.Text = "-";
            this.BookGenreDelete.UseVisualStyleBackColor = true;
            // 
            // BookGenreAdd
            // 
            this.BookGenreAdd.Location = new System.Drawing.Point(205, 272);
            this.BookGenreAdd.Name = "BookGenreAdd";
            this.BookGenreAdd.Size = new System.Drawing.Size(32, 32);
            this.BookGenreAdd.TabIndex = 20;
            this.BookGenreAdd.Text = "+";
            this.BookGenreAdd.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 254);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 15);
            this.label20.TabIndex = 18;
            this.label20.Text = "Жанры";
            // 
            // BookAuthorDelete
            // 
            this.BookAuthorDelete.Location = new System.Drawing.Point(394, 213);
            this.BookAuthorDelete.Name = "BookAuthorDelete";
            this.BookAuthorDelete.Size = new System.Drawing.Size(32, 32);
            this.BookAuthorDelete.TabIndex = 17;
            this.BookAuthorDelete.Text = "-";
            this.BookAuthorDelete.UseVisualStyleBackColor = true;
            // 
            // BookAuthorAdd
            // 
            this.BookAuthorAdd.Location = new System.Drawing.Point(394, 175);
            this.BookAuthorAdd.Name = "BookAuthorAdd";
            this.BookAuthorAdd.Size = new System.Drawing.Size(32, 32);
            this.BookAuthorAdd.TabIndex = 16;
            this.BookAuthorAdd.Text = "+";
            this.BookAuthorAdd.UseVisualStyleBackColor = true;
            // 
            // BookAuthorsView
            // 
            this.BookAuthorsView.AllowUserToAddRows = false;
            this.BookAuthorsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookAuthorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookAuthorsView.Location = new System.Drawing.Point(6, 175);
            this.BookAuthorsView.Name = "BookAuthorsView";
            this.BookAuthorsView.ReadOnly = true;
            this.BookAuthorsView.RowHeadersWidth = 51;
            this.BookAuthorsView.RowTemplate.Height = 25;
            this.BookAuthorsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookAuthorsView.Size = new System.Drawing.Size(382, 76);
            this.BookAuthorsView.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "Авторы";
            // 
            // BookDate
            // 
            this.BookDate.Location = new System.Drawing.Point(6, 87);
            this.BookDate.Name = "BookDate";
            this.BookDate.Size = new System.Drawing.Size(191, 23);
            this.BookDate.TabIndex = 13;
            // 
            // BookPublisherAdd
            // 
            this.BookPublisherAdd.Location = new System.Drawing.Point(243, 131);
            this.BookPublisherAdd.Name = "BookPublisherAdd";
            this.BookPublisherAdd.Size = new System.Drawing.Size(24, 23);
            this.BookPublisherAdd.TabIndex = 12;
            this.BookPublisherAdd.Text = "...";
            this.BookPublisherAdd.UseVisualStyleBackColor = true;
            // 
            // BookPublisher
            // 
            this.BookPublisher.FormattingEnabled = true;
            this.BookPublisher.Location = new System.Drawing.Point(6, 131);
            this.BookPublisher.Name = "BookPublisher";
            this.BookPublisher.Size = new System.Drawing.Size(231, 23);
            this.BookPublisher.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Издательство";
            // 
            // BookError
            // 
            this.BookError.AutoSize = true;
            this.BookError.ForeColor = System.Drawing.Color.Red;
            this.BookError.Location = new System.Drawing.Point(6, 408);
            this.BookError.Name = "BookError";
            this.BookError.Size = new System.Drawing.Size(32, 15);
            this.BookError.TabIndex = 8;
            this.BookError.Text = "error";
            // 
            // BookCancelBut
            // 
            this.BookCancelBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookCancelBut.Location = new System.Drawing.Point(545, 404);
            this.BookCancelBut.Name = "BookCancelBut";
            this.BookCancelBut.Size = new System.Drawing.Size(75, 23);
            this.BookCancelBut.TabIndex = 7;
            this.BookCancelBut.Text = "Отмена";
            this.BookCancelBut.UseVisualStyleBackColor = true;
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(6, 43);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(296, 23);
            this.BookName.TabIndex = 0;
            // 
            // BookOKBut
            // 
            this.BookOKBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookOKBut.Location = new System.Drawing.Point(464, 404);
            this.BookOKBut.Name = "BookOKBut";
            this.BookOKBut.Size = new System.Drawing.Size(75, 23);
            this.BookOKBut.TabIndex = 6;
            this.BookOKBut.Text = "ОК";
            this.BookOKBut.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 15);
            this.label18.TabIndex = 1;
            this.label18.Text = "Название*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "Дата публикации";
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(20, 7);
            this.label.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(106, 15);
            this.label.TabIndex = 8;
            this.label.Text = "Имя справочника";
            // 
            // search_panel
            // 
            this.search_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.search_panel.ColumnCount = 4;
            this.search_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.search_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.search_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.search_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.search_panel.Controls.Add(this.search_but, 1, 0);
            this.search_panel.Controls.Add(this.clear_search_but, 2, 0);
            this.search_panel.Controls.Add(this.search_bar, 0, 0);
            this.search_panel.Location = new System.Drawing.Point(191, 30);
            this.search_panel.Margin = new System.Windows.Forms.Padding(0);
            this.search_panel.Name = "search_panel";
            this.search_panel.RowCount = 1;
            this.search_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.search_panel.Size = new System.Drawing.Size(463, 30);
            this.search_panel.TabIndex = 6;
            // 
            // search_but
            // 
            this.search_but.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search_but.Location = new System.Drawing.Point(303, 3);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(74, 23);
            this.search_but.TabIndex = 1;
            this.search_but.Text = "Найти";
            this.search_but.UseVisualStyleBackColor = true;
            // 
            // clear_search_but
            // 
            this.clear_search_but.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clear_search_but.Location = new System.Drawing.Point(383, 3);
            this.clear_search_but.Name = "clear_search_but";
            this.clear_search_but.Size = new System.Drawing.Size(74, 23);
            this.clear_search_but.TabIndex = 2;
            this.clear_search_but.Text = "Очистить";
            this.clear_search_but.UseVisualStyleBackColor = true;
            // 
            // search_bar
            // 
            this.search_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.search_bar.Location = new System.Drawing.Point(3, 3);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(294, 23);
            this.search_bar.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 15);
            this.label16.TabIndex = 10;
            this.label16.Text = "Контактные данные";
            // 
            // UserContacts
            // 
            this.UserContacts.Location = new System.Drawing.Point(6, 175);
            this.UserContacts.Name = "UserContacts";
            this.UserContacts.Size = new System.Drawing.Size(283, 23);
            this.UserContacts.TabIndex = 9;
            // 
            // main_form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1200, 598);
            this.MinimumSize = new System.Drawing.Size(800, 598);
            this.Name = "main_form";
            this.Text = "библиотека";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.control_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.window.ResumeLayout(false);
            this.MainWin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.AddAuthorWin.ResumeLayout(false);
            this.AddAuthorGroup.ResumeLayout(false);
            this.AddAuthorGroup.PerformLayout();
            this.AddPublisherWin.ResumeLayout(false);
            this.AddPublisherGroup.ResumeLayout(false);
            this.AddPublisherGroup.PerformLayout();
            this.AddGenreWin.ResumeLayout(false);
            this.AddGenreGroup.ResumeLayout(false);
            this.AddGenreGroup.PerformLayout();
            this.AddPositionWin.ResumeLayout(false);
            this.AddPositionGroup.ResumeLayout(false);
            this.AddPositionGroup.PerformLayout();
            this.AddUserWin.ResumeLayout(false);
            this.AddUserGroup.ResumeLayout(false);
            this.AddUserGroup.PerformLayout();
            this.AddLibrarianWin.ResumeLayout(false);
            this.AddLibrarianGroup.ResumeLayout(false);
            this.AddLibrarianGroup.PerformLayout();
            this.AddBookWin.ResumeLayout(false);
            this.AddBookGroup.ResumeLayout(false);
            this.AddBookGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookGenresView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookAuthorsView)).EndInit();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem dictSelect;
        private TableLayoutPanel control_panel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel search_panel;
        private TextBox search_bar;
        private Button search_but;
        private Button clear_search_but;
        private TabControl window;
        private TabPage MainWin;
        private TabPage AddAuthorWin;
        private Button del_but;
        private Button add_but;
        private Button edit_but;
        private Label label;
        private DataGridView dataView;
        private ToolStripMenuItem выдачаToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem книгаToolStripMenuItem;
        private ToolStripMenuItem авторToolStripMenuItem;
        private ToolStripMenuItem читателиToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem работникиToolStripMenuItem;
        private ToolStripMenuItem должностиToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem издательстваToolStripMenuItem;
        private ToolStripMenuItem жанрыToolStripMenuItem;
        private Button AuthorCancelBut;
        private Button AuthorOKBut;
        private Label label3;
        private TextBox authorName3;
        private Label label2;
        private TextBox authorName2;
        private Label label1;
        private TextBox authorName;
        private GroupBox AddAuthorGroup;
        private Label AuthorError;
        private ContextMenuStrip contextMenuStrip1;
        private TabPage AddPublisherWin;
        private GroupBox AddPublisherGroup;
        private Label PublisherError;
        private Button PublisherCancelBut;
        private TextBox PublisherName;
        private Button PublisherOKBut;
        private Label label6;
        private TextBox PublisherAddress;
        private Label label7;
        private ToolStripMenuItem отчётыToolStripMenuItem;
        private TabPage AddGenreWin;
        private GroupBox AddGenreGroup;
        private Label GenreError;
        private Button GenreCancelBut;
        private TextBox GenreName;
        private Button GenreOKBut;
        private Label label5;
        private TabPage AddPositionWin;
        private GroupBox AddPositionGroup;
        private Label PositionError;
        private Button PositionCancelBut;
        private TextBox PositionName;
        private Button PositionOKBut;
        private Label label8;
        private TabPage AddUserWin;
        private GroupBox AddUserGroup;
        private Label UserError;
        private Label label10;
        private Button UserCancelBut;
        private TextBox UserName;
        private Button UserOKBut;
        private Label label11;
        private TextBox UserName2;
        private TextBox UserName3;
        private Label label12;
        private TabPage AddLibrarianWin;
        private GroupBox AddLibrarianGroup;
        private Label LibrarianError;
        private Label label9;
        private Button LibrarianCancelBut;
        private TextBox LibrarianName;
        private Button LibrarianOKBut;
        private Label label13;
        private TextBox LibrarianName2;
        private TextBox LibrarianName3;
        private Label label14;
        private ComboBox LibrarianPosition;
        private Label label15;
        private TabPage AddBookWin;
        private Button goToPositions;
        private GroupBox AddBookGroup;
        private DateTimePicker BookDate;
        private Button BookPublisherAdd;
        private ComboBox BookPublisher;
        private Label label4;
        private Label BookError;
        private Button BookCancelBut;
        private TextBox BookName;
        private Button BookOKBut;
        private Label label18;
        private Label label19;
        private Button BookGenreDelete;
        private Button BookGenreAdd;
        private Label label20;
        private Button BookAuthorDelete;
        private Button BookAuthorAdd;
        private DataGridView BookAuthorsView;
        private Label label17;
        private DataGridView BookGenresView;
        private Label label16;
        private TextBox UserContacts;
    }
}