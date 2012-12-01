In the system implemented here we used restriction (Shieber, 1985) on the stack states to restrict attention to a finite number of distinct stack states for any given stack depth.
P85-1018
Unlike the method derived from the LR(k) parsing algorithm described in Pereira and Wright (1991), these methods use grammar transformations based on the left-corner grammar transform (Rosenkrantz and Lewis II, 1970; Aho and Ullman, 1972).
P91-1032
Shieber. 1985.
P85-1018
For example, the implementation described here translates a DCG version of the example grammar given by Pereira and Wright (1991) directly into a FSM without constructing an approximating CFG.
P91-1032
The 'tail recursion' or 'composition' optimization (Abney and Johnson, 1991; Resnik, 1992) permits right-branching structures to be parsed with bounded stack depth.
C92-1032
In many useful cases, including the example grammar provided by Pereira and Wright (1991), this stack bound is never reached and the system reports that the FSA it returns is exact.
P91-1032
Generalizing the left-corner closure filter on pair categories to complex feature "unification" grammars in an efficient way is complicated, and is the primary difficulty in using left-corner methods with complex feature based grammars, van Noord (1997) provides a detailed discussion of methods for using such a "left-corner filter" in unification-grammar parsing, and the methods he discusses are used in the implementation described below.
J97-3004
