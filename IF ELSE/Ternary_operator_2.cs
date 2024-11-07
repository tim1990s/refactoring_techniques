/******************PROBLEM AND SOLUTION*******************

I. Old way
	if(a)
	{
	
    	b = true;
	}
	else
	{
	    b = false;
	}
	
II. Better way
	b = a;


******************EXAMPLE*******************************/

void Main()
{
	CheckCustomerEligibleForFreeShipping();
	CheckCustomerEligibleForFreeShipping_Better();
}

#region private methods

private void CheckCustomerEligibleForFreeShipping()
{
	// Simulate user input: true means premium member, false means regular user
	bool isPremiumMember = CheckPremiumMember();

	// Old way using if-else
	bool eligibleForFreeShipping;
	if (isPremiumMember)
	{
		eligibleForFreeShipping = true;
	}
	else
	{
		eligibleForFreeShipping = false;
	}
	Console.WriteLine("Eligible for free shipping (if-else): " + eligibleForFreeShipping);
}

private void CheckCustomerEligibleForFreeShipping_Better()
{

	// Simulate user input: true means premium member, false means regular user
	bool isPremiumMember = CheckPremiumMember();

	// Better way: direct assignment
	bool eligibleForFreeShipping = isPremiumMember;
	Console.WriteLine("Eligible for free shipping (direct assignment): " + eligibleForFreeShipping);
}

private bool CheckPremiumMember()
{
	// Handling something to check the premium member
	return true;
}

#endregion

