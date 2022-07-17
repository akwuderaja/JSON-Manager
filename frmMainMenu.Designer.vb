<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnPriceAdjuster = New System.Windows.Forms.Button()
        Me.btnCheckPrices = New System.Windows.Forms.Button()
        Me.btnCheckMargins = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPriceAdjuster
        '
        Me.btnPriceAdjuster.Location = New System.Drawing.Point(13, 26)
        Me.btnPriceAdjuster.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPriceAdjuster.Name = "btnPriceAdjuster"
        Me.btnPriceAdjuster.Size = New System.Drawing.Size(278, 49)
        Me.btnPriceAdjuster.TabIndex = 0
        Me.btnPriceAdjuster.Text = "Price Adjuster"
        Me.btnPriceAdjuster.UseVisualStyleBackColor = True
        '
        'btnCheckPrices
        '
        Me.btnCheckPrices.Location = New System.Drawing.Point(13, 88)
        Me.btnCheckPrices.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheckPrices.Name = "btnCheckPrices"
        Me.btnCheckPrices.Size = New System.Drawing.Size(278, 49)
        Me.btnCheckPrices.TabIndex = 1
        Me.btnCheckPrices.Text = "Check Prices"
        Me.btnCheckPrices.UseVisualStyleBackColor = True
        '
        'btnCheckMargins
        '
        Me.btnCheckMargins.Location = New System.Drawing.Point(13, 149)
        Me.btnCheckMargins.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheckMargins.Name = "btnCheckMargins"
        Me.btnCheckMargins.Size = New System.Drawing.Size(278, 49)
        Me.btnCheckMargins.TabIndex = 2
        Me.btnCheckMargins.Text = "Check Margins"
        Me.btnCheckMargins.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AcceptButton = Me.btnPriceAdjuster
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 225)
        Me.Controls.Add(Me.btnCheckMargins)
        Me.Controls.Add(Me.btnCheckPrices)
        Me.Controls.Add(Me.btnPriceAdjuster)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMainMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPriceAdjuster As Button
    Friend WithEvents btnCheckPrices As Button
    Friend WithEvents btnCheckMargins As Button
End Class
