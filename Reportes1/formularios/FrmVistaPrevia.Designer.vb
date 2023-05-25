<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaPrevia
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DBRH_ds = New Reportes1.DBRH_ds()
        Me.DBRHdsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobEmployeeTableAdapter = New Reportes1.DBRH_dsTableAdapters.JobEmployeeTableAdapter()
        CType(Me.DBRH_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBRHdsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DsReporte"
        ReportDataSource1.Value = Me.JobEmployeeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Reportes1.rptEmpleadoTrabajo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DBRH_ds
        '
        Me.DBRH_ds.DataSetName = "DBRH_ds"
        Me.DBRH_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DBRHdsBindingSource
        '
        Me.DBRHdsBindingSource.DataSource = Me.DBRH_ds
        Me.DBRHdsBindingSource.Position = 0
        '
        'JobEmployeeBindingSource
        '
        Me.JobEmployeeBindingSource.DataMember = "JobEmployee"
        Me.JobEmployeeBindingSource.DataSource = Me.DBRHdsBindingSource
        '
        'JobEmployeeTableAdapter
        '
        Me.JobEmployeeTableAdapter.ClearBeforeFill = True
        '
        'FrmVistaPrevia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmVistaPrevia"
        Me.Text = "FrmVistaPrevia"
        CType(Me.DBRH_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBRHdsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DBRHdsBindingSource As BindingSource
    Friend WithEvents DBRH_ds As DBRH_ds
    Friend WithEvents JobEmployeeBindingSource As BindingSource
    Friend WithEvents JobEmployeeTableAdapter As DBRH_dsTableAdapters.JobEmployeeTableAdapter
End Class
