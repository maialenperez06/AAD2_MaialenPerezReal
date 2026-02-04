<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblEntradas = New System.Windows.Forms.Label()
        Me.numEntradas = New System.Windows.Forms.NumericUpDown()
        Me.btnComprar = New System.Windows.Forms.Button()
        CType(Me.numEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(191, 54)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(362, 42)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Compra de Entradas"
        '
        'lblEntradas
        '
        Me.lblEntradas.AutoSize = True
        Me.lblEntradas.Location = New System.Drawing.Point(160, 157)
        Me.lblEntradas.Name = "lblEntradas"
        Me.lblEntradas.Size = New System.Drawing.Size(121, 16)
        Me.lblEntradas.TabIndex = 2
        Me.lblEntradas.Text = "Cantidad Entradas:"
        '
        'numEntradas
        '
        Me.numEntradas.Location = New System.Drawing.Point(369, 155)
        Me.numEntradas.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numEntradas.Name = "numEntradas"
        Me.numEntradas.Size = New System.Drawing.Size(161, 22)
        Me.numEntradas.TabIndex = 3
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(239, 251)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(219, 67)
        Me.btnComprar.TabIndex = 5
        Me.btnComprar.Text = "COMPRAR"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 383)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.numEntradas)
        Me.Controls.Add(Me.lblEntradas)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.numEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblEntradas As Label
    Friend WithEvents numEntradas As NumericUpDown
    Friend WithEvents btnComprar As Button
End Class
