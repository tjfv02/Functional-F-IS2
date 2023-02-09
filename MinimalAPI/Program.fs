open Microsoft.AspNetCore.Builder
open Giraffe

let webApp =
    choose [ route "/ping" >=> text "pong"
             route "/" >=> text "Hello World!" ]

let app = WebApplication.CreateBuilder().Build()
app.UseGiraffe webApp
app.MapGet("csharp/", Func<string>(fun () -> "Hello World!")) |> ignore
app.Run()