The use of such a semantic filter in bottom-up evaluation requires the grammar to obey the semantic monotonicity constraint in order to ensure completeness(Shieber, 1988) (see below).
C88-2128
Though this rule is not cyclic, it becomes cyclic upon off-line abstraction: magic_vp (VForm, \[CSem I_3, SSem) : magic_vp (VForm, \[CSem2l_\], SSem) . Through trimming this magic rule, e.g., given a bounded term depth (Sato and Tamaki, 1984) or a restrictor (Shieber, 1985), constructing an abstract unfolding tree reveals the fact that a cycle results from the magic rule.
P85-1018
In generation, examples of such extended processing strategies are head corner generation with its semantic linking (Shieber et al., 1990) or bottom-up (Earley) generation with a semantic filter (Shieber, 1988).
C88-2128 J90-1004
Given an off-line optimization of the order in which the right-hand side categories in the rules of a logic grammar are processed (Minnen et al., 1996) the resulting processing behavior can be considered a generalization of the head corner generation approach (Shieber et al., 1990): Without the need to rely on notions such as semantic head and chain rule, a head corner behavior can be mimicked in a strict bottom-up fashion.
J90-1004
Generation with the resulting grammar can be compared best with head corner generation (Shieber et al., 1990) (see next section).
J90-1004
This necessitates a dynamic processing strategy, i.e., memoization, extended with an abstraction function like, e.g., restriction (Shieber, 1985), to weaken filtering and a subsumption check to discard redundant results.
P85-1018
In order to obtain a generator similar to the bottom-up generator as described in Shieber (1988) the compilation process can be modified such that only lexical entries are extended with magic literals.
C88-2128
One can consider this as bringing abstraction into the logic as the definite clause representation of filtering is weakened such that only a mild form of connectedness results which does not affect completeness (Shieber, 1985).
P85-1018
