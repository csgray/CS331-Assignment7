; evenitems.scm
; Corey S. Gray
; 27 April 2018
;
; For CS F331 / CSCE A331 Spring 2018
; Solution to Assignment 7 Exercise C

#lang scheme

; evenitems
; Takes a list.
; Returns a list of all items in the given list with even index, where indices start with zero.
(define (evenitems l)
  (if (null? l) `()
  (cons (car l) (if (pair? (cdr l)) (evenitems (cddr l)) `() ))))
  