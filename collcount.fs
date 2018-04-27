\ collcounts.fs
\ Corey S. Gray
\ 26 April 2018
\
\ For CS F331 / CSCE A331 Spring 2018
\ Solution to Assignment 7 Exercise B

: collatz ( n -- i )
  dup 1 = IF ELSE 
    dup 2 MOD 0= IF 2 / ELSE 3 * 1 + THEN 
  THEN ;


\ collcounts
\ Takes a positive integer and returns the number of iterations of the Collatz function required to take n to 1.
\ : collcounts (n -- c)

