Imports System.ComponentModel

Public Class Form1

   Private _Texte As clsTextRecordList

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Try

         _Texte = New clsTextRecordList
         _Texte.read()

         If _Texte IsNot Nothing Then
            gridTexte.DataSource = _Texte
         End If

      Catch ex As Exception
         Stop
      End Try
   End Sub
   Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
      Try
         _Texte.write()
      Catch ex As Exception
         Stop
      End Try
   End Sub

End Class
