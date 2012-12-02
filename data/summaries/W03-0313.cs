This contrasts with alternative alignment models such as those of Melamed (1998) and Wu (1997), which impose a “one-to-one” constraint on alignments.
J97-3002
[Brown et al.1993] Peter F.
J93-2003
[Wu1997] Dekai Wu.
J97-3002
Brown. 1996.
C96-1030
[Marcu2001] Daniel Marcu.
P01-1050
[Osborne2000] Miles Osborne.
W00-0731
[Brown1996] Ralf D.
C96-1030
For the purpose of statistical translation modeling, Brown et al.(1993) define an alignment as a vector a = a1...am that connects each word of a source-language text S = s1...sm to a target-language word in its translation T = t1...tn, with the interpretation that word taj is the translation of word sj in S (aj = 0 is used to denote words of s that do not produce anything in T).
J93-2003
The English version of this document was segmented into syntactic chunks, using an implementation of Osborne’s chunker (Osborne, 2000).
W00-0731
Translation spotting finds different applications, for example in bilingual concordancers, such as the TransSearch system (Macklovitch et al., 2000), and example-based machine translation (Brown, 1996).
C96-1030
This approach is not dependent on the underlying translation model, and similar methods could certainly be devised based on more elaborate models, such as IBM Models 3–5, or the HMM-based models proposed by Och et al.(1999) for example.
W99-0604
It is interesting to note that this method is equivalent to the one proposed by Marcu (Marcu, 2001) to automatically construct a sub-sentential translation memory.
P01-1050
[Och et al.1999] Franz Josef Och, Christoph Tillmann, and Hermann Ney.
W99-0604
These methods are based on IBM statistical translation Model 2 (Brown et al., 1993), but take advantage of certain characteristics of the segments of text that can typically be extracted from translation memories.
J93-2003
