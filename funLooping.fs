// Functional for loop
let rec forLoop body times =
  if times <= 0 then
    ()
   else
    body()
    forLoop body (times - 1)

let rec whileLoop predicate body =
  if predicate() then
    body()
    whileLoop predicate body
  else ()

forLoop (fun () -> printfn "Looping") 3

// Define mutually recursive functioins
let rec isOdd n = (n = 1) || isEven (n-1)
and    isEven n = (n = 0) || isOdd (n-1)

// Factorial