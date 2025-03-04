<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtHour = New TextBox()
        txtMinute = New TextBox()
        btnPlusHour = New Button()
        btnMinHour = New Button()
        btnMinMinute = New Button()
        btnPlusMinute = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnOk = New Button()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' txtHour
        ' 
        txtHour.Location = New Point(101, 153)
        txtHour.Name = "txtHour"
        txtHour.Size = New Size(105, 35)
        txtHour.TabIndex = 0
        ' 
        ' txtMinute
        ' 
        txtMinute.Location = New Point(289, 153)
        txtMinute.Name = "txtMinute"
        txtMinute.Size = New Size(105, 35)
        txtMinute.TabIndex = 1
        ' 
        ' btnPlusHour
        ' 
        btnPlusHour.BackColor = Color.FromArgb(CByte(41), CByte(49), CByte(68))
        btnPlusHour.FlatAppearance.BorderSize = 0
        btnPlusHour.FlatAppearance.MouseDownBackColor = Color.White
        btnPlusHour.FlatStyle = FlatStyle.Flat
        btnPlusHour.ForeColor = Color.White
        btnPlusHour.Location = New Point(101, 78)
        btnPlusHour.Name = "btnPlusHour"
        btnPlusHour.Size = New Size(105, 50)
        btnPlusHour.TabIndex = 2
        btnPlusHour.Text = "+"
        btnPlusHour.UseVisualStyleBackColor = False
        ' 
        ' btnMinHour
        ' 
        btnMinHour.BackColor = Color.FromArgb(CByte(41), CByte(49), CByte(68))
        btnMinHour.FlatAppearance.BorderSize = 0
        btnMinHour.FlatAppearance.MouseDownBackColor = Color.White
        btnMinHour.FlatStyle = FlatStyle.Flat
        btnMinHour.ForeColor = Color.White
        btnMinHour.Location = New Point(101, 215)
        btnMinHour.Name = "btnMinHour"
        btnMinHour.Size = New Size(105, 50)
        btnMinHour.TabIndex = 3
        btnMinHour.Text = "-"
        btnMinHour.UseVisualStyleBackColor = False
        ' 
        ' btnMinMinute
        ' 
        btnMinMinute.BackColor = Color.FromArgb(CByte(41), CByte(49), CByte(68))
        btnMinMinute.FlatAppearance.BorderSize = 0
        btnMinMinute.FlatAppearance.MouseDownBackColor = Color.White
        btnMinMinute.FlatStyle = FlatStyle.Flat
        btnMinMinute.ForeColor = Color.White
        btnMinMinute.Location = New Point(289, 215)
        btnMinMinute.Name = "btnMinMinute"
        btnMinMinute.Size = New Size(105, 50)
        btnMinMinute.TabIndex = 5
        btnMinMinute.Text = "-"
        btnMinMinute.UseVisualStyleBackColor = False
        ' 
        ' btnPlusMinute
        ' 
        btnPlusMinute.BackColor = Color.FromArgb(CByte(41), CByte(49), CByte(68))
        btnPlusMinute.FlatAppearance.BorderSize = 0
        btnPlusMinute.FlatAppearance.MouseDownBackColor = Color.White
        btnPlusMinute.FlatStyle = FlatStyle.Flat
        btnPlusMinute.ForeColor = Color.White
        btnPlusMinute.Location = New Point(289, 78)
        btnPlusMinute.Name = "btnPlusMinute"
        btnPlusMinute.Size = New Size(105, 50)
        btnPlusMinute.TabIndex = 4
        btnPlusMinute.Text = "+"
        btnPlusMinute.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(104, 280)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 45)
        Label1.TabIndex = 6
        Label1.Text = "Hour"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(278, 280)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 45)
        Label2.TabIndex = 7
        Label2.Text = "Minute"
        ' 
        ' btnOk
        ' 
        btnOk.BackColor = Color.FromArgb(CByte(41), CByte(49), CByte(68))
        btnOk.FlatAppearance.BorderSize = 0
        btnOk.FlatAppearance.MouseDownBackColor = Color.White
        btnOk.FlatStyle = FlatStyle.Flat
        btnOk.Font = New Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOk.ForeColor = Color.White
        btnOk.Location = New Point(554, 124)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(105, 50)
        btnOk.TabIndex = 8
        btnOk.Text = "OK"
        btnOk.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(41), CByte(49), CByte(68))
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.FlatAppearance.MouseDownBackColor = Color.White
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.ForeColor = Color.White
        btnReset.Location = New Point(554, 197)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(105, 50)
        btnReset.TabIndex = 9
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(55), CByte(63), CByte(81))
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(btnOk)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnMinMinute)
        Controls.Add(btnPlusMinute)
        Controls.Add(btnMinHour)
        Controls.Add(btnPlusHour)
        Controls.Add(txtMinute)
        Controls.Add(txtHour)
        Name = "Form2"
        Text = "Timer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtHour As TextBox
    Friend WithEvents txtMinute As TextBox
    Friend WithEvents btnPlusHour As Button
    Friend WithEvents btnMinHour As Button
    Friend WithEvents btnMinMinute As Button
    Friend WithEvents btnPlusMinute As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnReset As Button
End Class
