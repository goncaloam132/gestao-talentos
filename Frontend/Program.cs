using Blazored.LocalStorage;
using Frontend.Components;
using Frontend.Services;
using Microsoft.AspNetCore.Components.Authorization;
using AuthService = Frontend.Services.AuthService;
using ExperienciaService = Frontend.Services.ExperienciaService;
using TalentoService = Frontend.Services.TalentoService;
using UtilizadorService = Frontend.Services.UtilizadorService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddScoped<TalentoService>();
builder.Services.AddScoped<ExperienciaService>();
builder.Services.AddScoped<CustomAuthStateProvider>();
builder.Services.AddScoped<UtilizadorService>();
builder.Services.AddScoped<HabilidadeService>();
builder.Services.AddScoped<CategoriaService>();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<TalentoHabilidadeService>();
builder.Services.AddScoped<PropostaTrabalhoService>();
builder.Services.AddScoped<PropostaHabilidadeService>();
builder.Services.AddScoped<EstadoService>();
builder.Services.AddScoped<RelatorioService>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
var apiBaseUrl = builder.Configuration["ApiSettings:BaseUrl"] ?? "https://localhost:7070/";

builder.Services.AddHttpClient<AuthService>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

builder.Services.AddHttpClient<ExperienciaService>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

builder.Services.AddHttpClient<TalentoService>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

builder.Services.AddHttpClient<HabilidadeService>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});
builder.Services.AddHttpClient<TalentoHabilidadeService>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});
builder.Services.AddHttpClient<PropostaTrabalhoService>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});
builder.Services.AddHttpClient<PropostaTalentoService>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});
builder.Services.AddHttpClient<EstadoService>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

builder.Services.AddHttpClient<RelatorioService>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

builder.Services.AddBlazoredLocalStorage();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();


app.Run();
