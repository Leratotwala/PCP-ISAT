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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.mtbTelNo = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSmartphone = New System.Windows.Forms.RadioButton()
        Me.radTablet = New System.Windows.Forms.RadioButton()
        Me.radLaptop = New System.Windows.Forms.RadioButton()
        Me.radDesktopComputer = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkUSB = New System.Windows.Forms.CheckBox()
        Me.chkKeyboard = New System.Windows.Forms.CheckBox()
        Me.chkWirelessMouse = New System.Windows.Forms.CheckBox()
        Me.chkLaptopBag = New System.Windows.Forms.CheckBox()
        Me.lstQoute = New System.Windows.Forms.ListBox()
        Me.btnWriteto = New System.Windows.Forms.Button()
        Me.btnReadto = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnQoute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Surname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer Tel No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Customer Email:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(131, 246)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(190, 22)
        Me.txtName.TabIndex = 4
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(151, 171)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(170, 22)
        Me.txtSurname.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(126, 361)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(195, 22)
        Me.txtEmail.TabIndex = 6
        '
        'mtbTelNo
        '
        Me.mtbTelNo.Location = New System.Drawing.Point(136, 310)
        Me.mtbTelNo.Mask = "(999) 000-0000"
        Me.mtbTelNo.Name = "mtbTelNo"
        Me.mtbTelNo.Size = New System.Drawing.Size(185, 22)
        Me.mtbTelNo.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSmartphone)
        Me.GroupBox1.Controls.Add(Me.radTablet)
        Me.GroupBox1.Controls.Add(Me.radLaptop)
        Me.GroupBox1.Controls.Add(Me.radDesktopComputer)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 422)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 220)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MainProduct"
        '
        'radSmartphone
        '
        Me.radSmartphone.AutoSize = True
        Me.radSmartphone.Location = New System.Drawing.Point(15, 184)
        Me.radSmartphone.Name = "radSmartphone"
        Me.radSmartphone.Size = New System.Drawing.Size(106, 21)
        Me.radSmartphone.TabIndex = 3
        Me.radSmartphone.TabStop = True
        Me.radSmartphone.Text = "Smartphone"
        Me.radSmartphone.UseVisualStyleBackColor = True
        '
        'radTablet
        '
        Me.radTablet.AutoSize = True
        Me.radTablet.Location = New System.Drawing.Point(15, 126)
        Me.radTablet.Name = "radTablet"
        Me.radTablet.Size = New System.Drawing.Size(69, 21)
        Me.radTablet.TabIndex = 2
        Me.radTablet.TabStop = True
        Me.radTablet.Text = "Tablet"
        Me.radTablet.UseVisualStyleBackColor = True
        '
        'radLaptop
        '
        Me.radLaptop.AutoSize = True
        Me.radLaptop.Location = New System.Drawing.Point(15, 42)
        Me.radLaptop.Name = "radLaptop"
        Me.radLaptop.Size = New System.Drawing.Size(73, 21)
        Me.radLaptop.TabIndex = 1
        Me.radLaptop.TabStop = True
        Me.radLaptop.Text = "Laptop"
        Me.radLaptop.UseVisualStyleBackColor = True
        '
        'radDesktopComputer
        '
        Me.radDesktopComputer.AutoSize = True
        Me.radDesktopComputer.Location = New System.Drawing.Point(15, 88)
        Me.radDesktopComputer.Name = "radDesktopComputer"
        Me.radDesktopComputer.Size = New System.Drawing.Size(146, 21)
        Me.radDesktopComputer.TabIndex = 0
        Me.radDesktopComputer.TabStop = True
        Me.radDesktopComputer.Text = "Desktop Computer"
        Me.radDesktopComputer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkUSB)
        Me.GroupBox2.Controls.Add(Me.chkKeyboard)
        Me.GroupBox2.Controls.Add(Me.chkWirelessMouse)
        Me.GroupBox2.Controls.Add(Me.chkLaptopBag)
        Me.GroupBox2.Location = New System.Drawing.Point(327, 422)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 220)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accessories"
        '
        'chkUSB
        '
        Me.chkUSB.AutoSize = True
        Me.chkUSB.Location = New System.Drawing.Point(21, 184)
        Me.chkUSB.Name = "chkUSB"
        Me.chkUSB.Size = New System.Drawing.Size(133, 21)
        Me.chkUSB.TabIndex = 3
        Me.chkUSB.Text = "USB Flash Drive"
        Me.chkUSB.UseVisualStyleBackColor = True
        '
        'chkKeyboard
        '
        Me.chkKeyboard.AutoSize = True
        Me.chkKeyboard.Location = New System.Drawing.Point(21, 126)
        Me.chkKeyboard.Name = "chkKeyboard"
        Me.chkKeyboard.Size = New System.Drawing.Size(91, 21)
        Me.chkKeyboard.TabIndex = 2
        Me.chkKeyboard.Text = "Keyboard"
        Me.chkKeyboard.UseVisualStyleBackColor = True
        '
        'chkWirelessMouse
        '
        Me.chkWirelessMouse.AutoSize = True
        Me.chkWirelessMouse.Location = New System.Drawing.Point(21, 88)
        Me.chkWirelessMouse.Name = "chkWirelessMouse"
        Me.chkWirelessMouse.Size = New System.Drawing.Size(130, 21)
        Me.chkWirelessMouse.TabIndex = 1
        Me.chkWirelessMouse.Text = "Wireless Mouse"
        Me.chkWirelessMouse.UseVisualStyleBackColor = True
        '
        'chkLaptopBag
        '
        Me.chkLaptopBag.AutoSize = True
        Me.chkLaptopBag.Location = New System.Drawing.Point(21, 42)
        Me.chkLaptopBag.Name = "chkLaptopBag"
        Me.chkLaptopBag.Size = New System.Drawing.Size(103, 21)
        Me.chkLaptopBag.TabIndex = 0
        Me.chkLaptopBag.Text = "Laptop Bag"
        Me.chkLaptopBag.UseVisualStyleBackColor = True
        '
        'lstQoute
        '
        Me.lstQoute.FormattingEnabled = True
        Me.lstQoute.ItemHeight = 16
        Me.lstQoute.Location = New System.Drawing.Point(665, 80)
        Me.lstQoute.Name = "lstQoute"
        Me.lstQoute.Size = New System.Drawing.Size(517, 548)
        Me.lstQoute.TabIndex = 10
        '
        'btnWriteto
        '
        Me.btnWriteto.Location = New System.Drawing.Point(15, 652)
        Me.btnWriteto.Name = "btnWriteto"
        Me.btnWriteto.Size = New System.Drawing.Size(75, 23)
        Me.btnWriteto.TabIndex = 11
        Me.btnWriteto.Text = "Write to.."
        Me.btnWriteto.UseVisualStyleBackColor = True
        '
        'btnReadto
        '
        Me.btnReadto.Location = New System.Drawing.Point(126, 652)
        Me.btnReadto.Name = "btnReadto"
        Me.btnReadto.Size = New System.Drawing.Size(75, 23)
        Me.btnReadto.TabIndex = 12
        Me.btnReadto.Text = "Read to.."
        Me.btnReadto.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(258, 652)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSort.TabIndex = 13
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(388, 652)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(978, 652)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnQoute
        '
        Me.btnQoute.Location = New System.Drawing.Point(723, 652)
        Me.btnQoute.Name = "btnQoute"
        Me.btnQoute.Size = New System.Drawing.Size(75, 23)
        Me.btnQoute.TabIndex = 16
        Me.btnQoute.Text = "Qoute"
        Me.btnQoute.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(858, 652)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp20.My.Resources.Resources.technova_imaging_systems_p_ltd_logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(342, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(374, 32)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "TECHNOVA DIGITAL PRO"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(558, 652)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(88, 31)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 687)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnQoute)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnReadto)
        Me.Controls.Add(Me.btnWriteto)
        Me.Controls.Add(Me.lstQoute)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mtbTelNo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "0402201481080"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbTelNo As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSmartphone As RadioButton
    Friend WithEvents radTablet As RadioButton
    Friend WithEvents radLaptop As RadioButton
    Friend WithEvents radDesktopComputer As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkUSB As CheckBox
    Friend WithEvents chkKeyboard As CheckBox
    Friend WithEvents chkWirelessMouse As CheckBox
    Friend WithEvents chkLaptopBag As CheckBox
    Friend WithEvents lstQoute As ListBox
    Friend WithEvents btnWriteto As Button
    Friend WithEvents btnReadto As Button
    Friend WithEvents btnSort As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnQoute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUpdate As Button
End Class
