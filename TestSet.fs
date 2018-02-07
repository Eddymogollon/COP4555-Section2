// Missing 8

let testing f = f 5 1 'a'
// (int -> 'a) -> 'a

// Exercise 7
let testingx (x, y) = "HELLO"::"im"::"Eddy"::[];

// Exercise 9
let testing2 = fun f -> f 17
let testing3 f = f 17

// Exercise 10
(@)[5]
let testing4 = fun x -> 5::x
let testing5 = [fun x -> x+1]
let testing6 = (@)[5]
let testing7 = fun x -> x::[5]

// Exercise 11
let ex11_a = (3, [], true)
let ex11_b = (3, (+), true)
let ex11_c = (3, [3], true)

// Exercise 13
let ex13_a xs = List.map (+) xs
let ex13_b = fun xs -> List.map (+) xs

// Exercise 14
let ex14_a = fun x -> fun y -> x y "."
let ex14_b = fun x y -> String.length x * String.length y
let ex14_c = fun (x, y) -> x + y + "."
let ex14_d = (+)

// Exercise 15
let ex15_a = fun f -> String.length (f "cat")
let ex15_b = fun x y -> x + " " + y
let ex15_c = fun f -> f (f "cat")
let ex15_d = fun f -> f "cat"

// Exercise 16
//??

// Exercise 17
let revlists xs = List.map (fun x -> List.rev) xs
List.map (fun x -> x * x) [1;2;3] 
List.rev (List.map (fun x -> x * x) [1;2;3])

let revlists1 xs = List.map (fun x -> List.rev x) xs // Answer
revlists1 [[1;2;3];[3;2;1];[1;4;9]]

// Exercise 18
