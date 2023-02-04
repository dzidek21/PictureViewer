namespace PictureViewer
{
    partial class Form1
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
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbNazwaPliku = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPicture.Location = new System.Drawing.Point(129, 41);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(414, 279);
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPicture.Font = new System.Drawing.Font("Italianate", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddPicture.ForeColor = System.Drawing.Color.Ivory;
            this.btnAddPicture.Location = new System.Drawing.Point(12, 41);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(75, 23);
            this.btnAddPicture.TabIndex = 1;
            this.btnAddPicture.Text = "Dodaj";
            this.btnAddPicture.UseVisualStyleBackColor = false;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Location = new System.Drawing.Point(12, 254);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddUrl.FlatAppearance.BorderSize = 3;
            this.btnAddUrl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUrl.Font = new System.Drawing.Font("Italianate", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUrl.ForeColor = System.Drawing.Color.Ivory;
            this.btnAddUrl.Location = new System.Drawing.Point(12, 78);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(75, 23);
            this.btnAddUrl.TabIndex = 3;
            this.btnAddUrl.Text = "Dodaj URL";
            this.btnAddUrl.UseVisualStyleBackColor = false;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(93, 26);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromFileToolStripMenuItem,
            this.importFromURLToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem2.Text = "File";
            // 
            // importFromFileToolStripMenuItem
            // 
            this.importFromFileToolStripMenuItem.Name = "importFromFileToolStripMenuItem";
            this.importFromFileToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.importFromFileToolStripMenuItem.Text = "Import from file";
            this.importFromFileToolStripMenuItem.Click += new System.EventHandler(this.importFromFileToolStripMenuItem_Click);
            // 
            // importFromURLToolStripMenuItem
            // 
            this.importFromURLToolStripMenuItem.Name = "importFromURLToolStripMenuItem";
            this.importFromURLToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.importFromURLToolStripMenuItem.Text = "Import from URL";
            this.importFromURLToolStripMenuItem.Click += new System.EventHandler(this.importFromURLToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(312, 332);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(0, 15);
            this.lbFileName.TabIndex = 5;
            // 
            // lbNazwaPliku
            // 
            this.lbNazwaPliku.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNazwaPliku.AutoSize = true;
            this.lbNazwaPliku.Location = new System.Drawing.Point(209, 332);
            this.lbNazwaPliku.Name = "lbNazwaPliku";
            this.lbNazwaPliku.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNazwaPliku.Size = new System.Drawing.Size(272, 15);
            this.lbNazwaPliku.TabIndex = 6;
            this.lbNazwaPliku.Text = "4a37e2cbf36ca098deee95971abe9166a2841952.png";
            this.lbNazwaPliku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nazwa pliku:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNazwaPliku);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAddUrl);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.pbPicture);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbPicture;
        private Button btnAddPicture;
        private Button btnRemove;
        private Button btnAddUrl;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem importFromFileToolStripMenuItem;
        private ToolStripMenuItem importFromURLToolStripMenuItem;
        private Label lbFileName;
        private Label lbNazwaPliku;
        private Label label1;
    }
}