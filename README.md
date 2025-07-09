# 🌦️ Weather App - Auth with GraphQL APIs (Layered Architecture)

Authentication-focused GraphQL API examples for a Weather App using Layered Architecture. Demonstrates secure access using API Key, JWT, and OAuth2 (Firebase) mechanisms built with [HotChocolate](https://chillicream.com/docs/hotchocolate).

---
# Authors

## Vishwa Kumar

- **Email:** vishwa@vishwa.me
- **GitHub:** [Vishwam](https://github.com/vishwamkumar)
- **LinkedIn:** [Vishwa Kumar](https://www.linkedin.com/in/vishwamohan)

Vishwa is the primary developer and architect of this example app, responsible for the architecture and implementation of these features.

---

## 📁 Projects Included

Each project is built independently and follows layered architecture for clean separation of concerns:

- `WeatherApp.GraphQLApi.ApiKeyAuth` – GraphQL API secured via static API Key.
- `WeatherApp.GraphQLApi.JwtAuth` – GraphQL API secured using JSON Web Tokens.
- `WeatherApp.GraphQLApi.OAuth2Firebase` – GraphQL API secured using OAuth2 with Firebase provider.

---

## ▶️ Getting Started

Each project has its own solution file and can be run/tested independently.

### 🧱 Clone the Repository

    ```bash
        git clone https://github.com/<your-username>/weather-app.auth-graphql-apis.layered.git
        cd weather-app.auth-graphql-apis.layered
    ```


## ▶️ Run Any Project

    ```bash
        cd WeatherApp.GraphQLApi.JwtAuth
        dotnet run
    ```
        
     Replace JwtAuth with any of the other folders as needed.


## 🔎 Explore GraphQL Playground
    Each project exposes the default HotChocolate GraphQL IDE Banana Cake Pop at:

    ```bash
        http://localhost:5000/graphql
    ```
    You can explore schema, make authenticated queries, and test authorization.



## 🧪 Test Scenarios
    Each project includes a Docs/TestMe.md file with example queries and test scenarios specific to the authentication scheme in use.

---

## Structure

    weather-app.auth-graphql-apis.layered/
    ├── WeatherApp.GraphQLApi.ApiKeyAuth/
    ├── WeatherApp.GraphQLApi.JwtAuth/
    └── WeatherApp.GraphQLApi.OAuth2Firebase/

---

## 🛡️ Auth Mechanisms Compared

| Project        | Security Mechanism | AuthN / AuthZ           | Provider |
| -------------- | ------------------ | ----------------------- | -------- |
| ApiKeyAuth     | API Key            | Header-based static key | Custom   |
| JwtAuth        | JWT                | Token-based             | Custom   |
| OAuth2Firebase | OAuth2             | Firebase-issued JWT     | Firebase |


## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.