# KTOWorkspace

Scenario Mapping:
Login Page:
<<<<<<< HEAD
⦁ Try to login with a valid username and valid password
⦁ Try to login leaving username blank and valid password
⦁ Try to login leaving password blank and valid username
⦁ Try to login with a valid username and invalid password
⦁ Try to login with an invalid username and valid password
⦁ Try to login with an invalid username and invalid password
⦁ Try to login with an username that contains special characters and valid password
⦁ Try to login with an username that contains special characters and invalid password
⦁ Try to login with a valid username and a password that doesnt match the minimun security standard
⦁ Try to login with Google
⦁ Try to login after several failed attempts (account blocked) this web doesn't have this functionality thought.
⦁ Try "remember me" checkbox (close the browser and verify values are still there after mark)
⦁ Try to reset password
⦁ Try to login leaving both username and password blank
⦁ Try to login with valid username and password with different lowercase/uppercase combinations
⦁ Try to login entering additional spaces at the beginning and at the end of both username and password
⦁ Try to login introducing special characters in password and username
⦁ Trying range limits both in username and password
⦁ Trying to login entering Unicode or multibyte characters both in username and password
⦁ Trying to login with web page under big load of requests
⦁ Verify login form behavior when server is inactive
⦁ Verify that login form is compatible with different web browsers
⦁ Verify the login form behavior in different devices (phone, tablets, etc)
⦁ Try the "Not yet a customer" link text
⦁ Verify the logout after login in succesfully

Registration Page:
⦁ Try to register an account with valid email, valid password and valid security answer
⦁ Try to register an account without entering an email
⦁ Try to register an account without entering a password
⦁ Try to register an account without repeating the password
⦁ Try to register an account with passwords that doesn't match
⦁ Try to register an account with a password that doesn't meet the minimum security requirements
⦁ Try to register an account without selecting a security question
⦁ Try to register an account without entering a security answer
⦁ Try to register an account selecting one of the questions that asks for a date and entering no date in the answer (this has to be based on the Acceptance Criteria of the funcionality: does the client wants the user is forced to put a date? if so, which format? if the answer has to be in the specified format we should try to enter answer in different formats, etc...)
⦁ Try to register account without entering a security answer
⦁ Try to register an account with invalid email
⦁ Try range limits with the security answer
⦁ Verify the display of password requirements when the slide button is activated
⦁ Test time responses
⦁ Test behavior of form with different devices
⦁ Test the link that takes you to the login page
⦁ Test the system response when server is down
⦁ Verify registration form from different web browsers

Commands to run TCs:
To place in the actual project when you directly clone the repo to Visual Studio:
	cd KTOWorkspace
	cd KTOtesting

To run all TCs present in the project:
dotnet test KTOtesting.csproj
To run TCs by Categories:
dotnet test KTOtesting.csproj --filter TestCategory=ValidLogin
dotnet test KTOtesting.csproj --filter TestCategory=InvalidLogin
dotnet test KTOtesting.csproj --filter TestCategory=Register
Categories:
⦁ ValidLogin - Test Case that enter valid credentials into the login page, clicks submit and verified that it takes you to the home page.
⦁ InvalidLogin - Test Case that enters invalid credentials into the login page, clicks submit and checks that an error message is appears due to the invalid credentials.
⦁ Register - Test Case that enters valid and invalid credentials to the registration page as well as selects security questions and answers.
=======

⦁	Try to login with a valid username and valid password
⦁	Try to login leaving username blank and valid password
⦁	Try to login leaving password blank and valid username
⦁	Try to login with a valid username and invalid password
⦁	Try to login with an invalid username and valid password
⦁	Try to login with an invalid username and invalid password
⦁	Try to login with an username that contains special characters and valid password
⦁	Try to login with an username that contains special characters and invalid password
⦁	Try to login with a valid username and a password that doesnt match the minimun security standard
⦁	Try to login with Google
⦁	Try to login after several failed attempts (account blocked) this web doesn't have this functionality thought.
⦁	Try "remember me" checkbox (close the browser and verify values are still there after mark)
⦁	Try to reset password 
⦁	Try to login leaving both username and password blank
⦁	Try to login with valid username and password with different lowercase/uppercase combinations
⦁	Try to login entering additional spaces at the beginning and at the end of both username and password
⦁	Try to login introducing special characters in password and username
⦁	Trying range limits both in username and password
⦁	Trying to login entering Unicode or multibyte characters both in username and password
⦁	Trying to login with web page under big load of requests 
⦁	Verify login form behavior when server is inactive
⦁	Verify that login form is compatible with different web browsers
⦁	Verify the login form behavior in different devices (phone, tablets, etc)
⦁	Try the "Not yet a customer" link text
⦁	Verify the logout after login in succesfully

Registration Page:

⦁	Try to register an account with valid email, valid password and valid security answer
⦁	Try to register an account without entering an email
⦁	Try to register an account without entering a password
⦁	Try to register an account without repeating the password
⦁	Try to register an account with passwords that doesn't match
⦁	Try to register an account with a password that doesn't meet the minimum security requirements
⦁	Try to register an account without selecting a security question
⦁	Try to register an account without entering a security answer
⦁	Try to register an account selecting one of the questions that asks for a date and entering no date in the answer (this has to be based on 	the Acceptance Criteria of the funcionality: does the client wants the user is forced to put a date? if so, which format? if the answer has 	to be in the specified format we should try to enter answer in different formats, etc...)
⦁	Try to register account without entering a security answer
⦁	Try to register an account with invalid email
⦁	Try range limits with the security answer
⦁	Verify the display of password requirements when the slide button is activated
⦁	Test time responses
⦁	Test behavior of form with different devices
⦁	Test the link that takes you to the login page
⦁	Test the system response when server is down
⦁	Verify registration form from different web browsers

Commands to run TCs:
To place in the actual project:
	cd KTOWorkspace
	cd KTOtesting
 
To run all TCs present in the project:
	dotnet test KTOtesting.csproj
 
To run TCs by Categories:
	dotnet test KTOtesting.csproj --filter TestCategory=ValidLogin
	dotnet test KTOtesting.csproj --filter TestCategory=InvalidLogin
	dotnet test KTOtesting.csproj --filter TestCategory=Register
 
Categories:
⦁	ValidLogin - Test Case that enter valid credentials into the login page, clicks submit and verified that it takes you to the home page.
⦁	InvalidLogin - Test Case that enters invalid credentials into the login page, clicks submit and checks that an error message is appears due 	to the invalid credentials.
⦁	Register - Test Case that enters valid and invalid credentials to the registration page as well as selects security questions and answers.
>>>>>>> 611fd3ab503e8edf8c3ed3c6e2274d4878af3998
All the values of the data can be modified within the testData.json file in "Utilities". There you also have App.config in where simply changing the value of the key you can make the Test Cases runs either in Chrome or Firefox


