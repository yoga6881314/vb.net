<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newemployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newemployee))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNewSubmit = New System.Windows.Forms.Button()
        Me.btnNewCancel = New System.Windows.Forms.Button()
        Me.btnImageCancel = New System.Windows.Forms.Button()
        Me.btnImagePick = New System.Windows.Forms.Button()
        Me.dtpNewBirth = New System.Windows.Forms.DateTimePicker()
        Me.chkNewFemale = New System.Windows.Forms.CheckBox()
        Me.chkNewMale = New System.Windows.Forms.CheckBox()
        Me.txtNewEdu = New System.Windows.Forms.TextBox()
        Me.txtNewAddress = New System.Windows.Forms.TextBox()
        Me.txtNewTele = New System.Windows.Forms.TextBox()
        Me.txtNewMail = New System.Windows.Forms.TextBox()
        Me.txtNewSpecial = New System.Windows.Forms.TextBox()
        Me.txtNewKata = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewName = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmbNewDepart = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(44, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'btnNewSubmit
        '
        Me.btnNewSubmit.Location = New System.Drawing.Point(565, 522)
        Me.btnNewSubmit.Name = "btnNewSubmit"
        Me.btnNewSubmit.Size = New System.Drawing.Size(175, 40)
        Me.btnNewSubmit.TabIndex = 54
        Me.btnNewSubmit.Text = "提出"
        Me.btnNewSubmit.UseVisualStyleBackColor = True
        '
        'btnNewCancel
        '
        Me.btnNewCancel.Location = New System.Drawing.Point(281, 522)
        Me.btnNewCancel.Name = "btnNewCancel"
        Me.btnNewCancel.Size = New System.Drawing.Size(175, 40)
        Me.btnNewCancel.TabIndex = 53
        Me.btnNewCancel.Text = "取消"
        Me.btnNewCancel.UseVisualStyleBackColor = True
        '
        'btnImageCancel
        '
        Me.btnImageCancel.Location = New System.Drawing.Point(171, 218)
        Me.btnImageCancel.Name = "btnImageCancel"
        Me.btnImageCancel.Size = New System.Drawing.Size(111, 30)
        Me.btnImageCancel.TabIndex = 51
        Me.btnImageCancel.Text = "キャンセル"
        Me.btnImageCancel.UseVisualStyleBackColor = True
        '
        'btnImagePick
        '
        Me.btnImagePick.Location = New System.Drawing.Point(32, 217)
        Me.btnImagePick.Name = "btnImagePick"
        Me.btnImagePick.Size = New System.Drawing.Size(109, 31)
        Me.btnImagePick.TabIndex = 50
        Me.btnImagePick.Text = "選択"
        Me.btnImagePick.UseVisualStyleBackColor = True
        '
        'dtpNewBirth
        '
        Me.dtpNewBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNewBirth.Location = New System.Drawing.Point(507, 223)
        Me.dtpNewBirth.Name = "dtpNewBirth"
        Me.dtpNewBirth.Size = New System.Drawing.Size(238, 25)
        Me.dtpNewBirth.TabIndex = 48
        '
        'chkNewFemale
        '
        Me.chkNewFemale.AutoSize = True
        Me.chkNewFemale.Location = New System.Drawing.Point(721, 132)
        Me.chkNewFemale.Name = "chkNewFemale"
        Me.chkNewFemale.Size = New System.Drawing.Size(70, 22)
        Me.chkNewFemale.TabIndex = 47
        Me.chkNewFemale.Text = "女性"
        Me.chkNewFemale.UseVisualStyleBackColor = True
        '
        'chkNewMale
        '
        Me.chkNewMale.AutoSize = True
        Me.chkNewMale.Location = New System.Drawing.Point(565, 132)
        Me.chkNewMale.Name = "chkNewMale"
        Me.chkNewMale.Size = New System.Drawing.Size(70, 22)
        Me.chkNewMale.TabIndex = 46
        Me.chkNewMale.Text = "男性"
        Me.chkNewMale.UseVisualStyleBackColor = True
        '
        'txtNewEdu
        '
        Me.txtNewEdu.Location = New System.Drawing.Point(507, 409)
        Me.txtNewEdu.Name = "txtNewEdu"
        Me.txtNewEdu.Size = New System.Drawing.Size(385, 25)
        Me.txtNewEdu.TabIndex = 45
        '
        'txtNewAddress
        '
        Me.txtNewAddress.Location = New System.Drawing.Point(507, 358)
        Me.txtNewAddress.Name = "txtNewAddress"
        Me.txtNewAddress.Size = New System.Drawing.Size(385, 25)
        Me.txtNewAddress.TabIndex = 44
        '
        'txtNewTele
        '
        Me.txtNewTele.Location = New System.Drawing.Point(507, 311)
        Me.txtNewTele.Name = "txtNewTele"
        Me.txtNewTele.Size = New System.Drawing.Size(238, 25)
        Me.txtNewTele.TabIndex = 43
        '
        'txtNewMail
        '
        Me.txtNewMail.Location = New System.Drawing.Point(507, 265)
        Me.txtNewMail.Name = "txtNewMail"
        Me.txtNewMail.Size = New System.Drawing.Size(238, 25)
        Me.txtNewMail.TabIndex = 42
        '
        'txtNewSpecial
        '
        Me.txtNewSpecial.Location = New System.Drawing.Point(507, 460)
        Me.txtNewSpecial.Name = "txtNewSpecial"
        Me.txtNewSpecial.Size = New System.Drawing.Size(385, 25)
        Me.txtNewSpecial.TabIndex = 41
        '
        'txtNewKata
        '
        Me.txtNewKata.Location = New System.Drawing.Point(507, 85)
        Me.txtNewKata.Name = "txtNewKata"
        Me.txtNewKata.Size = New System.Drawing.Size(385, 25)
        Me.txtNewKata.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(344, 460)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 18)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "特技："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(344, 412)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 18)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "最終学歴："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(344, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "住所："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(344, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 18)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "電話番号："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(344, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "メイルアドレス："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "生年月日："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "部署："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(344, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "性別："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "セイメイ："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "姓名："
        '
        'txtNewName
        '
        Me.txtNewName.Location = New System.Drawing.Point(507, 40)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(385, 25)
        Me.txtNewName.TabIndex = 29
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" &
    "s (*.*)|*.*"
        Me.OpenFileDialog1.Title = "Select a picture file"
        '
        'cmbNewDepart
        '
        Me.cmbNewDepart.FormattingEnabled = True
        Me.cmbNewDepart.Items.AddRange(New Object() {"部署A", "部署B", "部署C", "部署D"})
        Me.cmbNewDepart.Location = New System.Drawing.Point(507, 173)
        Me.cmbNewDepart.Name = "cmbNewDepart"
        Me.cmbNewDepart.Size = New System.Drawing.Size(238, 26)
        Me.cmbNewDepart.TabIndex = 56
        '
        'newemployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 617)
        Me.Controls.Add(Me.cmbNewDepart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNewSubmit)
        Me.Controls.Add(Me.btnNewCancel)
        Me.Controls.Add(Me.btnImageCancel)
        Me.Controls.Add(Me.btnImagePick)
        Me.Controls.Add(Me.dtpNewBirth)
        Me.Controls.Add(Me.chkNewFemale)
        Me.Controls.Add(Me.chkNewMale)
        Me.Controls.Add(Me.txtNewEdu)
        Me.Controls.Add(Me.txtNewAddress)
        Me.Controls.Add(Me.txtNewTele)
        Me.Controls.Add(Me.txtNewMail)
        Me.Controls.Add(Me.txtNewSpecial)
        Me.Controls.Add(Me.txtNewKata)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNewName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "newemployee"
        Me.Text = "新規登録"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNewSubmit As Button
    Friend WithEvents btnNewCancel As Button
    Friend WithEvents btnImageCancel As Button
    Friend WithEvents btnImagePick As Button
    Friend WithEvents dtpNewBirth As DateTimePicker
    Friend WithEvents chkNewFemale As CheckBox
    Friend WithEvents chkNewMale As CheckBox
    Friend WithEvents txtNewEdu As TextBox
    Friend WithEvents txtNewAddress As TextBox
    Friend WithEvents txtNewTele As TextBox
    Friend WithEvents txtNewMail As TextBox
    Friend WithEvents txtNewSpecial As TextBox
    Friend WithEvents txtNewKata As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNewName As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmbNewDepart As ComboBox
End Class
