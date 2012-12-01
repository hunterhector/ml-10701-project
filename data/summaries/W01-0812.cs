This assumes the existence of a separate higher-level process to produce such a representation, following the canonical pipeline architecture of a full generation system (Reiter, 1994).
W94-0319
The Nitrogen system (Knight & Hatzivassiloglou, 1995; Langkilde & Knight, 1998) made the first significant attempt to integrate statistical knowledge for surface realization.
P95-1034
To date, only limited use of statistically-derived resources has been made for realization in natural language generation, notably Knight & Hatzivassiloglou (1995), Langkilde & Knight (1998) and Bangalore & Rambow (2000).
C00-1007 P95-1034
This contrasts with the exhaustive searches through the grammars in Nitrogen (Langkilde & Knight, 1998) and Fergus (Bangalore & Rambow, 2000), where the generation algorithm operates independently of the statistical resources.
C00-1007
A statistical language model – a lexicalized PCFG (similar to that of Collins, 1997) – is derived from the analysis grammar by processing a corpus using the same grammar with no statistical model and recording frequencies of substructures built by each rule.
P97-1003
Bangalore & Rambow (2000) propose some interesting initial metrics, but we have not yet attempted any comparative experiments.
C00-1007
Bangalore & Rambow (2000) build on the approach of the Nitrogen system but use a language model which does encode some structural information.
C00-1007
The algorithm in fact follows a head-driven node expansion, or search through the grammar, (as in Shieber et al., 1990), with the head of the most recently expanded node being selected for the next expansion (in step 2 of the algorithm above), until a leaf node is produced.
J90-1004
