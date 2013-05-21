<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim 戸主氏名Label As System.Windows.Forms.Label
        Dim ふりがなLabel As System.Windows.Forms.Label
        Dim 檀家番号Label As System.Windows.Forms.Label
        Dim 入檀年月日Label As System.Windows.Forms.Label
        Dim _Label As System.Windows.Forms.Label
        Dim 住所1Label As System.Windows.Forms.Label
        Dim 住所2Label As System.Windows.Forms.Label
        Dim 墓地Label As System.Windows.Forms.Label
        Me.T_D_檀家BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JiinDataDataSet = New DankaSearch.JiinDataDataSet()
        Me.txtDankaNo = New System.Windows.Forms.TextBox()
        Me.T_D_過去帳BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_D_過去帳DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblKana = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnRegistParent = New System.Windows.Forms.Button()
        Me.T_D_檀家TableAdapter = New DankaSearch.JiinDataDataSetTableAdapters.T_D_檀家TableAdapter()
        Me.TableAdapterManager = New DankaSearch.JiinDataDataSetTableAdapters.TableAdapterManager()
        Me.T_D_過去帳TableAdapter = New DankaSearch.JiinDataDataSetTableAdapters.T_D_過去帳TableAdapter()
        Me.入檀年月日Label1 = New System.Windows.Forms.Label()
        Me._Label1 = New System.Windows.Forms.Label()
        Me.住所1Label1 = New System.Windows.Forms.Label()
        Me.住所2Label1 = New System.Windows.Forms.Label()
        Me.墓地Label1 = New System.Windows.Forms.Label()
        戸主氏名Label = New System.Windows.Forms.Label()
        ふりがなLabel = New System.Windows.Forms.Label()
        檀家番号Label = New System.Windows.Forms.Label()
        入檀年月日Label = New System.Windows.Forms.Label()
        _Label = New System.Windows.Forms.Label()
        住所1Label = New System.Windows.Forms.Label()
        住所2Label = New System.Windows.Forms.Label()
        墓地Label = New System.Windows.Forms.Label()
        CType(Me.T_D_檀家BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JiinDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_D_過去帳BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_D_過去帳DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        '戸主氏名Label
        '
        戸主氏名Label.AutoSize = True
        戸主氏名Label.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        戸主氏名Label.Location = New System.Drawing.Point(38, 123)
        戸主氏名Label.Name = "戸主氏名Label"
        戸主氏名Label.Size = New System.Drawing.Size(150, 33)
        戸主氏名Label.TabIndex = 0
        戸主氏名Label.Text = "戸主氏名:"
        '
        'ふりがなLabel
        '
        ふりがなLabel.AutoSize = True
        ふりがなLabel.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ふりがなLabel.Location = New System.Drawing.Point(66, 168)
        ふりがなLabel.Name = "ふりがなLabel"
        ふりがなLabel.Size = New System.Drawing.Size(122, 33)
        ふりがなLabel.TabIndex = 3
        ふりがなLabel.Text = "ふりがな:"
        '
        '檀家番号Label
        '
        檀家番号Label.AutoSize = True
        檀家番号Label.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        檀家番号Label.Location = New System.Drawing.Point(38, 59)
        檀家番号Label.Name = "檀家番号Label"
        檀家番号Label.Size = New System.Drawing.Size(150, 33)
        檀家番号Label.TabIndex = 5
        檀家番号Label.Text = "檀家番号:"
        '
        '入檀年月日Label
        '
        入檀年月日Label.AutoSize = True
        入檀年月日Label.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        入檀年月日Label.Location = New System.Drawing.Point(6, 213)
        入檀年月日Label.Name = "入檀年月日Label"
        入檀年月日Label.Size = New System.Drawing.Size(182, 33)
        入檀年月日Label.TabIndex = 11
        入檀年月日Label.Text = "入檀年月日:"
        '
        '_Label
        '
        _Label.AutoSize = True
        _Label.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        _Label.Location = New System.Drawing.Point(134, 258)
        _Label.Name = "_Label"
        _Label.Size = New System.Drawing.Size(54, 33)
        _Label.TabIndex = 12
        _Label.Text = "〒:"
        '
        '住所1Label
        '
        住所1Label.AutoSize = True
        住所1Label.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        住所1Label.Location = New System.Drawing.Point(86, 303)
        住所1Label.Name = "住所1Label"
        住所1Label.Size = New System.Drawing.Size(102, 33)
        住所1Label.TabIndex = 13
        住所1Label.Text = "住所1:"
        '
        '住所2Label
        '
        住所2Label.AutoSize = True
        住所2Label.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        住所2Label.Location = New System.Drawing.Point(86, 348)
        住所2Label.Name = "住所2Label"
        住所2Label.Size = New System.Drawing.Size(102, 33)
        住所2Label.TabIndex = 15
        住所2Label.Text = "住所2:"
        '
        '墓地Label
        '
        墓地Label.AutoSize = True
        墓地Label.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        墓地Label.Location = New System.Drawing.Point(328, 213)
        墓地Label.Name = "墓地Label"
        墓地Label.Size = New System.Drawing.Size(86, 33)
        墓地Label.TabIndex = 17
        墓地Label.Text = "墓地:"
        '
        'T_D_檀家BindingSource
        '
        Me.T_D_檀家BindingSource.DataMember = "T_D_檀家"
        Me.T_D_檀家BindingSource.DataSource = Me.JiinDataDataSet
        '
        'JiinDataDataSet
        '
        Me.JiinDataDataSet.DataSetName = "JiinDataDataSet"
        Me.JiinDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDankaNo
        '
        Me.txtDankaNo.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDankaNo.Location = New System.Drawing.Point(194, 56)
        Me.txtDankaNo.Name = "txtDankaNo"
        Me.txtDankaNo.Size = New System.Drawing.Size(128, 39)
        Me.txtDankaNo.TabIndex = 0
        '
        'T_D_過去帳BindingSource
        '
        Me.T_D_過去帳BindingSource.DataMember = "T_D_檀家T_D_過去帳"
        Me.T_D_過去帳BindingSource.DataSource = Me.T_D_檀家BindingSource
        '
        'T_D_過去帳DataGridView
        '
        Me.T_D_過去帳DataGridView.AllowUserToAddRows = False
        Me.T_D_過去帳DataGridView.AllowUserToDeleteRows = False
        Me.T_D_過去帳DataGridView.AutoGenerateColumns = False
        Me.T_D_過去帳DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_D_過去帳DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.T_D_過去帳DataGridView.DataSource = Me.T_D_過去帳BindingSource
        Me.T_D_過去帳DataGridView.Location = New System.Drawing.Point(12, 400)
        Me.T_D_過去帳DataGridView.Name = "T_D_過去帳DataGridView"
        Me.T_D_過去帳DataGridView.ReadOnly = True
        Me.T_D_過去帳DataGridView.RowTemplate.Height = 21
        Me.T_D_過去帳DataGridView.Size = New System.Drawing.Size(760, 222)
        Me.T_D_過去帳DataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "過去ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "過去ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "印刷"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "印刷"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "檀家ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "檀家ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "戒名"
        Me.DataGridViewTextBoxColumn3.HeaderText = "戒名"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "命日"
        Me.DataGridViewTextBoxColumn4.HeaderText = "命日"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "俗名"
        Me.DataGridViewTextBoxColumn5.HeaderText = "俗名"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "享年"
        Me.DataGridViewTextBoxColumn6.HeaderText = "享年"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "続柄ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "続柄ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "喪主名"
        Me.DataGridViewTextBoxColumn8.HeaderText = "喪主名"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "備考"
        Me.DataGridViewTextBoxColumn9.HeaderText = "備考"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'lblKana
        '
        Me.lblKana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "ふりがな", True))
        Me.lblKana.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblKana.Location = New System.Drawing.Point(194, 168)
        Me.lblKana.Name = "lblKana"
        Me.lblKana.Size = New System.Drawing.Size(312, 33)
        Me.lblKana.TabIndex = 8
        Me.lblKana.Text = "Label1"
        Me.lblKana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "戸主氏名", True))
        Me.lblName.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblName.Location = New System.Drawing.Point(194, 123)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(312, 33)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Label1"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(328, 49)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(119, 52)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.btnDetail)
        Me.grpMenu.Controls.Add(Me.btnReport)
        Me.grpMenu.Controls.Add(Me.btnRegistParent)
        Me.grpMenu.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grpMenu.Location = New System.Drawing.Point(512, 12)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(268, 189)
        Me.grpMenu.TabIndex = 11
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = "メニュー"
        '
        'btnDetail
        '
        Me.btnDetail.Enabled = False
        Me.btnDetail.Location = New System.Drawing.Point(39, 135)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(207, 43)
        Me.btnDetail.TabIndex = 2
        Me.btnDetail.Text = "詳細確認"
        Me.btnDetail.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Enabled = False
        Me.btnReport.Location = New System.Drawing.Point(39, 86)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(207, 43)
        Me.btnReport.TabIndex = 1
        Me.btnReport.Text = "帳票印刷メニュー"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnRegistParent
        '
        Me.btnRegistParent.Enabled = False
        Me.btnRegistParent.Location = New System.Drawing.Point(39, 37)
        Me.btnRegistParent.Name = "btnRegistParent"
        Me.btnRegistParent.Size = New System.Drawing.Size(207, 43)
        Me.btnRegistParent.TabIndex = 0
        Me.btnRegistParent.Text = "戸主登録"
        Me.btnRegistParent.UseVisualStyleBackColor = True
        '
        'T_D_檀家TableAdapter
        '
        Me.T_D_檀家TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.T_D_檀家TableAdapter = Me.T_D_檀家TableAdapter
        Me.TableAdapterManager.T_D_資料配付区分TableAdapter = Nothing
        Me.TableAdapterManager.T_D_過去帳TableAdapter = Me.T_D_過去帳TableAdapter
        Me.TableAdapterManager.T_M_会費TableAdapter = Nothing
        Me.TableAdapterManager.T_M_但書TableAdapter = Nothing
        Me.TableAdapterManager.T_M_元号TableAdapter = Nothing
        Me.TableAdapterManager.T_M_印刷書体TableAdapter = Nothing
        Me.TableAdapterManager.T_M_地区TableAdapter = Nothing
        Me.TableAdapterManager.T_M_墓地TableAdapter = Nothing
        Me.TableAdapterManager.T_M_年回TableAdapter = Nothing
        Me.TableAdapterManager.T_M_戒名TableAdapter = Nothing
        Me.TableAdapterManager.T_M_檀信徒別TableAdapter = Nothing
        Me.TableAdapterManager.T_M_環境設定TableAdapter = Nothing
        Me.TableAdapterManager.T_M_続柄TableAdapter = Nothing
        Me.TableAdapterManager.T_M_資料配付区分TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DankaSearch.JiinDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_D_過去帳TableAdapter
        '
        Me.T_D_過去帳TableAdapter.ClearBeforeFill = True
        '
        '入檀年月日Label1
        '
        Me.入檀年月日Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "入檀年月日", True))
        Me.入檀年月日Label1.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        Me.入檀年月日Label1.Location = New System.Drawing.Point(194, 213)
        Me.入檀年月日Label1.Name = "入檀年月日Label1"
        Me.入檀年月日Label1.Size = New System.Drawing.Size(128, 33)
        Me.入檀年月日Label1.TabIndex = 12
        Me.入檀年月日Label1.Text = "Label1"
        '
        '_Label1
        '
        Me._Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "〒", True))
        Me._Label1.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        Me._Label1.Location = New System.Drawing.Point(194, 258)
        Me._Label1.Name = "_Label1"
        Me._Label1.Size = New System.Drawing.Size(179, 33)
        Me._Label1.TabIndex = 13
        Me._Label1.Text = "Label1"
        '
        '住所1Label1
        '
        Me.住所1Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "住所1", True))
        Me.住所1Label1.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        Me.住所1Label1.Location = New System.Drawing.Point(194, 348)
        Me.住所1Label1.Name = "住所1Label1"
        Me.住所1Label1.Size = New System.Drawing.Size(586, 33)
        Me.住所1Label1.TabIndex = 14
        Me.住所1Label1.Text = "Label1"
        '
        '住所2Label1
        '
        Me.住所2Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "住所2", True))
        Me.住所2Label1.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        Me.住所2Label1.Location = New System.Drawing.Point(194, 303)
        Me.住所2Label1.Name = "住所2Label1"
        Me.住所2Label1.Size = New System.Drawing.Size(586, 33)
        Me.住所2Label1.TabIndex = 16
        Me.住所2Label1.Text = "Label1"
        '
        '墓地Label1
        '
        Me.墓地Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "墓地", True))
        Me.墓地Label1.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        Me.墓地Label1.Location = New System.Drawing.Point(420, 213)
        Me.墓地Label1.Name = "墓地Label1"
        Me.墓地Label1.Size = New System.Drawing.Size(179, 33)
        Me.墓地Label1.TabIndex = 18
        Me.墓地Label1.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 642)
        Me.Controls.Add(墓地Label)
        Me.Controls.Add(Me.墓地Label1)
        Me.Controls.Add(住所2Label)
        Me.Controls.Add(Me.住所2Label1)
        Me.Controls.Add(住所1Label)
        Me.Controls.Add(Me.住所1Label1)
        Me.Controls.Add(_Label)
        Me.Controls.Add(Me._Label1)
        Me.Controls.Add(入檀年月日Label)
        Me.Controls.Add(Me.入檀年月日Label1)
        Me.Controls.Add(Me.grpMenu)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblKana)
        Me.Controls.Add(Me.T_D_過去帳DataGridView)
        Me.Controls.Add(檀家番号Label)
        Me.Controls.Add(Me.txtDankaNo)
        Me.Controls.Add(ふりがなLabel)
        Me.Controls.Add(戸主氏名Label)
        Me.Name = "frmMain"
        Me.Text = "檀家検索"
        CType(Me.T_D_檀家BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JiinDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_D_過去帳BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_D_過去帳DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JiinDataDataSet As DankaSearch.JiinDataDataSet
    Friend WithEvents T_D_檀家BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_D_檀家TableAdapter As DankaSearch.JiinDataDataSetTableAdapters.T_D_檀家TableAdapter
    Friend WithEvents TableAdapterManager As DankaSearch.JiinDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents T_D_過去帳TableAdapter As DankaSearch.JiinDataDataSetTableAdapters.T_D_過去帳TableAdapter
    Friend WithEvents txtDankaNo As System.Windows.Forms.TextBox
    Friend WithEvents T_D_過去帳BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_D_過去帳DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblKana As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents grpMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnRegistParent As System.Windows.Forms.Button
    Friend WithEvents 入檀年月日Label1 As System.Windows.Forms.Label
    Friend WithEvents _Label1 As System.Windows.Forms.Label
    Friend WithEvents 住所1Label1 As System.Windows.Forms.Label
    Friend WithEvents 住所2Label1 As System.Windows.Forms.Label
    Friend WithEvents 墓地Label1 As System.Windows.Forms.Label

End Class
