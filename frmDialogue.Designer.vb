<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogue
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfurniName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCheapestPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAveragePrice = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudBuyPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudSellPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudIndividual = New System.Windows.Forms.NumericUpDown()
        Me.btnUpdateValues = New System.Windows.Forms.Button()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.nudBuyPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSellPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIndividual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Furni Name:"
        '
        'txtfurniName
        '
        Me.txtfurniName.Location = New System.Drawing.Point(19, 34)
        Me.txtfurniName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfurniName.Name = "txtfurniName"
        Me.txtfurniName.ReadOnly = True
        Me.txtfurniName.Size = New System.Drawing.Size(180, 23)
        Me.txtfurniName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cheapest Price:"
        '
        'txtCheapestPrice
        '
        Me.txtCheapestPrice.Location = New System.Drawing.Point(19, 92)
        Me.txtCheapestPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCheapestPrice.Name = "txtCheapestPrice"
        Me.txtCheapestPrice.ReadOnly = True
        Me.txtCheapestPrice.Size = New System.Drawing.Size(180, 23)
        Me.txtCheapestPrice.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Average Price:"
        '
        'txtAveragePrice
        '
        Me.txtAveragePrice.Location = New System.Drawing.Point(229, 92)
        Me.txtAveragePrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAveragePrice.Name = "txtAveragePrice"
        Me.txtAveragePrice.ReadOnly = True
        Me.txtAveragePrice.Size = New System.Drawing.Size(180, 23)
        Me.txtAveragePrice.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAveragePrice)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCheapestPrice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtfurniName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 136)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.nudSellPrice)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.nudIndividual)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.nudBuyPrice)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(13, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 139)
        Me.Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Buy Price:"
        '
        'nudBuyPrice
        '
        Me.nudBuyPrice.Location = New System.Drawing.Point(19, 35)
        Me.nudBuyPrice.Name = "nudBuyPrice"
        Me.nudBuyPrice.Size = New System.Drawing.Size(180, 23)
        Me.nudBuyPrice.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sell Price:"
        '
        'nudSellPrice
        '
        Me.nudSellPrice.Location = New System.Drawing.Point(229, 35)
        Me.nudSellPrice.Name = "nudSellPrice"
        Me.nudSellPrice.Size = New System.Drawing.Size(180, 23)
        Me.nudSellPrice.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Individual %:"
        '
        'nudIndividual
        '
        Me.nudIndividual.Location = New System.Drawing.Point(18, 93)
        Me.nudIndividual.Name = "nudIndividual"
        Me.nudIndividual.Size = New System.Drawing.Size(180, 23)
        Me.nudIndividual.TabIndex = 1
        '
        'btnUpdateValues
        '
        Me.btnUpdateValues.Location = New System.Drawing.Point(13, 297)
        Me.btnUpdateValues.Name = "btnUpdateValues"
        Me.btnUpdateValues.Size = New System.Drawing.Size(182, 33)
        Me.btnUpdateValues.TabIndex = 4
        Me.btnUpdateValues.Text = "&Update Values"
        Me.btnUpdateValues.UseVisualStyleBackColor = True
        '
        'btnSkip
        '
        Me.btnSkip.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSkip.Location = New System.Drawing.Point(201, 297)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(182, 33)
        Me.btnSkip.TabIndex = 4
        Me.btnSkip.Text = "&Skip"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.JSON_Manager.My.Resources.Resources.cancel_24px
        Me.btnCancel.Location = New System.Drawing.Point(389, 297)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(50, 33)
        Me.btnCancel.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancel all operation")
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'frmDialogue
        '
        Me.AcceptButton = Me.btnUpdateValues
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSkip
        Me.ClientSize = New System.Drawing.Size(453, 339)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.btnUpdateValues)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmDialogue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Input Dialogue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudBuyPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSellPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIndividual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtfurniName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCheapestPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAveragePrice As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents nudSellPrice As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudIndividual As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents nudBuyPrice As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdateValues As Button
    Friend WithEvents btnSkip As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
