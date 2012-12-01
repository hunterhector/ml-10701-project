(Koehn et al., 2004; Och et al., 2001) used heuristics for pruning implausible hypotheses.
W01-1408
If arbitrary reorderings are allowed, the search problem is NP-complete (Knight, 1999).
J99-4005
The Japanese sentences were automatically dependency-parsed by CaboCha (Kudo et al., 2002) and the Korean sentences were automatically POS tagged by KUTagger (Rim, 2003) 5.2 Translation Systems Four translation systems were implemented for evaluation: 1) Word based IBM-style SMT System(WBIBM), 2) Chunk based IBM-style SMT System(CBIBM), 3) Word based LM tightly Coupled SMT System(WBLMC), and 4) Chunk based LM tightly Coupled SMT System(CBLMC).
W02-2016
Chunk-based Translation We learn chunk alignments from a corpus that has been word-aligned by a training toolkit for wordbased translation models: the Giza++ (Och and Ney, 2000) toolkit for the IBM models (Brown et al., 1993).
J93-2003 P00-1056
To identify chunks, we use a word-aligned corpus, in which source language sentences are annotated with dependency parse trees by a dependency parser (Kudo et al., 2002) and target language sentences are annotated with POS tags by a part-of-speech tagger (Rim, 2003).
W02-2016
Most of the phrase-based translation models have adopted the noisy-channel based IBM style models (Brown et al., 1993): CMCT C1 BD BP CPD6CVD1CPDC CT C1 BD C8D6B4CU C2 BD CYCT C1 BD B5C8D6B4CT C1 BD B5 (1) In these model, we have two types of knowledge: translation model, C8D6B4CU C2 BD CYCT C1 BD B5 and language model, C8D6B4CT C1 BD B5.
J93-2003
Recently, various works have improved the quality of statistical machine translation systems by using phrase translation (Koehn et al., 2003; Marcu et al., 2002; Och et al., 1999; Och and Ney, 2000; Zens et al., 2004).
N03-1017 N04-1033 P00-1056 W02-1018 W99-0604
In order to reduce the number of possible configurations of source words, decoding algorithms based on BT A3 as well as the beam search algorithm have been proposed (Koehn et al., 2004; Och et al., 2001).
W01-1408
