<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBasicLookup = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBasicPC = New System.Windows.Forms.TextBox()
        Me.txtBasicCounty = New System.Windows.Forms.TextBox()
        Me.txtBasicCity = New System.Windows.Forms.TextBox()
        Me.txtBasicAL2 = New System.Windows.Forms.TextBox()
        Me.txtBasicAL1 = New System.Windows.Forms.TextBox()
        Me.txtBasicHouseNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBasicPostCode = New System.Windows.Forms.TextBox()
        Me.btnGetAddress = New System.Windows.Forms.Button()
        Me.tabRapidAddress = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboAddressList = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRapidPC = New System.Windows.Forms.TextBox()
        Me.txtRapidCounty = New System.Windows.Forms.TextBox()
        Me.txtRapidCity = New System.Windows.Forms.TextBox()
        Me.txtRapidAL2 = New System.Windows.Forms.TextBox()
        Me.txtRapidAL1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRapidPostCode = New System.Windows.Forms.TextBox()
        Me.btnRapidGetAddresses = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabBasicLookup.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabRapidAddress.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabBasicLookup)
        Me.TabControl1.Controls.Add(Me.tabRapidAddress)
        Me.TabControl1.Location = New System.Drawing.Point(17, 16)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(299, 383)
        Me.TabControl1.TabIndex = 0
        '
        'tabBasicLookup
        '
        Me.tabBasicLookup.Controls.Add(Me.GroupBox2)
        Me.tabBasicLookup.Controls.Add(Me.GroupBox1)
        Me.tabBasicLookup.Location = New System.Drawing.Point(4, 25)
        Me.tabBasicLookup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabBasicLookup.Name = "tabBasicLookup"
        Me.tabBasicLookup.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabBasicLookup.Size = New System.Drawing.Size(291, 354)
        Me.tabBasicLookup.TabIndex = 0
        Me.tabBasicLookup.Text = "Basic Address"
        Me.tabBasicLookup.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtBasicPC)
        Me.GroupBox2.Controls.Add(Me.txtBasicCounty)
        Me.GroupBox2.Controls.Add(Me.txtBasicCity)
        Me.GroupBox2.Controls.Add(Me.txtBasicAL2)
        Me.GroupBox2.Controls.Add(Me.txtBasicAL1)
        Me.GroupBox2.Controls.Add(Me.txtBasicHouseNo)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 107)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(268, 236)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(8, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "* House No needs entering manually *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 203)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Post Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 171)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "County:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 139)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "City/Town:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Address Line 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Address Line 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "House No:"
        '
        'txtBasicPC
        '
        Me.txtBasicPC.Location = New System.Drawing.Point(116, 199)
        Me.txtBasicPC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBasicPC.Name = "txtBasicPC"
        Me.txtBasicPC.Size = New System.Drawing.Size(124, 22)
        Me.txtBasicPC.TabIndex = 12
        '
        'txtBasicCounty
        '
        Me.txtBasicCounty.Location = New System.Drawing.Point(116, 167)
        Me.txtBasicCounty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBasicCounty.Name = "txtBasicCounty"
        Me.txtBasicCounty.Size = New System.Drawing.Size(124, 22)
        Me.txtBasicCounty.TabIndex = 11
        '
        'txtBasicCity
        '
        Me.txtBasicCity.Location = New System.Drawing.Point(116, 135)
        Me.txtBasicCity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBasicCity.Name = "txtBasicCity"
        Me.txtBasicCity.Size = New System.Drawing.Size(124, 22)
        Me.txtBasicCity.TabIndex = 10
        '
        'txtBasicAL2
        '
        Me.txtBasicAL2.Location = New System.Drawing.Point(116, 103)
        Me.txtBasicAL2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBasicAL2.Name = "txtBasicAL2"
        Me.txtBasicAL2.Size = New System.Drawing.Size(124, 22)
        Me.txtBasicAL2.TabIndex = 9
        '
        'txtBasicAL1
        '
        Me.txtBasicAL1.Location = New System.Drawing.Point(116, 71)
        Me.txtBasicAL1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBasicAL1.Name = "txtBasicAL1"
        Me.txtBasicAL1.Size = New System.Drawing.Size(124, 22)
        Me.txtBasicAL1.TabIndex = 8
        '
        'txtBasicHouseNo
        '
        Me.txtBasicHouseNo.Location = New System.Drawing.Point(116, 39)
        Me.txtBasicHouseNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBasicHouseNo.Name = "txtBasicHouseNo"
        Me.txtBasicHouseNo.Size = New System.Drawing.Size(124, 22)
        Me.txtBasicHouseNo.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBasicPostCode)
        Me.GroupBox1.Controls.Add(Me.btnGetAddress)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(268, 91)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Post Code Entry && Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Post Code:"
        '
        'txtBasicPostCode
        '
        Me.txtBasicPostCode.Location = New System.Drawing.Point(113, 23)
        Me.txtBasicPostCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBasicPostCode.Name = "txtBasicPostCode"
        Me.txtBasicPostCode.Size = New System.Drawing.Size(124, 22)
        Me.txtBasicPostCode.TabIndex = 6
        Me.txtBasicPostCode.Text = "AA11AB"
        '
        'btnGetAddress
        '
        Me.btnGetAddress.Location = New System.Drawing.Point(31, 55)
        Me.btnGetAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGetAddress.Name = "btnGetAddress"
        Me.btnGetAddress.Size = New System.Drawing.Size(208, 25)
        Me.btnGetAddress.TabIndex = 4
        Me.btnGetAddress.Text = "Get Sample Address"
        Me.btnGetAddress.UseVisualStyleBackColor = True
        '
        'tabRapidAddress
        '
        Me.tabRapidAddress.Controls.Add(Me.GroupBox4)
        Me.tabRapidAddress.Controls.Add(Me.GroupBox3)
        Me.tabRapidAddress.Location = New System.Drawing.Point(4, 25)
        Me.tabRapidAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabRapidAddress.Name = "tabRapidAddress"
        Me.tabRapidAddress.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabRapidAddress.Size = New System.Drawing.Size(291, 354)
        Me.tabRapidAddress.TabIndex = 1
        Me.tabRapidAddress.Text = "Rapid Address"
        Me.tabRapidAddress.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.cboAddressList)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtRapidPC)
        Me.GroupBox4.Controls.Add(Me.txtRapidCounty)
        Me.GroupBox4.Controls.Add(Me.txtRapidCity)
        Me.GroupBox4.Controls.Add(Me.txtRapidAL2)
        Me.GroupBox4.Controls.Add(Me.txtRapidAL1)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 106)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(268, 236)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Output"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Select an address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 203)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Post Code:"
        '
        'cboAddressList
        '
        Me.cboAddressList.FormattingEnabled = True
        Me.cboAddressList.Location = New System.Drawing.Point(12, 38)
        Me.cboAddressList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAddressList.Name = "cboAddressList"
        Me.cboAddressList.Size = New System.Drawing.Size(228, 24)
        Me.cboAddressList.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(57, 171)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "County:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 139)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 17)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "City/Town:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 107)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 17)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Address Line 2:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 75)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 17)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Address Line 1:"
        '
        'txtRapidPC
        '
        Me.txtRapidPC.Location = New System.Drawing.Point(116, 199)
        Me.txtRapidPC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRapidPC.Name = "txtRapidPC"
        Me.txtRapidPC.Size = New System.Drawing.Size(124, 22)
        Me.txtRapidPC.TabIndex = 12
        '
        'txtRapidCounty
        '
        Me.txtRapidCounty.Location = New System.Drawing.Point(116, 167)
        Me.txtRapidCounty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRapidCounty.Name = "txtRapidCounty"
        Me.txtRapidCounty.Size = New System.Drawing.Size(124, 22)
        Me.txtRapidCounty.TabIndex = 11
        '
        'txtRapidCity
        '
        Me.txtRapidCity.Location = New System.Drawing.Point(116, 135)
        Me.txtRapidCity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRapidCity.Name = "txtRapidCity"
        Me.txtRapidCity.Size = New System.Drawing.Size(124, 22)
        Me.txtRapidCity.TabIndex = 10
        '
        'txtRapidAL2
        '
        Me.txtRapidAL2.Location = New System.Drawing.Point(116, 103)
        Me.txtRapidAL2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRapidAL2.Name = "txtRapidAL2"
        Me.txtRapidAL2.Size = New System.Drawing.Size(124, 22)
        Me.txtRapidAL2.TabIndex = 9
        '
        'txtRapidAL1
        '
        Me.txtRapidAL1.Location = New System.Drawing.Point(116, 71)
        Me.txtRapidAL1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRapidAL1.Name = "txtRapidAL1"
        Me.txtRapidAL1.Size = New System.Drawing.Size(124, 22)
        Me.txtRapidAL1.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtRapidPostCode)
        Me.GroupBox3.Controls.Add(Me.btnRapidGetAddresses)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(268, 91)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Post Code Entry && Search"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 28)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Post Code:"
        '
        'txtRapidPostCode
        '
        Me.txtRapidPostCode.Location = New System.Drawing.Point(113, 23)
        Me.txtRapidPostCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRapidPostCode.Name = "txtRapidPostCode"
        Me.txtRapidPostCode.Size = New System.Drawing.Size(124, 22)
        Me.txtRapidPostCode.TabIndex = 6
        Me.txtRapidPostCode.Text = "AA11AB"
        '
        'btnRapidGetAddresses
        '
        Me.btnRapidGetAddresses.Location = New System.Drawing.Point(31, 55)
        Me.btnRapidGetAddresses.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRapidGetAddresses.Name = "btnRapidGetAddresses"
        Me.btnRapidGetAddresses.Size = New System.Drawing.Size(208, 25)
        Me.btnRapidGetAddresses.TabIndex = 4
        Me.btnRapidGetAddresses.Text = "Get Sample Address"
        Me.btnRapidGetAddresses.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 415)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Crafty Clicks - Example Post Code Lookup"
        Me.TabControl1.ResumeLayout(False)
        Me.tabBasicLookup.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabRapidAddress.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabBasicLookup As System.Windows.Forms.TabPage
    Friend WithEvents tabRapidAddress As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBasicPC As System.Windows.Forms.TextBox
    Friend WithEvents txtBasicCounty As System.Windows.Forms.TextBox
    Friend WithEvents txtBasicCity As System.Windows.Forms.TextBox
    Friend WithEvents txtBasicAL2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBasicAL1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBasicHouseNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBasicPostCode As System.Windows.Forms.TextBox
    Friend WithEvents btnGetAddress As System.Windows.Forms.Button
    Friend WithEvents cboAddressList As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtRapidPC As System.Windows.Forms.TextBox
    Friend WithEvents txtRapidCounty As System.Windows.Forms.TextBox
    Friend WithEvents txtRapidCity As System.Windows.Forms.TextBox
    Friend WithEvents txtRapidAL2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRapidAL1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRapidPostCode As System.Windows.Forms.TextBox
    Friend WithEvents btnRapidGetAddresses As System.Windows.Forms.Button

End Class
