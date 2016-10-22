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
            Dim Settings, Conjunto As XmlNodeList
            Dim Variable, test As XmlNode
            'Manipulacion de documentos XML con carga
            Datos = New XmlDocument
            Datos.Load(Ruta)
            'Lectura de NODOS para acceder al panel principal
            Conjunto = Datos.SelectNodes("/DataFenix/Servers/Servidor[@id='0']")

            Conjunto = Datos.SelectNodes("/DataFenix/Servers/Servidor[@id='0']")

            ' TEST DE PRUEBA



            MsgBox(Conjunto.Count & "NODOS")

            If Conjunto.Count = 1 Then
                'Reserved id 0 Used
                For Each Variable In Conjunto
                    Variable.ChildNodes(0).InnerText = TB_Site.Text
                    Variable.ChildNodes(1).InnerText = TB_Rack.Text
                    Variable.ChildNodes(2).InnerText = TB_Modelo.Text
                    Variable.ChildNodes(3).InnerText = TB_SerialNumber.Text
                    Variable.ChildNodes(4).InnerText = TB_ControlDomain.Text
                    Variable.ChildNodes(5).InnerText = TB_Ambiente.Text
                    Variable.ChildNodes(6).InnerText = TB_Hostname.Text
                    Variable.ChildNodes(7).InnerText = TB_Dominio.Text
                    Variable.ChildNodes(8).InnerText = Check_Dominio.Checked
                    Variable.ChildNodes(9).InnerText = TB_IP.Text
                    Variable.ChildNodes(10).InnerText = TB_Usuario.Text
                    Variable.ChildNodes(11).InnerText = TB_Password.Text
                    Variable.ChildNodes(12).InnerText = TB_Sistema.Text
                    Variable.ChildNodes(13).InnerText = TB_Version.Text


                Next
                test = Conjunto.Item(0)


                Dim Continuo = test.Attributes.GetNamedItem("id").Value + 1
                test.Clone()

                MsgBox(Continuo)

                MsgBox("Servidor Registrado con exito")

            Else
                'Firts Servers
                'MsgBox("Primer Server a registrar ")

            End If
            'MsgBox("Salida")

            'For Each Variable In Conjunto
            '    MsgBox(Variable.Attributes.GetNamedItem("id").Value)
            '    MsgBox(Variable.ChildNodes(0).InnerText)
            'Next

            'Almacenar Cambios realizados
            Datos.Save(Ruta)
        Catch ex As Exception
            MessageBox.Show("Error Inesperado por favor de contactar al administrador - Out: " & ex.Message)
        End Try
    End Sub

    Private Sub VerPass_Click(sender As Object, e As EventArgs) Handles VerPass.Click
        If TB_Password.UseSystemPasswordChar = True Then
            TB_Password.UseSystemPasswordChar = False
        Else
            TB_Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Check_Dominio_CheckStateChanged(sender As Object, e As EventArgs) Handles Check_Dominio.CheckStateChanged
        If Check_Dominio.Checked = True Then
            TB_Dominio.Enabled = True
            TB_Dominio.Clear()
        Else
            TB_Dominio.Enabled = False
            TB_Dominio.Text = "PROSAMX"
        End If
    End Sub
End Class