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
               Dim list As ArrayList = createDatasetRow(Zeile)

               If list.Count > 0 Then
                  Dim row As dsTexte.tblStandardTexteRow = ds.tblStandardTexte.NewRow
                  Dim i As Integer = 0
                  For Each element As String In list
                     row(i) = list(i)
                     i += 1
                  Next
                  ds.tblStandardTexte.Rows.Add(row)

                  fillVocabulary(row.English, row.German)
               End If

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
               Dim list As ArrayList = createDatasetRow(Zeile)

               If list.Count > 0 Then
                  Dim row As dsTexte.tblQuestTexteRow = ds.tblQuestTexte.NewRow
                  Dim i As Integer = 0
                  For Each element As String In list
                     row(i) = list(i)
                     i += 1
                  Next
                  ds.tblStandardTexte.Rows.Add(row)

                  fillVocabulary(row.English, row.German)
               End If

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
               sw.WriteLine($"{row.Key},{row.Source},{row.Context},{row.Changes},{convertText(row.English)},{convertText(row.French)},{convertText(row.German)},{convertText(row.Klingon)},{convertText(row.Spanish)},{convertText(row.Polish)}")
            Next

            sw.Close()
         End Using

         ' Questtexte
         Fi = New IO.FileInfo("Localization - Quest.txt")

         Using sw As IO.StreamWriter = Fi.CreateText()

            For Each row As dsTexte.tblStandardTexteRow In ds.tblStandardTexte.Rows
               sw.WriteLine($"{row.Key},{row.Source},{row.Context},{row.Changes},{convertText(row.English)},{convertText(row.French)},{convertText(row.German)},{convertText(row.Klingon)},{convertText(row.Spanish)}")
            Next

            sw.Close()
         End Using
      Catch ex As Exception
         Stop
      End Try
   End Sub
   Private Function convertText(Text As String) As String
      ' Zweck:    Wenn der gegebene Text ein Komma enthält, wird er von Anführungszeichen umgeben
      Try
         If Text.Contains(",") = True Then
            Return """" & Text & """"
         End If
      Catch ex As Exception
         Stop
      End Try
      Return Text
   End Function

   Public Function createDatasetRow(Text As String) As ArrayList
      ' Zweck:    den gegebenen Text zerlegen, und in einen Datensatz umwandeln.
      '           Grundsätzlich sind die einzelnen Sprachen durch Komma getrennt. Sollte ein Eintrag selber ein Komma enthalten, steht der ganze Eintrag
      '           in Anführungszeichen
      Dim list As New ArrayList
      Try
         Dim ErsterText As String = Nothing
         Dim Resttext As String = Text
         Dim P As Integer = Resttext.IndexOf(","c)

         Do While Resttext <> String.Empty

            ' prüfen, ob der Resttext mit Anführungszeichen beginnt. Wenn ja, wird das erste und zweite Anführungszeichen entfernt.
            If Resttext.StartsWith("""") Then

               ' 1. Anführungszeichen entfernen
               Resttext = Resttext.Substring(1, Resttext.Length - 1)

               ' Text bis zum 2. Anführungszeichen ermitteln
               P = Resttext.IndexOf("""")
               If P > 0 Then
                  ErsterText = Resttext.Substring(0, P)
                  If Resttext.Length - P - 2 < 0 Then
                     Resttext = String.Empty
                  Else
                     Resttext = Resttext.Substring(P + 2, Resttext.Length - P - 2)
                  End If
               End If

            Else

               If P = -1 Then
                  ' Text ist am Ende
                  ErsterText = Resttext
                  Resttext = String.Empty
               Else
                  ErsterText = Resttext.Substring(0, P)
                  Resttext = Resttext.Substring(P + 1, Resttext.Length - P - 1)
               End If

            End If

            P = Resttext.IndexOf(","c)

            list.Add(ErsterText)
         Loop
      Catch ex As Exception
         Stop
      End Try
      Return list
   End Function

   Public Function getTempVocabulary(englishText As String) As ArrayList
      ' Zweck:    Für alle Wörter im gegebenen englischen Text die zugehörigen Vokabeleinträge ermitteln und zu einer Liste zusammenfassen
      Dim Liste As New ArrayList
      Try
         Dim englishWords() As String = englishText.Split(" "c)
         For Each englishWord As String In englishWords

            ' im Vokabular die zugehörige Vokabelliste ermitteln
            If _vocabularyHt.ContainsKey(englishWord) Then

               For Each foreignWord As String In _vocabularyHt.Item(englishWord)
                  Liste.Add(foreignWord)
               Next

            End If

         Next
      Catch ex As Exception
         Stop
      End Try
      Return Liste
   End Function

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

   ' öffentliche Methoden
   Public Shared Function listToString(list As ArrayList) As String
      ' Zweck:    Die gegebene Liste als String darstellen
      Dim Sb As New Text.StringBuilder
      Try
         For Each item As String In list
            If Sb.Length = 0 Then
               Sb.Append(item)
            Else
               Sb.Append(", ")
               Sb.Append(item)
            End If
         Next
      Catch ex As Exception
         Stop
      End Try
      Return Sb.ToString
   End Function

End Class
