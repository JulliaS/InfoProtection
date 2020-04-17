namespace Task6
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
            this.textBoxP = new System.Windows.Forms.RichTextBox();
            this.textBoxG = new System.Windows.Forms.RichTextBox();
            this.textBoxK_B = new System.Windows.Forms.RichTextBox();
            this.inputMessage = new System.Windows.Forms.RichTextBox();
            this.decodedMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(185, 25);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(261, 57);
            this.textBoxP.TabIndex = 0;
            this.textBoxP.Text = "";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(185, 103);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(261, 57);
            this.textBoxG.TabIndex = 1;
            this.textBoxG.Text = "";
            // 
            // textBoxK_B
            // 
            this.textBoxK_B.Location = new System.Drawing.Point(185, 186);
            this.textBoxK_B.Name = "textBoxK_B";
            this.textBoxK_B.Size = new System.Drawing.Size(261, 57);
            this.textBoxK_B.TabIndex = 2;
            this.textBoxK_B.Text = "";
            // 
            // inputMessage
            // 
            this.inputMessage.Location = new System.Drawing.Point(185, 317);
            this.inputMessage.Name = "inputMessage";
            this.inputMessage.Size = new System.Drawing.Size(261, 93);
            this.inputMessage.TabIndex = 3;
            this.inputMessage.Text = "";
            // 
            // decodedMessage
            // 
            this.decodedMessage.Location = new System.Drawing.Point(751, 317);
            this.decodedMessage.Name = "decodedMessage";
            this.decodedMessage.Size = new System.Drawing.Size(261, 93);
            this.decodedMessage.TabIndex = 4;
            this.decodedMessage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 72);
            this.label1.TabIndex = 5;
            this.label1.Text = "Encrypted\r\nMessage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Random P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Random G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 72);
            this.label4.TabIndex = 8;
            this.label4.Text = "Private key\r\nfor B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(575, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 72);
            this.label5.TabIndex = 9;
            this.label5.Text = "Decrypted \r\nMessage";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "ENDCODE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(896, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 53);
            this.button2.TabIndex = 11;
            this.button2.Text = "DECODE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 495);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decodedMessage);
            this.Controls.Add(this.inputMessage);
            this.Controls.Add(this.textBoxK_B);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxP);
            this.Name = "Form1";
            this.Text = "Task6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxP;
        private System.Windows.Forms.RichTextBox textBoxG;
        private System.Windows.Forms.RichTextBox textBoxK_B;
        private System.Windows.Forms.RichTextBox inputMessage;
        private System.Windows.Forms.RichTextBox decodedMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

