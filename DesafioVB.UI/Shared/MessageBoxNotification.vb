Imports DesafioVB.Entities.Notifications

Public Class MessageBoxNotification
    Implements INotification

    Public Sub Notify(message As String) Implements INotification.Notify
        MessageBox.Show(message, "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
