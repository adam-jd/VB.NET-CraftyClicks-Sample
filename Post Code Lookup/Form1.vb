Imports System.Xml
Imports System.IO
Imports System.Web
Imports System.Net
Imports Newtonsoft.Json

Public Class Form1

    Private addressList As New List(Of clsAddress)


    Private Sub btnGetAddress_Click(sender As Object, e As EventArgs) Handles btnGetAddress.Click

        Me.ClearBasicControls()

        'Retrieve and set a post code value to a variable.
        Dim postCodeHolder As String
        postCodeHolder = Me.txtBasicPostCode.Text

        Dim url As String =
              String.Format("http://pcls1.craftyclicks.co.uk/json/basicaddress?postcode={0}&response=data_formatted",
                  postCodeHolder)

        'Complete XML HTTP Request
        Dim request As HttpWebRequest = WebRequest.Create(url)
        'Complete XML HTTP Response
        Dim response As HttpWebResponse = request.GetResponse
        'Declare and set a stream reader to read the returned XML
        Dim reader As New StreamReader(response.GetResponseStream)


        ' Get the requests json object and convert it to in memory dynamic
        ' Note: that you are able to convert to a specific object if required.

        Dim data As String = reader.ReadToEnd()

        Dim jsonResponseObject = JsonConvert.DeserializeObject(Of JsonNode)(data)

        '' check that there are thoroughfare
        If (jsonResponseObject.thoroughfare_count > 0) Then

            ''If the node list contains address nodes then move on.
            Dim i As Integer = 0
            For Each node As Object In jsonResponseObject.thoroughfares


                Dim clsAddress As clsAddress = New clsAddress()
                clsAddress.AddressID = i
                clsAddress.AddressLine1 = node.line_1
                clsAddress.AddressLine2 = node.line_2
                clsAddress.County = jsonResponseObject.postal_county
                clsAddress.PostCode = jsonResponseObject.postcode
                clsAddress.Town = jsonResponseObject.town

                addressList.Add(clsAddress)
                i = i + 1
            Next

            Me.DisplayAddressDetails()

        Else

            Dim error_jsonResponseObject = JsonConvert.DeserializeObject(Of JsonErrorNode)(data)

        

            Select Case (error_jsonResponseObject.error_code)

                Case "0001"
                    MessageBox.Show("Post Code not found")

                Case "0002"
                    MessageBox.Show("Invalid Post Code format")

                Case "7001"
                    MessageBox.Show("Demo limit exceeded")

                Case "8001"
                    MessageBox.Show("Invalid or no access token")

                Case "8003"
                    MessageBox.Show("Account credit allowance exceeded")

                Case "8004"
                    MessageBox.Show("Access denied due to access rules")

                Case "8005"
                    MessageBox.Show("Access denied, account suspended")

                Case "9001"
                    MessageBox.Show("Internal server error")

                Case Else
                    MessageBox.Show(error_jsonResponseObject.error_msg)
            End Select



        End If

    End Sub

    Private Sub DisplayAddressDetails()

        Me.txtBasicAL1.Text = addressList.Item(0).AddressLine1
        Me.txtBasicAL2.Text = addressList.Item(0).AddressLine2
        Me.txtBasicCity.Text = addressList.Item(0).Town
        Me.txtBasicCounty.Text = addressList.Item(0).County
        Me.txtBasicPC.Text = addressList.Item(0).PostCode

    End Sub

    Private Sub ClearBasicControls()

        Me.txtBasicHouseNo.Text = ""
        Me.txtBasicAL1.Text = ""
        Me.txtBasicAL2.Text = ""
        Me.txtBasicCity.Text = ""
        Me.txtBasicCounty.Text = ""
        Me.txtBasicPC.Text = ""

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRapidGetAddresses_Click(sender As Object, e As EventArgs) Handles btnRapidGetAddresses.Click

        Me.ClearRapidControls()

        'Retrieve and set a post code value to a variable.
        Dim postCodeHolder As String
        postCodeHolder = Me.txtRapidPostCode.Text

        Dim url =
             String.Format("http://pcls1.craftyclicks.co.uk/json/rapidaddress?postcode={0}&response=data_formatted&lines=2",
                 postCodeHolder)


        'Complete XML HTTP Request
        Dim request As HttpWebRequest = WebRequest.Create(url)
         
        ''Complete XML HTTP Response
        Dim response As WebResponse = request.GetResponse()

        ''Declare and set a stream reader to read the returned XML
        Dim reader As StreamReader = New StreamReader(response.GetResponseStream())

        '' Get the requests json object and convert it to in memory dynamic
        '' Note: that you are able to convert to a specific object if required.
        ''   Dim jsonResponseObject = JsonConvert.DeserializeObject(reader.ReadToEnd())


        Dim data As String = reader.ReadToEnd()

        Dim jsonResponseObject = JsonConvert.DeserializeObject(Of JsonRapidNode)(data)

        '' check that there are delivery points
        If (jsonResponseObject.delivery_point_count > 0) Then


            ''If the node list contains address nodes then move on.
            Dim i As Integer = 0
            For Each node As Object In jsonResponseObject.delivery_points

                Dim address = New clsAddress()

                address.AddressID = i
                address.AddressLine1 = node.line_1
                address.AddressLine2 = node.line_2
                address.County = jsonResponseObject.postal_county
                address.PostCode = jsonResponseObject.postcode
                address.Town = jsonResponseObject.town
                addressList.Add(address)
                i = i + 1
            Next

            Me.LoadAddressListIntoDropDown()

        Else

            ''If no node details, there will be an error message. 

            Dim error_jsonResponseObject = JsonConvert.DeserializeObject(Of JsonErrorNode)(data)

            ''Get the details of the error message and return it the user.
            Select Case error_jsonResponseObject.error_code

                Case "0001"
                    MessageBox.Show("Post Code not found")

                Case "0002"
                    MessageBox.Show("Invalid Post Code format")

                Case "7001"
                    MessageBox.Show("Demo limit exceeded")

                Case "8001"
                    MessageBox.Show("Invalid or no access token")

                Case "8003"
                    MessageBox.Show("Account credit allowance exceeded")

                Case "8004"
                    MessageBox.Show("Access denied due to access rules")

                Case "8005"
                    MessageBox.Show("Access denied, account suspended")

                Case "9001"
                    MessageBox.Show("Internal server error")

                Case Else
                    MessageBox.Show(error_jsonResponseObject.error_msg)

            End Select

        End If
      

    End Sub

    Private Sub ClearRapidControls()

        Me.txtRapidAL1.Text = ""
        Me.txtRapidAL2.Text = ""
        Me.txtRapidCity.Text = ""
        Me.txtRapidCounty.Text = ""
        Me.txtRapidPC.Text = ""

    End Sub

    Private Sub LoadAddressListIntoDropDown()

        Me.cboAddressList.Items.Clear()
        Me.cboAddressList.DisplayMember = "AddressLine1"
        Me.cboAddressList.ValueMember = "AddressID"
        Me.cboAddressList.DataSource = addressList

    End Sub

    Private Sub cboAddressList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAddressList.SelectedIndexChanged

        Dim i As Integer = Me.cboAddressList.SelectedValue

        Me.txtRapidAL1.Text = addressList.Item(i).AddressLine1
        Me.txtRapidAL2.Text = addressList.Item(i).AddressLine2
        Me.txtRapidCity.Text = addressList.Item(i).Town
        Me.txtRapidCounty.Text = addressList.Item(i).County
        Me.txtRapidPC.Text = addressList.Item(i).PostCode

    End Sub
End Class
