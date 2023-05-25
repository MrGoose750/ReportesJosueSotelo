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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.TxtDato = New System.Windows.Forms.TextBox()
        Me.CmbCampo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvRegistros = New System.Windows.Forms.DataGridView()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.BtnMostrar)
        Me.GroupBox.Controls.Add(Me.TxtDato)
        Me.GroupBox.Controls.Add(Me.CmbCampo)
        Me.GroupBox.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(755, 100)
        Me.GroupBox.TabIndex = 0
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Seleccione por cuál campo desea buscar"
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(635, 45)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(98, 23)
        Me.BtnMostrar.TabIndex = 2
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(165, 45)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(445, 22)
        Me.TxtDato.TabIndex = 1
        '
        'CmbCampo
        '
        Me.CmbCampo.FormattingEnabled = True
        Me.CmbCampo.Items.AddRange(New Object() {"Profesion", "Nombre", "Apellidos"})
        Me.CmbCampo.Location = New System.Drawing.Point(26, 45)
        Me.CmbCampo.Name = "CmbCampo"
        Me.CmbCampo.Size = New System.Drawing.Size(121, 24)
        Me.CmbCampo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvRegistros)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(755, 421)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registros encontrados"
        '
        'DgvRegistros
        '
        Me.DgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistros.Location = New System.Drawing.Point(7, 31)
        Me.DgvRegistros.Name = "DgvRegistros"
        Me.DgvRegistros.RowHeadersWidth = 51
        Me.DgvRegistros.RowTemplate.Height = 24
        Me.DgvRegistros.Size = New System.Drawing.Size(742, 384)
        Me.DgvRegistros.TabIndex = 0
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(661, 590)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(98, 23)
        Me.BtnImprimir.TabIndex = 3
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 649)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents TxtDato As TextBox
    Friend WithEvents CmbCampo As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvRegistros As DataGridView
    Friend WithEvents BtnImprimir As Button
End Class
