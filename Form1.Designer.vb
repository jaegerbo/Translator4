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
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.gridTexte = New System.Windows.Forms.DataGridView()
      Me.lblStatus = New System.Windows.Forms.Label()
      Me.cbSource = New System.Windows.Forms.ComboBox()
      Me.lblSource = New System.Windows.Forms.Label()
      Me.txtSuchbegriff = New System.Windows.Forms.TextBox()
      Me.btnSucheStarten = New System.Windows.Forms.Button()
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
      Me.ClsTextRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      CType(Me.gridTexte, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ClsTextRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'gridTexte
      '
      Me.gridTexte.AllowUserToAddRows = False
      Me.gridTexte.AllowUserToDeleteRows = False
      Me.gridTexte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.gridTexte.AutoGenerateColumns = False
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.gridTexte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
      Me.gridTexte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.gridTexte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeyDataGridViewTextBoxColumn, Me.SourceDataGridViewTextBoxColumn, Me.ContextDataGridViewTextBoxColumn, Me.ChangesDataGridViewTextBoxColumn, Me.EnglishDataGridViewTextBoxColumn, Me.FrenchDataGridViewTextBoxColumn, Me.GermanDataGridViewTextBoxColumn, Me.KlingonDataGridViewTextBoxColumn, Me.SpanishDataGridViewTextBoxColumn, Me.PolishDataGridViewTextBoxColumn})
      Me.gridTexte.DataSource = Me.ClsTextRecordBindingSource
      Me.gridTexte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
      Me.gridTexte.Location = New System.Drawing.Point(2, 62)
      Me.gridTexte.Name = "gridTexte"
      Me.gridTexte.Size = New System.Drawing.Size(1445, 750)
      Me.gridTexte.TabIndex = 0
      '
      'lblStatus
      '
      Me.lblStatus.AutoSize = True
      Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblStatus.Location = New System.Drawing.Point(789, 13)
      Me.lblStatus.Name = "lblStatus"
      Me.lblStatus.Size = New System.Drawing.Size(45, 13)
      Me.lblStatus.TabIndex = 1
      Me.lblStatus.Text = "Label1"
      '
      'cbSource
      '
      Me.cbSource.FormattingEnabled = True
      Me.cbSource.Location = New System.Drawing.Point(65, 10)
      Me.cbSource.Name = "cbSource"
      Me.cbSource.Size = New System.Drawing.Size(178, 21)
      Me.cbSource.TabIndex = 2
      '
      'lblSource
      '
      Me.lblSource.AutoSize = True
      Me.lblSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSource.Location = New System.Drawing.Point(12, 13)
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
      'KeyDataGridViewTextBoxColumn
      '
      Me.KeyDataGridViewTextBoxColumn.DataPropertyName = "Key"
      DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.KeyDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
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
      Me.EnglishDataGridViewTextBoxColumn.Width = 500
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
      'ClsTextRecordBindingSource
      '
      Me.ClsTextRecordBindingSource.DataSource = GetType(Translator.clsTextRecord)
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1448, 812)
      Me.Controls.Add(Me.btnSucheStarten)
      Me.Controls.Add(Me.txtSuchbegriff)
      Me.Controls.Add(Me.lblSource)
      Me.Controls.Add(Me.cbSource)
      Me.Controls.Add(Me.lblStatus)
      Me.Controls.Add(Me.gridTexte)
      Me.Name = "Form1"
      Me.Text = "Form1"
      CType(Me.gridTexte, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ClsTextRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents gridTexte As DataGridView
   Friend WithEvents ClsTextRecordBindingSource As BindingSource
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
   Friend WithEvents lblStatus As Label
   Friend WithEvents cbSource As ComboBox
   Friend WithEvents lblSource As Label
   Friend WithEvents txtSuchbegriff As TextBox
   Friend WithEvents btnSucheStarten As Button
End Class
