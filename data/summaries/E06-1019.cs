These switches correspond to discontinuous constituents (Melamed, 2003) in general bitext parsing.
N03-1021
Our test set is the 500 manually aligned sentence pairs created by Franz Och and Hermann Ney (2003).
J03-1002
The task originally emerged as an intermediate result of training the IBM translation models (Brown et al., 1993).
J93-2003
However, the use of a fixed tree is not the only difference between (Yamada and Knight, 2001) and ITGs; the probability models are also very different.
P01-1067
Our weakest method outperforms Model 2, which scores an AERof 22.0 on this test set whentrained with roughly twice as many sentence pairs (Och and Ney, 2003).
J03-1002
We define the following simple link score to test the guidance provided by different alignment spaces: flink(a,E,F) = φ2(ei,fj) −C|i−j| (6) Here, a = (i,j) is a link and φ2(ei,fj) returns the φ2 correlation metric (Gale and Church, 1991) 150 Table 1: Results with the learned link score.
H91-1026
Lin and Cherry (2003) have shown that adding a dependency-based cohesion constraint to an alignment search can improve alignment quality.
N03-2017
They remain the dominant method for word alignment (Och and Ney, 2003).
J03-1002
This results in two forbidden alignment structures, shown in Figure 1, called “inside-out” transpositions in (Wu, 1997).
J97-3002
Gold standard links are broken up into twocategories in Och and Ney’s evaluation framework (2003).
J03-1002
Melamed. 2003.
N03-1021
Zhang and Gildea (2004) compared Yamada and Knight’s (2001) tree-to-string alignment model to ITGs.
C04-1060 P01-1067
This corresponds to the competitive linking algorithm (Melamed, 2000).
J00-2004
Zens and Ney (2003) explore the re-orderings allowed by ITGs, and provide a formulation for the number of structures that can be built for a sentence pair of size n.
P03-1019
Alignment spaces can emerge from generative stories (Brown et al., 1993), from syntactic notions (Wu, 1997), or they can be imposed to create competition between links (Melamed, 2000).
J00-2004 J93-2003 J97-3002
ITGs explore almost all of permutation space when n is small, but their coverage of permutation space falls off quickly for n > 5 (Wu, 1997).
J97-3002
English dependency trees are supplied by Minipar (Lin, 1994).
C94-1079
Having a single, canonical tree structure for each possible alignment can help when flattening binary trees, as it indicates arbitrary binarization decisions (Wu, 1997).
J97-3002
This is similar to the experiments in (Fox, 2002), but instead of countingcrossings, wecount howmanylinksamaximal alignment misses when confined to the space.
W02-1039
The IBM models (Brown et al., 1993) search a version of permutation space with a one-to-many constraint.
J93-2003
Fox. 2002.
W02-1039
Taskar et al (2005) have shown that with a strong flink, one can achieve state of the art results using this objective function and the maximum matching algorithm.
H05-1010
Normally, one would eliminate the redundant structures produced by the grammar in (1) by replacing it with the canonical form grammar (Wu, 1997), which has the following form: S → A | B | C A → [AB] | [BB] | [CB] | [AC] | [BC] | [CC] B → 〈AA〉 |〈BA〉|〈CA〉| 〈AC〉 |〈BC〉|〈CC〉 C → e/f (2) By design, this grammar allows only one struc147 a0 a1 a2 a0 a3 a4 a2 a5 a1 a6 a7 a8 a6 a8 a9 a8 a2 a8 a10 a8 a1 a2 a3 a6 a8 a4 a7 a8 a6 a8 a9 a8 a8 a11 a12 a11 a0 a1 a2 a0 a3 a4 a2 a5 a1 a6 a7 a8 a6 a8 a9 a8 a0 a1 a2 a0 a3 a4 a2 a5 a1 a6 a7 a8 a6 a8 a9 a8 a0 a1 a2 a0 a3 a4 a2 a5 a1 a6 a7 a8 a6 a8 a9 a8 a13 a11 Figure 3: An example of how dependency trees interact with ITGs.
J97-3002
Canonical structures also eliminate double counting when performing tasks like EM (Zhang and Gildea, 2004).
C04-1060
Permutation space methods include weighted maximum matching (Taskar et al., 2005), and approximations to maximum matching like competitive linking (Melamed, 2000).
H05-1010 J00-2004
Melamed. 2000.
J00-2004
Space A straight-forward way to limit the space of possible alignments is to enforce a one-to-one constraint (Melamed, 2000).
J00-2004
Fox (2002) introduced the notion of headmodifier and modifier-modifier crossings.
W02-1039
Someworkwithintheframework of synchronous grammars (Wu, 1997; Melamed, 2003), while others create a generative story that includes a parse tree provided for one of the sentences (Yamada and Knight, 2001).
J97-3002 N03-1021 P01-1067
To enable such techniques, we bring the cohesion constraint inside the ITG framework (Wu, 1997).
J97-3002
simple solution Wu (1997) suggests that in order to have an ITG take advantage of a known partial structure, one can simply stop the parser from using any spans that would violate the structure.
J97-3002
In all cases, we report our results in terms of alignment quality, using the standard word alignment error metrics: precision, recall, F-measure andalignment error rate (OchandNey, 2003).
J03-1002
B.Taskar, S.Lacoste-Julien, and D.Klein. 2005.
H05-1010
Space Inversion Transduction Grammars, or ITGs (Wu, 1997) provide an efficient formalism to synchronously parse bitext.
J97-3002
