<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TablaController = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelResultado = New System.Windows.Forms.Panel()
        Me.PanelOutputResult = New System.Windows.Forms.Panel()
        Me.PanelGrados = New System.Windows.Forms.Panel()
        Me.PanelBuscar = New System.Windows.Forms.Panel()
        Me.PanelInfoGrados = New System.Windows.Forms.Panel()
        Me.PanelResultado.SuspendLayout()
        Me.PanelOutputResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'TablaController
        '
        Me.TablaController.ColumnCount = 4
        Me.TablaController.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.68924!))
        Me.TablaController.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.31076!))
        Me.TablaController.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TablaController.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TablaController.Location = New System.Drawing.Point(12, 12)
        Me.TablaController.Name = "TablaController"
        Me.TablaController.RowCount = 1
        Me.TablaController.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TablaController.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TablaController.Size = New System.Drawing.Size(464, 51)
        Me.TablaController.TabIndex = 0
        '
        'PanelResultado
        '
        Me.PanelResultado.Controls.Add(Me.PanelInfoGrados)
        Me.PanelResultado.Location = New System.Drawing.Point(245, 69)
        Me.PanelResultado.Name = "PanelResultado"
        Me.PanelResultado.Size = New System.Drawing.Size(231, 37)
        Me.PanelResultado.TabIndex = 1
        '
        'PanelOutputResult
        '
        Me.PanelOutputResult.Controls.Add(Me.PanelGrados)
        Me.PanelOutputResult.Location = New System.Drawing.Point(325, 69)
        Me.PanelOutputResult.Name = "PanelOutputResult"
        Me.PanelOutputResult.Size = New System.Drawing.Size(97, 30)
        Me.PanelOutputResult.TabIndex = 0
        '
        'PanelGrados
        '
        Me.PanelGrados.Location = New System.Drawing.Point(100, 0)
        Me.PanelGrados.Name = "PanelGrados"
        Me.PanelGrados.Size = New System.Drawing.Size(33, 27)
        Me.PanelGrados.TabIndex = 0
        '
        'PanelBuscar
        '
        Me.PanelBuscar.Location = New System.Drawing.Point(137, 65)
        Me.PanelBuscar.Name = "PanelBuscar"
        Me.PanelBuscar.Size = New System.Drawing.Size(112, 34)
        Me.PanelBuscar.TabIndex = 2
        '
        'PanelInfoGrados
        '
        Me.PanelInfoGrados.Location = New System.Drawing.Point(183, 0)
        Me.PanelInfoGrados.Name = "PanelInfoGrados"
        Me.PanelInfoGrados.Size = New System.Drawing.Size(33, 30)
        Me.PanelInfoGrados.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(494, 115)
        Me.Controls.Add(Me.PanelBuscar)
        Me.Controls.Add(Me.PanelOutputResult)
        Me.Controls.Add(Me.PanelResultado)
        Me.Controls.Add(Me.TablaController)
        Me.Font = New System.Drawing.Font("Dubai", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(500, 500)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Temperature Converter"
        Me.PanelResultado.ResumeLayout(False)
        Me.PanelOutputResult.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TablaController As TableLayoutPanel
    Friend WithEvents PanelResultado As Panel
    Friend WithEvents PanelOutputResult As Panel
    Friend WithEvents PanelBuscar As Panel
    Friend WithEvents PanelGrados As Panel
    Friend WithEvents PanelInfoGrados As Panel
End Class
