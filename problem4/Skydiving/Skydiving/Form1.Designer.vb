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
        Me.btnSkyDive = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSkyDive
        '
        Me.btnSkyDive.Location = New System.Drawing.Point(85, 119)
        Me.btnSkyDive.Name = "btnSkyDive"
        Me.btnSkyDive.Size = New System.Drawing.Size(93, 30)
        Me.btnSkyDive.TabIndex = 0
        Me.btnSkyDive.Text = "SkyDive!"
        Me.btnSkyDive.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 254)
        Me.Controls.Add(Me.btnSkyDive)
        Me.Name = "Form1"
        Me.Text = "Skydiving"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSkyDive As System.Windows.Forms.Button

End Class
