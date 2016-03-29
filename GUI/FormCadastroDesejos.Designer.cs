namespace GUI
{
    partial class FormCadastroDesejos
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
            this.textBoxAmigoSolicitado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDataDesejo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxValorDesejo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amigo Solicitante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amigo Solicitado:";
            // 
            // textBoxAmigoSolicitado
            // 
            this.textBoxAmigoSolicitado.Location = new System.Drawing.Point(105, 58);
            this.textBoxAmigoSolicitado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAmigoSolicitado.Name = "textBoxAmigoSolicitado";
            this.textBoxAmigoSolicitado.Size = new System.Drawing.Size(285, 20);
            this.textBoxAmigoSolicitado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // dateTimePickerDataDesejo
            // 
            this.dateTimePickerDataDesejo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDesejo.Location = new System.Drawing.Point(105, 91);
            this.dateTimePickerDataDesejo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDataDesejo.Name = "dateTimePickerDataDesejo";
            this.dateTimePickerDataDesejo.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerDataDesejo.TabIndex = 5;
            this.dateTimePickerDataDesejo.ValueChanged += new System.EventHandler(this.dateTimePickerDataDesejo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor:";
            // 
            // textBoxValorDesejo
            // 
            this.textBoxValorDesejo.Location = new System.Drawing.Point(105, 120);
            this.textBoxValorDesejo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValorDesejo.Name = "textBoxValorDesejo";
            this.textBoxValorDesejo.Size = new System.Drawing.Size(153, 20);
            this.textBoxValorDesejo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descrição:";
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(105, 152);
            this.richTextBoxDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(285, 79);
            this.richTextBoxDescricao.TabIndex = 9;
            this.richTextBoxDescricao.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Novo Desejo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "Gravar Desejo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 12;
            // 
            // FormCadastroDesejos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 296);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxValorDesejo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDataDesejo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAmigoSolicitado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormCadastroDesejos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Desejos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmigoSolicitado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDesejo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxValorDesejo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}