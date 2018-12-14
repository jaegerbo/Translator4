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
      Return clsTextDataManager.listToString(_list)
   End Function

End Class
