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
        Me.btnPayoff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPayoff
        '
        Me.btnPayoff.Location = New System.Drawing.Point(75, 107)
        Me.btnPayoff.Name = "btnPayoff"
        Me.btnPayoff.Size = New System.Drawing.Size(141, 40)
        Me.btnPayoff.TabIndex = 0
        Me.btnPayoff.Text = "Compute Payoff"
        Me.btnPayoff.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 254)
        Me.Controls.Add(Me.btnPayoff)
        Me.Name = "Form1"
        Me.Text = "Financial"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPayoff As System.Windows.Forms.Button

End Class
