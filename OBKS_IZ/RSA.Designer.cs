namespace OBKS_IZ
{
    partial class RSA
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
            this.button_rand = new System.Windows.Forms.Button();
            this.button_dec_copy = new System.Windows.Forms.Button();
            this.textBox_dec_output = new System.Windows.Forms.TextBox();
            this.textBox_dec_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_enc_copy = new System.Windows.Forms.Button();
            this.textBox_enc_output = new System.Windows.Forms.TextBox();
            this.textBox_enc_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_o_key_e = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_c_key1_d = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_c_key2_d = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_c_key1_n = new System.Windows.Forms.TextBox();
            this.textBox_c_key2_n = new System.Windows.Forms.TextBox();
            this.textBox_o_key_n = new System.Windows.Forms.TextBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_dec_output2 = new System.Windows.Forms.TextBox();
            this.textBox_dec_input2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_rand
            // 
            this.button_rand.Location = new System.Drawing.Point(346, 108);
            this.button_rand.Name = "button_rand";
            this.button_rand.Size = new System.Drawing.Size(76, 23);
            this.button_rand.TabIndex = 47;
            this.button_rand.Text = "Рандом";
            this.button_rand.UseVisualStyleBackColor = true;
            this.button_rand.Click += new System.EventHandler(this.button_rand_Click);
            // 
            // button_dec_copy
            // 
            this.button_dec_copy.Location = new System.Drawing.Point(117, 329);
            this.button_dec_copy.Name = "button_dec_copy";
            this.button_dec_copy.Size = new System.Drawing.Size(109, 23);
            this.button_dec_copy.TabIndex = 45;
            this.button_dec_copy.Text = "Копировать";
            this.button_dec_copy.UseVisualStyleBackColor = true;
            this.button_dec_copy.Click += new System.EventHandler(this.button_dec_copy_Click);
            // 
            // textBox_dec_output
            // 
            this.textBox_dec_output.Enabled = false;
            this.textBox_dec_output.Location = new System.Drawing.Point(27, 301);
            this.textBox_dec_output.Name = "textBox_dec_output";
            this.textBox_dec_output.Size = new System.Drawing.Size(287, 22);
            this.textBox_dec_output.TabIndex = 44;
            // 
            // textBox_dec_input
            // 
            this.textBox_dec_input.Location = new System.Drawing.Point(27, 273);
            this.textBox_dec_input.Name = "textBox_dec_input";
            this.textBox_dec_input.Size = new System.Drawing.Size(287, 22);
            this.textBox_dec_input.TabIndex = 43;
            this.textBox_dec_input.TextChanged += new System.EventHandler(this.textBox_dec_input_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Расшифровать";
            // 
            // button_enc_copy
            // 
            this.button_enc_copy.Location = new System.Drawing.Point(117, 222);
            this.button_enc_copy.Name = "button_enc_copy";
            this.button_enc_copy.Size = new System.Drawing.Size(109, 23);
            this.button_enc_copy.TabIndex = 41;
            this.button_enc_copy.Text = "Копировать";
            this.button_enc_copy.UseVisualStyleBackColor = true;
            this.button_enc_copy.Click += new System.EventHandler(this.button_enc_copy_Click);
            // 
            // textBox_enc_output
            // 
            this.textBox_enc_output.Enabled = false;
            this.textBox_enc_output.Location = new System.Drawing.Point(27, 194);
            this.textBox_enc_output.Name = "textBox_enc_output";
            this.textBox_enc_output.Size = new System.Drawing.Size(287, 22);
            this.textBox_enc_output.TabIndex = 40;
            // 
            // textBox_enc_input
            // 
            this.textBox_enc_input.Location = new System.Drawing.Point(27, 166);
            this.textBox_enc_input.Name = "textBox_enc_input";
            this.textBox_enc_input.Size = new System.Drawing.Size(287, 22);
            this.textBox_enc_input.TabIndex = 39;
            this.textBox_enc_input.TextChanged += new System.EventHandler(this.textBox_enc_input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Зашифровать";
            // 
            // textBox_o_key_e
            // 
            this.textBox_o_key_e.Location = new System.Drawing.Point(27, 109);
            this.textBox_o_key_e.Name = "textBox_o_key_e";
            this.textBox_o_key_e.Size = new System.Drawing.Size(102, 22);
            this.textBox_o_key_e.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Открытый ключ";
            // 
            // textBox_c_key1_d
            // 
            this.textBox_c_key1_d.Location = new System.Drawing.Point(334, 276);
            this.textBox_c_key1_d.Name = "textBox_c_key1_d";
            this.textBox_c_key1_d.Size = new System.Drawing.Size(102, 22);
            this.textBox_c_key1_d.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Закрытый ключ 1";
            // 
            // textBox_c_key2_d
            // 
            this.textBox_c_key2_d.Location = new System.Drawing.Point(334, 383);
            this.textBox_c_key2_d.Name = "textBox_c_key2_d";
            this.textBox_c_key2_d.Size = new System.Drawing.Size(102, 22);
            this.textBox_c_key2_d.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Закрытый ключ 2";
            // 
            // textBox_c_key1_n
            // 
            this.textBox_c_key1_n.Location = new System.Drawing.Point(334, 304);
            this.textBox_c_key1_n.Name = "textBox_c_key1_n";
            this.textBox_c_key1_n.Size = new System.Drawing.Size(102, 22);
            this.textBox_c_key1_n.TabIndex = 52;
            // 
            // textBox_c_key2_n
            // 
            this.textBox_c_key2_n.Location = new System.Drawing.Point(334, 411);
            this.textBox_c_key2_n.Name = "textBox_c_key2_n";
            this.textBox_c_key2_n.Size = new System.Drawing.Size(102, 22);
            this.textBox_c_key2_n.TabIndex = 53;
            // 
            // textBox_o_key_n
            // 
            this.textBox_o_key_n.Location = new System.Drawing.Point(135, 109);
            this.textBox_o_key_n.Name = "textBox_o_key_n";
            this.textBox_o_key_n.Size = new System.Drawing.Size(102, 22);
            this.textBox_o_key_n.TabIndex = 54;
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(334, 38);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(97, 23);
            this.button_apply.TabIndex = 46;
            this.button_apply.Text = "Применить";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(41, 38);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(70, 22);
            this.textBox_p.TabIndex = 55;
            this.textBox_p.TextChanged += new System.EventHandler(this.textBox_p_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "p";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "q";
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(135, 38);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(70, 22);
            this.textBox_q.TabIndex = 57;
            this.textBox_q.TextChanged += new System.EventHandler(this.textBox_q_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "e";
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(239, 38);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(70, 22);
            this.textBox_e.TabIndex = 59;
            this.textBox_e.TextChanged += new System.EventHandler(this.textBox_e_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "Копировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_dec_output2
            // 
            this.textBox_dec_output2.Enabled = false;
            this.textBox_dec_output2.Location = new System.Drawing.Point(27, 411);
            this.textBox_dec_output2.Name = "textBox_dec_output2";
            this.textBox_dec_output2.Size = new System.Drawing.Size(287, 22);
            this.textBox_dec_output2.TabIndex = 63;
            // 
            // textBox_dec_input2
            // 
            this.textBox_dec_input2.Location = new System.Drawing.Point(27, 383);
            this.textBox_dec_input2.Name = "textBox_dec_input2";
            this.textBox_dec_input2.Size = new System.Drawing.Size(287, 22);
            this.textBox_dec_input2.TabIndex = 62;
            this.textBox_dec_input2.TextChanged += new System.EventHandler(this.textBox_dec_input2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "Расшифровать";
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_dec_output2);
            this.Controls.Add(this.textBox_dec_input2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.textBox_o_key_n);
            this.Controls.Add(this.textBox_c_key2_n);
            this.Controls.Add(this.textBox_c_key1_n);
            this.Controls.Add(this.textBox_c_key2_d);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_c_key1_d);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.textBox_o_key_e);
            this.Controls.Add(this.label1);
            this.Name = "RSA";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_rand;
        private System.Windows.Forms.Button button_dec_copy;
        private System.Windows.Forms.TextBox textBox_dec_output;
        private System.Windows.Forms.TextBox textBox_dec_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_enc_copy;
        private System.Windows.Forms.TextBox textBox_enc_output;
        private System.Windows.Forms.TextBox textBox_enc_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_o_key_e;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_c_key1_d;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_c_key2_d;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_c_key1_n;
        private System.Windows.Forms.TextBox textBox_c_key2_n;
        private System.Windows.Forms.TextBox textBox_o_key_n;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_dec_output2;
        private System.Windows.Forms.TextBox textBox_dec_input2;
        private System.Windows.Forms.Label label9;
    }
}