
namespace Tyuiu.LyaginVA.Sprint7.Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_LVA = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_LVA = new System.Windows.Forms.TextBox();
            this.buttonClose_LVA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LVA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_LVA
            // 
            this.pictureBoxAvatar_LVA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_LVA.Image")));
            this.pictureBoxAvatar_LVA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_LVA.Name = "pictureBoxAvatar_LVA";
            this.pictureBoxAvatar_LVA.Size = new System.Drawing.Size(226, 357);
            this.pictureBoxAvatar_LVA.TabIndex = 0;
            this.pictureBoxAvatar_LVA.TabStop = false;
            // 
            // textBoxInfo_LVA
            // 
            this.textBoxInfo_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfo_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo_LVA.Location = new System.Drawing.Point(245, 30);
            this.textBoxInfo_LVA.Multiline = true;
            this.textBoxInfo_LVA.Name = "textBoxInfo_LVA";
            this.textBoxInfo_LVA.ReadOnly = true;
            this.textBoxInfo_LVA.Size = new System.Drawing.Size(404, 356);
            this.textBoxInfo_LVA.TabIndex = 1;
            this.textBoxInfo_LVA.TabStop = false;
            this.textBoxInfo_LVA.Text = resources.GetString("textBoxInfo_LVA.Text");
            // 
            // buttonClose_LVA
            // 
            this.buttonClose_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose_LVA.Location = new System.Drawing.Point(532, 329);
            this.buttonClose_LVA.Name = "buttonClose_LVA";
            this.buttonClose_LVA.Size = new System.Drawing.Size(117, 40);
            this.buttonClose_LVA.TabIndex = 2;
            this.buttonClose_LVA.Text = "Ок";
            this.buttonClose_LVA.UseVisualStyleBackColor = true;
            this.buttonClose_LVA.Click += new System.EventHandler(this.buttonClose_LVA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 398);
            this.Controls.Add(this.buttonClose_LVA);
            this.Controls.Add(this.textBoxInfo_LVA);
            this.Controls.Add(this.pictureBoxAvatar_LVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_LVA;
        private System.Windows.Forms.TextBox textBoxInfo_LVA;
        private System.Windows.Forms.Button buttonClose_LVA;
    }
}