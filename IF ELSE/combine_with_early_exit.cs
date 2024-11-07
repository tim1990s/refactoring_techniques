/******************PROBLEM AND SOLUTION*******************

I. Old way
	if(a)
	{
	    if(b)
	    {
	        statement
	    }
	}
	
II. Better way

=> FROM early exit, we have
if(!a)
	    return;
	if(!b)
	    return;
		
=> APPlY the early exit method with the combine method, we will have.
if(!a || !b)
    return;


******************EXAMPLE*****************************/

void Main()
{
	Login();
	Login_With_Combine_Early_Exit();
}

#region private methods

/// <summary>Login with old way</summary>
private void Login()
{
	bool isLoggedIn = true;  // Simulating a logged-in user
	bool hasAdminPrivileges = true;  // Simulating an admin user

	if (isLoggedIn)
	{
		if (hasAdminPrivileges)
		{
			// Grant access to the admin page
			Console.WriteLine("Access granted to the admin page.");
		}
		else
		{
			Console.WriteLine("Access denied. User does not have admin privileges.");
		}
	}
	else
	{
		Console.WriteLine("Access denied. User is not logged in.");
	}

}

/// <summary>Login with early exit and combine methods</summary>
private void Login_With_Combine_Early_Exit()
{
	bool isLoggedIn = true;  // Simulating a logged-in user
	bool hasAdminPrivileges = true;  // Simulating an admin user

	if (!isLoggedIn || !hasAdminPrivileges)
		return;  // Exit early if either condition is false

	// Grant access to the admin page
	Console.WriteLine("Access granted to the admin page.");

}

#endregion