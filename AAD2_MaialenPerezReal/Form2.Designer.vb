<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblSipnosis = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblSip = New System.Windows.Forms.Label()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(58, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 424)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Información Pelicula"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(405, 137)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(43, 16)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Titulo:"
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Location = New System.Drawing.Point(405, 195)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(82, 16)
        Me.lblAnio.TabIndex = 3
        Me.lblAnio.Text = "Año estreno:"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Location = New System.Drawing.Point(405, 254)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(147, 16)
        Me.lblDuracion.TabIndex = 4
        Me.lblDuracion.Text = "Duración de la película:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(405, 307)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(132, 16)
        Me.lblPrecio.TabIndex = 5
        Me.lblPrecio.Text = "Precio de la película:"
        '
        'lblSipnosis
        '
        Me.lblSipnosis.AutoSize = True
        Me.lblSipnosis.Location = New System.Drawing.Point(405, 366)
        Me.lblSipnosis.Name = "lblSipnosis"
        Me.lblSipnosis.Size = New System.Drawing.Size(62, 16)
        Me.lblSipnosis.TabIndex = 6
        Me.lblSipnosis.Text = "Sipnosis:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(537, 134)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(230, 22)
        Me.txtTitulo.TabIndex = 7
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(537, 195)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(230, 22)
        Me.txtAnio.TabIndex = 8
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(589, 254)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(178, 22)
        Me.txtDuracion.TabIndex = 9
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(589, 307)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(178, 22)
        Me.txtPrecio.TabIndex = 10
        '
        'lblSip
        '
        Me.lblSip.Location = New System.Drawing.Point(468, 389)
        Me.lblSip.Name = "lblSip"
        Me.lblSip.Size = New System.Drawing.Size(421, 82)
        Me.lblSip.TabIndex = 11
        Me.lblSip.Text = "kkk"
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(526, 495)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(241, 52)
        Me.btnVender.TabIndex = 12
        Me.btnVender.Text = "Vender Entradas"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(853, 583)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(140, 52)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "S A L I R"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 647)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.lblSip)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.lblSipnosis)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.lblAnio)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAnio As Label
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblSipnosis As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblSip As Label
    Friend WithEvents btnVender As Button
    Friend WithEvents btnSalir As Button
End Class
