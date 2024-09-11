namespace DestionEmpleadosV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ListEmpleados = new ListBox();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnEliminar2 = new Button();
            btnEditar2 = new Button();
            btnAdd2 = new Button();
            ListDepartamentos = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 9);
            label1.Name = "label1";
            label1.Size = new Size(613, 41);
            label1.TabIndex = 0;
            label1.Text = "Gestion De Empleados y Departamentos.";
            // 
            // ListEmpleados
            // 
            ListEmpleados.FormattingEnabled = true;
            ListEmpleados.Location = new Point(18, 36);
            ListEmpleados.Name = "ListEmpleados";
            ListEmpleados.Size = new Size(250, 144);
            ListEmpleados.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar...";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(ListEmpleados);
            groupBox1.Location = new Point(45, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 334);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleados.";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.Controls.Add(btnEliminar2);
            groupBox2.Controls.Add(btnEditar2);
            groupBox2.Controls.Add(btnAdd2);
            groupBox2.Controls.Add(ListDepartamentos);
            groupBox2.Location = new Point(430, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 334);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Departamentos";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(18, 233);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar...";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(18, 268);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar..";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar2
            // 
            btnEliminar2.Location = new Point(35, 269);
            btnEliminar2.Name = "btnEliminar2";
            btnEliminar2.Size = new Size(94, 29);
            btnEliminar2.TabIndex = 8;
            btnEliminar2.Text = "Eliminar..";
            btnEliminar2.UseVisualStyleBackColor = true;
            // 
            // btnEditar2
            // 
            btnEditar2.Location = new Point(35, 234);
            btnEditar2.Name = "btnEditar2";
            btnEditar2.Size = new Size(94, 29);
            btnEditar2.TabIndex = 7;
            btnEditar2.Text = "Editar...";
            btnEditar2.UseVisualStyleBackColor = true;
            // 
            // btnAdd2
            // 
            btnAdd2.Location = new Point(35, 199);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(94, 29);
            btnAdd2.TabIndex = 6;
            btnAdd2.Text = "Agregar...";
            btnAdd2.UseVisualStyleBackColor = true;
            // 
            // ListDepartamentos
            // 
            ListDepartamentos.FormattingEnabled = true;
            ListDepartamentos.Location = new Point(35, 37);
            ListDepartamentos.Name = "ListDepartamentos";
            ListDepartamentos.Size = new Size(250, 144);
            ListDepartamentos.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox ListEmpleados;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnEditar;
        private GroupBox groupBox2;
        private Button btnEliminar2;
        private Button btnEditar2;
        private Button btnAdd2;
        private ListBox ListDepartamentos;
    }
}
