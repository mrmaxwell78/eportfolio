namespace CDApplication
{
    partial class Form1
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
            this.lblArtistPrompt = new System.Windows.Forms.Label();
            this.lblDatePrompt = new System.Windows.Forms.Label();
            this.lblGenrePrompt = new System.Windows.Forms.Label();
            this.lblTitlePrompt = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lstCDs = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArtistPrompt
            // 
            this.lblArtistPrompt.Location = new System.Drawing.Point(59, 70);
            this.lblArtistPrompt.Name = "lblArtistPrompt";
            this.lblArtistPrompt.Size = new System.Drawing.Size(178, 34);
            this.lblArtistPrompt.TabIndex = 0;
            this.lblArtistPrompt.Text = "Enter Artist:";
            this.lblArtistPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDatePrompt
            // 
            this.lblDatePrompt.Location = new System.Drawing.Point(59, 172);
            this.lblDatePrompt.Name = "lblDatePrompt";
            this.lblDatePrompt.Size = new System.Drawing.Size(178, 34);
            this.lblDatePrompt.TabIndex = 1;
            this.lblDatePrompt.Text = "Enter release date:";
            this.lblDatePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGenrePrompt
            // 
            this.lblGenrePrompt.Location = new System.Drawing.Point(59, 138);
            this.lblGenrePrompt.Name = "lblGenrePrompt";
            this.lblGenrePrompt.Size = new System.Drawing.Size(178, 34);
            this.lblGenrePrompt.TabIndex = 2;
            this.lblGenrePrompt.Text = "Enter genre:";
            this.lblGenrePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitlePrompt
            // 
            this.lblTitlePrompt.Location = new System.Drawing.Point(59, 104);
            this.lblTitlePrompt.Name = "lblTitlePrompt";
            this.lblTitlePrompt.Size = new System.Drawing.Size(178, 34);
            this.lblTitlePrompt.TabIndex = 3;
            this.lblTitlePrompt.Text = "Enter Title:";
            this.lblTitlePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(243, 78);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(170, 20);
            this.txtArtist.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(243, 112);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(170, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(243, 146);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(170, 20);
            this.txtGenre.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(243, 180);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(170, 20);
            this.txtDate.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(229, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 44);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add To File";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(232, 323);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(180, 49);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "Read From File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lstCDs
            // 
            this.lstCDs.FormattingEnabled = true;
            this.lstCDs.Location = new System.Drawing.Point(475, 71);
            this.lstCDs.Name = "lstCDs";
            this.lstCDs.Size = new System.Drawing.Size(112, 121);
            this.lstCDs.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.addToFileToolStripMenuItem,
            this.readFromFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // addToFileToolStripMenuItem
            // 
            this.addToFileToolStripMenuItem.Name = "addToFileToolStripMenuItem";
            this.addToFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToFileToolStripMenuItem.Text = "Add To File";
            this.addToFileToolStripMenuItem.Click += new System.EventHandler(this.addToFileToolStripMenuItem_Click);
            // 
            // readFromFileToolStripMenuItem
            // 
            this.readFromFileToolStripMenuItem.Name = "readFromFileToolStripMenuItem";
            this.readFromFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.readFromFileToolStripMenuItem.Text = "Read From File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 457);
            this.Controls.Add(this.lstCDs);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.lblTitlePrompt);
            this.Controls.Add(this.lblGenrePrompt);
            this.Controls.Add(this.lblDatePrompt);
            this.Controls.Add(this.lblArtistPrompt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtistPrompt;
        private System.Windows.Forms.Label lblDatePrompt;
        private System.Windows.Forms.Label lblGenrePrompt;
        private System.Windows.Forms.Label lblTitlePrompt;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox lstCDs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFromFileToolStripMenuItem;
    }
}

