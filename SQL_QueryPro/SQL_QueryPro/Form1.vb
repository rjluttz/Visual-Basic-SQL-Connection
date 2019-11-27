﻿Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1
    Public sqlcon As New SqlConnection With {.ConnectionString = "Data Source=USER\SQLEXPRESS;Initial Catalog=GTEC;Persist Security Info=True;User ID=sa;Password=2raku5"}
    Public sqlcmd As SqlCommand
    Public sqladp As SqlDataAdapter
    Public dset As DataSet
    Public query As String
    Public Function DBCon() As Boolean
        Try
            sqlcon.Open()
            sqlcon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub runquery(query As String)
        Try
            sqlcon.Open()
            sqlcmd = New SqlCommand(query, sqlcon)
            sqladp = New SqlDataAdapter(sqlcmd)
            dset = New DataSet
            sqladp.Fill(dset)
            sqlcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If
        End Try
    End Sub

    Private Sub ButQuery_Click(sender As Object, e As EventArgs) Handles ButQuery.Click
        If DBCon() = True Then
            runquery(TxtQuery.Text)
            If dset.Tables.Count > 0 Then
                DgvQuery.DataSource = dset.Tables(0)
            End If
        End If
    End Sub
End Class
