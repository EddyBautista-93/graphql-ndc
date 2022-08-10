var builder = WebApplication.CreateBuilder(args);
// add the GraphQL Server
builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();
app.MapGraphQL();
app.Run();
