Imports System.Data
Imports System.Data.SqlClient

Module SQL

    Friend Con_BD As New SqlConnection("Data Source=ANDROID\PROSAFNX;Initial Catalog=fenix;Integrated Security=True")

    'Data Source=190.190.200.100,1433;Network Library=DBMSSOCN;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;
    'Server=ANDROID\PROSAFNX;Database=fenix;User Id=sa;Password=;

    'MAS SEGURO SE CONTROLA CON CREDENCIALES NT
    'Data Source=ANDROID\PROSAFNX;Initial Catalog=fenix;Integrated Security=True

End Module
