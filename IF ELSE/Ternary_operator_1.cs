/******************PROBLEM AND SOLUTION*******************

I. Old way
	if(a)
	{
	    b = some value;
	}
	else
	{
	    b = anotherValue;
	}

II. Better way
	
	b = (a) ? someValue : anotherValue;
	
Ref: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator

******************EXAMPLE*******************************/

void Main()
{	
	ManipulateCustomerDiscount();
	ManipulateCustomerDiscount_Better();
}

#region private methods

private void ManipulateCustomerDiscount()
{
	// Simulate user input: true means loyal customer, false means new customer
	bool isLoyalCustomer = true;

	// Traditional if-else approach
	double discountPercentage;
	if (isLoyalCustomer)
	{
		discountPercentage = 20.0; // 20% for loyal customers
	}
	else
	{
		discountPercentage = 5.0; // 5% for new customers
	}
	Console.WriteLine("Discount using if-else: " + discountPercentage + "%");
}

private void ManipulateCustomerDiscount_Better()
{
	// Simulate user input: true means loyal customer, false means new customer
	bool isLoyalCustomer = true;
	
	// Refactored using the conditional operator (?:)
	double discountPercentageRefactored = (isLoyalCustomer) ? 20.0 : 5.0;
	Console.WriteLine("Discount using conditional operator: " + discountPercentageRefactored + "%");
}

#endregion