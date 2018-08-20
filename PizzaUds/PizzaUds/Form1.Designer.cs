namespace PizzaUds
{
    partial class frm_main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_borda = new System.Windows.Forms.CheckBox();
            this.cb_semcebola = new System.Windows.Forms.CheckBox();
            this.cb_bacon = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_portuguesa = new System.Windows.Forms.RadioButton();
            this.rb_marguerita = new System.Windows.Forms.RadioButton();
            this.rb_calabresa = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_grande = new System.Windows.Forms.RadioButton();
            this.rb_media = new System.Windows.Forms.RadioButton();
            this.rb_pequena = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 132);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza UDS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 577);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cb_borda);
            this.groupBox3.Controls.Add(this.cb_semcebola);
            this.groupBox3.Controls.Add(this.cb_bacon);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 228);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personalização";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_borda
            // 
            this.cb_borda.AutoSize = true;
            this.cb_borda.Location = new System.Drawing.Point(48, 116);
            this.cb_borda.Name = "cb_borda";
            this.cb_borda.Size = new System.Drawing.Size(245, 17);
            this.cb_borda.TabIndex = 5;
            this.cb_borda.Text = "Borda recheada adicional R$ 5,00 e 5 minutos";
            this.cb_borda.UseVisualStyleBackColor = true;
            // 
            // cb_semcebola
            // 
            this.cb_semcebola.AutoSize = true;
            this.cb_semcebola.Location = new System.Drawing.Point(48, 78);
            this.cb_semcebola.Name = "cb_semcebola";
            this.cb_semcebola.Size = new System.Drawing.Size(82, 17);
            this.cb_semcebola.TabIndex = 4;
            this.cb_semcebola.Text = "Sem cebola";
            this.cb_semcebola.UseVisualStyleBackColor = true;
            // 
            // cb_bacon
            // 
            this.cb_bacon.AutoSize = true;
            this.cb_bacon.Location = new System.Drawing.Point(48, 41);
            this.cb_bacon.Name = "cb_bacon";
            this.cb_bacon.Size = new System.Drawing.Size(170, 17);
            this.cb_bacon.TabIndex = 3;
            this.cb_bacon.Text = "Extra Bacon adicional R$ 3,00";
            this.cb_bacon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_portuguesa);
            this.groupBox2.Controls.Add(this.rb_marguerita);
            this.groupBox2.Controls.Add(this.rb_calabresa);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sabor";
            // 
            // rb_portuguesa
            // 
            this.rb_portuguesa.AutoSize = true;
            this.rb_portuguesa.Location = new System.Drawing.Point(48, 108);
            this.rb_portuguesa.Name = "rb_portuguesa";
            this.rb_portuguesa.Size = new System.Drawing.Size(172, 17);
            this.rb_portuguesa.TabIndex = 2;
            this.rb_portuguesa.Text = "Portuguesa adicional 5 minutos";
            this.rb_portuguesa.UseVisualStyleBackColor = true;
            // 
            // rb_marguerita
            // 
            this.rb_marguerita.AutoSize = true;
            this.rb_marguerita.Location = new System.Drawing.Point(48, 70);
            this.rb_marguerita.Name = "rb_marguerita";
            this.rb_marguerita.Size = new System.Drawing.Size(75, 17);
            this.rb_marguerita.TabIndex = 1;
            this.rb_marguerita.Text = "Marguerita";
            this.rb_marguerita.UseVisualStyleBackColor = true;
            // 
            // rb_calabresa
            // 
            this.rb_calabresa.AutoSize = true;
            this.rb_calabresa.Checked = true;
            this.rb_calabresa.Location = new System.Drawing.Point(48, 34);
            this.rb_calabresa.Name = "rb_calabresa";
            this.rb_calabresa.Size = new System.Drawing.Size(72, 17);
            this.rb_calabresa.TabIndex = 0;
            this.rb_calabresa.TabStop = true;
            this.rb_calabresa.Text = "Calabresa";
            this.rb_calabresa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_grande);
            this.groupBox1.Controls.Add(this.rb_media);
            this.groupBox1.Controls.Add(this.rb_pequena);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamanho";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_grande
            // 
            this.rb_grande.AutoSize = true;
            this.rb_grande.Location = new System.Drawing.Point(48, 125);
            this.rb_grande.Name = "rb_grande";
            this.rb_grande.Size = new System.Drawing.Size(233, 17);
            this.rb_grande.TabIndex = 2;
            this.rb_grande.Text = "Grande  Valor: R$ 40,00 Tempo: 25 minutos";
            this.rb_grande.UseVisualStyleBackColor = true;
            // 
            // rb_media
            // 
            this.rb_media.AutoSize = true;
            this.rb_media.Location = new System.Drawing.Point(48, 78);
            this.rb_media.Name = "rb_media";
            this.rb_media.Size = new System.Drawing.Size(227, 17);
            this.rb_media.TabIndex = 1;
            this.rb_media.Text = "Média  Valor: R$ 30,00 Tempo: 20 minutos";
            this.rb_media.UseVisualStyleBackColor = true;
            // 
            // rb_pequena
            // 
            this.rb_pequena.AutoSize = true;
            this.rb_pequena.Checked = true;
            this.rb_pequena.Location = new System.Drawing.Point(48, 35);
            this.rb_pequena.Name = "rb_pequena";
            this.rb_pequena.Size = new System.Drawing.Size(241, 17);
            this.rb_pequena.TabIndex = 0;
            this.rb_pequena.TabStop = true;
            this.rb_pequena.Text = "Pequena  Valor: R$ 20,00 Tempo: 15 minutos";
            this.rb_pequena.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Montar Pizza";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_portuguesa;
        private System.Windows.Forms.RadioButton rb_marguerita;
        private System.Windows.Forms.RadioButton rb_calabresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_grande;
        private System.Windows.Forms.RadioButton rb_media;
        private System.Windows.Forms.RadioButton rb_pequena;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_borda;
        private System.Windows.Forms.CheckBox cb_semcebola;
        private System.Windows.Forms.CheckBox cb_bacon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

