: fizz? ( n -- flag ) 3 mod 0= ;
: buzz? ( n -- flag ) 5 mod 0= ;
: fizzbuzz ( n -- )
  dup fizz? over buzz? if 
    drop ." FizzBuzz "
  else dup fizz? if 
    drop ." Fizz "
  else dup buzz? if 
    drop ." Buzz "
  else . then then then ;

: test-fizzbuzz 16 1 do i fizzbuzz loop ;
