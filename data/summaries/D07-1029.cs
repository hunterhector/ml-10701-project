For example, in the multi-engine machine translation system (Nirenburg and Frederking, 1994), target language phrases from each system and their corresponding source phrases are recorded in a chart structure, together with their confidence scores.
H94-1026
These include phrase-based statistical MT systems (Al-Onaizan and Papineni, 2006) (Block) and (Hewavitharana et al., 2005) (CMU SMT), a direct translation model (DTM) system (Ittycheriah and Roukos, 2007) and a hierarchical phrased-based MT system (Hiero) (Chiang, 2005).
N07-1008 P05-1033 P06-1067
(Rosti et al., 2007) extracts phrase translation pairs in the phrase level combination.
N07-1029
(Jayaraman and Lavie, 2005) proposed another black-box system combination strategy.
P05-3026
This is similar to the sentenceand wordlevel combinations in (Rosti et al., 2007), where TER is used to align multiple hypotheses.
N07-1029
(Matusov et al., 2006) computes consensus translation by voting on a confusion network, which is created by pairwise word alignment of multiple baseline MT hypotheses.
E06-1005
The final translation may be selected by voted language models and appropriate confidence rescaling schemes ((Tidhar and Kuss1http://www.darpa.mil/ipto/programs/gale/index.htm 277 ner, 2000) and (Nomoto, 2004)).
C00-2122 P04-1063
−logp(e|f), a source-to-target word translation cost, calculated similar to −logp(f|e); S(e,f), a phrase translation cost estimated according to their relative alignment frequency in the bilingual training data, S(e,f) = −logP(e|f) = −log C(f,e)C(f). (3) λ’s in Equation 1 are the weights of different feature functions, learned to maximize development set BLEU scores using a method similar to (Och, 2003).
P03-1021
(Matusov et al., 2006) and (Rosti et al., 2007) constructed a confusion network from multiple MT hypotheses, and a consensus translation is selected by redecoding the lattice with arc costs and confidence scores.
E06-1005 N07-1029
