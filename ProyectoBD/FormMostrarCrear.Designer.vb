<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMostrarCrear
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxAño = New System.Windows.Forms.TextBox()
        Me.TextBoxKilometraje = New System.Windows.Forms.TextBox()
        Me.TextBoxInterior = New System.Windows.Forms.TextBox()
        Me.ComboBoxMarca = New System.Windows.Forms.ComboBox()
        Me.ComboBoxModelo = New System.Windows.Forms.ComboBox()
        Me.ComboBoxVersionAuto = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCarroceria = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTransmicion = New System.Windows.Forms.ComboBox()
        Me.ComboBoxColor = New System.Windows.Forms.ComboBox()
        Me.ComboBoxVenta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.Buttonagregar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxAño
        '
        Me.TextBoxAño.Location = New System.Drawing.Point(111, 37)
        Me.TextBoxAño.Name = "TextBoxAño"
        Me.TextBoxAño.Size = New System.Drawing.Size(213, 23)
        Me.TextBoxAño.TabIndex = 0
        '
        'TextBoxKilometraje
        '
        Me.TextBoxKilometraje.Location = New System.Drawing.Point(111, 66)
        Me.TextBoxKilometraje.Name = "TextBoxKilometraje"
        Me.TextBoxKilometraje.Size = New System.Drawing.Size(213, 23)
        Me.TextBoxKilometraje.TabIndex = 1
        '
        'TextBoxInterior
        '
        Me.TextBoxInterior.Location = New System.Drawing.Point(111, 95)
        Me.TextBoxInterior.Name = "TextBoxInterior"
        Me.TextBoxInterior.Size = New System.Drawing.Size(213, 23)
        Me.TextBoxInterior.TabIndex = 2
        '
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.FormattingEnabled = True
        Me.ComboBoxMarca.Location = New System.Drawing.Point(111, 124)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(213, 23)
        Me.ComboBoxMarca.TabIndex = 3
        '
        'ComboBoxModelo
        '
        Me.ComboBoxModelo.FormattingEnabled = True
        Me.ComboBoxModelo.Location = New System.Drawing.Point(111, 153)
        Me.ComboBoxModelo.Name = "ComboBoxModelo"
        Me.ComboBoxModelo.Size = New System.Drawing.Size(213, 23)
        Me.ComboBoxModelo.TabIndex = 4
        '
        'ComboBoxVersionAuto
        '
        Me.ComboBoxVersionAuto.FormattingEnabled = True
        Me.ComboBoxVersionAuto.Location = New System.Drawing.Point(111, 182)
        Me.ComboBoxVersionAuto.Name = "ComboBoxVersionAuto"
        Me.ComboBoxVersionAuto.Size = New System.Drawing.Size(213, 23)
        Me.ComboBoxVersionAuto.TabIndex = 5
        '
        'ComboBoxCarroceria
        '
        Me.ComboBoxCarroceria.FormattingEnabled = True
        Me.ComboBoxCarroceria.Location = New System.Drawing.Point(111, 211)
        Me.ComboBoxCarroceria.Name = "ComboBoxCarroceria"
        Me.ComboBoxCarroceria.Size = New System.Drawing.Size(213, 23)
        Me.ComboBoxCarroceria.TabIndex = 6
        '
        'ComboBoxTransmicion
        '
        Me.ComboBoxTransmicion.FormattingEnabled = True
        Me.ComboBoxTransmicion.Location = New System.Drawing.Point(111, 240)
        Me.ComboBoxTransmicion.Name = "ComboBoxTransmicion"
        Me.ComboBoxTransmicion.Size = New System.Drawing.Size(213, 23)
        Me.ComboBoxTransmicion.TabIndex = 7
        '
        'ComboBoxColor
        '
        Me.ComboBoxColor.FormattingEnabled = True
        Me.ComboBoxColor.Location = New System.Drawing.Point(111, 269)
        Me.ComboBoxColor.Name = "ComboBoxColor"
        Me.ComboBoxColor.Size = New System.Drawing.Size(213, 23)
        Me.ComboBoxColor.TabIndex = 8
        '
        'ComboBoxVenta
        '
        Me.ComboBoxVenta.FormattingEnabled = True
        Me.ComboBoxVenta.Location = New System.Drawing.Point(111, 298)
        Me.ComboBoxVenta.Name = "ComboBoxVenta"
        Me.ComboBoxVenta.Size = New System.Drawing.Size(213, 23)
        Me.ComboBoxVenta.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Carroceria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Kilometraje"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Interior"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Marca"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Modelo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Version Auto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Transmicion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Color"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Venta"
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Location = New System.Drawing.Point(398, 381)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCerrar.TabIndex = 19
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'Buttonagregar
        '
        Me.Buttonagregar.Location = New System.Drawing.Point(479, 381)
        Me.Buttonagregar.Name = "Buttonagregar"
        Me.Buttonagregar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonagregar.TabIndex = 20
        Me.Buttonagregar.Text = "Añadir"
        Me.Buttonagregar.UseVisualStyleBackColor = True
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Location = New System.Drawing.Point(560, 381)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonActualizar.TabIndex = 22
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'FormMostrarCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.Buttonagregar)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxVenta)
        Me.Controls.Add(Me.ComboBoxColor)
        Me.Controls.Add(Me.ComboBoxTransmicion)
        Me.Controls.Add(Me.ComboBoxCarroceria)
        Me.Controls.Add(Me.ComboBoxVersionAuto)
        Me.Controls.Add(Me.ComboBoxModelo)
        Me.Controls.Add(Me.ComboBoxMarca)
        Me.Controls.Add(Me.TextBoxInterior)
        Me.Controls.Add(Me.TextBoxKilometraje)
        Me.Controls.Add(Me.TextBoxAño)
        Me.Name = "FormMostrarCrear"
        Me.Text = "FormMostrarCrear"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxAño As TextBox
    Friend WithEvents TextBoxKilometraje As TextBox
    Friend WithEvents TextBoxInterior As TextBox
    Friend WithEvents ComboBoxMarca As ComboBox
    Friend WithEvents ComboBoxModelo As ComboBox
    Friend WithEvents ComboBoxVersionAuto As ComboBox
    Friend WithEvents ComboBoxCarroceria As ComboBox
    Friend WithEvents ComboBoxTransmicion As ComboBox
    Friend WithEvents ComboBoxColor As ComboBox
    Friend WithEvents ComboBoxVenta As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents Buttonagregar As Button
    Friend WithEvents ButtonActualizar As Button
End Class
