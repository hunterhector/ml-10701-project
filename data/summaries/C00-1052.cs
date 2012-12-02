Left-corner factoring seems to correspond to one step of Moore's (2000) "left factor" (LF) operation.
A00-2033
After this paI)er was accepted for publication we learnt of Moore (2000), which addresses the issue of grammar size using very similar techniques to those proposed here.
A00-2033
However, Roark mid Johnson (1999) report good perR)rmance from a stochastically-guided top-down parser, suggesting that lefl;-recm'sion is not; always fatal.
P99-1054
tile transforn>detransfornl franmwork described in Johnson (1998b) to evaluate the parses, i.e., we applied tile at)propriate inverse tree transfornl,\]---1 to detransform the parse trees produced using the PCFG estimated froul trees transtbrnmd by T.
J98-4004 P98-1101
The state of a left-corner parser does capture some linguistic generalizations (Mmming an<l Carpenter, 1997; Roark a.nd Johnson, 1999), but one might still expect sparse-data problems.
P99-1054
Because the emission 1)robabilit;y of a PCFG 1)ro(hm(;ion ca15 be regarded as an anllotatioll on a CFG 1)reduction, the left-corner transform can t)rodue(', a CFG with weighted l)roductions which assigns the same l)robal)iliti(~s to strings an(l transtbrmed trees its the original grammar (Abney et al., 11999).
P99-1070
Moore (2000) does not address left-corner tree-transforms, or questions of sparse data and parsing accuracy that are covered ill section 3.
A00-2033
358 3 Empirical Results To examine the effect of the tra.nsforms outlined above, we experimented with vm'ious PCFGs indueed from sections 2--21 of a modified Pcml WSJ tree-bank as described in Johnson (19981)) (i.e., labels simplifiecl to grammatical ca.tegorics, R.OOT lu)des added, empty nodes and vacuous unary bra.nehcs deleted, and auxiliaries retagged as AUX or AUX(').
J98-4004 P98-1101
As Moore (2000) observes, in general the transforms produce a non-left-recursive output grammar only if tile input grammar G does not contain unary cycles, i.e., there is no nonterminal A such that A -~+ A.
A00-2033
lective left-corner tra,nsform is tbllowed by a onestep c-renlowd transfornl (i.e., coml)osition or partial evaluation of schema 1t) with respect to schema ld (Johnson, 1998a; Abney and 3oMson, 1991; Resnik, 1992)), each top-down production f'rolll G appears uilclmnged in tile tinal grammar.
C92-1032 J98-4004 P98-1101
Moore (2000) suggests all additional constraint on nonte.rminals D X that can al)l)ear in useflll 1)roduc l;iolts of £CL(G): D lllllsl; eitller be th(! start synJ)ol of G or else al)pear in a production A --+ o'D/3 of G, for .,,;, A cV, c {Vu T}+ c Tp.
A00-2033
For example, tile selective left-corner transform can be used in place of the standard left-comer transform in the construction of finite-state approximations (Johnson, 1998a), often reducing the size of the intermediate automata constructed.
J98-4004 P98-1101
D ~j w D ~ ~DA whereA-+(~cl )-L .D -+ a where D =>* A P L A, -+ ~ G -L D-B --+ fl D C whereC-->BflcL D-B -} fl wllereD~},C,C~Bfl6L Moore (2000) introduces a version of the leftcorner transform called LCLIt, which al)plies only to productions with left-recursive parent and left clfihl categories.
A00-2033
It; is straightforward to detine a 14o-1 tree l;ransform TL mapping parse trees of G into parse trees of £dL (G) (.Johnson, 1998a; Roark and Johnson, 1999).
J98-4004 P98-1101 P99-1054
Ultinmtely, however, it seems that a more complex ai)t)roach incorporating back-off and smoothing is necessary ill order to achieve the parsing accuracy achieved by Charniak (1997) and Collins (1997).
P97-1003
Top-down factoring plws approximately tile same role as "non-left-recursion grouping" (NLRG) does in Moore's (2000) approach.
A00-2033
