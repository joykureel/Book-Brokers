namespace BookBrokers
{
    partial class VendorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorsForm));
            this.btnPrintVendors = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printVendorInvoices = new System.Drawing.Printing.PrintDocument();
            this.prvVendorInvoices = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrintVendors
            // 
            this.btnPrintVendors.Location = new System.Drawing.Point(120, 74);
            this.btnPrintVendors.Name = "btnPrintVendors";
            this.btnPrintVendors.Size = new System.Drawing.Size(113, 23);
            this.btnPrintVendors.TabIndex = 0;
            this.btnPrintVendors.Text = "Print Vendors";
            this.btnPrintVendors.UseVisualStyleBackColor = true;
            this.btnPrintVendors.Click += new System.EventHandler(this.btnPrintVendors_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(322, 74);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(109, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printVendorInvoices
            // 
            this.printVendorInvoices.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printVendorInvoices_PrintPage);
            // 
            // prvVendorInvoices
            // 
            this.prvVendorInvoices.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvVendorInvoices.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvVendorInvoices.ClientSize = new System.Drawing.Size(400, 300);
            this.prvVendorInvoices.Document = this.printVendorInvoices;
            this.prvVendorInvoices.Enabled = true;
            this.prvVendorInvoices.Icon = ((System.Drawing.Icon)(resources.GetObject("prvVendorInvoices.Icon")));
            this.prvVendorInvoices.Name = "prvVendorInvoices";
            this.prvVendorInvoices.Visible = false;
            // 
            // VendorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 157);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintVendors);
            this.Name = "VendorsForm";
            this.Text = "Vendors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintVendors;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printVendorInvoices;
        private System.Windows.Forms.PrintPreviewDialog prvVendorInvoices;
    }
}