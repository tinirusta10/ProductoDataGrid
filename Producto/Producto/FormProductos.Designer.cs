namespace Producto
{
    partial class FormProductos
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
            this.label3 = new System.Windows.Forms.Label();
            this.btncargar = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabcargar = new System.Windows.Forms.TabPage();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.tabcantidad = new System.Windows.Forms.TabPage();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_descmovimiento = new System.Windows.Forms.Label();
            this.lbl_codmovimietno = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rbegreso = new System.Windows.Forms.RadioButton();
            this.rbingreso = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.tab.SuspendLayout();
            this.tabcargar.SuspendLayout();
            this.tabcantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(592, 147);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 3;
            this.btncargar.Text = "Cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabcargar);
            this.tab.Controls.Add(this.tabcantidad);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(751, 234);
            this.tab.TabIndex = 4;
            // 
            // tabcargar
            // 
            this.tabcargar.Controls.Add(this.txtstock);
            this.tabcargar.Controls.Add(this.txtdesc);
            this.tabcargar.Controls.Add(this.txtcodigo);
            this.tabcargar.Controls.Add(this.label1);
            this.tabcargar.Controls.Add(this.btncargar);
            this.tabcargar.Controls.Add(this.label2);
            this.tabcargar.Controls.Add(this.label3);
            this.tabcargar.Location = new System.Drawing.Point(4, 22);
            this.tabcargar.Name = "tabcargar";
            this.tabcargar.Padding = new System.Windows.Forms.Padding(3);
            this.tabcargar.Size = new System.Drawing.Size(743, 208);
            this.tabcargar.TabIndex = 0;
            this.tabcargar.Text = "Carga de productos";
            this.tabcargar.UseVisualStyleBackColor = true;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(191, 140);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 20);
            this.txtstock.TabIndex = 6;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(191, 86);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(100, 20);
            this.txtdesc.TabIndex = 5;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(191, 29);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 4;
            // 
            // tabcantidad
            // 
            this.tabcantidad.Controls.Add(this.txtcantidad);
            this.tabcantidad.Controls.Add(this.lbl_stock);
            this.tabcantidad.Controls.Add(this.lbl_descmovimiento);
            this.tabcantidad.Controls.Add(this.lbl_codmovimietno);
            this.tabcantidad.Controls.Add(this.btnAceptar);
            this.tabcantidad.Controls.Add(this.rbegreso);
            this.tabcantidad.Controls.Add(this.rbingreso);
            this.tabcantidad.Controls.Add(this.label4);
            this.tabcantidad.Location = new System.Drawing.Point(4, 22);
            this.tabcantidad.Name = "tabcantidad";
            this.tabcantidad.Padding = new System.Windows.Forms.Padding(3);
            this.tabcantidad.Size = new System.Drawing.Size(743, 208);
            this.tabcantidad.TabIndex = 1;
            this.tabcantidad.Text = "Movimiento de productos";
            this.tabcantidad.UseVisualStyleBackColor = true;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(141, 130);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 8;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(74, 106);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(52, 17);
            this.lbl_stock.TabIndex = 7;
            this.lbl_stock.Text = "label5";
            // 
            // lbl_descmovimiento
            // 
            this.lbl_descmovimiento.AutoSize = true;
            this.lbl_descmovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descmovimiento.Location = new System.Drawing.Point(74, 73);
            this.lbl_descmovimiento.Name = "lbl_descmovimiento";
            this.lbl_descmovimiento.Size = new System.Drawing.Size(52, 17);
            this.lbl_descmovimiento.TabIndex = 6;
            this.lbl_descmovimiento.Text = "label5";
            this.lbl_descmovimiento.Click += new System.EventHandler(this.lbl_descmovimiento_Click);
            // 
            // lbl_codmovimietno
            // 
            this.lbl_codmovimietno.AutoSize = true;
            this.lbl_codmovimietno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codmovimietno.Location = new System.Drawing.Point(74, 34);
            this.lbl_codmovimietno.Name = "lbl_codmovimietno";
            this.lbl_codmovimietno.Size = new System.Drawing.Size(52, 17);
            this.lbl_codmovimietno.TabIndex = 5;
            this.lbl_codmovimietno.Text = "label5";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(456, 130);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 50);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbegreso
            // 
            this.rbegreso.AutoSize = true;
            this.rbegreso.Location = new System.Drawing.Point(358, 168);
            this.rbegreso.Name = "rbegreso";
            this.rbegreso.Size = new System.Drawing.Size(58, 17);
            this.rbegreso.TabIndex = 3;
            this.rbegreso.TabStop = true;
            this.rbegreso.Text = "Egreso";
            this.rbegreso.UseVisualStyleBackColor = true;
            // 
            // rbingreso
            // 
            this.rbingreso.AutoSize = true;
            this.rbingreso.Location = new System.Drawing.Point(358, 130);
            this.rbingreso.Name = "rbingreso";
            this.rbingreso.Size = new System.Drawing.Size(60, 17);
            this.rbingreso.TabIndex = 2;
            this.rbingreso.TabStop = true;
            this.rbingreso.Text = "Ingreso";
            this.rbingreso.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(12, 263);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(500, 150);
            this.dg.TabIndex = 5;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.tab);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.tab.ResumeLayout(false);
            this.tabcargar.ResumeLayout(false);
            this.tabcargar.PerformLayout();
            this.tabcantidad.ResumeLayout(false);
            this.tabcantidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabcargar;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TabPage tabcantidad;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rbegreso;
        private System.Windows.Forms.RadioButton rbingreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_descmovimiento;
        private System.Windows.Forms.Label lbl_codmovimietno;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.TextBox txtcantidad;
    }
}