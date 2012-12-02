References Bouma, Gosse (1990).
P90-1021
Flickinger, Pollard, and Wasow (1985), Flickinger (1987), De Smedt (1990), Daelemans (1988), and others, have argued that the encoding and maintenance of the detailed lexical descriptions typical for lexicalist grammar formalisms benefits greatly from the use of (nonmonotonic) inheritance.
P85-1032
An example is the rule for agentless passive (Shieber 1986a, p.
C86-1050
In spite of their great expressive power and flexibility, unification-based grammar formalisms (see Shieber 1986a, for an introduction) are in general not very successful in modeling such devices.
C86-1050
The possibility of incorporating an overwrite operation in a unification-based formalism is mentioned in Shieber (1986a, p.
C86-1050
From the examples given in Shieber (1986a) it seems as if overwriting can only be used to add or substitute (nonmonotonically) one atomic feature value in a given (possibly complex) feature structure (which acts as default).
C86-1050
The work of Evans and Gazdar (1989a,b), finally, is not easily incorporated in a unification-based formalism, as they use semantic nets instead of feature structures to represent linguistic information.
E89-1009
Evans, Roger, and Gazdar, Gerald (1989a).
E89-1009
Acknowledgments A syntactic approach to default unification is presented in Bouma (1990).
P90-1021
Feature structures can be defined using a description language, such as the one found in PATR-II (Shieber 1986a) or in Kasper and Rounds (1986; 1990).
C86-1050 P86-1038
5. Reentrancies in the nondefault argument may be replaced by a weaker set of reentrancies if necessary (this is the add conservatively operation of Shieber (1986b)).
C86-1050
Evans, Roger, and Gazdar, Gerald (1989b).
E89-1009
( (f) = a (g f) = a (g f) = Igg) f'a Following the approach of Kasper and Rounds (1986; 1990), and others, we represent feature structures formally as finite (acyclic) automata (the definition below is taken from Dawar and Vijay-Shanker 1990): Definition A finite acyclic automaton A is a 7-tuple (Q, ~, P, 6, q0, F, "~/where: 1.
J90-1002 P86-1038
Shieber, Stuart (1986b).
C86-1050
Example 12 A = B= \[g:a\] c= \[g:b\] 195 Computational Linguistics Volume 18, Number 2 4.3 Add Conservatively Defining default unification as (A B) U B will fail to capture the idea of Shieber's (1986b) add conservatively, as the difference operation completely removes a default reentrancy if one of the paths leading to it is also defined in the nondefault argument.
C86-1050
While the examples in Flickinger, Pollard, and Wasow (1985) and Evans and Gazdar (1989a,b) suggest that the latter restriction can be easily removed, it is not so obvious how a unification-based grammar formalism can cope with the combination of rules and exceptions typical for (inflectional) morphology.
E89-1009 P85-1032
Kasper, Robert, and Rounds, William (1986).
P86-1038
In Flickinger, Pollard, and Wasow (1985), for instance, lexical information is organized in the form of frames, which are comparable to the templates (i.e., feature structures that may be used as part of the definition of other feature structures) of PATR-II (Shieber 1986a).
C86-1050 P85-1032
Shieber, Stuart (1986a).
C86-1050
Evans and Gazdar (1989a,b) present the DATR-formalism, which, among other things, contains a nonmonotonic inference system that enables an elegant account of the blocking-phenomenon just described.
E89-1009
In this approach, the HFC is part of the rules itself and thus, the effect of Shieber's (1986b) special-purpose compilations step, which adds the HFC conservatively, is achieved directly.
C86-1050
Shieber (1986b) therefore proposes to add this constraint conservatively, which means that, if the rule already contains conflicting information for some head feature f, the constraint is replaced by a set of constraints (Xo head f') = (Xi head f'), for all head features f' # f.
C86-1050
That is, although the syntax of DATR is suggestively similar to that of, for instance, PATR-II, DATR descriptions do in fact denote graphs that differ rather substantially from the graphs used to represent feature structures (see Evans and Gazdar 1989b).
E89-1009
