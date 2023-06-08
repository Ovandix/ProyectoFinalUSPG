namespace ProyectoFinalUSPG
{
    partial class frmAlumno
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFacultad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grivAlumno = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCarnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFacultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grivAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(477, 27);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(82, 79);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(477, 27);
            this.txtApellido.TabIndex = 4;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(82, 135);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(236, 27);
            this.txtCarnet.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Carnet";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(82, 196);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(87, 27);
            this.txtEdad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(82, 245);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(477, 27);
            this.txtCarrera.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Carrera";
            // 
            // txtFacultad
            // 
            this.txtFacultad.Location = new System.Drawing.Point(82, 294);
            this.txtFacultad.Name = "txtFacultad";
            this.txtFacultad.Size = new System.Drawing.Size(477, 27);
            this.txtFacultad.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Facultad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar Lista Enlazada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grivAlumno
            // 
            this.grivAlumno.AccessibleName = "";
            this.grivAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grivAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColApellido,
            this.ColCarnet,
            this.ColEdad,
            this.ColCarrera,
            this.ColFacultad});
            this.grivAlumno.Location = new System.Drawing.Point(12, 355);
            this.grivAlumno.Name = "grivAlumno";
            this.grivAlumno.RowHeadersWidth = 51;
            this.grivAlumno.RowTemplate.Height = 29;
            this.grivAlumno.Size = new System.Drawing.Size(830, 237);
            this.grivAlumno.TabIndex = 14;
            this.grivAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grivAlumno_CellClick);
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Width = 125;
            // 
            // ColApellido
            // 
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.MinimumWidth = 6;
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.Width = 125;
            // 
            // ColCarnet
            // 
            this.ColCarnet.HeaderText = "Carnet";
            this.ColCarnet.MinimumWidth = 6;
            this.ColCarnet.Name = "ColCarnet";
            this.ColCarnet.Width = 125;
            // 
            // ColEdad
            // 
            this.ColEdad.HeaderText = "Edad";
            this.ColEdad.MinimumWidth = 6;
            this.ColEdad.Name = "ColEdad";
            this.ColEdad.Width = 125;
            // 
            // ColCarrera
            // 
            this.ColCarrera.HeaderText = "Carrera";
            this.ColCarrera.MinimumWidth = 6;
            this.ColCarrera.Name = "ColCarrera";
            this.ColCarrera.Width = 125;
            // 
            // ColFacultad
            // 
            this.ColFacultad.HeaderText = "Facultad";
            this.ColFacultad.MinimumWidth = 6;
            this.ColFacultad.Name = "ColFacultad";
            this.ColFacultad.Width = 125;
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 604);
            this.Controls.Add(this.grivAlumno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFacultad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.grivAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtApellido;
        private TextBox txtCarnet;
        private Label label3;
        private TextBox txtEdad;
        private Label label4;
        private TextBox txtCarrera;
        private Label label5;
        private TextBox txtFacultad;
        private Label label6;
        private Button button1;
        private DataGridView grivAlumno;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColCarnet;
        private DataGridViewTextBoxColumn ColEdad;
        private DataGridViewTextBoxColumn ColCarrera;
        private DataGridViewTextBoxColumn ColFacultad;
    }
}