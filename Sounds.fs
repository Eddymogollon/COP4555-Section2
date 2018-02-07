open System
let victory() = 
  for frequency in [100 .. 50 .. 2000] do
    Console.Beep(frequency, 25)

victory()

let defeat() =
  for frequency in [2000 .. -50 .. 37] do
    Console.Beep(frequency, 25)

defeat()