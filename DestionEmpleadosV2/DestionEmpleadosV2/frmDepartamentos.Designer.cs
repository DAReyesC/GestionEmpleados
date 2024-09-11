namespace DestionEmpleadosV2
{
    partial class frmDepartamentos
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
            txtNdepartamentos = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNdepartamentos
            // 
            txtNdepartamentos.Location = new Point(205, 42);
            txtNdepartamentos.Name = "txtNdepartamentos";
            txtNdepartamentos.Size = new Size(233, 27);
            txtNdepartamentos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Departamento:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtNdepartamentos);
            groupBox1.Location = new Point(31, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 207);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar/Editar";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(244, 119);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(105, 119);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Guardar..";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(502, 231);
            Controls.Add(groupBox1);
            Name = "frmDepartamentos";
            Text = "frmDepartamentos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNdepartamentos;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnSave;
    }
}