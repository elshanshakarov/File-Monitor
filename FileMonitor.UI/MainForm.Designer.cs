namespace FileMonitor.UI
{
    partial class MainForm
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
            txtFolder = new TextBox();
            listLoaders = new ListBox();
            listFiles = new ListBox();
            dataGrid = new DataGridView();
            splitContainer1 = new SplitContainer();
            txtInterval = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFolder
            // 
            txtFolder.Font = new Font("Segoe UI", 12F);
            txtFolder.Location = new Point(12, 58);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(309, 34);
            txtFolder.TabIndex = 0;
            // 
            // listLoaders
            // 
            listLoaders.Font = new Font("Segoe UI", 12F);
            listLoaders.FormattingEnabled = true;
            listLoaders.ItemHeight = 28;
            listLoaders.Location = new Point(12, 236);
            listLoaders.Name = "listLoaders";
            listLoaders.Size = new Size(150, 88);
            listLoaders.TabIndex = 2;
            // 
            // listFiles
            // 
            listFiles.Font = new Font("Segoe UI", 12F);
            listFiles.FormattingEnabled = true;
            listFiles.ItemHeight = 28;
            listFiles.Location = new Point(12, 406);
            listFiles.Name = "listFiles";
            listFiles.Size = new Size(150, 88);
            listFiles.TabIndex = 3;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(0, 0);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(1279, 1055);
            dataGrid.TabIndex = 4;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtInterval);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtFolder);
            splitContainer1.Panel1.Controls.Add(listFiles);
            splitContainer1.Panel1.Controls.Add(listLoaders);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGrid);
            splitContainer1.Size = new Size(1924, 1055);
            splitContainer1.SplitterDistance = 641;
            splitContainer1.TabIndex = 5;
            // 
            // txtInterval
            // 
            txtInterval.Font = new Font("Segoe UI", 12F);
            txtInterval.Location = new Point(12, 147);
            txtInterval.Name = "txtInterval";
            txtInterval.ReadOnly = true;
            txtInterval.Size = new Size(309, 34);
            txtInterval.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 375);
            label4.Name = "label4";
            label4.Size = new Size(413, 28);
            label4.TabIndex = 7;
            label4.Text = "File names (Tracking olunmuş faylların siyahısı)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(556, 28);
            label3.TabIndex = 6;
            label3.Text = "File extensions (Qovluqda hansı uzantılı fayllar tracking olunur)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(452, 28);
            label2.TabIndex = 5;
            label2.Text = "Milliseconds (Qovluq neçə saniyədən bir yoxlanılır)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(270, 28);
            label1.TabIndex = 4;
            label1.Text = "Path (İzlənilən qovluğun yolu)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFolder;
        private ListBox listLoaders;
        private ListBox listFiles;
        private DataGridView dataGrid;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox txtInterval;
    }
}
