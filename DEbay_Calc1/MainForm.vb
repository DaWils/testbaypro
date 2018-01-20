Public Class MainForm

	Private itemCost As Double = 0.00
	Private shippingCost As Double = 0.00
	Private additionalFees As Double = 0.00
	Private sellingPrice As Double = 0.00
	Private shippingCharged As Double = 0.00

	Private ebayFees As Double = 0.00
	Private payPalFees As Double = 0.00

	Private totalCost As Double = 0.00
	Private totalRevenue As Double = 0.00
	Private totalProfit As Double = 0.00

	Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
		'Erase all the values in textboxes
		'Erases all the values in Display labels
		Dim ctrl As Control
		For Each ctrl In Me.Controls
			If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is Label And ctrl.Name.Contains("Display") Then
				ctrl.Text = Nothing
			End If
		Next
	End Sub

	Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
		'Calculates the total fees, cost, revenue and profit based on entered values
		VerifyForm()
		GetUserValues()

		GetFees(sellingPrice, shippingCharged)
		GetTotalCost(itemCost, shippingCost, additionalFees)
		GetTotalRevenue(sellingPrice, shippingCharged)
		GetTotalProfitOrLoss(totalRevenue, totalCost, ebayFees, payPalFees)

		EbayFeesDisplayLabel.Text = FormatCurrency(ebayFees.ToString)
		PayPalFeesDisplayLabel.Text = FormatCurrency(payPalFees.ToString)
		TotalCostDisplayLabel.Text = FormatCurrency(totalCost.ToString)
		TotalRevenueDisplayLabel.Text = FormatCurrency(totalRevenue.ToString)
		TotalProfitDisplayLabel.Text = FormatCurrency(totalProfit.ToString)

	End Sub

	Private Sub VerifyForm()
		'Check for valid values in textboxes
		Dim result As Double
		Dim ctrl As Control
		For Each ctrl In Me.Controls
			If TypeOf ctrl Is TextBox Then
				'Try to convert entered value to double
				Try
					If String.IsNullOrWhiteSpace(ctrl.Text) Then
						ctrl.Text = "0.00"
					End If
					result = Convert.ToDouble(ctrl.Text)
				Catch ex As Exception
					'display error message if value cannot be converted
					MessageBox.Show("Could not convert " & ctrl.Text & " to currency. Please enter a valid value.")
				End Try
			End If
		Next
	End Sub

	Private Sub GetFees(ByVal SellingPrice As Double, Optional ByVal ShippingCharged As Double = 0.00)
		'Based on total final values, calculates Ebay and Paypal Fees
		'Ebay Fees at time of writing - 10% of Final Value, up to $750
		Dim finalValue As Double = (SellingPrice + ShippingCharged)

		Dim ebayFeesLimit As Double = 750.0
		Dim ebayFeesPercentage As Double = 0.1

		ebayFees = finalValue * ebayFeesPercentage
		If ebayFees > ebayFeesLimit Then
			ebayFees = ebayFeesLimit
		End If

		'Paypal Fees at time of writing - 2.9% of final value +0.30
		Dim payPalFeesPercentage As Double = 0.029
		Dim payPalFeesStatic = 0.3

		payPalFees = (finalValue * payPalFeesPercentage) + payPalFeesStatic

	End Sub

	Private Sub GetTotalCost(Optional ByVal itemCost As Double = 0.00, Optional ByVal shippingCost As Double = 0.00, Optional ByVal additionalFees As Double = 0.00)
		totalCost = itemCost + shippingCost + additionalFees
	End Sub

	Private Sub GetTotalRevenue(Optional ByVal sellingPrice As Double = 0.00, Optional ByVal shippingCharged As Double = 0.00)
		totalRevenue = sellingPrice + shippingCharged
	End Sub

	Private Sub GetTotalProfitOrLoss(ByVal TotalRevenue As Double, Optional ByVal TotalCost As Double = 0.00, Optional ByVal ebayFees As Double = 0.00, Optional ByVal payPalFees As Double = 0.00)
		'Calculate total money made or lost, adjust color of displayed text accordingly.
		totalProfit = TotalRevenue - (TotalCost + ebayFees + payPalFees)

		If totalProfit >= 0.00 Then
			TotalProfitDisplayLabel.ForeColor = Color.Green
		Else
			TotalProfitDisplayLabel.ForeColor = Color.Red
		End If
	End Sub

	Private Sub GetUserValues()
		itemCost = Convert.ToDouble(ItemCostTextBox.Text)
		shippingCost = Convert.ToDouble(ShippingCostTextbox.Text)
		additionalFees = Convert.ToDouble(AdditionalFeesTextBox.Text)
		sellingPrice = Convert.ToDouble(ItemSellingPriceTextBox.Text)
		shippingCharged = Convert.ToDouble(ShippingChargedTextBox.Text)

	End Sub
End Class
