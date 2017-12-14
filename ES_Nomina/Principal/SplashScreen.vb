Imports System.IO
Imports System.Threading
Imports System.Management

Public Class SplashScreen

    Public contador As Integer

    Private Function CheckUSB() As Boolean
        If GetVolumeSerial("D").Equals("8E465F40") Then
            Return True
        ElseIf GetVolumeSerial("E").Equals("A06737B2") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function GetVolumeSerial(ByVal DriveLetter As String) As String

        'Check for valid drive letter argument. 
        Dim ValidDriveLetters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        If ValidDriveLetters.IndexOf(DriveLetter) <> -1 Then
            If DriveLetter.Length = 1 Then
                Try
                    Dim Disk As New ManagementObject("Win32_LogicalDisk.DeviceID=""" & DriveLetter & ":""")
                    Dim DiskProperty As PropertyData
                    For Each DiskProperty In Disk.Properties
                        If DiskProperty.Name = "VolumeSerialNumber" Then
                            Return DiskProperty.Value.ToString  '.ToString 'Return the volume serial number. 
                        End If
                    Next DiskProperty
                Catch
                    MessageBox.Show("No hay USB conectada", "ES_Nomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return ""
                End Try
            End If
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (contador < 100) Then
            ProgressBar1.Value = contador
            contador += 10
        Else
            Timer1.Enabled = False
            If (CheckUSB()) Then
                FrmMenu.Show()
                Hide()
            Else
                MessageBox.Show("USB invalida, inserte la USB correcta", "ES_Nomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Application.Exit()
            End If
        End If
    End Sub
End Class

