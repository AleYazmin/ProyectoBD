using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoBD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            TextBox1 = new TextBox();
            CBVehiculo = new ComboBox();
            CBVehiculo.SelectedIndexChanged += new EventHandler(CBVehiculo_SelectedIndexChanged);
            DataGridView1 = new DataGridView();
            DataGridView1.CellContentClick += new DataGridViewCellEventHandler(DataGridView1_CellContentClick);
            DataGridView1.SelectionChanged += new EventHandler(DataGridView1_SelectionChanged);
            BtnBuscar = new Button();
            BtnBuscar.Click += new EventHandler(BtnBuscar_Click);
            ButtonEliminar = new Button();
            ButtonEliminar.Click += new EventHandler(ButtonEliminar_Click);
            ButtonCrear = new Button();
            ButtonCrear.Click += new EventHandler(ButtonCrear_Click);
            Label1 = new Label();
            ButtonMostrar = new Button();
            ButtonMostrar.Click += new EventHandler(ButtonMostrar_Click);
            ButtonActualizar = new Button();
            ButtonActualizar.Click += new EventHandler(ButtonActualizar_Click);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(144, 101);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(121, 23);
            TextBox1.TabIndex = 0;
            // 
            // CBVehiculo
            // 
            CBVehiculo.FormattingEnabled = true;
            CBVehiculo.Location = new Point(307, 100);
            CBVehiculo.Name = "CBVehiculo";
            CBVehiculo.Size = new Size(121, 23);
            CBVehiculo.TabIndex = 1;
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(59, 167);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowTemplate.Height = 25;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.ShowCellErrors = false;
            DataGridView1.ShowCellToolTips = false;
            DataGridView1.ShowEditingIcon = false;
            DataGridView1.ShowRowErrors = false;
            DataGridView1.Size = new Size(604, 208);
            DataGridView1.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(520, 100);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 3;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // ButtonEliminar
            // 
            ButtonEliminar.Location = new Point(419, 396);
            ButtonEliminar.Name = "ButtonEliminar";
            ButtonEliminar.Size = new Size(75, 23);
            ButtonEliminar.TabIndex = 4;
            ButtonEliminar.Text = "Eliminar";
            ButtonEliminar.UseVisualStyleBackColor = true;
            // 
            // ButtonCrear
            // 
            ButtonCrear.Location = new Point(338, 396);
            ButtonCrear.Name = "ButtonCrear";
            ButtonCrear.Size = new Size(75, 23);
            ButtonCrear.TabIndex = 5;
            ButtonCrear.Text = "Crear";
            ButtonCrear.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(59, 104);
            Label1.Name = "Label1";
            Label1.Size = new Size(52, 15);
            Label1.TabIndex = 6;
            Label1.Text = "Vehiculo";
            // 
            // ButtonMostrar
            // 
            ButtonMostrar.Location = new Point(257, 396);
            ButtonMostrar.Name = "ButtonMostrar";
            ButtonMostrar.Size = new Size(75, 23);
            ButtonMostrar.TabIndex = 7;
            ButtonMostrar.Text = "Mostar";
            ButtonMostrar.UseVisualStyleBackColor = true;
            // 
            // ButtonActualizar
            // 
            ButtonActualizar.Location = new Point(510, 396);
            ButtonActualizar.Name = "ButtonActualizar";
            ButtonActualizar.Size = new Size(75, 23);
            ButtonActualizar.TabIndex = 8;
            ButtonActualizar.Text = "Actualizar";
            ButtonActualizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = BtnBuscar;
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 450);
            Controls.Add(ButtonActualizar);
            Controls.Add(ButtonMostrar);
            Controls.Add(Label1);
            Controls.Add(ButtonCrear);
            Controls.Add(ButtonEliminar);
            Controls.Add(BtnBuscar);
            Controls.Add(DataGridView1);
            Controls.Add(CBVehiculo);
            Controls.Add(TextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox TextBox1;
        internal ComboBox CBVehiculo;
        internal DataGridView DataGridView1;
        internal Button BtnBuscar;
        internal Button ButtonEliminar;
        internal Button ButtonCrear;
        internal Label Label1;
        internal Button ButtonMostrar;
        internal Button ButtonActualizar;
    }
}