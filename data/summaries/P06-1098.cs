In the hierarchical phrase-based model (Chiang, 2005), and an inversion transduction grammar (ITG) (Wu, 1997), the problem is resolved by restricting to a binarized form where at most two non-terminals are allowed in the righthand side.
J97-3002 P05-1033
The idea is based on a word-based source channel modeling of Brown et al.(1993): It assumes that eI1 is segmented into a sequence of K phrases ¯eK1 . Each phrase ¯ek is transformed into ¯fk.
J93-2003
The method exhaustively extracts phrase pairs ( f j+mj, ei+ni ) from a sentence pair ( f J1, eI1) that do not violate the word alignment constraints a: ∃(i′, j′)∈a : j′∈[ j, j + m], i′∈[i, i + n] ∄(i′, j′)∈a : j′∈[ j, j + m], i′ nelement [i, i + n] ∄(i′, j′)∈a : j′ nelement [ j, j + m], i′∈[i, i + n] Third, based on the extracted phrases, production rules are accumulated by computing the “holes” for contiguous phrases (Chiang, 2005): 1.
P05-1033
Second, phrase translation pairs are extracted from the word alignment corpus (Koehn et al., 2003).
N03-1017
First, a bilingual corpus is annotated with word alignments using the method of Koehn et al.(2003). Many-to-many word alignments are induced by running a one-to-many word alignment model, such as GIZA++ (Och and Ney, 2003), in both directions and by combining the results based on a heuristic (Koehn et al., 2003).
J03-1002 N03-1017 P03-1021
Chiang (2005) introduced a hierarchical phrasebased translation model that combined the strength of the phrase-based approach and a synchronous-CFG formalism (Aho and Ullman, 1969): A rewrite system initiated from a start symbol which synchronously rewrites paired nonterminals.
P05-1033
Our model is based on Chiang (2005)’s framework, but further restricts the form of production rules so that the aligned right-hand side α follows a GNF-like structure: X ← angbracketleftBig γ, ¯bβ,∼ angbracketrightBig (7) where ¯b is a string of terminals, or a phrase, and beta is a (possibly empty) string of nonterminals.
P05-1033
However, Huang et al.(2005) reported that the computational complexity for decoding amounted to O(J3+3(n−1)) with n-gram even using a hook technique.
W05-1507
γ = γ′ ¯fγ′′ and α = ¯e′¯eβ constitutes a rule X → angbracketleftBig γ′ X k γ′′, ¯e′ X k β angbracketrightBig Following Chiang (2005), we applied constraints when inducing rules with non-terminals: • At least one foreign word must be aligned to an English word.
P05-1033
The hierarchical phrase-based model avoided this problem by introducing the glue rules 5 and 6 that combined hierarchical phrases sequentially (Chiang, 2005).
P05-1033
The procedure is based on those for the hierarchical phrase-based translation model (Chiang, 2005).
P05-1033
A phrase-based translation model is one of the modern approaches which exploits a phrase, a contiguous sequence of words, as a unit of translation (Koehn et al., 2003; Zens and Ney, 2003; Tillman, 2004).
N03-1017 P03-1019 W04-3250
English, eI1 = e1, e2,..., eI by seeking a maximum likely solution of: ˆeI1 = argmax eI1 Pr(eI1|f J1 ) (1) = argmax eI1 Pr( f J1|eI1)Pr(eI1) (2) The source channel approach in Equation 2 independently decomposes translation knowledge into a translation model and a language model, respectively (Brown et al., 1993).
J93-2003
Chiang (2005) proposed a hierarchical phrasebased translation model, a binary synchronousCFG, which restricted the form of production rules as follows: • Only two types of non-terminals allowed: S and X.
P05-1033
Rules are induced from a bilingual corpus without linguistic clues first by extracting phrase translation pairs, and then by generalizing extracted phrases with holes (Chiang, 2005).
P05-1033
In the state of the art statistical machine translation, the posterior probability Pr(eI1|f J1 ) is directly maximized using a log-linear combination of feature functions (Och and Ney, 2002): ˆeI1 = argmax eI1 exp parenleftBigsummationtextM m=1 λmhm(e I 1, f J 1 ) parenrightBig summationtext e′I′1 exp parenleftBigsummationtextM m=1 λmhm(e′ I′ 1, f J 1 ) parenrightBig (3) where hm(eI1, f J1 ) is a feature function, such as a ngram language model or a translation model.
P02-1038
When decoding, the denominator is dropped since it depends only on f J1. Feature function scaling factors λm are optimized based on a maximum likely approach (Och and Ney, 2002) or on a direct error minimization approach (Och, 2003).
J03-1002 P02-1038 P03-1021
