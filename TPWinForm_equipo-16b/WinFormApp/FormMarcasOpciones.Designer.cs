namespace WinFormApp
{
    partial class FormMarcasOpciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelOpcionesMarca = new System.Windows.Forms.Panel();
            this.ButtonAgregarMarcas = new System.Windows.Forms.Button();
            this.buttonEliminarMarca = new System.Windows.Forms.Button();
            this.buttonModificarMarcas = new System.Windows.Forms.Button();
            this.pboxMarca = new System.Windows.Forms.PictureBox();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.comboBoxBuscarMarca = new System.Windows.Forms.ComboBox();
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.panelOpcionesMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOpcionesMarca
            // 
            this.panelOpcionesMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelOpcionesMarca.Controls.Add(this.ButtonAgregarMarcas);
            this.panelOpcionesMarca.Controls.Add(this.buttonEliminarMarca);
            this.panelOpcionesMarca.Controls.Add(this.buttonModificarMarcas);
            this.panelOpcionesMarca.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpcionesMarca.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panelOpcionesMarca.Location = new System.Drawing.Point(0, 0);
            this.panelOpcionesMarca.Name = "panelOpcionesMarca";
            this.panelOpcionesMarca.Size = new System.Drawing.Size(163, 593);
            this.panelOpcionesMarca.TabIndex = 1;
            // 
            // ButtonAgregarMarcas
            // 
            this.ButtonAgregarMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.ButtonAgregarMarcas.FlatAppearance.BorderSize = 0;
            this.ButtonAgregarMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.ButtonAgregarMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAgregarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAgregarMarcas.ForeColor = System.Drawing.SystemColors.Menu;
            this.ButtonAgregarMarcas.Location = new System.Drawing.Point(-10, 175);
            this.ButtonAgregarMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAgregarMarcas.Name = "ButtonAgregarMarcas";
            this.ButtonAgregarMarcas.Size = new System.Drawing.Size(173, 88);
            this.ButtonAgregarMarcas.TabIndex = 6;
            this.ButtonAgregarMarcas.Text = "Agregar Marcas";
            this.ButtonAgregarMarcas.UseVisualStyleBackColor = false;
            this.ButtonAgregarMarcas.Click += new System.EventHandler(this.ButtonAgregarMarcas_Click);
            // 
            // buttonEliminarMarca
            // 
            this.buttonEliminarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.buttonEliminarMarca.FlatAppearance.BorderSize = 0;
            this.buttonEliminarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.buttonEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarMarca.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonEliminarMarca.Location = new System.Drawing.Point(-14, 352);
            this.buttonEliminarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminarMarca.Name = "buttonEliminarMarca";
            this.buttonEliminarMarca.Size = new System.Drawing.Size(175, 81);
            this.buttonEliminarMarca.TabIndex = 5;
            this.buttonEliminarMarca.Text = "Eliminar Marca";
            this.buttonEliminarMarca.UseVisualStyleBackColor = false;
            this.buttonEliminarMarca.Click += new System.EventHandler(this.buttonEliminarMarca_Click);
            // 
            // buttonModificarMarcas
            // 
            this.buttonModificarMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.buttonModificarMarcas.FlatAppearance.BorderSize = 0;
            this.buttonModificarMarcas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonModificarMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.buttonModificarMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarMarcas.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonModificarMarcas.Location = new System.Drawing.Point(-14, 267);
            this.buttonModificarMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModificarMarcas.Name = "buttonModificarMarcas";
            this.buttonModificarMarcas.Size = new System.Drawing.Size(175, 81);
            this.buttonModificarMarcas.TabIndex = 2;
            this.buttonModificarMarcas.Text = "Modificar Marca";
            this.buttonModificarMarcas.UseVisualStyleBackColor = false;
            this.buttonModificarMarcas.Click += new System.EventHandler(this.buttonModificarMarcas_Click);
            // 
            // pboxMarca
            // 
            this.pboxMarca.Location = new System.Drawing.Point(762, 156);
            this.pboxMarca.Name = "pboxMarca";
            this.pboxMarca.Size = new System.Drawing.Size(275, 263);
            this.pboxMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMarca.TabIndex = 51;
            this.pboxMarca.TabStop = false;
            // 
            // dgvMarca
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarca.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMarca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarca.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMarca.Location = new System.Drawing.Point(166, 97);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarca.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.dgvMarca.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarca.Size = new System.Drawing.Size(590, 385);
            this.dgvMarca.TabIndex = 50;
            // 
            // comboBoxBuscarMarca
            // 
            this.comboBoxBuscarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBuscarMarca.FormattingEnabled = true;
            this.comboBoxBuscarMarca.Location = new System.Drawing.Point(290, 24);
            this.comboBoxBuscarMarca.Name = "comboBoxBuscarMarca";
            this.comboBoxBuscarMarca.Size = new System.Drawing.Size(175, 21);
            this.comboBoxBuscarMarca.TabIndex = 49;
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnBuscarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.btnBuscarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarMarca.Location = new System.Drawing.Point(169, 12);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(115, 43);
            this.btnBuscarMarca.TabIndex = 48;
            this.btnBuscarMarca.Text = "Buscar";
            this.btnBuscarMarca.UseVisualStyleBackColor = false;
            // 
            // FormMarcasOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1047, 593);
            this.Controls.Add(this.pboxMarca);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.comboBoxBuscarMarca);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.panelOpcionesMarca);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMarcasOpciones";
            this.Text = "FormMarcasOpciones";
            this.Load += new System.EventHandler(this.FormMarcasOpciones_Load);
            this.panelOpcionesMarca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelOpcionesMarca;
        private System.Windows.Forms.Button ButtonAgregarMarcas;
        private System.Windows.Forms.Button buttonEliminarMarca;
        private System.Windows.Forms.Button buttonModificarMarcas;
        private System.Windows.Forms.PictureBox pboxMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.ComboBox comboBoxBuscarMarca;
        private System.Windows.Forms.Button btnBuscarMarca;
    }
}