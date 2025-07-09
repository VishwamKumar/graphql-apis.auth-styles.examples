global using HotChocolate;
global using HotChocolate.Resolvers;
global using HotChocolate.Authorization;

global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.Options;
global using Microsoft.IdentityModel.Tokens;
//global using Microsoft.AspNetCore.Authorization;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.AspNetCore.Authentication.JwtBearer;


global using System.Text;
global using System.Security.Claims;
global using System.IdentityModel.Tokens.Jwt;
global using System.ComponentModel.DataAnnotations;

global using WeatherApp.GraphQLApi.JwtAuth.Configs;
global using WeatherApp.GraphQLApi.JwtAuth.Dtos;
global using WeatherApp.GraphQLApi.JwtAuth.Schemas.Queries;

global using WeatherApp.GraphQLApi.JwtAuth.Controllers;
global using WeatherApp.GraphQLApi.JwtAuth.Middlewares;
