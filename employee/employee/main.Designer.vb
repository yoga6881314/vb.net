<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.txtSerFullName = New System.Windows.Forms.TextBox()
        Me.btnNewEpl = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSerKaName = New System.Windows.Forms.TextBox()
        Me.chkSerMale = New System.Windows.Forms.CheckBox()
        Me.chkSerFemale = New System.Windows.Forms.CheckBox()
        Me.txtSerDepart = New System.Windows.Forms.TextBox()
        Me.txtSerBirth = New System.Windows.Forms.TextBox()
        Me.txtSerMail = New System.Windows.Forms.TextBox()
        Me.txtSerTele = New System.Windows.Forms.TextBox()
        Me.txtSerAddress = New System.Windows.Forms.TextBox()
        Me.txtSerEdu = New System.Windows.Forms.TextBox()
        Me.txtSerSpecial = New System.Windows.Forms.TextBox()
        Me.btnSerReset = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvUserdata = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvUserdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSerFullName
        '
        Me.txtSerFullName.Location = New System.Drawing.Point(105, 57)
        Me.txtSerFullName.Name = "txtSerFullName"
        Me.txtSerFullName.Size = New System.Drawing.Size(178, 25)
        Me.txtSerFullName.TabIndex = 2
        '
        'btnNewEpl
        '
        Me.btnNewEpl.Location = New System.Drawing.Point(814, 12)
        Me.btnNewEpl.Name = "btnNewEpl"
        Me.btnNewEpl.Size = New System.Drawing.Size(159, 39)
        Me.btnNewEpl.TabIndex = 3
        Me.btnNewEpl.Text = "新規登録"
        Me.btnNewEpl.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(1016, 13)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(159, 39)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "ログアウト"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "検索"
        '
        'txtSerKaName
        '
        Me.txtSerKaName.Location = New System.Drawing.Point(105, 103)
        Me.txtSerKaName.Name = "txtSerKaName"
        Me.txtSerKaName.Size = New System.Drawing.Size(178, 25)
        Me.txtSerKaName.TabIndex = 6
        '
        'chkSerMale
        '
        Me.chkSerMale.AutoSize = True
        Me.chkSerMale.Location = New System.Drawing.Point(105, 155)
        Me.chkSerMale.Name = "chkSerMale"
        Me.chkSerMale.Size = New System.Drawing.Size(70, 22)
        Me.chkSerMale.TabIndex = 7
        Me.chkSerMale.Text = "男性"
        Me.chkSerMale.UseVisualStyleBackColor = True
        '
        'chkSerFemale
        '
        Me.chkSerFemale.AutoSize = True
        Me.chkSerFemale.Location = New System.Drawing.Point(181, 155)
        Me.chkSerFemale.Name = "chkSerFemale"
        Me.chkSerFemale.Size = New System.Drawing.Size(70, 22)
        Me.chkSerFemale.TabIndex = 8
        Me.chkSerFemale.Text = "女性"
        Me.chkSerFemale.UseVisualStyleBackColor = True
        '
        'txtSerDepart
        '
        Me.txtSerDepart.Location = New System.Drawing.Point(105, 201)
        Me.txtSerDepart.Name = "txtSerDepart"
        Me.txtSerDepart.Size = New System.Drawing.Size(178, 25)
        Me.txtSerDepart.TabIndex = 9
        '
        'txtSerBirth
        '
        Me.txtSerBirth.Location = New System.Drawing.Point(105, 252)
        Me.txtSerBirth.Name = "txtSerBirth"
        Me.txtSerBirth.Size = New System.Drawing.Size(178, 25)
        Me.txtSerBirth.TabIndex = 10
        '
        'txtSerMail
        '
        Me.txtSerMail.Location = New System.Drawing.Point(105, 306)
        Me.txtSerMail.Name = "txtSerMail"
        Me.txtSerMail.Size = New System.Drawing.Size(178, 25)
        Me.txtSerMail.TabIndex = 11
        '
        'txtSerTele
        '
        Me.txtSerTele.Location = New System.Drawing.Point(105, 355)
        Me.txtSerTele.Name = "txtSerTele"
        Me.txtSerTele.Size = New System.Drawing.Size(178, 25)
        Me.txtSerTele.TabIndex = 12
        '
        'txtSerAddress
        '
        Me.txtSerAddress.Location = New System.Drawing.Point(105, 401)
        Me.txtSerAddress.Name = "txtSerAddress"
        Me.txtSerAddress.Size = New System.Drawing.Size(178, 25)
        Me.txtSerAddress.TabIndex = 13
        '
        'txtSerEdu
        '
        Me.txtSerEdu.Location = New System.Drawing.Point(105, 450)
        Me.txtSerEdu.Name = "txtSerEdu"
        Me.txtSerEdu.Size = New System.Drawing.Size(178, 25)
        Me.txtSerEdu.TabIndex = 14
        '
        'txtSerSpecial
        '
        Me.txtSerSpecial.Location = New System.Drawing.Point(105, 501)
        Me.txtSerSpecial.Name = "txtSerSpecial"
        Me.txtSerSpecial.Size = New System.Drawing.Size(178, 25)
        Me.txtSerSpecial.TabIndex = 15
        '
        'btnSerReset
        '
        Me.btnSerReset.Location = New System.Drawing.Point(43, 567)
        Me.btnSerReset.Name = "btnSerReset"
        Me.btnSerReset.Size = New System.Drawing.Size(108, 39)
        Me.btnSerReset.TabIndex = 16
        Me.btnSerReset.Text = "リセット"
        Me.btnSerReset.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(181, 567)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 39)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "姓名："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "セイメイ："
        '
        'dgvUserdata
        '
        Me.dgvUserdata.AllowUserToAddRows = False
        Me.dgvUserdata.AllowUserToDeleteRows = False
        Me.dgvUserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserdata.Location = New System.Drawing.Point(344, 57)
        Me.dgvUserdata.Name = "dgvUserdata"
        Me.dgvUserdata.ReadOnly = True
        Me.dgvUserdata.RowHeadersVisible = False
        Me.dgvUserdata.RowHeadersWidth = 62
        Me.dgvUserdata.RowTemplate.Height = 27
        Me.dgvUserdata.Size = New System.Drawing.Size(1700, 900)
        Me.dgvUserdata.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "部署："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "生年月日："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 18)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "メイル："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "性別："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 18)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "電話番号："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 408)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 18)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "住所："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 453)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 18)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "最終学歴："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 508)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 18)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "特技："
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1912, 1038)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvUserdata)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSerReset)
        Me.Controls.Add(Me.txtSerSpecial)
        Me.Controls.Add(Me.txtSerEdu)
        Me.Controls.Add(Me.txtSerAddress)
        Me.Controls.Add(Me.txtSerTele)
        Me.Controls.Add(Me.txtSerMail)
        Me.Controls.Add(Me.txtSerBirth)
        Me.Controls.Add(Me.txtSerDepart)
        Me.Controls.Add(Me.chkSerFemale)
        Me.Controls.Add(Me.chkSerMale)
        Me.Controls.Add(Me.txtSerKaName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnNewEpl)
        Me.Controls.Add(Me.txtSerFullName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "社員管理システム"
        CType(Me.dgvUserdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSerFullName As TextBox
    Friend WithEvents btnNewEpl As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSerKaName As TextBox
    Friend WithEvents chkSerMale As CheckBox
    Friend WithEvents chkSerFemale As CheckBox
    Friend WithEvents txtSerDepart As TextBox
    Friend WithEvents txtSerBirth As TextBox
    Friend WithEvents txtSerMail As TextBox
    Friend WithEvents txtSerTele As TextBox
    Friend WithEvents txtSerAddress As TextBox
    Friend WithEvents txtSerEdu As TextBox
    Friend WithEvents txtSerSpecial As TextBox
    Friend WithEvents btnSerReset As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvUserdata As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
