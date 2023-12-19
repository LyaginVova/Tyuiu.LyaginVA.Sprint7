
namespace Tyuiu.LyaginVA.Sprint7.Project.V4
{
    partial class FormMain
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
            this.menuStripData_LVA = new System.Windows.Forms.MenuStrip();
            this.ToolStripAboutProgram_LVA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMove_LVA = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem_LVA = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem_LVA = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem_LVA = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem_LVA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripExit_LVA = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewData_LVA = new System.Windows.Forms.DataGridView();
            this.CodeBook_LVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_LVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre_LVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year_LVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor_LVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finished_LVA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBoxMoves_LVA = new System.Windows.Forms.GroupBox();
            this.buttonOpenData_LVA = new System.Windows.Forms.Button();
            this.buttonInfo_LVA = new System.Windows.Forms.Button();
            this.buttonAddBook_LVA = new System.Windows.Forms.Button();
            this.buttonSaveData_LVA = new System.Windows.Forms.Button();
            this.saveFileDialogData_LVA = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogData_LVA = new System.Windows.Forms.OpenFileDialog();
            this.menuStripData_LVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_LVA)).BeginInit();
            this.groupBoxMoves_LVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripData_LVA
            // 
            this.menuStripData_LVA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripData_LVA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripAboutProgram_LVA,
            this.ToolStripMove_LVA,
            this.ToolStripExit_LVA});
            this.menuStripData_LVA.Location = new System.Drawing.Point(0, 0);
            this.menuStripData_LVA.Name = "menuStripData_LVA";
            this.menuStripData_LVA.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripData_LVA.Size = new System.Drawing.Size(771, 24);
            this.menuStripData_LVA.TabIndex = 0;
            this.menuStripData_LVA.Text = "menuStrip_LVA";
            // 
            // ToolStripAboutProgram_LVA
            // 
            this.ToolStripAboutProgram_LVA.Name = "ToolStripAboutProgram_LVA";
            this.ToolStripAboutProgram_LVA.Size = new System.Drawing.Size(94, 20);
            this.ToolStripAboutProgram_LVA.Text = "О программе";
            this.ToolStripAboutProgram_LVA.Click += new System.EventHandler(this.ToolStripAboutProgram_LVA_Click);
            // 
            // ToolStripMove_LVA
            // 
            this.ToolStripMove_LVA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem_LVA,
            this.saveToolStripMenuItem_LVA,
            this.addToolStripMenuItem_LVA,
            this.infoToolStripMenuItem_LVA});
            this.ToolStripMove_LVA.Name = "ToolStripMove_LVA";
            this.ToolStripMove_LVA.Size = new System.Drawing.Size(70, 20);
            this.ToolStripMove_LVA.Text = "Действия";
            // 
            // openToolStripMenuItem_LVA
            // 
            this.openToolStripMenuItem_LVA.Name = "openToolStripMenuItem_LVA";
            this.openToolStripMenuItem_LVA.Size = new System.Drawing.Size(133, 22);
            this.openToolStripMenuItem_LVA.Text = "Открыть";
            this.openToolStripMenuItem_LVA.Click += new System.EventHandler(this.openToolStripMenuItem_LVA_Click);
            // 
            // saveToolStripMenuItem_LVA
            // 
            this.saveToolStripMenuItem_LVA.Name = "saveToolStripMenuItem_LVA";
            this.saveToolStripMenuItem_LVA.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem_LVA.Text = "Сохранить";
            this.saveToolStripMenuItem_LVA.Click += new System.EventHandler(this.saveToolStripMenuItem_LVA_Click);
            // 
            // addToolStripMenuItem_LVA
            // 
            this.addToolStripMenuItem_LVA.Name = "addToolStripMenuItem_LVA";
            this.addToolStripMenuItem_LVA.Size = new System.Drawing.Size(133, 22);
            this.addToolStripMenuItem_LVA.Text = "Добавить";
            this.addToolStripMenuItem_LVA.Click += new System.EventHandler(this.addToolStripMenuItem_LVA_Click);
            // 
            // infoToolStripMenuItem_LVA
            // 
            this.infoToolStripMenuItem_LVA.Name = "infoToolStripMenuItem_LVA";
            this.infoToolStripMenuItem_LVA.Size = new System.Drawing.Size(133, 22);
            this.infoToolStripMenuItem_LVA.Text = "Инфо";
            this.infoToolStripMenuItem_LVA.Click += new System.EventHandler(this.infoToolStripMenuItem_LVA_Click);
            // 
            // ToolStripExit_LVA
            // 
            this.ToolStripExit_LVA.Name = "ToolStripExit_LVA";
            this.ToolStripExit_LVA.Size = new System.Drawing.Size(54, 20);
            this.ToolStripExit_LVA.Text = "Выход";
            this.ToolStripExit_LVA.Click += new System.EventHandler(this.ToolStripExit_LVA_Click);
            // 
            // dataGridViewData_LVA
            // 
            this.dataGridViewData_LVA.AllowUserToAddRows = false;
            this.dataGridViewData_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewData_LVA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData_LVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_LVA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeBook_LVA,
            this.Book_LVA,
            this.Genre_LVA,
            this.Year_LVA,
            this.Autor_LVA,
            this.Finished_LVA});
            this.dataGridViewData_LVA.Location = new System.Drawing.Point(306, 26);
            this.dataGridViewData_LVA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewData_LVA.Name = "dataGridViewData_LVA";
            this.dataGridViewData_LVA.RowHeadersVisible = false;
            this.dataGridViewData_LVA.RowHeadersWidth = 51;
            this.dataGridViewData_LVA.RowTemplate.Height = 24;
            this.dataGridViewData_LVA.Size = new System.Drawing.Size(456, 178);
            this.dataGridViewData_LVA.TabIndex = 1;
            // 
            // CodeBook_LVA
            // 
            this.CodeBook_LVA.HeaderText = "Код книги";
            this.CodeBook_LVA.Name = "CodeBook_LVA";
            // 
            // Book_LVA
            // 
            this.Book_LVA.HeaderText = "Название";
            this.Book_LVA.MinimumWidth = 6;
            this.Book_LVA.Name = "Book_LVA";
            // 
            // Genre_LVA
            // 
            this.Genre_LVA.HeaderText = "Жанр";
            this.Genre_LVA.Name = "Genre_LVA";
            // 
            // Year_LVA
            // 
            this.Year_LVA.HeaderText = "Год издания";
            this.Year_LVA.MinimumWidth = 6;
            this.Year_LVA.Name = "Year_LVA";
            // 
            // Autor_LVA
            // 
            this.Autor_LVA.HeaderText = "Автор";
            this.Autor_LVA.MinimumWidth = 6;
            this.Autor_LVA.Name = "Autor_LVA";
            // 
            // Finished_LVA
            // 
            this.Finished_LVA.HeaderText = "Прочитано";
            this.Finished_LVA.MinimumWidth = 6;
            this.Finished_LVA.Name = "Finished_LVA";
            // 
            // groupBoxMoves_LVA
            // 
            this.groupBoxMoves_LVA.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxMoves_LVA.Controls.Add(this.buttonOpenData_LVA);
            this.groupBoxMoves_LVA.Controls.Add(this.buttonInfo_LVA);
            this.groupBoxMoves_LVA.Controls.Add(this.buttonAddBook_LVA);
            this.groupBoxMoves_LVA.Controls.Add(this.buttonSaveData_LVA);
            this.groupBoxMoves_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMoves_LVA.Location = new System.Drawing.Point(11, 26);
            this.groupBoxMoves_LVA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMoves_LVA.Name = "groupBoxMoves_LVA";
            this.groupBoxMoves_LVA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMoves_LVA.Size = new System.Drawing.Size(291, 229);
            this.groupBoxMoves_LVA.TabIndex = 2;
            this.groupBoxMoves_LVA.TabStop = false;
            this.groupBoxMoves_LVA.Text = "Панель действия";
            // 
            // buttonOpenData_LVA
            // 
            this.buttonOpenData_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenData_LVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonOpenData_LVA.Location = new System.Drawing.Point(4, 16);
            this.buttonOpenData_LVA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenData_LVA.Name = "buttonOpenData_LVA";
            this.buttonOpenData_LVA.Size = new System.Drawing.Size(281, 39);
            this.buttonOpenData_LVA.TabIndex = 0;
            this.buttonOpenData_LVA.Text = "Открыть базу данных";
            this.buttonOpenData_LVA.UseVisualStyleBackColor = true;
            this.buttonOpenData_LVA.Click += new System.EventHandler(this.buttonOpenData_LVA_Click);
            // 
            // buttonInfo_LVA
            // 
            this.buttonInfo_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_LVA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_LVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonInfo_LVA.Location = new System.Drawing.Point(4, 145);
            this.buttonInfo_LVA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo_LVA.Name = "buttonInfo_LVA";
            this.buttonInfo_LVA.Size = new System.Drawing.Size(281, 39);
            this.buttonInfo_LVA.TabIndex = 0;
            this.buttonInfo_LVA.Text = "Информация о разработчике программы";
            this.buttonInfo_LVA.UseVisualStyleBackColor = false;
            this.buttonInfo_LVA.Click += new System.EventHandler(this.buttonInfo_LVA_Click);
            // 
            // buttonAddBook_LVA
            // 
            this.buttonAddBook_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBook_LVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddBook_LVA.Location = new System.Drawing.Point(4, 102);
            this.buttonAddBook_LVA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddBook_LVA.Name = "buttonAddBook_LVA";
            this.buttonAddBook_LVA.Size = new System.Drawing.Size(281, 39);
            this.buttonAddBook_LVA.TabIndex = 0;
            this.buttonAddBook_LVA.Text = "Добавить книгу";
            this.buttonAddBook_LVA.UseVisualStyleBackColor = true;
            this.buttonAddBook_LVA.Click += new System.EventHandler(this.buttonAddBook_LVA_Click);
            // 
            // buttonSaveData_LVA
            // 
            this.buttonSaveData_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveData_LVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSaveData_LVA.Location = new System.Drawing.Point(4, 59);
            this.buttonSaveData_LVA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveData_LVA.Name = "buttonSaveData_LVA";
            this.buttonSaveData_LVA.Size = new System.Drawing.Size(281, 39);
            this.buttonSaveData_LVA.TabIndex = 0;
            this.buttonSaveData_LVA.Text = "Сохранить базу данных";
            this.buttonSaveData_LVA.UseVisualStyleBackColor = true;
            this.buttonSaveData_LVA.Click += new System.EventHandler(this.buttonSaveData_LVA_Click);
            // 
            // openFileDialogData_LVA
            // 
            this.openFileDialogData_LVA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 213);
            this.Controls.Add(this.groupBoxMoves_LVA);
            this.Controls.Add(this.dataGridViewData_LVA);
            this.Controls.Add(this.menuStripData_LVA);
            this.MainMenuStrip = this.menuStripData_LVA;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.menuStripData_LVA.ResumeLayout(false);
            this.menuStripData_LVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_LVA)).EndInit();
            this.groupBoxMoves_LVA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripData_LVA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMove_LVA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripAboutProgram_LVA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExit_LVA;
        private System.Windows.Forms.DataGridView dataGridViewData_LVA;
        private System.Windows.Forms.GroupBox groupBoxMoves_LVA;
        private System.Windows.Forms.Button buttonOpenData_LVA;
        private System.Windows.Forms.Button buttonInfo_LVA;
        private System.Windows.Forms.Button buttonAddBook_LVA;
        private System.Windows.Forms.Button buttonSaveData_LVA;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem_LVA;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem_LVA;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem_LVA;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem_LVA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogData_LVA;
        private System.Windows.Forms.OpenFileDialog openFileDialogData_LVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeBook_LVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_LVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre_LVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year_LVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor_LVA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finished_LVA;
    }
}

