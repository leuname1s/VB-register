<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnComprar = New System.Windows.Forms.Button()
        Me.BtnVender = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodPro = New System.Windows.Forms.TextBox()
        Me.TxtDet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCant = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPreUni = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIva = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnComprar
        '
        Me.BtnComprar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComprar.Location = New System.Drawing.Point(29, 28)
        Me.BtnComprar.Name = "BtnComprar"
        Me.BtnComprar.Size = New System.Drawing.Size(113, 47)
        Me.BtnComprar.TabIndex = 0
        Me.BtnComprar.Text = "COMPRAR"
        Me.BtnComprar.UseVisualStyleBackColor = True
        '
        'BtnVender
        '
        Me.BtnVender.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVender.Location = New System.Drawing.Point(29, 81)
        Me.BtnVender.Name = "BtnVender"
        Me.BtnVender.Size = New System.Drawing.Size(113, 47)
        Me.BtnVender.TabIndex = 1
        Me.BtnVender.Text = "VENDER"
        Me.BtnVender.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo Producto"
        '
        'TxtCodPro
        '
        Me.TxtCodPro.Location = New System.Drawing.Point(306, 43)
        Me.TxtCodPro.MaxLength = 4
        Me.TxtCodPro.Multiline = True
        Me.TxtCodPro.Name = "TxtCodPro"
        Me.TxtCodPro.ShortcutsEnabled = False
        Me.TxtCodPro.Size = New System.Drawing.Size(125, 20)
        Me.TxtCodPro.TabIndex = 4
        '
        'TxtDet
        '
        Me.TxtDet.Location = New System.Drawing.Point(306, 69)
        Me.TxtDet.Multiline = True
        Me.TxtDet.Name = "TxtDet"
        Me.TxtDet.Size = New System.Drawing.Size(125, 20)
        Me.TxtDet.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS PGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Detalle"
        '
        'TxtCant
        '
        Me.TxtCant.Location = New System.Drawing.Point(306, 97)
        Me.TxtCant.Multiline = True
        Me.TxtCant.Name = "TxtCant"
        Me.TxtCant.Size = New System.Drawing.Size(125, 20)
        Me.TxtCant.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS PGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cantidad"
        '
        'TxtPreUni
        '
        Me.TxtPreUni.Location = New System.Drawing.Point(306, 124)
        Me.TxtPreUni.Multiline = True
        Me.TxtPreUni.Name = "TxtPreUni"
        Me.TxtPreUni.Size = New System.Drawing.Size(125, 20)
        Me.TxtPreUni.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS PGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Precio unidad"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(306, 150)
        Me.TxtSubTotal.Multiline = True
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(125, 20)
        Me.TxtSubTotal.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS PGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(187, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Subtotal"
        '
        'TxtIva
        '
        Me.TxtIva.Location = New System.Drawing.Point(306, 175)
        Me.TxtIva.Multiline = True
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(125, 20)
        Me.TxtIva.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS PGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(187, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "IVA"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(306, 203)
        Me.TxtTotal.Multiline = True
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(125, 20)
        Me.TxtTotal.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS PGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(187, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Total"
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(446, 67)
        Me.TxtStock.Multiline = True
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(125, 22)
        Me.TxtStock.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS PGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(486, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Stock"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(29, 172)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(113, 47)
        Me.BtnAceptar.TabIndex = 19
        Me.BtnAceptar.Text = "ACEPTAR"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 249)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtIva)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtSubTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPreUni)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCant)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCodPro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnVender)
        Me.Controls.Add(Me.BtnComprar)
        Me.Name = "Form1"
        Me.Text = "Precio Unidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnComprar As Button
    Friend WithEvents BtnVender As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodPro As TextBox
    Friend WithEvents TxtDet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCant As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPreUni As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIva As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnAceptar As Button
End Class
