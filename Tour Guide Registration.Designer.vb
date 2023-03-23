<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tour_Guide_Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tour_Guide_Registration))
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtServices = New System.Windows.Forms.TextBox()
        Me.lblPerHour = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnProfile.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Location = New System.Drawing.Point(185, 173)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(124, 40)
        Me.btnProfile.TabIndex = 3
        Me.btnProfile.Text = "Profile Picture"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'lblServices
        '
        Me.lblServices.AutoSize = True
        Me.lblServices.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.Location = New System.Drawing.Point(131, 232)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(74, 20)
        Me.lblServices.TabIndex = 4
        Me.lblServices.Text = "Services:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(131, 363)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(133, 20)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "Cost Demanded:"
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(135, 391)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(119, 26)
        Me.txtCost.TabIndex = 7
        '
        'txtServices
        '
        Me.txtServices.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServices.Location = New System.Drawing.Point(134, 269)
        Me.txtServices.Multiline = True
        Me.txtServices.Name = "txtServices"
        Me.txtServices.Size = New System.Drawing.Size(246, 71)
        Me.txtServices.TabIndex = 8
        '
        'lblPerHour
        '
        Me.lblPerHour.AutoSize = True
        Me.lblPerHour.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerHour.Location = New System.Drawing.Point(274, 397)
        Me.lblPerHour.Name = "lblPerHour"
        Me.lblPerHour.Size = New System.Drawing.Size(71, 20)
        Me.lblPerHour.TabIndex = 9
        Me.lblPerHour.Text = "per hour"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(120, 460)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 40)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnRegister.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(267, 460)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(95, 40)
        Me.btnRegister.TabIndex = 11
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'picProfile
        '
        Me.picProfile.Location = New System.Drawing.Point(171, 17)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(151, 150)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 2
        Me.picProfile.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.VACCAL_COMPANY.My.Resources.Resources.Background
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(115, 818)
        Me.Panel1.TabIndex = 0
        '
        'Tour_Guide_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(472, 513)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblPerHour)
        Me.Controls.Add(Me.txtServices)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblServices)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tour_Guide_Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tour Guide Registration"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnProfile As Button
    Friend WithEvents lblServices As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtServices As TextBox
    Friend WithEvents lblPerHour As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRegister As Button
End Class
