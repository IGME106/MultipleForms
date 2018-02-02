namespace MultipleForms
{
    partial class MenuForm
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
            this.BtnStartMenuForm = new System.Windows.Forms.Button();
            this.TxtBLowerValueMenuForm = new System.Windows.Forms.TextBox();
            this.LblLowerValueMenuForm = new System.Windows.Forms.Label();
            this.LblUpperValueMenuFrm = new System.Windows.Forms.Label();
            this.TxtBUpperValueMenuForm = new System.Windows.Forms.TextBox();
            this.RichTxtBDescrMenuForm = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnStartMenuForm
            // 
            this.BtnStartMenuForm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartMenuForm.Location = new System.Drawing.Point(52, 226);
            this.BtnStartMenuForm.Name = "BtnStartMenuForm";
            this.BtnStartMenuForm.Size = new System.Drawing.Size(334, 56);
            this.BtnStartMenuForm.TabIndex = 0;
            this.BtnStartMenuForm.Text = "START GAME";
            this.BtnStartMenuForm.UseVisualStyleBackColor = true;
            this.BtnStartMenuForm.Click += new System.EventHandler(this.BtnStartMenuForm_Click);
            // 
            // TxtBLowerValueMenuForm
            // 
            this.TxtBLowerValueMenuForm.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBLowerValueMenuForm.Location = new System.Drawing.Point(241, 135);
            this.TxtBLowerValueMenuForm.Name = "TxtBLowerValueMenuForm";
            this.TxtBLowerValueMenuForm.Size = new System.Drawing.Size(100, 31);
            this.TxtBLowerValueMenuForm.TabIndex = 1;
            // 
            // LblLowerValueMenuForm
            // 
            this.LblLowerValueMenuForm.AutoSize = true;
            this.LblLowerValueMenuForm.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLowerValueMenuForm.Location = new System.Drawing.Point(85, 135);
            this.LblLowerValueMenuForm.Name = "LblLowerValueMenuForm";
            this.LblLowerValueMenuForm.Size = new System.Drawing.Size(109, 24);
            this.LblLowerValueMenuForm.TabIndex = 2;
            this.LblLowerValueMenuForm.Text = "Lower Value";
            // 
            // LblUpperValueMenuFrm
            // 
            this.LblUpperValueMenuFrm.AutoSize = true;
            this.LblUpperValueMenuFrm.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUpperValueMenuFrm.Location = new System.Drawing.Point(86, 172);
            this.LblUpperValueMenuFrm.Name = "LblUpperValueMenuFrm";
            this.LblUpperValueMenuFrm.Size = new System.Drawing.Size(108, 24);
            this.LblUpperValueMenuFrm.TabIndex = 3;
            this.LblUpperValueMenuFrm.Text = "Upper Value";
            // 
            // TxtBUpperValueMenuForm
            // 
            this.TxtBUpperValueMenuForm.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBUpperValueMenuForm.Location = new System.Drawing.Point(241, 172);
            this.TxtBUpperValueMenuForm.Name = "TxtBUpperValueMenuForm";
            this.TxtBUpperValueMenuForm.Size = new System.Drawing.Size(100, 31);
            this.TxtBUpperValueMenuForm.TabIndex = 4;
            // 
            // RichTxtBDescrMenuForm
            // 
            this.RichTxtBDescrMenuForm.BackColor = System.Drawing.SystemColors.Control;
            this.RichTxtBDescrMenuForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTxtBDescrMenuForm.Font = new System.Drawing.Font("Comic Sans MS", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTxtBDescrMenuForm.Location = new System.Drawing.Point(28, 29);
            this.RichTxtBDescrMenuForm.Name = "RichTxtBDescrMenuForm";
            this.RichTxtBDescrMenuForm.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichTxtBDescrMenuForm.Size = new System.Drawing.Size(378, 80);
            this.RichTxtBDescrMenuForm.TabIndex = 5;
            this.RichTxtBDescrMenuForm.Text = "Welcome to the number guessing game.  To play the game enter your lower and upper" +
    " ranges and click the Start button.";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 303);
            this.Controls.Add(this.RichTxtBDescrMenuForm);
            this.Controls.Add(this.TxtBUpperValueMenuForm);
            this.Controls.Add(this.LblUpperValueMenuFrm);
            this.Controls.Add(this.LblLowerValueMenuForm);
            this.Controls.Add(this.TxtBLowerValueMenuForm);
            this.Controls.Add(this.BtnStartMenuForm);
            this.MaximumSize = new System.Drawing.Size(450, 350);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Guessing Game";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartMenuForm;
        private System.Windows.Forms.TextBox TxtBLowerValueMenuForm;
        private System.Windows.Forms.Label LblLowerValueMenuForm;
        private System.Windows.Forms.Label LblUpperValueMenuFrm;
        private System.Windows.Forms.TextBox TxtBUpperValueMenuForm;
        private System.Windows.Forms.RichTextBox RichTxtBDescrMenuForm;
    }
}

