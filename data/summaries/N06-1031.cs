Annotation Another common relabeling method in parsing is parent annotation (Johnson, 1998), in which a node is annotated with its parent’s label.
J98-4004
Typically, this is done only to nonterminals, but Klein and Manning (2003) found that annotating preterminals as well was highly effective.
P03-1054
The yield of this tree gives the target translation: the gunman was killed by police . The Penn English Treebank (PTB) (Marcus et al., 1993) is our source of syntactic information, largely due to the availability of reliable parsers.
J93-2004
To determine if a BLEU score increase or decrease is meaningful, we calculate statistical signi cance at 95% using paired bootstrap resampling (Koehn, 2004; Zhang et al., 2004) on 1,000 samples.
W04-3250
Klein and Manning (2003) discuss this as a problem in parsing and demonstrate that annotating additional information onto the PTB tags leads to improved parsing performance.
P03-1054
The English half was parsed with a reimplementation of Collins’ Model 2 (Collins, 1999) and the two halves were wordaligned using GIZA++ (Och and Ney, 2000).
P00-1056
Step 2 involves extracting minimal xRS rules (Galley et al., 2004) from the set of string/tree/alignments triplets.
N04-1035
The last two methods are drawn directly from Klein and Manning (2003).
P03-1054
Recent work in statistical machine translation (MT) has sought to overcome the limitations of phrasebased models (Marcu and Wong, 2002; Koehn et al., 2003; Och and Ney, 2004) by making use of syntactic information.
J04-4002 N03-1017 W02-1018 W04-3250
In this work, we employ a syntax-based model that applies a series of tree/string (xRS) rules (Galley et al., 2004; Graehl and Knight, 2004) to a source language string to produce a target language phrase structure tree.
N04-1014 N04-1035
Some approaches have used syntax at the core (Wu, 1997; Alshawi et al., 2000; Yamada and Knight, 2001; Gildea, 2003; Eisner, 2003; Hearne and Way, 2003; Melamed, 2004) while others have integrated syntax into existing phrase-based frameworks (Xia and McCord, 2004; Chiang, 2005; Collins et al., 2005; Quirk et al., 2005).
C04-1073 J00-1004 J97-3002 P01-1067 P03-1011 P03-2041 P04-1083 P05-1033 P05-1034 P05-1066
Klein and Manning (2003) make a similar proposal but omit do.
P03-1054
In the nal step, we score our translations with 4-gram BLEU (Papineni et al., 2002).
P02-1040
