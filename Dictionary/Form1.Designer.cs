namespace Dictionary
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnglishWord = new System.Windows.Forms.TextBox();
            this.txtTranslate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_EnglishWord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EnglishWord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "English Word";
            // 
            // txtEnglishWord
            // 
            this.txtEnglishWord.Location = new System.Drawing.Point(314, 45);
            this.txtEnglishWord.Name = "txtEnglishWord";
            this.txtEnglishWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnglishWord.Size = new System.Drawing.Size(190, 23);
            this.txtEnglishWord.TabIndex = 1;
            this.txtEnglishWord.TextChanged += new System.EventHandler(this.txtEnglishWord_TextChanged);
            // 
            // txtTranslate
            // 
            this.txtTranslate.Location = new System.Drawing.Point(12, 45);
            this.txtTranslate.Multiline = true;
            this.txtTranslate.Name = "txtTranslate";
            this.txtTranslate.Size = new System.Drawing.Size(296, 292);
            this.txtTranslate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ترجمه";
            // 
            // dataGridView_EnglishWord
            // 
            this.dataGridView_EnglishWord.AllowUserToAddRows = false;
            this.dataGridView_EnglishWord.AllowUserToDeleteRows = false;
            this.dataGridView_EnglishWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EnglishWord.Location = new System.Drawing.Point(314, 74);
            this.dataGridView_EnglishWord.Name = "dataGridView_EnglishWord";
            this.dataGridView_EnglishWord.ReadOnly = true;
            this.dataGridView_EnglishWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_EnglishWord.RowTemplate.Height = 25;
            this.dataGridView_EnglishWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_EnglishWord.Size = new System.Drawing.Size(190, 263);
            this.dataGridView_EnglishWord.TabIndex = 4;
            this.dataGridView_EnglishWord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_EnglishWord_CellContentClick);
            this.dataGridView_EnglishWord.CurrentCellChanged += new System.EventHandler(this.dataGridView_EnglishWord_CurrentCellChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 349);
            this.Controls.Add(this.dataGridView_EnglishWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTranslate);
            this.Controls.Add(this.txtEnglishWord);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "دیکشنری";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EnglishWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtEnglishWord;
        private TextBox txtTranslate;
        private Label label2;
        private DataGridView dataGridView_EnglishWord;
    }
}