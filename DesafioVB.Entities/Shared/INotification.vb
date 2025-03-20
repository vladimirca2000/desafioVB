Namespace Notifications
    Public Interface INotification
        Sub Notify(message As String)
    End Interface

    Public Class ConsoleNotification
        Implements INotification

        Public Sub Notify(message As String) Implements INotification.Notify
            Console.WriteLine(message)
        End Sub
    End Class
End Namespace
