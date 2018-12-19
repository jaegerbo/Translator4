Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.IO

<TestClass()> Public Class clsTest

   <TestMethod()> Public Sub TextLadenTesten()
      Try
         Dim Text As String = "bedGroupDesc,blocks,Block,EnChanged,Placing it on the ground will let you spawn there when you die. It shows on your map and prevents zombie respawn. Only the last placed one will be active.,""En le plaçant à terre, vous pourrez réapparaître à cet endroit lorsque vous mourrez et il sera indiqué sur votre carte."",""Wenn du dies platzierst, kannst du dort wiedererscheinen, falls du stirbst. Außerdem wird der Standort auf deiner Karte angezeigt."""

         Dim TextManager As New clsTextDataManager
         Dim row As dsTexte.tblQuestTexteRow = TextManager.createDatasetRow(Text)
         Assert.AreEqual("bedGroupDesc", row(0), "Spalte 0 falsch eingelesen")
         Assert.AreEqual("blocks", row(1), "Spalte 1 falsch eingelesen")
         Assert.AreEqual("Block", row(2), "Spalte 2 falsch eingelesen")
         Assert.AreEqual("EnChanged", row(3), "Spalte 3 falsch eingelesen")
         Assert.AreEqual("Placing it on the ground will let you spawn there when you die. It shows on your map and prevents zombie respawn. Only the last placed one will be active.", row(4), "Spalte 4 falsch eingelesen")
         Assert.AreEqual("En le plaçant à terre, vous pourrez réapparaître à cet endroit lorsque vous mourrez et il sera indiqué sur votre carte.", row(5), "Spalte 5 falsch eingelesen")
         Assert.AreEqual("Wenn du dies platzierst, kannst du dort wiedererscheinen, falls du stirbst. Außerdem wird der Standort auf deiner Karte angezeigt.", row(6), "Spalte 6 falsch eingelesen")
         Assert.AreEqual(String.Empty, row(7), "Spalte 7 falsch eingelesen")
         Assert.AreEqual(String.Empty, row(8), "Spalte 8 falsch eingelesen")

      Catch ex As Exception
         Assert.Fail(ex.Message)
      End Try
   End Sub

End Class
