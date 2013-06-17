<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetail
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
        Dim 檀家番号Label As System.Windows.Forms.Label
        Dim ふりがなLabel As System.Windows.Forms.Label
        Dim 戸主氏名Label As System.Windows.Forms.Label
        Dim 檀信徒別IDLabel As System.Windows.Forms.Label
        Dim 入檀年月日Label As System.Windows.Forms.Label
        Dim _Label As System.Windows.Forms.Label
        Dim 住所1Label As System.Windows.Forms.Label
        Dim 住所2Label As System.Windows.Forms.Label
        Dim 地域名Label As System.Windows.Forms.Label
        Dim TELLabel As System.Windows.Forms.Label
        Dim FAXLabel As System.Windows.Forms.Label
        Dim 墓地Label As System.Windows.Forms.Label
        Dim 備考Label As System.Windows.Forms.Label
        Dim DummyLabel As System.Windows.Forms.Label
        Dim Dummy金額Label As System.Windows.Forms.Label
        Me.JiinDataDataSet = New DankaSearch.JiinDataDataSet()
        Me.T_D_檀家BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_D_檀家TableAdapter = New DankaSearch.JiinDataDataSetTableAdapters.T_D_檀家TableAdapter()
        Me.TableAdapterManager = New DankaSearch.JiinDataDataSetTableAdapters.TableAdapterManager()
        Me.T_D_過去帳TableAdapter = New DankaSearch.JiinDataDataSetTableAdapters.T_D_過去帳TableAdapter()
        Me.檀家番号Label1 = New System.Windows.Forms.Label()
        Me.ふりがなLabel1 = New System.Windows.Forms.Label()
        Me.戸主氏名Label1 = New System.Windows.Forms.Label()
        Me.檀信徒別IDLabel1 = New System.Windows.Forms.Label()
        Me.入檀年月日Label1 = New System.Windows.Forms.Label()
        Me._Label1 = New System.Windows.Forms.Label()
        Me.住所1Label1 = New System.Windows.Forms.Label()
        Me.住所2Label1 = New System.Windows.Forms.Label()
        Me.地域名Label1 = New System.Windows.Forms.Label()
        Me.TELLabel1 = New System.Windows.Forms.Label()
        Me.FAXLabel1 = New System.Windows.Forms.Label()
        Me.墓地Label1 = New System.Windows.Forms.Label()
        Me.備考Label1 = New System.Windows.Forms.Label()
        Me.DummyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Dummy金額Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.T_D_過去帳BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.T_D_会費DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_D_会費BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.T_D_檀家DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        檀家番号Label = New System.Windows.Forms.Label()
        ふりがなLabel = New System.Windows.Forms.Label()
        戸主氏名Label = New System.Windows.Forms.Label()
        檀信徒別IDLabel = New System.Windows.Forms.Label()
        入檀年月日Label = New System.Windows.Forms.Label()
        _Label = New System.Windows.Forms.Label()
        住所1Label = New System.Windows.Forms.Label()
        住所2Label = New System.Windows.Forms.Label()
        地域名Label = New System.Windows.Forms.Label()
        TELLabel = New System.Windows.Forms.Label()
        FAXLabel = New System.Windows.Forms.Label()
        墓地Label = New System.Windows.Forms.Label()
        備考Label = New System.Windows.Forms.Label()
        DummyLabel = New System.Windows.Forms.Label()
        Dummy金額Label = New System.Windows.Forms.Label()
        CType(Me.JiinDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_D_檀家BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.T_D_過去帳DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_D_過去帳BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.T_D_会費DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_D_会費BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.T_D_檀家DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '檀家番号Label
        '
        檀家番号Label.AutoSize = True
        檀家番号Label.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        檀家番号Label.Location = New System.Drawing.Point(38, 23)
        檀家番号Label.Name = "檀家番号Label"
        檀家番号Label.Size = New System.Drawing.Size(89, 19)
        檀家番号Label.TabIndex = 1
        檀家番号Label.Text = "檀家番号:"
        '
        'ふりがなLabel
        '
        ふりがなLabel.AutoSize = True
        ふりがなLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ふりがなLabel.Location = New System.Drawing.Point(309, 60)
        ふりがなLabel.Name = "ふりがなLabel"
        ふりがなLabel.Size = New System.Drawing.Size(73, 19)
        ふりがなLabel.TabIndex = 3
        ふりがなLabel.Text = "ふりがな:"
        '
        '戸主氏名Label
        '
        戸主氏名Label.AutoSize = True
        戸主氏名Label.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        戸主氏名Label.Location = New System.Drawing.Point(38, 60)
        戸主氏名Label.Name = "戸主氏名Label"
        戸主氏名Label.Size = New System.Drawing.Size(89, 19)
        戸主氏名Label.TabIndex = 5
        戸主氏名Label.Text = "戸主氏名:"
        '
        '檀信徒別IDLabel
        '
        檀信徒別IDLabel.AutoSize = True
        檀信徒別IDLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        檀信徒別IDLabel.Location = New System.Drawing.Point(490, 23)
        檀信徒別IDLabel.Name = "檀信徒別IDLabel"
        檀信徒別IDLabel.Size = New System.Drawing.Size(106, 19)
        檀信徒別IDLabel.TabIndex = 7
        檀信徒別IDLabel.Text = "檀信徒別ID:"
        '
        '入檀年月日Label
        '
        入檀年月日Label.AutoSize = True
        入檀年月日Label.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        入檀年月日Label.Location = New System.Drawing.Point(252, 23)
        入檀年月日Label.Name = "入檀年月日Label"
        入檀年月日Label.Size = New System.Drawing.Size(108, 19)
        入檀年月日Label.TabIndex = 8
        入檀年月日Label.Text = "入檀年月日:"
        '
        '_Label
        '
        _Label.AutoSize = True
        _Label.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        _Label.Location = New System.Drawing.Point(95, 94)
        _Label.Name = "_Label"
        _Label.Size = New System.Drawing.Size(32, 19)
        _Label.TabIndex = 10
        _Label.Text = "〒:"
        '
        '住所1Label
        '
        住所1Label.AutoSize = True
        住所1Label.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        住所1Label.Location = New System.Drawing.Point(66, 126)
        住所1Label.Name = "住所1Label"
        住所1Label.Size = New System.Drawing.Size(61, 19)
        住所1Label.TabIndex = 12
        住所1Label.Text = "住所1:"
        '
        '住所2Label
        '
        住所2Label.AutoSize = True
        住所2Label.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        住所2Label.Location = New System.Drawing.Point(66, 159)
        住所2Label.Name = "住所2Label"
        住所2Label.Size = New System.Drawing.Size(61, 19)
        住所2Label.TabIndex = 14
        住所2Label.Text = "住所2:"
        '
        '地域名Label
        '
        地域名Label.AutoSize = True
        地域名Label.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        地域名Label.Location = New System.Drawing.Point(57, 223)
        地域名Label.Name = "地域名Label"
        地域名Label.Size = New System.Drawing.Size(70, 19)
        地域名Label.TabIndex = 16
        地域名Label.Text = "地域名:"
        '
        'TELLabel
        '
        TELLabel.AutoSize = True
        TELLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        TELLabel.Location = New System.Drawing.Point(82, 191)
        TELLabel.Name = "TELLabel"
        TELLabel.Size = New System.Drawing.Size(45, 19)
        TELLabel.TabIndex = 18
        TELLabel.Text = "TEL:"
        '
        'FAXLabel
        '
        FAXLabel.AutoSize = True
        FAXLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        FAXLabel.Location = New System.Drawing.Point(388, 191)
        FAXLabel.Name = "FAXLabel"
        FAXLabel.Size = New System.Drawing.Size(46, 19)
        FAXLabel.TabIndex = 20
        FAXLabel.Text = "FAX:"
        '
        '墓地Label
        '
        墓地Label.AutoSize = True
        墓地Label.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        墓地Label.Location = New System.Drawing.Point(252, 223)
        墓地Label.Name = "墓地Label"
        墓地Label.Size = New System.Drawing.Size(51, 19)
        墓地Label.TabIndex = 22
        墓地Label.Text = "墓地:"
        '
        '備考Label
        '
        備考Label.AutoSize = True
        備考Label.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        備考Label.Location = New System.Drawing.Point(76, 256)
        備考Label.Name = "備考Label"
        備考Label.Size = New System.Drawing.Size(51, 19)
        備考Label.TabIndex = 24
        備考Label.Text = "備考:"
        '
        'DummyLabel
        '
        DummyLabel.AutoSize = True
        DummyLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DummyLabel.Location = New System.Drawing.Point(415, 223)
        DummyLabel.Name = "DummyLabel"
        DummyLabel.Size = New System.Drawing.Size(69, 19)
        DummyLabel.TabIndex = 32
        DummyLabel.Text = "dummy:"
        '
        'Dummy金額Label
        '
        Dummy金額Label.AutoSize = True
        Dummy金額Label.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Dummy金額Label.Location = New System.Drawing.Point(515, 223)
        Dummy金額Label.Name = "Dummy金額Label"
        Dummy金額Label.Size = New System.Drawing.Size(107, 19)
        Dummy金額Label.TabIndex = 34
        Dummy金額Label.Text = "dummy金額:"
        '
        'JiinDataDataSet
        '
        Me.JiinDataDataSet.DataSetName = "JiinDataDataSet"
        Me.JiinDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_D_檀家BindingSource
        '
        Me.T_D_檀家BindingSource.DataMember = "T_D_檀家"
        Me.T_D_檀家BindingSource.DataSource = Me.JiinDataDataSet
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
        '檀家番号Label1
        '
        Me.檀家番号Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "檀家番号", True))
        Me.檀家番号Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.檀家番号Label1.Location = New System.Drawing.Point(133, 23)
        Me.檀家番号Label1.Name = "檀家番号Label1"
        Me.檀家番号Label1.Size = New System.Drawing.Size(100, 23)
        Me.檀家番号Label1.TabIndex = 2
        Me.檀家番号Label1.Text = "Label1"
        '
        'ふりがなLabel1
        '
        Me.ふりがなLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "ふりがな", True))
        Me.ふりがなLabel1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ふりがなLabel1.Location = New System.Drawing.Point(388, 60)
        Me.ふりがなLabel1.Name = "ふりがなLabel1"
        Me.ふりがなLabel1.Size = New System.Drawing.Size(208, 23)
        Me.ふりがなLabel1.TabIndex = 4
        Me.ふりがなLabel1.Text = "Label1"
        '
        '戸主氏名Label1
        '
        Me.戸主氏名Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "戸主氏名", True))
        Me.戸主氏名Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.戸主氏名Label1.Location = New System.Drawing.Point(133, 60)
        Me.戸主氏名Label1.Name = "戸主氏名Label1"
        Me.戸主氏名Label1.Size = New System.Drawing.Size(170, 23)
        Me.戸主氏名Label1.TabIndex = 6
        Me.戸主氏名Label1.Text = "Label1"
        '
        '檀信徒別IDLabel1
        '
        Me.檀信徒別IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "檀信徒別ID", True))
        Me.檀信徒別IDLabel1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.檀信徒別IDLabel1.Location = New System.Drawing.Point(597, 23)
        Me.檀信徒別IDLabel1.Name = "檀信徒別IDLabel1"
        Me.檀信徒別IDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.檀信徒別IDLabel1.TabIndex = 8
        Me.檀信徒別IDLabel1.Text = "Label1"
        '
        '入檀年月日Label1
        '
        Me.入檀年月日Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "入檀年月日", True))
        Me.入檀年月日Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.入檀年月日Label1.Location = New System.Drawing.Point(366, 23)
        Me.入檀年月日Label1.Name = "入檀年月日Label1"
        Me.入檀年月日Label1.Size = New System.Drawing.Size(100, 23)
        Me.入檀年月日Label1.TabIndex = 9
        Me.入檀年月日Label1.Text = "Label1"
        '
        '_Label1
        '
        Me._Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "〒", True))
        Me._Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me._Label1.Location = New System.Drawing.Point(133, 94)
        Me._Label1.Name = "_Label1"
        Me._Label1.Size = New System.Drawing.Size(100, 23)
        Me._Label1.TabIndex = 11
        Me._Label1.Text = "Label1"
        '
        '住所1Label1
        '
        Me.住所1Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "住所1", True))
        Me.住所1Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.住所1Label1.Location = New System.Drawing.Point(133, 126)
        Me.住所1Label1.Name = "住所1Label1"
        Me.住所1Label1.Size = New System.Drawing.Size(376, 23)
        Me.住所1Label1.TabIndex = 13
        Me.住所1Label1.Text = "Label1"
        '
        '住所2Label1
        '
        Me.住所2Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "住所2", True))
        Me.住所2Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.住所2Label1.Location = New System.Drawing.Point(133, 159)
        Me.住所2Label1.Name = "住所2Label1"
        Me.住所2Label1.Size = New System.Drawing.Size(376, 23)
        Me.住所2Label1.TabIndex = 15
        Me.住所2Label1.Text = "Label1"
        '
        '地域名Label1
        '
        Me.地域名Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "地域名", True))
        Me.地域名Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.地域名Label1.Location = New System.Drawing.Point(133, 223)
        Me.地域名Label1.Name = "地域名Label1"
        Me.地域名Label1.Size = New System.Drawing.Size(100, 23)
        Me.地域名Label1.TabIndex = 17
        Me.地域名Label1.Text = "Label1"
        '
        'TELLabel1
        '
        Me.TELLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "TEL", True))
        Me.TELLabel1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TELLabel1.Location = New System.Drawing.Point(133, 191)
        Me.TELLabel1.Name = "TELLabel1"
        Me.TELLabel1.Size = New System.Drawing.Size(249, 23)
        Me.TELLabel1.TabIndex = 19
        Me.TELLabel1.Text = "Label1"
        '
        'FAXLabel1
        '
        Me.FAXLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "FAX", True))
        Me.FAXLabel1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FAXLabel1.Location = New System.Drawing.Point(440, 191)
        Me.FAXLabel1.Name = "FAXLabel1"
        Me.FAXLabel1.Size = New System.Drawing.Size(249, 23)
        Me.FAXLabel1.TabIndex = 21
        Me.FAXLabel1.Text = "Label1"
        '
        '墓地Label1
        '
        Me.墓地Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "墓地", True))
        Me.墓地Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.墓地Label1.Location = New System.Drawing.Point(309, 223)
        Me.墓地Label1.Name = "墓地Label1"
        Me.墓地Label1.Size = New System.Drawing.Size(100, 23)
        Me.墓地Label1.TabIndex = 23
        Me.墓地Label1.Text = "Label1"
        '
        '備考Label1
        '
        Me.備考Label1.AutoEllipsis = True
        Me.備考Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "備考", True))
        Me.備考Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.備考Label1.Location = New System.Drawing.Point(133, 256)
        Me.備考Label1.Name = "備考Label1"
        Me.備考Label1.Size = New System.Drawing.Size(620, 53)
        Me.備考Label1.TabIndex = 25
        Me.備考Label1.Text = "Label1"
        '
        'DummyCheckBox
        '
        Me.DummyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.T_D_檀家BindingSource, "dummy", True))
        Me.DummyCheckBox.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DummyCheckBox.Location = New System.Drawing.Point(490, 221)
        Me.DummyCheckBox.Name = "DummyCheckBox"
        Me.DummyCheckBox.Size = New System.Drawing.Size(19, 24)
        Me.DummyCheckBox.TabIndex = 33
        Me.DummyCheckBox.UseVisualStyleBackColor = True
        '
        'Dummy金額Label1
        '
        Me.Dummy金額Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "dummy金額", True))
        Me.Dummy金額Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Dummy金額Label1.Location = New System.Drawing.Point(628, 223)
        Me.Dummy金額Label1.Name = "Dummy金額Label1"
        Me.Dummy金額Label1.Size = New System.Drawing.Size(100, 23)
        Me.Dummy金額Label1.TabIndex = 35
        Me.Dummy金額Label1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ふりがなLabel1)
        Me.GroupBox1.Controls.Add(ふりがなLabel)
        Me.GroupBox1.Controls.Add(Dummy金額Label)
        Me.GroupBox1.Controls.Add(Me.Dummy金額Label1)
        Me.GroupBox1.Controls.Add(檀家番号Label)
        Me.GroupBox1.Controls.Add(Me._Label1)
        Me.GroupBox1.Controls.Add(Me.戸主氏名Label1)
        Me.GroupBox1.Controls.Add(DummyLabel)
        Me.GroupBox1.Controls.Add(Me.DummyCheckBox)
        Me.GroupBox1.Controls.Add(Me.檀家番号Label1)
        Me.GroupBox1.Controls.Add(戸主氏名Label)
        Me.GroupBox1.Controls.Add(Me.檀信徒別IDLabel1)
        Me.GroupBox1.Controls.Add(檀信徒別IDLabel)
        Me.GroupBox1.Controls.Add(Me.入檀年月日Label1)
        Me.GroupBox1.Controls.Add(備考Label)
        Me.GroupBox1.Controls.Add(入檀年月日Label)
        Me.GroupBox1.Controls.Add(Me.備考Label1)
        Me.GroupBox1.Controls.Add(_Label)
        Me.GroupBox1.Controls.Add(墓地Label)
        Me.GroupBox1.Controls.Add(Me.住所1Label1)
        Me.GroupBox1.Controls.Add(Me.墓地Label1)
        Me.GroupBox1.Controls.Add(住所1Label)
        Me.GroupBox1.Controls.Add(地域名Label)
        Me.GroupBox1.Controls.Add(Me.地域名Label1)
        Me.GroupBox1.Controls.Add(Me.住所2Label1)
        Me.GroupBox1.Controls.Add(住所2Label)
        Me.GroupBox1.Controls.Add(Me.TELLabel1)
        Me.GroupBox1.Controls.Add(TELLabel)
        Me.GroupBox1.Controls.Add(Me.FAXLabel1)
        Me.GroupBox1.Controls.Add(FAXLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 327)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "基本情報"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 346)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(759, 215)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "付随情報"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(7, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(746, 222)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.T_D_過去帳DataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(738, 196)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "過去帳"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'T_D_過去帳DataGridView
        '
        Me.T_D_過去帳DataGridView.AllowUserToAddRows = False
        Me.T_D_過去帳DataGridView.AllowUserToDeleteRows = False
        Me.T_D_過去帳DataGridView.AutoGenerateColumns = False
        Me.T_D_過去帳DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_D_過去帳DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.T_D_過去帳DataGridView.DataSource = Me.T_D_過去帳BindingSource
        Me.T_D_過去帳DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.T_D_過去帳DataGridView.Name = "T_D_過去帳DataGridView"
        Me.T_D_過去帳DataGridView.RowTemplate.Height = 21
        Me.T_D_過去帳DataGridView.Size = New System.Drawing.Size(738, 196)
        Me.T_D_過去帳DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "過去ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "過去ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "印刷"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "印刷"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "檀家ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "檀家ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "戒名"
        Me.DataGridViewTextBoxColumn3.HeaderText = "戒名"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "命日"
        Me.DataGridViewTextBoxColumn4.HeaderText = "命日"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "俗名"
        Me.DataGridViewTextBoxColumn5.HeaderText = "俗名"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "享年"
        Me.DataGridViewTextBoxColumn6.HeaderText = "享年"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "続柄ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "続柄ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "喪主名"
        Me.DataGridViewTextBoxColumn8.HeaderText = "喪主名"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "備考"
        Me.DataGridViewTextBoxColumn9.HeaderText = "備考"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'T_D_過去帳BindingSource
        '
        Me.T_D_過去帳BindingSource.DataMember = "T_D_過去帳"
        Me.T_D_過去帳BindingSource.DataSource = Me.JiinDataDataSet
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.T_D_会費DataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(738, 196)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "会費履歴"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'T_D_会費DataGridView
        '
        Me.T_D_会費DataGridView.AllowUserToAddRows = False
        Me.T_D_会費DataGridView.AllowUserToDeleteRows = False
        Me.T_D_会費DataGridView.AutoGenerateColumns = False
        Me.T_D_会費DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_D_会費DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.T_D_会費DataGridView.DataSource = Me.T_D_会費BindingSource
        Me.T_D_会費DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.T_D_会費DataGridView.Name = "T_D_会費DataGridView"
        Me.T_D_会費DataGridView.RowTemplate.Height = 21
        Me.T_D_会費DataGridView.Size = New System.Drawing.Size(738, 196)
        Me.T_D_会費DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "檀家番号"
        Me.DataGridViewTextBoxColumn10.HeaderText = "檀家番号"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "会費No"
        Me.DataGridViewTextBoxColumn11.HeaderText = "会費No"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "入金日"
        Me.DataGridViewTextBoxColumn12.HeaderText = "入金日"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "備考"
        Me.DataGridViewTextBoxColumn13.HeaderText = "備考"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "入金額"
        Me.DataGridViewTextBoxColumn14.HeaderText = "入金額"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'T_D_会費BindingSource
        '
        Me.T_D_会費BindingSource.DataMember = "T_D_会費"
        Me.T_D_会費BindingSource.DataSource = Me.JiinDataDataSet
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.T_D_檀家DataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(738, 196)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "現在帳"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'T_D_檀家DataGridView
        '
        Me.T_D_檀家DataGridView.AllowUserToAddRows = False
        Me.T_D_檀家DataGridView.AllowUserToDeleteRows = False
        Me.T_D_檀家DataGridView.AutoGenerateColumns = False
        Me.T_D_檀家DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_D_檀家DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn31})
        Me.T_D_檀家DataGridView.DataSource = Me.T_D_檀家BindingSource
        Me.T_D_檀家DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.T_D_檀家DataGridView.Name = "T_D_檀家DataGridView"
        Me.T_D_檀家DataGridView.RowTemplate.Height = 21
        Me.T_D_檀家DataGridView.Size = New System.Drawing.Size(738, 196)
        Me.T_D_檀家DataGridView.TabIndex = 0
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "削除"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "削除"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "印刷"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "印刷"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "檀家番号"
        Me.DataGridViewTextBoxColumn15.HeaderText = "檀家番号"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ふりがな"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ふりがな"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "戸主氏名"
        Me.DataGridViewTextBoxColumn17.HeaderText = "戸主氏名"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "檀信徒別ID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "檀信徒別ID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "入檀年月日"
        Me.DataGridViewTextBoxColumn19.HeaderText = "入檀年月日"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "〒"
        Me.DataGridViewTextBoxColumn20.HeaderText = "〒"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "住所1"
        Me.DataGridViewTextBoxColumn21.HeaderText = "住所1"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "住所2"
        Me.DataGridViewTextBoxColumn22.HeaderText = "住所2"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "地域名"
        Me.DataGridViewTextBoxColumn23.HeaderText = "地域名"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "TEL"
        Me.DataGridViewTextBoxColumn24.HeaderText = "TEL"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "FAX"
        Me.DataGridViewTextBoxColumn25.HeaderText = "FAX"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "墓地"
        Me.DataGridViewTextBoxColumn26.HeaderText = "墓地"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "備考"
        Me.DataGridViewTextBoxColumn27.HeaderText = "備考"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "経度"
        Me.DataGridViewTextBoxColumn28.HeaderText = "経度"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "緯度"
        Me.DataGridViewTextBoxColumn29.HeaderText = "緯度"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "スケール"
        Me.DataGridViewTextBoxColumn30.HeaderText = "スケール"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "dummy"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "dummy"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "dummy金額"
        Me.DataGridViewTextBoxColumn31.HeaderText = "dummy金額"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'frmDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 573)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetail"
        Me.Text = "詳細情報"
        CType(Me.JiinDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_D_檀家BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.T_D_過去帳DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_D_過去帳BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.T_D_会費DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_D_会費BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.T_D_檀家DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents JiinDataDataSet As DankaSearch.JiinDataDataSet
    Friend WithEvents T_D_檀家BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_D_檀家TableAdapter As DankaSearch.JiinDataDataSetTableAdapters.T_D_檀家TableAdapter
    Friend WithEvents TableAdapterManager As DankaSearch.JiinDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 檀家番号Label1 As System.Windows.Forms.Label
    Friend WithEvents ふりがなLabel1 As System.Windows.Forms.Label
    Friend WithEvents 戸主氏名Label1 As System.Windows.Forms.Label
    Friend WithEvents 檀信徒別IDLabel1 As System.Windows.Forms.Label
    Friend WithEvents 入檀年月日Label1 As System.Windows.Forms.Label
    Friend WithEvents _Label1 As System.Windows.Forms.Label
    Friend WithEvents 住所1Label1 As System.Windows.Forms.Label
    Friend WithEvents 住所2Label1 As System.Windows.Forms.Label
    Friend WithEvents 地域名Label1 As System.Windows.Forms.Label
    Friend WithEvents TELLabel1 As System.Windows.Forms.Label
    Friend WithEvents FAXLabel1 As System.Windows.Forms.Label
    Friend WithEvents 墓地Label1 As System.Windows.Forms.Label
    Friend WithEvents 備考Label1 As System.Windows.Forms.Label
    Friend WithEvents DummyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Dummy金額Label1 As System.Windows.Forms.Label
    Friend WithEvents T_D_過去帳TableAdapter As DankaSearch.JiinDataDataSetTableAdapters.T_D_過去帳TableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
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
    Friend WithEvents T_D_会費DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T_D_会費BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents T_D_檀家DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
