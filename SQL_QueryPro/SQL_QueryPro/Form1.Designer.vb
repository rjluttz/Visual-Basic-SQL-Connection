<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButQuery = New System.Windows.Forms.Button()
        Me.DgvQuery = New System.Windows.Forms.DataGridView()
        Me.TxtQuery = New System.Windows.Forms.TextBox()
        CType(Me.DgvQuery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButQuery
        '
        Me.ButQuery.Font = New System.Drawing.Font("Adobe Gothic Std B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButQuery.Location = New System.Drawing.Point(742, 12)
        Me.ButQuery.Name = "ButQuery"
        Me.ButQuery.Size = New System.Drawing.Size(134, 80)
        Me.ButQuery.TabIndex = 1
        Me.ButQuery.Text = "Run Query"
        Me.ButQuery.UseVisualStyleBackColor = True
        '
        'DgvQuery
        '
        Me.DgvQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvQuery.Location = New System.Drawing.Point(22, 119)
        Me.DgvQuery.Name = "DgvQuery"
        Me.DgvQuery.Size = New System.Drawing.Size(854, 365)
        Me.DgvQuery.TabIndex = 2
        '
        'TxtQuery
        '
        Me.TxtQuery.Location = New System.Drawing.Point(22, 12)
        Me.TxtQuery.Multiline = True
        Me.TxtQuery.Name = "TxtQuery"
        Me.TxtQuery.Size = New System.Drawing.Size(694, 80)
        Me.TxtQuery.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 506)
        Me.Controls.Add(Me.ButQuery)
        Me.Controls.Add(Me.TxtQuery)
        Me.Controls.Add(Me.DgvQuery)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgvQuery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButQuery As System.Windows.Forms.Button
    Friend WithEvents DgvQuery As System.Windows.Forms.DataGridView
    Friend WithEvents TxtQuery As System.Windows.Forms.TextBox

End Class
