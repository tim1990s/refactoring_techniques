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
	if(!a)
	    return;
	if(!b)
	    return;

	statement

******************EXAMPLE*****************************/

void Main()
{
	Login();
	Login_Early_Exit();
}

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

/// <summary>Login with early exit solution</summary>
private void Login_Early_Exit()
{
	bool isLoggedIn = true;  // Simulating a logged-in user
	bool hasAdminPrivileges = true;  // Simulating an admin user

	if (!isLoggedIn)
		return;  // Exit early if not logged in

	if (!hasAdminPrivileges)
		return;  // Exit early if not an admin

	// Grant access to the admin page
	Console.WriteLine("Access granted to the admin page.");

}