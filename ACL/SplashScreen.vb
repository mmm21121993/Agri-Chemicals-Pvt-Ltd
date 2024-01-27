Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmSplashScreen

    Public CS As String = System.Configuration.ConfigurationManager.ConnectionStrings("AgriChemDB").ConnectionString.ToString

End Class