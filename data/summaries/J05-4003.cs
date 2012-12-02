This article describes a method for identifying parallel sentences in comparable corpora and builds on our earlier work on parallel sentence extraction (Munteanu, Fraser, and Marcu 2004).
N04-1034
Fung and Cheung (2004) present an extraction method similar to ours but focus on “very-non-parallel corpora,” aggregations of Chinese and English news stories from different sources and time periods.
W04-3208
One such model is the IBM Model 1 (Brown et al.1993). According to this model, given foreign sentence (f j 1<=j<=m ), English sentence (e i1<=i<=l ), and translation probabilities t( f j |e i ), the best alignment f → e is obtained by linking each foreign word f j to its most likely English translation argmax e i t( f j |e i ).
J93-2003
In a subsequent publication, Vogel (2003) evaluates these sentences in the context of an MT system and shows that they bring improvement under special circumstances (i.e., a language model constructed from reference translations) designed to reduce the noise introduced by the automatically extracted corpus.
E03-1050
They provide indispensable training data for statistical machine translation (Brown et al.1990; Och and Ney 2002) and have been found useful in research on automatic lexical acquisition (Gale and Church 1991; Melamed 1997), crosslanguage information retrieval (Davis and Dunning 1995; Oard 1997), and annotation projection (Diab and Resnik 2002; Yarowsky and Ngai 2001; Yarowsky, Ngai, and Wicentowski 2001).
H01-1035 J90-2002 N01-1026 P02-1033 P02-1038 P91-1023 P97-1039
8. Related Work While there is a large body of work on bilingual comparable corpora, most of it is focused on learning word translations (Fung and Yee 1998; Rapp 1999; Diab and Finch 2000; Koehn and Knight 2000; Gaussier et al.2004). We are aware of only three previous efforts aimed at discovering parallel sentences.
P04-1067 P98-1069 P99-1067 W04-3208 W04-3250
Using this alignment strategy, we follow (Och and Ney 2003) and compute one alignment for each translation direction ( f → e and e → f ), and then combine them.
J03-1002 P03-1021
Bootstrapping was also successfully applied to this problem by Fung and Cheung (2004).
W04-3208
The parameter values that maximize the likelihood of a given training corpus can be computed using various optimization algorithms (see [Malouf 2002] for a comparison of such algorithms).
W02-2018
Barzilay and Elhadad (2003) present a method of aligning sentences in two comparable English corpora for the purpose of building a training set of text-totext rewriting examples.
W03-1004
Traditional sentence alignment algorithms (Gale and Church 1991; Wu 1994; Fung and Church 1994; Melamed 1999; Moore 2002) are designed to align sentences in parallel corpora and operate on the assumption that there are no reorderings and only limited insertions and deletions between the two renderings of a parallel document.
C94-2178 J99-1003 P91-1023 P94-1012
Fung and Cheung (2004) also perform a manual evaluation of the extracted sentences and estimate their precision to be 65.7% after bootstrapping.
W04-3208
Barzilay and Elhadad (2003) make use of contextual information by detecting the topical structure of the articles in the two corpora and aligning them at paragraph level based on the topic assigned to each paragraph.
W03-1004
A line of research that is both complementary and related to ours is that of Resnik and Smith (2003).
J03-3002
The 95% confidence intervals of the scores computed by bootstrap resampling (Koehn 2004) are marked on the graphs; the delta value is around 1.2 for Arabic-English and 1 for Chinese-English.
W04-3250
The approach of Fung and Cheung (2004) is a simpler version of ours.
W04-3208
Whether this is true for comparable corpora from other domains is an empirical question outside the scope of this article; however, both our results and those of Resnik and Smith (2003) strongly indicate that good data is available on the Web.
J03-3002
Due to its simplicity, this model has several shortcomings, some more structural than others (see Moore [2004] for a discussion).
P04-1066
Resnik and Smith (2003) show that their approach is able to find large numbers of similar document pairs.
J03-3002
We follow Brown et al.(1993) in defining the fertility of a word in an alignment as the number of words it is connected to.
J93-2003
Word alignments were first introduced in the context of statistical MT, where they are used to estimate the parameters of a translation model (Brown et al.1990). Since then, they were found useful in many other NLP applications (e.g., word sense tagging [Diab and Resnik 2002] and question answering [Echihabi and Marcu 2003]).
J03-3002 J90-2002 P02-1033 P03-1003
All our MT systems were trained using a variant of the alignment template model described in (Och 2003).
J03-1002 P03-1021
performance was measured using the automatic BLEU evaluation metric (Papineni et al.2002) on four reference translations.
P02-1040
