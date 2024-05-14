using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoBD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Login : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            TBUsuario = new TextBox();
            TBContraseña = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            PictureBox1 = new PictureBox();
            BtnAceptar = new Button();
            BtnAceptar.Click += new EventHandler(BtnAceptar_Click);
            TBNombre = new TextBox();
            Label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TBUsuario
            // 
            TBUsuario.Location = new Point(214, 168);
            TBUsuario.Name = "TBUsuario";
            TBUsuario.Size = new Size(152, 23);
            TBUsuario.TabIndex = 0;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(214, 226);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(152, 23);
            TBContraseña.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(214, 145);
            Label1.Name = "Label1";
            Label1.Size = new Size(59, 20);
            Label1.TabIndex = 2;
            Label1.Text = "Usuario";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point);
            Label2.Location = new Point(214, 203);
            Label2.Name = "Label2";
            Label2.Size = new Size(83, 20);
            Label2.TabIndex = 3;
            Label2.Text = "Contraseña";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(27, 92);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(156, 157);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 4;
            PictureBox1.TabStop = false;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point);
            BtnAceptar.Location = new Point(155, 293);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(84, 28);
            BtnAceptar.TabIndex = 5;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(214, 119);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(152, 23);
            TBNombre.TabIndex = 6;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point);
            Label3.Location = new Point(214, 92);
            Label3.Name = "Label3";
            Label3.Size = new Size(64, 20);
            Label3.TabIndex = 7;
            Label3.Text = "Nombre";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 361);
            Controls.Add(Label3);
            Controls.Add(TBNombre);
            Controls.Add(BtnAceptar);
            Controls.Add(PictureBox1);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(TBContraseña);
            Controls.Add(TBUsuario);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox TBUsuario;
        internal TextBox TBContraseña;
        internal Label Label1;
        internal Label Label2;
        internal PictureBox PictureBox1;
        internal Button BtnAceptar;
        internal TextBox TBNombre;
        internal Label Label3;
    }
}