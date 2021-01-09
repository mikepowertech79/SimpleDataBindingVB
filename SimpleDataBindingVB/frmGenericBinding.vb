' This import is needed so we do not need to user the Fully Qualified Name (FQN) for BindingList
Imports System.ComponentModel



'source https :  //www.codeproject.com/Articles/23222/BindingList-Example



Public Class frmGenericBinding

#Region " Modular Variables "

    ' Provides generic collection data binding. Notice that we are specifying 
    ' the type of object that is allowed to be added to the BindingList
    Private moEmployeeBindingList As BindingList(Of Employee)

#End Region

#Region " Constructors "

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Instantiate the needed BindingList
        moEmployeeBindingList = New BindingList(Of Employee)

    End Sub

#End Region

#Region " Private Methods "

    ''' <summary>
    ''' This method will create 50 new employees and add them to the BindList
    ''' </summary>
    Private Sub PopulateBindingList()
        Dim oEmployee As Employee

        ' Create some Employees
        For nCnt As Integer = 1 To 50
            oEmployee = New Employee

            ' Create a employee first/last name using the counter
            oEmployee.FirstName = "Employee_" & nCnt.ToString
            oEmployee.LastName = "Last_" & nCnt.ToString
            oEmployee.MiddleInitial = "A"

            ' Create a employee street address using the counter
            oEmployee.Address1 = "12" & nCnt.ToString() & " Happy Street"
            oEmployee.City = "Charlotte"
            oEmployee.State = "NC"
            oEmployee.ZipCode = "28211"

            ' Create a manager id
            oEmployee.Manager = Guid.NewGuid

            ' Add new employee to the BindingList
            moEmployeeBindingList.Add(oEmployee)
        Next

    End Sub

#End Region

    Private Sub btnLoadEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadEmployees.Click
        PopulateBindingList()

        ' Bind the BindingList of Employee objects to the DataGridView
        Me.dgvEmployees.DataSource = moEmployeeBindingList
    End Sub

End Class
