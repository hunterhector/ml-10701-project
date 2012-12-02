A similar formulation using dependency trees derived from TreeBank was reported in Hacioglu (Hacioglu, 2004).
C04-1186 N04-4037 W04-2416
One using the correct CCG parses, and the other using parses obtained using StatCCG4 parser (Hockenmaier and Steedman, 2002).
P02-1043
an important feature in argument identification (Hacioglu et al., 2004) therefore we experimented with four clause-based path feature variations.
C04-1186 N04-4037 W04-2416
We used three features that were introduced by Gildea and Hockenmaier (2003): Phrase type – This is the category of the maximal projection between the two words – the predicate and the dependent word.
W03-1008
Features 3.1 CCG Parse Features While the Path feature has been identified to be very important for the argument identification task, it is one of the most sparse features and may be difficult to train or generalize (Pradhan et al., 2004; Xue and Palmer, 2004).
W04-3212
To address these errors, we added two additional parse representations: i) Minipar dependency parser, and ii) chunking parser (Hacioglu et al., 2004).
C04-1186 N04-4037 W04-2416
Parallel to the hand-corrected TreeBank parses, we also had access to correct CCG parses derived from the TreeBank (Hockenmaier and Steedman, 2002a).
P02-1043
In the first set of experiments we explore new 581 features, including features extracted from a parser that provides a different syntactic view – a Combinatory Categorial Grammar (CCG) parser (Hockenmaier and Steedman, 2002).
P02-1043
We formulate the semantic labeling problem as a multi-class classification problem using Support Vector Machine (SVM) classifier (Hacioglu et al., 2003; Pradhan et al., 2003; Pradhan et al., 2004) TinySVM2 along with YamCha3 (Kudo and Mat1http://www.cis.upenn.edu/˜ace/ 2http://chasen.org/˜taku/software/TinySVM/ 3http://chasen.org/˜taku/software/yamcha/ Sa104a104 a104a104a40a40a40a40 NPa104a104 a104a104a40a40a40a40 The acquisition ARG1 VPa96a96 a96a96a32a32a32a32VBD was NULL VPa88 a88a88a24a24a24VBN completed predicate PPa96 a96a96a96a32a32a32a32 in September ARGM−TMP [ARG1 The acquisition] was [predicate completed] [ARGM−TMP in September].
C04-1186 N03-2009 N04-4037 W04-2416
Semantic Role Labeling is the process of annotating the predicate-argument structure in text with se∗This research was partially supported by the ARDA AQUAINT program via contract OCG4423B and by the NSF via grants IS-9978025 and ITR/HCI 0086132 mantic labels (Gildea and Jurafsky, 2000; Gildea and Jurafsky, 2002; Gildea and Palmer, 2002; Surdeanu et al., 2003; Hacioglu and Ward, 2003; Chen and Rambow, 2003; Gildea and Hockenmaier, 2003; Pradhan et al., 2004; Hacioglu, 2004).
C04-1186 J02-3001 N03-2009 N04-4037 P00-1065 P02-1031 P03-1002 W03-1006 W03-1008 W04-2416
Again, TinySVM5 along with YamCha6 (Kudo and Matsumoto, 2000; Kudo and Matsumoto, 2001) are used as the SVM training and test software.
N01-1025 W00-0730
5.2 Chunk-based Semantic Labeler Hacioglu has previously described a chunk based semantic labeling method (Hacioglu et al., 2004).
C04-1186 N04-4037 W04-2416
A more realistic way to score the performance is to score tags assigned to head words of constituents, rather than considering the exact boundaries of the constituents as reported by Gildea and Hockenmaier (2003).
W03-1008
System For our experiments, we use Feb 2004 release of PropBank1 (Kingsbury and Palmer, 2002; Palmer et al., 2005), a corpus in which predicate argument relations are marked for verbs in the Wall Street Journal (WSJ) part of the Penn TreeBank (Marcus et al., 1994).
H94-1020 J05-1004
The baseline feature set is a combination of features introduced by Gildea and Jurafsky (2002) and ones proposed in Pradhan et al., (2004), Surdeanu et al., (2003) and the syntactic-frame feature proposed in (Xue and Palmer, 2004).
J02-3001 P02-1031 P03-1002 W03-1008 W04-3212
Gildea and Hockenmaier (2003) report that using features extracted from a Combinatory Categorial Grammar (CCG) representation improves semantic labeling performance on core arguments.
W03-1008
In experiments reported by Hacioglu (Hacioglu, 2004), a mismatch of about 8% was introduced in the transformation from handcorrected constituent trees to dependency trees.
C04-1186 N04-4037 W04-2416
For each argument, we started with the set of features introduced by (Gildea and Jurafsky, 2002).
J02-3001 P02-1031
We investigate ways to combine hypotheses generated from semantic role taggers trained using different syntactic views – one trained using the Charniak parser (Charniak, 2000), another on a rule-based dependency parser – Minipar (Lin, 1998), and a third based on a flat, shallow syntactic chunk representation (Hacioglu, 2004a).
A00-2018 C04-1186 N04-4037 W04-2416
In case of the CCG parses, as reported by Gildea and Hockenmaier (2003), the mismatch was about 23%.
W03-1008
sumoto, 2000; Kudo and Matsumoto, 2001) are used to implement the system.
N01-1025
