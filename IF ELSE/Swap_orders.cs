/******************PROBLEM AND SOLUTION*******************
	
	I. Old way
		if(a)
		{
		    if(b)
		    {
		        isValid = true;
		    }
		}
		if(c)
		{
		    if(b)
		    {
		        isValid = true;
		    }
		}
		
	II. Better way
	
	1. First approach
		if(b)
		{
		    if(a)
		    {
		        isValid = true;
		    }
		    if(c)
		    {
		        isValid = true;
		    }
		}
	
	2. Second approach
	
		if(b)
		{
		    if(a || c)
		    {
		        isValid = true;
		    }
		}
	
	3. Third approach
	
		isValid = (b && (a || c));
	
		
******************EXAMPLE*****************************/

void Main()
{
	AuthenticateUser();
	AuthenticateUser_First_Approach();
	AuthenticateUser_Second_Approach();
	AuthenticateUser_Third_Approach();
}

#region private methods

private void AuthenticateUser()
{
	bool isUserAuthenticated = true; // User is authenticated
	bool hasRequiredPermission = false; // User does not have the required permission
	bool hasValidSubscription = true; // User has a valid subscription
	bool isValidAccess = false; // Flag to track if user has valid access

	// Old way: Separate checks for user authentication and permission/subscription
	if (isUserAuthenticated)
	{
		if (hasRequiredPermission)
		{
			isValidAccess = true;
		}
	}

	if (hasValidSubscription)
	{
		if (isUserAuthenticated)
		{
			isValidAccess = true;
		}
	}

	Console.WriteLine($"Is User Valid Access (Old Way): {isValidAccess}");
}

private void AuthenticateUser_First_Approach()
{
	bool isUserAuthenticated = true; // User is authenticated
	bool hasRequiredPermission = false; // User does not have the required permission
	bool hasValidSubscription = true; // User has a valid subscription
	bool isValidAccess = false; // Flag to track if user has valid access

	// Better way: First approach, check `isUserAuthenticated` first
	if (isUserAuthenticated)
	{
		if (hasRequiredPermission)
		{
			isValidAccess = true;
		}
		if (hasValidSubscription)
		{
			isValidAccess = true;
		}
	}

	Console.WriteLine($"Is User Valid Access (First Approach): {isValidAccess}");
}

private void AuthenticateUser_Second_Approach()
{
	bool isUserAuthenticated = true; // User is authenticated
	bool hasRequiredPermission = false; // User does not have the required permission
	bool hasValidSubscription = true; // User has a valid subscription
	bool isValidAccess = false; // Flag to track if user has valid access

	// Better way: Second approach, use logical OR for `hasRequiredPermission` and `hasValidSubscription`
	if (isUserAuthenticated)
	{
		if (hasRequiredPermission || hasValidSubscription)
		{
			isValidAccess = true;
		}
	}

	Console.WriteLine($"Is User Valid Access (Second Approach): {isValidAccess}");
}

private void AuthenticateUser_Third_Approach()
{
	bool isUserAuthenticated = true; // User is authenticated
	bool hasRequiredPermission = false; // User does not have the required permission
	bool hasValidSubscription = true; // User has a valid subscription

	// Better way: Third approach, use a single line to assign `isValidAccess`
	bool isValidAccess = (isUserAuthenticated && (hasRequiredPermission || hasValidSubscription));

	Console.WriteLine($"Is User Valid Access (Third Approach): {isValidAccess}");
}
#endregion