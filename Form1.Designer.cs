namespace Diabetes_Alarm
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialogPath = new System.Windows.Forms.SaveFileDialog();
            this.buttonPathBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPath.Location = new System.Drawing.Point(77, 23);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPath.Size = new System.Drawing.Size(303, 26);
            this.textBoxPath.TabIndex = 0;
            this.textBoxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.Location = new System.Drawing.Point(386, 29);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(72, 20);
            this.path.TabIndex = 1;
            this.path.Text = "ملف البيانات";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(67, 82);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 2;
            // 
            // saveFileDialogPath
            // 
            this.saveFileDialogPath.DefaultExt = "csv";
            this.saveFileDialogPath.FileName = "ملف البيانات";
            this.saveFileDialogPath.Filter = "Data Files (*.csv)|*.csv";
            this.saveFileDialogPath.Title = "ملف البيانات";
            // 
            // buttonPathBrowse
            // 
            this.buttonPathBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPathBrowse.Location = new System.Drawing.Point(11, 23);
            this.buttonPathBrowse.Name = "buttonPathBrowse";
            this.buttonPathBrowse.Size = new System.Drawing.Size(60, 26);
            this.buttonPathBrowse.TabIndex = 3;
            this.buttonPathBrowse.Text = "تصفح";
            this.buttonPathBrowse.UseVisualStyleBackColor = true;
            this.buttonPathBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 382);
            this.Controls.Add(this.buttonPathBrowse);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.textBoxPath);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPath;
        private System.Windows.Forms.Button buttonPathBrowse;
    }
}

