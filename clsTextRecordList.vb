Public Class clsTextRecordList
   Inherits Generic.List(Of clsTextRecord)

   Private _SourceList As ArrayList = Nothing
   Public Property SourceList() As ArrayList
      Get
         Dim isFirstRecord As Boolean = True

         If _SourceList Is Nothing Then
            _SourceList = New ArrayList
            For Each Record As clsTextRecord In Me

               ' den ersten Datensatz überspringen
               If isFirstRecord = True Then
                  isFirstRecord = False

                  _SourceList.Add("all")

               Else
                  If _SourceList.Contains(Record.Source) = False Then
                     _SourceList.Add(Record.Source)
                  End If
               End If

            Next
         End If
         Return _SourceList
      End Get
      Set(ByVal value As ArrayList)
         _SourceList = value
      End Set
   End Property

   Private _ds As New dsTexte
   Public Property ds() As dsTexte
      Get
         Return _ds
      End Get
      Set(ByVal value As dsTexte)
         _ds = value
      End Set
   End Property

   Public Sub read()
      ' Zweck:    speichern
      Try
         Dim Fi As New IO.FileInfo("Localization.txt")
         If Fi.Exists = False Then
            MsgBox("Die Datei Localization.txt wurde nicht gefunden")
            Exit Sub
         End If

         Using fs As IO.StreamReader = Fi.OpenText

            Dim isfirstRecord As Boolean = True

            While Not fs.EndOfStream
               Dim Zeile As String = fs.ReadLine
               Dim TextArray As String() = Zeile.Split(CChar(","))

               Dim row As dsTexte.tblStandardTexteRow = _ds.tblStandardTexte.NewRow
               row.Key = TextArray(0)
               row.Source = TextArray(1)
               row.Context = TextArray(2)
               row.Changes = TextArray(3)
               row.English = TextArray(4)
               row.French = TextArray(5)
               row.German = TextArray(6)
               row.Klingon = TextArray(7)
               row.Spanish = TextArray(8)
               row.Polish = TextArray(9)
               _ds.tblStandardTexte.Rows.Add(row)

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

            For Each row As dsTexte.tblStandardTexteRow In _ds.tblStandardTexte.Rows
               sw.WriteLine($"{row.Key},{row.Source},{row.Context},{row.Changes},{row.English},{row.French},{row.German},{row.Klingon},{row.Spanish},{row.Polish}")
            Next

            sw.Close()
         End Using
      Catch ex As Exception
         Stop
      End Try
   End Sub

End Class
