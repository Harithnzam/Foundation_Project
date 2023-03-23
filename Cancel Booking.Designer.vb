<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cancel_Booking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cancel_Booking))
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.gboReasons = New System.Windows.Forms.GroupBox()
        Me.txtOthers = New System.Windows.Forms.TextBox()
        Me.rbOthers = New System.Windows.Forms.RadioButton()
        Me.rbDatTimeChange = New System.Windows.Forms.RadioButton()
        Me.rbHealth = New System.Windows.Forms.RadioButton()
        Me.rbFoundNew = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gboCancelFee = New System.Windows.Forms.GroupBox()
        Me.lblTotRefund = New System.Windows.Forms.Label()
        Me.lblTotRefundResult = New System.Windows.Forms.Label()
        Me.gboReasons.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gboCancelFee.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(58, 275)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(380, 16)
        Me.lblDesc.TabIndex = 8
        Me.lblDesc.Text = "* There will be cancellation fee for 20% off from the total amount."
        '
        'gboReasons
        '
        Me.gboReasons.Controls.Add(Me.txtOthers)
        Me.gboReasons.Controls.Add(Me.rbOthers)
        Me.gboReasons.Controls.Add(Me.rbDatTimeChange)
        Me.gboReasons.Controls.Add(Me.rbHealth)
        Me.gboReasons.Controls.Add(Me.rbFoundNew)
        Me.gboReasons.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboReasons.ForeColor = System.Drawing.Color.White
        Me.gboReasons.Location = New System.Drawing.Point(34, 16)
        Me.gboReasons.Name = "gboReasons"
        Me.gboReasons.Size = New System.Drawing.Size(404, 256)
        Me.gboReasons.TabIndex = 7
        Me.gboReasons.TabStop = False
        Me.gboReasons.Text = "Reason of Cancellation"
        '
        'txtOthers
        '
        Me.txtOthers.Location = New System.Drawing.Point(73, 202)
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(241, 28)
        Me.txtOthers.TabIndex = 4
        '
        'rbOthers
        '
        Me.rbOthers.AutoSize = True
        Me.rbOthers.Location = New System.Drawing.Point(51, 173)
        Me.rbOthers.Name = "rbOthers"
        Me.rbOthers.Size = New System.Drawing.Size(92, 23)
        Me.rbOthers.TabIndex = 3
        Me.rbOthers.TabStop = True
        Me.rbOthers.Text = "Others :"
        Me.rbOthers.UseVisualStyleBackColor = True
        '
        'rbDatTimeChange
        '
        Me.rbDatTimeChange.AutoSize = True
        Me.rbDatTimeChange.Location = New System.Drawing.Point(51, 132)
        Me.rbDatTimeChange.Name = "rbDatTimeChange"
        Me.rbDatTimeChange.Size = New System.Drawing.Size(225, 23)
        Me.rbDatTimeChange.TabIndex = 2
        Me.rbDatTimeChange.TabStop = True
        Me.rbDatTimeChange.Text = "Date and time changed"
        Me.rbDatTimeChange.UseVisualStyleBackColor = True
        '
        'rbHealth
        '
        Me.rbHealth.AutoSize = True
        Me.rbHealth.Location = New System.Drawing.Point(51, 88)
        Me.rbHealth.Name = "rbHealth"
        Me.rbHealth.Size = New System.Drawing.Size(164, 23)
        Me.rbHealth.TabIndex = 1
        Me.rbHealth.TabStop = True
        Me.rbHealth.Text = "Health problems"
        Me.rbHealth.UseVisualStyleBackColor = True
        '
        'rbFoundNew
        '
        Me.rbFoundNew.AutoSize = True
        Me.rbFoundNew.Location = New System.Drawing.Point(51, 47)
        Me.rbFoundNew.Name = "rbFoundNew"
        Me.rbFoundNew.Size = New System.Drawing.Size(263, 23)
        Me.rbFoundNew.TabIndex = 0
        Me.rbFoundNew.TabStop = True
        Me.rbFoundNew.Text = "Found a new accomodation"
        Me.rbFoundNew.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.btnProceed)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.gboCancelFee)
        Me.Panel1.Location = New System.Drawing.Point(-12, 317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 217)
        Me.Panel1.TabIndex = 12
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnProceed.Location = New System.Drawing.Point(265, 148)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(95, 40)
        Me.btnProceed.TabIndex = 14
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnBack.Location = New System.Drawing.Point(139, 148)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 40)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'gboCancelFee
        '
        Me.gboCancelFee.Controls.Add(Me.lblTotRefund)
        Me.gboCancelFee.Controls.Add(Me.lblTotRefundResult)
        Me.gboCancelFee.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboCancelFee.ForeColor = System.Drawing.Color.White
        Me.gboCancelFee.Location = New System.Drawing.Point(106, 28)
        Me.gboCancelFee.Name = "gboCancelFee"
        Me.gboCancelFee.Size = New System.Drawing.Size(280, 100)
        Me.gboCancelFee.TabIndex = 12
        Me.gboCancelFee.TabStop = False
        Me.gboCancelFee.Text = "Cancellation Fee Total"
        '
        'lblTotRefund
        '
        Me.lblTotRefund.AutoSize = True
        Me.lblTotRefund.Location = New System.Drawing.Point(15, 48)
        Me.lblTotRefund.Name = "lblTotRefund"
        Me.lblTotRefund.Size = New System.Drawing.Size(113, 19)
        Me.lblTotRefund.TabIndex = 1
        Me.lblTotRefund.Text = "Total refund :"
        '
        'lblTotRefundResult
        '
        Me.lblTotRefundResult.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotRefundResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotRefundResult.ForeColor = System.Drawing.Color.Black
        Me.lblTotRefundResult.Location = New System.Drawing.Point(147, 33)
        Me.lblTotRefundResult.Name = "lblTotRefundResult"
        Me.lblTotRefundResult.Size = New System.Drawing.Size(116, 49)
        Me.lblTotRefundResult.TabIndex = 0
        Me.lblTotRefundResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cancel_Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(472, 513)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.gboReasons)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cancel_Booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancel Booking"
        Me.gboReasons.ResumeLayout(False)
        Me.gboReasons.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gboCancelFee.ResumeLayout(False)
        Me.gboCancelFee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDesc As Label
    Friend WithEvents gboReasons As GroupBox
    Friend WithEvents txtOthers As TextBox
    Friend WithEvents rbOthers As RadioButton
    Friend WithEvents rbDatTimeChange As RadioButton
    Friend WithEvents rbHealth As RadioButton
    Friend WithEvents rbFoundNew As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents gboCancelFee As GroupBox
    Friend WithEvents lblTotRefund As Label
    Friend WithEvents lblTotRefundResult As Label
End Class
