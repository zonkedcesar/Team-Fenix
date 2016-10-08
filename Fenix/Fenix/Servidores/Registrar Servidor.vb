Imports System.Xml

Public Class Registrar_Servidor

    Private Sub B_Cancelar_Click(sender As Object, e As EventArgs) Handles B_Cancelar.Click
        Me.Hide()
        'Limpiar contenedores
        TB_Site.Clear()
        TB_Rack.Clear()
        TB_Modelo.Clear()
        TB_SerialNumber.Clear()
        'Limpiar Contenedores
        TB_ControlDomain.Clear()
        TB_Ambiente.Clear()
        TB_Hostname.Clear()
        TB_Ambiente.Clear()
        TB_IP.Clear()
        TB_Sistema.Clear()
        TB_Version.Clear()
    End Sub

    Private Sub B_Registrar_Click(sender As Object, e As EventArgs) Handles B_Registrar.Click
        Dim Ruta As String
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".fnx"
        Try
            'Declaracion de variables de entorno
            Dim cuenta, recovery As XmlDocument
            Dim Variable As XmlNode
            Dim Conjunto As XmlNodeList
            Dim NumeroNodos As String
            'Manipulacion de documentos XML con carga
            cuenta = New XmlDocument
            recovery = New XmlDocument
            cuenta.Load(Ruta)
            'Lectura de NODOS para acceder al panel principal
            Conjunto = cuenta.SelectNodes("DataFenix/Servers")
            Variable = Conjunto.Item(0)
            NumeroNodos = Conjunto.Count
            MsgBox(NumeroNodos)
            For Each Variable In Conjunto
                'MsgBox(Variable.Attributes.GetEnumerator)
            Next
            'Almacenar Cambios realizados
            'cuenta.Save(Ruta)
        Catch ex As Exception
            MessageBox.Show("No se pudo crear la cuenta " & ex.Message)
        End Try
    End Sub
End Class