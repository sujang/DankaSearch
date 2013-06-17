<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistParent
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
        Dim 戸主氏名Label As System.Windows.Forms.Label
        Dim 戸主氏名Label2 As System.Windows.Forms.Label
        Dim 檀家番号Label2 As System.Windows.Forms.Label
        Me.JiinDataDataSet = New DankaSearch.JiinDataDataSet()
        Me.T_D_檀家BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_D_檀家TableAdapter = New DankaSearch.JiinDataDataSetTableAdapters.T_D_檀家TableAdapter()
        Me.TableAdapterManager = New DankaSearch.JiinDataDataSetTableAdapters.TableAdapterManager()
        Me.檀家番号Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.戸主氏名Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbDanka = New System.Windows.Forms.ComboBox()
        Me.戸主氏名Label3 = New System.Windows.Forms.Label()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        檀家番号Label = New System.Windows.Forms.Label()
        戸主氏名Label = New System.Windows.Forms.Label()
        戸主氏名Label2 = New System.Windows.Forms.Label()
        檀家番号Label2 = New System.Windows.Forms.Label()
        CType(Me.JiinDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_D_檀家BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        '檀家番号Label
        '
        檀家番号Label.AutoSize = True
        檀家番号Label.Location = New System.Drawing.Point(40, 30)
        檀家番号Label.Name = "檀家番号Label"
        檀家番号Label.Size = New System.Drawing.Size(55, 12)
        檀家番号Label.TabIndex = 1
        檀家番号Label.Text = "檀家番号:"
        '
        '戸主氏名Label
        '
        戸主氏名Label.AutoSize = True
        戸主氏名Label.Location = New System.Drawing.Point(40, 67)
        戸主氏名Label.Name = "戸主氏名Label"
        戸主氏名Label.Size = New System.Drawing.Size(55, 12)
        戸主氏名Label.TabIndex = 2
        戸主氏名Label.Text = "戸主氏名:"
        '
        '戸主氏名Label2
        '
        戸主氏名Label2.AutoSize = True
        戸主氏名Label2.Location = New System.Drawing.Point(40, 63)
        戸主氏名Label2.Name = "戸主氏名Label2"
        戸主氏名Label2.Size = New System.Drawing.Size(55, 12)
        戸主氏名Label2.TabIndex = 2
        戸主氏名Label2.Text = "戸主氏名:"
        '
        '檀家番号Label2
        '
        檀家番号Label2.AutoSize = True
        檀家番号Label2.Location = New System.Drawing.Point(40, 27)
        檀家番号Label2.Name = "檀家番号Label2"
        檀家番号Label2.Size = New System.Drawing.Size(55, 12)
        檀家番号Label2.TabIndex = 3
        檀家番号Label2.Text = "檀家番号:"
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
        Me.TableAdapterManager.T_D_過去帳TableAdapter = Nothing
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
        '檀家番号Label1
        '
        Me.檀家番号Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "檀家番号", True))
        Me.檀家番号Label1.Location = New System.Drawing.Point(101, 30)
        Me.檀家番号Label1.Name = "檀家番号Label1"
        Me.檀家番号Label1.Size = New System.Drawing.Size(100, 23)
        Me.檀家番号Label1.TabIndex = 2
        Me.檀家番号Label1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(戸主氏名Label)
        Me.GroupBox1.Controls.Add(Me.戸主氏名Label1)
        Me.GroupBox1.Controls.Add(檀家番号Label)
        Me.GroupBox1.Controls.Add(Me.檀家番号Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 93)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "檀家情報"
        '
        '戸主氏名Label1
        '
        Me.戸主氏名Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "戸主氏名", True))
        Me.戸主氏名Label1.Location = New System.Drawing.Point(101, 67)
        Me.戸主氏名Label1.Name = "戸主氏名Label1"
        Me.戸主氏名Label1.Size = New System.Drawing.Size(100, 23)
        Me.戸主氏名Label1.TabIndex = 3
        Me.戸主氏名Label1.Text = "Label1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(檀家番号Label2)
        Me.GroupBox2.Controls.Add(Me.cmbDanka)
        Me.GroupBox2.Controls.Add(戸主氏名Label2)
        Me.GroupBox2.Controls.Add(Me.戸主氏名Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 106)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "戸主情報"
        '
        'cmbDanka
        '
        Me.cmbDanka.FormattingEnabled = True
        Me.cmbDanka.Location = New System.Drawing.Point(101, 24)
        Me.cmbDanka.Name = "cmbDanka"
        Me.cmbDanka.Size = New System.Drawing.Size(121, 20)
        Me.cmbDanka.TabIndex = 4
        '
        '戸主氏名Label3
        '
        Me.戸主氏名Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_D_檀家BindingSource, "戸主氏名", True))
        Me.戸主氏名Label3.Location = New System.Drawing.Point(101, 63)
        Me.戸主氏名Label3.Name = "戸主氏名Label3"
        Me.戸主氏名Label3.Size = New System.Drawing.Size(100, 23)
        Me.戸主氏名Label3.TabIndex = 3
        Me.戸主氏名Label3.Text = "Label1"
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(115, 224)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(75, 23)
        Me.btnRegist.TabIndex = 5
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(197, 224)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmRegistParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRegistParent"
        Me.Text = "家族関連付け"
        CType(Me.JiinDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_D_檀家BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents JiinDataDataSet As DankaSearch.JiinDataDataSet
    Friend WithEvents T_D_檀家BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_D_檀家TableAdapter As DankaSearch.JiinDataDataSetTableAdapters.T_D_檀家TableAdapter
    Friend WithEvents TableAdapterManager As DankaSearch.JiinDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 檀家番号Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents 戸主氏名Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDanka As System.Windows.Forms.ComboBox
    Friend WithEvents 戸主氏名Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
