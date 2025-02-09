Public Class VoteInformation
    Public Property PresidentLabel As String
    Public Property VicePresidentLabel As String
    Public Property FinanceLabel As String
    Public Property ActivitiesLabel As String
    Public Property ComnMarketLabel As String
    Public Property DocuLabel As String

    Private Sub VoteInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelPresident.Text = PresidentLabel
        LabelVicePresident.Text = VicePresidentLabel
        LabelFinance.Text = FinanceLabel
        LabelActivities.Text = ActivitiesLabel
        LabelComnMarket.Text = ComnMarketLabel
        LabelDocu.Text = DocuLabel


    End Sub



    Private Sub LogoutUser()
        Me.Close()
        VotingLoginpanel.Show()
    End Sub
End Class
