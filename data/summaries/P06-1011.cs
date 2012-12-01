In the work of Moore (2004a) and Melamed (2000), two words cooccur if they are present in a pair of aligned sentences in the parallel training corpus.
J00-2004 P04-1066 W04-3243
Moore. 2004a.
P04-1066 W04-3243
The first one, GIZA-Lex, is obtained by running the GIZA++2 implementation of the IBM word alignment models (Brown et al., 1993) on the initial parallel corpus.
J93-2003
Work Much of the work involving comparable corpora has focused on extracting word translations (Fung and Yee, 1998; Rapp, 1999; Diab and Finch, 2000; Koehn and Knight, 2000; Gaussier et al., 2004; Shao and Ng, 2004; Shinyama and Sekine, 2004).
C04-1089 C04-1122 C04-1151 P04-1067 P98-1069 P99-1067 W04-3208 W04-3250
Munteanu and Marcu (2005) analyze sentence pairs in isolation from their context, and classify them as parallel or non-parallel.
J05-4003
Translation performance is measured using the automatic BLEU (Papineni et al., 2002) metric, on one reference translation.
P02-1040
The research reported by Fung and Cheung (2004a; 2004b), Cheung and Fung (2004) and Wu and Fung (2005) is aimed explicitly at “very non-parallel corpora”.
C04-1151 W04-3208
Following Och and Ney (2003), we run GIZA++ in both directions, and then symmetrize the alignments using the refined heuristic.
J03-1002
The 95% confidence intervals of our scores, computed by bootstrap resampling (Koehn, 2004), indicate that a score increase of more than 1 BLEU% is statistically significant.
W04-3250
All MT systems are trained using a variant of the alignment template model of Och and Ney (2004).
J04-4002
Fung and Cheung (2004a) describe corpora ranging from noisy parallel, to comparable, and finally to very non-parallel.
C04-1151 W04-3208
For the sentence pair from Figure 5, our system will output the pair: people to focus on the past year’s achievements, which, he says sa se concentreze pe succesele anului trecut, care, printre 3 Experiments In our experiments, we compare our fragment extraction method (which we call FragmentExtract) with the sentence extraction approach of Munteanu and Marcu (2005) (SentenceExtract).
J05-4003
We compute a22a23a22a25a24a26a3a5a1a19a18 a0a9a8, the LLR score for words a1 and a0, using the formula presented by Moore (2004b), which we do not repeat here due to lack of space.
P04-1066 W04-3243
Several researchers (Zhao and Vogel, 2002; Vogel, 2003; Resnik and Smith, 2003; Fung and Cheung, 2004a; Wu and Fung, 2005; Munteanu and Marcu, 2005) have shown how fairly good-quality parallel sentence pairs can be automatically extracted from comparable corpora, and used to improve the performance of machine translation (MT) systems.
C04-1151 E03-1050 J03-3002 J05-4003 W04-3208
Moore. 2004b.
P04-1066 W04-3243
The earliest efforts in this direction are those of Zhao and Vogel (2002) and Utiyama and Isahara (2003).
E03-1050 P03-1010
Another related research effort is that of Resnik and Smith (2003), whose system is designed to discover parallel document pairs on the Web.
J03-3002
Log-Likelihood-Ratios to Estimate Word Translation Probabilities Our method for computing the probabilistic translation lexicon LLR-Lex is based on the the Log2http://www.fjoch.com/GIZA++.html Likelihood-Ratio (LLR) statistic (Dunning, 1993), which has also been used by Moore (2004a; 2004b) and Melamed (2000) as a measure of word association.
J00-2004 J93-1003 P04-1066 W04-3243
Experiments On each of our comparable corpora, and using each of our initial parallel corpora, we apply both the fragment extraction and the sentence extraction method of Munteanu and Marcu (2005).
J05-4003
