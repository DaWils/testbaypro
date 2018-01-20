<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
		Me.ItemCostTextBox = New System.Windows.Forms.TextBox()
		Me.ShippingCostTextbox = New System.Windows.Forms.TextBox()
		Me.AdditionalFeesTextBox = New System.Windows.Forms.TextBox()
		Me.ItemSellingPriceTextBox = New System.Windows.Forms.TextBox()
		Me.ShippingChargedTextBox = New System.Windows.Forms.TextBox()
		Me.ItemCostLabel = New System.Windows.Forms.Label()
		Me.ShippingCostLabel = New System.Windows.Forms.Label()
		Me.AdditionalFeesLabel = New System.Windows.Forms.Label()
		Me.ItemSellingPriceLabel = New System.Windows.Forms.Label()
		Me.ShippingChargedLabel = New System.Windows.Forms.Label()
		Me.EbayFeesLabel = New System.Windows.Forms.Label()
		Me.PayPalFeesLabel = New System.Windows.Forms.Label()
		Me.EbayFeesDisplayLabel = New System.Windows.Forms.Label()
		Me.PayPalFeesDisplayLabel = New System.Windows.Forms.Label()
		Me.TotalRevenueDisplayLabel = New System.Windows.Forms.Label()
		Me.TotalCostDisplayLabel = New System.Windows.Forms.Label()
		Me.TotalRevenueLabel = New System.Windows.Forms.Label()
		Me.TotalCostLabel = New System.Windows.Forms.Label()
		Me.TotalProfitDisplayLabel = New System.Windows.Forms.Label()
		Me.TotalProfitLabel = New System.Windows.Forms.Label()
		Me.ClearButton = New System.Windows.Forms.Button()
		Me.CalculateButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'ItemCostTextBox
		'
		Me.ItemCostTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ItemCostTextBox.Location = New System.Drawing.Point(488, 43)
		Me.ItemCostTextBox.Name = "ItemCostTextBox"
		Me.ItemCostTextBox.Size = New System.Drawing.Size(200, 55)
		Me.ItemCostTextBox.TabIndex = 0
		'
		'ShippingCostTextbox
		'
		Me.ShippingCostTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ShippingCostTextbox.Location = New System.Drawing.Point(488, 124)
		Me.ShippingCostTextbox.Name = "ShippingCostTextbox"
		Me.ShippingCostTextbox.Size = New System.Drawing.Size(200, 55)
		Me.ShippingCostTextbox.TabIndex = 1
		'
		'AdditionalFeesTextBox
		'
		Me.AdditionalFeesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AdditionalFeesTextBox.Location = New System.Drawing.Point(488, 205)
		Me.AdditionalFeesTextBox.Name = "AdditionalFeesTextBox"
		Me.AdditionalFeesTextBox.Size = New System.Drawing.Size(200, 55)
		Me.AdditionalFeesTextBox.TabIndex = 2
		'
		'ItemSellingPriceTextBox
		'
		Me.ItemSellingPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ItemSellingPriceTextBox.Location = New System.Drawing.Point(488, 328)
		Me.ItemSellingPriceTextBox.Name = "ItemSellingPriceTextBox"
		Me.ItemSellingPriceTextBox.Size = New System.Drawing.Size(200, 55)
		Me.ItemSellingPriceTextBox.TabIndex = 3
		'
		'ShippingChargedTextBox
		'
		Me.ShippingChargedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ShippingChargedTextBox.Location = New System.Drawing.Point(488, 407)
		Me.ShippingChargedTextBox.Name = "ShippingChargedTextBox"
		Me.ShippingChargedTextBox.Size = New System.Drawing.Size(200, 55)
		Me.ShippingChargedTextBox.TabIndex = 4
		'
		'ItemCostLabel
		'
		Me.ItemCostLabel.AutoSize = True
		Me.ItemCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ItemCostLabel.Location = New System.Drawing.Point(37, 43)
		Me.ItemCostLabel.Name = "ItemCostLabel"
		Me.ItemCostLabel.Size = New System.Drawing.Size(211, 48)
		Me.ItemCostLabel.TabIndex = 5
		Me.ItemCostLabel.Text = "Item Cost:"
		'
		'ShippingCostLabel
		'
		Me.ShippingCostLabel.AutoSize = True
		Me.ShippingCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ShippingCostLabel.Location = New System.Drawing.Point(37, 124)
		Me.ShippingCostLabel.Name = "ShippingCostLabel"
		Me.ShippingCostLabel.Size = New System.Drawing.Size(338, 48)
		Me.ShippingCostLabel.TabIndex = 6
		Me.ShippingCostLabel.Text = "Cost of Shipping:"
		'
		'AdditionalFeesLabel
		'
		Me.AdditionalFeesLabel.AutoSize = True
		Me.AdditionalFeesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AdditionalFeesLabel.Location = New System.Drawing.Point(37, 205)
		Me.AdditionalFeesLabel.Name = "AdditionalFeesLabel"
		Me.AdditionalFeesLabel.Size = New System.Drawing.Size(258, 48)
		Me.AdditionalFeesLabel.TabIndex = 7
		Me.AdditionalFeesLabel.Text = "Listing Fees:"
		'
		'ItemSellingPriceLabel
		'
		Me.ItemSellingPriceLabel.AutoSize = True
		Me.ItemSellingPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ItemSellingPriceLabel.Location = New System.Drawing.Point(37, 328)
		Me.ItemSellingPriceLabel.Name = "ItemSellingPriceLabel"
		Me.ItemSellingPriceLabel.Size = New System.Drawing.Size(359, 48)
		Me.ItemSellingPriceLabel.TabIndex = 8
		Me.ItemSellingPriceLabel.Text = "Item Selling Price:"
		'
		'ShippingChargedLabel
		'
		Me.ShippingChargedLabel.AutoSize = True
		Me.ShippingChargedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ShippingChargedLabel.Location = New System.Drawing.Point(37, 407)
		Me.ShippingChargedLabel.Name = "ShippingChargedLabel"
		Me.ShippingChargedLabel.Size = New System.Drawing.Size(365, 48)
		Me.ShippingChargedLabel.TabIndex = 9
		Me.ShippingChargedLabel.Text = "Shipping Charged:"
		'
		'EbayFeesLabel
		'
		Me.EbayFeesLabel.AutoSize = True
		Me.EbayFeesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EbayFeesLabel.Location = New System.Drawing.Point(37, 532)
		Me.EbayFeesLabel.Name = "EbayFeesLabel"
		Me.EbayFeesLabel.Size = New System.Drawing.Size(231, 48)
		Me.EbayFeesLabel.TabIndex = 10
		Me.EbayFeesLabel.Text = "Ebay Fees:"
		'
		'PayPalFeesLabel
		'
		Me.PayPalFeesLabel.AutoSize = True
		Me.PayPalFeesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PayPalFeesLabel.Location = New System.Drawing.Point(37, 606)
		Me.PayPalFeesLabel.Name = "PayPalFeesLabel"
		Me.PayPalFeesLabel.Size = New System.Drawing.Size(269, 48)
		Me.PayPalFeesLabel.TabIndex = 11
		Me.PayPalFeesLabel.Text = "PayPal Fees:"
		'
		'EbayFeesDisplayLabel
		'
		Me.EbayFeesDisplayLabel.AutoSize = True
		Me.EbayFeesDisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EbayFeesDisplayLabel.Location = New System.Drawing.Point(477, 532)
		Me.EbayFeesDisplayLabel.Name = "EbayFeesDisplayLabel"
		Me.EbayFeesDisplayLabel.Size = New System.Drawing.Size(0, 48)
		Me.EbayFeesDisplayLabel.TabIndex = 12
		'
		'PayPalFeesDisplayLabel
		'
		Me.PayPalFeesDisplayLabel.AutoSize = True
		Me.PayPalFeesDisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PayPalFeesDisplayLabel.Location = New System.Drawing.Point(477, 606)
		Me.PayPalFeesDisplayLabel.Name = "PayPalFeesDisplayLabel"
		Me.PayPalFeesDisplayLabel.Size = New System.Drawing.Size(0, 48)
		Me.PayPalFeesDisplayLabel.TabIndex = 13
		'
		'TotalRevenueDisplayLabel
		'
		Me.TotalRevenueDisplayLabel.AutoSize = True
		Me.TotalRevenueDisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TotalRevenueDisplayLabel.Location = New System.Drawing.Point(477, 802)
		Me.TotalRevenueDisplayLabel.Name = "TotalRevenueDisplayLabel"
		Me.TotalRevenueDisplayLabel.Size = New System.Drawing.Size(0, 48)
		Me.TotalRevenueDisplayLabel.TabIndex = 17
		'
		'TotalCostDisplayLabel
		'
		Me.TotalCostDisplayLabel.AutoSize = True
		Me.TotalCostDisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TotalCostDisplayLabel.Location = New System.Drawing.Point(477, 728)
		Me.TotalCostDisplayLabel.Name = "TotalCostDisplayLabel"
		Me.TotalCostDisplayLabel.Size = New System.Drawing.Size(0, 48)
		Me.TotalCostDisplayLabel.TabIndex = 16
		'
		'TotalRevenueLabel
		'
		Me.TotalRevenueLabel.AutoSize = True
		Me.TotalRevenueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TotalRevenueLabel.Location = New System.Drawing.Point(37, 802)
		Me.TotalRevenueLabel.Name = "TotalRevenueLabel"
		Me.TotalRevenueLabel.Size = New System.Drawing.Size(303, 48)
		Me.TotalRevenueLabel.TabIndex = 15
		Me.TotalRevenueLabel.Text = "Total Revenue:"
		'
		'TotalCostLabel
		'
		Me.TotalCostLabel.AutoSize = True
		Me.TotalCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TotalCostLabel.Location = New System.Drawing.Point(37, 728)
		Me.TotalCostLabel.Name = "TotalCostLabel"
		Me.TotalCostLabel.Size = New System.Drawing.Size(223, 48)
		Me.TotalCostLabel.TabIndex = 14
		Me.TotalCostLabel.Text = "Total Cost:"
		'
		'TotalProfitDisplayLabel
		'
		Me.TotalProfitDisplayLabel.AutoSize = True
		Me.TotalProfitDisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TotalProfitDisplayLabel.Location = New System.Drawing.Point(474, 875)
		Me.TotalProfitDisplayLabel.Name = "TotalProfitDisplayLabel"
		Me.TotalProfitDisplayLabel.Size = New System.Drawing.Size(0, 48)
		Me.TotalProfitDisplayLabel.TabIndex = 19
		'
		'TotalProfitLabel
		'
		Me.TotalProfitLabel.AutoSize = True
		Me.TotalProfitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TotalProfitLabel.Location = New System.Drawing.Point(34, 875)
		Me.TotalProfitLabel.Name = "TotalProfitLabel"
		Me.TotalProfitLabel.Size = New System.Drawing.Size(236, 48)
		Me.TotalProfitLabel.TabIndex = 18
		Me.TotalProfitLabel.Text = "Total Profit:"
		'
		'ClearButton
		'
		Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ClearButton.Location = New System.Drawing.Point(42, 989)
		Me.ClearButton.Name = "ClearButton"
		Me.ClearButton.Size = New System.Drawing.Size(192, 84)
		Me.ClearButton.TabIndex = 20
		Me.ClearButton.Text = "Clear"
		Me.ClearButton.UseVisualStyleBackColor = True
		'
		'CalculateButton
		'
		Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CalculateButton.Location = New System.Drawing.Point(283, 989)
		Me.CalculateButton.Name = "CalculateButton"
		Me.CalculateButton.Size = New System.Drawing.Size(394, 84)
		Me.CalculateButton.TabIndex = 21
		Me.CalculateButton.Text = "Calculate"
		Me.CalculateButton.UseVisualStyleBackColor = True
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.ClientSize = New System.Drawing.Size(722, 1102)
		Me.Controls.Add(Me.CalculateButton)
		Me.Controls.Add(Me.ClearButton)
		Me.Controls.Add(Me.TotalProfitDisplayLabel)
		Me.Controls.Add(Me.TotalProfitLabel)
		Me.Controls.Add(Me.TotalRevenueDisplayLabel)
		Me.Controls.Add(Me.TotalCostDisplayLabel)
		Me.Controls.Add(Me.TotalRevenueLabel)
		Me.Controls.Add(Me.TotalCostLabel)
		Me.Controls.Add(Me.PayPalFeesDisplayLabel)
		Me.Controls.Add(Me.EbayFeesDisplayLabel)
		Me.Controls.Add(Me.PayPalFeesLabel)
		Me.Controls.Add(Me.EbayFeesLabel)
		Me.Controls.Add(Me.ShippingChargedLabel)
		Me.Controls.Add(Me.ItemSellingPriceLabel)
		Me.Controls.Add(Me.AdditionalFeesLabel)
		Me.Controls.Add(Me.ShippingCostLabel)
		Me.Controls.Add(Me.ItemCostLabel)
		Me.Controls.Add(Me.ShippingChargedTextBox)
		Me.Controls.Add(Me.ItemSellingPriceTextBox)
		Me.Controls.Add(Me.AdditionalFeesTextBox)
		Me.Controls.Add(Me.ShippingCostTextbox)
		Me.Controls.Add(Me.ItemCostTextBox)
		Me.Name = "MainForm"
		Me.Text = "Ebay Profit Calculator"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ItemCostTextBox As TextBox
	Friend WithEvents ShippingCostTextbox As TextBox
	Friend WithEvents AdditionalFeesTextBox As TextBox
	Friend WithEvents ItemSellingPriceTextBox As TextBox
	Friend WithEvents ShippingChargedTextBox As TextBox
	Friend WithEvents ItemCostLabel As Label
	Friend WithEvents ShippingCostLabel As Label
	Friend WithEvents AdditionalFeesLabel As Label
	Friend WithEvents ItemSellingPriceLabel As Label
	Friend WithEvents ShippingChargedLabel As Label
	Friend WithEvents EbayFeesLabel As Label
	Friend WithEvents PayPalFeesLabel As Label
	Friend WithEvents EbayFeesDisplayLabel As Label
	Friend WithEvents PayPalFeesDisplayLabel As Label
	Friend WithEvents TotalRevenueDisplayLabel As Label
	Friend WithEvents TotalCostDisplayLabel As Label
	Friend WithEvents TotalRevenueLabel As Label
	Friend WithEvents TotalCostLabel As Label
	Friend WithEvents TotalProfitDisplayLabel As Label
	Friend WithEvents TotalProfitLabel As Label
	Friend WithEvents ClearButton As Button
	Friend WithEvents CalculateButton As Button
End Class
