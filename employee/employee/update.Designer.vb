<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class update
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(update))
        Me.txtShowId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbUpdDepart = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnUpdCancel = New System.Windows.Forms.Button()
        Me.btnImageCancel = New System.Windows.Forms.Button()
        Me.btnImagePick = New System.Windows.Forms.Button()
        Me.dtpUpdBirth = New System.Windows.Forms.DateTimePicker()
        Me.chkUpdFemale = New System.Windows.Forms.CheckBox()
        Me.chkUpdMale = New System.Windows.Forms.CheckBox()
        Me.txtUpdEdu = New System.Windows.Forms.TextBox()
        Me.txtUpdAddress = New System.Windows.Forms.TextBox()
        Me.txtUpdTele = New System.Windows.Forms.TextBox()
        Me.txtUpdMail = New System.Windows.Forms.TextBox()
        Me.txtUpdSpecial = New System.Windows.Forms.TextBox()
        Me.txtUpdKata = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUpdName = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtShowId
        '
        Me.txtShowId.Location = New System.Drawing.Point(452, 27)
        Me.txtShowId.Name = "txtShowId"
        Me.txtShowId.Size = New System.Drawing.Size(155, 25)
        Me.txtShowId.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        '
        'cmbUpdDepart
        '
        Me.cmbUpdDepart.FormattingEnabled = True
        Me.cmbUpdDepart.Items.AddRange(New Object() {"部署A", "部署B", "部署C", "部署D"})
        Me.cmbUpdDepart.Location = New System.Drawing.Point(534, 213)
        Me.cmbUpdDepart.Name = "cmbUpdDepart"
        Me.cmbUpdDepart.Size = New System.Drawing.Size(238, 26)
        Me.cmbUpdDepart.TabIndex = 82
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(71, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(592, 562)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(175, 40)
        Me.btnUpdate.TabIndex = 80
        Me.btnUpdate.Text = "更新"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnUpdCancel
        '
        Me.btnUpdCancel.Location = New System.Drawing.Point(308, 562)
        Me.btnUpdCancel.Name = "btnUpdCancel"
        Me.btnUpdCancel.Size = New System.Drawing.Size(175, 40)
        Me.btnUpdCancel.TabIndex = 79
        Me.btnUpdCancel.Text = "取消"
        Me.btnUpdCancel.UseVisualStyleBackColor = True
        '
        'btnImageCancel
        '
        Me.btnImageCancel.Location = New System.Drawing.Point(198, 258)
        Me.btnImageCancel.Name = "btnImageCancel"
        Me.btnImageCancel.Size = New System.Drawing.Size(111, 30)
        Me.btnImageCancel.TabIndex = 78
        Me.btnImageCancel.Text = "キャンセル"
        Me.btnImageCancel.UseVisualStyleBackColor = True
        '
        'btnImagePick
        '
        Me.btnImagePick.Location = New System.Drawing.Point(59, 257)
        Me.btnImagePick.Name = "btnImagePick"
        Me.btnImagePick.Size = New System.Drawing.Size(109, 31)
        Me.btnImagePick.TabIndex = 77
        Me.btnImagePick.Text = "選択"
        Me.btnImagePick.UseVisualStyleBackColor = True
        '
        'dtpUpdBirth
        '
        Me.dtpUpdBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpUpdBirth.Location = New System.Drawing.Point(534, 263)
        Me.dtpUpdBirth.Name = "dtpUpdBirth"
        Me.dtpUpdBirth.Size = New System.Drawing.Size(238, 25)
        Me.dtpUpdBirth.TabIndex = 76
        '
        'chkUpdFemale
        '
        Me.chkUpdFemale.AutoSize = True
        Me.chkUpdFemale.Location = New System.Drawing.Point(748, 172)
        Me.chkUpdFemale.Name = "chkUpdFemale"
        Me.chkUpdFemale.Size = New System.Drawing.Size(70, 22)
        Me.chkUpdFemale.TabIndex = 75
        Me.chkUpdFemale.Text = "女性"
        Me.chkUpdFemale.UseVisualStyleBackColor = True
        '
        'chkUpdMale
        '
        Me.chkUpdMale.AutoSize = True
        Me.chkUpdMale.Location = New System.Drawing.Point(592, 172)
        Me.chkUpdMale.Name = "chkUpdMale"
        Me.chkUpdMale.Size = New System.Drawing.Size(70, 22)
        Me.chkUpdMale.TabIndex = 74
        Me.chkUpdMale.Text = "男性"
        Me.chkUpdMale.UseVisualStyleBackColor = True
        '
        'txtUpdEdu
        '
        Me.txtUpdEdu.Location = New System.Drawing.Point(534, 449)
        Me.txtUpdEdu.Name = "txtUpdEdu"
        Me.txtUpdEdu.Size = New System.Drawing.Size(385, 25)
        Me.txtUpdEdu.TabIndex = 73
        '
        'txtUpdAddress
        '
        Me.txtUpdAddress.Location = New System.Drawing.Point(534, 398)
        Me.txtUpdAddress.Name = "txtUpdAddress"
        Me.txtUpdAddress.Size = New System.Drawing.Size(385, 25)
        Me.txtUpdAddress.TabIndex = 72
        '
        'txtUpdTele
        '
        Me.txtUpdTele.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtUpdTele.Location = New System.Drawing.Point(534, 351)
        Me.txtUpdTele.Name = "txtUpdTele"
        Me.txtUpdTele.Size = New System.Drawing.Size(238, 25)
        Me.txtUpdTele.TabIndex = 71
        '
        'txtUpdMail
        '
        Me.txtUpdMail.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtUpdMail.Location = New System.Drawing.Point(534, 305)
        Me.txtUpdMail.Name = "txtUpdMail"
        Me.txtUpdMail.Size = New System.Drawing.Size(238, 25)
        Me.txtUpdMail.TabIndex = 70
        '
        'txtUpdSpecial
        '
        Me.txtUpdSpecial.Location = New System.Drawing.Point(534, 500)
        Me.txtUpdSpecial.Name = "txtUpdSpecial"
        Me.txtUpdSpecial.Size = New System.Drawing.Size(385, 25)
        Me.txtUpdSpecial.TabIndex = 69
        '
        'txtUpdKata
        '
        Me.txtUpdKata.Location = New System.Drawing.Point(534, 125)
        Me.txtUpdKata.Name = "txtUpdKata"
        Me.txtUpdKata.Size = New System.Drawing.Size(385, 25)
        Me.txtUpdKata.TabIndex = 68
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(371, 500)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 18)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "特技："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(371, 452)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 18)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "最終学歴："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(371, 401)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "住所："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(371, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 18)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "電話番号："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(371, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "メイルアドレス："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "生年月日："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "部署："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "性別："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "セイメイ："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(371, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 18)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "姓名："
        '
        'txtUpdName
        '
        Me.txtUpdName.Location = New System.Drawing.Point(534, 80)
        Me.txtUpdName.Name = "txtUpdName"
        Me.txtUpdName.Size = New System.Drawing.Size(385, 25)
        Me.txtUpdName.TabIndex = 57
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 643)
        Me.Controls.Add(Me.cmbUpdDepart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnUpdCancel)
        Me.Controls.Add(Me.btnImageCancel)
        Me.Controls.Add(Me.btnImagePick)
        Me.Controls.Add(Me.dtpUpdBirth)
        Me.Controls.Add(Me.chkUpdFemale)
        Me.Controls.Add(Me.chkUpdMale)
        Me.Controls.Add(Me.txtUpdEdu)
        Me.Controls.Add(Me.txtUpdAddress)
        Me.Controls.Add(Me.txtUpdTele)
        Me.Controls.Add(Me.txtUpdMail)
        Me.Controls.Add(Me.txtUpdSpecial)
        Me.Controls.Add(Me.txtUpdKata)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtUpdName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtShowId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "update"
        Me.Text = "編集"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtShowId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbUpdDepart As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnUpdCancel As Button
    Friend WithEvents btnImageCancel As Button
    Friend WithEvents btnImagePick As Button
    Friend WithEvents dtpUpdBirth As DateTimePicker
    Friend WithEvents chkUpdFemale As CheckBox
    Friend WithEvents chkUpdMale As CheckBox
    Friend WithEvents txtUpdEdu As TextBox
    Friend WithEvents txtUpdAddress As TextBox
    Friend WithEvents txtUpdTele As TextBox
    Friend WithEvents txtUpdMail As TextBox
    Friend WithEvents txtUpdSpecial As TextBox
    Friend WithEvents txtUpdKata As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUpdName As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
