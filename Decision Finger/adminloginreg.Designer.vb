<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminloginreg
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Buttonadminlogin = New System.Windows.Forms.Button()
        Me.Buttoncancel = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBoxadminpassword = New System.Windows.Forms.TextBox()
        Me.TextBoxadminusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Buttonadminlogin)
        Me.Panel1.Controls.Add(Me.Buttoncancel)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.TextBoxadminpassword)
        Me.Panel1.Controls.Add(Me.TextBoxadminusername)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(950, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 450)
        Me.Panel1.TabIndex = 2
        '
        'Buttonadminlogin
        '
        Me.Buttonadminlogin.BackColor = System.Drawing.Color.black
        Me.Buttonadminlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buttonadminlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.green
        Me.Buttonadminlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonadminlogin.Font = New System.Drawing.Font("Point Panther", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonadminlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Buttonadminlogin.Location = New System.Drawing.Point(240, 340)
        Me.Buttonadminlogin.Name = "Buttonadminlogin"
        Me.Buttonadminlogin.Size = New System.Drawing.Size(115, 60)
        Me.Buttonadminlogin.TabIndex = 11
        Me.Buttonadminlogin.Text = "LOGIN"
        Me.Buttonadminlogin.UseVisualStyleBackColor = False
        '
        'Buttoncancel
        '
        Me.Buttoncancel.BackColor = System.Drawing.Color.black
        Me.Buttoncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buttoncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.red
        Me.Buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttoncancel.Font = New System.Drawing.Font("Point Panther", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttoncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Buttoncancel.Location = New System.Drawing.Point(52, 340)
        Me.Buttoncancel.Name = "Buttoncancel"
        Me.Buttoncancel.Size = New System.Drawing.Size(115, 60)
        Me.Buttoncancel.TabIndex = 10S
        Me.Buttoncancel.Text = "CANCEL"
        Me.Buttoncancel.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBox1.Location = New System.Drawing.Point(250, 265)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 30)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Show Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'TextBoxadminpassword
        '
        Me.TextBoxadminpassword.Font = New System.Drawing.Font("Manrope Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxadminpassword.Location = New System.Drawing.Point(178, 230)
        Me.TextBoxadminpassword.Name = "TextBoxadminpassword"
        Me.TextBoxadminpassword.Size = New System.Drawing.Size(170, 30)
        Me.TextBoxadminpassword.TabIndex = 6
        Me.TextBoxadminpassword.UseSystemPasswordChar = True
        '
        'TextBoxadminusername
        '
        Me.TextBoxadminusername.Font = New System.Drawing.Font("Manrope Bold ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxadminusername.Location = New System.Drawing.Point(177, 178)
        Me.TextBoxadminusername.Name = "TextBoxadminusername"
        Me.TextBoxadminusername.Size = New System.Drawing.Size(170, 30)
        Me.TextBoxadminusername.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Point Panther", 15.00!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(47, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Point Panther", 15.00!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(47, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User Name "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Point Panther", 50.00!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " LOGIN "
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(599, 28)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(111, 104)
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'adminloginreg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Decision_Finger.My.Resources.Resources._28a1ca72_ab9f_11e8_8465_1eef8cfbb700
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1124, 749)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "adminloginreg"
        Me.Text = "adminloginreg"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Buttonadminlogin As Button
    Friend WithEvents Buttoncancel As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBoxadminpassword As TextBox
    Friend WithEvents TextBoxadminusername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
