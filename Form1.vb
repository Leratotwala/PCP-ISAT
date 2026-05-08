Public Class Form1
    'Assiging file path to storage 
    Dim filePath As String = "TextFile1.txt"

    Dim customers As String

    Dim CustomersName(14) As String
    Dim CustomersSurnames(14) As String
    Dim CustomersTelNos(14) As String
    Dim CustomersEmails(14) As String

    Dim currentCustomerIndex As Integer = 0

    'DECLARING VARIABLES  
    Const decVatRate As Decimal = 0.15
    Dim intchkBoxes As Integer
    Dim decPromotionalDiscount As Decimal
    Dim decSubCost As Decimal
    Dim decVatAmount As Decimal
    Dim decTotalAmount As Decimal
    Dim decMainProduct As Decimal
    Dim decAccessories As Decimal

    Dim strSurname As String
    Dim strNames As String
    Dim strTelno As String
    Dim strEmail As String
    Dim strMainProduct As String
    Dim strAccessories As String

    Dim decLaptop As Decimal = 3500.0
    Dim decSmartphone As Decimal = 2500.0
    Dim decTablet As Decimal = 2000.0
    Dim decDesktopComputer As Decimal = 3600.0
    Dim decLaptopbag As Decimal = 350.0
    Dim decWirelessmouse As Decimal = 40.0
    Dim decUSBFlashDrive As Decimal = 125.0
    Dim decKeyboard As Decimal = 250.0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSurname.Enabled = True
        txtName.Enabled = False
        txtEmail.Enabled = False
        mtbTelNo.Enabled = False
        txtSurname.Focus()
    End Sub
    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged
        txtName.Enabled = True
    End Sub
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        mtbTelNo.Enabled = True
    End Sub

    Private Sub mtbTelno_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbTelNo.MaskInputRejected
        txtEmail.Enabled = True
    End Sub

    Function calcMainProduct(ByVal decMainProduct As Decimal) As Decimal

        'FUNCTION FOR CALCULATING TOTAL CELLPHONES
        If radLaptop.Checked = True Then
            decMainProduct = 3500.0
        ElseIf radDesktopComputer.Checked = True Then
            decMainProduct = 3600.0
        ElseIf radTablet.Checked = True Then
            decMainProduct = 2000.0
        ElseIf radSmartphone.Checked = True Then
            decMainProduct = 2500.0
        End If
        Return CDec(decMainProduct)
    End Function
    Function calcAccessories(ByVal decAccessories As Decimal) As Decimal
        'FUNCTION FOR CALCULATING ACCESSORIES
        If chkLaptopBag.Checked = True Then
            decAccessories += 350.0
        End If
        If chkWirelessMouse.Checked = True Then
            decAccessories += 40.0
        End If
        If chkKeyboard.Checked = True Then
            decAccessories += 250.0
        End If
        If chkUSB.Checked = True Then
            decAccessories += 125.0
        End If
        Return CDec(decAccessories)
    End Function

    Function calcPromotionalDiscount(ByVal decPromotionalDiscount As Decimal, ByVal decSubCost As Decimal) As Decimal
        'FUNCTION FOR CALCULATING PROMOTINAL DISCOUNT 
        If chkWirelessMouse.Checked = False Then
            intchkBoxes = 0
        ElseIf chkUSB.Checked = False Then
            intchkBoxes = 0
        ElseIf chkLaptopBag.Checked = False Then
            intchkBoxes = 0
        ElseIf chkKeyboard.Checked = False Then
            intchkBoxes = 0
        End If

        If chkWirelessMouse.Checked = True Then
            intchkBoxes = 1
        ElseIf chkUSB.Checked = True Then
            intchkBoxes = 1
        ElseIf chkLaptopBag.Checked = True Then
            intchkBoxes = 1
        ElseIf chkKeyboard.Checked = True Then
            intchkBoxes = 1
        End If

        If chkWirelessMouse.Checked = True And chkUSB.Checked = True Then
            intchkBoxes = 2
        ElseIf chkWirelessMouse.Checked = True And chkLaptopBag.Checked = True Then
            intchkBoxes = 2
        ElseIf chkWirelessMouse.Checked = True And chkKeyboard.Checked = True Then
            intchkBoxes = 2
        ElseIf chkUSB.Checked = True And chkKeyboard.Checked = True Then
            intchkBoxes = 2
        ElseIf chkUSB.Checked = True And chkLaptopBag.Checked = True Then
            intchkBoxes = 2
        ElseIf chkLaptopBag.Checked = True And chkKeyboard.Checked = True Then
            intchkBoxes = 2
        End If

        If chkUSB.Checked = True And chkKeyboard.Checked = True And chkWirelessMouse.Checked = True Then
            intchkBoxes = 3
        ElseIf chkUSB.Checked = True And chkKeyboard.Checked = True And chkLaptopBag.Checked = True Then
            intchkBoxes = 3
        ElseIf chkUSB.Checked = True And chkLaptopBag.Checked = True And chkWirelessMouse.Checked = True Then
            intchkBoxes = 3
        ElseIf chkKeyboard.Checked = True And chkKeyboard.Checked = True And chkWirelessMouse.Checked = True Then
            intchkBoxes = 3
        End If

        If radSmartphone.Checked And radLaptop.Checked And radDesktopComputer.Checked And radTablet.Checked And intchkBoxes = 0 Then
            decPromotionalDiscount = 0
        End If

        If radLaptop.Checked And intchkBoxes = 0 Then
            decPromotionalDiscount = 0
        End If
        If radLaptop.Checked And intchkBoxes = 1 Then
            decPromotionalDiscount = decSubCost * 0.04
        End If
        If radLaptop.Checked And intchkBoxes = 2 Then
            decPromotionalDiscount = decSubCost * 0.06
        End If

        If radDesktopComputer.Checked And chkWirelessMouse.Checked And chkLaptopBag.Checked Then
            decPromotionalDiscount = (40.0 + 3600.0 + 350.0) * 0.14
        End If

        If radTablet.Checked And intchkBoxes = 0 Then
            decPromotionalDiscount = 0
        End If
        If radTablet.Checked And intchkBoxes = 1 Then
            decPromotionalDiscount = decSubCost * 0.04
        End If
        If radTablet.Checked And intchkBoxes = 2 Then
            decPromotionalDiscount = decSubCost * 0.06
        End If

        If radSmartphone.Checked And intchkBoxes = 0 Then
            decPromotionalDiscount = 0
        End If
        If radSmartphone.Checked And intchkBoxes = 1 Then
            decPromotionalDiscount = decSubCost * 0.04
        End If
        If radSmartphone.Checked And intchkBoxes = 2 Then
            decPromotionalDiscount = decSubCost * 0.06
        End If

        Return CDec(decPromotionalDiscount)
    End Function
    Function calcSubCost(ByVal decMainProduct As Decimal, ByVal decAccessories As Decimal) As Decimal
        'FUNCTION FOR CALCULATING SUBCOST
        Dim decSubCost As Decimal
        decSubCost = decMainProduct + decAccessories
        Return CDec(decSubCost)
    End Function
    Function calcVatAmount(ByVal decVatAmount As Decimal, ByVal decSubCost As Decimal) As Decimal
        'FUNCTION FOR CALCULATING VAT
        If radLaptop.Checked = True Then
            decVatAmount = 3500.0 * 0.15
        ElseIf radDesktopComputer.Checked = True Then
            decVatAmount = 3600.0 * 0.15
        ElseIf radTablet.Checked = True Then
            decVatAmount = 2000.0 * 0.15
        ElseIf radSmartphone.Checked = True Then
            decVatAmount = 2500.0 * 0.15
        End If

        If chkLaptopBag.Checked = True Then
            decVatAmount = 3500.0 * 0.15
        End If
        If chkKeyboard.Checked = True Then
            decVatAmount = 250.0 * 0.15
        End If
        If chkUSB.Checked = True Then
            decVatAmount = 125.0 * 0.15
        End If
        If chkWirelessMouse.Checked = True Then
            decVatAmount = 40.0 * 0.15
        End If

        decVatAmount = decSubCost * decVatRate
        Return CDec(decVatAmount)
    End Function

    Function calcTotalAmount(ByVal decTotalAmount As Decimal) As Decimal
        'FUNCTION TO CALCULATE TOTALAMOUNT  
        If radLaptop.Checked = True Then
            decTotalAmount = 3500.0 + decVatAmount
        ElseIf radDesktopComputer.Checked = True Then
            decTotalAmount = 3600.0 + decVatAmount
        ElseIf radTablet.Checked = True Then
            decTotalAmount = 2000.0 + decVatAmount
        ElseIf radSmartphone.Checked = True Then
            decTotalAmount = 2500.0 + decVatAmount
        End If

        If chkLaptopBag.Checked = True Then
            decTotalAmount = 3500.0 + decVatAmount
        ElseIf chkWirelessMouse.Checked = True Then
            decTotalAmount = 40.0 + decVatAmount
        ElseIf chkKeyboard.Checked = True Then
            decTotalAmount = 250.0 + decVatAmount
        ElseIf chkUSB.Checked = True Then
            decTotalAmount = 125.0 + decVatAmount
        End If

        decTotalAmount = decMainProduct + decAccessories + decVatAmount - decPromotionalDiscount

        Return CDec(decTotalAmount)
    End Function

    Sub DisplayMainProduct(ByVal decCellphone As Decimal)
        'SUBROTINE FOR CELLPHONE DISPLAY 
        lstQoute.Text = decMainProduct.ToString("C2")
    End Sub

    Sub DisplayAccessories(ByVal decAccessories As Decimal)
        'SUBROTINE FOR ACCESSORIES DISPLAY
        lstQoute.Text = decAccessories.ToString("C2")
    End Sub
    Sub DisplaySubCost(ByVal decMainProduct As Decimal, ByVal decAccessories As Decimal, ByValdecSubCost As Decimal)
        'SUBROTINE FOR SUBCOST DISPLAY 
        lstQoute.Text = decSubCost.ToString("C2")
    End Sub

    Sub DisplayPromotinalDiscount(ByVal decPromotionalDiscount As Decimal)
        'SUBROTINE FOR PROMOTIONAL DISCOUNT DISPLAY 
        lstQoute.Text = decPromotionalDiscount.ToString("C2")
    End Sub
    Sub DisplayVatAmount(ByVal decVatAmount As Decimal)
        'SUBROTINE FOR VAT 
        lstQoute.Text = decVatAmount.ToString("C2")
    End Sub
    Sub DisplayTotalAmount(ByVal decTotalAmount As Decimal)
        'SUBROTINE FOR TOTALAMOUNT 
        lstQoute.Text = decTotalAmount.ToString("C2")
    End Sub



    Private Sub btnQuote_Click(sender As Object, e As EventArgs) Handles btnQoute.Click

        'DECLARING AND CONVERTING OF VARIABLES 
        Dim strSurname As String = txtSurname.Text
        Dim strName As String = txtName.Text
        Dim strEmail As String = txtEmail.Text
        Dim strTelno As String = mtbTelNo.Text
        Dim strMainProduct As String
        Dim strAccess As String

        Dim decMainProduct As Decimal
        Dim decAccessories As Decimal
        Dim decSubCost As Decimal
        Dim decPromotionalDiscount As Decimal
        Dim decVatAmount As Decimal
        Dim decTotalAmount As Decimal


        decMainProduct = calcMainProduct(decMainProduct)
        Call DisplayMainProduct(decMainProduct)
        decAccessories = calcAccessories(decAccessories)
        Call DisplayAccessories(decAccessories)
        decSubCost = calcSubCost(decMainProduct, decAccessories)
        Call DisplaySubCost(decMainProduct, decAccessories, decSubCost)
        decPromotionalDiscount = calcPromotionalDiscount(decPromotionalDiscount, decSubCost)
        Call DisplayPromotinalDiscount(decPromotionalDiscount)
        decVatAmount = calcVatAmount(decVatAmount, decSubCost)
        Call DisplayVatAmount(decVatAmount)


        decTotalAmount = calcTotalAmount(decTotalAmount)
        Call DisplayTotalAmount(decTotalAmount)

        If txtName.Text = "" Then
            MessageBox.Show("Please Enter Your Name")
            txtName.Focus()
        End If
        If txtSurname.Text = "" Then
            MessageBox.Show("Please Enter Your Surname")
            txtSurname.Focus()
        End If
        If mtbTelNo.Text = "" Then
            MessageBox.Show("Please Enter Your Telephone Number")
            mtbTelNo.Focus()
        End If
        If txtEmail.Text = "" Then
            MessageBox.Show("Please Enter Your Email Address")
            txtSurname.Focus()
        End If

        If radLaptop.Checked = True Then
            strMainProduct = "Laptop"
        End If
        If radSmartphone.Checked = True Then
            strMainProduct = "Smartphone"
        End If
        If radTablet.Checked = True Then
            strMainProduct = "Tablet"
        End If
        If radDesktopComputer.Checked = True Then
            strMainProduct = "Desktop Computer"
        End If

        If chkWirelessMouse.Checked = True Then
            strMainProduct += "Laptop Bag, "
        End If
        If chkUSB.Checked = True Then
            strAccess += "Wireless Mouse,"
        End If
        If chkLaptopBag.Checked = True Then
            strAccess += "Keyboard "
        End If
        If chkKeyboard.Checked = True Then
            strAccess += "& USB Flash Drive"
        End If

        'Display Quote
        lstQoute.Items.Add("QUOTE BY:    TECHNOVA DIGITAL PRO ")
        lstQoute.Items.Add("===================================================================")
        lstQoute.Items.Add("")
        lstQoute.Items.Add("Surname :                                               " & strSurname)
        lstQoute.Items.Add("Name    :                                               " & strName)
        lstQoute.Items.Add("TelNo   :                                               " & strTelno)
        lstQoute.Items.Add("Email   :                                               " & strEmail)
        lstQoute.Items.Add("===================================================================")
        lstQoute.Items.Add("")
        lstQoute.Items.Add("MainProduct :                                           " & strMainProduct)
        lstQoute.Items.Add("Accessories :                                           " & strAccess)
        lstQoute.Items.Add("===================================================================")
        lstQoute.Items.Add("")
        lstQoute.Items.Add("MainProduct Price :                                     " & decMainProduct.ToString("C2"))
        lstQoute.Items.Add("Accessories Price :                                     " & decAccessories.ToString("C2"))
        lstQoute.Items.Add("Combined Price    :                                     " & decSubCost.ToString("C2"))
        lstQoute.Items.Add("===================================================================")
        lstQoute.Items.Add(" ")
        lstQoute.Items.Add("Promotional Discount:                                   " & decPromotionalDiscount.ToString("C2"))
        lstQoute.Items.Add("Vat Amount          :                                   " & decVatAmount.ToString("C2"))
        lstQoute.Items.Add("=====================================================================")
        lstQoute.Items.Add("Total Amount:                                           " & decTotalAmount.ToString("C2"))
    End Sub

    Private Sub btnWriteto_Click(sender As Object, e As EventArgs) Handles btnWriteto.Click
        'Stores customer details into arrays and a file if within limit
        If currentCustomerIndex < CustomersSurnames.GetLength(0) Then
            CustomersSurnames(currentCustomerIndex) = txtSurname.Text
            CustomersName(currentCustomerIndex) = txtName.Text
            CustomersTelNos(currentCustomerIndex) = mtbTelNo.Text
            CustomersEmails(currentCustomerIndex) = txtEmail.Text
            currentCustomerIndex += 1
            Dim customersInfo As String = $"{txtSurname.Text}, {txtName.Text},  {mtbTelNo.Text}, {txtEmail.Text}"

            If IO.File.Exists(filePath) = True Then
                IO.File.AppendAllText(filePath, customersInfo & Environment.NewLine)
            Else
                IO.File.WriteAllLines(filePath, {customersInfo})
            End If
        Else
            MessageBox.Show("Customer Array has reached its limit.")

        End If
        lstQoute.Items.Clear()
        txtSurname.Clear()
        txtName.Clear()
        txtEmail.Clear()
        mtbTelNo.Clear()
        txtSurname.Enabled = True
        txtName.Enabled = False
        txtEmail.Enabled = False
        mtbTelNo.Enabled = False
        txtSurname.Focus()
    End Sub


    Private Sub btnReadto_Click(sender As Object, e As EventArgs) Handles btnReadto.Click
        'loads customer data from a file into arrays then displays the data in a list, Or shows an error if the file Is missing. 

        If IO.File.Exists(filePath) = True Then
            Dim lines() As String = IO.File.ReadAllLines(filePath)
            Array.Clear(CustomersSurnames, 0, CustomersSurnames.Length)
            Array.Clear(CustomersName, 0, CustomersName.Length)
            Array.Clear(CustomersTelNos, 0, CustomersTelNos.Length)
            Array.Clear(CustomersEmails, 0, CustomersEmails.Length)
            currentCustomerIndex = 0
            For Each line As String In lines
                If currentCustomerIndex < CustomersSurnames.GetLength(0) Then
                    Dim parts() As String = line.Split(", ")
                    If parts.Length = 4 Then
                        CustomersSurnames(currentCustomerIndex) = parts(0)
                        CustomersName(currentCustomerIndex) = parts(1)
                        CustomersTelNos(currentCustomerIndex) = parts(2)
                        CustomersEmails(currentCustomerIndex) = parts(3)
                        currentCustomerIndex += 1
                    End If
                Else
                    Exit For
                End If
            Next
        End If
        lstQoute.Items.Clear()
        For i As Integer = 0 To currentCustomerIndex - 1
            lstQoute.Items.Add($"{CustomersSurnames(i)}, {CustomersName(i)},{CustomersTelNos(i)}, {CustomersEmails(i)}")
        Next
        MessageBox.Show("File not found.")
    End Sub

    Function GetFormattedCustomerInfo(surname As String, name As String, telno As String, email As String) As String

        'This function returns a formatted customer string and (incorrectly) also adds all customer records to the list each time it's called  
        For i As Integer = 0 To currentCustomerIndex - 1
            lstQoute.Items.Add(GetFormattedCustomerInfo(CustomersSurnames(i), CustomersName(i), CustomersTelNos(i), CustomersEmails(i)))

        Next
        Return $"{surname}, {name}, {telno}, {email}"
    End Function

    Sub BubbleSortAscending(ByRef surnames() As String, ByRef names() As String, ByRef telNos() As String, ByRef emails() As String, ByVal count As Integer)


        'sorts parallel arrays of customer data alphabetically  using the Bubble  


        '  Sort algorithm making all related fields are aligned 

        Dim i, j As Integer
        For i = 0 To count - 2
            For j = 0 To count - i - 2

                If surnames(j) > surnames(j + 1) Then
                    'Swap surnames 
                    Dim tempSurname As String = surnames(j)
                    surnames(j) = surnames(j + 1)
                    surnames(j + 1) = tempSurname
                    'swap names 
                    Dim tempName As String = names(j)
                    names(j) = names(j + 1)
                    names(j + 1) = tempName

                    'swap telephone numbers 
                    Dim tempTel As String = telNos(j)
                    telNos(j) = telNos(j + 1)
                    telNos(j + 1) = tempTel

                    'swap Emails 
                    Dim tempEmail As String = emails(j)
                    emails(j) = emails(j + 1)
                    emails(j + 1) = tempEmail
                End If

            Next
        Next
    End Sub


    Private Sub WriteCustomersToFile(CustomersSurnames() As String, customersName() As String, customersTelnos() As String, customersEmails() As String, ByVal length As Integer, filePath As String)
        'writes all customer data from arrays into a file as comma-separated lines 
        Dim lines As New List(Of String)

        For i As Integer = 0 To currentCustomerIndex - 1
            Dim line As String = CustomersSurnames(i) & "," & customersName(i) & "," & customersTelnos(i) & "," & customersEmails(i)

            lines.Add(line)
        Next

        IO.File.WriteAllLines(filePath, lines)
    End Sub


    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        'it sorts customer details it by surname, updates the display list, saves it to a file, or shows a message if no data is present. 

        If currentCustomerIndex > 0 Then
            BubbleSortAscending(CustomersSurnames, CustomersName, CustomersTelNos, CustomersEmails, currentCustomerIndex)

            lstQoute.Items.Clear()
            For i As Integer = 0 To currentCustomerIndex - 1
                lstQoute.Items.Add($"{CustomersSurnames(i)}, {CustomersName(i)}, {CustomersTelNos(i)}, {CustomersEmails(i)}")
            Next
            WriteCustomersToFile(CustomersSurnames, CustomersName, CustomersTelNos, CustomersEmails, currentCustomerIndex, filePath)

        Else
            MessageBox.Show("No customers found")
        End If

    End Sub

    Function IsValidPhoneNumber(phone As String) As Boolean
        ' Only allows to 10 digits, with optional + at the start 
        Dim cleaned As String = phone.Replace(" ", "").Replace("-", "")
        If cleaned.StartsWith("+") Then cleaned = cleaned.Substring(1)
        Return cleaned.All(AddressOf Char.IsDigit) AndAlso cleaned.Length >= 10
    End Function

    Function IsValidEmail(email As String) As Boolean
        Return email.Contains("@") AndAlso email.Contains(".") AndAlso email.Length > 5
    End Function
    Function IsValidIDno(id As String) As Boolean
        Return id.Length = 13 AndAlso id.All(AddressOf Char.IsDigit)
    End Function

    Function IsValidAddress(address As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(address)
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'CLEARING ALL HANDLES 
        txtName.Clear()
        txtEmail.Clear()
        txtSurname.Clear()
        mtbTelNo.Clear()
        radSmartphone.Checked = False
        radLaptop.Checked = False
        radDesktopComputer.Checked = False
        radTablet.Checked = False
        chkWirelessMouse.Checked = False
        chkUSB.Checked = False
        chkKeyboard.Checked = False
        chkLaptopBag.Checked = False
        lstQoute.Items.Clear()
        txtSurname.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'EXITING PROGRAM 
        Dim strCaption As String = "TechNova Digital Pro"
        Dim strMessage As String = "Are you sure you want to exit"
        Dim diaResults As DialogResult
        diaResults = MessageBox.Show(strMessage, strCaption,
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If diaResults = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchSurname As String = InputBox("Enter the surname to search for:", "Search 
Customer").Trim()

        ' Defensive check: Makng sure input is not empty 
        If String.IsNullOrWhiteSpace(searchSurname) Then
            MessageBox.Show("Surname cannot be empty. Please enter a valid surname.", "Input 
Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim found As Boolean = False
        lstQoute.Items.Clear()

        Try
            ' Defensive check 
            If IO.File.Exists(filePath) Then
                Dim lines() As String = IO.File.ReadAllLines(filePath)

                For Each line As String In lines

                    If String.IsNullOrWhiteSpace(line) Then Continue For

                    Dim parts() As String = line.Split(",")


                    If parts.Length = 6 Then
                        If String.Equals(parts(0).Trim(), searchSurname,
StringComparison.OrdinalIgnoreCase) Then
                            lstQoute.Items.Add(String.Join(",", parts))
                            found = True
                        End If
                    Else


                        Continue For
                    End If
                Next
            Else
                MessageBox.Show("Customer file not found.", "File Error",
MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            If Not found Then
                MessageBox.Show("Customer with surname '" & searchSurname & "' not found.",
"Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Defensive programming and validation together 
        Try
            Dim searchSurname As String = InputBox("Enter the surname of the customer you want to update:", "Update Customer").Trim
            If String.IsNullOrWhiteSpace(searchSurname) Then
                MessageBox.Show("Surname cannot be empty.")
                Exit Sub
            End If

            Dim updated As Boolean = False

            If IO.File.Exists(filePath) Then
                Dim lines As New List(Of String)(IO.File.ReadAllLines(filePath))

                For i As Integer = 0 To lines.Count - 1
                    Dim parts() As String = lines(i).Split(","c).Select(Function(p) p.Trim().ToArray())


                    If parts.Length = 6 AndAlso String.Equals(parts(0), searchSurname, StringComparison.OrdinalIgnoreCase) Then
                        ' Prompt for new values with validation 
                        Dim newName As String = ""
                        Do
                            newName = InputBox("Enter new name:", "Update Name", parts(1)).Trim
                            If String.IsNullOrWhiteSpace(newName) Then
                                MessageBox.Show("Name cannot be empty.")
                            End If
                        Loop While String.IsNullOrWhiteSpace(newName)


                        Dim newTel As String = ""
                        Do
                            newTel = InputBox("Enter new telephone number:", "Update Telephone", parts(2)).Trim

                            If Not IsValidPhoneNumber(newTel) Then
                                MessageBox.Show("Invalid telephone number. It must be 10 digits.")

                            End If
                        Loop While Not IsValidPhoneNumber(newTel)


                        Dim newEmail As String = ""
                        Do
                            newEmail = InputBox("Enter new email:", "Update Email", parts(3)).Trim
                            If Not IsValidEmail(newEmail) Then
                                MessageBox.Show("Invalid email format.")
                            End If
                        Loop While Not IsValidEmail(newEmail)


                        Dim newIDno As String = ""
                        Do
                            newIDno = InputBox("Enter new ID number:", "Update ID Number", parts(4)).Trim
                            If Not IsValidIDno(newIDno) Then
                                MessageBox.Show("Invalid ID number.")
                            End If
                        Loop While Not IsValidIDno(newIDno)


                        Dim newAddress As String = ""
                        Do
                            newAddress = InputBox("Enter new address (Town or City):", "Update Address", parts(5)).Trim()

                            If Not IsValidAddress(newAddress) Then
                                MessageBox.Show("Invalid address. Enter a valid town or city")
                            End If
                        Loop While Not IsValidAddress(newAddress)

                        lines(i) = String.Join(", ", {parts(0), newName, newTel, newEmail, newIDno, newAddress})
                        updated = True
                        Exit For
                    End If
                Next

                If updated Then
                    IO.File.WriteAllLines(filePath, lines)
                    MessageBox.Show("Customer information updated successfully.")
                Else
                    MessageBox.Show("Customer not found.")
                End If
            Else
                MessageBox.Show("Customer file not found.")
            End If

        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message)
        End Try
    End Sub

End Class

