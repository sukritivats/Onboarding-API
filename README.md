# Onboarding API

A standalone, secure .NET Web API for user authentication and onboarding. This project handles user registration with input validation, authentication via secure login, and JSON Web Token (JWT) generation. It also includes an authorized endpoint to extract user details directly from the token context.

## 🚀 Features

- **User Registration**: Secure sign-up workflow enforcing strict validation rules for credentials.
- **User Login & Authentication**: Verifies user credentials and generates a signed JWT token upon successful authentication.
- **JWT Token Extraction**: A protected endpoint that decodes the incoming bearer token to safely retrieve the authenticated user's email ID.
