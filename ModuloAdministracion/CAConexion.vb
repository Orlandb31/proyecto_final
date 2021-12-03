Imports System.Data.SqlClient
Imports System.Xml
Public Class CAConexion
    Private mYConn As SqlConnection
    Public Function conexion() As SqlConnection
        Dim cadenadeconexion As String
        Dim servidorDb As String = "", nameDb As String = "", usuario As String = "", pass As String = ""
        lecturaXML(servidorDb, nameDb, usuario, pass)
        cadenadeconexion = "data source =" & servidorDb & " ; initial catalog =" & nameDb & "; user id =" & usuario & " ; password =" & pass
        mYConn = New SqlConnection(cadenadeconexion)
        Return mYConn
    End Function
    Sub lecturaXML(ByRef servidorDb As String, ByRef nameDb As String, ByRef usuario As String, ByRef pass As String)
        Dim mxml As XmlTextReader
        mxml = New XmlTextReader("../../Archivos/datacon.xml")
        mxml.Read()
        While Not mxml.EOF
            mxml.Read()
            If Not mxml.IsStartElement Then
                Exit While
            End If
            mxml.Read()
            servidorDb = DecodeBase64(mxml.ReadElementString("datasorurce"))
            nameDb = DecodeBase64(mxml.ReadElementString("initialcatalog"))
            usuario = DecodeBase64(mxml.ReadElementString("usuario"))
            pass = DecodeBase64(mxml.ReadElementString("pass"))

        End While
        mxml.Close()

    End Sub
    Public Function DecodeBase64(ByVal mensajeCodificado As String) As String

        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(mensajeCodificado))
    End Function
End Class
