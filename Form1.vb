﻿Imports System.ComponentModel
Imports System.Text
Imports System.Net

Public Class Form1

   Private _countVisibleRows As Integer = 0
   Private _Stopwatch As New Stopwatch
   Private _viewTexte As New DataView
   Private _viewQuestTexte As New DataView
   Private _DataManager As New clsTextDataManager
   Private _ChangeEventActive As Boolean = True

   Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
      ' Zweck:    Formular schließen und alles speichern
      _DataManager.saveTexte()
   End Sub

   Private Sub gridTexte_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles gridTexte.CellValueChanged
      showStatistik()
   End Sub
   Private Sub gridTexte_SelectionChanged(sender As Object, e As EventArgs) Handles gridTexte.SelectionChanged
      ' Zweck:    Die Sprachen in extra Textboxen zur Verfügung stellen
      Try
         _ChangeEventActive = False

         If gridTexte.CurrentRow Is Nothing Then
            txtEnglish.Text = Nothing
            txtForeignLanguage.Text = Nothing
         Else
            txtEnglish.Text = gridTexte.CurrentRow.Cells(4).Value
            txtForeignLanguage.Text = gridTexte.CurrentRow.Cells(6).Value

            ' Eine Liste möglicher Übersetzungen anzeigen
            Dim vocabulatyList As ArrayList = _DataManager.getTempVocabulary(txtEnglish.Text)
            If vocabulatyList.Count > 0 Then
               txtWordList.Text = clsTextDataManager.listToString(vocabulatyList)
            End If

         End If
      Catch ex As Exception
         Stop
      Finally
         _ChangeEventActive = True
      End Try
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
      ' Zweck:    Änderungen im Textfeld in den Datensatz übernehmen
      Try
         If _ChangeEventActive = False Then Exit Sub
         If gridTexte.CurrentCell Is Nothing OrElse txtForeignLanguage.Text Is Nothing OrElse txtForeignLanguage.Text = String.Empty Then Exit Sub

         Dim vocabulatyList As ArrayList = _DataManager.getTempVocabulary(txtEnglish.Text)
         If vocabulatyList.Count > 0 Then

            Dim testResult As clsTestForTokenResult = testForToken(txtForeignLanguage.Text, vocabulatyList)
            If testResult.tokenFound = True Then
               txtForeignLanguage.Text = testResult.text
               txtForeignLanguage.SelectionStart = testResult.selectionStart
               txtForeignLanguage.SelectionLength = testResult.selectionLength
            End If

         End If


         gridTexte.Rows(gridTexte.CurrentCell.RowIndex).Cells(6).Value = txtForeignLanguage.Text
      Catch ex As Exception
         Stop
      End Try
   End Sub
   Private Function testForToken(text As String, tokenList As ArrayList) As clsTestForTokenResult
      ' Zweck:    prüfen, ob Token aus der gegebenen Liste im gegebenen Text vorkommen
      Dim result As New clsTestForTokenResult With {.text = text}
      Try
         ' Aus dem Text das letzte Wort ermitteln
         Dim TextArray() As String = text.Split(" "c)
         Dim lastWord As String = TextArray(TextArray.Length - 1)

         ' Schleife über alle token
         For Each token As String In tokenList

            If token.StartsWith(lastWord) = True Then
               result.tokenFound = True
               result.selectionStart = text.Length
               result.selectionLength = token.Length
               result.text &= token
            End If

         Next
      Catch ex As Exception
         Stop
      End Try
      Return result
   End Function

   Private Sub btnGoogle_Click(sender As Object, e As EventArgs) Handles btnGoogle.Click
      ' Zweck:    den zu übersetzenden Text an den Google Übersetzer weiterleiten
      Try
         Dim Prozess As ProcessStartInfo

         ' WOOD Berechtigungen als extra Programm starten
         Prozess = New ProcessStartInfo With {.FileName = $"https://translate.google.com/?hl=de#view=home&op=translate&sl=en&tl=de&text={Web.HttpUtility.UrlEncode(txtEnglish.Text)}"}
         'Prozess.Arguments = Parameter
         Prozess.UseShellExecute = True
         'Prozess.WindowStyle = WindowStyle
         Process.Start(Prozess)

         'Dim request As WebRequest = WebRequest.Create("https://translate.google.com/?hl=de#view=home&op=translate&sl=de&tl=en&text=Testtext")
         'request.Credentials = CredentialCache.DefaultCredentials
         'Using response As WebResponse = request.GetResponse()
         '   Dim dataStream As IO.Stream = response.GetResponseStream()

         '   response.Close()
         'End Using

      Catch ex As Exception
         Stop
      End Try
   End Sub

End Class
