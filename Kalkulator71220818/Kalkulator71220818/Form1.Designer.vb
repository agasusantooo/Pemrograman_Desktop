<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        txtInput = New TextBox()
        Panel2 = New Panel()
        cmdEqual = New Button()
        cmdAddition = New Button()
        cmdInverse = New Button()
        cmdSubstraction = New Button()
        cmdSqrt = New Button()
        cmdMultiply = New Button()
        cmdDecimal = New Button()
        cmdSign = New Button()
        cmd0 = New Button()
        cmdPowerOf = New Button()
        cmdDivision = New Button()
        cmd3 = New Button()
        cmd2 = New Button()
        cmd1 = New Button()
        cmd6 = New Button()
        cmd5 = New Button()
        cmd4 = New Button()
        cmd9 = New Button()
        cmd8 = New Button()
        cmd7 = New Button()
        cmdCE = New Button()
        cmdC = New Button()
        cmdBackspace = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtInput)
        Panel1.Location = New Point(82, 40)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(297, 65)
        Panel1.TabIndex = 0
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInput.Location = New Point(13, 11)
        txtInput.Multiline = True
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(268, 44)
        txtInput.TabIndex = 0
        txtInput.Text = "0"
        txtInput.TextAlign = HorizontalAlignment.Right
        txtInput.WordWrap = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(cmdEqual)
        Panel2.Controls.Add(cmdAddition)
        Panel2.Controls.Add(cmdInverse)
        Panel2.Controls.Add(cmdSubstraction)
        Panel2.Controls.Add(cmdSqrt)
        Panel2.Controls.Add(cmdMultiply)
        Panel2.Controls.Add(cmdDecimal)
        Panel2.Controls.Add(cmdSign)
        Panel2.Controls.Add(cmd0)
        Panel2.Controls.Add(cmdPowerOf)
        Panel2.Controls.Add(cmdDivision)
        Panel2.Controls.Add(cmd3)
        Panel2.Controls.Add(cmd2)
        Panel2.Controls.Add(cmd1)
        Panel2.Controls.Add(cmd6)
        Panel2.Controls.Add(cmd5)
        Panel2.Controls.Add(cmd4)
        Panel2.Controls.Add(cmd9)
        Panel2.Controls.Add(cmd8)
        Panel2.Controls.Add(cmd7)
        Panel2.Controls.Add(cmdCE)
        Panel2.Controls.Add(cmdC)
        Panel2.Controls.Add(cmdBackspace)
        Panel2.Location = New Point(83, 111)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(296, 228)
        Panel2.TabIndex = 1
        ' 
        ' cmdEqual
        ' 
        cmdEqual.Location = New Point(240, 179)
        cmdEqual.Name = "cmdEqual"
        cmdEqual.Size = New Size(40, 40)
        cmdEqual.TabIndex = 22
        cmdEqual.Text = "="
        cmdEqual.UseVisualStyleBackColor = True
        ' 
        ' cmdAddition
        ' 
        cmdAddition.Location = New Point(194, 179)
        cmdAddition.Name = "cmdAddition"
        cmdAddition.Size = New Size(40, 40)
        cmdAddition.TabIndex = 21
        cmdAddition.Text = "+"
        cmdAddition.UseVisualStyleBackColor = True
        ' 
        ' cmdInverse
        ' 
        cmdInverse.Location = New Point(240, 133)
        cmdInverse.Name = "cmdInverse"
        cmdInverse.Size = New Size(40, 40)
        cmdInverse.TabIndex = 20
        cmdInverse.Text = "1/X"
        cmdInverse.UseVisualStyleBackColor = True
        ' 
        ' cmdSubstraction
        ' 
        cmdSubstraction.Location = New Point(194, 133)
        cmdSubstraction.Name = "cmdSubstraction"
        cmdSubstraction.Size = New Size(40, 40)
        cmdSubstraction.TabIndex = 19
        cmdSubstraction.Text = "-"
        cmdSubstraction.UseVisualStyleBackColor = True
        ' 
        ' cmdSqrt
        ' 
        cmdSqrt.Font = New Font("Segoe UI", 7.0F)
        cmdSqrt.Location = New Point(240, 87)
        cmdSqrt.Name = "cmdSqrt"
        cmdSqrt.Size = New Size(40, 40)
        cmdSqrt.TabIndex = 18
        cmdSqrt.Text = "SQRT"
        cmdSqrt.UseVisualStyleBackColor = True
        ' 
        ' cmdMultiply
        ' 
        cmdMultiply.Location = New Point(194, 87)
        cmdMultiply.Name = "cmdMultiply"
        cmdMultiply.Size = New Size(40, 40)
        cmdMultiply.TabIndex = 17
        cmdMultiply.Text = "*"
        cmdMultiply.UseVisualStyleBackColor = True
        ' 
        ' cmdDecimal
        ' 
        cmdDecimal.Location = New Point(106, 179)
        cmdDecimal.Name = "cmdDecimal"
        cmdDecimal.Size = New Size(40, 40)
        cmdDecimal.TabIndex = 16
        cmdDecimal.Text = "."
        cmdDecimal.UseVisualStyleBackColor = True
        ' 
        ' cmdSign
        ' 
        cmdSign.Location = New Point(60, 179)
        cmdSign.Name = "cmdSign"
        cmdSign.Size = New Size(40, 40)
        cmdSign.TabIndex = 15
        cmdSign.Text = "+/-"
        cmdSign.UseVisualStyleBackColor = True
        ' 
        ' cmd0
        ' 
        cmd0.Location = New Point(14, 179)
        cmd0.Name = "cmd0"
        cmd0.Size = New Size(40, 40)
        cmd0.TabIndex = 14
        cmd0.Text = "0"
        cmd0.UseVisualStyleBackColor = True
        ' 
        ' cmdPowerOf
        ' 
        cmdPowerOf.Location = New Point(240, 41)
        cmdPowerOf.Name = "cmdPowerOf"
        cmdPowerOf.Size = New Size(40, 40)
        cmdPowerOf.TabIndex = 13
        cmdPowerOf.Text = "X^"
        cmdPowerOf.UseVisualStyleBackColor = True
        ' 
        ' cmdDivision
        ' 
        cmdDivision.Location = New Point(194, 41)
        cmdDivision.Name = "cmdDivision"
        cmdDivision.Size = New Size(40, 40)
        cmdDivision.TabIndex = 12
        cmdDivision.Text = "/"
        cmdDivision.UseVisualStyleBackColor = True
        ' 
        ' cmd3
        ' 
        cmd3.Location = New Point(106, 133)
        cmd3.Name = "cmd3"
        cmd3.Size = New Size(40, 40)
        cmd3.TabIndex = 11
        cmd3.Text = "3"
        cmd3.UseVisualStyleBackColor = True
        ' 
        ' cmd2
        ' 
        cmd2.Location = New Point(60, 133)
        cmd2.Name = "cmd2"
        cmd2.Size = New Size(40, 40)
        cmd2.TabIndex = 10
        cmd2.Text = "2"
        cmd2.UseVisualStyleBackColor = True
        ' 
        ' cmd1
        ' 
        cmd1.Location = New Point(14, 133)
        cmd1.Name = "cmd1"
        cmd1.Size = New Size(40, 40)
        cmd1.TabIndex = 9
        cmd1.Text = "1"
        cmd1.UseVisualStyleBackColor = True
        ' 
        ' cmd6
        ' 
        cmd6.Location = New Point(106, 87)
        cmd6.Name = "cmd6"
        cmd6.Size = New Size(40, 40)
        cmd6.TabIndex = 8
        cmd6.Text = "6"
        cmd6.UseVisualStyleBackColor = True
        ' 
        ' cmd5
        ' 
        cmd5.Location = New Point(60, 87)
        cmd5.Name = "cmd5"
        cmd5.Size = New Size(40, 40)
        cmd5.TabIndex = 7
        cmd5.Text = "5"
        cmd5.UseVisualStyleBackColor = True
        ' 
        ' cmd4
        ' 
        cmd4.Location = New Point(14, 87)
        cmd4.Name = "cmd4"
        cmd4.Size = New Size(40, 40)
        cmd4.TabIndex = 6
        cmd4.Text = "4"
        cmd4.UseVisualStyleBackColor = True
        ' 
        ' cmd9
        ' 
        cmd9.Location = New Point(106, 41)
        cmd9.Name = "cmd9"
        cmd9.Size = New Size(40, 40)
        cmd9.TabIndex = 5
        cmd9.Text = "9"
        cmd9.UseVisualStyleBackColor = True
        ' 
        ' cmd8
        ' 
        cmd8.Location = New Point(60, 41)
        cmd8.Name = "cmd8"
        cmd8.Size = New Size(40, 40)
        cmd8.TabIndex = 4
        cmd8.Text = "8"
        cmd8.UseVisualStyleBackColor = True
        ' 
        ' cmd7
        ' 
        cmd7.Location = New Point(14, 41)
        cmd7.Name = "cmd7"
        cmd7.Size = New Size(40, 40)
        cmd7.TabIndex = 3
        cmd7.Text = "7"
        cmd7.UseVisualStyleBackColor = True
        ' 
        ' cmdCE
        ' 
        cmdCE.Location = New Point(240, 12)
        cmdCE.Name = "cmdCE"
        cmdCE.Size = New Size(40, 23)
        cmdCE.TabIndex = 2
        cmdCE.Text = "CE"
        cmdCE.UseVisualStyleBackColor = True
        ' 
        ' cmdC
        ' 
        cmdC.Location = New Point(194, 12)
        cmdC.Name = "cmdC"
        cmdC.Size = New Size(40, 23)
        cmdC.TabIndex = 1
        cmdC.Text = "C"
        cmdC.UseVisualStyleBackColor = True
        ' 
        ' cmdBackspace
        ' 
        cmdBackspace.Location = New Point(12, 12)
        cmdBackspace.Name = "cmdBackspace"
        cmdBackspace.Size = New Size(88, 23)
        cmdBackspace.TabIndex = 0
        cmdBackspace.Text = "Backspace"
        cmdBackspace.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(453, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Calculator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdC As Button
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents cmdPowerOf As Button
    Friend WithEvents cmdDivision As Button
    Friend WithEvents cmdDecimal As Button
    Friend WithEvents cmdSign As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdEqual As Button
    Friend WithEvents cmdAddition As Button
    Friend WithEvents cmdInverse As Button
    Friend WithEvents cmdSubstraction As Button
    Friend WithEvents cmdSqrt As Button

End Class
