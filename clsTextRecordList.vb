Public Class clsTextRecordList
   Inherits Generic.List(Of clsTextRecord)

   Public Sub read()
      ' Zweck:    speichern
      Try
         Dim Fi As New IO.FileInfo("Localization.txt")
         If Fi.Exists = False Then
            MsgBox("Die Datei Localization.txt wurde nicht gefunden")
            Exit Sub
         End If

         Using fs As IO.StreamReader = Fi.OpenText

            While Not fs.EndOfStream
               Dim Zeile As String = fs.ReadLine
               Dim TextArray As String() = Zeile.Split(CChar(","))

               ' Key,Source,Context,Changes,English,French,German,Klingon,Spanish,Polish
               Dim Record As New clsTextRecord With {
                  .Key = TextArray(0),
                  .Source = TextArray(1),
                  .Context = TextArray(2),
                  .Changes = TextArray(3),
                  .English = TextArray(4),
                  .French = TextArray(5),
                  .German = TextArray(6),
                  .Klingon = TextArray(7),
                  .Spanish = TextArray(8),
                  .Polish = TextArray(9)
               }
               Me.Add(Record)
            End While

            fs.Close()
         End Using
      Catch ex As Exception
         Stop
      End Try
   End Sub

   Public Sub write()
      Try
         Dim Fi As New IO.FileInfo("Localization.txt")

         Using sw As IO.StreamWriter = Fi.CreateText()
            For Each Record As clsTextRecord In Me
               sw.WriteLine($"{Record.Key},{Record.Source},{Record.Context},{Record.Changes},{Record.English},{Record.French},{Record.German},{Record.Klingon},{Record.Spanish},{Record.Polish}")
            Next

            sw.Close()
         End Using
      Catch ex As Exception
         Stop
      End Try
   End Sub

End Class
