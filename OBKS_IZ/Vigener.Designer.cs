namespace OBKS_IZ
{
    partial class Vigenere
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
            this.comboBox_lang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.table_letters = new System.Windows.Forms.TableLayoutPanel();
            this.picture_table = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_table)).BeginInit();
            this.SuspendLayout();
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(212, 111);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(97, 23);
            this.button_apply.TabIndex = 23;
            this.button_apply.Text = "Применить";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_dec_copy
            // 
            this.button_dec_copy.Location = new System.Drawing.Point(112, 331);
            this.button_dec_copy.Name = "button_dec_copy";
            this.button_dec_copy.Size = new System.Drawing.Size(109, 23);
            this.button_dec_copy.TabIndex = 22;
            this.button_dec_copy.Text = "Копировать";
            this.button_dec_copy.UseVisualStyleBackColor = true;
            this.button_dec_copy.Click += new System.EventHandler(this.button_dec_copy_Click);
            // 
            // textBox_dec_output
            // 
            this.textBox_dec_output.Enabled = false;
            this.textBox_dec_output.Location = new System.Drawing.Point(22, 303);
            this.textBox_dec_output.Name = "textBox_dec_output";
            this.textBox_dec_output.Size = new System.Drawing.Size(287, 22);
            this.textBox_dec_output.TabIndex = 21;
            // 
            // textBox_dec_input
            // 
            this.textBox_dec_input.Location = new System.Drawing.Point(22, 275);
            this.textBox_dec_input.Name = "textBox_dec_input";
            this.textBox_dec_input.Size = new System.Drawing.Size(287, 22);
            this.textBox_dec_input.TabIndex = 20;
            this.textBox_dec_input.TextChanged += new System.EventHandler(this.textBox_dec_input_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Расшифровать";
            // 
            // button_enc_copy
            // 
            this.button_enc_copy.Location = new System.Drawing.Point(112, 224);
            this.button_enc_copy.Name = "button_enc_copy";
            this.button_enc_copy.Size = new System.Drawing.Size(109, 23);
            this.button_enc_copy.TabIndex = 18;
            this.button_enc_copy.Text = "Копировать";
            this.button_enc_copy.UseVisualStyleBackColor = true;
            this.button_enc_copy.Click += new System.EventHandler(this.button_enc_copy_Click);
            // 
            // textBox_enc_output
            // 
            this.textBox_enc_output.Enabled = false;
            this.textBox_enc_output.Location = new System.Drawing.Point(22, 196);
            this.textBox_enc_output.Name = "textBox_enc_output";
            this.textBox_enc_output.Size = new System.Drawing.Size(287, 22);
            this.textBox_enc_output.TabIndex = 17;
            // 
            // textBox_enc_input
            // 
            this.textBox_enc_input.Location = new System.Drawing.Point(22, 168);
            this.textBox_enc_input.Name = "textBox_enc_input";
            this.textBox_enc_input.Size = new System.Drawing.Size(287, 22);
            this.textBox_enc_input.TabIndex = 15;
            this.textBox_enc_input.TextChanged += new System.EventHandler(this.textBox_enc_input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Зашифровать";
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(22, 111);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(184, 22);
            this.textBox_key.TabIndex = 13;
            this.textBox_key.TextChanged += new System.EventHandler(this.textBox_key_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ключ";
            // 
            // comboBox_lang
            // 
            this.comboBox_lang.FormattingEnabled = true;
            this.comboBox_lang.Items.AddRange(new object[] {
            "English",
            "Русский"});
            this.comboBox_lang.Location = new System.Drawing.Point(22, 55);
            this.comboBox_lang.Name = "comboBox_lang";
            this.comboBox_lang.Size = new System.Drawing.Size(287, 24);
            this.comboBox_lang.TabIndex = 24;
            this.comboBox_lang.SelectedIndexChanged += new System.EventHandler(this.comboBox_lang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Язык";
            // 
            // table_letters
            // 
            this.table_letters.ColumnCount = 33;
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.table_letters.Location = new System.Drawing.Point(337, 19);
            this.table_letters.Name = "table_letters";
            this.table_letters.RowCount = 33;
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_letters.Size = new System.Drawing.Size(663, 663);
            this.table_letters.TabIndex = 27;
            // 
            // picture_table
            // 
            this.picture_table.Image = global::OBKS_IZ.Properties.Resources.visEn;
            this.picture_table.Location = new System.Drawing.Point(337, 19);
            this.picture_table.Name = "picture_table";
            this.picture_table.Size = new System.Drawing.Size(663, 663);
            this.picture_table.TabIndex = 28;
            this.picture_table.TabStop = false;
            // 
            // Vigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 694);
            this.Controls.Add(this.picture_table);
            this.Controls.Add(this.table_letters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_lang);
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
            this.Name = "Vigenere";
            this.Text = "Шифр Виженера";
            ((System.ComponentModel.ISupportInitialize)(this.picture_table)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox_lang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel table_letters;
        private System.Windows.Forms.PictureBox picture_table;
    }
}