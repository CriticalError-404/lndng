[<Literal>]
let url = "file:///C:/Users/vinim/Desktop/site/js/elementor-stepai.json"

PM> Install-Package FSharp.Data
open FSharp.Data

[<Literal>]
let url = "file:///C:/Users/vinim/Desktop/site/js/elementor-stepai.json"

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code

type PerfilGitHub = JsonProvider<url>

let perfil = PerfilGitHub.Load url

printfn "%s com %i seguidores" perfil.Name perfil.Followers
printfn "%s" perfil.Bio
printfn "Blog: %s" perfil.Blog