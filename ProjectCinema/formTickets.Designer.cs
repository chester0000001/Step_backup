namespace ProjectCinema
{
    partial class formTickets
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
            this.boxSessions = new System.Windows.Forms.ListBox();
            this.boxHallName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numPlace = new System.Windows.Forms.NumericUpDown();
            this.boxRow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxFilmName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фильмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сессииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPlaces = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxSessions
            // 
            this.boxSessions.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxSessions.FormattingEnabled = true;
            this.boxSessions.Location = new System.Drawing.Point(0, 24);
            this.boxSessions.Name = "boxSessions";
            this.boxSessions.Size = new System.Drawing.Size(176, 221);
            this.boxSessions.TabIndex = 0;
            this.boxSessions.SelectedIndexChanged += new System.EventHandler(this.boxSessions_SelectedIndexChanged);
            // 
            // boxHallName
            // 
            this.boxHallName.Location = new System.Drawing.Point(60, 38);
            this.boxHallName.Name = "boxHallName";
            this.boxHallName.Size = new System.Drawing.Size(100, 20);
            this.boxHallName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Зал:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.numPlace);
            this.panel1.Controls.Add(this.boxRow);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.boxFilmName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.boxHallName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(434, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 221);
            this.panel1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(60, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add ticket";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numPlace
            // 
            this.numPlace.Location = new System.Drawing.Point(60, 92);
            this.numPlace.Name = "numPlace";
            this.numPlace.Size = new System.Drawing.Size(42, 20);
            this.numPlace.TabIndex = 9;
            // 
            // boxRow
            // 
            this.boxRow.Location = new System.Drawing.Point(60, 64);
            this.boxRow.Name = "boxRow";
            this.boxRow.Size = new System.Drawing.Size(100, 20);
            this.boxRow.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ряд:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Место:";
            // 
            // boxFilmName
            // 
            this.boxFilmName.Location = new System.Drawing.Point(60, 12);
            this.boxFilmName.Name = "boxFilmName";
            this.boxFilmName.Size = new System.Drawing.Size(100, 20);
            this.boxFilmName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фильм:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(176, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 221);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фильмыToolStripMenuItem,
            this.сессииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фильмыToolStripMenuItem
            // 
            this.фильмыToolStripMenuItem.Name = "фильмыToolStripMenuItem";
            this.фильмыToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.фильмыToolStripMenuItem.Text = "Фильмы...";
            this.фильмыToolStripMenuItem.Click += new System.EventHandler(this.фильмыToolStripMenuItem_Click);
            // 
            // сессииToolStripMenuItem
            // 
            this.сессииToolStripMenuItem.Name = "сессииToolStripMenuItem";
            this.сессииToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.сессииToolStripMenuItem.Text = "Сессии...";
            this.сессииToolStripMenuItem.Click += new System.EventHandler(this.сессииToolStripMenuItem_Click);
            // 
            // lvPlaces
            // 
            this.lvPlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPlaces.HideSelection = false;
            this.lvPlaces.Location = new System.Drawing.Point(176, 24);
            this.lvPlaces.Name = "lvPlaces";
            this.lvPlaces.Size = new System.Drawing.Size(258, 221);
            this.lvPlaces.TabIndex = 7;
            this.lvPlaces.UseCompatibleStateImageBehavior = false;
            this.lvPlaces.SelectedIndexChanged += new System.EventHandler(this.lvPlaces_SelectedIndexChanged);
            // 
            // formTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 245);
            this.Controls.Add(this.lvPlaces);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boxSessions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formTickets";
            this.Text = "formTickets";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox boxSessions;
        private System.Windows.Forms.TextBox boxHallName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numPlace;
        private System.Windows.Forms.TextBox boxRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxFilmName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фильмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сессииToolStripMenuItem;
        private System.Windows.Forms.ListView lvPlaces;
    }
}