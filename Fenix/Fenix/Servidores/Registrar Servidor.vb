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
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".Data"
        Try
            'Declaracion de variables de entorno
            Dim Datos As XmlDocument
            Dim Variable As XmlNode
            Dim salida As XmlElement
            Dim Conjunto, Menor As XmlNodeList
            'Manipulacion de documentos XML con carga
            Datos = New XmlDocument
            Datos.Load(Ruta)
            'Lectura de NODOS para acceder al panel principal
            Conjunto = Datos.SelectNodes("/DataFenix/Servers/Servidor")

            MsgBox(Conjunto.Count)

            If Conjunto.Count = 1 Then
                'Reserved id 0 Used
                MsgBox(Conjunto.Item(1))
                MsgBox("Antes")

                For Each Variable In Conjunto
                    MsgBox(Variable.ChildNodes(0).InnerText)
                    MsgBox(Variable.Attributes.GetNamedItem("id").Value)
                Next
            Else
                'Firts Servers
                MsgBox("Yo actualizo sobre el defaut 0 ")
            End If
            For Each Variable In Conjunto
                MsgBox(Variable.Attributes.GetNamedItem("id").Value)
            Next

            

            'Almacenar Cambios realizados
            'cuenta.Save(Ruta)
        Catch ex As Exception
            MessageBox.Show("No se pudo crear la cuenta " & ex.Message)
        End Try
    End Sub
End Class