namespace MiniBankaOtomasyonu
{
    partial class frmAna
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
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGise = new System.Windows.Forms.MenuStrip();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapParaCekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediKartıToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.krediKartıOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMusteri = new System.Windows.Forms.MenuStrip();
            this.krediKartıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapDefteriÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin.SuspendLayout();
            this.menuGise.SuspendLayout();
            this.menuMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAdmin
            // 
            this.menuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıToolStripMenuItem});
            this.menuAdmin.Location = new System.Drawing.Point(0, 48);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(800, 24);
            this.menuAdmin.TabIndex = 1;
            this.menuAdmin.Text = "menuStrip1";
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem,
            this.kullanıcıListeleToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click);
            // 
            // kullanıcıListeleToolStripMenuItem
            // 
            this.kullanıcıListeleToolStripMenuItem.Name = "kullanıcıListeleToolStripMenuItem";
            this.kullanıcıListeleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.kullanıcıListeleToolStripMenuItem.Text = "Kullanıcı Listele";
            this.kullanıcıListeleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıListeleToolStripMenuItem_Click);
            // 
            // menuGise
            // 
            this.menuGise.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.hesapToolStripMenuItem,
            this.hesapParaCekToolStripMenuItem,
            this.krediKartıToolStripMenuItem1});
            this.menuGise.Location = new System.Drawing.Point(0, 24);
            this.menuGise.Name = "menuGise";
            this.menuGise.Size = new System.Drawing.Size(800, 24);
            this.menuGise.TabIndex = 3;
            this.menuGise.Text = "menuStrip1";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriListeleToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // müşteriListeleToolStripMenuItem
            // 
            this.müşteriListeleToolStripMenuItem.Name = "müşteriListeleToolStripMenuItem";
            this.müşteriListeleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.müşteriListeleToolStripMenuItem.Text = "Müşteri Listele";
            this.müşteriListeleToolStripMenuItem.Click += new System.EventHandler(this.müşteriListeleToolStripMenuItem_Click);
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapOluşturToolStripMenuItem,
            this.hesapListeleToolStripMenuItem,
            this.hesapDefteriÇıkarToolStripMenuItem});
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.hesapToolStripMenuItem.Text = "Hesap";
            // 
            // hesapOluşturToolStripMenuItem
            // 
            this.hesapOluşturToolStripMenuItem.Name = "hesapOluşturToolStripMenuItem";
            this.hesapOluşturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hesapOluşturToolStripMenuItem.Text = "Hesap Oluştur";
            this.hesapOluşturToolStripMenuItem.Click += new System.EventHandler(this.hesapOluşturToolStripMenuItem_Click);
            // 
            // hesapListeleToolStripMenuItem
            // 
            this.hesapListeleToolStripMenuItem.Name = "hesapListeleToolStripMenuItem";
            this.hesapListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hesapListeleToolStripMenuItem.Text = "Hesap Listele";
            this.hesapListeleToolStripMenuItem.Click += new System.EventHandler(this.hesapListeleToolStripMenuItem_Click);
            // 
            // hesapParaCekToolStripMenuItem
            // 
            this.hesapParaCekToolStripMenuItem.Name = "hesapParaCekToolStripMenuItem";
            this.hesapParaCekToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.hesapParaCekToolStripMenuItem.Text = "Hesap Para Cek";
            this.hesapParaCekToolStripMenuItem.Click += new System.EventHandler(this.hesapParaCekToolStripMenuItem_Click);
            // 
            // krediKartıToolStripMenuItem1
            // 
            this.krediKartıToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krediKartıOluşturToolStripMenuItem});
            this.krediKartıToolStripMenuItem1.Name = "krediKartıToolStripMenuItem1";
            this.krediKartıToolStripMenuItem1.Size = new System.Drawing.Size(73, 20);
            this.krediKartıToolStripMenuItem1.Text = "Kredi Kartı";
            this.krediKartıToolStripMenuItem1.Click += new System.EventHandler(this.krediKartıToolStripMenuItem1_Click);
            // 
            // krediKartıOluşturToolStripMenuItem
            // 
            this.krediKartıOluşturToolStripMenuItem.Name = "krediKartıOluşturToolStripMenuItem";
            this.krediKartıOluşturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.krediKartıOluşturToolStripMenuItem.Text = "Kredi Kartı Oluştur";
            // 
            // menuMusteri
            // 
            this.menuMusteri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krediKartıToolStripMenuItem});
            this.menuMusteri.Location = new System.Drawing.Point(0, 0);
            this.menuMusteri.Name = "menuMusteri";
            this.menuMusteri.Size = new System.Drawing.Size(800, 24);
            this.menuMusteri.TabIndex = 5;
            this.menuMusteri.Text = "menuStrip1";
            // 
            // krediKartıToolStripMenuItem
            // 
            this.krediKartıToolStripMenuItem.Name = "krediKartıToolStripMenuItem";
            this.krediKartıToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.krediKartıToolStripMenuItem.Text = "Kredi Kartı";
            this.krediKartıToolStripMenuItem.Click += new System.EventHandler(this.krediKartıToolStripMenuItem_Click);
            // 
            // hesapDefteriÇıkarToolStripMenuItem
            // 
            this.hesapDefteriÇıkarToolStripMenuItem.Name = "hesapDefteriÇıkarToolStripMenuItem";
            this.hesapDefteriÇıkarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hesapDefteriÇıkarToolStripMenuItem.Text = "Hesap Defteri Çıkar";
            this.hesapDefteriÇıkarToolStripMenuItem.Click += new System.EventHandler(this.hesapDefteriÇıkarToolStripMenuItem_Click);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuAdmin);
            this.Controls.Add(this.menuGise);
            this.Controls.Add(this.menuMusteri);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuAdmin;
            this.Name = "frmAna";
            this.Text = "frmAna";
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.menuAdmin.ResumeLayout(false);
            this.menuAdmin.PerformLayout();
            this.menuGise.ResumeLayout(false);
            this.menuGise.PerformLayout();
            this.menuMusteri.ResumeLayout(false);
            this.menuMusteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıListeleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuGise;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListeleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuMusteri;
        private System.Windows.Forms.ToolStripMenuItem krediKartıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapParaCekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediKartıToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem krediKartıOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapDefteriÇıkarToolStripMenuItem;
    }
}