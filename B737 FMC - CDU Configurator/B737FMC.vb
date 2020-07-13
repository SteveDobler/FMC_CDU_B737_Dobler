Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel

Public Class formB737FMC
    '------------------------------------------------
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data
    '------------------------------------------------

    Private Sub formB737FMC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxCommPort.Items.AddRange(myPort)
        Button2.Enabled = False

    End Sub

    Private Sub btnEXEC_ON_Click(sender As Object, e As EventArgs) Handles btnEXEC_ON.Click
        ledEXEC.BackColor = Color.LightGreen
    End Sub

    Private Sub btnEXIT_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub

    Private Sub btnEXEC_OFF_Click(sender As Object, e As EventArgs) Handles btnEXEC_OFF.Click
        ledEXEC.BackColor = Color.White
    End Sub

    Private Sub btnCALL_ON_Click(sender As Object, e As EventArgs) Handles btnCALL_ON.Click
        ledCALL.BackColor = Color.Red
    End Sub

    Private Sub btnCALL_OFF_Click(sender As Object, e As EventArgs) Handles btnCALL_OFF.Click
        ledCALL.BackColor = Color.White
    End Sub

    Private Sub btnFAIL_ON_Click(sender As Object, e As EventArgs) Handles btnFAIL_ON.Click
        ledFAIL.BackColor = Color.Red
    End Sub

    Private Sub btnFAIL_OFF_Click(sender As Object, e As EventArgs) Handles btnFAIL_OFF.Click
        ledFAIL.BackColor = Color.White
    End Sub

    Private Sub btnMSG_ON_Click(sender As Object, e As EventArgs) Handles btnMSG_ON.Click
        ledMSG.BackColor = Color.Yellow
    End Sub

    Private Sub btnMSG_OFF_Click(sender As Object, e As EventArgs) Handles btnMSG_OFF.Click
        ledMSG.BackColor = Color.White
    End Sub

    Private Sub btnOFST_ON_Click(sender As Object, e As EventArgs) Handles btnOFST_ON.Click
        ledOFST.BackColor = Color.Yellow
    End Sub

    Private Sub btnOFST_OFF_Click(sender As Object, e As EventArgs) Handles btnOFST_OFF.Click
        ledOFST.BackColor = Color.White
    End Sub

    Private Sub btnALL_ON_Click(sender As Object, e As EventArgs) Handles btnALL_ON.Click
        ledOFST.BackColor = Color.Yellow
        ledMSG.BackColor = Color.Yellow
        ledFAIL.BackColor = Color.Red
        ledEXEC.BackColor = Color.LightGreen
        ledCALL.BackColor = Color.Red
    End Sub

    Private Sub btnALL_OF_Click(sender As Object, e As EventArgs) Handles btnALL_OF.Click
        ledOFST.BackColor = Color.White
        ledMSG.BackColor = Color.White
        ledFAIL.BackColor = Color.White
        ledEXEC.BackColor = Color.White
        ledCALL.BackColor = Color.White
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.PortName = ComboBoxCommPort.Text
        SerialPort1.BaudRate = ComboBoxBaudRate.Text
        SerialPort1.Open()
        Button1.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SerialPort1.Close()
        Button1.Enabled = True
        Button2.Enabled = False
        Button4.Enabled = False
    End Sub

End Class
