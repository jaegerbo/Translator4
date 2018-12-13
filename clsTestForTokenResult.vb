Public Class clsTestForTokenResult

   Private _tokenFound As Boolean = False
   Public Property tokenFound() As Boolean
      Get
         Return _tokenFound
      End Get
      Set(ByVal value As Boolean)
         _tokenFound = value
      End Set
   End Property

   Private _text As String
   Public Property text() As String
      Get
         Return _text
      End Get
      Set(ByVal value As String)
         _text = value
      End Set
   End Property

   Private _selectionStart As Integer = 0
   Public Property selectionStart() As Integer
      Get
         Return _selectionStart
      End Get
      Set(ByVal value As Integer)
         _selectionStart = value
      End Set
   End Property

   Private _selectionLength As Integer = 0
   Public Property selectionLength() As Integer
      Get
         Return _selectionLength
      End Get
      Set(ByVal value As Integer)
         _selectionLength = value
      End Set
   End Property

End Class
