Imports System.ComponentModel
Imports System.Text

Public Class Form1

   Private _countVisibleRows As Integer = 0
   Private _Stopwatch As New Stopwatch
   Private _viewTexte As New DataView
   Private _viewQuestTexte As New DataView
   Private _DataManager As New clsTextDataManager

   Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
      ' Zweck:    Formular schließen und alles speichern
      _DataManager.saveTexte()
   End Sub

   Private Sub gridTexte_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles gridTexte.CellValueChanged
      showStatistik()
   End Sub

   Private Sub showStatistik()
      ' Zweck:    Statusinformationen ermitteln und schreiben
      Try
         If _DataManager.ds Is Nothing OrElse sbStatus.Items Is Nothing OrElse sbStatus.Items.Count = 0 Then Exit Sub

         Dim countAll As Integer = 0
         Dim countGerman As Integer = 0

         For Each row As dsTexte.tblStandardTexteRow In _DataManager.ds.tblStandardTexte.Rows
            countAll += 1

            If row.German = String.Empty Then
               countGerman += 1
            End If
         Next

         sbStatus.Items("lblStatustext").Text = $"{countAll} Vokablen insgesamt. {countGerman} deutsche Vokalbeln nicht übersetzt. {_countVisibleRows} gefiltert."
         sbStatus.Items("lblStatustext").Width = 300
         sbStatus.Items("lblDauer").Text = $"Dauer: {_Stopwatch.ElapsedMilliseconds.ToString} msec"

      Catch ex As Exception
         Stop
      End Try
   End Sub

   Private Sub cbSource_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbSource.SelectedValueChanged
      ' Zweck:    Auf Änderungen in der Combo reagieren
      Try
         _Stopwatch.Reset()
         _Stopwatch.Start()

         Cursor = Cursors.WaitCursor

         _countVisibleRows = 0

         If cbSource.Text = "all" Then
            _viewTexte.RowFilter = Nothing
         Else
            _viewTexte.RowFilter = $"Source = '{cbSource.Text}'"
         End If

         _Stopwatch.Stop()
         showStatistik()

      Catch ex As Exception
         Stop
      Finally
         Cursor = Cursors.Default
      End Try
   End Sub

   Private Sub btnSucheStarten_Click(sender As Object, e As EventArgs) Handles btnSucheStarten.Click
      ' Zweck:    Suche starten
      Try
         _Stopwatch.Reset()
         _Stopwatch.Start()

         Cursor = Cursors.WaitCursor

         Dim Suchbegriff As String = txtSuchbegriff.Text
         _countVisibleRows = 0

         If Suchbegriff = String.Empty Then
            _viewTexte.RowFilter = Nothing
         Else
            _viewTexte.RowFilter = $"Key Like '%{Suchbegriff}%' or Source Like '%{Suchbegriff}%' or Context Like '%{Suchbegriff}%' or Changes Like '%{Suchbegriff}%' or English Like '%{Suchbegriff}%' or German Like '%{Suchbegriff}%'"
         End If

         _Stopwatch.Stop()
         showStatistik()

      Catch ex As Exception
         Stop
      Finally
         Cursor = Cursors.Default
      End Try
   End Sub

   Private Sub txtSuchbegriff_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSuchbegriff.KeyUp
      If e.KeyCode = Keys.Enter Then
         btnSucheStarten_Click(Nothing, Nothing)
      End If
   End Sub

   Private Sub btnTexteLaden_Click(sender As Object, e As EventArgs) Handles btnTexteLaden.Click
      ' Zweck:    Daten laden
      Try
         _Stopwatch.Reset()
         _Stopwatch.Start()

         Cursor = Cursors.WaitCursor

         _viewTexte = New DataView(_DataManager.ds.tblStandardTexte)
         _viewQuestTexte = New DataView(_DataManager.ds.tblQuestTexte)

         gridTexte.DataSource = _viewTexte
         gridQuestTexte.DataSource = _viewQuestTexte

         cbSource.DataSource = _DataManager.SourceList

         gridVocabulary.DataSource = _DataManager.vocabularyHt

         _Stopwatch.Stop()
         showStatistik()
      Catch ex As Exception
         Stop
      Finally
         Cursor = Cursors.Default
      End Try
   End Sub

   Private Sub txtForeignLanguage_TextChanged(sender As Object, e As EventArgs) Handles txtForeignLanguage.TextChanged
      ' Zweck:    Änderungen im Textfeld in den daten satz übernehmen

      Try
         If gridTexte.CurrentCell Is Nothing OrElse txtForeignLanguage.Text Is Nothing OrElse txtForeignLanguage.Text = String.Empty Then Exit Sub

         Dim testResult As clsTestForTokenResult = testForToken(txtForeignLanguage.Text, "abc")
         If testResult.tokenFound = True Then
            txtForeignLanguage.Text = testResult.text
            txtForeignLanguage.SelectionStart = testResult.selectionStart
            txtForeignLanguage.SelectionLength = testResult.selectionLength
         End If


         'gridTexte.Rows(gridTexte.CurrentCell.RowIndex).Cells(6).Value = txtForeignLanguage.Text
      Catch ex As Exception
         Stop
      End Try
   End Sub
   Private Function testForToken(text As String, token As String) As clsTestForTokenResult
      ' Zweck:    prüfen, ob das gegebene Token im gegebenen Text vorkommt
      Dim result As New clsTestForTokenResult With {.text = text}
      Try
         Dim additionToken As String = "def"
         Dim TextArray() As String = text.Split(" "c)
         If TextArray(TextArray.Length - 1) = token Then
            result.tokenFound = True
            result.selectionStart = text.Length
            result.selectionLength = additionToken.Length
            result.text &= additionToken
         End If
      Catch ex As Exception
         Stop
      End Try
      Return result
   End Function

   Private Sub gridTexte_SelectionChanged(sender As Object, e As EventArgs) Handles gridTexte.SelectionChanged
      ' Zweck:    Die Sprachen in extra Textboxen zur Verfügung stellen
      Try
         If gridTexte.CurrentRow Is Nothing Then
            txtEnglish.Text = Nothing
            txtForeignLanguage.Text = Nothing
         Else
            txtEnglish.Text = gridTexte.CurrentRow.Cells(4).Value
            txtForeignLanguage.Text = gridTexte.CurrentRow.Cells(6).Value
         End If
      Catch ex As Exception
         Stop
      End Try
   End Sub

End Class
