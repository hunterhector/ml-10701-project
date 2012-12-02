Mason (2004) presents CorMet, “a corpusbased system for discovering metaphorical mappings between concepts” ((Mason, 2004), p.
J04-1002
al., 2000; Nissim&Markert, 2003; Mason, 2004).
J04-1002 P03-1008
Mason. 2004.
J04-1002
As per ((Di Eugenio & Glass, 2004), cf.
J04-1005
Data The TroFi algorithm requires a target set (called original set in (Karov & Edelman, 1998)) – the set of sentences containing the verbs to be classified into literal or nonliteral – and the seed sets: the literal feedback set and the nonliteral feedback set.
J98-1002
SuperTags (Bangalore & Joshi, 1999) encode a great deal of syntactic information in a single tag (each tag is an elementary tree from the XTAG English Tree Adjoining Grammar).
J99-2004
By finding semantic differences between the selectional preferences, it can “articulate the higher-order structure of conceptual metaphors” ((Mason, 2004), p.
J04-1002
Nissim & Markert (2003) approach metonymy resolution with machine learning methods, “which [exploit] the similarity between examples of conventional metonymy” ((Nissim & Markert, 2003), p.
P03-1008
The target set is built using the ’88-’89 Wall Street Journal Corpus (WSJ) tagged using the (Ratnaparkhi, 1996) tagger and the (Bangalore & Joshi, 1999) SuperTagger; the feedback sets are built using WSJ sentences con330 Algorithm 1 KE-train: (Karov & Edelman, 1998) algorithm adapted to literal/nonliteral classification Require: S: the set of sentences containing the target word Require: L: the set of literal seed sentences Require: N: the set of nonliteral seed sentences Require: W: the set of words/features, w ∈ s means w is in sentence s, s owner w means s contains w Require: epsilon1: threshold that determines the stopping condition 1: w-sim0(wx,wy) := 1 if wx = wy,0 otherwise 2: s-simI0(sx,sy) := 1, for all sx,sy ∈ S ×S where sx = sy, 0 otherwise 3: i := 0 4: while (true) do 5: s-simLi+1(sx,sy) := summationtextwx∈sx p(wx,sx)maxwy∈sy w-simi(wx,wy), for all sx,sy ∈ S ×L 6: s-simNi+1(sx,sy) := summationtextwx∈sx p(wx,sx)maxwy∈sy w-simi(wx,wy), for all sx,sy ∈ S ×N 7: for wx,wy ∈ W ×W do 8: w-simi+1(wx,wy) := braceleftBigg i = 0 summationtextsxownerwx p(wx,sx)maxsyownerwy s-simIi(sx,sy) else summationtextsxownerwx p(wx,sx)maxsyownerwys-simLi (sx,sy),s-simNi (sx,sy)} 9: end for 10: if ∀wx,maxwyw-simi+1(wx,wy)−w-simi(wx,wy)} ≤ epsilon1 then 11: break # algorithm converges in 1epsilon1 steps.
J98-1002 J99-2004 W96-0213
Algorithm Since we are attempting to reduce the problem of literal/nonliteral recognition to one of word-sense disambiguation, TroFi makes use of an existing similarity-based word-sense disambiguation algorithm developed by (Karov & Edelman, 1998), henceforth KE.
J98-1002
