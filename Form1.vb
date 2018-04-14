Imports System.Data.SqlClient

Public Class Form1

    Dim cnADONetConnection As New System.Data.Odbc.OdbcConnection()

    Private m_cn As New OdbcConnection()

    ' m_cn.ConnectionString = Data Source="C\Users\Admin\Google Drive\Property\000 - Administration\Contacts.mdf";Integrated Security=True;Connect Timeout=30"
    'Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;
    ' Persist Security Info=False;

    m_cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;
                            Data Source=C\Users\Admin\Documents\GTSBackupRestore\TestDB\GTSDatabaseTest.accdb;"


    ' C\Users\Admin\Documents\GTSBackupRestore\TestDB\GTSDatabaseTest.accdb

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtBackupConnectionString.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strServer, strDatabase, strBackupPath, strConnectionString, strBackupStatus As String

        strServer = ""
        strDatabase = ""
        strBackupPath = ""
        strConnectionString = ""
        strBackupStatus = ""



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim fdFileDialog As OpenFileDialog = New OpenFileDialog()
        Dim strBackupPath As String

        fdFileDialog.Title = "Open File Dialog"
        'fdFileDialog.InitialDirectory = "C:\"
        fdFileDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fdFileDialog.FilterIndex = 2
        fdFileDialog.RestoreDirectory = True

        strBackupPath = fdFileDialog.FileName


        If fdFileDialog.ShowDialog() = DialogResult.OK Then
            strBackupPath = fdFileDialog.FileName
            txtBackupFileName.Text = strBackupPath

        End If

        'MessageBox.Show(strBackupPath)


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtBackupServer_TextChanged(sender As Object, e As EventArgs) Handles txtBackupServer.TextChanged

    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click

        m_cn.Open()
        ' txtConnectionConnect.Text = m_cn.RetrieveStatistics
        MessageBox.Show("Button Clicked")
    End Sub
End Class

'Private Sub EstablishDatabaseConnection()
'Provider = SQLXMLOLEDB.3.0;Data Provider=SQLOLEDB;Data Source=myServerAddress;
'Initial Catalog = myDataBase;User Id=myUsername;Password=myPassword;

'strConnectionString = "'Provider=SQLXMLOLEDB.3.0; Data Provider=SQLOLEDB; Data Source=" & txtBackupServer.text & ";" &
'       "Initial Catalog=" & txtBackupCatalog.text & ";Integrated Security=True/"
'End Sub

