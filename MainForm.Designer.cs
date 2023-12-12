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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            dictSelect = new ToolStripMenuItem();
            выдачаToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            читателиToolStripMenuItem = new ToolStripMenuItem();
            книгаToolStripMenuItem = new ToolStripMenuItem();
            авторToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            работникиToolStripMenuItem = new ToolStripMenuItem();
            должностиToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            издательстваToolStripMenuItem = new ToolStripMenuItem();
            жанрыToolStripMenuItem = new ToolStripMenuItem();
            отчётыToolStripMenuItem = new ToolStripMenuItem();
            control_panel = new TableLayoutPanel();
            add_but = new Button();
            edit_but = new Button();
            del_but = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            window = new TabControl();
            MainWin = new TabPage();
            dataView = new DataGridView();
            AddAuthorWin = new TabPage();
            AddAuthorGroup = new GroupBox();
            AuthorError = new Label();
            label3 = new Label();
            AuthorCancelBut = new Button();
            authorName = new TextBox();
            AuthorOKBut = new Button();
            label1 = new Label();
            authorName2 = new TextBox();
            authorName3 = new TextBox();
            label2 = new Label();
            AddPublisherWin = new TabPage();
            AddPublisherGroup = new GroupBox();
            PublisherError = new Label();
            PublisherCancelBut = new Button();
            PublisherName = new TextBox();
            PublisherOKBut = new Button();
            label6 = new Label();
            PublisherAddress = new TextBox();
            label7 = new Label();
            AddGenreWin = new TabPage();
            AddGenreGroup = new GroupBox();
            GenreError = new Label();
            GenreCancelBut = new Button();
            GenreName = new TextBox();
            GenreOKBut = new Button();
            label5 = new Label();
            AddPositionWin = new TabPage();
            AddPositionGroup = new GroupBox();
            PositionError = new Label();
            PositionCancelBut = new Button();
            PositionName = new TextBox();
            PositionOKBut = new Button();
            label8 = new Label();
            AddUserWin = new TabPage();
            AddUserGroup = new GroupBox();
            UserError = new Label();
            label10 = new Label();
            UserCancelBut = new Button();
            UserName = new TextBox();
            UserOKBut = new Button();
            label11 = new Label();
            UserName2 = new TextBox();
            UserName3 = new TextBox();
            label12 = new Label();
            AddLibrarianWin = new TabPage();
            AddLibrarianGroup = new GroupBox();
            goToPositions = new Button();
            LibrarianPosition = new ComboBox();
            label15 = new Label();
            LibrarianError = new Label();
            label9 = new Label();
            LibrarianCancelBut = new Button();
            LibrarianName = new TextBox();
            LibrarianOKBut = new Button();
            label13 = new Label();
            LibrarianName2 = new TextBox();
            LibrarianName3 = new TextBox();
            label14 = new Label();
            AddBookWin = new TabPage();
            AddBookGroup = new GroupBox();
            BookGenresView = new DataGridView();
            BookGenreDelete = new Button();
            BookGenreAdd = new Button();
            label20 = new Label();
            BookAuthorDelete = new Button();
            BookAuthorAdd = new Button();
            BookAuthorsView = new DataGridView();
            label17 = new Label();
            BookDate = new DateTimePicker();
            BookPublisherAdd = new Button();
            BookPublisher = new ComboBox();
            label4 = new Label();
            BookError = new Label();
            BookCancelBut = new Button();
            BookName = new TextBox();
            BookOKBut = new Button();
            label18 = new Label();
            label19 = new Label();
            label = new Label();
            search_panel = new TableLayoutPanel();
            search_but = new Button();
            clear_search_but = new Button();
            search_bar = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            control_panel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            window.SuspendLayout();
            MainWin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            AddAuthorWin.SuspendLayout();
            AddAuthorGroup.SuspendLayout();
            AddPublisherWin.SuspendLayout();
            AddPublisherGroup.SuspendLayout();
            AddGenreWin.SuspendLayout();
            AddGenreGroup.SuspendLayout();
            AddPositionWin.SuspendLayout();
            AddPositionGroup.SuspendLayout();
            AddUserWin.SuspendLayout();
            AddUserGroup.SuspendLayout();
            AddLibrarianWin.SuspendLayout();
            AddLibrarianGroup.SuspendLayout();
            AddBookWin.SuspendLayout();
            AddBookGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookGenresView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookAuthorsView).BeginInit();
            search_panel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, dictSelect, отчётыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(896, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // dictSelect
            // 
            dictSelect.DropDownItems.AddRange(new ToolStripItem[] { выдачаToolStripMenuItem, toolStripMenuItem2, читателиToolStripMenuItem, книгаToolStripMenuItem, авторToolStripMenuItem, toolStripMenuItem1, работникиToolStripMenuItem, должностиToolStripMenuItem, toolStripMenuItem3, издательстваToolStripMenuItem, жанрыToolStripMenuItem });
            dictSelect.Name = "dictSelect";
            dictSelect.Size = new Size(117, 24);
            dictSelect.Text = "Справочники";
            // 
            // выдачаToolStripMenuItem
            // 
            выдачаToolStripMenuItem.Name = "выдачаToolStripMenuItem";
            выдачаToolStripMenuItem.Size = new Size(185, 26);
            выдачаToolStripMenuItem.Text = "Выдача";
            выдачаToolStripMenuItem.Click += выдачаToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(182, 6);
            // 
            // читателиToolStripMenuItem
            // 
            читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            читателиToolStripMenuItem.Size = new Size(185, 26);
            читателиToolStripMenuItem.Text = "Читатели";
            читателиToolStripMenuItem.Click += читателиToolStripMenuItem_Click;
            // 
            // книгаToolStripMenuItem
            // 
            книгаToolStripMenuItem.Name = "книгаToolStripMenuItem";
            книгаToolStripMenuItem.Size = new Size(185, 26);
            книгаToolStripMenuItem.Text = "Книги";
            книгаToolStripMenuItem.Click += книгаToolStripMenuItem_Click;
            // 
            // авторToolStripMenuItem
            // 
            авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            авторToolStripMenuItem.Size = new Size(185, 26);
            авторToolStripMenuItem.Text = "Авторы";
            авторToolStripMenuItem.Click += авторToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(182, 6);
            // 
            // работникиToolStripMenuItem
            // 
            работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            работникиToolStripMenuItem.Size = new Size(185, 26);
            работникиToolStripMenuItem.Text = "Работники";
            работникиToolStripMenuItem.Click += работникиToolStripMenuItem_Click;
            // 
            // должностиToolStripMenuItem
            // 
            должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            должностиToolStripMenuItem.Size = new Size(185, 26);
            должностиToolStripMenuItem.Text = "Должности";
            должностиToolStripMenuItem.Click += должностиToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(182, 6);
            // 
            // издательстваToolStripMenuItem
            // 
            издательстваToolStripMenuItem.Name = "издательстваToolStripMenuItem";
            издательстваToolStripMenuItem.Size = new Size(185, 26);
            издательстваToolStripMenuItem.Text = "Издательства";
            издательстваToolStripMenuItem.Click += издательстваToolStripMenuItem_Click;
            // 
            // жанрыToolStripMenuItem
            // 
            жанрыToolStripMenuItem.Name = "жанрыToolStripMenuItem";
            жанрыToolStripMenuItem.Size = new Size(185, 26);
            жанрыToolStripMenuItem.Text = "Жанры";
            жанрыToolStripMenuItem.Click += жанрыToolStripMenuItem_Click;
            // 
            // отчётыToolStripMenuItem
            // 
            отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            отчётыToolStripMenuItem.Size = new Size(73, 24);
            отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // control_panel
            // 
            control_panel.ColumnCount = 1;
            control_panel.ColumnStyles.Add(new ColumnStyle());
            control_panel.Controls.Add(add_but, 0, 0);
            control_panel.Controls.Add(edit_but, 0, 1);
            control_panel.Controls.Add(del_but, 0, 3);
            control_panel.Dock = DockStyle.Fill;
            control_panel.Location = new Point(750, 93);
            control_panel.Margin = new Padding(3, 13, 3, 4);
            control_panel.Name = "control_panel";
            control_panel.RowCount = 5;
            control_panel.RowStyles.Add(new RowStyle());
            control_panel.RowStyles.Add(new RowStyle());
            control_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            control_panel.RowStyles.Add(new RowStyle());
            control_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            control_panel.Size = new Size(143, 632);
            control_panel.TabIndex = 4;
            // 
            // add_but
            // 
            add_but.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            add_but.Location = new Point(3, 4);
            add_but.Margin = new Padding(3, 4, 3, 4);
            add_but.Name = "add_but";
            add_but.Size = new Size(137, 31);
            add_but.TabIndex = 0;
            add_but.Text = "Добавить";
            add_but.UseVisualStyleBackColor = true;
            add_but.Click += add_but_Click;
            // 
            // edit_but
            // 
            edit_but.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            edit_but.Location = new Point(3, 43);
            edit_but.Margin = new Padding(3, 4, 3, 4);
            edit_but.Name = "edit_but";
            edit_but.Size = new Size(137, 31);
            edit_but.TabIndex = 1;
            edit_but.Text = "Изменить";
            edit_but.UseVisualStyleBackColor = true;
            edit_but.Click += edit_but_Click;
            // 
            // del_but
            // 
            del_but.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            del_but.Location = new Point(3, 122);
            del_but.Margin = new Padding(3, 4, 3, 4);
            del_but.Name = "del_but";
            del_but.Size = new Size(137, 31);
            del_but.TabIndex = 2;
            del_but.Text = "Удалить";
            del_but.UseVisualStyleBackColor = true;
            del_but.Click += del_but_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel1.Controls.Add(control_panel, 1, 2);
            tableLayoutPanel1.Controls.Add(window, 0, 2);
            tableLayoutPanel1.Controls.Add(label, 0, 0);
            tableLayoutPanel1.Controls.Add(search_panel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 30);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(896, 707);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // window
            // 
            window.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            window.Controls.Add(MainWin);
            window.Controls.Add(AddAuthorWin);
            window.Controls.Add(AddPublisherWin);
            window.Controls.Add(AddGenreWin);
            window.Controls.Add(AddPositionWin);
            window.Controls.Add(AddUserWin);
            window.Controls.Add(AddLibrarianWin);
            window.Controls.Add(AddBookWin);
            window.Location = new Point(11, 93);
            window.Margin = new Padding(11, 13, 0, 13);
            window.Name = "window";
            window.Padding = new Point(0, 0);
            window.SelectedIndex = 0;
            window.Size = new Size(736, 623);
            window.TabIndex = 7;
            // 
            // MainWin
            // 
            MainWin.Controls.Add(dataView);
            MainWin.Location = new Point(4, 29);
            MainWin.Margin = new Padding(0);
            MainWin.Name = "MainWin";
            MainWin.Size = new Size(728, 590);
            MainWin.TabIndex = 0;
            MainWin.Text = "Main";
            MainWin.UseVisualStyleBackColor = true;
            // 
            // dataView
            // 
            dataView.AllowUserToAddRows = false;
            dataView.AllowUserToDeleteRows = false;
            dataView.AllowUserToResizeRows = false;
            dataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataView.Location = new Point(0, 0);
            dataView.Margin = new Padding(0);
            dataView.Name = "dataView";
            dataView.ReadOnly = true;
            dataView.RowHeadersWidth = 51;
            dataView.RowTemplate.Height = 25;
            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.Size = new Size(727, 585);
            dataView.TabIndex = 0;
            dataView.CellDoubleClick += dataView_CellDoubleClick;
            dataView.SelectionChanged += dataView_SelectionChanged;
            // 
            // AddAuthorWin
            // 
            AddAuthorWin.Controls.Add(AddAuthorGroup);
            AddAuthorWin.Location = new Point(4, 29);
            AddAuthorWin.Margin = new Padding(3, 4, 3, 4);
            AddAuthorWin.Name = "AddAuthorWin";
            AddAuthorWin.Padding = new Padding(3, 4, 3, 4);
            AddAuthorWin.Size = new Size(728, 590);
            AddAuthorWin.TabIndex = 1;
            AddAuthorWin.Text = "Author";
            AddAuthorWin.UseVisualStyleBackColor = true;
            // 
            // AddAuthorGroup
            // 
            AddAuthorGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddAuthorGroup.Controls.Add(AuthorError);
            AddAuthorGroup.Controls.Add(label3);
            AddAuthorGroup.Controls.Add(AuthorCancelBut);
            AddAuthorGroup.Controls.Add(authorName);
            AddAuthorGroup.Controls.Add(AuthorOKBut);
            AddAuthorGroup.Controls.Add(label1);
            AddAuthorGroup.Controls.Add(authorName2);
            AddAuthorGroup.Controls.Add(authorName3);
            AddAuthorGroup.Controls.Add(label2);
            AddAuthorGroup.Location = new Point(7, 4);
            AddAuthorGroup.Margin = new Padding(3, 4, 3, 4);
            AddAuthorGroup.Name = "AddAuthorGroup";
            AddAuthorGroup.Padding = new Padding(3, 4, 3, 4);
            AddAuthorGroup.Size = new Size(715, 293);
            AddAuthorGroup.TabIndex = 8;
            AddAuthorGroup.TabStop = false;
            AddAuthorGroup.Text = "Добавление";
            // 
            // AuthorError
            // 
            AuthorError.AutoSize = true;
            AuthorError.ForeColor = Color.Red;
            AuthorError.Location = new Point(7, 221);
            AuthorError.Name = "AuthorError";
            AuthorError.Size = new Size(0, 20);
            AuthorError.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 151);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Отчество";
            // 
            // AuthorCancelBut
            // 
            AuthorCancelBut.Location = new Point(623, 255);
            AuthorCancelBut.Margin = new Padding(3, 4, 3, 4);
            AuthorCancelBut.Name = "AuthorCancelBut";
            AuthorCancelBut.Size = new Size(86, 31);
            AuthorCancelBut.TabIndex = 7;
            AuthorCancelBut.Text = "Отмена";
            AuthorCancelBut.UseVisualStyleBackColor = true;
            AuthorCancelBut.Click += CancelBut_Click;
            // 
            // authorName
            // 
            authorName.Location = new Point(7, 57);
            authorName.Margin = new Padding(3, 4, 3, 4);
            authorName.Name = "authorName";
            authorName.Size = new Size(218, 27);
            authorName.TabIndex = 0;
            // 
            // AuthorOKBut
            // 
            AuthorOKBut.Location = new Point(530, 255);
            AuthorOKBut.Margin = new Padding(3, 4, 3, 4);
            AuthorOKBut.Name = "AuthorOKBut";
            AuthorOKBut.Size = new Size(86, 31);
            AuthorOKBut.TabIndex = 6;
            AuthorOKBut.Text = "ОК";
            AuthorOKBut.UseVisualStyleBackColor = true;
            AuthorOKBut.Click += OKBut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 33);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "Имя*";
            // 
            // authorName2
            // 
            authorName2.Location = new Point(7, 116);
            authorName2.Margin = new Padding(3, 4, 3, 4);
            authorName2.Name = "authorName2";
            authorName2.Size = new Size(218, 27);
            authorName2.TabIndex = 2;
            // 
            // authorName3
            // 
            authorName3.Location = new Point(7, 175);
            authorName3.Margin = new Padding(3, 4, 3, 4);
            authorName3.Name = "authorName3";
            authorName3.Size = new Size(218, 27);
            authorName3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 92);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Фамилия*";
            // 
            // AddPublisherWin
            // 
            AddPublisherWin.Controls.Add(AddPublisherGroup);
            AddPublisherWin.Location = new Point(4, 29);
            AddPublisherWin.Margin = new Padding(3, 4, 3, 4);
            AddPublisherWin.Name = "AddPublisherWin";
            AddPublisherWin.Size = new Size(728, 590);
            AddPublisherWin.TabIndex = 2;
            AddPublisherWin.Text = "Publisher";
            AddPublisherWin.UseVisualStyleBackColor = true;
            // 
            // AddPublisherGroup
            // 
            AddPublisherGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddPublisherGroup.Controls.Add(PublisherError);
            AddPublisherGroup.Controls.Add(PublisherCancelBut);
            AddPublisherGroup.Controls.Add(PublisherName);
            AddPublisherGroup.Controls.Add(PublisherOKBut);
            AddPublisherGroup.Controls.Add(label6);
            AddPublisherGroup.Controls.Add(PublisherAddress);
            AddPublisherGroup.Controls.Add(label7);
            AddPublisherGroup.Location = new Point(7, 4);
            AddPublisherGroup.Margin = new Padding(3, 4, 3, 4);
            AddPublisherGroup.Name = "AddPublisherGroup";
            AddPublisherGroup.Padding = new Padding(3, 4, 3, 4);
            AddPublisherGroup.Size = new Size(715, 293);
            AddPublisherGroup.TabIndex = 9;
            AddPublisherGroup.TabStop = false;
            AddPublisherGroup.Text = "Добавление";
            // 
            // PublisherError
            // 
            PublisherError.AutoSize = true;
            PublisherError.ForeColor = Color.Red;
            PublisherError.Location = new Point(7, 221);
            PublisherError.Name = "PublisherError";
            PublisherError.Size = new Size(0, 20);
            PublisherError.TabIndex = 8;
            // 
            // PublisherCancelBut
            // 
            PublisherCancelBut.Location = new Point(623, 255);
            PublisherCancelBut.Margin = new Padding(3, 4, 3, 4);
            PublisherCancelBut.Name = "PublisherCancelBut";
            PublisherCancelBut.Size = new Size(86, 31);
            PublisherCancelBut.TabIndex = 7;
            PublisherCancelBut.Text = "Отмена";
            PublisherCancelBut.UseVisualStyleBackColor = true;
            PublisherCancelBut.Click += PublisherCancelBut_Click;
            // 
            // PublisherName
            // 
            PublisherName.Location = new Point(7, 57);
            PublisherName.Margin = new Padding(3, 4, 3, 4);
            PublisherName.Name = "PublisherName";
            PublisherName.Size = new Size(266, 27);
            PublisherName.TabIndex = 0;
            // 
            // PublisherOKBut
            // 
            PublisherOKBut.Location = new Point(530, 255);
            PublisherOKBut.Margin = new Padding(3, 4, 3, 4);
            PublisherOKBut.Name = "PublisherOKBut";
            PublisherOKBut.Size = new Size(86, 31);
            PublisherOKBut.TabIndex = 6;
            PublisherOKBut.Text = "ОК";
            PublisherOKBut.UseVisualStyleBackColor = true;
            PublisherOKBut.Click += PublisherOKBut_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 33);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 1;
            label6.Text = "Наименование*";
            // 
            // PublisherAddress
            // 
            PublisherAddress.Location = new Point(7, 116);
            PublisherAddress.Margin = new Padding(3, 4, 3, 4);
            PublisherAddress.Name = "PublisherAddress";
            PublisherAddress.Size = new Size(431, 27);
            PublisherAddress.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 92);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 3;
            label7.Text = "Адрес*";
            // 
            // AddGenreWin
            // 
            AddGenreWin.Controls.Add(AddGenreGroup);
            AddGenreWin.Location = new Point(4, 29);
            AddGenreWin.Margin = new Padding(3, 4, 3, 4);
            AddGenreWin.Name = "AddGenreWin";
            AddGenreWin.Padding = new Padding(3, 4, 3, 4);
            AddGenreWin.Size = new Size(728, 590);
            AddGenreWin.TabIndex = 3;
            AddGenreWin.Text = "Genres";
            AddGenreWin.UseVisualStyleBackColor = true;
            // 
            // AddGenreGroup
            // 
            AddGenreGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddGenreGroup.Controls.Add(GenreError);
            AddGenreGroup.Controls.Add(GenreCancelBut);
            AddGenreGroup.Controls.Add(GenreName);
            AddGenreGroup.Controls.Add(GenreOKBut);
            AddGenreGroup.Controls.Add(label5);
            AddGenreGroup.Location = new Point(7, 4);
            AddGenreGroup.Margin = new Padding(3, 4, 3, 4);
            AddGenreGroup.Name = "AddGenreGroup";
            AddGenreGroup.Padding = new Padding(3, 4, 3, 4);
            AddGenreGroup.Size = new Size(715, 293);
            AddGenreGroup.TabIndex = 10;
            AddGenreGroup.TabStop = false;
            AddGenreGroup.Text = "Добавление";
            // 
            // GenreError
            // 
            GenreError.AutoSize = true;
            GenreError.ForeColor = Color.Red;
            GenreError.Location = new Point(7, 221);
            GenreError.Name = "GenreError";
            GenreError.Size = new Size(0, 20);
            GenreError.TabIndex = 8;
            // 
            // GenreCancelBut
            // 
            GenreCancelBut.Location = new Point(623, 255);
            GenreCancelBut.Margin = new Padding(3, 4, 3, 4);
            GenreCancelBut.Name = "GenreCancelBut";
            GenreCancelBut.Size = new Size(86, 31);
            GenreCancelBut.TabIndex = 7;
            GenreCancelBut.Text = "Отмена";
            GenreCancelBut.UseVisualStyleBackColor = true;
            GenreCancelBut.Click += GenreCancelBut_Click;
            // 
            // GenreName
            // 
            GenreName.Location = new Point(7, 57);
            GenreName.Margin = new Padding(3, 4, 3, 4);
            GenreName.Name = "GenreName";
            GenreName.Size = new Size(175, 27);
            GenreName.TabIndex = 0;
            // 
            // GenreOKBut
            // 
            GenreOKBut.Location = new Point(530, 255);
            GenreOKBut.Margin = new Padding(3, 4, 3, 4);
            GenreOKBut.Name = "GenreOKBut";
            GenreOKBut.Size = new Size(86, 31);
            GenreOKBut.TabIndex = 6;
            GenreOKBut.Text = "ОК";
            GenreOKBut.UseVisualStyleBackColor = true;
            GenreOKBut.Click += GenreOKBut_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 33);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 1;
            label5.Text = "Наименование*";
            // 
            // AddPositionWin
            // 
            AddPositionWin.Controls.Add(AddPositionGroup);
            AddPositionWin.Location = new Point(4, 29);
            AddPositionWin.Margin = new Padding(3, 4, 3, 4);
            AddPositionWin.Name = "AddPositionWin";
            AddPositionWin.Padding = new Padding(3, 4, 3, 4);
            AddPositionWin.Size = new Size(728, 590);
            AddPositionWin.TabIndex = 4;
            AddPositionWin.Text = "Positions";
            AddPositionWin.UseVisualStyleBackColor = true;
            // 
            // AddPositionGroup
            // 
            AddPositionGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddPositionGroup.Controls.Add(PositionError);
            AddPositionGroup.Controls.Add(PositionCancelBut);
            AddPositionGroup.Controls.Add(PositionName);
            AddPositionGroup.Controls.Add(PositionOKBut);
            AddPositionGroup.Controls.Add(label8);
            AddPositionGroup.Location = new Point(7, 4);
            AddPositionGroup.Margin = new Padding(3, 4, 3, 4);
            AddPositionGroup.Name = "AddPositionGroup";
            AddPositionGroup.Padding = new Padding(3, 4, 3, 4);
            AddPositionGroup.Size = new Size(715, 293);
            AddPositionGroup.TabIndex = 11;
            AddPositionGroup.TabStop = false;
            AddPositionGroup.Text = "Добавление";
            // 
            // PositionError
            // 
            PositionError.AutoSize = true;
            PositionError.ForeColor = Color.Red;
            PositionError.Location = new Point(7, 221);
            PositionError.Name = "PositionError";
            PositionError.Size = new Size(0, 20);
            PositionError.TabIndex = 8;
            // 
            // PositionCancelBut
            // 
            PositionCancelBut.Location = new Point(623, 255);
            PositionCancelBut.Margin = new Padding(3, 4, 3, 4);
            PositionCancelBut.Name = "PositionCancelBut";
            PositionCancelBut.Size = new Size(86, 31);
            PositionCancelBut.TabIndex = 7;
            PositionCancelBut.Text = "Отмена";
            PositionCancelBut.UseVisualStyleBackColor = true;
            PositionCancelBut.Click += PositionCancelBut_Click;
            // 
            // PositionName
            // 
            PositionName.Location = new Point(7, 57);
            PositionName.Margin = new Padding(3, 4, 3, 4);
            PositionName.Name = "PositionName";
            PositionName.Size = new Size(266, 27);
            PositionName.TabIndex = 0;
            // 
            // PositionOKBut
            // 
            PositionOKBut.Location = new Point(530, 255);
            PositionOKBut.Margin = new Padding(3, 4, 3, 4);
            PositionOKBut.Name = "PositionOKBut";
            PositionOKBut.Size = new Size(86, 31);
            PositionOKBut.TabIndex = 6;
            PositionOKBut.Text = "ОК";
            PositionOKBut.UseVisualStyleBackColor = true;
            PositionOKBut.Click += PositionOKBut_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 33);
            label8.Name = "label8";
            label8.Size = new Size(122, 20);
            label8.TabIndex = 1;
            label8.Text = "Наименование*";
            // 
            // AddUserWin
            // 
            AddUserWin.Controls.Add(AddUserGroup);
            AddUserWin.Location = new Point(4, 29);
            AddUserWin.Margin = new Padding(3, 4, 3, 4);
            AddUserWin.Name = "AddUserWin";
            AddUserWin.Padding = new Padding(3, 4, 3, 4);
            AddUserWin.Size = new Size(728, 590);
            AddUserWin.TabIndex = 5;
            AddUserWin.Text = "Users";
            AddUserWin.UseVisualStyleBackColor = true;
            // 
            // AddUserGroup
            // 
            AddUserGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddUserGroup.Controls.Add(UserError);
            AddUserGroup.Controls.Add(label10);
            AddUserGroup.Controls.Add(UserCancelBut);
            AddUserGroup.Controls.Add(UserName);
            AddUserGroup.Controls.Add(UserOKBut);
            AddUserGroup.Controls.Add(label11);
            AddUserGroup.Controls.Add(UserName2);
            AddUserGroup.Controls.Add(UserName3);
            AddUserGroup.Controls.Add(label12);
            AddUserGroup.Location = new Point(7, 4);
            AddUserGroup.Margin = new Padding(3, 4, 3, 4);
            AddUserGroup.Name = "AddUserGroup";
            AddUserGroup.Padding = new Padding(3, 4, 3, 4);
            AddUserGroup.Size = new Size(715, 293);
            AddUserGroup.TabIndex = 9;
            AddUserGroup.TabStop = false;
            AddUserGroup.Text = "Добавление";
            // 
            // UserError
            // 
            UserError.AutoSize = true;
            UserError.ForeColor = Color.Red;
            UserError.Location = new Point(7, 221);
            UserError.Name = "UserError";
            UserError.Size = new Size(41, 20);
            UserError.TabIndex = 8;
            UserError.Text = "error";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 151);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 5;
            label10.Text = "Отчество";
            // 
            // UserCancelBut
            // 
            UserCancelBut.Location = new Point(623, 255);
            UserCancelBut.Margin = new Padding(3, 4, 3, 4);
            UserCancelBut.Name = "UserCancelBut";
            UserCancelBut.Size = new Size(86, 31);
            UserCancelBut.TabIndex = 7;
            UserCancelBut.Text = "Отмена";
            UserCancelBut.UseVisualStyleBackColor = true;
            UserCancelBut.Click += UserCancelBut_Click;
            // 
            // UserName
            // 
            UserName.Location = new Point(7, 57);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Name = "UserName";
            UserName.Size = new Size(218, 27);
            UserName.TabIndex = 0;
            // 
            // UserOKBut
            // 
            UserOKBut.Location = new Point(530, 255);
            UserOKBut.Margin = new Padding(3, 4, 3, 4);
            UserOKBut.Name = "UserOKBut";
            UserOKBut.Size = new Size(86, 31);
            UserOKBut.TabIndex = 6;
            UserOKBut.Text = "ОК";
            UserOKBut.UseVisualStyleBackColor = true;
            UserOKBut.Click += UserOKBut_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 33);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 1;
            label11.Text = "Имя*";
            // 
            // UserName2
            // 
            UserName2.Location = new Point(7, 116);
            UserName2.Margin = new Padding(3, 4, 3, 4);
            UserName2.Name = "UserName2";
            UserName2.Size = new Size(218, 27);
            UserName2.TabIndex = 2;
            // 
            // UserName3
            // 
            UserName3.Location = new Point(7, 175);
            UserName3.Margin = new Padding(3, 4, 3, 4);
            UserName3.Name = "UserName3";
            UserName3.Size = new Size(218, 27);
            UserName3.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 92);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 3;
            label12.Text = "Фамилия*";
            // 
            // AddLibrarianWin
            // 
            AddLibrarianWin.Controls.Add(AddLibrarianGroup);
            AddLibrarianWin.Location = new Point(4, 29);
            AddLibrarianWin.Margin = new Padding(3, 4, 3, 4);
            AddLibrarianWin.Name = "AddLibrarianWin";
            AddLibrarianWin.Padding = new Padding(3, 4, 3, 4);
            AddLibrarianWin.Size = new Size(728, 590);
            AddLibrarianWin.TabIndex = 6;
            AddLibrarianWin.Text = "Librarians";
            AddLibrarianWin.UseVisualStyleBackColor = true;
            // 
            // AddLibrarianGroup
            // 
            AddLibrarianGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddLibrarianGroup.Controls.Add(goToPositions);
            AddLibrarianGroup.Controls.Add(LibrarianPosition);
            AddLibrarianGroup.Controls.Add(label15);
            AddLibrarianGroup.Controls.Add(LibrarianError);
            AddLibrarianGroup.Controls.Add(label9);
            AddLibrarianGroup.Controls.Add(LibrarianCancelBut);
            AddLibrarianGroup.Controls.Add(LibrarianName);
            AddLibrarianGroup.Controls.Add(LibrarianOKBut);
            AddLibrarianGroup.Controls.Add(label13);
            AddLibrarianGroup.Controls.Add(LibrarianName2);
            AddLibrarianGroup.Controls.Add(LibrarianName3);
            AddLibrarianGroup.Controls.Add(label14);
            AddLibrarianGroup.Location = new Point(7, 4);
            AddLibrarianGroup.Margin = new Padding(3, 4, 3, 4);
            AddLibrarianGroup.Name = "AddLibrarianGroup";
            AddLibrarianGroup.Padding = new Padding(3, 4, 3, 4);
            AddLibrarianGroup.Size = new Size(715, 379);
            AddLibrarianGroup.TabIndex = 10;
            AddLibrarianGroup.TabStop = false;
            AddLibrarianGroup.Text = "Добавление";
            // 
            // goToPositions
            // 
            goToPositions.Location = new Point(278, 233);
            goToPositions.Margin = new Padding(3, 4, 3, 4);
            goToPositions.Name = "goToPositions";
            goToPositions.Size = new Size(27, 31);
            goToPositions.TabIndex = 12;
            goToPositions.Text = "...";
            goToPositions.UseVisualStyleBackColor = true;
            goToPositions.Click += goToPositions_Click;
            // 
            // LibrarianPosition
            // 
            LibrarianPosition.FormattingEnabled = true;
            LibrarianPosition.Location = new Point(7, 233);
            LibrarianPosition.Margin = new Padding(3, 4, 3, 4);
            LibrarianPosition.Name = "LibrarianPosition";
            LibrarianPosition.Size = new Size(263, 28);
            LibrarianPosition.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 209);
            label15.Name = "label15";
            label15.Size = new Size(86, 20);
            label15.TabIndex = 10;
            label15.Text = "Должность";
            // 
            // LibrarianError
            // 
            LibrarianError.AutoSize = true;
            LibrarianError.ForeColor = Color.Red;
            LibrarianError.Location = new Point(7, 313);
            LibrarianError.Name = "LibrarianError";
            LibrarianError.Size = new Size(41, 20);
            LibrarianError.TabIndex = 8;
            LibrarianError.Text = "error";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 151);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 5;
            label9.Text = "Отчество";
            // 
            // LibrarianCancelBut
            // 
            LibrarianCancelBut.Location = new Point(623, 340);
            LibrarianCancelBut.Margin = new Padding(3, 4, 3, 4);
            LibrarianCancelBut.Name = "LibrarianCancelBut";
            LibrarianCancelBut.Size = new Size(86, 31);
            LibrarianCancelBut.TabIndex = 7;
            LibrarianCancelBut.Text = "Отмена";
            LibrarianCancelBut.UseVisualStyleBackColor = true;
            LibrarianCancelBut.Click += LibrarianCancelBut_Click;
            // 
            // LibrarianName
            // 
            LibrarianName.Location = new Point(7, 57);
            LibrarianName.Margin = new Padding(3, 4, 3, 4);
            LibrarianName.Name = "LibrarianName";
            LibrarianName.Size = new Size(218, 27);
            LibrarianName.TabIndex = 0;
            // 
            // LibrarianOKBut
            // 
            LibrarianOKBut.Location = new Point(530, 340);
            LibrarianOKBut.Margin = new Padding(3, 4, 3, 4);
            LibrarianOKBut.Name = "LibrarianOKBut";
            LibrarianOKBut.Size = new Size(86, 31);
            LibrarianOKBut.TabIndex = 6;
            LibrarianOKBut.Text = "ОК";
            LibrarianOKBut.UseVisualStyleBackColor = true;
            LibrarianOKBut.Click += LibrarianOKBut_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 33);
            label13.Name = "label13";
            label13.Size = new Size(45, 20);
            label13.TabIndex = 1;
            label13.Text = "Имя*";
            // 
            // LibrarianName2
            // 
            LibrarianName2.Location = new Point(7, 116);
            LibrarianName2.Margin = new Padding(3, 4, 3, 4);
            LibrarianName2.Name = "LibrarianName2";
            LibrarianName2.Size = new Size(218, 27);
            LibrarianName2.TabIndex = 2;
            // 
            // LibrarianName3
            // 
            LibrarianName3.Location = new Point(7, 175);
            LibrarianName3.Margin = new Padding(3, 4, 3, 4);
            LibrarianName3.Name = "LibrarianName3";
            LibrarianName3.Size = new Size(218, 27);
            LibrarianName3.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 92);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 3;
            label14.Text = "Фамилия*";
            // 
            // AddBookWin
            // 
            AddBookWin.Controls.Add(AddBookGroup);
            AddBookWin.Location = new Point(4, 29);
            AddBookWin.Margin = new Padding(3, 4, 3, 4);
            AddBookWin.Name = "AddBookWin";
            AddBookWin.Size = new Size(728, 590);
            AddBookWin.TabIndex = 7;
            AddBookWin.Text = "Books";
            AddBookWin.UseVisualStyleBackColor = true;
            // 
            // AddBookGroup
            // 
            AddBookGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddBookGroup.Controls.Add(BookGenresView);
            AddBookGroup.Controls.Add(BookGenreDelete);
            AddBookGroup.Controls.Add(BookGenreAdd);
            AddBookGroup.Controls.Add(label20);
            AddBookGroup.Controls.Add(BookAuthorDelete);
            AddBookGroup.Controls.Add(BookAuthorAdd);
            AddBookGroup.Controls.Add(BookAuthorsView);
            AddBookGroup.Controls.Add(label17);
            AddBookGroup.Controls.Add(BookDate);
            AddBookGroup.Controls.Add(BookPublisherAdd);
            AddBookGroup.Controls.Add(BookPublisher);
            AddBookGroup.Controls.Add(label4);
            AddBookGroup.Controls.Add(BookError);
            AddBookGroup.Controls.Add(BookCancelBut);
            AddBookGroup.Controls.Add(BookName);
            AddBookGroup.Controls.Add(BookOKBut);
            AddBookGroup.Controls.Add(label18);
            AddBookGroup.Controls.Add(label19);
            AddBookGroup.Location = new Point(7, 4);
            AddBookGroup.Margin = new Padding(3, 4, 3, 4);
            AddBookGroup.Name = "AddBookGroup";
            AddBookGroup.Padding = new Padding(3, 4, 3, 4);
            AddBookGroup.Size = new Size(715, 577);
            AddBookGroup.TabIndex = 11;
            AddBookGroup.TabStop = false;
            AddBookGroup.Text = "Добавление";
            // 
            // BookGenresView
            // 
            BookGenresView.AllowUserToAddRows = false;
            BookGenresView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookGenresView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookGenresView.Location = new Point(7, 363);
            BookGenresView.Margin = new Padding(3, 4, 3, 4);
            BookGenresView.Name = "BookGenresView";
            BookGenresView.ReadOnly = true;
            BookGenresView.RowHeadersWidth = 51;
            BookGenresView.RowTemplate.Height = 25;
            BookGenresView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookGenresView.Size = new Size(221, 101);
            BookGenresView.TabIndex = 22;
            // 
            // BookGenreDelete
            // 
            BookGenreDelete.Location = new Point(234, 413);
            BookGenreDelete.Margin = new Padding(3, 4, 3, 4);
            BookGenreDelete.Name = "BookGenreDelete";
            BookGenreDelete.Size = new Size(37, 43);
            BookGenreDelete.TabIndex = 21;
            BookGenreDelete.Text = "-";
            BookGenreDelete.UseVisualStyleBackColor = true;
            BookGenreDelete.Click += BookGenreDelete_Click;
            // 
            // BookGenreAdd
            // 
            BookGenreAdd.Location = new Point(234, 363);
            BookGenreAdd.Margin = new Padding(3, 4, 3, 4);
            BookGenreAdd.Name = "BookGenreAdd";
            BookGenreAdd.Size = new Size(37, 43);
            BookGenreAdd.TabIndex = 20;
            BookGenreAdd.Text = "+";
            BookGenreAdd.UseVisualStyleBackColor = true;
            BookGenreAdd.Click += BookGenreAdd_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(7, 339);
            label20.Name = "label20";
            label20.Size = new Size(59, 20);
            label20.TabIndex = 18;
            label20.Text = "Жанры";
            // 
            // BookAuthorDelete
            // 
            BookAuthorDelete.Location = new Point(450, 284);
            BookAuthorDelete.Margin = new Padding(3, 4, 3, 4);
            BookAuthorDelete.Name = "BookAuthorDelete";
            BookAuthorDelete.Size = new Size(37, 43);
            BookAuthorDelete.TabIndex = 17;
            BookAuthorDelete.Text = "-";
            BookAuthorDelete.UseVisualStyleBackColor = true;
            BookAuthorDelete.Click += BookAuthorDelete_Click;
            // 
            // BookAuthorAdd
            // 
            BookAuthorAdd.Location = new Point(450, 233);
            BookAuthorAdd.Margin = new Padding(3, 4, 3, 4);
            BookAuthorAdd.Name = "BookAuthorAdd";
            BookAuthorAdd.Size = new Size(37, 43);
            BookAuthorAdd.TabIndex = 16;
            BookAuthorAdd.Text = "+";
            BookAuthorAdd.UseVisualStyleBackColor = true;
            BookAuthorAdd.Click += BookAuthorAdd_Click;
            // 
            // BookAuthorsView
            // 
            BookAuthorsView.AllowUserToAddRows = false;
            BookAuthorsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookAuthorsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookAuthorsView.Location = new Point(7, 233);
            BookAuthorsView.Margin = new Padding(3, 4, 3, 4);
            BookAuthorsView.Name = "BookAuthorsView";
            BookAuthorsView.ReadOnly = true;
            BookAuthorsView.RowHeadersWidth = 51;
            BookAuthorsView.RowTemplate.Height = 25;
            BookAuthorsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookAuthorsView.Size = new Size(437, 101);
            BookAuthorsView.TabIndex = 15;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(7, 209);
            label17.Name = "label17";
            label17.Size = new Size(62, 20);
            label17.TabIndex = 14;
            label17.Text = "Авторы";
            // 
            // BookDate
            // 
            BookDate.Location = new Point(7, 116);
            BookDate.Margin = new Padding(3, 4, 3, 4);
            BookDate.Name = "BookDate";
            BookDate.Size = new Size(218, 27);
            BookDate.TabIndex = 13;
            // 
            // BookPublisherAdd
            // 
            BookPublisherAdd.Location = new Point(278, 175);
            BookPublisherAdd.Margin = new Padding(3, 4, 3, 4);
            BookPublisherAdd.Name = "BookPublisherAdd";
            BookPublisherAdd.Size = new Size(27, 31);
            BookPublisherAdd.TabIndex = 12;
            BookPublisherAdd.Text = "...";
            BookPublisherAdd.UseVisualStyleBackColor = true;
            BookPublisherAdd.Click += BookPublisherAdd_Click;
            // 
            // BookPublisher
            // 
            BookPublisher.FormattingEnabled = true;
            BookPublisher.Location = new Point(7, 175);
            BookPublisher.Margin = new Padding(3, 4, 3, 4);
            BookPublisher.Name = "BookPublisher";
            BookPublisher.Size = new Size(263, 28);
            BookPublisher.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 151);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 10;
            label4.Text = "Издательство";
            // 
            // BookError
            // 
            BookError.AutoSize = true;
            BookError.ForeColor = Color.Red;
            BookError.Location = new Point(7, 544);
            BookError.Name = "BookError";
            BookError.Size = new Size(41, 20);
            BookError.TabIndex = 8;
            BookError.Text = "error";
            // 
            // BookCancelBut
            // 
            BookCancelBut.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BookCancelBut.Location = new Point(623, 539);
            BookCancelBut.Margin = new Padding(3, 4, 3, 4);
            BookCancelBut.Name = "BookCancelBut";
            BookCancelBut.Size = new Size(86, 31);
            BookCancelBut.TabIndex = 7;
            BookCancelBut.Text = "Отмена";
            BookCancelBut.UseVisualStyleBackColor = true;
            BookCancelBut.Click += BookCancelBut_Click;
            // 
            // BookName
            // 
            BookName.Location = new Point(7, 57);
            BookName.Margin = new Padding(3, 4, 3, 4);
            BookName.Name = "BookName";
            BookName.Size = new Size(338, 27);
            BookName.TabIndex = 0;
            // 
            // BookOKBut
            // 
            BookOKBut.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BookOKBut.Location = new Point(530, 539);
            BookOKBut.Margin = new Padding(3, 4, 3, 4);
            BookOKBut.Name = "BookOKBut";
            BookOKBut.Size = new Size(86, 31);
            BookOKBut.TabIndex = 6;
            BookOKBut.Text = "ОК";
            BookOKBut.UseVisualStyleBackColor = true;
            BookOKBut.Click += BookOKBut_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(7, 33);
            label18.Name = "label18";
            label18.Size = new Size(83, 20);
            label18.TabIndex = 1;
            label18.Text = "Название*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(7, 92);
            label19.Name = "label19";
            label19.Size = new Size(129, 20);
            label19.TabIndex = 3;
            label19.Text = "Дата публикации";
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.Location = new Point(23, 10);
            label.Margin = new Padding(23, 0, 3, 0);
            label.Name = "label";
            label.Size = new Size(134, 20);
            label.TabIndex = 8;
            label.Text = "Имя справочника";
            // 
            // search_panel
            // 
            search_panel.Anchor = AnchorStyles.Right;
            search_panel.ColumnCount = 4;
            search_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 343F));
            search_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            search_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            search_panel.ColumnStyles.Add(new ColumnStyle());
            search_panel.Controls.Add(search_but, 1, 0);
            search_panel.Controls.Add(clear_search_but, 2, 0);
            search_panel.Controls.Add(search_bar, 0, 0);
            search_panel.Location = new Point(218, 40);
            search_panel.Margin = new Padding(0);
            search_panel.Name = "search_panel";
            search_panel.RowCount = 1;
            search_panel.RowStyles.Add(new RowStyle());
            search_panel.Size = new Size(529, 40);
            search_panel.TabIndex = 6;
            // 
            // search_but
            // 
            search_but.Anchor = AnchorStyles.Left;
            search_but.Location = new Point(346, 4);
            search_but.Margin = new Padding(3, 4, 3, 4);
            search_but.Name = "search_but";
            search_but.Size = new Size(85, 31);
            search_but.TabIndex = 1;
            search_but.Text = "Найти";
            search_but.UseVisualStyleBackColor = true;
            // 
            // clear_search_but
            // 
            clear_search_but.Anchor = AnchorStyles.Left;
            clear_search_but.Location = new Point(437, 4);
            clear_search_but.Margin = new Padding(3, 4, 3, 4);
            clear_search_but.Name = "clear_search_but";
            clear_search_but.Size = new Size(85, 31);
            clear_search_but.TabIndex = 2;
            clear_search_but.Text = "Очистить";
            clear_search_but.UseVisualStyleBackColor = true;
            // 
            // search_bar
            // 
            search_bar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            search_bar.Location = new Point(3, 6);
            search_bar.Margin = new Padding(3, 4, 3, 4);
            search_bar.Name = "search_bar";
            search_bar.Size = new Size(337, 27);
            search_bar.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // main_form
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 737);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1369, 784);
            MinimumSize = new Size(912, 784);
            Name = "main_form";
            Text = "библиотека";
            Activated += main_form_Activated;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            control_panel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            window.ResumeLayout(false);
            MainWin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            AddAuthorWin.ResumeLayout(false);
            AddAuthorGroup.ResumeLayout(false);
            AddAuthorGroup.PerformLayout();
            AddPublisherWin.ResumeLayout(false);
            AddPublisherGroup.ResumeLayout(false);
            AddPublisherGroup.PerformLayout();
            AddGenreWin.ResumeLayout(false);
            AddGenreGroup.ResumeLayout(false);
            AddGenreGroup.PerformLayout();
            AddPositionWin.ResumeLayout(false);
            AddPositionGroup.ResumeLayout(false);
            AddPositionGroup.PerformLayout();
            AddUserWin.ResumeLayout(false);
            AddUserGroup.ResumeLayout(false);
            AddUserGroup.PerformLayout();
            AddLibrarianWin.ResumeLayout(false);
            AddLibrarianGroup.ResumeLayout(false);
            AddLibrarianGroup.PerformLayout();
            AddBookWin.ResumeLayout(false);
            AddBookGroup.ResumeLayout(false);
            AddBookGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookGenresView).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookAuthorsView).EndInit();
            search_panel.ResumeLayout(false);
            search_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}