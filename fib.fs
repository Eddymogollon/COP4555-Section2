let rec fib1 = function
  | 0 -> 0I
  | 1 -> 1I
  | n -> fib1(n-1) + fib1(n-2)
  


let rec fib1a x =
  match x with
    | 0 -> 0I
    | 1 -> 1I
    | n -> fib1a(n-1) + fib1a(n-2)

// polymorphic exponentiation
let mk_expon times one =
  let rec expon x n = 
    if n = 0 then one
    elif n%2 = 0 then expon (times x x) (n / 2)
    else times x (expon x (n-1))
  expon // this is the return value - a function
  // expon n (type mismatch)

// int exponentation
let expon1 = mk_expon (*) 1

// string exponentation
let expon2 = mk_expon (+) ""

// rewrite expon using match

  // infix operator?
  // function factory
  // polymorphic
  // type promotion

  // trace the recursive calls until I get ot the base case, return values back up

  // use pattern matching