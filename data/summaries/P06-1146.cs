Furthermore, corpora labelled with semantic role information can be used to train shallow semantic parsers (Gildea and Jurafsky, 2002), which could in turn benefit applications in need of broad-coverage semantic analysis.
J02-3001
A similar approach is described in Collins et al.(2005); however, the rules are manually specified and the constituent alignment step reduces to inspection of the source-target sentence pairs.
P05-1066
Other approaches treat rewrite rules not as a preprocessing step (e.g., for reordering source strings), but as a part of the translation model itself (Gildea, 2003; Gildea, 2004).
P03-1011 W04-3228
1See Carreras and Màrquez (2005) for an overview of recent approaches to semantic parsing.
W05-0620
Previous research addresses this problem in a post-processing step, by reestimating parameter values (Yarowsky and Ngai, 2001), by applying transformation rules (Hwa et al., 2002), by using manually labelled data (Hi and Hwa, 2005), or by relying on linguistic criteria (Padó and Lapata, 2005).
H01-1035 P02-1050
Argument filtering Previous work in shallow semantic parsing has demonstrated that not all nodes in a tree are equally probable as semantic roles for a given predicate (Xue and Palmer, 2004).
W04-3212
For example, Xia and McCord (2004) exploit constituent alignment for rearranging sentences in the source language so as to make their word or6Our results on the test set are slightly higher in comparison to the development set.
C04-1073
A number of recent studies rely on this notion of parallelism and demonstrate that annotations can be adequately projected for parts of speech (Yarowsky and Ngai, 2001; Hi and Hwa, 2005),chunks(YarowskyandNgai,2001),anddependencies (Hwa et al., 2002).
H01-1035 P02-1050
Following common practiseinMT(Koehnetal.,2003),weconsidered only their intersection (bidirectional alignments are known to exhibit high precision).
N03-1017
An exception is Fung and Chen (2004), who also attempt to induce FrameNet-style annotations in Chinese.
C04-1134
work Previous work has primarily focused on the projectionofgrammatical(YarowskyandNgai,2001) and syntactic information (Hwa et al., 2002).
H01-1035 P02-1050
The sentences were automatically parsed (using Collin’s 1997 parser for English and Dubey’s 2005 parser for German), and manually annotated with FrameNet-like semantic roles (see Padó and Lapata 2005 for details.) Word alignments were computed with the GIZA++ toolkit (Och and Ney, 2003), using the 3The corpus can be downloaded from http://www.
J03-1002 P05-1039
