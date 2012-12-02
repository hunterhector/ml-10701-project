That work extends the maximum spanning tree dependency parsing framework (McDonald et al., 2005a; McDonald et al., 2005b) to incorporate features over multiple edges in the dependency graph.
H05-1066 P05-1012
The first stage is based on the unlabeled dependency parsing models described by McDonald and Pereira (2006) augmented with morphological features for a subset of the languages.
E06-1011 E06-1038
We use the MIRA 217 online learner to set the weights (Crammer and Singer, 2003; McDonald et al., 2005a) since we found it trained quickly and provide good performance.
H05-1066 P05-1012
We evaluate this parser on a diverse set of 13 languages using data provided by the CoNLL-X shared-task organizers (Buchholz et al., 2006; Hajiˇc et al., 2004; Simov et al., 2005; Simov and Osenova, 2003; Chen et al., 2003; B¨ohmov´a et al., 2003; Kromann, 2003; van der Beek et al., 2002; Brants et al., 2002; Kawata and Bartels, 2000; Afonso et al., 2002; Dˇzeroski et al., 2006; Civit Torruella and Mart´ı Anton´ın, 2002; Nilsson et al., 2005; Oflazer et al., 2003; Atalay et al., 2003).
W06-2920
McDonald. 2006.
E06-1011 E06-1038
These results show that the discriminative spanning tree parsing framework (McDonald et al., 2005b; McDonald and Pereira, 2006) is easily adapted across all these languages.
E06-1011 E06-1038 H05-1066 P05-1012
This system is primarily based on the parsing models described by McDonald and Pereira (2006).
E06-1011 E06-1038
This has been shown through their successful use in many standard natural language processing tasks, including machine translation (Ding and Palmer, 2005), sentence compression (McDonald, 2006), and textual inference (Haghighi et al., 2005).
E06-1011 E06-1038 H05-1049 H05-1066 P05-1012 P05-1067
al. (McDonald et al., 2005b; McDonald and Pereira, 2006) generalizes well to languages other than English.
E06-1011 E06-1038 H05-1066 P05-1012
Furthermore, it made the system homogeneous in terms of learning algorithms since that is what is used to train our unlabeled parser (McDonald and Pereira, 2006).
E06-1011 E06-1038
For instance, the system of McDonald et al.(2005a) incorporates features over the part of speech of words occurring between and around a possible head-dependent relation.
H05-1066 P05-1012
In fact, for every language our models perform significantly higher than the average performance for all the systems reported in Buchholz et al.(2006). For the remainder of the paper we provide a general error analysis across a wide set of languages plus a detailed error analysis of Spanish and Arabic.
W06-2920
We report results on the CoNLL-X shared task (Buchholz et al., 2006) data sets and present an error analysis.
W06-2920
We trained models for all 13 languages provided by the CoNLL organizers (Buchholz et al., 2006).
W06-2920
