The schemata for these algorithms without unification support can be found at (Alonso et al., 1999).
E99-1020
parsers for the XTAG grammar By using parsing schemata as the ones in (Alonso et al., 1999; Nederhof, 1999) as input to our system, we can easily obtain efficient implementations of several TAG parsing algorithms.
E99-1020 J99-3002
The parsing schema for the TAG CYK-based algorithm (Alonso et al., 1999) is a function that maps such a grammar G to a deduction system whose domain is the set of items {[Nγ,i,j,p,q,adj]} verifying that Nγ is a tree node in an elementary 1Where VT denotes the set of terminal symbols, VN the set of nonterminal symbols, S the axiom, I the set of initial trees and A the set of auxiliary trees.
E99-1020
As an example, we introduce a CYK-based algorithm (Vijay-Shanker and Joshi, 1985) for TAG.
P85-1011
several parsers for the XTAG grammar In this section, we make a comparison of several different TAG parsing algorithms — the CYKbased algorithm described at (Vijay-Shanker and Joshi, 1985), Earley-based algorithms with (Alonso et al., 1999) and without (Schabes, 1994) the valid prefix property (VPP), and Nederhof’s algorithm (Nederhof, 1999) — on the XTAG English grammar (release 2.24.2001), by using our system and the ideas we have explained.
E99-1020 J99-3002 P85-1011
