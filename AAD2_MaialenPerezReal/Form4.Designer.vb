<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.pbGithub = New System.Windows.Forms.PictureBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblRepos = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.pbGithub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbGithub
        '
        Me.pbGithub.Location = New System.Drawing.Point(76, 104)
        Me.pbGithub.Name = "pbGithub"
        Me.pbGithub.Size = New System.Drawing.Size(215, 219)
        Me.pbGithub.TabIndex = 0
        Me.pbGithub.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(404, 137)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(48, 16)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Label1"
        '
        'lblRepos
        '
        Me.lblRepos.AutoSize = True
        Me.lblRepos.Location = New System.Drawing.Point(404, 187)
        Me.lblRepos.Name = "lblRepos"
        Me.lblRepos.Size = New System.Drawing.Size(48, 16)
        Me.lblRepos.TabIndex = 2
        Me.lblRepos.Text = "Label2"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(648, 400)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(102, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "C E R R A R"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblRepos)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.pbGithub)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.pbGithub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbGithub As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblRepos As Label
    Friend WithEvents btnCerrar As Button
End Class
