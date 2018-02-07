(* 1. Which of the following F# expressions is not well typed? Select one: *)
//c. 4 + 5.6

(* 2. A curried function has a type of which form? Select one: *)
// d?
let add x y = x + y
let addFive = add 5
printfn "%d" (addFive 12)

(* If an F# function has type 'a -> 'b when 'a : comparison, 
  which of the following is not a legal type for it? Select one: *)

let random f a = f(a)


