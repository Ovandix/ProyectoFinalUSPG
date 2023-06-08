namespace ProyectoFinalUSPG
{
    partial class frmDobleEnlazada
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
            this.grivAlumno = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCarnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFacultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFacultad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grivAlumno)).BeginInit();
            this.SuspendLayout();
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
            this.grivAlumno.Location = new System.Drawing.Point(12, 352);
            this.grivAlumno.Name = "grivAlumno";
            this.grivAlumno.RowHeadersWidth = 51;
            this.grivAlumno.RowTemplate.Height = 29;
            this.grivAlumno.Size = new System.Drawing.Size(830, 237);
            this.grivAlumno.TabIndex = 28;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "Agregar Lista Doble";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFacultad
            // 
            this.txtFacultad.Location = new System.Drawing.Point(82, 291);
            this.txtFacultad.Name = "txtFacultad";
            this.txtFacultad.Size = new System.Drawing.Size(477, 27);
            this.txtFacultad.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Facultad";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(82, 242);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(477, 27);
            this.txtCarrera.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Carrera";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(82, 193);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(87, 27);
            this.txtEdad.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Edad";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(82, 132);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(236, 27);
            this.txtCarnet.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Carnet";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(82, 76);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(477, 27);
            this.txtApellido.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(477, 27);
            this.txtName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // frmDobleEnlazada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 602);
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
            this.Name = "frmDobleEnlazada";
            this.Text = "frmDobleEnlazada";
            ((System.ComponentModel.ISupportInitialize)(this.grivAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grivAlumno;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColCarnet;
        private DataGridViewTextBoxColumn ColEdad;
        private DataGridViewTextBoxColumn ColCarrera;
        private DataGridViewTextBoxColumn ColFacultad;
        private Button button1;
        private TextBox txtFacultad;
        private Label label6;
        private TextBox txtCarrera;
        private Label label5;
        private TextBox txtEdad;
        private Label label4;
        private TextBox txtCarnet;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtName;
        private Label label1;
    }
}