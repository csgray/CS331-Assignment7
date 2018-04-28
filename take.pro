% take.pro
% Corey S. Gray
% 27 April 2018
%
% For CS F331 / CSCE A331 Spring 2018
% Solution for Assignment 7 Exercise D

% take/3
% take(+n, +x, ?e)
% n is a nonnegative integer, x is a list, and e is a list of the first n-elements of x
take(0, _, []).
take(_, [], []).
take(N, [H|X], [H|E]) :- M is N-1, take(M, X, E).