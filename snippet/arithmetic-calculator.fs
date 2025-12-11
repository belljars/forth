: main
    begin
        cr ." enter operation (+ - * /) or 'q' to quit: "
        key dup emit
        dup [char] q = if drop exit then
        dup [char] + = over [char] - = or
        over [char] * = or over [char] / = or
        0= if cr ." invalid operator" drop drop again then
        
        cr ." enter first number: " pad 32 accept number? drop
        cr ." enter second number: " pad 32 accept number? drop
        
        rot
        case
            [char] + of + endof
            [char] - of - endof
            [char] * of * endof
            [char] / of / endof
        endcase
        
        cr ." result: " . cr
    again
;
