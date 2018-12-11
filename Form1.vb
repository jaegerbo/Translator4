Imports System.ComponentModel

Public Class Form1

   Private _countVisibleRows As Integer = 0
   Private _Stopwatch As New Stopwatch
   Private _viewTexte As New DataView
   Private _viewQuestTexte As New DataView
   Private _DataManager As New clsTextDataManager

   Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
      _DataManager.saveTexte()
   End Sub

   Private Sub gridTexte_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles gridTexte.CellValueChanged
      showStatistik()
   End Sub

   Private Sub showStatistik()
      ' Zweck:    Statusinformationen ermitteln und schreiben
      Try
         If _DataManager.ds Is Nothing Then Exit Sub

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

         _Stopwatch.Stop()
         showStatistik()
      Catch ex As Exception
         Stop
      Finally
         Cursor = Cursors.Default
      End Try
   End Sub

End Class
