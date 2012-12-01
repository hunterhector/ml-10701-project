Following this information content-based model, in measuring the semantic similarity between unknown word and its candidate nearsynonymic words, we use a measure metric modelled on those of Chen and Chen (2000), which is a simplification of the Resnik algorithm by assuming that the occurrence probability of each leaf node is equal.
C00-1026
Among the current similar works, Table 4 shows that our system outperforms Chen(2004) in VV compounds, and approximates the Chen and Chen(2000) in NN compounds.
C00-1026 W04-1106
To solve above-mentioned problems, Chen (2004) proposed a non head-oriented charactersense association model to retrieve the latent senses of characters and the latent synonymous compounds among characters by measuring similarity of semantic template in compounding by using a MRD.
W04-1106
In Chen (2004), the combination pattern is referred to as compounding semantic template.
W04-1106
Difficulties encountered in previous researches could be summarized as follows: First, many models (Chen and Chen 1998;2000) cannot deal with the issue of “incompleteness” of characters in the lexicon, for these models depend heavily on CILIN, a Chinese Thesaurus containing only about 4,133 monosyllabic morphemic components (characters).
C00-1026
Third, it has long been assumed (Lua 1997; Chen and Chen 2000) that the overwhelming majority of Chinese compounds are more or less endocentric, where the compounds denote a hyponym of the head component in the compound.
C00-1026
“Head-oriented” Presupposition As remarked in Chen (2004), the previous research concerning the automatic semantic classification of Chinese compounds (Lua 1997; Chen and Chen 2000) presupposes the endocentric feature of compounds.
C00-1026 W04-1106
In many empirical studies (Tseng and Chen (2002); Tseng (2003); Lua (1993); Chen (2004)), this view has been confirmed repeatedly.
W04-1106
Among these types of unknown words, Chen and Chen (2000) pointed out that compound words constitute the most productive type of unknown words in Chinese texts.
C00-1026
The Information Load (IL) of a semantic class sc is defined in Chen and Chen (2004): IL(sc) = Entropy(system) −Entropy(sc) (3) similarequal (−1q summationdisplay log2 1q) − (−1p summationdisplay log2 1p) = log2 q − log2 p = −log2(pq), if there is q the number of the minimal semantic classes in the system,8 p is the number of the semantic classes subordinate sc.
W04-1106
• The quality and coverage of CILIN and character ontology: Since our SC system’s test and training data are gleaned from CILIN and the character Compound types Our model Current best model V-V 42.00% 39.80% (Chen 2004) N-N 72.50% 81.00% (Chen and Chen 2000) Table 4: Level-3 performance in the outside test: a comparison ontology, the quality and coverage play a crucial role.
C00-1026 W04-1106
