Imports System.Globalization

Module Fecha
    Function hora() As String 
        Dim localDate = DateTime.Now
        Dim cultureNames() As String = {"en-US", "en-GB", "fr-FR",
                                         "de-DE", "ru-RU"}
        Dim Result As String = ""
        For Each cultureName In cultureNames
            Dim culture As New CultureInfo(cultureName)


            Result = localDate.ToString(culture)
        Next
        Return Result
    End Function
End Module
