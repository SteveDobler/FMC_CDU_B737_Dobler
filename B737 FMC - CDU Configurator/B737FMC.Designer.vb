<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formB737FMC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formB737FMC))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEXEC_ON = New System.Windows.Forms.Button()
        Me.btnEXEC_OFF = New System.Windows.Forms.Button()
        Me.ledEXEC = New System.Windows.Forms.Button()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.ledCALL = New System.Windows.Forms.Button()
        Me.btnCALL_OFF = New System.Windows.Forms.Button()
        Me.btnCALL_ON = New System.Windows.Forms.Button()
        Me.btnFAIL_ON = New System.Windows.Forms.Button()
        Me.btnFAIL_OFF = New System.Windows.Forms.Button()
        Me.ledFAIL = New System.Windows.Forms.Button()
        Me.ledMSG = New System.Windows.Forms.Button()
        Me.btnMSG_OFF = New System.Windows.Forms.Button()
        Me.btnMSG_ON = New System.Windows.Forms.Button()
        Me.ledOFST = New System.Windows.Forms.Button()
        Me.btnOFST_OFF = New System.Windows.Forms.Button()
        Me.btnOFST_ON = New System.Windows.Forms.Button()
        Me.btnALL_OF = New System.Windows.Forms.Button()
        Me.btnALL_ON = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxCommPort = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 346)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnEXEC_ON
        '
        Me.btnEXEC_ON.Location = New System.Drawing.Point(29, 20)
        Me.btnEXEC_ON.Name = "btnEXEC_ON"
        Me.btnEXEC_ON.Size = New System.Drawing.Size(75, 23)
        Me.btnEXEC_ON.TabIndex = 6
        Me.btnEXEC_ON.Text = "EXEC ON"
        Me.btnEXEC_ON.UseVisualStyleBackColor = True
        '
        'btnEXEC_OFF
        '
        Me.btnEXEC_OFF.Location = New System.Drawing.Point(145, 20)
        Me.btnEXEC_OFF.Name = "btnEXEC_OFF"
        Me.btnEXEC_OFF.Size = New System.Drawing.Size(75, 23)
        Me.btnEXEC_OFF.TabIndex = 7
        Me.btnEXEC_OFF.Text = "EXEC OFF"
        Me.btnEXEC_OFF.UseVisualStyleBackColor = True
        '
        'ledEXEC
        '
        Me.ledEXEC.BackColor = System.Drawing.Color.White
        Me.ledEXEC.Location = New System.Drawing.Point(112, 23)
        Me.ledEXEC.Name = "ledEXEC"
        Me.ledEXEC.Size = New System.Drawing.Size(27, 20)
        Me.ledEXEC.TabIndex = 8
        Me.ledEXEC.UseVisualStyleBackColor = False
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(296, 364)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(252, 33)
        Me.btnEXIT.TabIndex = 9
        Me.btnEXIT.Text = "EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'ledCALL
        '
        Me.ledCALL.BackColor = System.Drawing.Color.White
        Me.ledCALL.Location = New System.Drawing.Point(112, 62)
        Me.ledCALL.Name = "ledCALL"
        Me.ledCALL.Size = New System.Drawing.Size(27, 20)
        Me.ledCALL.TabIndex = 12
        Me.ledCALL.UseVisualStyleBackColor = False
        '
        'btnCALL_OFF
        '
        Me.btnCALL_OFF.Location = New System.Drawing.Point(145, 59)
        Me.btnCALL_OFF.Name = "btnCALL_OFF"
        Me.btnCALL_OFF.Size = New System.Drawing.Size(75, 23)
        Me.btnCALL_OFF.TabIndex = 11
        Me.btnCALL_OFF.Text = "CALL OFF"
        Me.btnCALL_OFF.UseVisualStyleBackColor = True
        '
        'btnCALL_ON
        '
        Me.btnCALL_ON.Location = New System.Drawing.Point(29, 59)
        Me.btnCALL_ON.Name = "btnCALL_ON"
        Me.btnCALL_ON.Size = New System.Drawing.Size(75, 23)
        Me.btnCALL_ON.TabIndex = 10
        Me.btnCALL_ON.Text = "CALL ON"
        Me.btnCALL_ON.UseVisualStyleBackColor = True
        '
        'btnFAIL_ON
        '
        Me.btnFAIL_ON.Location = New System.Drawing.Point(29, 97)
        Me.btnFAIL_ON.Name = "btnFAIL_ON"
        Me.btnFAIL_ON.Size = New System.Drawing.Size(75, 23)
        Me.btnFAIL_ON.TabIndex = 13
        Me.btnFAIL_ON.Text = "FAIL ON"
        Me.btnFAIL_ON.UseVisualStyleBackColor = True
        '
        'btnFAIL_OFF
        '
        Me.btnFAIL_OFF.Location = New System.Drawing.Point(145, 97)
        Me.btnFAIL_OFF.Name = "btnFAIL_OFF"
        Me.btnFAIL_OFF.Size = New System.Drawing.Size(75, 23)
        Me.btnFAIL_OFF.TabIndex = 14
        Me.btnFAIL_OFF.Text = "FAIL OFF"
        Me.btnFAIL_OFF.UseVisualStyleBackColor = True
        '
        'ledFAIL
        '
        Me.ledFAIL.BackColor = System.Drawing.Color.White
        Me.ledFAIL.Location = New System.Drawing.Point(112, 98)
        Me.ledFAIL.Name = "ledFAIL"
        Me.ledFAIL.Size = New System.Drawing.Size(27, 20)
        Me.ledFAIL.TabIndex = 15
        Me.ledFAIL.UseVisualStyleBackColor = False
        '
        'ledMSG
        '
        Me.ledMSG.BackColor = System.Drawing.Color.White
        Me.ledMSG.Location = New System.Drawing.Point(112, 137)
        Me.ledMSG.Name = "ledMSG"
        Me.ledMSG.Size = New System.Drawing.Size(27, 20)
        Me.ledMSG.TabIndex = 18
        Me.ledMSG.UseVisualStyleBackColor = False
        '
        'btnMSG_OFF
        '
        Me.btnMSG_OFF.Location = New System.Drawing.Point(145, 136)
        Me.btnMSG_OFF.Name = "btnMSG_OFF"
        Me.btnMSG_OFF.Size = New System.Drawing.Size(75, 23)
        Me.btnMSG_OFF.TabIndex = 17
        Me.btnMSG_OFF.Text = "MSG OFF"
        Me.btnMSG_OFF.UseVisualStyleBackColor = True
        '
        'btnMSG_ON
        '
        Me.btnMSG_ON.Location = New System.Drawing.Point(29, 136)
        Me.btnMSG_ON.Name = "btnMSG_ON"
        Me.btnMSG_ON.Size = New System.Drawing.Size(75, 23)
        Me.btnMSG_ON.TabIndex = 16
        Me.btnMSG_ON.Text = "MSG ON"
        Me.btnMSG_ON.UseVisualStyleBackColor = True
        '
        'ledOFST
        '
        Me.ledOFST.BackColor = System.Drawing.Color.White
        Me.ledOFST.Location = New System.Drawing.Point(112, 176)
        Me.ledOFST.Name = "ledOFST"
        Me.ledOFST.Size = New System.Drawing.Size(27, 20)
        Me.ledOFST.TabIndex = 21
        Me.ledOFST.UseVisualStyleBackColor = False
        '
        'btnOFST_OFF
        '
        Me.btnOFST_OFF.Location = New System.Drawing.Point(145, 175)
        Me.btnOFST_OFF.Name = "btnOFST_OFF"
        Me.btnOFST_OFF.Size = New System.Drawing.Size(75, 23)
        Me.btnOFST_OFF.TabIndex = 20
        Me.btnOFST_OFF.Text = "OFST OFF"
        Me.btnOFST_OFF.UseVisualStyleBackColor = True
        '
        'btnOFST_ON
        '
        Me.btnOFST_ON.Location = New System.Drawing.Point(29, 175)
        Me.btnOFST_ON.Name = "btnOFST_ON"
        Me.btnOFST_ON.Size = New System.Drawing.Size(75, 23)
        Me.btnOFST_ON.TabIndex = 19
        Me.btnOFST_ON.Text = "OFST ON"
        Me.btnOFST_ON.UseVisualStyleBackColor = True
        '
        'btnALL_OF
        '
        Me.btnALL_OF.Location = New System.Drawing.Point(29, 244)
        Me.btnALL_OF.Name = "btnALL_OF"
        Me.btnALL_OF.Size = New System.Drawing.Size(191, 23)
        Me.btnALL_OF.TabIndex = 23
        Me.btnALL_OF.Text = "ALL OFF"
        Me.btnALL_OF.UseVisualStyleBackColor = True
        '
        'btnALL_ON
        '
        Me.btnALL_ON.Location = New System.Drawing.Point(29, 215)
        Me.btnALL_ON.Name = "btnALL_ON"
        Me.btnALL_ON.Size = New System.Drawing.Size(191, 23)
        Me.btnALL_ON.TabIndex = 22
        Me.btnALL_ON.Text = "ALL ON"
        Me.btnALL_ON.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnALL_OF)
        Me.GroupBox1.Controls.Add(Me.btnALL_ON)
        Me.GroupBox1.Controls.Add(Me.ledOFST)
        Me.GroupBox1.Controls.Add(Me.btnOFST_OFF)
        Me.GroupBox1.Controls.Add(Me.btnOFST_ON)
        Me.GroupBox1.Controls.Add(Me.ledMSG)
        Me.GroupBox1.Controls.Add(Me.btnMSG_OFF)
        Me.GroupBox1.Controls.Add(Me.btnMSG_ON)
        Me.GroupBox1.Controls.Add(Me.ledFAIL)
        Me.GroupBox1.Controls.Add(Me.btnFAIL_OFF)
        Me.GroupBox1.Controls.Add(Me.btnFAIL_ON)
        Me.GroupBox1.Controls.Add(Me.ledCALL)
        Me.GroupBox1.Controls.Add(Me.btnCALL_OFF)
        Me.GroupBox1.Controls.Add(Me.btnCALL_ON)
        Me.GroupBox1.Controls.Add(Me.ledEXEC)
        Me.GroupBox1.Controls.Add(Me.btnEXEC_OFF)
        Me.GroupBox1.Controls.Add(Me.btnEXEC_ON)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(296, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 288)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LED Test"
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"4800", "9600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(26, 45)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(108, 21)
        Me.ComboBoxBaudRate.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Select Baud Rate"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ComboBoxCommPort)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ComboBoxBaudRate)
        Me.GroupBox2.Location = New System.Drawing.Point(588, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 290)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "USB Serial Connection"
        '
        'ComboBoxCommPort
        '
        Me.ComboBoxCommPort.FormattingEnabled = True
        Me.ComboBoxCommPort.Location = New System.Drawing.Point(26, 99)
        Me.ComboBoxCommPort.Name = "ComboBoxCommPort"
        Me.ComboBoxCommPort.Size = New System.Drawing.Size(108, 21)
        Me.ComboBoxCommPort.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Select Comm Port"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(25, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 26)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Button 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 26)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(25, 200)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 26)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'formB737FMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "formB737FMC"
        Me.Text = "B737 FMC Configurator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEXEC_ON As Button
    Friend WithEvents btnEXEC_OFF As Button
    Friend WithEvents ledEXEC As Button
    Friend WithEvents btnEXIT As Button
    Friend WithEvents ledCALL As Button
    Friend WithEvents btnCALL_OFF As Button
    Friend WithEvents btnCALL_ON As Button
    Friend WithEvents btnFAIL_ON As Button
    Friend WithEvents btnFAIL_OFF As Button
    Friend WithEvents ledFAIL As Button
    Friend WithEvents ledMSG As Button
    Friend WithEvents btnMSG_OFF As Button
    Friend WithEvents btnMSG_ON As Button
    Friend WithEvents ledOFST As Button
    Friend WithEvents btnOFST_OFF As Button
    Friend WithEvents btnOFST_ON As Button
    Friend WithEvents btnALL_OF As Button
    Friend WithEvents btnALL_ON As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxCommPort As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
End Class
