Imports xAcademics.KFUPMSchedule

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReadSheetBtn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReadSheetBtn))
        txtCRNs = New TextBox()
        enter = New Label()
        pnlMap = New Panel()
        GroupBox6 = New GroupBox()
        btnS = New Button()
        btnM = New Button()
        btnT = New Button()
        btnW = New Button()
        btnR = New Button()
        txtResults = New TextBox()
        SuspendLayout()
        ' 
        ' txtCRNs
        ' 
        txtCRNs.Location = New Point(363, 61)
        txtCRNs.Name = "txtCRNs"
        txtCRNs.Size = New Size(466, 27)
        txtCRNs.TabIndex = 0
        ' 
        ' enter
        ' 
        enter.AutoSize = True
        enter.Location = New Point(62, 61)
        enter.Name = "enter"
        enter.Size = New Size(196, 20)
        enter.TabIndex = 4
        enter.Text = "Enter Student CRN Number :"
        ' 
        ' pnlMap
        ' 
        pnlMap.BackColor = SystemColors.ButtonHighlight
        pnlMap.BackgroundImage = CType(resources.GetObject("pnlMap.BackgroundImage"), Image)
        pnlMap.Location = New Point(62, 143)
        pnlMap.Name = "pnlMap"
        pnlMap.Size = New Size(411, 387)
        pnlMap.TabIndex = 5
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Location = New Point(534, 108)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(250, 71)
        GroupBox6.TabIndex = 12
        GroupBox6.TabStop = False
        GroupBox6.Text = "select day"
        ' 
        ' btnS
        ' 
        btnS.BackColor = Color.Yellow
        btnS.Location = New Point(547, 133)
        btnS.Name = "btnS"
        btnS.Size = New Size(40, 38)
        btnS.TabIndex = 13
        btnS.Text = "S"
        btnS.UseVisualStyleBackColor = False
        ' 
        ' btnM
        ' 
        btnM.BackColor = Color.Yellow
        btnM.Location = New Point(593, 133)
        btnM.Name = "btnM"
        btnM.Size = New Size(40, 38)
        btnM.TabIndex = 14
        btnM.Text = "M"
        btnM.UseVisualStyleBackColor = False
        ' 
        ' btnT
        ' 
        btnT.BackColor = Color.Yellow
        btnT.Location = New Point(639, 133)
        btnT.Name = "btnT"
        btnT.Size = New Size(40, 38)
        btnT.TabIndex = 15
        btnT.Text = "T"
        btnT.UseVisualStyleBackColor = False
        ' 
        ' btnW
        ' 
        btnW.BackColor = Color.Yellow
        btnW.Location = New Point(688, 133)
        btnW.Name = "btnW"
        btnW.Size = New Size(40, 38)
        btnW.TabIndex = 16
        btnW.Text = "W"
        btnW.UseVisualStyleBackColor = False
        ' 
        ' btnR
        ' 
        btnR.BackColor = Color.Yellow
        btnR.Location = New Point(734, 133)
        btnR.Name = "btnR"
        btnR.Size = New Size(40, 38)
        btnR.TabIndex = 17
        btnR.Text = "R"
        btnR.UseVisualStyleBackColor = False
        ' 
        ' txtResults
        ' 
        txtResults.BackColor = SystemColors.ButtonHighlight
        txtResults.Location = New Point(534, 196)
        txtResults.Multiline = True
        txtResults.Name = "txtResults"
        txtResults.ReadOnly = True
        txtResults.ScrollBars = ScrollBars.Vertical
        txtResults.Size = New Size(295, 351)
        txtResults.TabIndex = 18
        ' 
        ' ReadSheetBtn
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 553)
        Controls.Add(txtResults)
        Controls.Add(btnR)
        Controls.Add(btnW)
        Controls.Add(btnT)
        Controls.Add(btnM)
        Controls.Add(btnS)
        Controls.Add(GroupBox6)
        Controls.Add(pnlMap)
        Controls.Add(enter)
        Controls.Add(txtCRNs)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ReadSheetBtn"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents txtCRNs As TextBox
    Friend WithEvents enter As Label
    Friend WithEvents pnlMap As Panel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnS As Button
    Friend WithEvents btnM As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnW As Button
    Friend WithEvents btnR As Button
    Friend WithEvents txtResults As TextBox
End Class