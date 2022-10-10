namespace OBKS_IZ
{
    partial class XOR
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
            this.button_apply = new System.Windows.Forms.Button();
            this.button_dec_copy = new System.Windows.Forms.Button();
            this.textBox_dec_output = new System.Windows.Forms.TextBox();
            this.textBox_dec_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_enc_copy = new System.Windows.Forms.Button();
            this.textBox_enc_output = new System.Windows.Forms.TextBox();
            this.textBox_enc_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_rand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(131, 41);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(97, 23);
            this.button_apply.TabIndex = 34;
            this.button_apply.Text = "Применить";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_dec_copy
            // 
            this.button_dec_copy.Location = new System.Drawing.Point(113, 262);
            this.button_dec_copy.Name = "button_dec_copy";
            this.button_dec_copy.Size = new System.Drawing.Size(109, 23);
            this.button_dec_copy.TabIndex = 33;
            this.button_dec_copy.Text = "Копировать";
            this.button_dec_copy.UseVisualStyleBackColor = true;
            this.button_dec_copy.Click += new System.EventHandler(this.button_dec_copy_Click);
            // 
            // textBox_dec_output
            // 
            this.textBox_dec_output.Enabled = false;
            this.textBox_dec_output.Location = new System.Drawing.Point(23, 234);
            this.textBox_dec_output.Name = "textBox_dec_output";
            this.textBox_dec_output.Size = new System.Drawing.Size(287, 22);
            this.textBox_dec_output.TabIndex = 32;
            // 
            // textBox_dec_input
            // 
            this.textBox_dec_input.Location = new System.Drawing.Point(23, 206);
            this.textBox_dec_input.Name = "textBox_dec_input";
            this.textBox_dec_input.Size = new System.Drawing.Size(287, 22);
            this.textBox_dec_input.TabIndex = 31;
            this.textBox_dec_input.TextChanged += new System.EventHandler(this.textBox_dec_input_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Расшифровать";
            // 
            // button_enc_copy
            // 
            this.button_enc_copy.Location = new System.Drawing.Point(113, 155);
            this.button_enc_copy.Name = "button_enc_copy";
            this.button_enc_copy.Size = new System.Drawing.Size(109, 23);
            this.button_enc_copy.TabIndex = 29;
            this.button_enc_copy.Text = "Копировать";
            this.button_enc_copy.UseVisualStyleBackColor = true;
            this.button_enc_copy.Click += new System.EventHandler(this.button_enc_copy_Click);
            // 
            // textBox_enc_output
            // 
            this.textBox_enc_output.Enabled = false;
            this.textBox_enc_output.Location = new System.Drawing.Point(23, 127);
            this.textBox_enc_output.Name = "textBox_enc_output";
            this.textBox_enc_output.Size = new System.Drawing.Size(287, 22);
            this.textBox_enc_output.TabIndex = 28;
            // 
            // textBox_enc_input
            // 
            this.textBox_enc_input.Location = new System.Drawing.Point(23, 99);
            this.textBox_enc_input.Name = "textBox_enc_input";
            this.textBox_enc_input.Size = new System.Drawing.Size(287, 22);
            this.textBox_enc_input.TabIndex = 27;
            this.textBox_enc_input.TextChanged += new System.EventHandler(this.textBox_enc_input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Зашифровать";
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(23, 42);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(102, 22);
            this.textBox_key.TabIndex = 25;
            this.textBox_key.TextChanged += new System.EventHandler(this.textBox_key_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ключ";
            // 
            // button_rand
            // 
            this.button_rand.Location = new System.Drawing.Point(234, 41);
            this.button_rand.Name = "button_rand";
            this.button_rand.Size = new System.Drawing.Size(76, 23);
            this.button_rand.TabIndex = 35;
            this.button_rand.Text = "Рандом";
            this.button_rand.UseVisualStyleBackColor = true;
            this.button_rand.Click += new System.EventHandler(this.button_rand_Click);
            // 
            // XOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 308);
            this.Controls.Add(this.button_rand);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.button_dec_copy);
            this.Controls.Add(this.textBox_dec_output);
            this.Controls.Add(this.textBox_dec_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_enc_copy);
            this.Controls.Add(this.textBox_enc_output);
            this.Controls.Add(this.textBox_enc_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.label1);
            this.Name = "XOR";
            this.Text = "XOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_dec_copy;
        private System.Windows.Forms.TextBox textBox_dec_output;
        private System.Windows.Forms.TextBox textBox_dec_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_enc_copy;
        private System.Windows.Forms.TextBox textBox_enc_output;
        private System.Windows.Forms.TextBox textBox_enc_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_rand;
    }
}