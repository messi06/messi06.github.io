<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.pan_container = New System.Windows.Forms.Panel()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txt_url = New System.Windows.Forms.TextBox()
        Me.lbl_url = New System.Windows.Forms.Label()
        Me.grp_popup = New System.Windows.Forms.GroupBox()
        Me.pan_container_popup = New System.Windows.Forms.Panel()
        Me.grp_browser = New System.Windows.Forms.GroupBox()
        Me.pan_container.SuspendLayout()
        Me.grp_popup.SuspendLayout()
        Me.grp_browser.SuspendLayout()
        Me.SuspendLayout()
        '
        'pan_container
        '
        Me.pan_container.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pan_container.BackColor = System.Drawing.Color.Silver
        Me.pan_container.Controls.Add(Me.grp_browser)
        Me.pan_container.Location = New System.Drawing.Point(12, 40)
        Me.pan_container.Name = "pan_container"
        Me.pan_container.Size = New System.Drawing.Size(1135, 550)
        Me.pan_container.TabIndex = 1
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.Location = New System.Drawing.Point(887, 12)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 9
        Me.btn_ok.Text = "Go"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'txt_url
        '
        Me.txt_url.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_url.Location = New System.Drawing.Point(55, 14)
        Me.txt_url.Name = "txt_url"
        Me.txt_url.Size = New System.Drawing.Size(826, 20)
        Me.txt_url.TabIndex = 8
        '
        'lbl_url
        '
        Me.lbl_url.AutoSize = True
        Me.lbl_url.Location = New System.Drawing.Point(17, 17)
        Me.lbl_url.Name = "lbl_url"
        Me.lbl_url.Size = New System.Drawing.Size(29, 13)
        Me.lbl_url.TabIndex = 7
        Me.lbl_url.Text = "URL"
        '
        'grp_popup
        '
        Me.grp_popup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_popup.BackColor = System.Drawing.Color.PowderBlue
        Me.grp_popup.Controls.Add(Me.pan_container_popup)
        Me.grp_popup.Location = New System.Drawing.Point(1114, 3)
        Me.grp_popup.Name = "grp_popup"
        Me.grp_popup.Size = New System.Drawing.Size(0, 10)
        Me.grp_popup.TabIndex = 9
        Me.grp_popup.TabStop = False
        Me.grp_popup.Visible = False
        '
        'pan_container_popup
        '
        Me.pan_container_popup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pan_container_popup.BackColor = System.Drawing.Color.Silver
        Me.pan_container_popup.Location = New System.Drawing.Point(950, 145)
        Me.pan_container_popup.Name = "pan_container_popup"
        Me.pan_container_popup.Size = New System.Drawing.Size(0, 0)
        Me.pan_container_popup.TabIndex = 0
        Me.pan_container_popup.Visible = False
        '
        'grp_browser
        '
        Me.grp_browser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_browser.BackColor = System.Drawing.Color.White
        Me.grp_browser.Controls.Add(Me.grp_popup)
        Me.grp_browser.Location = New System.Drawing.Point(1125, 534)
        Me.grp_browser.Name = "grp_browser"
        Me.grp_browser.Size = New System.Drawing.Size(10, 16)
        Me.grp_browser.TabIndex = 8
        Me.grp_browser.TabStop = False
        Me.grp_browser.Text = "Browser"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 602)
        Me.Controls.Add(Me.pan_container)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.txt_url)
        Me.Controls.Add(Me.lbl_url)
        Me.Name = "frm_main"
        Me.Text = "Form1"
        Me.pan_container.ResumeLayout(False)
        Me.grp_popup.ResumeLayout(False)
        Me.grp_browser.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pan_container As Panel
    Private WithEvents btn_ok As Button
    Private WithEvents txt_url As TextBox
    Private WithEvents lbl_url As Label
    Private WithEvents grp_browser As GroupBox
    Private WithEvents grp_popup As GroupBox
    Private WithEvents pan_container_popup As Panel
End Class
