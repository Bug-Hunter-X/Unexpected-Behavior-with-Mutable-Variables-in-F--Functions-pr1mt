let x = 10

let addOne x = x + 1

let y = addOne x // y will be 11

// x remains unchanged

printf "%d %d" x y // Output will be 10 11

let z = addOne x // z will be 11

printf "%d" z //Output will be 11

let a = 10

let addOne2 a = 
  let temp = a + 1
  temp

let b = addOne2 a // b will be 11

printf "%d %d" a b // Output will be 10 11

let c = addOne2 a // c will be 11

printf "%d" c //Output will be 11