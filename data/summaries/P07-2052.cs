Dependency parsing has been actively studied in recent years (Yamada and Matsumoto, 2003; Nivre and Scholz, 2004; Isozaki et al., 2004; McDonald et al., 2005; McDonald and Pereira, 2006; Corston-Oliver et al., 2006).
C04-1010 C04-1040 E06-1011 N06-1021 P05-1012
Bikel. 2004.
J04-4004
Unlexicalized parsers, on the other hand, achieved accuracies almost equivalent to those of lexicalized parsers (Klein and Manning, 2003; Matsuzaki et al., 2005; Petrov et al., 2006).
P03-1054 P05-1010 P06-1055
Comparison with previous best results: KM01 (Kudoh and Matsumoto, 2001), CM03 (Carreras and Marquez, 2003), SP03 (Sha and Pereira, 2003), ZDJ02 (Zhang et al., 2002).
N01-1025
McDonald et al.proposed an online large-margin method for training dependency parsers (McDonald et al., 2005).
P05-1012
the Penn Treebank into training and testing parts in the same way as (Roark and Bacchiani, 2003).
N03-1027
For instance, Nivre and Scholz presented a deterministic dependency parser trained by memory-based learning (Nivre and Scholz, 2004).
C04-1010
Work Klein and Manning presented an unlexicalized PCFG parser that eliminated all the lexicalized parameters (Klein and Manning, 2003).
P03-1054
Dependency Parser We built a parser based on the deterministic algorithm of Nivre and Scholz (Nivre and Scholz, 2004) as a base dependency parser.
C04-1010
Previous best results: FIJZ03 (Florian et al., 2003), CN03 (Chieu and Ng, 2003), KSNM03 (Klein et al., 2003).
P03-1054
splitting tags (Matsuzaki et al., 2005; Petrov et al., 2006).
P05-1010 P06-1055
Following Pradhan et al.(2003), we used tinySVM along with YamCha (Kudo and Matsumoto 2000, 2001) as the SVM training and test software.
N01-1025
So far, various supervised learning approaches have been explored in this field (Culotta and Sorensen, 2004; Zelenko et al., 2003).
P04-1054
In recent years, many accurate phrase-structure parsers have been developed (e.g., (Collins, 1999; Charniak, 2000)).
A00-2018
Dependency trees have been used in a variety of NLP applications, such as relation extraction (Culotta and Sorensen, 2004) and machine translation (Ding and Palmer, 2005).
P04-1054 P05-1067
In the algorithm, parsing states are represented by triples ?S,I,A?? where S is the stack that keeps the words being under consideration, I is the list of reDA RA CR (Yamada and Matsumoto, 2003) 90.3 91.6 38.4 (Nivre and Scholz, 2004) 87.3 84.3 30.4 (Isozaki et al., 2004) 91.2 95.7 40.7 (McDonald et al., 2005) 90.9 94.2 37.5 (McDonald and Pereira, 2006) 91.5 N/A 42.1 (Corston-Oliver et al., 2006) 90.8 93.7 37.6 Our Base Parser 90.9 92.6 39.2 Table 2: Comparison of parser performance.
C04-1010 C04-1040 E06-1011 N06-1021 P05-1012
Kudoh and Matsumoto (2001), Zhang and Johnson (2003)).
N01-1025
Bikel also indicated that Collins??parser can use bilexical dependencies only 1.49% of the time; the rest of the time, itbacksofftoconditiononewordonjustphrasaland part-of-speech categories (Bikel, 2004).
J04-4004
During the testing phase, we used automatically assigned POS and chunk tags by Tsuruoka?s tagger4(Tsuruoka and Tsujii, 2005) and YamCha chunker5(Kudo and Matsumoto, 2001).
H05-1059 N01-1025
