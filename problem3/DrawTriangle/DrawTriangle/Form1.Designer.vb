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
        Me.lstTriangle = New System.Windows.Forms.ListBox()
        Me.btnTriangle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstTriangle
        '
        Me.lstTriangle.FormattingEnabled = True
        Me.lstTriangle.ItemHeight = 20
        Me.lstTriangle.Location = New System.Drawing.Point(48, 26)
        Me.lstTriangle.Name = "lstTriangle"
        Me.lstTriangle.Size = New System.Drawing.Size(412, 344)
        Me.lstTriangle.TabIndex = 0
        '
        'btnTriangle
        '
        Me.btnTriangle.Location = New System.Drawing.Point(192, 394)
        Me.btnTriangle.Name = "btnTriangle"
        Me.btnTriangle.Size = New System.Drawing.Size(125, 35)
        Me.btnTriangle.TabIndex = 1
        Me.btnTriangle.Text = "Draw Triangle"
        Me.btnTriangle.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 472)
        Me.Controls.Add(Me.btnTriangle)
        Me.Controls.Add(Me.lstTriangle)
        Me.Name = "Form1"
        Me.Text = "Draw Triangle"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstTriangle As System.Windows.Forms.ListBox
    Friend WithEvents btnTriangle As System.Windows.Forms.Button

End Class
