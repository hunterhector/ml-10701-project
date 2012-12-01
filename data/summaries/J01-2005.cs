As for the techniques developed so far which (partially) solve prediction nontermination (e.g., Shieber 1985; Haas 1989; Samuelsson 1993), they do not apply to nonminimal derivations because nonminimal derivations may arise without left recursion or recursion in general s One way is to define p to filter out all features except the context-free backbone of predictions.
J89-4001 P85-1018
So, Shieber's algorithm is sound as a recognizer, 6 but not as a transducer or parser (as in van Noord, \[1997\]) where the correctness of output models (i.e., parse trees) is critical.
J97-3004
In this respect, other chart-based algorithms for unification grammars which adopt mixed-direction parsing strategy, including head-corner parsing (van Noord 1997) and left-corner parsing (Alshawi 1992), are subject to the same problem.
J97-3004
However, automatic detection of such features (i.e., automatic derivation of p) is undecidable for the same reason as the prediction nontermination problem (caused by left recursion) for unification grammars (Shieber 1985).
P85-1018
Another possibility is to adopt an efficiency technique along the line of selective memoization (van Noord 1997).
J97-3004
