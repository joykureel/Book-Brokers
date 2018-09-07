namespace BookBrokers
{
    partial class AddBookForm
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
            this.components = new System.ComponentModel.Container();
            this.dSBookBrokers = new BookBrokers.DSBookBrokers();
            this.cLIENTORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvClientOrder = new System.Windows.Forms.DataGridView();
            this.dgvBookDetails = new System.Windows.Forms.DataGridView();
            this.dgvBookDetails2 = new System.Windows.Forms.DataGridView();
            this.lblClientLastName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.lblClientFirstName = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dSBookBrokers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails2)).BeginInit();
            this.SuspendLayout();
            // 
            // dSBookBrokers
            // 
            this.dSBookBrokers.DataSetName = "DSBookBrokers";
            this.dSBookBrokers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTORDERBindingSource
            // 
            this.cLIENTORDERBindingSource.DataMember = "CLIENTORDER";
            this.cLIENTORDERBindingSource.DataSource = this.dSBookBrokers;
            // 
            // dgvClientOrder
            // 
            this.dgvClientOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientOrder.Location = new System.Drawing.Point(12, 38);
            this.dgvClientOrder.Name = "dgvClientOrder";
            this.dgvClientOrder.Size = new System.Drawing.Size(542, 184);
            this.dgvClientOrder.TabIndex = 0;
            this.dgvClientOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientOrder_CellClick);
            this.dgvClientOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientOrder_CellContentClick);
            // 
            // dgvBookDetails
            // 
            this.dgvBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookDetails.Location = new System.Drawing.Point(12, 244);
            this.dgvBookDetails.Name = "dgvBookDetails";
            this.dgvBookDetails.Size = new System.Drawing.Size(593, 166);
            this.dgvBookDetails.TabIndex = 1;
            this.dgvBookDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookDetails_CellClick);
            this.dgvBookDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookDetails_CellContentClick);
            // 
            // dgvBookDetails2
            // 
            this.dgvBookDetails2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookDetails2.Location = new System.Drawing.Point(624, 244);
            this.dgvBookDetails2.Name = "dgvBookDetails2";
            this.dgvBookDetails2.Size = new System.Drawing.Size(596, 166);
            this.dgvBookDetails2.TabIndex = 2;
            this.dgvBookDetails2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookDetails2_CellClick);
            // 
            // lblClientLastName
            // 
            this.lblClientLastName.AutoSize = true;
            this.lblClientLastName.Location = new System.Drawing.Point(621, 103);
            this.lblClientLastName.Name = "lblClientLastName";
            this.lblClientLastName.Size = new System.Drawing.Size(90, 13);
            this.lblClientLastName.TabIndex = 3;
            this.lblClientLastName.Text = "Client Last Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(277, 438);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title:";
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(716, 100);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(100, 20);
            this.txtClientLastName.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(330, 435);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(716, 126);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtClientFirstName.TabIndex = 4;
            // 
            // lblClientFirstName
            // 
            this.lblClientFirstName.AutoSize = true;
            this.lblClientFirstName.Location = new System.Drawing.Point(621, 129);
            this.lblClientFirstName.Name = "lblClientFirstName";
            this.lblClientFirstName.Size = new System.Drawing.Size(89, 13);
            this.lblClientFirstName.TabIndex = 8;
            this.lblClientFirstName.Text = "Client First Name:";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(66, 461);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(86, 23);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(341, 461);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveBook.TabIndex = 7;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(650, 461);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 595);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblClientFirstName);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblClientLastName);
            this.Controls.Add(this.dgvBookDetails2);
            this.Controls.Add(this.dgvBookDetails);
            this.Controls.Add(this.dgvClientOrder);
            this.Name = "AddBookForm";
            this.Text = "Add Book to a Client Order";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSBookBrokers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cLIENTORDERBindingSource;
        private DSBookBrokers dSBookBrokers;
        private System.Windows.Forms.DataGridView dgvClientOrder;
        private System.Windows.Forms.DataGridView dgvBookDetails;
        private System.Windows.Forms.DataGridView dgvBookDetails2;
        private System.Windows.Forms.Label lblClientLastName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.Label lblClientFirstName;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnReturn;
    }
}