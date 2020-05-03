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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnResolver = New System.Windows.Forms.Button()
        Me.lblResultado1 = New System.Windows.Forms.Label()
        Me.lblRaiz1 = New System.Windows.Forms.Label()
        Me.lblRaiz2 = New System.Windows.Forms.Label()
        Me.lblResultado2 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(30, 41)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 26)
        Me.txtA.TabIndex = 0
        Me.txtA.Text = " a"
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "x² +"
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(175, 41)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 26)
        Me.txtB.TabIndex = 2
        Me.txtB.Text = "b"
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(277, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "x +"
        '
        'txtC
        '
        Me.txtC.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(317, 41)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 26)
        Me.txtC.TabIndex = 4
        Me.txtC.Text = "c"
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(419, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "= 0"
        '
        'btnResolver
        '
        Me.btnResolver.BackColor = System.Drawing.Color.Chocolate
        Me.btnResolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnResolver.Location = New System.Drawing.Point(465, 27)
        Me.btnResolver.Name = "btnResolver"
        Me.btnResolver.Size = New System.Drawing.Size(119, 55)
        Me.btnResolver.TabIndex = 6
        Me.btnResolver.Text = "Resolver"
        Me.btnResolver.UseVisualStyleBackColor = False
        '
        'lblResultado1
        '
        Me.lblResultado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado1.Location = New System.Drawing.Point(47, 156)
        Me.lblResultado1.Name = "lblResultado1"
        Me.lblResultado1.Size = New System.Drawing.Size(122, 23)
        Me.lblResultado1.TabIndex = 8
        '
        'lblRaiz1
        '
        Me.lblRaiz1.AutoSize = True
        Me.lblRaiz1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaiz1.Location = New System.Drawing.Point(47, 123)
        Me.lblRaiz1.Name = "lblRaiz1"
        Me.lblRaiz1.Size = New System.Drawing.Size(61, 24)
        Me.lblRaiz1.TabIndex = 9
        Me.lblRaiz1.Text = "Raiz 1"
        Me.lblRaiz1.Visible = False
        '
        'lblRaiz2
        '
        Me.lblRaiz2.AutoSize = True
        Me.lblRaiz2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaiz2.Location = New System.Drawing.Point(175, 123)
        Me.lblRaiz2.Name = "lblRaiz2"
        Me.lblRaiz2.Size = New System.Drawing.Size(61, 24)
        Me.lblRaiz2.TabIndex = 11
        Me.lblRaiz2.Text = "Raiz 2"
        Me.lblRaiz2.Visible = False
        '
        'lblResultado2
        '
        Me.lblResultado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado2.Location = New System.Drawing.Point(175, 156)
        Me.lblResultado2.Name = "lblResultado2"
        Me.lblResultado2.Size = New System.Drawing.Size(181, 23)
        Me.lblResultado2.TabIndex = 10
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.Location = New System.Drawing.Point(465, 144)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(119, 53)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = " Limpiar Valores"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(596, 229)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblRaiz2)
        Me.Controls.Add(Me.lblResultado2)
        Me.Controls.Add(Me.lblRaiz1)
        Me.Controls.Add(Me.lblResultado1)
        Me.Controls.Add(Me.btnResolver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnResolver As Button
    Friend WithEvents lblResultado1 As Label
    Friend WithEvents lblRaiz1 As Label
    Friend WithEvents lblRaiz2 As Label
    Friend WithEvents lblResultado2 As Label
    Friend WithEvents btnLimpiar As Button
End Class
