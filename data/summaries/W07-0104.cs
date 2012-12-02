As per ((Di Eugenio & Glass, 2004), cf.
J04-1005
Mason. 2004.
J04-1002
The sentences in the target set and feedback sets were augmented with some shallow syntactic information such as part of speech tags provided 22 Algorithm 1 KE-train: (Karov & Edelman, 1998) algorithm adapted to literal/nonliteral identification Require: S: the set of sentences containing the target word (each sentence is classified as literal/nonliteral) Require: L: the set of literal seed sentences Require: N: the set of nonliteral seed sentences Require: W: the set of words/features, w ∈ s means w is in sentence s, s owner w means s contains w Require: epsilon1: threshold that determines the stopping condition 1: w-sim0(wx,wy) := 1 if wx = wy,0 otherwise 2: s-simI0(sx,sy) := 1, for all sx,sy ∈ S ×S where sx = sy, 0 otherwise 3: i := 0 4: while (true) do 5: s-simLi+1(sx,sy) :=summationtextwx∈sx p(wx,sx)maxwy∈sy w-simi(wx,wy), for all sx,sy ∈ S ×L 6: s-simNi+1(sx,sy) :=summationtextwx∈sx p(wx,sx)maxwy∈sy w-simi(wx,wy), for all sx,sy ∈ S ×N 7: for wx,wy ∈ W ×W do 8: w-simi+1(wx,wy) := braceleftBigg i = 0 summationtextsxownerwx p(wx,sx)maxsyownerwy s-simIi(sx,sy) else summationtextsxownerwx p(wx,sx)maxsyownerwys-simLi (sx,sy), s-simNi (sx,sy)} 9: end for 10: if ∀wx,maxwyw-simi+1(wx,wy)− w-simi(wx,wy)} ≤ epsilon1 then 11: break # algorithm converges in 1epsilon1 steps.
J98-1002
(Karov & Edelman, 1998) state that the results are not likely to change much after the third iteration and we have confirmed this independently: similarity values continue to change until convergence, but cluster allegiance tends not to.
J98-1002
12: end if 13: i := i + 1 14: end while by a statistical tagger (Ratnaparkhi, 1996) and SuperTags (Bangalore & Joshi, 1999).
J99-2004
Since we are attempting to reduce the problem of literal/nonliteral recognition to one of word-sense disambiguation, we use an existing similarity-based word-sense disambiguation algorithm developed by (Karov & Edelman, 1998), henceforth KE.
J98-1002
By finding semantic differences between the selectional preferences, it can “articulate the higher-order structure of conceptual metaphors” ((Mason, 2004), p.
J04-1002
al., 2000; Nissim & Markert, 2003; Mason, 2004).
J04-1002 P03-1008
Mason (2004) presents CorMet, “a corpus-based system for discovering metaphorical mappings between concepts” ((Mason, 2004), p.
J04-1002
27 Nissim & Markert (2003) approach metonymy resolution with machine learning methods, “which [exploit] the similarity between examples of conventional metonymy” ((Nissim & Markert, 2003), p.
P03-1008
