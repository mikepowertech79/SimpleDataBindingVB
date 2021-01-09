<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenericBinding
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
        Me.dgvEmployees = New System.Windows.Forms.DataGridView
        Me.btnLoadEmployees = New System.Windows.Forms.Button
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmployees
        '
        Me.dgvEmployees.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(3, 1)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(643, 200)
        Me.dgvEmployees.TabIndex = 0
        '
        'btnLoadEmployees
        '
        Me.btnLoadEmployees.Location = New System.Drawing.Point(3, 208)
        Me.btnLoadEmployees.Name = "btnLoadEmployees"
        Me.btnLoadEmployees.Size = New System.Drawing.Size(111, 23)
        Me.btnLoadEmployees.TabIndex = 1
        Me.btnLoadEmployees.Text = "Load Employees"
        Me.btnLoadEmployees.UseVisualStyleBackColor = True
        '
        'frmGenericBinding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 246)
        Me.Controls.Add(Me.btnLoadEmployees)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Name = "frmGenericBinding"
        Me.Text = "Generic BindingList Example"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvEmployees As System.Windows.Forms.DataGridView
    Friend WithEvents btnLoadEmployees As System.Windows.Forms.Button

End Class
