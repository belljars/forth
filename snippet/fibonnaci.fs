: fib ( n -- fib_n )
    dup 0= if drop 0 exit then
    dup 1 = if drop 1 exit then
    0 1 rot 1 do
        swap over +
    loop nip ;

: test-fib
    cr
    10 0 do
        i fib . 
    loop cr ;
