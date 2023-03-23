<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Online_Banking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Online_Banking))
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblVaccalAccNum = New System.Windows.Forms.Label()
        Me.lblVaccalAccHolder = New System.Windows.Forms.Label()
        Me.lblVaccalBank = New System.Windows.Forms.Label()
        Me.lblAccNum = New System.Windows.Forms.Label()
        Me.lblAccHolder = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(67, 302)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(330, 38)
        Me.lblInfo.TabIndex = 31
        Me.lblInfo.Text = "SCAN THE QR CODE AND SCREENSHOT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THE TRANSACTIONAL RECEIPT"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVaccalAccNum
        '
        Me.lblVaccalAccNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVaccalAccNum.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaccalAccNum.Location = New System.Drawing.Point(227, 224)
        Me.lblVaccalAccNum.Name = "lblVaccalAccNum"
        Me.lblVaccalAccNum.Size = New System.Drawing.Size(190, 35)
        Me.lblVaccalAccNum.TabIndex = 27
        Me.lblVaccalAccNum.Text = "162042119506"
        '
        'lblVaccalAccHolder
        '
        Me.lblVaccalAccHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVaccalAccHolder.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaccalAccHolder.Location = New System.Drawing.Point(227, 166)
        Me.lblVaccalAccHolder.Name = "lblVaccalAccHolder"
        Me.lblVaccalAccHolder.Size = New System.Drawing.Size(190, 35)
        Me.lblVaccalAccHolder.TabIndex = 26
        Me.lblVaccalAccHolder.Text = "VACCAL COMPANY"
        '
        'lblVaccalBank
        '
        Me.lblVaccalBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVaccalBank.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaccalBank.Location = New System.Drawing.Point(227, 103)
        Me.lblVaccalBank.Name = "lblVaccalBank"
        Me.lblVaccalBank.Size = New System.Drawing.Size(190, 35)
        Me.lblVaccalBank.TabIndex = 25
        Me.lblVaccalBank.Text = "MAYBANK"
        '
        'lblAccNum
        '
        Me.lblAccNum.AutoSize = True
        Me.lblAccNum.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccNum.Location = New System.Drawing.Point(62, 225)
        Me.lblAccNum.Name = "lblAccNum"
        Me.lblAccNum.Size = New System.Drawing.Size(159, 21)
        Me.lblAccNum.TabIndex = 24
        Me.lblAccNum.Text = "Account Number:"
        '
        'lblAccHolder
        '
        Me.lblAccHolder.AutoSize = True
        Me.lblAccHolder.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccHolder.Location = New System.Drawing.Point(62, 167)
        Me.lblAccHolder.Name = "lblAccHolder"
        Me.lblAccHolder.Size = New System.Drawing.Size(147, 21)
        Me.lblAccHolder.TabIndex = 23
        Me.lblAccHolder.Text = "Account Holder:"
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(63, 104)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(112, 21)
        Me.lblBank.TabIndex = 22
        Me.lblBank.Text = "Bank Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 39)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Bank Details"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Location = New System.Drawing.Point(0, 396)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 133)
        Me.Panel1.TabIndex = 32
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(309, 64)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 40)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnOK.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(189, 64)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(95, 40)
        Me.btnOK.TabIndex = 34
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(71, 64)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 40)
        Me.btnBack.TabIndex = 33
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Online_Banking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(472, 513)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblVaccalAccNum)
        Me.Controls.Add(Me.lblVaccalAccHolder)
        Me.Controls.Add(Me.lblVaccalBank)
        Me.Controls.Add(Me.lblAccNum)
        Me.Controls.Add(Me.lblAccHolder)
        Me.Controls.Add(Me.lblBank)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Online_Banking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Online Banking"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfo As Label
    Friend WithEvents lblVaccalAccNum As Label
    Friend WithEvents lblVaccalAccHolder As Label
    Friend WithEvents lblVaccalBank As Label
    Friend WithEvents lblAccNum As Label
    Friend WithEvents lblAccHolder As Label
    Friend WithEvents lblBank As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
End Class
