using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoBD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class FormMostrarCrear : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
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

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            TextBoxAño = new TextBox();
            TextBoxKilometraje = new TextBox();
            TextBoxInterior = new TextBox();
            ComboBoxMarca = new ComboBox();
            ComboBoxModelo = new ComboBox();
            ComboBoxVersionAuto = new ComboBox();
            ComboBoxCarroceria = new ComboBox();
            ComboBoxTransmicion = new ComboBox();
            ComboBoxColor = new ComboBox();
            ComboBoxVenta = new ComboBox();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            ButtonCerrar = new Button();
            ButtonCerrar.Click += new EventHandler(ButtonCerrar_Click);
            Buttonagregar = new Button();
            Buttonagregar.Click += new EventHandler(Buttonagregar_Click);
            ButtonActualizar = new Button();
            ButtonActualizar.Click += new EventHandler(ButtonActualizar_Click);
            SuspendLayout();
            // 
            // TextBoxAño
            // 
            TextBoxAño.Location = new Point(111, 37);
            TextBoxAño.Name = "TextBoxAño";
            TextBoxAño.Size = new Size(213, 23);
            TextBoxAño.TabIndex = 0;
            // 
            // TextBoxKilometraje
            // 
            TextBoxKilometraje.Location = new Point(111, 66);
            TextBoxKilometraje.Name = "TextBoxKilometraje";
            TextBoxKilometraje.Size = new Size(213, 23);
            TextBoxKilometraje.TabIndex = 1;
            // 
            // TextBoxInterior
            // 
            TextBoxInterior.Location = new Point(111, 95);
            TextBoxInterior.Name = "TextBoxInterior";
            TextBoxInterior.Size = new Size(213, 23);
            TextBoxInterior.TabIndex = 2;
            // 
            // ComboBoxMarca
            // 
            ComboBoxMarca.FormattingEnabled = true;
            ComboBoxMarca.Location = new Point(111, 124);
            ComboBoxMarca.Name = "ComboBoxMarca";
            ComboBoxMarca.Size = new Size(213, 23);
            ComboBoxMarca.TabIndex = 3;
            // 
            // ComboBoxModelo
            // 
            ComboBoxModelo.FormattingEnabled = true;
            ComboBoxModelo.Location = new Point(111, 153);
            ComboBoxModelo.Name = "ComboBoxModelo";
            ComboBoxModelo.Size = new Size(213, 23);
            ComboBoxModelo.TabIndex = 4;
            // 
            // ComboBoxVersionAuto
            // 
            ComboBoxVersionAuto.FormattingEnabled = true;
            ComboBoxVersionAuto.Location = new Point(111, 182);
            ComboBoxVersionAuto.Name = "ComboBoxVersionAuto";
            ComboBoxVersionAuto.Size = new Size(213, 23);
            ComboBoxVersionAuto.TabIndex = 5;
            // 
            // ComboBoxCarroceria
            // 
            ComboBoxCarroceria.FormattingEnabled = true;
            ComboBoxCarroceria.Location = new Point(111, 211);
            ComboBoxCarroceria.Name = "ComboBoxCarroceria";
            ComboBoxCarroceria.Size = new Size(213, 23);
            ComboBoxCarroceria.TabIndex = 6;
            // 
            // ComboBoxTransmicion
            // 
            ComboBoxTransmicion.FormattingEnabled = true;
            ComboBoxTransmicion.Location = new Point(111, 240);
            ComboBoxTransmicion.Name = "ComboBoxTransmicion";
            ComboBoxTransmicion.Size = new Size(213, 23);
            ComboBoxTransmicion.TabIndex = 7;
            // 
            // ComboBoxColor
            // 
            ComboBoxColor.FormattingEnabled = true;
            ComboBoxColor.Location = new Point(111, 269);
            ComboBoxColor.Name = "ComboBoxColor";
            ComboBoxColor.Size = new Size(213, 23);
            ComboBoxColor.TabIndex = 8;
            // 
            // ComboBoxVenta
            // 
            ComboBoxVenta.FormattingEnabled = true;
            ComboBoxVenta.Location = new Point(111, 298);
            ComboBoxVenta.Name = "ComboBoxVenta";
            ComboBoxVenta.Size = new Size(213, 23);
            ComboBoxVenta.TabIndex = 9;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(12, 40);
            Label1.Name = "Label1";
            Label1.Size = new Size(29, 15);
            Label1.TabIndex = 10;
            Label1.Text = "Año";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(12, 214);
            Label2.Name = "Label2";
            Label2.Size = new Size(61, 15);
            Label2.TabIndex = 11;
            Label2.Text = "Carroceria";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(12, 69);
            Label3.Name = "Label3";
            Label3.Size = new Size(67, 15);
            Label3.TabIndex = 11;
            Label3.Text = "Kilometraje";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(12, 98);
            Label4.Name = "Label4";
            Label4.Size = new Size(45, 15);
            Label4.TabIndex = 12;
            Label4.Text = "Interior";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(12, 127);
            Label5.Name = "Label5";
            Label5.Size = new Size(40, 15);
            Label5.TabIndex = 13;
            Label5.Text = "Marca";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(12, 156);
            Label6.Name = "Label6";
            Label6.Size = new Size(48, 15);
            Label6.TabIndex = 14;
            Label6.Text = "Modelo";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(12, 185);
            Label7.Name = "Label7";
            Label7.Size = new Size(74, 15);
            Label7.TabIndex = 15;
            Label7.Text = "Version Auto";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(12, 243);
            Label8.Name = "Label8";
            Label8.Size = new Size(71, 15);
            Label8.TabIndex = 16;
            Label8.Text = "Transmicion";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(12, 272);
            Label9.Name = "Label9";
            Label9.Size = new Size(36, 15);
            Label9.TabIndex = 17;
            Label9.Text = "Color";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(12, 301);
            Label10.Name = "Label10";
            Label10.Size = new Size(36, 15);
            Label10.TabIndex = 18;
            Label10.Text = "Venta";
            // 
            // ButtonCerrar
            // 
            ButtonCerrar.Location = new Point(398, 381);
            ButtonCerrar.Name = "ButtonCerrar";
            ButtonCerrar.Size = new Size(75, 23);
            ButtonCerrar.TabIndex = 19;
            ButtonCerrar.Text = "Cerrar";
            ButtonCerrar.UseVisualStyleBackColor = true;
            // 
            // Buttonagregar
            // 
            Buttonagregar.Location = new Point(479, 381);
            Buttonagregar.Name = "Buttonagregar";
            Buttonagregar.Size = new Size(75, 23);
            Buttonagregar.TabIndex = 20;
            Buttonagregar.Text = "Añadir";
            Buttonagregar.UseVisualStyleBackColor = true;
            // 
            // ButtonActualizar
            // 
            ButtonActualizar.Location = new Point(560, 381);
            ButtonActualizar.Name = "ButtonActualizar";
            ButtonActualizar.Size = new Size(75, 23);
            ButtonActualizar.TabIndex = 22;
            ButtonActualizar.Text = "Actualizar";
            ButtonActualizar.UseVisualStyleBackColor = true;
            // 
            // FormMostrarCrear
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonActualizar);
            Controls.Add(Buttonagregar);
            Controls.Add(ButtonCerrar);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(ComboBoxVenta);
            Controls.Add(ComboBoxColor);
            Controls.Add(ComboBoxTransmicion);
            Controls.Add(ComboBoxCarroceria);
            Controls.Add(ComboBoxVersionAuto);
            Controls.Add(ComboBoxModelo);
            Controls.Add(ComboBoxMarca);
            Controls.Add(TextBoxInterior);
            Controls.Add(TextBoxKilometraje);
            Controls.Add(TextBoxAño);
            Name = "FormMostrarCrear";
            Text = "FormMostrarCrear";
            Load += new EventHandler(FormMostrarCrear_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox TextBoxAño;
        internal TextBox TextBoxKilometraje;
        internal TextBox TextBoxInterior;
        internal ComboBox ComboBoxMarca;
        internal ComboBox ComboBoxModelo;
        internal ComboBox ComboBoxVersionAuto;
        internal ComboBox ComboBoxCarroceria;
        internal ComboBox ComboBoxTransmicion;
        internal ComboBox ComboBoxColor;
        internal ComboBox ComboBoxVenta;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal Label Label8;
        internal Label Label9;
        internal Label Label10;
        internal Button ButtonCerrar;
        internal Button Buttonagregar;
        internal Button ButtonActualizar;
    }
}