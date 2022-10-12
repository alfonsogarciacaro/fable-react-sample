module App

open Fable.Core
open Browser
open Fable.React

// Entry point must be in a separate file
// for Vite Hot Reload to work

[<JSX.Component>]
let App () = TodoMVC.App()

let root = ReactDomClient.createRoot (document.getElementById ("app-container"))
root.render (App() |> toReact)
