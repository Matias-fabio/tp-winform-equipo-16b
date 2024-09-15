namespace WinFormApp
{
    partial class FormOpcionCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelOpcionesCategoria = new System.Windows.Forms.Panel();
            this.ButtonAgregarCategoria = new System.Windows.Forms.Button();
            this.buttonEliminarCategoria = new System.Windows.Forms.Button();
            this.buttonModificarCategoria = new System.Windows.Forms.Button();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.comboBoxBuscarCategoria = new System.Windows.Forms.ComboBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.pboxCategoria = new System.Windows.Forms.PictureBox();
            this.panelOpcionesCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOpcionesCategoria
            // 
            this.panelOpcionesCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelOpcionesCategoria.Controls.Add(this.ButtonAgregarCategoria);
            this.panelOpcionesCategoria.Controls.Add(this.buttonEliminarCategoria);
            this.panelOpcionesCategoria.Controls.Add(this.buttonModificarCategoria);
            this.panelOpcionesCategoria.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpcionesCategoria.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panelOpcionesCategoria.Location = new System.Drawing.Point(0, 0);
            this.panelOpcionesCategoria.Name = "panelOpcionesCategoria";
            this.panelOpcionesCategoria.Size = new System.Drawing.Size(163, 593);
            this.panelOpcionesCategoria.TabIndex = 2;
            // 
            // ButtonAgregarCategoria
            // 
            this.ButtonAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.ButtonAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.ButtonAgregarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.ButtonAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAgregarCategoria.ForeColor = System.Drawing.SystemColors.Menu;
            this.ButtonAgregarCategoria.Location = new System.Drawing.Point(-12, 129);
            this.ButtonAgregarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAgregarCategoria.Name = "ButtonAgregarCategoria";
            this.ButtonAgregarCategoria.Size = new System.Drawing.Size(173, 86);
            this.ButtonAgregarCategoria.TabIndex = 3;
            this.ButtonAgregarCategoria.Text = "Agregar nueva categoria";
            this.ButtonAgregarCategoria.UseVisualStyleBackColor = false;
            this.ButtonAgregarCategoria.Click += new System.EventHandler(this.ButtonAgregarCategoria_Click);
            // 
            // buttonEliminarCategoria
            // 
            this.buttonEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.buttonEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.buttonEliminarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.buttonEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCategoria.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonEliminarCategoria.Location = new System.Drawing.Point(-14, 304);
            this.buttonEliminarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminarCategoria.Name = "buttonEliminarCategoria";
            this.buttonEliminarCategoria.Size = new System.Drawing.Size(175, 81);
            this.buttonEliminarCategoria.TabIndex = 5;
            this.buttonEliminarCategoria.Text = "Eliminar Categoria";
            this.buttonEliminarCategoria.UseVisualStyleBackColor = false;
            this.buttonEliminarCategoria.Click += new System.EventHandler(this.buttonEliminarCategoria_Click);
            // 
            // buttonModificarCategoria
            // 
            this.buttonModificarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.buttonModificarCategoria.FlatAppearance.BorderSize = 0;
            this.buttonModificarCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonModificarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.buttonModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarCategoria.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonModificarCategoria.Location = new System.Drawing.Point(-14, 219);
            this.buttonModificarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModificarCategoria.Name = "buttonModificarCategoria";
            this.buttonModificarCategoria.Size = new System.Drawing.Size(175, 81);
            this.buttonModificarCategoria.TabIndex = 2;
            this.buttonModificarCategoria.Text = "Modificar Categoria";
            this.buttonModificarCategoria.UseVisualStyleBackColor = false;
            this.buttonModificarCategoria.Click += new System.EventHandler(this.buttonModificarCategoria_Click);
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnBuscarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.btnBuscarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(169, 12);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(115, 43);
            this.btnBuscarCategoria.TabIndex = 41;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = false;
            // 
            // comboBoxBuscarCategoria
            // 
            this.comboBoxBuscarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBuscarCategoria.FormattingEnabled = true;
            this.comboBoxBuscarCategoria.Location = new System.Drawing.Point(290, 24);
            this.comboBoxBuscarCategoria.Name = "comboBoxBuscarCategoria";
            this.comboBoxBuscarCategoria.Size = new System.Drawing.Size(175, 21);
            this.comboBoxBuscarCategoria.TabIndex = 45;
            // 
            // dgvCategoria
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategoria.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCategoria.Location = new System.Drawing.Point(166, 97);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.dgvCategoria.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(590, 385);
            this.dgvCategoria.TabIndex = 46;
            // 
            // pboxCategoria
            // 
            this.pboxCategoria.Location = new System.Drawing.Point(762, 156);
            this.pboxCategoria.Name = "pboxCategoria";
            this.pboxCategoria.Size = new System.Drawing.Size(275, 263);
            this.pboxCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCategoria.TabIndex = 47;
            this.pboxCategoria.TabStop = false;
            // 
            // FormOpcionCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1047, 593);
            this.Controls.Add(this.pboxCategoria);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.comboBoxBuscarCategoria);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.panelOpcionesCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOpcionCategoria";
            this.Text = "FormOpcionCategoria";
            this.Load += new System.EventHandler(this.FormOpcionCategoria_Load);
            this.panelOpcionesCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelOpcionesCategoria;
        private System.Windows.Forms.Button buttonEliminarCategoria;
        private System.Windows.Forms.Button buttonModificarCategoria;
        private System.Windows.Forms.Button ButtonAgregarCategoria;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.ComboBox comboBoxBuscarCategoria;
        private System.Windows.Forms.PictureBox pboxCategoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
    }
}