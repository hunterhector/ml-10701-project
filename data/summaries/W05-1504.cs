In parsing, the most relevant previous work is due to Collins (1997), who considered three binary features of the intervening material: did it contain (a) any word tokens at all, (b) any verbs, (c) any commas or colons?
P97-1003
As this is a regular sequence, we can assemble it in linear time from left to right (rather than in the order of Eisner and Satta (1999)), multiplying the items’ probabilities together.
P99-1059
Adapted with impro vements from (Eisner and Satta, 1999, Fig.
P99-1059
2a. If the bound is too tight to allow the correct parse of some sentence, we would still like to allow an accurate partial parse: a sequence of accurate parse fragments (Hindle, 1990; Abney, 1991; Appelt et al., 1993; Chen, 1995; Grefenstette, 1996).
P90-1034 P95-1031
On this point, see (Eisner and Satta, 1999, §8 and footnote 6).
P99-1059
It might be used to rapidly compute approximate outside-probability estimates to prioritize best-first search (e.g., Caraballo and Charniak, 1998).
J98-2004
Weighted agenda-based deduction is handled in the usual way (Nederhof, 2003; Eisner et al., 200 5).
J03-1006
Work As discussed in footnote 3, Collins (1997) and McDonald et al.(2005) considered the POS tags intervening between a head and child.
P05-1012 P97-1003
16One proof is to construct a strongly equivalent CFG without center-embedding (Nederhof, 2000).
J00-1003
Brants (1999) described a parser that encoded the grammar as a set of cascaded Markov models.
E99-1016
The corresponding unrestricted algorithms (Eisner, 2000; Eisner and Satta, 1999, respectively) have exactly the same runtimes with k replaced by n.
P99-1059
This is accomplished by using automata circlering−→circlering a1a0a27 as in model C, which allows the stopping probabilities p(STOP | q0) and p(STOP |q1) to differ, but tying the conditional dis7It is equivalent to the “dependency model with valence” of Klein and Manning (2004).
P04-1061
2It has recently been questioned whether these “bilexical” features actually contribute much to parsing performance (Klein and Manning, 2003; Bikel, 2004), at least when one has only a million words of training.
P03-1054 P04-1061 W04-3224
2a gives a variant of Eisner and Satta’s (1999) SHAG parsing algorithm, adapted to SBGs, which are easier to understand.9 (We will modify this algorithm later in §4).
P99-1059
Formalism Throughout this paper we will use split bilexical grammars, or SBGs (Eisner, 2000), a notationally simpler variant of split head-automaton grammars, or SHAGs (Eisner and Satta, 1999).
P99-1059
Similarly, McDonald et al.(2005) separately considered each of the intervening POS tags.
P05-1012
Subset and superset approximations of (weighted) CFLs by (weighted) regular languages, usually by preventing center-embedding, have been widely explored; Nederhof (2000) gives a thorough review.
J00-1003
(1) helps explain the “late closure” or “attach low” heuristic (e.g., Frazier, 1979; Hobbs and Bear, 1990): a modifier such as a PP is more likely to attach to the closest appropriate head.
C90-3029
This is known as uniform-cost search or shortest-hyperpath search (Nederhof, 2003).
J03-1006
This algorithm strings together the partial trees’ roots along a “vine.” 28The obvious reduction for unsplit head automaton grammars, say, is only O(n4) → O(n3k), following (Eisner and Satta, 1999).
P99-1059
It might also be used to speed up the early iterations of training a weighted parsing model, which for modern training methods tends to require repeated parsing (either for the best parse, as by Taskar et al., 2004, or all parses, as by Miyao and Tsujii, 2002).
W04-3201
First, we observe without details that we can easily achieve this by starting instead with the algorithm of Eisner (2000),20 rather than Eisner and Satta (1999), and again refusing to add long tree dependencies.
P99-1059
