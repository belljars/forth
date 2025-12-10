# Using Gforth REPL

## Start REPL
```bash
gforth
```

## Basic Usage

### Evaluate expressions
```forth
1 2 + .  \ Prints 3 (postfix notation)
." Hello"  \ Prints "Hello"
```

### Define words (functions)
```forth
: square ( n -- n^2 ) dup * ;
5 square .  \ Prints 25
```

### Variables
```forth
variable x
10 x !
x @ .  \ Prints 10
```

## Stack Operations
```forth
1 2 3 .s  \ Show stack (3 2 1)
drop  \ Remove top (3 2)
swap  \ Swap top two (2 3)
dup   \ Duplicate top (2 3 3)
```

## File Operations

### Load Forth file
```forth
include mycode.fs
```

### Run script directly
```bash
gforth mycode.fs
```

## REPL Commands

### Exit REPL
```forth
bye
; or Ctrl+D
```

### Help
```forth
see square  \ View word definition
words  \ List all words
.s  \ Show stack contents
```
