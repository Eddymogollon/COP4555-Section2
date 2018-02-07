// Testing control flow with if statement returning a value
let isEven x =
  let result = if x % 2 = 0 then "Yes it is" else "No it is not"
  result
    
printfn "%s" (isEven 5)

let isWeekday day =
  if day = "Monday" then true
  elif day = "Tuesday" then true
  elif day = "Wednesday" then true
  elif day = "Thursday" then true
  elif day = "Friday" then true
  else false
  
printfn "%A" (isWeekday "Sat")
let describeNumber x = 
  if x % 2 = 0 then 
    printfn "x is a multiple of 2" 
  if x % 3 = 0 then 
    printfn "x is a multiple of 3" 
  if x % 5 = 0 then 
    printfn "x is a multiple of 5" 
  ()
  
describeNumber 18

(* Tuple in a function *)
let add x y = x + y
let tupleAdd (x, y) = x + y
printfn "%A" (tupleAdd (3, 7))

(* Trying the map aggregate function *)
let squares x = x * x
List.map squares [1 .. 10]

(* Reduce aggregate *)
let insertCommas acc item = acc + ", " + item
List.reduce insertCommas ["Jack"; "Jill"; "Jim"]

(* Using List.Iter *)
let printNumber x = printfn "Printing %d" x
List.iter printNumber [1 .. 5]
