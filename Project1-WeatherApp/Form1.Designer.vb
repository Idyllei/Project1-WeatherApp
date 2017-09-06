<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeather
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWeather))
        Me.btnSunny = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRainy = New System.Windows.Forms.Button()
        Me.btnWindy = New System.Windows.Forms.Button()
        Me.btnHail = New System.Windows.Forms.Button()
        Me.picHail = New System.Windows.Forms.PictureBox()
        Me.picWind = New System.Windows.Forms.PictureBox()
        Me.picSun = New System.Windows.Forms.PictureBox()
        Me.picRain = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblReport = New System.Windows.Forms.Label()
        CType(Me.picHail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSunny
        '
        Me.btnSunny.BackColor = System.Drawing.Color.Khaki
        Me.btnSunny.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSunny.Location = New System.Drawing.Point(13, 13)
        Me.btnSunny.Name = "btnSunny"
        Me.btnSunny.Size = New System.Drawing.Size(75, 23)
        Me.btnSunny.TabIndex = 0
        Me.btnSunny.Text = "&Sun"
        Me.ToolTip1.SetToolTip(Me.btnSunny, "Make the weather sunny")
        Me.btnSunny.UseVisualStyleBackColor = False
        '
        'btnRainy
        '
        Me.btnRainy.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnRainy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRainy.Location = New System.Drawing.Point(13, 43)
        Me.btnRainy.Name = "btnRainy"
        Me.btnRainy.Size = New System.Drawing.Size(75, 23)
        Me.btnRainy.TabIndex = 1
        Me.btnRainy.Text = "&Rain"
        Me.ToolTip1.SetToolTip(Me.btnRainy, "Make the weather rainy")
        Me.btnRainy.UseVisualStyleBackColor = False
        '
        'btnWindy
        '
        Me.btnWindy.BackColor = System.Drawing.Color.White
        Me.btnWindy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWindy.Location = New System.Drawing.Point(12, 101)
        Me.btnWindy.Name = "btnWindy"
        Me.btnWindy.Size = New System.Drawing.Size(75, 23)
        Me.btnWindy.TabIndex = 2
        Me.btnWindy.Text = "&Wind"
        Me.ToolTip1.SetToolTip(Me.btnWindy, "Make the weather windy")
        Me.btnWindy.UseVisualStyleBackColor = False
        '
        'btnHail
        '
        Me.btnHail.BackColor = System.Drawing.Color.MintCream
        Me.btnHail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHail.Location = New System.Drawing.Point(13, 72)
        Me.btnHail.Name = "btnHail"
        Me.btnHail.Size = New System.Drawing.Size(75, 23)
        Me.btnHail.TabIndex = 3
        Me.btnHail.Text = "&Hail"
        Me.ToolTip1.SetToolTip(Me.btnHail, "Make the weather snowy")
        Me.btnHail.UseVisualStyleBackColor = False
        '
        'picHail
        '
        Me.picHail.Image = CType(resources.GetObject("picHail.Image"), System.Drawing.Image)
        Me.picHail.Location = New System.Drawing.Point(94, 12)
        Me.picHail.Name = "picHail"
        Me.picHail.Size = New System.Drawing.Size(128, 128)
        Me.picHail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picHail.TabIndex = 4
        Me.picHail.TabStop = False
        Me.picHail.Visible = False
        '
        'picWind
        '
        Me.picWind.Image = CType(resources.GetObject("picWind.Image"), System.Drawing.Image)
        Me.picWind.Location = New System.Drawing.Point(95, 12)
        Me.picWind.Name = "picWind"
        Me.picWind.Size = New System.Drawing.Size(128, 128)
        Me.picWind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picWind.TabIndex = 5
        Me.picWind.TabStop = False
        Me.picWind.Visible = False
        '
        'picSun
        '
        Me.picSun.Image = CType(resources.GetObject("picSun.Image"), System.Drawing.Image)
        Me.picSun.Location = New System.Drawing.Point(95, 12)
        Me.picSun.Name = "picSun"
        Me.picSun.Size = New System.Drawing.Size(128, 128)
        Me.picSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picSun.TabIndex = 6
        Me.picSun.TabStop = False
        Me.picSun.Visible = False
        '
        'picRain
        '
        Me.picRain.Image = CType(resources.GetObject("picRain.Image"), System.Drawing.Image)
        Me.picRain.Location = New System.Drawing.Point(95, 13)
        Me.picRain.Name = "picRain"
        Me.picRain.Size = New System.Drawing.Size(128, 128)
        Me.picRain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRain.TabIndex = 7
        Me.picRain.TabStop = False
        Me.picRain.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(13, 130)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblReport
        '
        Me.lblReport.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(95, 144)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(130, 54)
        Me.lblReport.TabIndex = 9
        Me.lblReport.UseCompatibleTextRendering = True
        '
        'frmWeather
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(237, 207)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHail)
        Me.Controls.Add(Me.btnWindy)
        Me.Controls.Add(Me.btnRainy)
        Me.Controls.Add(Me.btnSunny)
        Me.Controls.Add(Me.picRain)
        Me.Controls.Add(Me.picSun)
        Me.Controls.Add(Me.picWind)
        Me.Controls.Add(Me.picHail)
        Me.Name = "frmWeather"
        Me.Text = "Form1"
        CType(Me.picHail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSunny As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnRainy As Button
    Friend WithEvents btnWindy As Button
    Friend WithEvents btnHail As Button
    Friend WithEvents picHail As PictureBox
    Friend WithEvents picWind As PictureBox
    Friend WithEvents picSun As PictureBox
    Friend WithEvents picRain As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblReport As Label
End Class
