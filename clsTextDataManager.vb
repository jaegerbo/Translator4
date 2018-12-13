Public Class clsTextDataManager

   Private _ds As dsTexte = Nothing
   Public Property ds() As dsTexte
      Get
         If _ds Is Nothing Then
            _ds = getTexte()
         End If
         Return _ds
      End Get
      Set(ByVal value As dsTexte)
         _ds = value
      End Set
   End Property

   Private _SourceList As ArrayList = Nothing
   Public Property SourceList() As ArrayList
      Get
         If _SourceList Is Nothing Then
            _SourceList = getSourceList()
         End If
         Return _SourceList
      End Get
      Set(ByVal value As ArrayList)
         _SourceList = value
      End Set
   End Property

   Private _vocabularyHt As New clsVocabularyItemListHt
   Public Property vocabularyHt() As clsVocabularyItemListHt
      Get
         Return _vocabularyHt
      End Get
      Set(ByVal value As clsVocabularyItemListHt)
         _vocabularyHt = value
      End Set
   End Property

   Private Function getTexte() As dsTexte
      ' Zweck:    Alle Dateien einlesen
      Dim ds As New dsTexte
      Try
         ' Standardtexte
         Dim Fi As New IO.FileInfo("Localization.txt")
         If Fi.Exists = False Then
            MsgBox("Die Datei Localization.txt wurde nicht gefunden")
            Return ds
         End If

            Using fs As IO.StreamReader = Fi.OpenText()

                Dim isfirstRecord As Boolean = True

                While Not fs.EndOfStream
                    Dim Zeile As String = fs.ReadLine
                    Dim TextArray As String() = Zeile.Split(","c)

                    Dim row As dsTexte.tblStandardTexteRow = ds.tblStandardTexte.NewRow
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
               ds.tblStandardTexte.Rows.Add(row)

               fillVocabulary(row.English, row.German)
            End While

                fs.Close()
            End Using

            ' Questtexte
            Fi = New IO.FileInfo("Localization - Quest.txt")
         If Fi.Exists = False Then
            MsgBox("Die Datei Localization - Quest.txt wurde nicht gefunden")
            Return ds
         End If

         Using fs As IO.StreamReader = Fi.OpenText

            Dim isfirstRecord As Boolean = True

            While Not fs.EndOfStream
               Dim Zeile As String = fs.ReadLine
               Dim TextArray As String() = Zeile.Split(","c)

               Dim row As dsTexte.tblQuestTexteRow = ds.tblQuestTexte.NewRow
               row.Key = TextArray(0)
               row.Source = TextArray(1)
               row.Context = TextArray(2)
               row.Changes = TextArray(3)
               row.English = TextArray(4)
               row.French = TextArray(5)
               row.German = TextArray(6)
               row.Klingon = TextArray(7)
               row.Spanish = TextArray(8)
               ds.tblQuestTexte.Rows.Add(row)
            End While

            fs.Close()
         End Using
      Catch ex As Exception
         Stop
      End Try
      Return ds
   End Function
   Public Sub saveTexte()
      Try
         ' Standardtexte
         Dim Fi As New IO.FileInfo("Localization.txt")

         Using sw As IO.StreamWriter = Fi.CreateText()

            For Each row As dsTexte.tblStandardTexteRow In ds.tblStandardTexte.Rows
               sw.WriteLine($"{row.Key},{row.Source},{row.Context},{row.Changes},{row.English},{row.French},{row.German},{row.Klingon},{row.Spanish},{row.Polish}")
            Next

            sw.Close()
         End Using

         ' Questtexte
         Fi = New IO.FileInfo("Localization - Quest.txt")

         Using sw As IO.StreamWriter = Fi.CreateText()

            For Each row As dsTexte.tblStandardTexteRow In ds.tblStandardTexte.Rows
               sw.WriteLine($"{row.Key},{row.Source},{row.Context},{row.Changes},{row.English},{row.French},{row.German},{row.Klingon},{row.Spanish}")
            Next

            sw.Close()
         End Using
      Catch ex As Exception
         Stop
      End Try
   End Sub

   Private Function getSourceList() As ArrayList
      Dim Liste As New ArrayList
      Try
         Dim isFirstRecord As Boolean = True

         For Each row As dsTexte.tblStandardTexteRow In _ds.tblStandardTexte.Rows

            ' den ersten Datensatz überspringen
            If isFirstRecord = True Then
               isFirstRecord = False

               Liste.Add("all")

            Else
               If Liste.Contains(row.Source) = False Then
                  Liste.Add(row.Source)
               End If
            End If

         Next
      Catch ex As Exception
         Stop
      End Try
      Return Liste
   End Function

   Private Sub fillVocabulary(englishText As String, foreignText As String)
      ' Zweck:    Der englische Text wird gesplittet, und für jedes Wort, das mindestens 3 Buchstaben hat wird ein Eintrag im Vokabular erstellt.
      '           Zu diesem Wort werden alle fremdsprachlichen Wörter in eine Liste geschrieben.
      Try
         Dim englishWords() As String = englishText.Split(" "c)
         Dim foreignWords() As String = foreignText.Split(" "c)

         For Each englishWord As String In englishWords

            ' prüfen, ob es für das Wort schon einen Eintrag im Vokabular gibt
            If _vocabularyHt.ContainsKey(englishWord) = True Then

               ' die Liste der fremdsprachlichen Texte ggf erweitern
               Dim oldForeignWordsList As ArrayList = _vocabularyHt.Item(englishWord)

               ' jedes neue fremdsprachliche Wort überprüfen, ob es schon in der Liste ist
               For Each foreignWord As String In foreignWords
                  If oldForeignWordsList.Contains(foreignWord) = False Then
                     oldForeignWordsList.Add(foreignWord)
                  End If
               Next

               ' die erweiterte Liste im Vokabular speichern
               _vocabularyHt.Item(englishWord) = oldForeignWordsList

            Else

               ' einen neuen Eintrag im Vokabular anlegen.
               ' Als Key wird das englische Wort verwendet, und als Value die Liste der zugehörigen fremdsprachlichen Wörter

               ' den fremdsprachlichen Text in eine Liste umwandeln
               Dim foreignWordsList As New ArrayList
               For Each foreignWord As String In foreignWords
                  foreignWordsList.Add(foreignWord)
               Next

               _vocabularyHt.Add(englishWord, foreignWordsList)
            End If

         Next
      Catch ex As Exception
         Stop
      End Try
   End Sub

End Class
