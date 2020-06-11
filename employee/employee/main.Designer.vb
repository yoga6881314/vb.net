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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvUserdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSerFullName
        '
        Me.txtSerFullName.Location = New System.Drawing.Point(112, 108)
        Me.txtSerFullName.Name = "txtSerFullName"
        Me.txtSerFullName.Size = New System.Drawing.Size(178, 25)
        Me.txtSerFullName.TabIndex = 2
        '
        'btnNewEpl
        '
        Me.btnNewEpl.Location = New System.Drawing.Point(553, 92)
        Me.btnNewEpl.Name = "btnNewEpl"
        Me.btnNewEpl.Size = New System.Drawing.Size(159, 39)
        Me.btnNewEpl.TabIndex = 3
        Me.btnNewEpl.Text = "新規登録"
        Me.btnNewEpl.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.ForeColor = System.Drawing.Color.Red
        Me.btnLogout.Location = New System.Drawing.Point(1094, 47)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(132, 39)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "ログアウト"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "検索"
        '
        'txtSerKaName
        '
        Me.txtSerKaName.Location = New System.Drawing.Point(112, 154)
        Me.txtSerKaName.Name = "txtSerKaName"
        Me.txtSerKaName.Size = New System.Drawing.Size(178, 25)
        Me.txtSerKaName.TabIndex = 6
        '
        'chkSerMale
        '
        Me.chkSerMale.AutoSize = True
        Me.chkSerMale.Location = New System.Drawing.Point(112, 206)
        Me.chkSerMale.Name = "chkSerMale"
        Me.chkSerMale.Size = New System.Drawing.Size(70, 22)
        Me.chkSerMale.TabIndex = 7
        Me.chkSerMale.Text = "男性"
        Me.chkSerMale.UseVisualStyleBackColor = True
        '
        'chkSerFemale
        '
        Me.chkSerFemale.AutoSize = True
        Me.chkSerFemale.Location = New System.Drawing.Point(188, 206)
        Me.chkSerFemale.Name = "chkSerFemale"
        Me.chkSerFemale.Size = New System.Drawing.Size(70, 22)
        Me.chkSerFemale.TabIndex = 8
        Me.chkSerFemale.Text = "女性"
        Me.chkSerFemale.UseVisualStyleBackColor = True
        '
        'txtSerDepart
        '
        Me.txtSerDepart.Location = New System.Drawing.Point(112, 252)
        Me.txtSerDepart.Name = "txtSerDepart"
        Me.txtSerDepart.Size = New System.Drawing.Size(178, 25)
        Me.txtSerDepart.TabIndex = 9
        '
        'txtSerBirth
        '
        Me.txtSerBirth.Location = New System.Drawing.Point(112, 303)
        Me.txtSerBirth.Name = "txtSerBirth"
        Me.txtSerBirth.Size = New System.Drawing.Size(178, 25)
        Me.txtSerBirth.TabIndex = 10
        '
        'txtSerMail
        '
        Me.txtSerMail.Location = New System.Drawing.Point(112, 357)
        Me.txtSerMail.Name = "txtSerMail"
        Me.txtSerMail.Size = New System.Drawing.Size(178, 25)
        Me.txtSerMail.TabIndex = 11
        '
        'txtSerTele
        '
        Me.txtSerTele.Location = New System.Drawing.Point(112, 406)
        Me.txtSerTele.Name = "txtSerTele"
        Me.txtSerTele.Size = New System.Drawing.Size(178, 25)
        Me.txtSerTele.TabIndex = 12
        '
        'txtSerAddress
        '
        Me.txtSerAddress.Location = New System.Drawing.Point(112, 452)
        Me.txtSerAddress.Name = "txtSerAddress"
        Me.txtSerAddress.Size = New System.Drawing.Size(178, 25)
        Me.txtSerAddress.TabIndex = 13
        '
        'txtSerEdu
        '
        Me.txtSerEdu.Location = New System.Drawing.Point(112, 501)
        Me.txtSerEdu.Name = "txtSerEdu"
        Me.txtSerEdu.Size = New System.Drawing.Size(178, 25)
        Me.txtSerEdu.TabIndex = 14
        '
        'txtSerSpecial
        '
        Me.txtSerSpecial.Location = New System.Drawing.Point(112, 552)
        Me.txtSerSpecial.Name = "txtSerSpecial"
        Me.txtSerSpecial.Size = New System.Drawing.Size(178, 25)
        Me.txtSerSpecial.TabIndex = 15
        '
        'btnSerReset
        '
        Me.btnSerReset.Location = New System.Drawing.Point(50, 618)
        Me.btnSerReset.Name = "btnSerReset"
        Me.btnSerReset.Size = New System.Drawing.Size(108, 39)
        Me.btnSerReset.TabIndex = 16
        Me.btnSerReset.Text = "リセット"
        Me.btnSerReset.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(188, 618)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 39)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "姓名："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "セイメイ："
        '
        'dgvUserdata
        '
        Me.dgvUserdata.AllowUserToAddRows = False
        Me.dgvUserdata.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserdata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserdata.Location = New System.Drawing.Point(351, 142)
        Me.dgvUserdata.Name = "dgvUserdata"
        Me.dgvUserdata.RowHeadersVisible = False
        Me.dgvUserdata.RowHeadersWidth = 62
        Me.dgvUserdata.RowTemplate.Height = 27
        Me.dgvUserdata.Size = New System.Drawing.Size(895, 546)
        Me.dgvUserdata.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "部署："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "生年月日："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 18)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "メイル："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "性別："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 18)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "電話番号："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 459)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 18)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "住所："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 504)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 18)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "最終学歴："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 559)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 18)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "特技："
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(785, 91)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(195, 39)
        Me.btnUpdate.TabIndex = 30
        Me.btnUpdate.Text = "IDを指定して編集"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(816, 53)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(164, 25)
        Me.txtID.TabIndex = 31
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1031, 92)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(195, 39)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "IDを指定して削除"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(351, 91)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(159, 39)
        Me.btnShowAll.TabIndex = 33
        Me.btnShowAll.Text = "全件表示"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1291, 33)
        Me.BindingNavigator1.TabIndex = 34
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 30)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 28)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(782, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 18)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "ID:"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 725)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnUpdate)
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
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Label12 As Label
End Class
