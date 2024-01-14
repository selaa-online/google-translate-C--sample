
namespace googletranslate
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            from = new System.Windows.Forms.TextBox();
            to = new System.Windows.Forms.TextBox();
            input = new System.Windows.Forms.TextBox();
            output = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(75, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "from";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(497, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(75, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Input";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(482, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Output";
            // 
            // from
            // 
            from.Location = new System.Drawing.Point(123, 34);
            from.Name = "from";
            from.Size = new System.Drawing.Size(100, 23);
            from.TabIndex = 4;
            from.TextChanged += from_TextChanged;
            // 
            // to
            // 
            to.Location = new System.Drawing.Point(538, 34);
            to.Name = "to";
            to.Size = new System.Drawing.Size(100, 23);
            to.TabIndex = 5;
            // 
            // input
            // 
            input.Location = new System.Drawing.Point(123, 105);
            input.Multiline = true;
            input.Name = "input";
            input.Size = new System.Drawing.Size(279, 226);
            input.TabIndex = 6;
            // 
            // output
            // 
            output.Location = new System.Drawing.Point(533, 102);
            output.Multiline = true;
            output.Name = "output";
            output.Size = new System.Drawing.Size(279, 226);
            output.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(440, 219);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Translate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(829, 450);
            Controls.Add(button1);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(to);
            Controls.Add(from);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button1;
    }
}

