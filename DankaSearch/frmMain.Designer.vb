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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.T_D_檀家TableAdapter = New DankaSearch.JiinDataDataSetTableAdapters.T_D_檀家TableAdapter()
        Me.TableAdapterManager = New DankaSearch.JiinDataDataSetTableAdapters.TableAdapterManager()
        Me.T_D_過去帳TableAdapter = New DankaSearch.JiinDataDataSetTableAdapters.T_D_過去帳TableAdapter()
        Me.入檀年月日Label1 = New System.Windows.Forms.Label()
        戸主氏名Label = New System.Windows.Forms.Label()
        ふりがなLabel = New System.Windows.Forms.Label()
        檀家番号Label = New System.Windows.Forms.Label()
        入檀年月日Label = New System.Windows.Forms.Label()
        CType(Me.T_D_檀家BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JiinDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_D_過去帳BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_D_過去帳DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '戸主氏名Label
        '
        戸主氏名Label.AutoSize = True
        戸主氏名Label.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        戸主氏名Label.Location = New System.Drawing.Point(38, 139)
        戸主氏名Label.Name = "戸主氏名Label"
        戸主氏名Label.Size = New System.Drawing.Size(150, 33)
        戸主氏名Label.TabIndex = 1
        戸主氏名Label.Text = "戸主氏名:"
        '
        'ふりがなLabel
        '
        ふりがなLabel.AutoSize = True
        ふりがなLabel.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ふりがなLabel.Location = New System.Drawing.Point(66, 187)
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
        入檀年月日Label.Location = New System.Drawing.Point(6, 232)
        入檀年月日Label.Name = "入檀年月日Label"
        入檀年月日Label.Size = New System.Drawing.Size(182, 33)
        入檀年月日Label.TabIndex = 11
        入檀年月日Label.Text = "入檀年月日:"
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
        Me.txtDankaNo.Size = New System.Drawing.Size(85, 39)
        Me.txtDankaNo.TabIndex = 6
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
        Me.T_D_過去帳DataGridView.Location = New System.Drawing.Point(12, 360)
        Me.T_D_過去帳DataGridView.Name = "T_D_過去帳DataGridView"
        Me.T_D_過去帳DataGridView.ReadOnly = True
        Me.T_D_過去帳DataGridView.RowTemplate.Height = 21
        Me.T_D_過去帳DataGridView.Size = New System.Drawing.Size(760, 190)
        Me.T_D_過去帳DataGridView.TabIndex = 7
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
        Me.lblKana.Location = New System.Drawing.Point(194, 187)
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
        Me.lblName.Location = New System.Drawing.Point(194, 139)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(312, 33)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Label1"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(295, 49)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(119, 52)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(512, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 208)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "メニュー"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(39, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(207, 43)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "詳細編集"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(39, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(207, 43)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "帳票印刷"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(39, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 43)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "過去帳出力"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.入檀年月日Label1.Location = New System.Drawing.Point(194, 232)
        Me.入檀年月日Label1.Name = "入檀年月日Label1"
        Me.入檀年月日Label1.Size = New System.Drawing.Size(312, 33)
        Me.入檀年月日Label1.TabIndex = 12
        Me.入檀年月日Label1.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 570)
        Me.Controls.Add(入檀年月日Label)
        Me.Controls.Add(Me.入檀年月日Label1)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents 入檀年月日Label1 As System.Windows.Forms.Label

End Class
