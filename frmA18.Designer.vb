<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmA18
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
        Me.grpPlayer = New System.Windows.Forms.GroupBox()
        Me.lstPlayer = New System.Windows.Forms.ListBox()
        Me.grpDealer = New System.Windows.Forms.GroupBox()
        Me.lstDealer = New System.Windows.Forms.ListBox()
        Me.grpTotals = New System.Windows.Forms.GroupBox()
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.lblDealer = New System.Windows.Forms.Label()
        Me.txtDealer = New System.Windows.Forms.TextBox()
        Me.grpDecisions = New System.Windows.Forms.GroupBox()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.btnNewHand = New System.Windows.Forms.Button()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.grpHistory = New System.Windows.Forms.GroupBox()
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.grpPlayer.SuspendLayout()
        Me.grpDealer.SuspendLayout()
        Me.grpTotals.SuspendLayout()
        Me.grpDecisions.SuspendLayout()
        Me.grpStatus.SuspendLayout()
        Me.grpHistory.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPlayer
        '
        Me.grpPlayer.Controls.Add(Me.lstPlayer)
        Me.grpPlayer.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPlayer.Location = New System.Drawing.Point(12, 12)
        Me.grpPlayer.Name = "grpPlayer"
        Me.grpPlayer.Size = New System.Drawing.Size(200, 183)
        Me.grpPlayer.TabIndex = 0
        Me.grpPlayer.TabStop = False
        Me.grpPlayer.Text = "Player"
        '
        'lstPlayer
        '
        Me.lstPlayer.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPlayer.FormattingEnabled = True
        Me.lstPlayer.ItemHeight = 20
        Me.lstPlayer.Location = New System.Drawing.Point(6, 30)
        Me.lstPlayer.Name = "lstPlayer"
        Me.lstPlayer.Size = New System.Drawing.Size(188, 144)
        Me.lstPlayer.TabIndex = 0
        '
        'grpDealer
        '
        Me.grpDealer.Controls.Add(Me.lstDealer)
        Me.grpDealer.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDealer.Location = New System.Drawing.Point(218, 12)
        Me.grpDealer.Name = "grpDealer"
        Me.grpDealer.Size = New System.Drawing.Size(200, 183)
        Me.grpDealer.TabIndex = 1
        Me.grpDealer.TabStop = False
        Me.grpDealer.Text = "Dealer"
        '
        'lstDealer
        '
        Me.lstDealer.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDealer.FormattingEnabled = True
        Me.lstDealer.ItemHeight = 20
        Me.lstDealer.Location = New System.Drawing.Point(6, 30)
        Me.lstDealer.Name = "lstDealer"
        Me.lstDealer.Size = New System.Drawing.Size(188, 144)
        Me.lstDealer.TabIndex = 0
        '
        'grpTotals
        '
        Me.grpTotals.Controls.Add(Me.lblDealer)
        Me.grpTotals.Controls.Add(Me.txtDealer)
        Me.grpTotals.Controls.Add(Me.lblPlayer)
        Me.grpTotals.Controls.Add(Me.txtPlayer)
        Me.grpTotals.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTotals.Location = New System.Drawing.Point(12, 201)
        Me.grpTotals.Name = "grpTotals"
        Me.grpTotals.Size = New System.Drawing.Size(406, 78)
        Me.grpTotals.TabIndex = 1
        Me.grpTotals.TabStop = False
        Me.grpTotals.Text = "Totals"
        '
        'txtPlayer
        '
        Me.txtPlayer.Enabled = False
        Me.txtPlayer.Location = New System.Drawing.Point(131, 30)
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.Size = New System.Drawing.Size(63, 31)
        Me.txtPlayer.TabIndex = 0
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Location = New System.Drawing.Point(66, 33)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(60, 23)
        Me.lblPlayer.TabIndex = 1
        Me.lblPlayer.Text = "Player:"
        '
        'lblDealer
        '
        Me.lblDealer.AutoSize = True
        Me.lblDealer.Location = New System.Drawing.Point(228, 33)
        Me.lblDealer.Name = "lblDealer"
        Me.lblDealer.Size = New System.Drawing.Size(63, 23)
        Me.lblDealer.TabIndex = 3
        Me.lblDealer.Text = "Dealer:"
        '
        'txtDealer
        '
        Me.txtDealer.Enabled = False
        Me.txtDealer.Location = New System.Drawing.Point(293, 30)
        Me.txtDealer.Name = "txtDealer"
        Me.txtDealer.Size = New System.Drawing.Size(63, 31)
        Me.txtDealer.TabIndex = 2
        '
        'grpDecisions
        '
        Me.grpDecisions.Controls.Add(Me.btnNewHand)
        Me.grpDecisions.Controls.Add(Me.btnHold)
        Me.grpDecisions.Controls.Add(Me.btnHit)
        Me.grpDecisions.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDecisions.Location = New System.Drawing.Point(12, 285)
        Me.grpDecisions.Name = "grpDecisions"
        Me.grpDecisions.Size = New System.Drawing.Size(406, 70)
        Me.grpDecisions.TabIndex = 2
        Me.grpDecisions.TabStop = False
        Me.grpDecisions.Text = "Decisions"
        '
        'btnHit
        '
        Me.btnHit.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHit.Location = New System.Drawing.Point(6, 27)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(84, 37)
        Me.btnHit.TabIndex = 0
        Me.btnHit.Text = "Hit Me"
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'btnHold
        '
        Me.btnHold.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold.Location = New System.Drawing.Point(110, 27)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(84, 37)
        Me.btnHold.TabIndex = 1
        Me.btnHold.Text = "Hold"
        Me.btnHold.UseVisualStyleBackColor = True
        '
        'btnNewHand
        '
        Me.btnNewHand.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewHand.Location = New System.Drawing.Point(293, 27)
        Me.btnNewHand.Name = "btnNewHand"
        Me.btnNewHand.Size = New System.Drawing.Size(105, 37)
        Me.btnNewHand.TabIndex = 2
        Me.btnNewHand.Text = "New Hand"
        Me.btnNewHand.UseVisualStyleBackColor = True
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.txtStatus)
        Me.grpStatus.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStatus.Location = New System.Drawing.Point(12, 361)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(406, 64)
        Me.grpStatus.TabIndex = 3
        Me.grpStatus.TabStop = False
        Me.grpStatus.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(6, 27)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(392, 28)
        Me.txtStatus.TabIndex = 0
        '
        'grpHistory
        '
        Me.grpHistory.Controls.Add(Me.lstHistory)
        Me.grpHistory.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHistory.Location = New System.Drawing.Point(424, 12)
        Me.grpHistory.Name = "grpHistory"
        Me.grpHistory.Size = New System.Drawing.Size(462, 413)
        Me.grpHistory.TabIndex = 4
        Me.grpHistory.TabStop = False
        Me.grpHistory.Text = "History"
        '
        'lstHistory
        '
        Me.lstHistory.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.ItemHeight = 20
        Me.lstHistory.Location = New System.Drawing.Point(6, 30)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(450, 364)
        Me.lstHistory.TabIndex = 0
        '
        'frmA18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 441)
        Me.Controls.Add(Me.grpHistory)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.grpDecisions)
        Me.Controls.Add(Me.grpTotals)
        Me.Controls.Add(Me.grpDealer)
        Me.Controls.Add(Me.grpPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmA18"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assignment 18 - Blackjack"
        Me.grpPlayer.ResumeLayout(False)
        Me.grpDealer.ResumeLayout(False)
        Me.grpTotals.ResumeLayout(False)
        Me.grpTotals.PerformLayout()
        Me.grpDecisions.ResumeLayout(False)
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.grpHistory.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpPlayer As GroupBox
    Friend WithEvents lstPlayer As ListBox
    Friend WithEvents grpDealer As GroupBox
    Friend WithEvents lstDealer As ListBox
    Friend WithEvents grpTotals As GroupBox
    Friend WithEvents lblDealer As Label
    Friend WithEvents txtDealer As TextBox
    Friend WithEvents lblPlayer As Label
    Friend WithEvents txtPlayer As TextBox
    Friend WithEvents grpDecisions As GroupBox
    Friend WithEvents btnNewHand As Button
    Friend WithEvents btnHold As Button
    Friend WithEvents btnHit As Button
    Friend WithEvents grpStatus As GroupBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents grpHistory As GroupBox
    Friend WithEvents lstHistory As ListBox
End Class
