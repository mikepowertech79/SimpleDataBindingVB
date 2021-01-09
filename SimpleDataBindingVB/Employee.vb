' Developer - Sean Rhone
' Date Created - 01/26/2008
'
' General Description - Simple Employee class used for Business Object examples

Public Class Employee

#Region " Modular Variables "

    Private _FirstName As String
    Private _LastName As String
    Private _MiddleInitial As String

    ' Employee Address Fields
    Private _Address1 As String
    Private _Address2 As String
    Private _City As String
    Private _State As String
    Private _ZipCode As String

    Private _Manager As Guid

#End Region

#Region " Constructors "

    Public Sub New()

    End Sub

#End Region

#Region " Public Properties "

    ''' <summary>
    ''' Property to hold the first name of the employee
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>Employees first name</returns>
    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _FirstName = value
            Console.WriteLine("Property {0} has been changed.", "FirstName")
        End Set
    End Property

    ''' <summary>
    ''' Property to hold the last name of the employee
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>Employees last name</returns>
    Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(ByVal value As String)
            _LastName = value
            Console.WriteLine("Property {0} has been changed.", "LastName")
        End Set
    End Property

    ''' <summary>
    ''' Property to hold the middle initial of the employee
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>Employees middle initial</returns>
    Public Property MiddleInitial() As String
        Get
            Return _MiddleInitial
        End Get
        Set(ByVal value As String)
            _MiddleInitial = value
            Console.WriteLine("Property {0} has been changed.", "MiddleInitial")
        End Set
    End Property

    ''' <summary>
    ''' Property to hold the employees address
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>Employees first address field</returns>
    ''' <remarks></remarks>
    Public Property Address1() As String
        Get
            Return _Address1
        End Get
        Set(ByVal value As String)
            _Address1 = value
            Console.WriteLine("Property {0} has been changed.", "Address1")
        End Set
    End Property

    ''' <summary>
    ''' Property to hold the employees address
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>Employees second ddress field</returns>
    ''' <remarks></remarks>
    Public Property Address2() As String
        Get
            Return _Address2
        End Get
        Set(ByVal value As String)
            _Address2 = value
            Console.WriteLine("Property {0} has been changed.", "Address2")
        End Set
    End Property

    ''' <summary>
    ''' Property to hold the employees city
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>Employees city</returns>
    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            _City = value
            Console.WriteLine("Property {0} has been changed.", "City")
        End Set
    End Property

    ''' <summary>
    ''' Property to hold the employees state
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>Employees tate</returns>
    Public Property State() As String
        Get
            Return _State
        End Get
        Set(ByVal value As String)
            _State = value
            Console.WriteLine("Property {0} has been changed.", "State")
        End Set
    End Property

    ''' <summary>
    ''' Property to hold the employees zip code
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>Employees zip code</returns>
    Public Property ZipCode() As String
        Get
            Return _ZipCode
        End Get
        Set(ByVal value As String)
            _ZipCode = value
            Console.WriteLine("Property {0} has been changed.", "ZipCode")
        End Set
    End Property

    ''' <summary>
    ''' Holds employees managers ID
    ''' </summary>
    ''' <value>Guid</value>
    ''' <returns>Employees managers Guid</returns>
    Public Property Manager() As Guid
        Get
            Return _Manager
        End Get
        Set(ByVal value As Guid)
            _Manager = value
            Console.WriteLine("Property {0} has been changed.", "Manager")
        End Set
    End Property

#End Region

End Class
