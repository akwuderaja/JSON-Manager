<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMarginAdjuster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarginAdjuster))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudValue = New System.Windows.Forms.NumericUpDown()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.txtFurnIdJson = New System.Windows.Forms.TextBox()
        Me.txtConfigJson = New System.Windows.Forms.TextBox()
        Me.btnFurnIdJson = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConfigJson = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 139)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Margin (%):"
        '
        'nudValue
        '
        Me.nudValue.Location = New System.Drawing.Point(90, 158)
        Me.nudValue.Margin = New System.Windows.Forms.Padding(4)
        Me.nudValue.Name = "nudValue"
        Me.nudValue.Size = New System.Drawing.Size(237, 23)
        Me.nudValue.TabIndex = 2
        Me.nudValue.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'btnSave
        '
        Me.btnSave.Image = Global.JSON_Manager.My.Resources.Resources.save_24px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(248, 199)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 31)
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
        Me.btnProcess.Location = New System.Drawing.Point(89, 199)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(151, 31)
        Me.btnProcess.TabIndex = 3
        Me.btnProcess.Text = "&Check Margins"
        Me.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'txtFurnIdJson
        '
        Me.txtFurnIdJson.Enabled = False
        Me.txtFurnIdJson.Location = New System.Drawing.Point(12, 85)
        Me.txtFurnIdJson.Name = "txtFurnIdJson"
        Me.txtFurnIdJson.Size = New System.Drawing.Size(405, 23)
        Me.txtFurnIdJson.TabIndex = 9
        Me.txtFurnIdJson.Text = "C:\Users\ChudiSoft\Downloads\furni"
        '
        'txtConfigJson
        '
        Me.txtConfigJson.Enabled = False
        Me.txtConfigJson.Location = New System.Drawing.Point(12, 32)
        Me.txtConfigJson.Name = "txtConfigJson"
        Me.txtConfigJson.Size = New System.Drawing.Size(405, 23)
        Me.txtConfigJson.TabIndex = 10
        Me.txtConfigJson.Text = "C:\Users\ChudiSoft\Downloads\config.json"
        '
        'btnFurnIdJson
        '
        Me.btnFurnIdJson.FlatAppearance.BorderSize = 0
        Me.btnFurnIdJson.Image = Global.JSON_Manager.My.Resources.Resources.attach_24px
        Me.btnFurnIdJson.Location = New System.Drawing.Point(416, 83)
        Me.btnFurnIdJson.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFurnIdJson.Name = "btnFurnIdJson"
        Me.btnFurnIdJson.Size = New System.Drawing.Size(35, 26)
        Me.btnFurnIdJson.TabIndex = 8
        Me.btnFurnIdJson.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Selected FurniId JSON Folder:"
        '
        'btnConfigJson
        '
        Me.btnConfigJson.FlatAppearance.BorderSize = 0
        Me.btnConfigJson.Image = Global.JSON_Manager.My.Resources.Resources.attach_24px
        Me.btnConfigJson.Location = New System.Drawing.Point(416, 30)
        Me.btnConfigJson.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfigJson.Name = "btnConfigJson"
        Me.btnConfigJson.Size = New System.Drawing.Size(35, 26)
        Me.btnConfigJson.TabIndex = 6
        Me.btnConfigJson.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Selected Config JSON:"
        '
        'ofd
        '
        Me.ofd.Filter = "JSON Files|*.json"
        '
        'sfd
        '
        Me.sfd.Filter = "JSON Files|*.json"
        '
        'fbd
        '
        Me.fbd.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'frmMarginAdjuster
        '
        Me.AcceptButton = Me.btnProcess
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 250)
        Me.Controls.Add(Me.txtFurnIdJson)
        Me.Controls.Add(Me.txtConfigJson)
        Me.Controls.Add(Me.btnFurnIdJson)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConfigJson)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.nudValue)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMarginAdjuster"
        Me.Text = "Check Margins"
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents nudValue As NumericUpDown
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFurnIdJson As TextBox
    Friend WithEvents txtConfigJson As TextBox
    Friend WithEvents btnFurnIdJson As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConfigJson As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents fbd As FolderBrowserDialog
End Class
