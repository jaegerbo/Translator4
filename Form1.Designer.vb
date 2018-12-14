<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
   Inherits System.Windows.Forms.Form

   'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

   'Wird vom Windows Form-Designer benötigt.
   Private components As System.ComponentModel.IContainer

   'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
   'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
   'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.gridTexte = New System.Windows.Forms.DataGridView()
      Me.KeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.SourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.ContextDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.ChangesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.EnglishDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.FrenchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.GermanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.KlingonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.SpanishDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.PolishDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.TblStandardTexteDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.cbSource = New System.Windows.Forms.ComboBox()
      Me.lblSource = New System.Windows.Forms.Label()
      Me.txtSuchbegriff = New System.Windows.Forms.TextBox()
      Me.btnSucheStarten = New System.Windows.Forms.Button()
      Me.btnTexteLaden = New System.Windows.Forms.Button()
      Me.sbStatus = New System.Windows.Forms.StatusStrip()
      Me.lblStatustext = New System.Windows.Forms.ToolStripStatusLabel()
      Me.lblDauer = New System.Windows.Forms.ToolStripStatusLabel()
      Me.DsTexte = New Translator.dsTexte()
      Me.tabTexte = New System.Windows.Forms.TabControl()
      Me.tabPageStandardtexte = New System.Windows.Forms.TabPage()
      Me.tabPageQuestTexte = New System.Windows.Forms.TabPage()
      Me.gridQuestTexte = New System.Windows.Forms.DataGridView()
      Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.tabVocabulary = New System.Windows.Forms.TabPage()
      Me.gridVocabulary = New System.Windows.Forms.DataGridView()
      Me.key = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.value = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.txtEnglish = New System.Windows.Forms.TextBox()
      Me.txtForeignLanguage = New System.Windows.Forms.TextBox()
      Me.txtWordList = New System.Windows.Forms.TextBox()
      CType(Me.gridTexte, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TblStandardTexteDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.sbStatus.SuspendLayout()
      CType(Me.DsTexte, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabTexte.SuspendLayout()
      Me.tabPageStandardtexte.SuspendLayout()
      Me.tabPageQuestTexte.SuspendLayout()
      CType(Me.gridQuestTexte, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabVocabulary.SuspendLayout()
      CType(Me.gridVocabulary, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'gridTexte
      '
      Me.gridTexte.AllowUserToAddRows = False
      Me.gridTexte.AllowUserToDeleteRows = False
      Me.gridTexte.AutoGenerateColumns = False
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.gridTexte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
      Me.gridTexte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.gridTexte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeyDataGridViewTextBoxColumn, Me.SourceDataGridViewTextBoxColumn, Me.ContextDataGridViewTextBoxColumn, Me.ChangesDataGridViewTextBoxColumn, Me.EnglishDataGridViewTextBoxColumn, Me.FrenchDataGridViewTextBoxColumn, Me.GermanDataGridViewTextBoxColumn, Me.KlingonDataGridViewTextBoxColumn, Me.SpanishDataGridViewTextBoxColumn, Me.PolishDataGridViewTextBoxColumn})
      Me.gridTexte.DataSource = Me.TblStandardTexteDataTableBindingSource
      Me.gridTexte.Dock = System.Windows.Forms.DockStyle.Fill
      Me.gridTexte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
      Me.gridTexte.Location = New System.Drawing.Point(3, 3)
      Me.gridTexte.Name = "gridTexte"
      Me.gridTexte.Size = New System.Drawing.Size(1368, 620)
      Me.gridTexte.TabIndex = 0
      '
      'KeyDataGridViewTextBoxColumn
      '
      Me.KeyDataGridViewTextBoxColumn.DataPropertyName = "Key"
      Me.KeyDataGridViewTextBoxColumn.HeaderText = "Key"
      Me.KeyDataGridViewTextBoxColumn.Name = "KeyDataGridViewTextBoxColumn"
      '
      'SourceDataGridViewTextBoxColumn
      '
      Me.SourceDataGridViewTextBoxColumn.DataPropertyName = "Source"
      Me.SourceDataGridViewTextBoxColumn.HeaderText = "Source"
      Me.SourceDataGridViewTextBoxColumn.Name = "SourceDataGridViewTextBoxColumn"
      '
      'ContextDataGridViewTextBoxColumn
      '
      Me.ContextDataGridViewTextBoxColumn.DataPropertyName = "Context"
      Me.ContextDataGridViewTextBoxColumn.HeaderText = "Context"
      Me.ContextDataGridViewTextBoxColumn.Name = "ContextDataGridViewTextBoxColumn"
      '
      'ChangesDataGridViewTextBoxColumn
      '
      Me.ChangesDataGridViewTextBoxColumn.DataPropertyName = "Changes"
      Me.ChangesDataGridViewTextBoxColumn.HeaderText = "Changes"
      Me.ChangesDataGridViewTextBoxColumn.Name = "ChangesDataGridViewTextBoxColumn"
      '
      'EnglishDataGridViewTextBoxColumn
      '
      Me.EnglishDataGridViewTextBoxColumn.DataPropertyName = "English"
      Me.EnglishDataGridViewTextBoxColumn.HeaderText = "English"
      Me.EnglishDataGridViewTextBoxColumn.Name = "EnglishDataGridViewTextBoxColumn"
      Me.EnglishDataGridViewTextBoxColumn.Width = 300
      '
      'FrenchDataGridViewTextBoxColumn
      '
      Me.FrenchDataGridViewTextBoxColumn.DataPropertyName = "French"
      Me.FrenchDataGridViewTextBoxColumn.HeaderText = "French"
      Me.FrenchDataGridViewTextBoxColumn.Name = "FrenchDataGridViewTextBoxColumn"
      Me.FrenchDataGridViewTextBoxColumn.Visible = False
      '
      'GermanDataGridViewTextBoxColumn
      '
      Me.GermanDataGridViewTextBoxColumn.DataPropertyName = "German"
      Me.GermanDataGridViewTextBoxColumn.HeaderText = "German"
      Me.GermanDataGridViewTextBoxColumn.Name = "GermanDataGridViewTextBoxColumn"
      Me.GermanDataGridViewTextBoxColumn.Width = 500
      '
      'KlingonDataGridViewTextBoxColumn
      '
      Me.KlingonDataGridViewTextBoxColumn.DataPropertyName = "Klingon"
      Me.KlingonDataGridViewTextBoxColumn.HeaderText = "Klingon"
      Me.KlingonDataGridViewTextBoxColumn.Name = "KlingonDataGridViewTextBoxColumn"
      Me.KlingonDataGridViewTextBoxColumn.Visible = False
      '
      'SpanishDataGridViewTextBoxColumn
      '
      Me.SpanishDataGridViewTextBoxColumn.DataPropertyName = "Spanish"
      Me.SpanishDataGridViewTextBoxColumn.HeaderText = "Spanish"
      Me.SpanishDataGridViewTextBoxColumn.Name = "SpanishDataGridViewTextBoxColumn"
      Me.SpanishDataGridViewTextBoxColumn.Visible = False
      '
      'PolishDataGridViewTextBoxColumn
      '
      Me.PolishDataGridViewTextBoxColumn.DataPropertyName = "Polish"
      Me.PolishDataGridViewTextBoxColumn.HeaderText = "Polish"
      Me.PolishDataGridViewTextBoxColumn.Name = "PolishDataGridViewTextBoxColumn"
      Me.PolishDataGridViewTextBoxColumn.Visible = False
      '
      'TblStandardTexteDataTableBindingSource
      '
      Me.TblStandardTexteDataTableBindingSource.DataSource = GetType(Translator.dsTexte.tblStandardTexteDataTable)
      '
      'cbSource
      '
      Me.cbSource.FormattingEnabled = True
      Me.cbSource.Location = New System.Drawing.Point(408, 35)
      Me.cbSource.Name = "cbSource"
      Me.cbSource.Size = New System.Drawing.Size(171, 21)
      Me.cbSource.TabIndex = 2
      '
      'lblSource
      '
      Me.lblSource.AutoSize = True
      Me.lblSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSource.Location = New System.Drawing.Point(355, 38)
      Me.lblSource.Name = "lblSource"
      Me.lblSource.Size = New System.Drawing.Size(47, 13)
      Me.lblSource.TabIndex = 3
      Me.lblSource.Text = "Source"
      '
      'txtSuchbegriff
      '
      Me.txtSuchbegriff.Location = New System.Drawing.Point(408, 10)
      Me.txtSuchbegriff.Name = "txtSuchbegriff"
      Me.txtSuchbegriff.Size = New System.Drawing.Size(148, 20)
      Me.txtSuchbegriff.TabIndex = 4
      '
      'btnSucheStarten
      '
      Me.btnSucheStarten.Image = Global.Translator.My.Resources.Resources.Lupe
      Me.btnSucheStarten.Location = New System.Drawing.Point(555, 9)
      Me.btnSucheStarten.Name = "btnSucheStarten"
      Me.btnSucheStarten.Size = New System.Drawing.Size(24, 22)
      Me.btnSucheStarten.TabIndex = 5
      Me.btnSucheStarten.UseVisualStyleBackColor = True
      '
      'btnTexteLaden
      '
      Me.btnTexteLaden.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTexteLaden.Location = New System.Drawing.Point(4, 12)
      Me.btnTexteLaden.Name = "btnTexteLaden"
      Me.btnTexteLaden.Size = New System.Drawing.Size(124, 43)
      Me.btnTexteLaden.TabIndex = 6
      Me.btnTexteLaden.Text = "Texte laden"
      Me.btnTexteLaden.UseVisualStyleBackColor = True
      '
      'sbStatus
      '
      Me.sbStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatustext, Me.lblDauer})
      Me.sbStatus.Location = New System.Drawing.Point(0, 790)
      Me.sbStatus.Name = "sbStatus"
      Me.sbStatus.Size = New System.Drawing.Size(1382, 22)
      Me.sbStatus.TabIndex = 7
      Me.sbStatus.Text = "StatusStrip1"
      '
      'lblStatustext
      '
      Me.lblStatustext.Name = "lblStatustext"
      Me.lblStatustext.Size = New System.Drawing.Size(0, 17)
      '
      'lblDauer
      '
      Me.lblDauer.Name = "lblDauer"
      Me.lblDauer.Size = New System.Drawing.Size(0, 17)
      '
      'DsTexte
      '
      Me.DsTexte.DataSetName = "dsTexte"
      Me.DsTexte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'tabTexte
      '
      Me.tabTexte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.tabTexte.Controls.Add(Me.tabPageStandardtexte)
      Me.tabTexte.Controls.Add(Me.tabPageQuestTexte)
      Me.tabTexte.Controls.Add(Me.tabVocabulary)
      Me.tabTexte.Location = New System.Drawing.Point(0, 135)
      Me.tabTexte.Name = "tabTexte"
      Me.tabTexte.SelectedIndex = 0
      Me.tabTexte.Size = New System.Drawing.Size(1382, 652)
      Me.tabTexte.TabIndex = 8
      '
      'tabPageStandardtexte
      '
      Me.tabPageStandardtexte.Controls.Add(Me.gridTexte)
      Me.tabPageStandardtexte.Location = New System.Drawing.Point(4, 22)
      Me.tabPageStandardtexte.Name = "tabPageStandardtexte"
      Me.tabPageStandardtexte.Padding = New System.Windows.Forms.Padding(3)
      Me.tabPageStandardtexte.Size = New System.Drawing.Size(1374, 626)
      Me.tabPageStandardtexte.TabIndex = 0
      Me.tabPageStandardtexte.Text = "Standardtexte"
      Me.tabPageStandardtexte.UseVisualStyleBackColor = True
      '
      'tabPageQuestTexte
      '
      Me.tabPageQuestTexte.Controls.Add(Me.gridQuestTexte)
      Me.tabPageQuestTexte.Location = New System.Drawing.Point(4, 22)
      Me.tabPageQuestTexte.Name = "tabPageQuestTexte"
      Me.tabPageQuestTexte.Padding = New System.Windows.Forms.Padding(3)
      Me.tabPageQuestTexte.Size = New System.Drawing.Size(1374, 626)
      Me.tabPageQuestTexte.TabIndex = 1
      Me.tabPageQuestTexte.Text = "Quest-Texte"
      Me.tabPageQuestTexte.UseVisualStyleBackColor = True
      '
      'gridQuestTexte
      '
      Me.gridQuestTexte.AllowUserToAddRows = False
      Me.gridQuestTexte.AllowUserToDeleteRows = False
      Me.gridQuestTexte.AutoGenerateColumns = False
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.gridQuestTexte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
      Me.gridQuestTexte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.gridQuestTexte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
      Me.gridQuestTexte.DataSource = Me.TblStandardTexteDataTableBindingSource
      Me.gridQuestTexte.Dock = System.Windows.Forms.DockStyle.Fill
      Me.gridQuestTexte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
      Me.gridQuestTexte.Location = New System.Drawing.Point(3, 3)
      Me.gridQuestTexte.Name = "gridQuestTexte"
      Me.gridQuestTexte.Size = New System.Drawing.Size(1368, 620)
      Me.gridQuestTexte.TabIndex = 1
      '
      'DataGridViewTextBoxColumn1
      '
      Me.DataGridViewTextBoxColumn1.DataPropertyName = "Key"
      Me.DataGridViewTextBoxColumn1.HeaderText = "Key"
      Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
      '
      'DataGridViewTextBoxColumn2
      '
      Me.DataGridViewTextBoxColumn2.DataPropertyName = "Source"
      Me.DataGridViewTextBoxColumn2.HeaderText = "Source"
      Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
      '
      'DataGridViewTextBoxColumn3
      '
      Me.DataGridViewTextBoxColumn3.DataPropertyName = "Context"
      Me.DataGridViewTextBoxColumn3.HeaderText = "Context"
      Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
      '
      'DataGridViewTextBoxColumn4
      '
      Me.DataGridViewTextBoxColumn4.DataPropertyName = "Changes"
      Me.DataGridViewTextBoxColumn4.HeaderText = "Changes"
      Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
      '
      'DataGridViewTextBoxColumn5
      '
      Me.DataGridViewTextBoxColumn5.DataPropertyName = "English"
      Me.DataGridViewTextBoxColumn5.HeaderText = "English"
      Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
      Me.DataGridViewTextBoxColumn5.Width = 300
      '
      'DataGridViewTextBoxColumn6
      '
      Me.DataGridViewTextBoxColumn6.DataPropertyName = "French"
      Me.DataGridViewTextBoxColumn6.HeaderText = "French"
      Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
      Me.DataGridViewTextBoxColumn6.Visible = False
      '
      'DataGridViewTextBoxColumn7
      '
      Me.DataGridViewTextBoxColumn7.DataPropertyName = "German"
      Me.DataGridViewTextBoxColumn7.HeaderText = "German"
      Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
      Me.DataGridViewTextBoxColumn7.Width = 500
      '
      'DataGridViewTextBoxColumn8
      '
      Me.DataGridViewTextBoxColumn8.DataPropertyName = "Klingon"
      Me.DataGridViewTextBoxColumn8.HeaderText = "Klingon"
      Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
      Me.DataGridViewTextBoxColumn8.Visible = False
      '
      'DataGridViewTextBoxColumn9
      '
      Me.DataGridViewTextBoxColumn9.DataPropertyName = "Spanish"
      Me.DataGridViewTextBoxColumn9.HeaderText = "Spanish"
      Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
      Me.DataGridViewTextBoxColumn9.Visible = False
      '
      'DataGridViewTextBoxColumn10
      '
      Me.DataGridViewTextBoxColumn10.DataPropertyName = "Polish"
      Me.DataGridViewTextBoxColumn10.HeaderText = "Polish"
      Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
      Me.DataGridViewTextBoxColumn10.Visible = False
      '
      'tabVocabulary
      '
      Me.tabVocabulary.Controls.Add(Me.gridVocabulary)
      Me.tabVocabulary.Location = New System.Drawing.Point(4, 22)
      Me.tabVocabulary.Name = "tabVocabulary"
      Me.tabVocabulary.Padding = New System.Windows.Forms.Padding(3)
      Me.tabVocabulary.Size = New System.Drawing.Size(1374, 626)
      Me.tabVocabulary.TabIndex = 2
      Me.tabVocabulary.Text = "Vokabular"
      Me.tabVocabulary.UseVisualStyleBackColor = True
      '
      'gridVocabulary
      '
      Me.gridVocabulary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.gridVocabulary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.key, Me.value})
      Me.gridVocabulary.Dock = System.Windows.Forms.DockStyle.Fill
      Me.gridVocabulary.Location = New System.Drawing.Point(3, 3)
      Me.gridVocabulary.Name = "gridVocabulary"
      Me.gridVocabulary.Size = New System.Drawing.Size(1368, 620)
      Me.gridVocabulary.TabIndex = 0
      '
      'key
      '
      Me.key.HeaderText = "key"
      Me.key.Name = "key"
      Me.key.Width = 200
      '
      'value
      '
      Me.value.HeaderText = "value"
      Me.value.Name = "value"
      Me.value.Width = 800
      '
      'txtEnglish
      '
      Me.txtEnglish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEnglish.Location = New System.Drawing.Point(130, 61)
      Me.txtEnglish.Multiline = True
      Me.txtEnglish.Name = "txtEnglish"
      Me.txtEnglish.Size = New System.Drawing.Size(598, 74)
      Me.txtEnglish.TabIndex = 9
      '
      'txtForeignLanguage
      '
      Me.txtForeignLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtForeignLanguage.Location = New System.Drawing.Point(734, 61)
      Me.txtForeignLanguage.Multiline = True
      Me.txtForeignLanguage.Name = "txtForeignLanguage"
      Me.txtForeignLanguage.Size = New System.Drawing.Size(598, 74)
      Me.txtForeignLanguage.TabIndex = 10
      '
      'txtWordList
      '
      Me.txtWordList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtWordList.Location = New System.Drawing.Point(734, 8)
      Me.txtWordList.Multiline = True
      Me.txtWordList.Name = "txtWordList"
      Me.txtWordList.Size = New System.Drawing.Size(598, 48)
      Me.txtWordList.TabIndex = 11
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1382, 812)
      Me.Controls.Add(Me.txtWordList)
      Me.Controls.Add(Me.txtForeignLanguage)
      Me.Controls.Add(Me.txtEnglish)
      Me.Controls.Add(Me.tabTexte)
      Me.Controls.Add(Me.sbStatus)
      Me.Controls.Add(Me.btnTexteLaden)
      Me.Controls.Add(Me.btnSucheStarten)
      Me.Controls.Add(Me.txtSuchbegriff)
      Me.Controls.Add(Me.lblSource)
      Me.Controls.Add(Me.cbSource)
      Me.Name = "Form1"
      Me.Text = "7 Days To Die Translator"
      CType(Me.gridTexte, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TblStandardTexteDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.sbStatus.ResumeLayout(False)
      Me.sbStatus.PerformLayout()
      CType(Me.DsTexte, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabTexte.ResumeLayout(False)
      Me.tabPageStandardtexte.ResumeLayout(False)
      Me.tabPageQuestTexte.ResumeLayout(False)
      CType(Me.gridQuestTexte, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabVocabulary.ResumeLayout(False)
      CType(Me.gridVocabulary, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents gridTexte As DataGridView
   Friend WithEvents cbSource As ComboBox
   Friend WithEvents lblSource As Label
   Friend WithEvents txtSuchbegriff As TextBox
   Friend WithEvents btnSucheStarten As Button
   Friend WithEvents btnTexteLaden As Button
   Friend WithEvents sbStatus As StatusStrip
   Friend WithEvents lblStatustext As ToolStripStatusLabel
   Friend WithEvents lblDauer As ToolStripStatusLabel
   Friend WithEvents KeyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents SourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents ContextDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents ChangesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents EnglishDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents FrenchDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents GermanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents KlingonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents SpanishDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents PolishDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents TblStandardTexteDataTableBindingSource As BindingSource
   Friend WithEvents DsTexte As dsTexte
   Friend WithEvents tabTexte As TabControl
   Friend WithEvents tabPageStandardtexte As TabPage
   Friend WithEvents tabPageQuestTexte As TabPage
   Friend WithEvents gridQuestTexte As DataGridView
   Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents txtForeignLanguage As TextBox
   Friend WithEvents tabVocabulary As TabPage
   Friend WithEvents gridVocabulary As DataGridView
   Friend WithEvents key As DataGridViewTextBoxColumn
   Friend WithEvents value As DataGridViewTextBoxColumn
   Friend WithEvents txtWordList As TextBox
End Class
