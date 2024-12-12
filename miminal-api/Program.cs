var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (miminal_api.Dominio.DTOs.LoginDTO loginDTO) => {
    if(loginDTO.Email == "admin@teste.com" && loginDTO.Senha == "admin")
        return Results.Ok("Login com sucesso");
    else 
        return Results.Unauthorized();
    
});
app.Run();

