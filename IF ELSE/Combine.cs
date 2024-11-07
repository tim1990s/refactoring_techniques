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
	if(a && b)
	{
	    statement
	}


******************EXAMPLE*****************************/

void Main()
{
	Login();
	Login_Better_Combine();
}

#region private methods

/// <summary>Login with the old way</summary>
public void Login()
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
	}
	else
	{
		Console.WriteLine("Access denied. User is not logged in.");
	}
}

/// <summary>Login with combine solution</summary>
public void Login_Better_Combine()
{
	bool isLoggedIn = true;  // Simulating a logged-in user
	bool hasAdminPrivileges = true;  // Simulating an admin user

	if (isLoggedIn && hasAdminPrivileges)
	{
		// Grant access to the admin page
		Console.WriteLine("Access granted to the admin page.");
	}
	else
	{
		Console.WriteLine("Access denied. Either the user is not logged in or does not have admin privileges.");
	}
}

#endregion