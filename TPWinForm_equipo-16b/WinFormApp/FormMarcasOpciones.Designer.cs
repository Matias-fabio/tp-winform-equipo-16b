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
            this.BMarca = new System.Windows.Forms.Button();
            this.ComboBoxMarca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BMarca
            // 
            this.BMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.BMarca.FlatAppearance.BorderSize = 0;
            this.BMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.BMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMarca.ForeColor = System.Drawing.Color.White;
            this.BMarca.Location = new System.Drawing.Point(12, 12);
            this.BMarca.Name = "BMarca";
            this.BMarca.Size = new System.Drawing.Size(115, 47);
            this.BMarca.TabIndex = 0;
            this.BMarca.Text = "Buscar";
            this.BMarca.UseVisualStyleBackColor = false;
            // 
            // ComboBoxMarca
            // 
            this.ComboBoxMarca.FormattingEnabled = true;
            this.ComboBoxMarca.Items.AddRange(new object[] {
            "Samsung",
            "Apple",
            "Sony",
            "Huawei",
            "Motorola"});
            this.ComboBoxMarca.Location = new System.Drawing.Point(143, 26);
            this.ComboBoxMarca.Name = "ComboBoxMarca";
            this.ComboBoxMarca.Size = new System.Drawing.Size(158, 21);
            this.ComboBoxMarca.TabIndex = 1;
            this.ComboBoxMarca.Text = "Marca";
            this.ComboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormMarcasOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBoxMarca);
            this.Controls.Add(this.BMarca);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMarcasOpciones";
            this.Text = "FormMarcasOpciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BMarca;
        private System.Windows.Forms.ComboBox ComboBoxMarca;
    }
}