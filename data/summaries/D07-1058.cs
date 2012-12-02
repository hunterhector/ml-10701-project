PCFG enrichment models (Klein and Manning, 2003; Schmid, 2006) split (and merge) nonterminals; in automatic enrichment methods (Prescher, 2005; Petrov et al., 2006) these transformations are performed so as to maximize data likelihood (under some constraints).
P03-1054 P06-1023 P06-1055
Zuidema (2006a) shows that also the estimator (Bod, 2003) uses is biased and inconsistent, and will, even in the limit of in nite data, not correctly identify many possible distributions over trees.
E03-1005 E06-2025 W06-2905
Schmid’s program enriches nonterminal labels in the treebank, using features inspired by (Klein and Manning, 2003).
P03-1054
Moreover, as P-DOP is formulated as an enrichment of the treebank Probabilistic Context-free Grammar (PCFG), it allows for much easier comparison to alternative approaches to statistical parsing (Collins, 1997; Charniak, 1997; Johnson, 1998; Klein and Manning, 2003; Petrov et al., 2006).
J98-4004 P03-1054 P06-1055 P97-1003
For a second set of parsing experiments, we used the WSJ portion of the Penn Tree Bank (Marcus et al., 1993) and Helmut Schmid’s enrichment program tmod (Schmid, 2006).
J93-2004 P06-1023
All state-of-the-art wide-coverage parsers relax this assumption in some way, for instance by (i) changing the parser in step (3), such that the application of rules is conditioned on other steps in the derivation process (Collins, 1997; Charniak, 1997), or by (ii) enriching the nonterminal labels in step (1) with context-information (Johnson, 1998; Klein and Manning, 2003), along with suitable backtransforms in step (4).
J98-4004 P03-1054 P97-1003
This is one reason why the relative frequency estimator for DOP is inconsistent (Johnson, 2002).
J02-1005
The exact relation of P-DOP to other DOP models, including S-DOP (Bod, 2003), Backoff-DOP (Sima’an and Buratto, 2003), DOP* (Zollmann and Sima’an, 2005) and ML-DOP (Bod, 2006; based on Expectation Maximization) and not dissimilar automatic enrichment models such as (Petrov et al., 2006), remains a topic for future work.
E03-1005 P06-1055 P06-1109
The relation between DOP and enrichment/conditioning models was clari ed by Joshua Goodman, who devised an ef cient PCFG transform of the DOP1 model (Goodman, 1996).
W96-0214
For instance, the overrepresentation of but as the sentence-initial CC in the second and third subtree of that gure, is dealt with in (Schmid, 2006) by splitting the CC-category into CC/BUT and CC/AND.
P06-1023
Goodman’s transform, in combination with a range of heuristics, allowed Bod (2003) to run the DOP model on the Penn Treebank WSJ benchmark and obtain some of the best results obtained with a generative model.
E03-1005
Results For our parsing results we use BitPar, a fast and freely available general PCFG parser (Schmid, 2004).
C04-1024
The output of the push-n-pull algorithm is an PTSG, with the same set of elementary trees as the DOP models of Bod (1998; 2001).
P01-1010
Interesting recent work has focused on the automatic induction of enrichments (Matzuzaki et al., 2005; Prescher, 2005), leading to extremely accurate parsers (Petrov et al., 2006).
P06-1055
NNP@1 S/FIN/.@1 NP/BASE NNP NP/BASE@1 NNP@1 NP/BASE@2 Figure 2: Top-10 overrepresented subtrees (excluding subtrees with punctuation) in the WSJ20 corpus, enriched with the tmod program (Schmid, 2006).
P06-1023
Some of its innovations, although radical at the time, are now widely accepted: the use of fragments from the trees in an annotated corpus as the symbolic grammar (now known as treebank grammars, Charniak, 1996) and inclusion of all statistical dependencies between nodes in the trees for disambiguation (the allsubtrees approach, Collins & Duffy, 2002).
P02-1034
This procedure was described in some detail elsewhere (Zuidema, 2006b); here I only sketch the basic idea.
E06-2025 W06-2905
The best known instantiations of the DOPframework are due to Bod (1998; 2001; 2003), using the Probabilistic Tree Substitution Grammar (PTSG) formalism.
E03-1005 P01-1010
In Zuidema (2006b) we give a qualitative analysis of the subtrees with the highest scores as induced from the ATIS treebank, which include many of its frequent constructions including show me NP, I would like NP, ights from NP to NP.
E06-2025 W06-2905
model LR LP F1 CM tb-pcfg 83.27 83.53 83.40 26.58 pnp1000 83.20 83.47 83.33 26.70 pnp10000 83.56 83.99 83.77 26.93 Table 2: Results on the WSJ section of the Penn Tree Bank, where nonterminals are enriched with features using Helmut Schmid’s tmod program (Schmid, 2006).
P06-1023
