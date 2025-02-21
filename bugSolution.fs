let x = 10
let y = 20

let swap x y = 
    (y, x) //Return a tuple with swapped values

let x1, y1 = swap x y
printf "%d %d" x1 y1 //This will print 20 10

//If we want to swap immutable variables, we can use the swap function and destructure the returned tuple
let x2 = 10
let y2 = 20

let x3, y3 = swap x2 y2
printf "%d %d" x3 y3 //This will print 20 10