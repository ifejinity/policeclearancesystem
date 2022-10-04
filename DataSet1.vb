Partial Class DataSet1
    Partial Public Class userDataTable
        Private Sub userDataTable_userRowChanging(sender As Object, e As userRowChangeEvent) Handles Me.userRowChanging

        End Sub

        Private Sub userDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.usernameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
