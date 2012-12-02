Collins (1996) split the sentence label S into two versions, representing sentences with and without subjects.
P96-1025
Pereira and Schabes (1992) estimate PCFG parameters from partially bracketed sentences, using the inside-outside algorithm to induce the missing brackets and the missing node labels.
P92-1017
Simplified equation for inside probabilities (ignores unary rules) Matsuzaki et al.(2005) test: O(n3L3) train: O(nL3) d.f.: L3R3 + L2R2 +LR1−LN BX[α](i,k) = X Y,β,Z,γ,j P(X[α] → Y [β] Z[γ]) (4) ×BY [β](i,j)×BZ[γ](j,k) INHERIT model (this paper) test: O(n3L) train: O(nL) d.f.: L(R3 + R2 + R1) + 3R3 −N BX[α](i,k) = X Y,Z,j P(X[α] → Y Z) (5) × 0 B@ P(neither | X,Y,Z) × BY (i,j) × BZ(j,k)) + P(left | X,Y,Z) × BY [α](i,j) × BZ(j,k)) + P(right | X,Y,Z) × BY (i,j) × BZ[α](j,k)) + P(both | X,Y,Z) × BY [α]Y (i,j) × BZ[α](j,k)) 1 CA BX(i,j) = X α Pann(α | X)×BX[α](i,j) (6) P(left | X,Y,Z) =  P(head | X,Y,Z) if Y heads X →Y Z P(nonhead | X,Y,Z) otherwise (7) P(right | X,Y,Z) =  P(head | X,Y,Z) if Z heads X → Y Z P(nonhead | X,Y,Z) otherwise (8) Table 2: Comparison of the PCFG-LA model with the INHERIT model proposed in this paper.
P05-1010
Grammars 3.1 The PCFG-LA Model Staying in the partially supervised paradigm, the PCFG-LA model described in Matsuzaki et al.(2005) observe whole treebank trees, but learn an “annotation” on each nonterminal token—an unspecified and uninterpreted integer that distinguishes otherwise identical nonterminals.
P05-1010
Following Matsuzaki et al.(2005) and Prescher (2005), we may for example split NP without supervision into NP[0] andNP[1], which behave differently.
P05-1010 W05-1512
We used sections 2–20 of the Penn Treebank 2 Wall Street Journal corpus (Marcus et al., 1993) for training, section 22 as development set and section 23 for testing.
J93-2004
The head child of each node is given deterministically by the head rules of (Collins, 1996).
P96-1025
He 1Not to mention earlier non-PCFG lexicalized statistical parsers, notably Magerman (1995) for the Penn Treebank.
P95-1037
– Matsuzaki et al.(2005) used a markovized grammar to get a better unannotated parse forest during decoding, but they did not markovize the training data.
P05-1010
During early iterations, we could use a prior to encourage a strong positive weight on these inheritance features, and gradually relax this bias—akin to the “structural annealing” of (Smith and Eisner, 2006).
P06-1072
Chiang and Bikel (2002) induces the missing head-child information; Prescher (2005) induces both the head-child information and the latent annotations we will now discuss.
C02-1126 W05-1512
Before extracting the backbone PCFG and running the constrained inside-outside (EM) training algorithm, we preprocessed the Treebank using center-parent binarization Matsuzaki et al.(2005). Besides making the rules at most binary, this preprocessing also helpfully enriched the backbone nonterminals.
P05-1010
all but the first (“Basic”) experiments, we also enriched the nonterminals with order-1 horizontal and order-2 vertical markovization (Klein and Manning, 2003).7 Figure 4 shows what a multiplechild structure X → A B H C D looks like after binarization and markovization.
P03-1054
With these techniques we reach a parsing accuracy similar to Matsuzaki et al.(2005), but with an order of magnitude less parameters, resulting in more efficient parsing.
P05-1010
Following Matsuzaki et al.(2005), words occurring fewer than 4 times in the training corpus were replaced by unknown-word symbols that encoded certain suffix and capitalization information.
P05-1010
After automatically inducing the annotations with EM, their resulting parser performs just as well as one learned from a treebank whose nonterminals were manually refined through linguistic and error analysis (Klein and Manning, 2003).
P03-1054
Charniak (1997) and Johnson (1998) annotated each node with its parent and grandparent nonterminals, to more precisely reflect its “outside” context.
J98-4004
Eisner (1996), Charniak (1997), Collins (1997), and many subsequent researchers1 annotated every node with lexical features passed up from its “head child,” in order to more precisely reflect the node’s “inside” contents.
C96-1058 P97-1003
It would seem that different coarse-grained nonterminals in the original Penn Treebank have different degrees of impurity (Klein and Manning, 2003).
P03-1054
Lari and Young (1990) Words Parse tree Pereira and Schabes (1992) Words and partial brackets Parse tree Klein and Manning (2001) Part-of-speech tags Parse tree Chiang and Bikel (2002) Treebank tree Head child on each nonterminal Matsuzaki et al.(2005) Treebank tree Integer feature on each nonterminal INHERIT model (this paper) Treebank tree and head child heuristics Integer feature on each nonterminal Table 1: Observed and hidden data in PCFG grammar learning.
C02-1126 P05-1010 P92-1017 W01-0714
The “Basic” block of experiments in Table 3 used non-markovized grammars, as in Matsuzaki et al.(2005). The next block of experiments, introducing markovized grammars, shows a considerable improvement.
P05-1010
Matsuzaki et al.(2005) introduced a model for such learning: PCFG-LA.2 They used EM to induce fine-grained versions of a given treebank’s nonterminals and rules.
P05-1010
Magerman. 1995.
P95-1037
“Basic” models are trained on a non-markovized treebank (as in Matsuzaki et al.(2005)); all others are trained on a markovized treebank.
P05-1010
Klein and Manning (2003) identified nonterminals that could valuably be split into fine-grained ones using hand-written linguistic rules.
P03-1054
Just as Collins manually split the S nonterminal label into S and SG for sentences with and without subjects, Matsuzaki et al.(2005) split S into S[1], S[2],. . ., S[L] where L is a predefined number—but they do it automatically and systematically, and not only for S but for every nonterminal.
P05-1010
Matsuzaki et al.(2005) note that the best annotated parse is in fact NP-hard to find.
P05-1010
317 Citation Observed data Hidden data Collins (1997) Treebank tree with head child annotated on each nonterminal No hidden data.
P97-1003
321 Jensen-Shannon divergence is defined as D(q,r) = 12 parenleftbigg D parenleftbigg q|| q +r2 parenrightbigg +D parenleftbigg r|| q +r2 parenrightbiggparenrightbigg These experiments are a kind of “poor man’s version” of the deterministic annealing clustering algorithm (Pereira et al., 1993; Rose, 1998), which gradually increases the number of clusters during the clustering process.
P93-1024
A well-known example is the training of the IBM models for statistical machine translation (Berger et al., 1994).
H94-1028
