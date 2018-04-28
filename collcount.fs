\ collcounts.fs
\ Corey S. Gray
\ 26 April 2018
\
\ For CS F331 / CSCE A331 Spring 2018
\ Solution to Assignment 7 Exercise B

: collatz ( n -- i )
  DUP 1 = IF ELSE 
    DUP 2 MOD 0= IF 2 / ELSE 3 * 1 + THEN 
  THEN ;


\ collcount
\ Takes a positive integer and returns the number of iterations of the Collatz function required to take n to 1.
: collcount ( n -- c )
  DUP 1 = IF DROP 0 ELSE
    0 SWAP BEGIN COLLATZ SWAP 1 + SWAP DUP 1 = UNTIL DROP THEN ;
