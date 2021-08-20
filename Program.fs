// Learn more about F# at http://fsharp.org

open System
open FSharp.Text.Lexing

[<EntryPoint>]
let rec main argv =
  printf "calc> "
  let input = System.Console.ReadLine()
  let lexbuf = LexBuffer<char>.FromString input
  try
    let result = Parser.start Lexer.token lexbuf
    printfn "result: %A" result
  with
    | ex -> printfn "error: %A" ex
  main argv
  0
