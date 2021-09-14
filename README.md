# Facebook Desktop App Using Winforms GUI
An app that suppose to mimic the real facebook app but has 2 extra features.

## Behind The Scenes 
The app is WinForms .NET Facebook application using Facebook API.
## Incorporating :
- Multi-Threading
- Bidirectional Data Binding
- Delegates
- Serialization
- Design Patterns, based on the book of The Gang Of Four, such as:
```
Facade 
Static Factory Class
Proxy
Strategy
Visitor
Iterator
```

# Features Description:
### Volunteer With An Elderly
Find an elder in your city and volunteer with him, choose the age range you'd like starting from 65 up to 125, 
eventually a picture of the "Elder" would appear.

### Look How Someone Had Changed 
The second feature gives the user the opportunity to look how some one of his friends had changed during the last couple of years,
the age range over there is between 2010 - 2020, and the user must choose on of the friends from the friends list, he can hear the the name of the friends,
and afterwards the photos of this user will appear with description and date.

# Usage
- Create an application-account on https://developers.facebook.com/apps to get an App ID.
- In Visual Studio add a reference to the .dll files (FbGraphApiWrapper.dll, Facebook.dll).
- Use the static login method 
  ```
  LoginResult result = FacebookWrapper.FBService.Login( AppID, list of permission);
  ```
  providing your AppID and the permissions required from your app's user to display a login form to your user.
  For the list of permission, see this https://developers.facebook.com/docs/facebook-login/permissions.

# Resources
- Visit https://developers.facebook.com/docs/reference/api/ to understand more and get all the information about the Facebook Graph API.
- Use the https://developers.facebook.com/tools/explorer application to browse data on facebook using the Graph API and understanding Jason.
