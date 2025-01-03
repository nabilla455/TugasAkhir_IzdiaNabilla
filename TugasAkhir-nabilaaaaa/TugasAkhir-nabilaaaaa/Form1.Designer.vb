<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        BeliTiketButton = New Button()
        tanggalDateTimePicker = New DateTimePicker()
        DateTimePicker = New Label()
        JumlahTiketComboBox = New ComboBox()
        JamMulaiComboBox = New ComboBox()
        judulFilmComboBox = New ComboBox()
        jumlahTiketTextBox = New Label()
        hargaTiketLabel = New Label()
        jamMulaiLabel = New Label()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(32, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 190)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(224, 32)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(156, 190)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(423, 32)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(156, 190)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(BeliTiketButton)
        Panel1.Controls.Add(tanggalDateTimePicker)
        Panel1.Controls.Add(DateTimePicker)
        Panel1.Controls.Add(JumlahTiketComboBox)
        Panel1.Controls.Add(JamMulaiComboBox)
        Panel1.Controls.Add(judulFilmComboBox)
        Panel1.Controls.Add(jumlahTiketTextBox)
        Panel1.Controls.Add(hargaTiketLabel)
        Panel1.Controls.Add(jamMulaiLabel)
        Panel1.Location = New Point(620, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(383, 433)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(26, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 25)
        Label1.TabIndex = 13
        Label1.Text = "Judul Film"
        ' 
        ' BeliTiketButton
        ' 
        BeliTiketButton.Location = New Point(194, 286)
        BeliTiketButton.Name = "BeliTiketButton"
        BeliTiketButton.Size = New Size(112, 34)
        BeliTiketButton.TabIndex = 10
        BeliTiketButton.Text = "Beli Tiket"
        BeliTiketButton.UseVisualStyleBackColor = True
        ' 
        ' tanggalDateTimePicker
        ' 
        tanggalDateTimePicker.Format = DateTimePickerFormat.Short
        tanggalDateTimePicker.Location = New Point(138, 41)
        tanggalDateTimePicker.MaxDate = New Date(2024, 12, 24, 0, 0, 0, 0)
        tanggalDateTimePicker.MinDate = New Date(2024, 12, 24, 0, 0, 0, 0)
        tanggalDateTimePicker.Name = "tanggalDateTimePicker"
        tanggalDateTimePicker.Size = New Size(231, 31)
        tanggalDateTimePicker.TabIndex = 9
        tanggalDateTimePicker.Value = New Date(2024, 12, 24, 0, 0, 0, 0)
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.AutoSize = True
        DateTimePicker.ForeColor = SystemColors.ControlLightLight
        DateTimePicker.Location = New Point(26, 46)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(73, 25)
        DateTimePicker.TabIndex = 8
        DateTimePicker.Text = "Tanggal"
        ' 
        ' JumlahTiketComboBox
        ' 
        JumlahTiketComboBox.FormattingEnabled = True
        JumlahTiketComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        JumlahTiketComboBox.Location = New Point(138, 219)
        JumlahTiketComboBox.MaxLength = 3
        JumlahTiketComboBox.Name = "JumlahTiketComboBox"
        JumlahTiketComboBox.Size = New Size(231, 33)
        JumlahTiketComboBox.TabIndex = 7
        ' 
        ' JamMulaiComboBox
        ' 
        JamMulaiComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        JamMulaiComboBox.FormattingEnabled = True
        JamMulaiComboBox.Location = New Point(138, 157)
        JamMulaiComboBox.Name = "JamMulaiComboBox"
        JamMulaiComboBox.Size = New Size(231, 33)
        JamMulaiComboBox.TabIndex = 5
        ' 
        ' judulFilmComboBox
        ' 
        judulFilmComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        judulFilmComboBox.FormattingEnabled = True
        judulFilmComboBox.Location = New Point(138, 100)
        judulFilmComboBox.Name = "judulFilmComboBox"
        judulFilmComboBox.Size = New Size(231, 33)
        judulFilmComboBox.TabIndex = 4
        ' 
        ' jumlahTiketTextBox
        ' 
        jumlahTiketTextBox.AutoSize = True
        jumlahTiketTextBox.ForeColor = SystemColors.ControlLightLight
        jumlahTiketTextBox.Location = New Point(26, 227)
        jumlahTiketTextBox.Name = "jumlahTiketTextBox"
        jumlahTiketTextBox.Size = New Size(106, 25)
        jumlahTiketTextBox.TabIndex = 3
        jumlahTiketTextBox.Text = "Jumlah tiket"
        jumlahTiketTextBox.TextAlign = ContentAlignment.TopRight
        ' 
        ' hargaTiketLabel
        ' 
        hargaTiketLabel.AutoSize = True
        hargaTiketLabel.ForeColor = SystemColors.ControlLightLight
        hargaTiketLabel.Location = New Point(24, 193)
        hargaTiketLabel.Name = "hargaTiketLabel"
        hargaTiketLabel.Size = New Size(0, 25)
        hargaTiketLabel.TabIndex = 2
        ' 
        ' jamMulaiLabel
        ' 
        jamMulaiLabel.AutoSize = True
        jamMulaiLabel.ForeColor = SystemColors.ControlLightLight
        jamMulaiLabel.Location = New Point(26, 160)
        jamMulaiLabel.Name = "jamMulaiLabel"
        jamMulaiLabel.Size = New Size(91, 25)
        jamMulaiLabel.TabIndex = 1
        jamMulaiLabel.Text = "Jam Mulai"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(32, 275)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(156, 190)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(224, 275)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(156, 190)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 5
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(423, 275)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(156, 190)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 6
        PictureBox6.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        ClientSize = New Size(1023, 509)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(Panel1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "TRANSAKSI TIKET BIOSKOP"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents hargaTiketLabel As Label
    Friend WithEvents jamMulaiLabel As Label
    Friend WithEvents JumlahTiketComboBox As ComboBox
    Friend WithEvents JamMulaiComboBox As ComboBox
    Friend WithEvents judulFilmComboBox As ComboBox
    Friend WithEvents jumlahTiketTextBox As Label
    Friend WithEvents tanggalDateTimePicker As DateTimePicker
    Friend WithEvents DateTimePicker As Label
    Friend WithEvents BeliTiketButton As Button
    Friend WithEvents Label1 As Label

End Class
