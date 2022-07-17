<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceAdjuster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPriceAdjuster))
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudValue = New System.Windows.Forms.NumericUpDown()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnAttach = New System.Windows.Forms.Button()
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofd
        '
        Me.ofd.Filter = "JSON Files|*.json"
        '
        'sfd
        '
        Me.sfd.Filter = "JSON Files|*.json"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adjustment Value:"
        '
        'nudValue
        '
        Me.nudValue.Location = New System.Drawing.Point(103, 107)
        Me.nudValue.Margin = New System.Windows.Forms.Padding(4)
        Me.nudValue.Name = "nudValue"
        Me.nudValue.Size = New System.Drawing.Size(237, 23)
        Me.nudValue.TabIndex = 2
        '
        'txtFileName
        '
        Me.txtFileName.Enabled = False
        Me.txtFileName.Location = New System.Drawing.Point(12, 35)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(405, 23)
        Me.txtFileName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Selected File Name:"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.JSON_Manager.My.Resources.Resources.save_24px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(225, 148)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 31)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Image = Global.JSON_Manager.My.Resources.Resources.sync_settings_24px
        Me.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcess.Location = New System.Drawing.Point(102, 148)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(115, 31)
        Me.btnProcess.TabIndex = 3
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnAttach
        '
        Me.btnAttach.FlatAppearance.BorderSize = 0
        Me.btnAttach.Image = Global.JSON_Manager.My.Resources.Resources.attach_24px
        Me.btnAttach.Location = New System.Drawing.Point(416, 33)
        Me.btnAttach.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(35, 26)
        Me.btnAttach.TabIndex = 1
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'frmPriceAdjuster
        '
        Me.AcceptButton = Me.btnProcess
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 250)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.nudValue)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPriceAdjuster"
        Me.Text = "Price Adjuster"
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAttach As Button
    Friend WithEvents nudValue As NumericUpDown
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label2 As Label
End Class
