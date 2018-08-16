namespace Email
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
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.odbiorcaTxt = new System.Windows.Forms.TextBox();
            this.tematTxt = new System.Windows.Forms.TextBox();
            this.msgTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wyslijBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(279, 43);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(250, 22);
            this.emailTxt.TabIndex = 0;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(279, 83);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(250, 22);
            this.passTxt.TabIndex = 1;
            // 
            // odbiorcaTxt
            // 
            this.odbiorcaTxt.Location = new System.Drawing.Point(279, 198);
            this.odbiorcaTxt.Name = "odbiorcaTxt";
            this.odbiorcaTxt.Size = new System.Drawing.Size(250, 22);
            this.odbiorcaTxt.TabIndex = 2;
            // 
            // tematTxt
            // 
            this.tematTxt.Location = new System.Drawing.Point(279, 249);
            this.tematTxt.Name = "tematTxt";
            this.tematTxt.Size = new System.Drawing.Size(250, 22);
            this.tematTxt.TabIndex = 3;
            // 
            // msgTxt
            // 
            this.msgTxt.Location = new System.Drawing.Point(88, 340);
            this.msgTxt.Name = "msgTxt";
            this.msgTxt.Size = new System.Drawing.Size(441, 358);
            this.msgTxt.TabIndex = 4;
            this.msgTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Odbiorca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Temat:";
            // 
            // wyslijBtn
            // 
            this.wyslijBtn.Location = new System.Drawing.Point(88, 728);
            this.wyslijBtn.Name = "wyslijBtn";
            this.wyslijBtn.Size = new System.Drawing.Size(107, 31);
            this.wyslijBtn.TabIndex = 10;
            this.wyslijBtn.Text = "Wyślij";
            this.wyslijBtn.UseVisualStyleBackColor = true;
            this.wyslijBtn.Click += new System.EventHandler(this.wyslijBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 771);
            this.Controls.Add(this.wyslijBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msgTxt);
            this.Controls.Add(this.tematTxt);
            this.Controls.Add(this.odbiorcaTxt);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.emailTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox odbiorcaTxt;
        private System.Windows.Forms.TextBox tematTxt;
        private System.Windows.Forms.RichTextBox msgTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button wyslijBtn;
    }
}

