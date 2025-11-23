# 🌦️ Weather App - Auth with GraphQL APIs Examples

Authentication-focused GraphQL API examples for a Weather App using simple Layered Architecture. Demonstrates secure access using API Key, JWT, and OAuth2 (Firebase) mechanisms built with [HotChocolate](https://chillicream.com/docs/hotchocolate).

---

## 🛠️ Technologies Used

- **.NET 9.0** - Latest .NET framework
- **HotChocolate** (v15.1.7) - GraphQL server implementation
- **HotChocolate.AspNetCore.Authorization** (v15.1.7) - Authorization support for GraphQL
- **ASP.NET Core** - Web framework
- **Firebase Admin SDK** - For OAuth2/Firebase authentication (OAuth2Firebase project)

---

## 📁 Projects Included

Each project is built independently and follows layered architecture for clean separation of concerns:

### 1. `WeatherApp.GraphQLApi.ApiKeyAuth`
GraphQL API secured via static API Key authentication.
- **Authentication**: Custom middleware-based API Key validation
- **Configuration**: API keys stored in `appsettings.json`
- **Middleware**: `ApiKeyAuthMiddleware` validates API keys from request headers
- **Features**: Simple header-based authentication for API access

### 2. `WeatherApp.GraphQLApi.JwtAuth`
GraphQL API secured using JSON Web Tokens (JWT).
- **Authentication**: JWT Bearer token authentication
- **Token Generation**: Custom `/api/auth/login` endpoint for token generation
- **Configuration**: JWT settings (secret key, issuer, audience) in `appsettings.json`
- **Features**: 
  - User credential validation
  - JWT token generation and validation
  - ASP.NET Core Identity integration for JWT validation

### 3. `WeatherApp.GraphQLApi.OAuth2Firebase`
GraphQL API secured using OAuth2 with Firebase provider.
- **Authentication**: Firebase Authentication with OAuth2
- **Configuration**: Firebase credentials via `firebasesettings.json`
- **Features**: 
  - Firebase token validation
  - OAuth2 flow support
  - Firebase Admin SDK integration

---

## ▶️ Getting Started

### Prerequisites

- .NET 9.0 SDK or later
- Visual Studio 2022, VS Code, or Rider (optional)
- For OAuth2Firebase: Firebase project credentials

### 🧱 Clone the Repository

```bash
git clone https://github.com/vishwamkumar/weather-app.auth-graphql-apis.layered.git
cd weather-app.auth-graphql-apis.layered/src
```

### ▶️ Run Any Project

Each project has its own solution file and can be run/tested independently.

```bash
cd WeatherApp.GraphQLApi.ApiKeyAuth
dotnet run
```

Replace `ApiKeyAuth` with `JwtAuth` or `OAuth2Firebase` to run other projects.

**Default Ports:**
- HTTP: `http://localhost:5000`
- HTTPS: `https://localhost:5001`

---

## 🔎 Explore GraphQL Playground

Each project exposes the default HotChocolate GraphQL IDE **Banana Cake Pop** at:

```
http://localhost:5000/graphql
```

or

```
https://localhost:5001/graphql
```

You can:
- Explore the GraphQL schema
- Make authenticated queries
- Test authorization policies
- View query execution plans

---

## 🧪 Test Scenarios

Each project includes a `Docs/TestMe.md` file with:
- Example GraphQL queries
- Authentication headers configuration
- Test scenarios specific to the authentication scheme
- Sample requests and responses

### Quick Test Examples

**ApiKeyAuth:**
```graphql
query {
  weatherForecast {
    date
    temperatureC
    summary
  }
}
```
Header: `X-Api-Key: your-api-key-here`

**JwtAuth:**
1. First, get a token from `/api/auth/login`
2. Then use the token in Authorization header: `Bearer <token>`

**OAuth2Firebase:**
Use Firebase ID token in Authorization header: `Bearer <firebase-id-token>`

---

## 📂 Project Structure

```
graphsql-apis.auth-styles.examples/
├── src/
│   ├── WeatherApp.GraphQLApi.ApiKeyAuth/
│   │   ├── Configs/          # API Key configuration
│   │   ├── Middlewares/      # API Key authentication middleware
│   │   ├── Schemas/          # GraphQL schema definitions
│   │   ├── Dtos/             # Data transfer objects
│   │   ├── Docs/             # Test documentation
│   │   └── Program.cs        # Application entry point
│   │
│   ├── WeatherApp.GraphQLApi.JwtAuth/
│   │   ├── Configs/          # JWT and user credential settings
│   │   ├── Controllers/      # Auth controller for login
│   │   ├── Middlewares/      # JWT authentication middleware
│   │   ├── Schemas/          # GraphQL schema definitions
│   │   ├── Dtos/             # Data transfer objects
│   │   └── Program.cs
│   │
│   └── WeatherApp.GraphQLApi.OAuth2Firebase/
│       ├── Configs/          # Firebase configuration
│       ├── Schemas/          # GraphQL schema definitions
│       ├── Dtos/             # Data transfer objects
│       ├── firebasesettings.json  # Firebase credentials
│       └── Program.cs
```

---

## 🛡️ Auth Mechanisms Compared

| Project        | Security Mechanism | AuthN / AuthZ           | Provider | Header/Token Location |
| -------------- | ------------------ | ----------------------- | -------- | ---------------------- |
| ApiKeyAuth     | API Key            | Header-based static key | Custom   | `X-Api-Key` header     |
| JwtAuth        | JWT                | Token-based             | Custom   | `Authorization: Bearer <token>` |
| OAuth2Firebase | OAuth2             | Firebase-issued JWT     | Firebase | `Authorization: Bearer <firebase-token>` |

---

## ⚙️ Configuration

### ApiKeyAuth
Configure API keys in `appsettings.json`:
```json
{
  "ApiKeys": [
    {
      "Key": "your-api-key-here",
      "Owner": "ClientName"
    }
  ]
}
```

### JwtAuth
Configure JWT settings in `appsettings.json`:
```json
{
  "JwtSettings": {
    "SecretKey": "your-secret-key-min-32-chars",
    "Issuer": "WeatherApp",
    "Audience": "WeatherAppUsers",
    "ExpiryInMinutes": 60
  },
  "UserCredentials": [
    {
      "Username": "user1",
      "Password": "password1"
    }
  ]
}
```

### OAuth2Firebase
Configure Firebase credentials in `firebasesettings.json`:
```json
{
  "type": "service_account",
  "project_id": "your-project-id",
  ...
}
```

---

## 📝 Key Features

- ✅ **Layered Architecture** - Clean separation of concerns
- ✅ **HotChocolate GraphQL** - Modern GraphQL server implementation
- ✅ **Multiple Auth Strategies** - API Key, JWT, and OAuth2 examples
- ✅ **Authorization Policies** - Role and policy-based access control
- ✅ **Banana Cake Pop IDE** - Built-in GraphQL playground
- ✅ **Middleware-based Auth** - Custom authentication middleware
- ✅ **Configuration-driven** - Easy to configure via appsettings.json

---

## 🔗 Related Projects

- [REST API Auth Examples](../rest-apis.auth-styles.examples) - REST API authentication examples
- [gRPC API Auth Examples](../grpc-apis.auth-styles.examples) - gRPC API authentication examples

---

## 👤 Authors

### Vishwa Kumar

- **Email:** vishwa@vishwa.me
- **GitHub:** [Vishwam](https://github.com/vishwamkumar)
- **LinkedIn:** [Vishwa Kumar](https://www.linkedin.com/in/vishwamohan)

Vishwa is the primary developer and architect of this example app, responsible for the architecture and implementation of these features.

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
