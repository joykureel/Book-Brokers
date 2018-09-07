namespace BookBrokers
{
    partial class BookInfoForm
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
            this.lstBookTitles = new System.Windows.Forms.ListBox();
            this.lblBookInfoID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.lblAuthorLastName = new System.Windows.Forms.Label();
            this.lblAuthorFirstName = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddBookInfo = new System.Windows.Forms.Button();
            this.btnUpdateBookInfo = new System.Windows.Forms.Button();
            this.btnDeleteBookInfo = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtBookInfoID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.txtAuthorLastName = new System.Windows.Forms.TextBox();
            this.txtAuthorFirstName = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pnlAddBookInfo = new System.Windows.Forms.Panel();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSaveBookInfo = new System.Windows.Forms.Button();
            this.lblAddAuthor = new System.Windows.Forms.Label();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblAddNotes = new System.Windows.Forms.Label();
            this.cboAddAuthorFirstName = new System.Windows.Forms.ComboBox();
            this.cboAddAuthorLastName = new System.Windows.Forms.ComboBox();
            this.cboAddAuthorID = new System.Windows.Forms.ComboBox();
            this.txtAddNotes = new System.Windows.Forms.TextBox();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.pnlUpdateBookInfo = new System.Windows.Forms.Panel();
            this.txtUpdateNotes = new System.Windows.Forms.TextBox();
            this.txtUpdateAuthorFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdateAuthorLastName = new System.Windows.Forms.TextBox();
            this.txtUpdateAuthorID = new System.Windows.Forms.TextBox();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.txtUpdateBookInfoID = new System.Windows.Forms.TextBox();
            this.lblUpdateNotes = new System.Windows.Forms.Label();
            this.lblUpdateAuthorFirstName = new System.Windows.Forms.Label();
            this.lblUpdateAuthorLastName = new System.Windows.Forms.Label();
            this.lblUpdateAuthorID = new System.Windows.Forms.Label();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblUpdateBookInfoID = new System.Windows.Forms.Label();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnUpdateSaveBook = new System.Windows.Forms.Button();
            this.pnlAddBookInfo.SuspendLayout();
            this.pnlUpdateBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBookTitles
            // 
            this.lstBookTitles.FormattingEnabled = true;
            this.lstBookTitles.Location = new System.Drawing.Point(21, 12);
            this.lstBookTitles.Name = "lstBookTitles";
            this.lstBookTitles.Size = new System.Drawing.Size(185, 277);
            this.lstBookTitles.TabIndex = 0;
            this.lstBookTitles.SelectedIndexChanged += new System.EventHandler(this.lstBookTitles_SelectedIndexChanged);
            // 
            // lblBookInfoID
            // 
            this.lblBookInfoID.AutoSize = true;
            this.lblBookInfoID.Location = new System.Drawing.Point(310, 32);
            this.lblBookInfoID.Name = "lblBookInfoID";
            this.lblBookInfoID.Size = new System.Drawing.Size(70, 13);
            this.lblBookInfoID.TabIndex = 1;
            this.lblBookInfoID.Text = "Book Info ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(310, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(310, 116);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(55, 13);
            this.lblAuthorID.TabIndex = 3;
            this.lblAuthorID.Text = "Author ID:";
            // 
            // lblAuthorLastName
            // 
            this.lblAuthorLastName.AutoSize = true;
            this.lblAuthorLastName.Location = new System.Drawing.Point(310, 156);
            this.lblAuthorLastName.Name = "lblAuthorLastName";
            this.lblAuthorLastName.Size = new System.Drawing.Size(95, 13);
            this.lblAuthorLastName.TabIndex = 4;
            this.lblAuthorLastName.Text = "Author Last Name:";
            // 
            // lblAuthorFirstName
            // 
            this.lblAuthorFirstName.AutoSize = true;
            this.lblAuthorFirstName.Location = new System.Drawing.Point(310, 198);
            this.lblAuthorFirstName.Name = "lblAuthorFirstName";
            this.lblAuthorFirstName.Size = new System.Drawing.Size(94, 13);
            this.lblAuthorFirstName.TabIndex = 5;
            this.lblAuthorFirstName.Text = "Author First Name:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(30, 345);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrevious.Size = new System.Drawing.Size(110, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(167, 345);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddBookInfo
            // 
            this.btnAddBookInfo.Location = new System.Drawing.Point(310, 345);
            this.btnAddBookInfo.Name = "btnAddBookInfo";
            this.btnAddBookInfo.Size = new System.Drawing.Size(110, 23);
            this.btnAddBookInfo.TabIndex = 9;
            this.btnAddBookInfo.Text = "Add Book Info";
            this.btnAddBookInfo.UseVisualStyleBackColor = true;
            this.btnAddBookInfo.Click += new System.EventHandler(this.btnAddBookInfo_Click);
            // 
            // btnUpdateBookInfo
            // 
            this.btnUpdateBookInfo.Location = new System.Drawing.Point(455, 345);
            this.btnUpdateBookInfo.Name = "btnUpdateBookInfo";
            this.btnUpdateBookInfo.Size = new System.Drawing.Size(110, 23);
            this.btnUpdateBookInfo.TabIndex = 10;
            this.btnUpdateBookInfo.Text = "Update Book Info";
            this.btnUpdateBookInfo.UseVisualStyleBackColor = true;
            this.btnUpdateBookInfo.Click += new System.EventHandler(this.btnUpdateBookInfo_Click);
            // 
            // btnDeleteBookInfo
            // 
            this.btnDeleteBookInfo.Location = new System.Drawing.Point(598, 345);
            this.btnDeleteBookInfo.Name = "btnDeleteBookInfo";
            this.btnDeleteBookInfo.Size = new System.Drawing.Size(110, 23);
            this.btnDeleteBookInfo.TabIndex = 11;
            this.btnDeleteBookInfo.Text = "Delete Book Info";
            this.btnDeleteBookInfo.UseVisualStyleBackColor = true;
            this.btnDeleteBookInfo.Click += new System.EventHandler(this.btnDeleteBookInfo_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(598, 395);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 23);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(313, 237);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 12;
            this.lblNotes.Text = "Notes:";
            // 
            // txtBookInfoID
            // 
            this.txtBookInfoID.Location = new System.Drawing.Point(412, 24);
            this.txtBookInfoID.Name = "txtBookInfoID";
            this.txtBookInfoID.Size = new System.Drawing.Size(100, 20);
            this.txtBookInfoID.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(412, 63);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(287, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(412, 108);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorID.TabIndex = 3;
            this.txtAuthorID.TextChanged += new System.EventHandler(this.txtAuthorID_TextChanged);
            // 
            // txtAuthorLastName
            // 
            this.txtAuthorLastName.Location = new System.Drawing.Point(412, 156);
            this.txtAuthorLastName.Name = "txtAuthorLastName";
            this.txtAuthorLastName.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorLastName.TabIndex = 4;
            this.txtAuthorLastName.TextChanged += new System.EventHandler(this.txtAuthorID_TextChanged);
            // 
            // txtAuthorFirstName
            // 
            this.txtAuthorFirstName.Location = new System.Drawing.Point(412, 198);
            this.txtAuthorFirstName.Name = "txtAuthorFirstName";
            this.txtAuthorFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorFirstName.TabIndex = 5;
            this.txtAuthorFirstName.TextChanged += new System.EventHandler(this.txtAuthorID_TextChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(412, 237);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(287, 52);
            this.txtNotes.TabIndex = 6;
            // 
            // pnlAddBookInfo
            // 
            this.pnlAddBookInfo.Controls.Add(this.btnAddCancel);
            this.pnlAddBookInfo.Controls.Add(this.btnAddSaveBookInfo);
            this.pnlAddBookInfo.Controls.Add(this.lblAddAuthor);
            this.pnlAddBookInfo.Controls.Add(this.lblAddTitle);
            this.pnlAddBookInfo.Controls.Add(this.lblAddNotes);
            this.pnlAddBookInfo.Controls.Add(this.cboAddAuthorFirstName);
            this.pnlAddBookInfo.Controls.Add(this.cboAddAuthorLastName);
            this.pnlAddBookInfo.Controls.Add(this.cboAddAuthorID);
            this.pnlAddBookInfo.Controls.Add(this.txtAddNotes);
            this.pnlAddBookInfo.Controls.Add(this.txtAddTitle);
            this.pnlAddBookInfo.Location = new System.Drawing.Point(798, 12);
            this.pnlAddBookInfo.Name = "pnlAddBookInfo";
            this.pnlAddBookInfo.Size = new System.Drawing.Size(444, 299);
            this.pnlAddBookInfo.TabIndex = 19;
            this.pnlAddBookInfo.Visible = false;
            this.pnlAddBookInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddBookInfo_Paint);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(347, 214);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 7;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddSaveBookInfo
            // 
            this.btnAddSaveBookInfo.Location = new System.Drawing.Point(34, 214);
            this.btnAddSaveBookInfo.Name = "btnAddSaveBookInfo";
            this.btnAddSaveBookInfo.Size = new System.Drawing.Size(75, 23);
            this.btnAddSaveBookInfo.TabIndex = 6;
            this.btnAddSaveBookInfo.Text = "Save Book Info";
            this.btnAddSaveBookInfo.UseVisualStyleBackColor = true;
            this.btnAddSaveBookInfo.Click += new System.EventHandler(this.btnAddSaveBookInfo_Click);
            // 
            // lblAddAuthor
            // 
            this.lblAddAuthor.AutoSize = true;
            this.lblAddAuthor.Location = new System.Drawing.Point(54, 74);
            this.lblAddAuthor.Name = "lblAddAuthor";
            this.lblAddAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAddAuthor.TabIndex = 25;
            this.lblAddAuthor.Text = "Author:";
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(54, 34);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(30, 13);
            this.lblAddTitle.TabIndex = 24;
            this.lblAddTitle.Text = "Title:";
            // 
            // lblAddNotes
            // 
            this.lblAddNotes.AutoSize = true;
            this.lblAddNotes.Location = new System.Drawing.Point(54, 127);
            this.lblAddNotes.Name = "lblAddNotes";
            this.lblAddNotes.Size = new System.Drawing.Size(38, 13);
            this.lblAddNotes.TabIndex = 23;
            this.lblAddNotes.Text = "Notes:";
            // 
            // cboAddAuthorFirstName
            // 
            this.cboAddAuthorFirstName.FormattingEnabled = true;
            this.cboAddAuthorFirstName.Location = new System.Drawing.Point(329, 68);
            this.cboAddAuthorFirstName.Name = "cboAddAuthorFirstName";
            this.cboAddAuthorFirstName.Size = new System.Drawing.Size(93, 21);
            this.cboAddAuthorFirstName.TabIndex = 4;
            // 
            // cboAddAuthorLastName
            // 
            this.cboAddAuthorLastName.FormattingEnabled = true;
            this.cboAddAuthorLastName.Location = new System.Drawing.Point(210, 67);
            this.cboAddAuthorLastName.Name = "cboAddAuthorLastName";
            this.cboAddAuthorLastName.Size = new System.Drawing.Size(93, 21);
            this.cboAddAuthorLastName.TabIndex = 3;
            // 
            // cboAddAuthorID
            // 
            this.cboAddAuthorID.FormattingEnabled = true;
            this.cboAddAuthorID.Location = new System.Drawing.Point(135, 67);
            this.cboAddAuthorID.Name = "cboAddAuthorID";
            this.cboAddAuthorID.Size = new System.Drawing.Size(49, 21);
            this.cboAddAuthorID.TabIndex = 2;
            this.cboAddAuthorID.SelectedIndexChanged += new System.EventHandler(this.cboAddAuthorID_SelectedIndexChanged);
            // 
            // txtAddNotes
            // 
            this.txtAddNotes.Location = new System.Drawing.Point(135, 127);
            this.txtAddNotes.Multiline = true;
            this.txtAddNotes.Name = "txtAddNotes";
            this.txtAddNotes.Size = new System.Drawing.Size(287, 52);
            this.txtAddNotes.TabIndex = 5;
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(135, 28);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(287, 20);
            this.txtAddTitle.TabIndex = 1;
            // 
            // pnlUpdateBookInfo
            // 
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateNotes);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorFirstName);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorLastName);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorID);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateTitle);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateBookInfoID);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateNotes);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateAuthorFirstName);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateAuthorLastName);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateAuthorID);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateTitle);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateBookInfoID);
            this.pnlUpdateBookInfo.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateBookInfo.Controls.Add(this.btnUpdateSaveBook);
            this.pnlUpdateBookInfo.Location = new System.Drawing.Point(798, 317);
            this.pnlUpdateBookInfo.Name = "pnlUpdateBookInfo";
            this.pnlUpdateBookInfo.Size = new System.Drawing.Size(454, 333);
            this.pnlUpdateBookInfo.TabIndex = 20;
            this.pnlUpdateBookInfo.Visible = false;
            // 
            // txtUpdateNotes
            // 
            this.txtUpdateNotes.Location = new System.Drawing.Point(130, 237);
            this.txtUpdateNotes.Multiline = true;
            this.txtUpdateNotes.Name = "txtUpdateNotes";
            this.txtUpdateNotes.Size = new System.Drawing.Size(287, 52);
            this.txtUpdateNotes.TabIndex = 6;
            // 
            // txtUpdateAuthorFirstName
            // 
            this.txtUpdateAuthorFirstName.Enabled = false;
            this.txtUpdateAuthorFirstName.Location = new System.Drawing.Point(130, 198);
            this.txtUpdateAuthorFirstName.Name = "txtUpdateAuthorFirstName";
            this.txtUpdateAuthorFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAuthorFirstName.TabIndex = 5;
            // 
            // txtUpdateAuthorLastName
            // 
            this.txtUpdateAuthorLastName.Enabled = false;
            this.txtUpdateAuthorLastName.Location = new System.Drawing.Point(130, 156);
            this.txtUpdateAuthorLastName.Name = "txtUpdateAuthorLastName";
            this.txtUpdateAuthorLastName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAuthorLastName.TabIndex = 4;
            // 
            // txtUpdateAuthorID
            // 
            this.txtUpdateAuthorID.Enabled = false;
            this.txtUpdateAuthorID.Location = new System.Drawing.Point(130, 108);
            this.txtUpdateAuthorID.Name = "txtUpdateAuthorID";
            this.txtUpdateAuthorID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAuthorID.TabIndex = 3;
            this.txtUpdateAuthorID.TextChanged += new System.EventHandler(this.txtUpdateAuthorID_TextChanged);
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(130, 63);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(287, 20);
            this.txtUpdateTitle.TabIndex = 2;
            // 
            // txtUpdateBookInfoID
            // 
            this.txtUpdateBookInfoID.Enabled = false;
            this.txtUpdateBookInfoID.Location = new System.Drawing.Point(130, 24);
            this.txtUpdateBookInfoID.Name = "txtUpdateBookInfoID";
            this.txtUpdateBookInfoID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateBookInfoID.TabIndex = 1;
            // 
            // lblUpdateNotes
            // 
            this.lblUpdateNotes.AutoSize = true;
            this.lblUpdateNotes.Location = new System.Drawing.Point(31, 237);
            this.lblUpdateNotes.Name = "lblUpdateNotes";
            this.lblUpdateNotes.Size = new System.Drawing.Size(38, 13);
            this.lblUpdateNotes.TabIndex = 35;
            this.lblUpdateNotes.Text = "Notes:";
            // 
            // lblUpdateAuthorFirstName
            // 
            this.lblUpdateAuthorFirstName.AutoSize = true;
            this.lblUpdateAuthorFirstName.Location = new System.Drawing.Point(28, 198);
            this.lblUpdateAuthorFirstName.Name = "lblUpdateAuthorFirstName";
            this.lblUpdateAuthorFirstName.Size = new System.Drawing.Size(94, 13);
            this.lblUpdateAuthorFirstName.TabIndex = 34;
            this.lblUpdateAuthorFirstName.Text = "Author First Name:";
            // 
            // lblUpdateAuthorLastName
            // 
            this.lblUpdateAuthorLastName.AutoSize = true;
            this.lblUpdateAuthorLastName.Location = new System.Drawing.Point(28, 156);
            this.lblUpdateAuthorLastName.Name = "lblUpdateAuthorLastName";
            this.lblUpdateAuthorLastName.Size = new System.Drawing.Size(95, 13);
            this.lblUpdateAuthorLastName.TabIndex = 33;
            this.lblUpdateAuthorLastName.Text = "Author Last Name:";
            // 
            // lblUpdateAuthorID
            // 
            this.lblUpdateAuthorID.AutoSize = true;
            this.lblUpdateAuthorID.Location = new System.Drawing.Point(28, 116);
            this.lblUpdateAuthorID.Name = "lblUpdateAuthorID";
            this.lblUpdateAuthorID.Size = new System.Drawing.Size(55, 13);
            this.lblUpdateAuthorID.TabIndex = 32;
            this.lblUpdateAuthorID.Text = "Author ID:";
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(28, 76);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(30, 13);
            this.lblUpdateTitle.TabIndex = 31;
            this.lblUpdateTitle.Text = "Title:";
            // 
            // lblUpdateBookInfoID
            // 
            this.lblUpdateBookInfoID.AutoSize = true;
            this.lblUpdateBookInfoID.Location = new System.Drawing.Point(28, 32);
            this.lblUpdateBookInfoID.Name = "lblUpdateBookInfoID";
            this.lblUpdateBookInfoID.Size = new System.Drawing.Size(70, 13);
            this.lblUpdateBookInfoID.TabIndex = 30;
            this.lblUpdateBookInfoID.Text = "Book Info ID:";
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(347, 305);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCancel.TabIndex = 8;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnUpdateSaveBook
            // 
            this.btnUpdateSaveBook.Location = new System.Drawing.Point(34, 305);
            this.btnUpdateSaveBook.Name = "btnUpdateSaveBook";
            this.btnUpdateSaveBook.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSaveBook.TabIndex = 7;
            this.btnUpdateSaveBook.Text = "Save Book Info";
            this.btnUpdateSaveBook.UseVisualStyleBackColor = true;
            this.btnUpdateSaveBook.Click += new System.EventHandler(this.btnUpdateSaveBook_Click);
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.pnlUpdateBookInfo);
            this.Controls.Add(this.pnlAddBookInfo);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtAuthorFirstName);
            this.Controls.Add(this.txtAuthorLastName);
            this.Controls.Add(this.txtAuthorID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBookInfoID);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteBookInfo);
            this.Controls.Add(this.btnUpdateBookInfo);
            this.Controls.Add(this.btnAddBookInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblAuthorFirstName);
            this.Controls.Add(this.lblAuthorLastName);
            this.Controls.Add(this.lblAuthorID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookInfoID);
            this.Controls.Add(this.lstBookTitles);
            this.Name = "BookInfoForm";
            this.Text = "Book Info Maintenance";
            this.Load += new System.EventHandler(this.BookInfoForm_Load);
            this.pnlAddBookInfo.ResumeLayout(false);
            this.pnlAddBookInfo.PerformLayout();
            this.pnlUpdateBookInfo.ResumeLayout(false);
            this.pnlUpdateBookInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBookTitles;
        private System.Windows.Forms.Label lblBookInfoID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Label lblAuthorLastName;
        private System.Windows.Forms.Label lblAuthorFirstName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddBookInfo;
        private System.Windows.Forms.Button btnUpdateBookInfo;
        private System.Windows.Forms.Button btnDeleteBookInfo;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtBookInfoID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.TextBox txtAuthorLastName;
        private System.Windows.Forms.TextBox txtAuthorFirstName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlAddBookInfo;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddSaveBookInfo;
        private System.Windows.Forms.Label lblAddAuthor;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Label lblAddNotes;
        private System.Windows.Forms.ComboBox cboAddAuthorFirstName;
        private System.Windows.Forms.ComboBox cboAddAuthorLastName;
        private System.Windows.Forms.ComboBox cboAddAuthorID;
        private System.Windows.Forms.TextBox txtAddNotes;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Panel pnlUpdateBookInfo;
        private System.Windows.Forms.TextBox txtUpdateNotes;
        private System.Windows.Forms.TextBox txtUpdateAuthorFirstName;
        private System.Windows.Forms.TextBox txtUpdateAuthorLastName;
        private System.Windows.Forms.TextBox txtUpdateAuthorID;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.TextBox txtUpdateBookInfoID;
        private System.Windows.Forms.Label lblUpdateNotes;
        private System.Windows.Forms.Label lblUpdateAuthorFirstName;
        private System.Windows.Forms.Label lblUpdateAuthorLastName;
        private System.Windows.Forms.Label lblUpdateAuthorID;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblUpdateBookInfoID;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdateSaveBook;
    }
}