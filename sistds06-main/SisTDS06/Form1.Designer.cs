namespace SisTDS06
{
    partial class FormVenda
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtvenda = new System.Windows.Forms.TextBox();
            this.btnlocalizar = new System.Windows.Forms.Button();
            this.lblvenda = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnnovopedido = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnvenda = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblprod = new System.Windows.Forms.Label();
            this.lblquanti = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(373, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // txtvenda
            // 
            this.txtvenda.Location = new System.Drawing.Point(29, 38);
            this.txtvenda.Name = "txtvenda";
            this.txtvenda.Size = new System.Drawing.Size(153, 20);
            this.txtvenda.TabIndex = 1;
            // 
            // btnlocalizar
            // 
            this.btnlocalizar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnlocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlocalizar.Location = new System.Drawing.Point(200, 35);
            this.btnlocalizar.Name = "btnlocalizar";
            this.btnlocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnlocalizar.TabIndex = 2;
            this.btnlocalizar.Text = "Localizar ";
            this.btnlocalizar.UseVisualStyleBackColor = false;
            // 
            // lblvenda
            // 
            this.lblvenda.AutoSize = true;
            this.lblvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvenda.Location = new System.Drawing.Point(26, 19);
            this.lblvenda.Name = "lblvenda";
            this.lblvenda.Size = new System.Drawing.Size(96, 13);
            this.lblvenda.TabIndex = 3;
            this.lblvenda.Text = "Pedido / Venda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(627, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.Color.Lime;
            this.btnadicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionar.Location = new System.Drawing.Point(333, 162);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(122, 23);
            this.btnadicionar.TabIndex = 5;
            this.btnadicionar.Text = "Adicionar Produto";
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.Yellow;
            this.btnatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.Location = new System.Drawing.Point(333, 199);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(122, 23);
            this.btnatualizar.TabIndex = 6;
            this.btnatualizar.Text = "Atualizar Produto ";
            this.btnatualizar.UseVisualStyleBackColor = false;
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.Red;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(333, 238);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(122, 23);
            this.btnexcluir.TabIndex = 7;
            this.btnexcluir.Text = "Excluir Produto ";
            this.btnexcluir.UseVisualStyleBackColor = false;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Red;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(574, 174);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(122, 23);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            // 
            // btnnovopedido
            // 
            this.btnnovopedido.BackColor = System.Drawing.Color.Aqua;
            this.btnnovopedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovopedido.Location = new System.Drawing.Point(574, 87);
            this.btnnovopedido.Name = "btnnovopedido";
            this.btnnovopedido.Size = new System.Drawing.Size(122, 23);
            this.btnnovopedido.TabIndex = 9;
            this.btnnovopedido.Text = "Novo Pedido ";
            this.btnnovopedido.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(574, 116);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Finalizar Pedido";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnvenda
            // 
            this.btnvenda.BackColor = System.Drawing.Color.Lime;
            this.btnvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvenda.Location = new System.Drawing.Point(574, 145);
            this.btnvenda.Name = "btnvenda";
            this.btnvenda.Size = new System.Drawing.Size(122, 23);
            this.btnvenda.TabIndex = 11;
            this.btnvenda.Text = "Venda";
            this.btnvenda.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(29, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(209, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(29, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 20);
            this.textBox4.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(29, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(373, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(26, 69);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(50, 13);
            this.lblcliente.TabIndex = 16;
            this.lblcliente.Text = "Cliente ";
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprod.Location = new System.Drawing.Point(26, 116);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(51, 13);
            this.lblprod.TabIndex = 17;
            this.lblprod.Text = "Produto";
            // 
            // lblquanti
            // 
            this.lblquanti.AutoSize = true;
            this.lblquanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquanti.Location = new System.Drawing.Point(26, 167);
            this.lblquanti.Name = "lblquanti";
            this.lblquanti.Size = new System.Drawing.Size(72, 13);
            this.lblquanti.TabIndex = 18;
            this.lblquanti.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Preço ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Id Produto ";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(553, 446);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 20);
            this.textBox5.TabIndex = 21;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(479, 441);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(62, 24);
            this.lbltotal.TabIndex = 22;
            this.lbltotal.Text = "Total ";
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisTDS06.Properties.Resources.vendas_21;
            this.ClientSize = new System.Drawing.Size(718, 477);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblquanti);
            this.Controls.Add(this.lblprod);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnvenda);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnnovopedido);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblvenda);
            this.Controls.Add(this.btnlocalizar);
            this.Controls.Add(this.txtvenda);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormVenda";
            this.Text = "Pedido / Venda ";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtvenda;
        private System.Windows.Forms.Button btnlocalizar;
        private System.Windows.Forms.Label lblvenda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnnovopedido;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnvenda;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblprod;
        private System.Windows.Forms.Label lblquanti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbltotal;
    }
}