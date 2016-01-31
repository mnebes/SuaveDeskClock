module SuaveDeskClock.App 

open Suave                 // always open suave
open Suave.Successful      // for OK-result
open Suave.Web             // for config
open Suave.Operators
open Suave.Filters

let webPart = 
    choose [
        path Paths.home >=> (OK View.index)
        path Paths.settings >=> (OK "Settings")
        path Paths.styles >=> Files.browseHome
        path Paths.clockScript >=> Files.browseHome
        path Paths.clockStyles >=> Files.browseHome
        path Paths.jquery >=> Files.browseHome
    ]

let start = 
    startWebServer defaultConfig webPart

[<EntryPoint>]
let main _ = 
    start
    0
    
