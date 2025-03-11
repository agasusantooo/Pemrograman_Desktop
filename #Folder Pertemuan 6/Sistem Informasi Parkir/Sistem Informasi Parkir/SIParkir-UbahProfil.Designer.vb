<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUbahProfil
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
        buttonTutup = New Button()
        buttonSimpan = New Button()
        textboxPassword = New TextBox()
        textboxUsername = New TextBox()
        labelPasswordBaru = New Label()
        labelUsername = New Label()
        TextBox1 = New TextBox()
        labelConfirmPassword = New Label()
        SuspendLayout()
        ' 
        ' buttonTutup
        ' 
        buttonTutup.Location = New Point(429, 291)
        buttonTutup.Name = "buttonTutup"
        buttonTutup.Size = New Size(147, 51)
        buttonTutup.TabIndex = 11
        buttonTutup.Text = "Tutup"
        buttonTutup.UseVisualStyleBackColor = True
        ' 
        ' buttonSimpan
        ' 
        buttonSimpan.Location = New Point(252, 291)
        buttonSimpan.Name = "buttonSimpan"
        buttonSimpan.Size = New Size(147, 51)
        buttonSimpan.TabIndex = 10
        buttonSimpan.Text = "Simpan"
        buttonSimpan.UseVisualStyleBackColor = True
        ' 
        ' textboxPassword
        ' 
        textboxPassword.Font = New Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        textboxPassword.Location = New Point(390, 144)
        textboxPassword.Name = "textboxPassword"
        textboxPassword.Size = New Size(343, 51)
        textboxPassword.TabIndex = 9
        ' 
        ' textboxUsername
        ' 
        textboxUsername.Font = New Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        textboxUsername.Location = New Point(390, 74)
        textboxUsername.Name = "textboxUsername"
        textboxUsername.ReadOnly = True
        textboxUsername.Size = New Size(343, 51)
        textboxUsername.TabIndex = 8
        ' 
        ' labelPasswordBaru
        ' 
        labelPasswordBaru.AutoSize = True
        labelPasswordBaru.Font = New Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold)
        labelPasswordBaru.Location = New Point(98, 147)
        labelPasswordBaru.Name = "labelPasswordBaru"
        labelPasswordBaru.Size = New Size(237, 45)
        labelPasswordBaru.TabIndex = 7
        labelPasswordBaru.Text = "Password Baru"
        ' 
        ' labelUsername
        ' 
        labelUsername.AutoSize = True
        labelUsername.Font = New Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold)
        labelUsername.Location = New Point(98, 77)
        labelUsername.Name = "labelUsername"
        labelUsername.Size = New Size(170, 45)
        labelUsername.TabIndex = 6
        labelUsername.Text = "Username"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(390, 217)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(343, 51)
        TextBox1.TabIndex = 13
        ' 
        ' labelConfirmPassword
        ' 
        labelConfirmPassword.AutoSize = True
        labelConfirmPassword.Font = New Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold)
        labelConfirmPassword.Location = New Point(98, 220)
        labelConfirmPassword.Name = "labelConfirmPassword"
        labelConfirmPassword.Size = New Size(290, 45)
        labelConfirmPassword.TabIndex = 12
        labelConfirmPassword.Text = "Confirm Password"
        ' 
        ' formUbahProfil
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(labelConfirmPassword)
        Controls.Add(buttonTutup)
        Controls.Add(buttonSimpan)
        Controls.Add(textboxPassword)
        Controls.Add(textboxUsername)
        Controls.Add(labelPasswordBaru)
        Controls.Add(labelUsername)
        Name = "formUbahProfil"
        Text = "SIParkir - Ubah Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents buttonTutup As Button
    Friend WithEvents buttonSimpan As Button
    Friend WithEvents textboxPassword As TextBox
    Friend WithEvents textboxUsername As TextBox
    Friend WithEvents labelPasswordBaru As Label
    Friend WithEvents labelUsername As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents labelConfirmPassword As Label
End Class
