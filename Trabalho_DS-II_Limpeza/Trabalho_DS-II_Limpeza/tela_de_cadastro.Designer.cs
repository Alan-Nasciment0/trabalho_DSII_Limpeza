namespace Trabalho_DS_II_Limpeza
{
    partial class tela_de_cadastro
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
            this.lblcadastro = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btncadastro = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcadastro
            // 
            this.lblcadastro.AutoSize = true;
            this.lblcadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadastro.Location = new System.Drawing.Point(105, 30);
            this.lblcadastro.Name = "lblcadastro";
            this.lblcadastro.Size = new System.Drawing.Size(163, 25);
            this.lblcadastro.TabIndex = 0;
            this.lblcadastro.Text = "Tela de Cadastro";
            this.lblcadastro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereco.Location = new System.Drawing.Point(37, 191);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(78, 20);
            this.lblendereco.TabIndex = 1;
            this.lblendereco.Text = "Endereço";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(37, 80);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(51, 20);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome";
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(57, 221);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(165, 30);
            this.txtendereco.TabIndex = 3;
            this.txtendereco.TextChanged += new System.EventHandler(this.txtendereco_TextChanged);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(57, 126);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(165, 30);
            this.txtnome.TabIndex = 4;
            // 
            // btncadastro
            // 
            this.btncadastro.Location = new System.Drawing.Point(126, 371);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(155, 63);
            this.btncadastro.TabIndex = 5;
            this.btncadastro.Text = "Cadastrar";
            this.btncadastro.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(57, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 30);
            this.textBox1.TabIndex = 6;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcelular.Location = new System.Drawing.Point(38, 271);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(58, 20);
            this.lblcelular.TabIndex = 8;
            this.lblcelular.Text = "Celular";
            // 
            // tela_de_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 446);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btncadastro);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.lblcadastro);
            this.Name = "tela_de_cadastro";
            this.Load += new System.EventHandler(this.tela_de_cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcadastro;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblcelular;
    }
}