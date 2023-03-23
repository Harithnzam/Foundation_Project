<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Card_Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Card_Payment))
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gboCardDetails = New System.Windows.Forms.GroupBox()
        Me.txtCVV = New System.Windows.Forms.MaskedTextBox()
        Me.txtCardNum = New System.Windows.Forms.MaskedTextBox()
        Me.lblCVV = New System.Windows.Forms.Label()
        Me.lblCardNum = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gboCardPay = New System.Windows.Forms.GroupBox()
        Me.rbMaster = New System.Windows.Forms.RadioButton()
        Me.rbVisa = New System.Windows.Forms.RadioButton()
        Me.gboCardDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gboCardPay.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnProceed.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.Location = New System.Drawing.Point(297, 460)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(95, 40)
        Me.btnProceed.TabIndex = 8
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(185, 460)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 40)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'gboCardDetails
        '
        Me.gboCardDetails.Controls.Add(Me.txtCVV)
        Me.gboCardDetails.Controls.Add(Me.txtCardNum)
        Me.gboCardDetails.Controls.Add(Me.lblCVV)
        Me.gboCardDetails.Controls.Add(Me.lblCardNum)
        Me.gboCardDetails.Controls.Add(Me.lblYear)
        Me.gboCardDetails.Controls.Add(Me.lblMonth)
        Me.gboCardDetails.Controls.Add(Me.ComboBox2)
        Me.gboCardDetails.Controls.Add(Me.cboMonth)
        Me.gboCardDetails.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboCardDetails.ForeColor = System.Drawing.Color.White
        Me.gboCardDetails.Location = New System.Drawing.Point(49, 140)
        Me.gboCardDetails.Name = "gboCardDetails"
        Me.gboCardDetails.Size = New System.Drawing.Size(374, 308)
        Me.gboCardDetails.TabIndex = 6
        Me.gboCardDetails.TabStop = False
        Me.gboCardDetails.Text = "Card Details"
        '
        'txtCVV
        '
        Me.txtCVV.Location = New System.Drawing.Point(42, 248)
        Me.txtCVV.Mask = "000"
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(65, 28)
        Me.txtCVV.TabIndex = 11
        Me.txtCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCardNum
        '
        Me.txtCardNum.AsciiOnly = True
        Me.txtCardNum.Location = New System.Drawing.Point(42, 84)
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(301, 28)
        Me.txtCardNum.TabIndex = 10
        Me.txtCardNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCVV
        '
        Me.lblCVV.AutoSize = True
        Me.lblCVV.Location = New System.Drawing.Point(42, 216)
        Me.lblCVV.Name = "lblCVV"
        Me.lblCVV.Size = New System.Drawing.Size(46, 19)
        Me.lblCVV.TabIndex = 8
        Me.lblCVV.Text = "CVV"
        '
        'lblCardNum
        '
        Me.lblCardNum.AutoSize = True
        Me.lblCardNum.Location = New System.Drawing.Point(38, 41)
        Me.lblCardNum.Name = "lblCardNum"
        Me.lblCardNum.Size = New System.Drawing.Size(120, 19)
        Me.lblCardNum.TabIndex = 6
        Me.lblCardNum.Text = "Card Number"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(218, 132)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(57, 19)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year :"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(38, 132)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(69, 19)
        Me.lblMonth.TabIndex = 4
        Me.lblMonth.Text = "Month :"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
        Me.ComboBox2.Location = New System.Drawing.Point(222, 164)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox2.TabIndex = 3
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(42, 164)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 27)
        Me.cboMonth.TabIndex = 2
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(75, 460)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 40)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.gboCardPay)
        Me.Panel1.Location = New System.Drawing.Point(-12, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 133)
        Me.Panel1.TabIndex = 9
        '
        'gboCardPay
        '
        Me.gboCardPay.Controls.Add(Me.rbMaster)
        Me.gboCardPay.Controls.Add(Me.rbVisa)
        Me.gboCardPay.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboCardPay.ForeColor = System.Drawing.Color.White
        Me.gboCardPay.Location = New System.Drawing.Point(61, 11)
        Me.gboCardPay.Name = "gboCardPay"
        Me.gboCardPay.Size = New System.Drawing.Size(374, 112)
        Me.gboCardPay.TabIndex = 10
        Me.gboCardPay.TabStop = False
        Me.gboCardPay.Text = "Types of Card"
        '
        'rbMaster
        '
        Me.rbMaster.BackgroundImage = CType(resources.GetObject("rbMaster.BackgroundImage"), System.Drawing.Image)
        Me.rbMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbMaster.Location = New System.Drawing.Point(187, 27)
        Me.rbMaster.Name = "rbMaster"
        Me.rbMaster.Size = New System.Drawing.Size(156, 68)
        Me.rbMaster.TabIndex = 1
        Me.rbMaster.TabStop = True
        Me.rbMaster.UseVisualStyleBackColor = True
        '
        'rbVisa
        '
        Me.rbVisa.BackgroundImage = CType(resources.GetObject("rbVisa.BackgroundImage"), System.Drawing.Image)
        Me.rbVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbVisa.Location = New System.Drawing.Point(17, 27)
        Me.rbVisa.Name = "rbVisa"
        Me.rbVisa.Size = New System.Drawing.Size(156, 68)
        Me.rbVisa.TabIndex = 0
        Me.rbVisa.TabStop = True
        Me.rbVisa.UseVisualStyleBackColor = True
        '
        'Card_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(472, 513)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gboCardDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Card_Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Payment"
        Me.gboCardDetails.ResumeLayout(False)
        Me.gboCardDetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gboCardPay.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProceed As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents gboCardDetails As GroupBox
    Friend WithEvents lblCVV As Label
    Friend WithEvents lblCardNum As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gboCardPay As GroupBox
    Friend WithEvents rbMaster As RadioButton
    Friend WithEvents rbVisa As RadioButton
    Friend WithEvents txtCVV As MaskedTextBox
    Friend WithEvents txtCardNum As MaskedTextBox
    Friend WithEvents btnBack As Button
End Class
