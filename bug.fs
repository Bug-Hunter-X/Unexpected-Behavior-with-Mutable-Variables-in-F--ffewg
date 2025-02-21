let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 10

//However, if you try to swap values of immutable variables, it won't work
let x1 = 10
let y1 = 20

let swapImmutable x y =
    let temp = x
    x <- y //This line will cause a compile-time error.
    y <- temp

swapImmutable x1 y1 //This will cause a compile time error because x and y are immutable.