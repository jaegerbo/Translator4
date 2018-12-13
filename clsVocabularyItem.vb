Public Class clsVocabularyItem

   Private _key As String
   Public Property key() As String
      Get
         Return _key
      End Get
      Set(ByVal value As String)
         _key = value
      End Set
   End Property

   Private _list As New ArrayList
   Public Property list() As ArrayList
      Get
         Return _list
      End Get
      Set(ByVal value As ArrayList)
         _list = value
      End Set
   End Property

   Public Overrides Function ToString() As String
      Dim Sb As New Text.StringBuilder
      For Each item As String In _list
         If Sb.ToString Is Nothing Then
            Sb.Append(item)
         Else
            Sb.Append(", ")
            Sb.Append(item)
         End If
      Next
      Return $"{_key}: {Sb.ToString}"
   End Function

End Class
