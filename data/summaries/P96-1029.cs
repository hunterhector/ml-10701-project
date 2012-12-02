1The work reported here can thus be seen as complementary to recent reports on methods for directly inferring transducers from data (Oncina et al., 1993; Gildea and Jurafsky, 1995).
P95-1002
For example, the text-analysis ruleset for 220 the Bell Labs German text-to-speech (TTS) system (see (Sproat, 1996; Mohri and Sproat, 1996)) contains sets of rules for the pronunciation of various orthographic symbols.
P96-1031
Now, as noted above, and as discussed by Kaplan and Kay (1994) regular relations -the algebraic counterpart of FSTs -are not in general closed under intersection; however, the subset of same-length regular relations is closed under intersection, since they can be thought of as finite-state acceptors ex(a) left branch A = #Opt(') p = E* right branch A (b) left branch A = E* p = Opt(O(alv ) = (#Opt(')aOpt(')) U (#Opt(')aOpt(')aOpt('))U ( #Opt(')aOpt(')aOpt(')( aOpt(') ) +) = (Opt(')~)+Opt(') right branch A = p = ( Opt(')( blab) ) U ( Opt(')( labd) ) U ( Opt(')( den ) ) U ( Opt(')(pal) )U (Opt(')(vel)) U (Opt(')(pha)) U (Opt(')(n/a)) Table 3: Regular-expression interpretation of the decisions involved in going from the root node to leaf node 4 in the tree in Figure 1.
J94-3001
These rules are compiled into transducers using the weighted rewrite-rule rule-compilation algorithm described in (Mohri and Sproat, 1996).
P96-1031
Over an alphabet of 194 symbols, this compiles, using the algorithm of (Mohri and Sproat, 1996), into a transducer containing 213,408 arcs and 1,927 states.
P96-1031
These methods can be extended slightly to include the compilation of probabilistic or weighted rules into weighted finitestate-transducers (WFSTs -see (Pereira et al., 1994)): Mohri and Sproat (1996) describe a rulecompilation algorithm which is more efficient than the Kaplan-Kay algorithm, and which has been extended to handle weighted rules.
H94-1050 P96-1031
Applications of tree-based modeling to problems in speech and NLP are discussed in (Riley, 1989; Riley, 1991; Wang and Hirschberg, 1992; Magerman, 1995, inter alia).
H89-2048 P95-1037
Review of Rule Compilation Work on finite-state phonology (Johnson, 1972; Koskenniemi, 1983; Kaplan and Kay, 1994) has shown that systems of rewrite rules of the familiar form ¢ --* ¢/)~ p, where ¢, ¢, A and p are 216 regular expressions, can be represented computationally as finite-state transducers (FSTs): note that ¢ represents the rule's input rule, ¢ the output, and ~ and p, respectively, the left and right contexts.
J94-3001
Kaplan and Kay (1994) have presented a concrete algorithm for compiling systems of such rules into FSTs.
J94-3001
An increasing amount of attention has also been focussed on finite-state methods for implementing linguistic models, in particular finitestate transducers and weighted finite-state transducers; see (Kaplan and Kay, 1994; Pereira et al., 1994, inter alia).
H94-1050 J94-3001
It should also be borne in mind that the size explosion evident in Table 4 also characterizes rules that are compiled from hand-built rewrite rules (Kaplan and Kay, 1994; Mohri and Sproat, 1996).
J94-3001 P96-1031
The output ¢ is defined as the union of all of the possible expressions -at the leaf node in question -that aa could become, with their associated weights (negative log probabilities), which we represent here as subscripted floating-point numbers: ¢ = a00.95 U aal.24 O q+aa2.27 O q-l-ao2.34U ah2.6s U ax2.s4 Thus the entire weighted rule can be written as 2As far as possible, we use the notation of Kaplan and Kay (1994).
J94-3001
point can be extended somewhat to include relations that involve bounded deletions or insertions: this is precisely the interpretation necessary for systems of two-level rules (Koskenniemi, 1983), where a single transducer expressing the entire system may be constructed via intersection of the transducers expressing the individual rules (Kaplan and Kay, 1994, pages 367-376).
J94-3001
Following somewhat the discussion in (Pereira et al., 1994; Pereira and Riley, 1996), we can represent the speech recognition task as the problem of finding the best path in the composition of a grammar (language model) G, the transitive-closure of a dictionary D mapping be-" tween words and their phonemic representation, a model of phone realization (I), and a weighted lattice representing the acoustic observations A.
H94-1050
