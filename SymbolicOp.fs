let isOdd x = (x % 2 = 1)

let describeNumber x =
  match isOdd x with
  | true -> printfn "x is odd"
  | false -> printfn "x is even"  

describeNumber 4
let getNumber = function
  | x => 5 -> printfn "larger"
  | x < 5 -> printfn "smaller"

 