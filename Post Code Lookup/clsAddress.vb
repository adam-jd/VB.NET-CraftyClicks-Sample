Public Class clsAddress

    Private mAddressID As Integer
    Private mAddressLine1 As String
    Private mAddressLine2 As String
    Private mTown As String
    Private mCounty As String
    Private mPostCode As String

    Public Sub New()

    End Sub

    Public Property AddressID() As Integer
        Get
            Return mAddressID
        End Get
        Set(value As Integer)
            mAddressID = value
        End Set
    End Property


    Public Property AddressLine1() As String
        Get
            Return mAddressLine1
        End Get
        Set(value As String)
            mAddressLine1 = value
        End Set
    End Property

    Public Property AddressLine2() As String
        Get
            Return mAddressLine2
        End Get
        Set(value As String)
            mAddressLine2 = value
        End Set
    End Property

    Public Property Town() As String
        Get
            Return mTown
        End Get
        Set(value As String)
            mTown = value
        End Set
    End Property

    Public Property County() As String
        Get
            Return mCounty
        End Get
        Set(value As String)
            mCounty = value
        End Set
    End Property

    Public Property PostCode() As String
        Get
            Return mPostCode
        End Get
        Set(value As String)
            mPostCode = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return AddressLine1.ToString()
    End Function

End Class
