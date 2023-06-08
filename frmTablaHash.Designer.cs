namespace ProyectoFinalUSPG
{
    partial class frmTablaHash
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
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
            this.grivAlumno.Location = new System.Drawing.Point(19, 261);
            this.grivAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grivAlumno.Name = "grivAlumno";
            this.grivAlumno.RowHeadersWidth = 51;
            this.grivAlumno.RowTemplate.Height = 29;
            this.grivAlumno.Size = new System.Drawing.Size(769, 178);
            this.grivAlumno.TabIndex = 43;
            this.grivAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grivAlumno_CellContentClick);
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
            // txtFacultad
            // 
            this.txtFacultad.Location = new System.Drawing.Point(80, 215);
            this.txtFacultad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFacultad.Name = "txtFacultad";
            this.txtFacultad.Size = new System.Drawing.Size(439, 23);
            this.txtFacultad.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Facultad";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(80, 179);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(439, 23);
            this.txtCarrera.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Carrera";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(80, 142);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(98, 23);
            this.txtEdad.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Edad";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(80, 96);
            this.txtCarnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(228, 23);
            this.txtCarnet.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Carnet";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(80, 54);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(439, 23);
            this.txtApellido.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Apellido";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(560, 210);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 31);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Agregar Alumno";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 11);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(439, 23);
            this.txtName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(80, 461);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(81, 31);
            this.btnModificar.TabIndex = 44;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(190, 461);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(81, 31);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmTablaHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grivAlumno);
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
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmTablaHash";
            this.Text = "frmTablaHash";
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
        private Button btnAdd;
        private TextBox txtName;
        private Label label1;
        private Button btnModificar;
        private Button btnEliminar;
    }
}