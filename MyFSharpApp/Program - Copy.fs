// For more information see https://aka.ms/fsharp-console-apps
let rec fact x=
    if x<1 then 1
    else x*fact(x-1)

let res = fact 6
printfn "%A" res

