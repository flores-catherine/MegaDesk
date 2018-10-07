namespace MegaDesk
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calcQuote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelQuote = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Depth";
            // 
            // calcQuote
            // 
            this.calcQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcQuote.Location = new System.Drawing.Point(212, 219);
            this.calcQuote.Name = "calcQuote";
            this.calcQuote.Size = new System.Drawing.Size(148, 38);
            this.calcQuote.TabIndex = 3;
            this.calcQuote.Text = "Calculate Quote";
            this.calcQuote.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter width and height to calculate quote.";
            // 
            // cancelQuote
            // 
            this.cancelQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuote.Location = new System.Drawing.Point(92, 219);
            this.cancelQuote.Name = "cancelQuote";
            this.cancelQuote.Size = new System.Drawing.Size(80, 38);
            this.cancelQuote.TabIndex = 4;
            this.cancelQuote.Text = "Cancel";
            this.cancelQuote.UseVisualStyleBackColor = true;
            this.cancelQuote.Click += new System.EventHandler(this.cancelQuote_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.AutoSize = true;
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.ForeColor = System.Drawing.Color.Red;
            this.MessageBox.Location = new System.Drawing.Point(42, 275);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(0, 20);
            this.MessageBox.TabIndex = 4;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthTextBox.Location = new System.Drawing.Point(240, 90);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(120, 32);
            this.WidthTextBox.TabIndex = 1;
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthBox_Validating);
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthTextBox.Location = new System.Drawing.Point(240, 142);
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(120, 32);
            this.DepthTextBox.TabIndex = 2;
            this.DepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthTextBox_KeyPress);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 339);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelQuote);
            this.Controls.Add(this.calcQuote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcQuote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelQuote;
        private System.Windows.Forms.Label MessageBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox DepthTextBox;
    }
}