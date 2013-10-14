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
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnComputeFactorial = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(110, 37)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(162, 26)
        Me.txtN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "N="
        '
        'btnComputeFactorial
        '
        Me.btnComputeFactorial.Location = New System.Drawing.Point(132, 85)
        Me.btnComputeFactorial.Name = "btnComputeFactorial"
        Me.btnComputeFactorial.Size = New System.Drawing.Size(110, 30)
        Me.btnComputeFactorial.TabIndex = 2
        Me.btnComputeFactorial.Text = "Compute N!"
        Me.btnComputeFactorial.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 163)
        Me.Controls.Add(Me.btnComputeFactorial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtN)
        Me.Name = "Form1"
        Me.Text = "Factorial Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnComputeFactorial As System.Windows.Forms.Button

End Class
