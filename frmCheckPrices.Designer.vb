<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCheckPrices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckPrices))
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudValue = New System.Windows.Forms.NumericUpDown()
        Me.txtConfigJson = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFurnIdJson = New System.Windows.Forms.TextBox()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnFurnIdJson = New System.Windows.Forms.Button()
        Me.btnConfigJson = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(99, 146)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Difference (%):"
        '
        'nudValue
        '
        Me.nudValue.Location = New System.Drawing.Point(103, 165)
        Me.nudValue.Margin = New System.Windows.Forms.Padding(4)
        Me.nudValue.Name = "nudValue"
        Me.nudValue.Size = New System.Drawing.Size(237, 23)
        Me.nudValue.TabIndex = 2
        Me.nudValue.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'txtConfigJson
        '
        Me.txtConfigJson.Enabled = False
        Me.txtConfigJson.Location = New System.Drawing.Point(12, 35)
        Me.txtConfigJson.Name = "txtConfigJson"
        Me.txtConfigJson.Size = New System.Drawing.Size(405, 23)
        Me.txtConfigJson.TabIndex = 4
        Me.txtConfigJson.Text = "C:\Users\ChudiSoft\Downloads\config.json"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Selected Config JSON:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Selected FurniId JSON Folder:"
        '
        'txtFurnIdJson
        '
        Me.txtFurnIdJson.Enabled = False
        Me.txtFurnIdJson.Location = New System.Drawing.Point(12, 88)
        Me.txtFurnIdJson.Name = "txtFurnIdJson"
        Me.txtFurnIdJson.Size = New System.Drawing.Size(405, 23)
        Me.txtFurnIdJson.TabIndex = 4
        Me.txtFurnIdJson.Text = "C:\Users\ChudiSoft\Downloads\furni"
        '
        'fbd
        '
        Me.fbd.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'btnProcess
        '
        Me.btnProcess.Image = Global.JSON_Manager.My.Resources.Resources.sync_settings_24px
        Me.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcess.Location = New System.Drawing.Point(102, 206)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(155, 31)
        Me.btnProcess.TabIndex = 3
        Me.btnProcess.Text = "&Check Prices"
        Me.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = Global.JSON_Manager.My.Resources.Resources.save_24px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(265, 206)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnFurnIdJson
        '
        Me.btnFurnIdJson.FlatAppearance.BorderSize = 0
        Me.btnFurnIdJson.Image = Global.JSON_Manager.My.Resources.Resources.attach_24px
        Me.btnFurnIdJson.Location = New System.Drawing.Point(416, 86)
        Me.btnFurnIdJson.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFurnIdJson.Name = "btnFurnIdJson"
        Me.btnFurnIdJson.Size = New System.Drawing.Size(35, 26)
        Me.btnFurnIdJson.TabIndex = 1
        Me.btnFurnIdJson.UseVisualStyleBackColor = True
        '
        'btnConfigJson
        '
        Me.btnConfigJson.FlatAppearance.BorderSize = 0
        Me.btnConfigJson.Image = Global.JSON_Manager.My.Resources.Resources.attach_24px
        Me.btnConfigJson.Location = New System.Drawing.Point(416, 33)
        Me.btnConfigJson.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfigJson.Name = "btnConfigJson"
        Me.btnConfigJson.Size = New System.Drawing.Size(35, 26)
        Me.btnConfigJson.TabIndex = 0
        Me.btnConfigJson.UseVisualStyleBackColor = True
        '
        'frmCheckPrices
        '
        Me.AcceptButton = Me.btnProcess
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 250)
        Me.Controls.Add(Me.txtFurnIdJson)
        Me.Controls.Add(Me.txtConfigJson)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnFurnIdJson)
        Me.Controls.Add(Me.nudValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConfigJson)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCheckPrices"
        Me.Text = "Check Prices"
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfigJson As Button
    Friend WithEvents nudValue As NumericUpDown
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtConfigJson As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFurnIdJson As Button
    Friend WithEvents txtFurnIdJson As TextBox
    Friend WithEvents fbd As FolderBrowserDialog
End Class
