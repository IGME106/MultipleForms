namespace MultipleForms
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.LblGuessGameForm = new System.Windows.Forms.Label();
            this.TxtBGuessGameForm = new System.Windows.Forms.TextBox();
            this.ListBoxGameForm = new System.Windows.Forms.ListBox();
            this.BtnOKGameForm = new System.Windows.Forms.Button();
            this.ProgressBarGameForm = new System.Windows.Forms.ProgressBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblGuessGameForm
            // 
            this.LblGuessGameForm.AutoSize = true;
            this.LblGuessGameForm.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGuessGameForm.Location = new System.Drawing.Point(66, 56);
            this.LblGuessGameForm.Name = "LblGuessGameForm";
            this.LblGuessGameForm.Size = new System.Drawing.Size(57, 24);
            this.LblGuessGameForm.TabIndex = 0;
            this.LblGuessGameForm.Text = "Guess";
            // 
            // TxtBGuessGameForm
            // 
            this.TxtBGuessGameForm.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBGuessGameForm.Location = new System.Drawing.Point(129, 53);
            this.TxtBGuessGameForm.Name = "TxtBGuessGameForm";
            this.TxtBGuessGameForm.Size = new System.Drawing.Size(100, 31);
            this.TxtBGuessGameForm.TabIndex = 1;
            // 
            // ListBoxGameForm
            // 
            this.ListBoxGameForm.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxGameForm.FormattingEnabled = true;
            this.ListBoxGameForm.ItemHeight = 24;
            this.ListBoxGameForm.Location = new System.Drawing.Point(50, 156);
            this.ListBoxGameForm.Name = "ListBoxGameForm";
            this.ListBoxGameForm.Size = new System.Drawing.Size(395, 196);
            this.ListBoxGameForm.TabIndex = 2;
            // 
            // BtnOKGameForm
            // 
            this.BtnOKGameForm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOKGameForm.Location = new System.Drawing.Point(299, 49);
            this.BtnOKGameForm.Name = "BtnOKGameForm";
            this.BtnOKGameForm.Size = new System.Drawing.Size(130, 37);
            this.BtnOKGameForm.TabIndex = 3;
            this.BtnOKGameForm.Text = "OK";
            this.BtnOKGameForm.UseVisualStyleBackColor = true;
            this.BtnOKGameForm.Click += new System.EventHandler(this.BtnOKGameForm_Click);
            // 
            // ProgressBarGameForm
            // 
            this.ProgressBarGameForm.Location = new System.Drawing.Point(90, 107);
            this.ProgressBarGameForm.Name = "ProgressBarGameForm";
            this.ProgressBarGameForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressBarGameForm.Size = new System.Drawing.Size(326, 23);
            this.ProgressBarGameForm.TabIndex = 4;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 384);
            this.Controls.Add(this.ProgressBarGameForm);
            this.Controls.Add(this.BtnOKGameForm);
            this.Controls.Add(this.ListBoxGameForm);
            this.Controls.Add(this.TxtBGuessGameForm);
            this.Controls.Add(this.LblGuessGameForm);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGuessGameForm;
        private System.Windows.Forms.TextBox TxtBGuessGameForm;
        private System.Windows.Forms.ListBox ListBoxGameForm;
        private System.Windows.Forms.Button BtnOKGameForm;
        private System.Windows.Forms.ProgressBar ProgressBarGameForm;
        private System.Windows.Forms.Timer Timer1;
    }
}