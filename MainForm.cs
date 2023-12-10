

using Library.Model;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;

namespace Library
{
    public partial class main_form : Form
    {
        string formLabel = "Õ‡ËÏÂÌÓ‚‡ÌËÂ ÙÓÏ˚";
        WinEnum? source;
        bool fromAddForm;
        List<int> rowSource = new List<int>();
        public List<string[]> returnRows;

        public main_form(string formLabelIn = "¬˚‰‡˜‡", WinEnum? sourceIn = WinEnum.Entries, bool fromAddForm = false)
        {
            
            InitializeComponent();

            formLabel = formLabelIn;
            source= sourceIn;
            this.fromAddForm = fromAddForm;

            formLabel = formLabelIn;
            label.Text = formLabel;

            SetView(source);
        }

        public void SetView(WinEnum? source)
        {
            switch (source)
            {
                case WinEnum.Authors:
                    displayAuthors();
                    break;
                case WinEnum.Publishers:
                    displayPublishers();
                    break;
                case WinEnum.Genres:
                    displayGenres();
                    break;
                case WinEnum.Books:
                    displayBooks();
                    break;
                case WinEnum.Users:
                    displayUsers();
                    break;
                case WinEnum.Positions:
                    displayPositions();
                    break;
                case WinEnum.Librarians:
                    displayLibrarians();
                    break;
                case WinEnum.Entries:
                    break;
            }
            try
            {
                rowSource = new List<int>
                {
                    int.Parse(dataView.SelectedRows[0].Cells[0].Value.ToString() ?? "0")
                };
            }
            catch { }
        }

        public void displayAuthors()
        {
            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                var items = db.Author.ToList();
                dataView.DataSource = items;
                //dataView.Columns[0].Visible = false;
                dataView.Columns[1].HeaderText = "‘‡ÏËÎËˇ";
                dataView.Columns[2].HeaderText = "»Ïˇ";
                dataView.Columns[3].HeaderText = "ŒÚ˜ÂÒÚ‚Ó";
            }
        }

        public void displayPublishers()
        {
            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                var items = db.Publisher.ToList();
                dataView.DataSource = items;
                //dataView.Columns[0].Visible = false;
                dataView.Columns[1].HeaderText = "Õ‡ËÏÂÌÓ‚‡ÌËÂ";
                dataView.Columns[2].HeaderText = "¿‰ÂÒ";
            }
        }

        public void displayGenres()
        {
            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                var items = db.Genre.ToList();
                dataView.DataSource = items;
                //dataView.Columns[0].Visible = false;
                dataView.Columns[1].HeaderText = "Õ‡ËÏÂÌÓ‚‡ÌËÂ";
            }
        }

        public void displayPositions()
        {
            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                var items = db.Position.ToList();
                dataView.DataSource = items;
                //dataView.Columns[0].Visible = false;
                dataView.Columns[1].HeaderText = "Õ‡ËÏÂÌÓ‚‡ÌËÂ";
            }
        }

        public void displayUsers()
        {
            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                var items = db.User.ToList();
                dataView.DataSource = items;
                //dataView.Columns[0].Visible = false;
                dataView.Columns[1].HeaderText = "‘‡ÏËÎËˇ";
                dataView.Columns[2].HeaderText = "»Ïˇ";
                dataView.Columns[3].HeaderText = "ŒÚ˜ÂÒÚ‚Ó";
            }
        }

        public void displayLibrarians()
        {
            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                try
                {
                    var items = db.Worker.Select(p => new
                    {
                        Id = p.Id,
                        Position = p.Position.Name,
                        Name1 = p.Name1,
                        Name2 = p.Name2,
                        Name3 = p.Name3
                    }).ToList();
                    dataView.DataSource = items;
                    //dataView.Columns[0].Visible = false;
                    dataView.Columns[1].HeaderText = "ƒÓÎÊÌÓÒÚ¸";
                    dataView.Columns[2].HeaderText = "‘‡ÏËÎËˇ";
                    dataView.Columns[3].HeaderText = "»Ïˇ";
                    dataView.Columns[4].HeaderText = "ŒÚ˜ÂÒÚ‚Ó";
                }
                catch { }
                
            }
        }

        public void displayBooks()
        {
            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                try
                {
                    var items = db.Book.Select(p => new
                    {
                        Id = p.Id,
                        Name = p.Name,
                        PublicationDate = p.PublicationDate,
                        Publisher = p.Publisher,
                        Authors = p.Authors,
                        Genres = p.Genres
                    }).ToList();
                    dataView.DataSource = items;
                    //dataView.Columns[0].Visible = false;
                    dataView.Columns[1].HeaderText = "Õ‡Á‚‡ÌËÂ";
                    dataView.Columns[2].HeaderText = "ƒ‡Ú‡ ÔÛ·ÎËÍ‡ˆËË";
                    dataView.Columns[3].HeaderText = "»Á‰‡ÚÂÎ¸ÒÚ‚Ó";
                    dataView.Columns[4].HeaderText = "¿‚ÚÓ˚";
                    dataView.Columns[5].HeaderText = "∆‡Ì˚";
                }
                catch { }

            }
        }

        private void add_but_Click(object sender, EventArgs e)
        {
            rowSource = new List<int>
                {
                    -1
                };
            switch (source)
            {
                case WinEnum.Authors:
                    window.SelectTab("AddAuthorWin");
                    break;
                case WinEnum.Publishers:
                    window.SelectTab("AddPublisherWin");
                    break;
                case WinEnum.Genres:
                    window.SelectTab("AddGenreWin");
                    break;
                case WinEnum.Books:
                    window.SelectTab("AddBookWin");
                    break;
                case WinEnum.Users:
                    window.SelectTab("AddUserWin");
                    break;
                case WinEnum.Positions:
                    window.SelectTab("AddPositionWin");
                    break;
                case WinEnum.Librarians:
                    window.SelectTab("AddLibrarianWin");
                    break;
                case WinEnum.Entries:
                    break;
            }
            control_panel.Enabled = !control_panel.Enabled;
            search_panel.Enabled = !search_panel.Enabled;

        }

        private static void ClearInputs(Control src)
        {
            foreach (Control item in src.Controls)
            {
                if (item is TextBox)
                {
                    item.ResetText();
                }
                if (item is DataGridView)
                {
                    var item2 = item as DataGridView;
                    item2.DataSource = null;
                }
                //if (item is ComboBox)
                //{
                //    item.ResetText();
                //}
            }
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            ClearInputs(AddAuthorGroup);
            BackToView();
        }

        private void OKBut_Click(object sender, EventArgs e)
        {
            authorName.Text = Functions.PrepareName(authorName.Text);
            authorName2.Text = Functions.PrepareName(authorName2.Text);
            authorName3.Text = Functions.PrepareName(authorName3.Text);

            string? error = Functions.CheckNewAuthor(authorName.Text, authorName2.Text, authorName3.Text);
            AuthorError.Text =  error ?? "";
            if (error != null) return;

            window.Enabled = !window.Enabled;

            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                Model.Author? newInst = db.Author.Find(rowSource[0]);
                if (newInst != null)
                {
                    newInst.Name1 = authorName.Text;
                    newInst.Name2 = authorName2.Text;
                    newInst.Name3 = authorName3.Text;
                }
                else
                {
                    newInst = new Model.Author { Name1 = authorName.Text, Name2 = authorName2.Text, Name3 = authorName3.Text };
                    db.Author.Add(newInst);
                }
                db.SaveChanges();
                SetView(source);
            }
            CancelBut_Click(sender, e);

            window.Enabled = !window.Enabled;
        }

        private void main_form_Activated(object sender, EventArgs e)
        {
            //if (window.SelectedTab == window.TabPages[6])
            //{
                using (Model.ApplicationContext db = new Model.ApplicationContext())
                {
                    var items = db.Position.Select(p =>
                    p.Name.ToString()).ToList();
                    LibrarianPosition.DataSource = items;

                    var items2 = db.Position.Select(p =>
                    p.Name.ToString()).ToList();
                    BookPublisher.DataSource = items2;
                }
            //}
        }

        private void dataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fromAddForm)
            {
                this.returnRows = new List<string[]>();
                switch (source)
                {
                    case WinEnum.Books:
                        break;
                    case WinEnum.Librarians:
                        break;
                    case WinEnum.Entries:
                        break;
                }
                //main_form owner = (main_form)this.Owner;
                //owner.LibrarianPosition.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
                foreach (DataGridViewRow row in dataView.SelectedRows)
                {
                    string[] r = new string[2];
                    r[0] = row.Cells[0].Value.ToString();
                    r[1] = row.Cells[1].Value.ToString();
                    this.returnRows.Add(r);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ‚˚‰‡˜‡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.OpenNewWin(sender, WinEnum.Entries);
        }

        private void ˜ËÚ‡ÚÂÎËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.OpenNewWin(sender, WinEnum.Users);
        }

        private void ‡‚ÚÓToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.OpenNewWin(sender, WinEnum.Authors);
        }

        private void ÍÌË„‡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.OpenNewWin(sender, WinEnum.Books);
        }

        private void ‡·ÓÚÌËÍËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.OpenNewWin(sender, WinEnum.Librarians);
        }

        private void ‰ÓÎÊÌÓÒÚËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.OpenNewWin(sender, WinEnum.Positions);
        }

        private void ËÁ‰‡ÚÂÎ¸ÒÚ‚‡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.OpenNewWin(sender, WinEnum.Publishers);
        }

        private void Ê‡Ì˚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.OpenNewWin(sender, WinEnum.Genres);
        }

        private void PublisherOKBut_Click(object sender, EventArgs e)
        {

            string? error = Functions.CheckNewPublisher(PublisherName.Text, PublisherAddress.Text);
            PublisherError.Text = error ?? "";
            if (error != null) return;

            window.Enabled = !window.Enabled;

            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                Model.Publisher? newInst = db.Publisher.Find(rowSource[0]);
                if (newInst != null)
                {
                    newInst.Name = PublisherName.Text;
                    newInst.Address = PublisherAddress.Text;
                }
                else
                {
                    newInst = new Model.Publisher { Name = PublisherName.Text, Address = PublisherAddress.Text };
                    db.Publisher.Add(newInst);
                }
                db.SaveChanges();
                SetView(source);
            }
            PublisherCancelBut_Click(sender, e);

            window.Enabled = !window.Enabled;
        }

        private void PublisherCancelBut_Click(object sender, EventArgs e)
        {
            ClearInputs(AddPublisherGroup);
            BackToView();
        }

        public void BackToView()
        {
            window.SelectTab("MainWin");
            control_panel.Enabled = true;
            search_panel.Enabled = true;
        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            rowSource = new List<int>
                {
                    Int32.Parse(dataView.SelectedRows[0].Cells[0].Value.ToString() ?? "0")
                };
            switch (source)
            {
                case WinEnum.Authors:
                    authorName.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
                    authorName2.Text = dataView.SelectedRows[0].Cells[2].Value.ToString();
                    authorName3.Text = dataView.SelectedRows[0].Cells[3].Value.ToString();
                    window.SelectTab("AddAuthorWin");
                    break;
                case WinEnum.Publishers:
                    PublisherName.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
                    PublisherAddress.Text = dataView.SelectedRows[0].Cells[2].Value.ToString();
                    window.SelectTab("AddPublisherWin");
                    break;
                case WinEnum.Genres:
                    GenreName.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
                    window.SelectTab("AddGenreWin");
                    break;
                case WinEnum.Books:
                    break;
                case WinEnum.Users:
                    UserName.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
                    window.SelectTab("AddUserWin");
                    break;
                case WinEnum.Positions:
                    PositionName.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
                    window.SelectTab("AddPositionWin");
                    break;
                case WinEnum.Librarians:
                    LibrarianName.Text = dataView.SelectedRows[0].Cells[2].Value.ToString();
                    LibrarianName2.Text = dataView.SelectedRows[0].Cells[3].Value.ToString();
                    LibrarianName3.Text = dataView.SelectedRows[0].Cells[4].Value.ToString();
                    window.SelectTab("AddLibrarianWin");
                    LibrarianPosition.SelectedItem = dataView.SelectedRows[0].Cells[1].Value.ToString();
                    break;
                case WinEnum.Entries:
                    break;
            }
            control_panel.Enabled = !control_panel.Enabled;
            search_panel.Enabled = !search_panel.Enabled;
        }

        private void del_but_Click(object sender, EventArgs e)
        {
            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                switch (source)
                {
                    case WinEnum.Authors:
                        {
                            foreach (var i in rowSource)
                            {
                                Model.Author? newInst = db.Author.Find(i);
                                if (newInst != null) db.Author.Remove(newInst);
                            }
                            break;
                        }
                    case WinEnum.Publishers:
                        {
                            foreach (var i in rowSource)
                            {
                                Model.Publisher? newInst = db.Publisher.Find(i);
                                if (newInst != null) db.Publisher.Remove(newInst);
                            } 
                            break;
                        }
                    case WinEnum.Genres:
                        {
                            foreach (var i in rowSource)
                            {
                                Model.Genre? newInst = db.Genre.Find(i);
                                if (newInst != null) db.Genre.Remove(newInst);
                            }
                            break;
                        }
                    case WinEnum.Books:
                        break;
                    case WinEnum.Users:
                        foreach (var i in rowSource)
                        {
                            Model.User? newInst = db.User.Find(i);
                            if (newInst != null) db.User.Remove(newInst);
                        }
                        break;
                    case WinEnum.Positions:
                        foreach (var i in rowSource)
                        {
                            Model.Position? newInst = db.Position.Find(i);
                            if (newInst != null) db.Position.Remove(newInst);
                        }
                        break;
                    case WinEnum.Librarians:
                        foreach (var i in rowSource)
                        {
                            Model.Worker? newInst = db.Worker.Find(i);
                            if (newInst != null) db.Worker.Remove(newInst);
                        }
                        break;
                    case WinEnum.Entries:
                        break;
                }
                db.SaveChanges();
                SetView(source);
            }
        }

        private void dataView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                rowSource = new List<int>();
                foreach (DataGridViewRow item in dataView.SelectedRows)
                {
                    rowSource.Add(int.Parse(item.Cells[0].Value.ToString()));
                }
            }
            catch { }
        }

        private void GenreOKBut_Click(object sender, EventArgs e)
        {
            string? error = Functions.CheckNewGenre(GenreName.Text);
            GenreError.Text = error ?? "";
            if (error != null) return;

            window.Enabled = !window.Enabled;

            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                Model.Genre? newInst = db.Genre.Find(rowSource[0]);
                if (newInst != null)
                {
                    newInst.Name = GenreName.Text;
                }
                else
                {
                    newInst = new Model.Genre { Name = GenreName.Text };
                    db.Genre.Add(newInst);
                }
                db.SaveChanges();
                SetView(source);
            }
            GenreCancelBut_Click(sender, e);

            window.Enabled = !window.Enabled;
        }

        private void GenreCancelBut_Click(object sender, EventArgs e)
        {
            ClearInputs(AddGenreGroup);
            BackToView();
        }

        private void PositionOKBut_Click(object sender, EventArgs e)
        {
            string? error = Functions.CheckNewPosition(PositionName.Text);
            PositionError.Text = error ?? "";
            if (error != null) return;

            window.Enabled = !window.Enabled;

            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                Model.Position? newInst = db.Position.Find(rowSource[0]);
                if (newInst != null)
                {
                    newInst.Name = PositionName.Text;
                }
                else
                {
                    newInst = new Model.Position { Name = PositionName.Text };
                    db.Position.Add(newInst);
                }
                db.SaveChanges();
                SetView(source);
            }
            PositionCancelBut_Click(sender, e);

            window.Enabled = !window.Enabled;
        }

        private void PositionCancelBut_Click(object sender, EventArgs e)
        {
            ClearInputs(AddPositionGroup);
            BackToView();
        }

        private void UserOKBut_Click(object sender, EventArgs e)
        {
            UserName.Text = Functions.PrepareName(UserName.Text);
            UserName2.Text = Functions.PrepareName(UserName2.Text);
            UserName3.Text = Functions.PrepareName(UserName3.Text);

            string? error = Functions.CheckNewAuthor(UserName.Text, UserName2.Text, UserName3.Text);
            UserError.Text = error ?? "";
            if (error != null) return;

            window.Enabled = !window.Enabled;

            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                Model.User? newInst = db.User.Find(rowSource[0]);
                if (newInst != null)
                {
                    newInst.Name1 = UserName.Text;
                    newInst.Name2 = UserName2.Text;
                    newInst.Name3 = UserName3.Text;
                }
                else
                {
                    newInst = new Model.User { Name1 = UserName.Text, Name2 = UserName2.Text, Name3 = UserName3.Text };
                    db.User.Add(newInst);
                }
                db.SaveChanges();
                SetView(source);
            }
            UserCancelBut_Click(sender, e);

            window.Enabled = !window.Enabled;
        }

        private void UserCancelBut_Click(object sender, EventArgs e)
        {
            ClearInputs(AddUserGroup);
            BackToView();
        }

        private void LibrarianOKBut_Click(object sender, EventArgs e)
        {
            LibrarianName.Text = Functions.PrepareName(LibrarianName.Text);
            LibrarianName2.Text = Functions.PrepareName(LibrarianName2.Text);
            LibrarianName3.Text = Functions.PrepareName(LibrarianName3.Text);

            string? error = Functions.CheckNewAuthor(LibrarianName.Text, LibrarianName2.Text, LibrarianName3.Text);
            LibrarianError.Text = error ?? "";
            if (error != null) return;

            window.Enabled = !window.Enabled;

            using (Model.ApplicationContext db = new Model.ApplicationContext())
            {
                Model.Worker? newInst = db.Worker.Find(rowSource[0]);
                var val = (Position)db.Position.Where(p => p.Name == LibrarianPosition.SelectedValue.ToString()).ToList()[0];
                if (newInst != null)
                {
                    newInst.Name1 = LibrarianName.Text;
                    newInst.Name2 = LibrarianName2.Text;
                    newInst.Name3 = LibrarianName3.Text;
                    newInst.Position = val;
                }
                else
                {
                    newInst = new Model.Worker { Name1 = LibrarianName.Text, Name2 = LibrarianName2.Text, Name3 = LibrarianName3.Text, Position = val };
                    db.Worker.Add(newInst);
                }
                db.SaveChanges();
                SetView(source);
            }
            LibrarianCancelBut_Click(sender, e);

            window.Enabled = !window.Enabled;
        }

        private void LibrarianCancelBut_Click(object sender, EventArgs e)
        {
            ClearInputs(AddLibrarianGroup);
            BackToView();
        }

        private void goToPositions_Click(object sender, EventArgs e)
        {
            List<string[]>? rows = Functions.OpenNewWin(sender, WinEnum.Positions, true, this);
            if (rows == null) return;
            LibrarianPosition.SelectedItem = rows[0][1];
        }

        private void BookAuthorAdd_Click(object sender, EventArgs e)
        {
            List<string[]>? rows = Functions.OpenNewWin(sender, WinEnum.Authors, true, this);
            if (rows == null) return;
            BookAuthorsView.ColumnCount = 4;
            BookAuthorsView.Columns[0].HeaderText = "id";
            BookAuthorsView.Columns[1].HeaderText = "‘‡ÏËÎËˇ";
            //BookAuthorsView.Columns[2].HeaderText = "»Ïˇ";
            //BookAuthorsView.Columns[3].HeaderText = "ŒÚ˜ÂÒÚ‚Ó";
            BookAuthorsView.Rows.Add(rows[0][0], rows[0][1]);
        }

        private void BookAuthorDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in BookAuthorsView.SelectedRows)
            {
                BookAuthorsView.Rows.RemoveAt(row.Index);
            }
        }

        private void BookGenreAdd_Click(object sender, EventArgs e)
        {
            List<string[]>? rows = Functions.OpenNewWin(sender, WinEnum.Genres, true, this);
            if (rows == null) return;
            DataGridViewRow dr = new DataGridViewRow();
            dr.Cells[0].Value = rows[0][0];
            dr.Cells[1].Value = rows[0][1];
            BookGenresView.Rows.Add(dr);
        }

        private void BookGenreDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in BookGenresView.SelectedRows)
            {
                BookGenresView.Rows.Remove(row);
            }
        }

        private void BookOKBut_Click(object sender, EventArgs e)
        {

        }

        private void BookCancelBut_Click(object sender, EventArgs e)
        {
            ClearInputs(AddLibrarianGroup);
            BackToView();
        }
    }
}