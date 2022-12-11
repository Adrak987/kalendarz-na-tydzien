namespace projektadraka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajZdarzenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńZdarzenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modyfikujZdarzenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.data1 = new System.Windows.Forms.Label();
            this.dzien1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data2 = new System.Windows.Forms.Label();
            this.dzien2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data3 = new System.Windows.Forms.Label();
            this.dzien3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data4 = new System.Windows.Forms.Label();
            this.dzien4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data5 = new System.Windows.Forms.Label();
            this.dzien5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listView6 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data6 = new System.Windows.Forms.Label();
            this.dzien6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listView7 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data7 = new System.Windows.Forms.Label();
            this.dzien7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(360, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "KALENDARZ NA TYDZIEŃ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.data1);
            this.panel1.Controls.Add(this.dzien1);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 395);
            this.panel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 46);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(149, 343);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zdarzenia:";
            this.columnHeader1.Width = 140;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajZdarzenieToolStripMenuItem,
            this.usuńZdarzenieToolStripMenuItem,
            this.modyfikujZdarzenieToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // dodajZdarzenieToolStripMenuItem
            // 
            this.dodajZdarzenieToolStripMenuItem.Name = "dodajZdarzenieToolStripMenuItem";
            this.dodajZdarzenieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajZdarzenieToolStripMenuItem.Text = "Dodaj zdarzenie";
            this.dodajZdarzenieToolStripMenuItem.Click += new System.EventHandler(this.dodajZdarzenieToolStripMenuItem_Click);
            // 
            // usuńZdarzenieToolStripMenuItem
            // 
            this.usuńZdarzenieToolStripMenuItem.Name = "usuńZdarzenieToolStripMenuItem";
            this.usuńZdarzenieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuńZdarzenieToolStripMenuItem.Text = "Usuń zdarzenie";
            this.usuńZdarzenieToolStripMenuItem.Click += new System.EventHandler(this.usuńZdarzenieToolStripMenuItem_Click);
            // 
            // modyfikujZdarzenieToolStripMenuItem
            // 
            this.modyfikujZdarzenieToolStripMenuItem.Name = "modyfikujZdarzenieToolStripMenuItem";
            this.modyfikujZdarzenieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modyfikujZdarzenieToolStripMenuItem.Text = "Modyfikuj zdarzenie";
            this.modyfikujZdarzenieToolStripMenuItem.Click += new System.EventHandler(this.modyfikujZdarzenieToolStripMenuItem_Click);
            // 
            // data1
            // 
            this.data1.AutoSize = true;
            this.data1.Location = new System.Drawing.Point(5, 19);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(35, 13);
            this.data1.TabIndex = 2;
            this.data1.Text = "label3";
            // 
            // dzien1
            // 
            this.dzien1.AutoSize = true;
            this.dzien1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzien1.Location = new System.Drawing.Point(3, 3);
            this.dzien1.Name = "dzien1";
            this.dzien1.Size = new System.Drawing.Size(46, 16);
            this.dzien1.TabIndex = 2;
            this.dzien1.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Controls.Add(this.data2);
            this.panel2.Controls.Add(this.dzien2);
            this.panel2.Location = new System.Drawing.Point(175, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 395);
            this.panel2.TabIndex = 3;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView2.ContextMenuStrip = this.contextMenuStrip1;
            this.listView2.FullRowSelect = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 46);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(149, 344);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zdarzenia:";
            this.columnHeader2.Width = 140;
            // 
            // data2
            // 
            this.data2.AutoSize = true;
            this.data2.Location = new System.Drawing.Point(5, 19);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(35, 13);
            this.data2.TabIndex = 2;
            this.data2.Text = "label3";
            // 
            // dzien2
            // 
            this.dzien2.AutoSize = true;
            this.dzien2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzien2.Location = new System.Drawing.Point(3, 3);
            this.dzien2.Name = "dzien2";
            this.dzien2.Size = new System.Drawing.Size(46, 16);
            this.dzien2.TabIndex = 2;
            this.dzien2.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.listView3);
            this.panel3.Controls.Add(this.data3);
            this.panel3.Controls.Add(this.dzien3);
            this.panel3.Location = new System.Drawing.Point(338, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 395);
            this.panel3.TabIndex = 3;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listView3.ContextMenuStrip = this.contextMenuStrip1;
            this.listView3.FullRowSelect = true;
            this.listView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(3, 46);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(149, 344);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Zdarzenia:";
            this.columnHeader3.Width = 140;
            // 
            // data3
            // 
            this.data3.AutoSize = true;
            this.data3.Location = new System.Drawing.Point(5, 19);
            this.data3.Name = "data3";
            this.data3.Size = new System.Drawing.Size(35, 13);
            this.data3.TabIndex = 2;
            this.data3.Text = "label3";
            // 
            // dzien3
            // 
            this.dzien3.AutoSize = true;
            this.dzien3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzien3.Location = new System.Drawing.Point(3, 3);
            this.dzien3.Name = "dzien3";
            this.dzien3.Size = new System.Drawing.Size(46, 16);
            this.dzien3.TabIndex = 2;
            this.dzien3.Text = "label2";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.listView4);
            this.panel4.Controls.Add(this.data4);
            this.panel4.Controls.Add(this.dzien4);
            this.panel4.Location = new System.Drawing.Point(501, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(157, 395);
            this.panel4.TabIndex = 3;
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listView4.ContextMenuStrip = this.contextMenuStrip1;
            this.listView4.FullRowSelect = true;
            this.listView4.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(3, 46);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(149, 344);
            this.listView4.TabIndex = 2;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Zdarzenia:";
            this.columnHeader4.Width = 140;
            // 
            // data4
            // 
            this.data4.AutoSize = true;
            this.data4.Location = new System.Drawing.Point(5, 19);
            this.data4.Name = "data4";
            this.data4.Size = new System.Drawing.Size(35, 13);
            this.data4.TabIndex = 2;
            this.data4.Text = "label3";
            // 
            // dzien4
            // 
            this.dzien4.AutoSize = true;
            this.dzien4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzien4.Location = new System.Drawing.Point(3, 3);
            this.dzien4.Name = "dzien4";
            this.dzien4.Size = new System.Drawing.Size(46, 16);
            this.dzien4.TabIndex = 2;
            this.dzien4.Text = "label2";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.listView5);
            this.panel5.Controls.Add(this.data5);
            this.panel5.Controls.Add(this.dzien5);
            this.panel5.Location = new System.Drawing.Point(664, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(157, 395);
            this.panel5.TabIndex = 3;
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.listView5.ContextMenuStrip = this.contextMenuStrip1;
            this.listView5.FullRowSelect = true;
            this.listView5.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(3, 46);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(149, 344);
            this.listView5.TabIndex = 2;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Zdarzenia:";
            this.columnHeader5.Width = 140;
            // 
            // data5
            // 
            this.data5.AutoSize = true;
            this.data5.Location = new System.Drawing.Point(5, 19);
            this.data5.Name = "data5";
            this.data5.Size = new System.Drawing.Size(35, 13);
            this.data5.TabIndex = 2;
            this.data5.Text = "label3";
            // 
            // dzien5
            // 
            this.dzien5.AutoSize = true;
            this.dzien5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzien5.Location = new System.Drawing.Point(3, 3);
            this.dzien5.Name = "dzien5";
            this.dzien5.Size = new System.Drawing.Size(46, 16);
            this.dzien5.TabIndex = 2;
            this.dzien5.Text = "label2";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.listView6);
            this.panel6.Controls.Add(this.data6);
            this.panel6.Controls.Add(this.dzien6);
            this.panel6.Location = new System.Drawing.Point(827, 93);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(157, 395);
            this.panel6.TabIndex = 3;
            // 
            // listView6
            // 
            this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listView6.ContextMenuStrip = this.contextMenuStrip1;
            this.listView6.FullRowSelect = true;
            this.listView6.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView6.HideSelection = false;
            this.listView6.Location = new System.Drawing.Point(3, 46);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(149, 344);
            this.listView6.TabIndex = 2;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Zdarzenia:";
            this.columnHeader6.Width = 140;
            // 
            // data6
            // 
            this.data6.AutoSize = true;
            this.data6.Location = new System.Drawing.Point(5, 19);
            this.data6.Name = "data6";
            this.data6.Size = new System.Drawing.Size(35, 13);
            this.data6.TabIndex = 2;
            this.data6.Text = "label3";
            // 
            // dzien6
            // 
            this.dzien6.AutoSize = true;
            this.dzien6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzien6.Location = new System.Drawing.Point(3, 3);
            this.dzien6.Name = "dzien6";
            this.dzien6.Size = new System.Drawing.Size(46, 16);
            this.dzien6.TabIndex = 2;
            this.dzien6.Text = "label2";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.listView7);
            this.panel7.Controls.Add(this.data7);
            this.panel7.Controls.Add(this.dzien7);
            this.panel7.Location = new System.Drawing.Point(990, 93);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(157, 395);
            this.panel7.TabIndex = 4;
            // 
            // listView7
            // 
            this.listView7.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.listView7.ContextMenuStrip = this.contextMenuStrip1;
            this.listView7.FullRowSelect = true;
            this.listView7.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView7.HideSelection = false;
            this.listView7.Location = new System.Drawing.Point(3, 46);
            this.listView7.Name = "listView7";
            this.listView7.Size = new System.Drawing.Size(149, 344);
            this.listView7.TabIndex = 2;
            this.listView7.UseCompatibleStateImageBehavior = false;
            this.listView7.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Zdarzenia:";
            this.columnHeader7.Width = 140;
            // 
            // data7
            // 
            this.data7.AutoSize = true;
            this.data7.Location = new System.Drawing.Point(5, 19);
            this.data7.Name = "data7";
            this.data7.Size = new System.Drawing.Size(35, 13);
            this.data7.TabIndex = 2;
            this.data7.Text = "label3";
            // 
            // dzien7
            // 
            this.dzien7.AutoSize = true;
            this.dzien7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzien7.Location = new System.Drawing.Point(3, 3);
            this.dzien7.Name = "dzien7";
            this.dzien7.Size = new System.Drawing.Size(46, 16);
            this.dzien7.TabIndex = 2;
            this.dzien7.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 496);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Kalendarz na tydzień";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dzien1;
        private System.Windows.Forms.Label data1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label data2;
        private System.Windows.Forms.Label dzien2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label data3;
        private System.Windows.Forms.Label dzien3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label data4;
        private System.Windows.Forms.Label dzien4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label data5;
        private System.Windows.Forms.Label dzien5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label data6;
        private System.Windows.Forms.Label dzien6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListView listView7;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label data7;
        private System.Windows.Forms.Label dzien7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajZdarzenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńZdarzenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modyfikujZdarzenieToolStripMenuItem;
    }
}

