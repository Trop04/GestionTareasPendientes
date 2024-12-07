namespace GestionTareasPendientes
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
            txtTarea = new TextBox();
            btnAgregarTarea = new Button();
            lstTareas = new ListBox();
            btnEliminarTarea = new Button();
            SuspendLayout();
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(22, 12);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(208, 23);
            txtTarea.TabIndex = 0;
            txtTarea.TextChanged += txtTarea_TextChanged;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.BackColor = SystemColors.ControlLightLight;
            btnAgregarTarea.Cursor = Cursors.Hand;
            btnAgregarTarea.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            btnAgregarTarea.FlatStyle = FlatStyle.System;
            btnAgregarTarea.Location = new Point(124, 41);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(106, 23);
            btnAgregarTarea.TabIndex = 1;
            btnAgregarTarea.Text = "Agregar Tarea";
            btnAgregarTarea.UseVisualStyleBackColor = false;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(22, 77);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(208, 334);
            lstTareas.TabIndex = 2;
            lstTareas.SelectedIndexChanged += lstTareas_SelectedIndexChanged;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.BackColor = SystemColors.ControlLightLight;
            btnEliminarTarea.Cursor = Cursors.Hand;
            btnEliminarTarea.FlatAppearance.BorderColor = SystemColors.Control;
            btnEliminarTarea.FlatStyle = FlatStyle.System;
            btnEliminarTarea.Location = new Point(22, 417);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(208, 23);
            btnEliminarTarea.TabIndex = 3;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = false;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(257, 450);
            Controls.Add(btnEliminarTarea);
            Controls.Add(lstTareas);
            Controls.Add(btnAgregarTarea);
            Controls.Add(txtTarea);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Gestión de Tareas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarea;
        private Button btnAgregarTarea;
        private ListBox lstTareas;
        private Button btnEliminarTarea;
    }
}
