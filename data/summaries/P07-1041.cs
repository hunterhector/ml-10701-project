According to the inv metric, our results are considerably worse than those reported by Ringger et al.(2004). As mentioned in Section 3, the fact that they generate the order for every non-terminal node seriously in ates their numbers.
C04-1097
Bigram Model Similar to Ringger et al.(2004), we nd the order with the highest probability conditioned on syntactic and semantic categories.
C04-1097
E.g., in text-to-text generation (Barzilay & McKeown, 2005; Marsi & Krahmer, 2005; Wan et al., 2005), new sentences are fused from dependency structures of input sentences.
J05-3002 W05-1612 W05-1628
The TnT tagger (Brants, 2000) and the TreeTagger (Schmid, 1997) are used for tagging and lemmatization.
A00-1031
Kruijff et al.(2001) describe an architecture which supports generating the appropriate word order for different languages.
W01-0810
Finally, the articles are parsed with the CDG dependency parser (Foth & Menzel, 2006).
P06-1041
The work of Uchimoto et al.(2000) is done on the free word order language Japanese.
C00-2126
Ringger et al.(2004) aim at regenerating the order of constituents as well as the order within them for German and French technical manuals.
C04-1097
For the fourth baseline (UCHIMOTO), we utilized a maximum entropy learner (OpenNLP8) and reimplemented the algorithm of Uchimoto et al.(2000). For every possible permutation, its probability is estimated according to Formula (1).
C00-2126
With these adjustments the probability of an order O given the history h, if conditioned on syntactic functions of constituents (s1...sn), is simply: P(O|h) = nproductdisplay i=1 P(si|si−1,h) (4) Ringger et al.(2004) do not make explicit, what their set of semantic relations consists of.
C04-1097
The preferences summarized below have mo320 tivated our choice of features: • constituents in the nominative case precede those in other cases, and dative constituents often precede those in the accusative case (Uszkoreit, 1987; Keller, 2000); • the verb arguments’ order depends on the verb’s subcategorization properties (Kurz, 2000); • constituents with a de nite article precede those with an inde nite one (Weber & Mcurrency1uller, 2004); • pronominalized constituents precede nonpronominalized ones (Kempen & Harbusch, 2004); • animate referents precede inanimate ones (Pappert et al., 2007); • short constituents precede longer ones (Kimball, 1973); • the preferred topic position is right after the verb (Frey, 2004); • the initial position is usually occupied by scene-setting elements and topics (Speyer, 2005).
W04-1911
Apart from acc and τ, we also adopt the metrics used by Uchimoto et al.(2000) and Ringger et al.(2004). The former use agreement rate (agr) calculated as 2pN(N−1): the number of correctly ordered pairs of constituents over the total number of all possible pairs, as well as complete agreement which is basically per-sentence accuracy.
C00-2126 C04-1097
Harbusch et al.(2006) present a generation workbench, which has the goal of producing not the most appropriate order, but all grammatical ones.
W06-1402
Unlike overgeneration approaches (Varges & Mellish, 2001, inter alia) which select the best of all possible outputs ours is more ef cient, because we do not need to generate every permutation.
N01-1001
Ringger et al.(2004) evaluate the performance only in terms of per-constituent edit distance calculated as mN, where m is the minimum number of moves11 10Since subordinate clauses do not have a VF, the rst step is not needed.
C04-1097
