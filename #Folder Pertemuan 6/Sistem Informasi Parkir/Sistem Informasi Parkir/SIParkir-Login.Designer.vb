<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLogin
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
        labelUsername = New Label()
        labelPassword = New Label()
        textboxUsername = New TextBox()
        textboxPassword = New TextBox()
        buttonLogin = New Button()
        buttonKeluar = New Button()
        SuspendLayout()
        ' 
        ' labelUsername
        ' 
        labelUsername.AutoSize = True
        labelUsername.Font = New Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold)
        labelUsername.Location = New Point(122, 111)
        labelUsername.Name = "labelUsername"
        labelUsername.Size = New Size(170, 45)
        labelUsername.TabIndex = 0
        labelUsername.Text = "Username"
        ' 
        ' labelPassword
        ' 
        labelPassword.AutoSize = True
        labelPassword.Font = New Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold)
        labelPassword.Location = New Point(122, 181)
        labelPassword.Name = "labelPassword"
        labelPassword.Size = New Size(160, 45)
        labelPassword.TabIndex = 1
        labelPassword.Text = "Password"
        ' 
        ' textboxUsername
        ' 
        textboxUsername.Font = New Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        textboxUsername.Location = New Point(345, 108)
        textboxUsername.Name = "textboxUsername"
        textboxUsername.Size = New Size(343, 51)
        textboxUsername.TabIndex = 2
        ' 
        ' textboxPassword
        ' 
        textboxPassword.Font = New Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        textboxPassword.Location = New Point(345, 178)
        textboxPassword.Name = "textboxPassword"
        textboxPassword.Size = New Size(343, 51)
        textboxPassword.TabIndex = 3
        ' 
        ' buttonLogin
        ' 
        buttonLogin.Location = New Point(231, 277)
        buttonLogin.Name = "buttonLogin"
        buttonLogin.Size = New Size(147, 51)
        buttonLogin.TabIndex = 4
        buttonLogin.Text = "Login"
        buttonLogin.UseVisualStyleBackColor = True
        ' 
        ' buttonKeluar
        ' 
        buttonKeluar.Location = New Point(408, 277)
        buttonKeluar.Name = "buttonKeluar"
        buttonKeluar.Size = New Size(147, 51)
        buttonKeluar.TabIndex = 5
        buttonKeluar.Text = "Keluar"
        buttonKeluar.UseVisualStyleBackColor = True
        ' 
        ' formLogin
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(buttonKeluar)
        Controls.Add(buttonLogin)
        Controls.Add(textboxPassword)
        Controls.Add(textboxUsername)
        Controls.Add(labelPassword)
        Controls.Add(labelUsername)
        Name = "formLogin"
        Text = "SIParkir - Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelUsername As Label
    Friend WithEvents labelPassword As Label
    Friend WithEvents textboxUsername As TextBox
    Friend WithEvents textboxPassword As TextBox
    Friend WithEvents buttonLogin As Button
    Friend WithEvents buttonKeluar As Button

End Class
