<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmageindays
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
        Me.txtageinyears = New System.Windows.Forms.TextBox()
        Me.lblinstruction = New System.Windows.Forms.Label()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.lblageindays = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtageinyears
        '
        Me.txtageinyears.Location = New System.Drawing.Point(28, 111)
        Me.txtageinyears.Name = "txtageinyears"
        Me.txtageinyears.Size = New System.Drawing.Size(226, 22)
        Me.txtageinyears.TabIndex = 0
        '
        'lblinstruction
        '
        Me.lblinstruction.AutoSize = True
        Me.lblinstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinstruction.Location = New System.Drawing.Point(24, 53)
        Me.lblinstruction.Name = "lblinstruction"
        Me.lblinstruction.Size = New System.Drawing.Size(230, 20)
        Me.lblinstruction.TabIndex = 1
        Me.lblinstruction.Text = "Please Enter Age in Years"
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(90, 167)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(80, 23)
        Me.btncalculate.TabIndex = 2
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'lblageindays
        '
        Me.lblageindays.AutoSize = True
        Me.lblageindays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblageindays.Location = New System.Drawing.Point(24, 232)
        Me.lblageindays.Name = "lblageindays"
        Me.lblageindays.Size = New System.Drawing.Size(188, 20)
        Me.lblageindays.TabIndex = 3
        Me.lblageindays.Text = "Your Age in Days is: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmageindays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 331)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblageindays)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.lblinstruction)
        Me.Controls.Add(Me.txtageinyears)
        Me.MaximumSize = New System.Drawing.Size(333, 378)
        Me.MinimumSize = New System.Drawing.Size(333, 378)
        Me.Name = "frmageindays"
        Me.Text = "Age in Days"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtageinyears As TextBox
    Friend WithEvents lblinstruction As Label
    Friend WithEvents btncalculate As Button
    Friend WithEvents lblageindays As Label
    Friend WithEvents Button1 As Button
End Class
