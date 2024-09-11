namespace DestionEmpleadosV2
{
    partial class frmEmpleado
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
            label1 = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            cbxDepartamento = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtCargo = new TextBox();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 44);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtName
            // 
            txtName.Location = new Point(111, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 27);
            txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(111, 216);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Guardar..";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(txtCargo);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbxDepartamento);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Location = new Point(51, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 277);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar/Editar";
            // 
            // cbxDepartamento
            // 
            cbxDepartamento.FormattingEnabled = true;
            cbxDepartamento.Location = new Point(137, 147);
            cbxDepartamento.Name = "cbxDepartamento";
            cbxDepartamento.Size = new Size(207, 28);
            cbxDepartamento.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 78);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 117);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 153);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 6;
            label4.Text = "Departamento:";
            // 
            // txtID
            // 
            txtID.Location = new Point(111, 78);
            txtID.Name = "txtID";
            txtID.Size = new Size(120, 27);
            txtID.TabIndex = 7;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(111, 114);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(233, 27);
            txtCargo.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 216);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(550, 310);
            Controls.Add(groupBox1);
            Name = "frmEmpleado";
            Text = "frmEmpleado";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnSave;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbxDepartamento;
        private Button btnCancel;
        private TextBox txtCargo;
        private TextBox txtID;
    }
}