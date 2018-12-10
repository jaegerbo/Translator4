Imports System.ComponentModel

Public Class Form1

   Private _Texte As clsTextRecordList
   Private _countVisibleRows As Integer = 0
   Private _Stopwatch As New Stopwatch
   Private _view As DataView

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Try
         _Stopwatch.Reset()
         _Stopwatch.Start()

         _Texte = New clsTextRecordList
         _Texte.read()

         If _Texte IsNot Nothing Then
            'gridTexte.DataSource = _Texte
            'gridTexte.DataSource = _Texte.ds.tblStandardTexte

            _view = New DataView(_Texte.ds.tblStandardTexte)
            gridTexte.DataSource = _view

            cbSource.DataSource = _Texte.SourceList

            _countVisibleRows = _Texte.Count

            showStatistik()
         End If

      Catch ex As Exception
         Stop
      Finally
         _Stopwatch.Stop()
      End Try
   End Sub
   Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
      _Texte.write()
   End Sub

   Private Sub gridTexte_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles gridTexte.CellValueChanged
      showStatistik()
   End Sub

   Private Sub showStatistik()
      Try
         If _Texte Is Nothing Then Exit Sub

         Dim countAll As Integer = 0
         Dim countGerman As Integer = 0

         For Each Record As clsTextRecord In _Texte
            countAll += 1

            If Record.German = String.Empty Then
               countGerman += 1
            End If
         Next

         lblStatus.Text = $"{countAll} Vokablen insgesamt. {countGerman} deutsche Vokalbeln nicht übersetzt. {_countVisibleRows} gefiltert. {_Stopwatch.ElapsedMilliseconds.ToString} msec"

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
            _view.RowFilter = Nothing
         Else
            _view.RowFilter = $"Source = '{cbSource.Text}'"
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
            _view.RowFilter = Nothing
         Else
            _view.RowFilter = $"Key Like '%{Suchbegriff}%' or Source Like '%{Suchbegriff}%' or Context Like '%{Suchbegriff}%' or Changes Like '%{Suchbegriff}%' or English Like '%{Suchbegriff}%' or German Like '%{Suchbegriff}%'"
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

End Class
