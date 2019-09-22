Public Class mainFrame
    Dim total As Double

    Private Sub foodsButton_Click(sender As Object, e As EventArgs) Handles foodsButton.Click
        onFoodsButtonPanel.Height = foodsButton.Height
        onFoodsButtonPanel.Top = foodsButton.Top
        foodMenuPanel.Visible = True
        drinkMenuPanel.Visible = False
        desertMenuPanel.Visible = False
        aboutUsPanel.Visible = False
        myCartPanel.Visible = False
    End Sub

    Private Sub drinksButton_Click(sender As Object, e As EventArgs) Handles drinksButton.Click
        onDrinksButtonPanel.Height = drinksButton.Height
        onDrinksButtonPanel.Top = drinksButton.Top
        foodMenuPanel.Visible = False
        drinkMenuPanel.Visible = True
        desertMenuPanel.Visible = False
        aboutUsPanel.Visible = False
        myCartPanel.Visible = False
    End Sub

    Private Sub desertButton_Click(sender As Object, e As EventArgs) Handles desertButton.Click
        onDesertButtonPanel.Height = desertButton.Height
        onDesertButtonPanel.Top = desertButton.Top
        foodMenuPanel.Visible = False
        drinkMenuPanel.Visible = False
        desertMenuPanel.Visible = True
        aboutUsPanel.Visible = False
        myCartPanel.Visible = False
    End Sub

    Private Sub cartButton_Click(sender As Object, e As EventArgs) Handles cartButton.Click
        onCartButtonPanel.Height = cartButton.Height
        onCartButtonPanel.Top = cartButton.Top
        foodMenuPanel.Visible = False
        drinkMenuPanel.Visible = False
        desertMenuPanel.Visible = False
        aboutUsPanel.Visible = False
        myCartPanel.Visible = True
    End Sub

    Private Sub aboutUsButton_Click(sender As Object, e As EventArgs) Handles aboutUsButton.Click
        onAboutUsButtonPanel.Height = aboutUsButton.Height
        onAboutUsButtonPanel.Top = aboutUsButton.Top
        foodMenuPanel.Visible = False
        drinkMenuPanel.Visible = False
        desertMenuPanel.Visible = False
        aboutUsPanel.Visible = True
        myCartPanel.Visible = False
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()

    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = WindowState.Minimized

    End Sub

    Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub hotdogButton_Click(sender As Object, e As EventArgs) Handles hotdogButton.Click
        ListBox1.Items.Add("Hotdog")


    End Sub

    Private Sub tacoButton_Click(sender As Object, e As EventArgs) Handles tacoButton.Click
        ListBox1.Items.Add("Taco")

    End Sub

    Private Sub riceButton_Click(sender As Object, e As EventArgs) Handles riceButton.Click
        ListBox1.Items.Add("Rice")

    End Sub

    Private Sub crabButton_Click(sender As Object, e As EventArgs) Handles crabButton.Click
        ListBox1.Items.Add("Crab")

    End Sub

    Private Sub burgerButton_Click(sender As Object, e As EventArgs) Handles burgerButton.Click
        ListBox1.Items.Add("Burger")

    End Sub

    Private Sub pizzaButton_Click(sender As Object, e As EventArgs) Handles pizzaButton.Click
        ListBox1.Items.Add("Pizza")

    End Sub



    Private Sub iceCreamButton_Click(sender As Object, e As EventArgs) Handles iceCreamButton.Click
        ListBox1.Items.Add("IceCream")
        total += 1.99
        cartTotal.Text = total
    End Sub

    Private Sub strawberryButton_Click(sender As Object, e As EventArgs) Handles strawberryButton.Click
        ListBox1.Items.Add("Strawberry")

    End Sub

    Private Sub milkshakeButton_Click(sender As Object, e As EventArgs) Handles milkshakeButton.Click
        ListBox1.Items.Add("MilkShake")

    End Sub

    Private Sub wineButton_Click(sender As Object, e As EventArgs) Handles wineButton.Click
        ListBox1.Items.Add("Wine")

    End Sub

    Private Sub teaButton_Click(sender As Object, e As EventArgs) Handles teaButton.Click
        ListBox1.Items.Add("Tea")


    End Sub

    Private Sub coffeeButton_Click(sender As Object, e As EventArgs) Handles coffeeButton.Click
        ListBox1.Items.Add("Coffee")


    End Sub

    Private Sub sodaButton_Click(sender As Object, e As EventArgs) Handles sodaButton.Click
        ListBox1.Items.Add("Soda")


    End Sub

    Private Sub waterButton_Click(sender As Object, e As EventArgs) Handles waterButton.Click
        ListBox1.Items.Add("Water")


    End Sub

    Private Sub orangeJuiceButton_Click(sender As Object, e As EventArgs) Handles orangeJuiceButton.Click
        ListBox1.Items.Add("Orange Juice")


    End Sub
End Class
