namespace WinFormApp
{
    partial class FormArticuloOpciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelOpcionesArticulos = new System.Windows.Forms.Panel();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnModificarArt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pboxArticulo = new System.Windows.Forms.PictureBox();
            this.panelOpcionesArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOpcionesArticulos
            // 
            this.panelOpcionesArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelOpcionesArticulos.Controls.Add(this.btnAgregarArt);
            this.panelOpcionesArticulos.Controls.Add(this.button5);
            this.panelOpcionesArticulos.Controls.Add(this.btnModificarArt);
            this.panelOpcionesArticulos.Controls.Add(this.button1);
            this.panelOpcionesArticulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpcionesArticulos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panelOpcionesArticulos.Location = new System.Drawing.Point(0, 0);
            this.panelOpcionesArticulos.Name = "panelOpcionesArticulos";
            this.panelOpcionesArticulos.Size = new System.Drawing.Size(163, 593);
            this.panelOpcionesArticulos.TabIndex = 0;
            this.panelOpcionesArticulos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOpcionesArticulos_Paint);
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAgregarArt.FlatAppearance.BorderSize = 0;
            this.btnAgregarArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.btnAgregarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArt.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarArt.Location = new System.Drawing.Point(-14, 85);
            this.btnAgregarArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(173, 88);
            this.btnAgregarArt.TabIndex = 6;
            this.btnAgregarArt.Text = "Agregar Articulo";
            this.btnAgregarArt.UseVisualStyleBackColor = false;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregarArt_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Menu;
            this.button5.Location = new System.Drawing.Point(-14, 352);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 81);
            this.button5.TabIndex = 5;
            this.button5.Text = "Eliminar Articulo";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnModificarArt.FlatAppearance.BorderSize = 0;
            this.btnModificarArt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.btnModificarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArt.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnModificarArt.Location = new System.Drawing.Point(-14, 267);
            this.btnModificarArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(175, 81);
            this.btnModificarArt.TabIndex = 2;
            this.btnModificarArt.Text = "Modificar Articulo";
            this.btnModificarArt.UseVisualStyleBackColor = false;
            this.btnModificarArt.Click += new System.EventHandler(this.btnModificarArt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(-12, 177);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar Articulos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvArticulo
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvArticulo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvArticulo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvArticulo.Location = new System.Drawing.Point(164, 85);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulo.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.dgvArticulo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(590, 385);
            this.dgvArticulo.TabIndex = 1;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pboxArticulo
            // 
            this.pboxArticulo.Location = new System.Drawing.Point(760, 144);
            this.pboxArticulo.Name = "pboxArticulo";
            this.pboxArticulo.Size = new System.Drawing.Size(275, 263);
            this.pboxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxArticulo.TabIndex = 2;
            this.pboxArticulo.TabStop = false;
            // 
            // FormArticuloOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1047, 593);
            this.Controls.Add(this.pboxArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.panelOpcionesArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormArticuloOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormArticuloOpciones";
            this.Load += new System.EventHandler(this.FormArticuloOpciones_Load);
            this.panelOpcionesArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnModificarArt;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panelOpcionesArticulos;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pboxArticulo;
    }
}