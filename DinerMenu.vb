Public Class DinerMenu
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DescriptionofFoodLabel.Text = "Fresh piping tomatoe soup tastier than a gourmet feast of King Louis II," _
                                        & " enjoy this spicey treat while you can as it is only available for a limited time!"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DescriptionofFoodLabel.Text = "The salad of the day is a cesar salad fresh with any choice of ranch, sunflower seeds, " _
                                        & " pepperoni, ham,  vinegrete, or blue cheese. "
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DescriptionofFoodLabel.Text = "The fish of the day is an alaskan salmon smoked, served with lemon and bread. "
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
