A number of other re532 searchers (Berger et al., 1996; Niessen and Ney, 2004; Xia and McCord, 2004) have described previous work on preprocessing methods.
C04-1073 J04-2003 J96-1002
(Koehn and Knight, 2003) apply a reranking approach to the sub-task of noun-phrase translation.
N03-1017 P03-1040
In practice, when training the parameters of an SMT system, for example using the discriminative methods of (Och, 2003), the cost for skips of this kind is typically set to a very high value.
P03-1021
These methods go beyond the original IBM machine translation models (Brown et al., 1993), by allowing multi-word units (“phrases”) in one language to be translated directly into phrases in another language.
J93-2003
(Niessen and Ney, 2004) describe a method that combines morphologically–split verbs in German, and also reorders questions in English and German.
J04-2003
However, correctness of the bootstrap method relies on some technical properties of the statistic (e.g., Bleu scores) being used (e.g., see (Wasserman, 2004) theorem 8.3); (Koehn, 2004; Zhang and Vogel, 2004) do not discuss whether Bleu scores meet any such criteria, which makes us uncertain of their correctness when applied to Bleu scores.
W04-3250
on Syntax-Based SMT A number of researchers (Alshawi, 1996; Wu, 1997; Yamada and Knight, 2001; Gildea, 2003; Melamed, 2004; Graehl and Knight, 2004; Galley et al., 2004) have proposed models where the translation process involves syntactic representations of the source and/or target languages.
J97-3002 N04-1014 N04-1035 P01-1067 P03-1011 P04-1083 P96-1023
For this reason there is currently a great deal of interest in methods which incorporate syntactic information within statistical machine translation systems (e.g., see (Alshawi, 1996; Wu, 1997; Yamada and Knight, 2001; Gildea, 2003; Melamed, 2004; Graehl and Knight, 2004; Och et al., 2004; Xia and McCord, 2004)).
C04-1073 J97-3002 N04-1014 N04-1021 P01-1067 P03-1011 P04-1083 P96-1023
(Berger et al., 1996) describe an approach that targets translation of French phrases of the form NOUN de NOUN (e.g., conflit d’int´erˆet).
J96-1002
Recent research on statistical machine translation (SMT) has lead to the development of phrasebased systems (Och et al., 1999; Marcu and Wong, 2002; Koehn et al., 2003).
N03-1017 P03-1021 P03-1040 W02-1018 W99-0604
Reranking methods have also been proposed as a method for using syntactic information (Koehn and Knight, 2003; Och et al., 2004; Shen et al., 2004).
N03-1017 N04-1021 N04-1023 P03-1040 W04-3250
Our method differs from that of (Xia and McCord, 2004) in a couple of important respects.
C04-1073
Results using the method show an improvement from 25.2% Bleu score to 26.8% Bleu score (a statistically significant improvement), using a phrase-based system (Koehn et al., 2003) which has been shown in the past to be a highly competitive SMT system.
N03-1017 P03-1040
2.1 Previous Work 2.1.1 Research on Phrase-Based SMT The original work on statistical machine translation was carried out by researchers at IBM (Brown et al., 1993).
J93-2003
In experiments with the system of (Koehn et al., 2003) we have found that in practice a large number of complete translations are completely monotonic (i.e., have a0 skips), suggesting that the system has difficulty learning exactly what points in the translation should allow reordering.
N03-1017 P03-1040
(Xia and McCord, 2004) describe an approach for translation from French to English, where reordering rules are acquired automatically.
C04-1073
(Koehn, 2004) gives empirical evidence that these give accurate estimates for Bleu statistics.
W04-3250
(Och et al., 2004; Shen et al., 2004) describe the use of syntactic features in reranking the output of a full translation system, but the syntactic features give very small gains: for example the majority of the gain in performance in the experiments in (Och et al., 2004) was due to the addition of IBM Model 1 translation probabilities, a non-syntactic feature.
N04-1021 N04-1023
In this paper we use the phrase-based system of (Koehn et al., 2003) as our underlying model.
N03-1017 P03-1040
More recently, phrase-based models (Och et al., 1999; Marcu and Wong, 2002; Koehn et al., 2003) have been proposed as a highly successful alternative to the IBM models.
N03-1017 P03-1021 P03-1040 W02-1018 W99-0604
As a first step in the reordering process, we parse the sentence using the parser described in (Dubey and Keller, 2003).
P03-1013
We use BLEU scores (Papineni et al., 2002) to measure translation accuracy.
P02-1040
Note that previous work (Koehn, 2004; Zhang and Vogel, 2004) has suggested the use of bootstrap tests (Efron and Tibshirani, 1993) for the calculation of confidence intervals for Bleu scores.
W04-3250
Our baseline is the phrase-based MT system of (Koehn et al., 2003).
N03-1017 P03-1040
