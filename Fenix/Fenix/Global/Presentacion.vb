﻿Public NotInheritable Class Presentacion

    'TODO: Este formulario se puede establecer fácilmente como pantalla de presentación para la aplicación desde la pestaña "Aplicación"
    '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").


    Private Sub Presentacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Si l
















        'Configure el texto del cuadro de diálogo en tiempo de ejecución según la información del ensamblado de la aplicación.  

        'TODO: Personalice la información del ensamblado de la aplicación en el panel "Aplicación" del cuadro de diálogo 
        '  propiedades del proyecto (bajo el menú "Proyecto").

        'Título de la aplicación



        If My.Application.Info.Title <> "" Then

        Else
            'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión

        End If

        'Dé formato a la información de versión usando el texto establecido en el control de versiones en tiempo de diseño como
        '  cadena de formato.  Esto le permite una localización efectiva si lo desea.
        '  Se pudo incluir la información de compilación y revisión usando el siguiente código y cambiando el 
        '  texto en tiempo de diseño del control de versiones a "Versión {0}.{1:00}.{2}.{3}" o algo parecido.  Consulte
        '  String.Format() en la Ayuda para obtener más información.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)



        'Información de Copyright

    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BannerPresentacion_Click(sender As Object, e As EventArgs) Handles BannerPresentacion.Click

    End Sub
End Class
