module SuaveDeskClock.View

open Suave.Html
open System

let divClass cssClass = divAttr ["class", cssClass]
let h1 xml = tag "h1" [] xml
let aHref href = tag "a" ["href", href]
let cssLink href = linkAttr [ "href", href; " rel", "stylesheet"; " type", "text/css" ]

let index = 
    html [
        head [
            title "Suave Desk Clock"
            cssLink Paths.styles
            cssLink Paths.clockStyles
            text (sprintf "<script src=%s></script>" Paths.jquery)
            text (sprintf "<script src=%s></script>" Paths.clockScript)
        ]

        body [
            divClass "clock" [ emptyText ]
            script [ text "var clock = $('.clock').FlipClock({ clockFace: 'TwentyFourHourClock'});" ]
        ]
        
    ]
    |> xmlToString
