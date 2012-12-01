757 hbp’s strong tendency to overestimate the probability of rare bi-phrases; it is computed as in equation (2), except that bi-phrase probabilities are computed based on individual word translation probabilities, somewhat as in IBM model 1 (Brown et al., 1993): Pr(˜t|˜s) = 1|˜s||˜t| productdisplay t∈˜t summationdisplay s∈˜s Pr(t|s) • The target language feature function htl: this is based on a N-gram language model of the target language.
J93-2003
Interestingly, in the experiments reported in (Goutte et al., 2004), alignment method B did not compare favorably to A under the widely used Alignment Error Rate (AER) metric.
P04-1064
This type of model is now quite widely used for machine translation (Tillmann and Xia, 2003; Zens and Ney, 2003)1.
N03-2036
The first is to align the words using a “standard” word alignement technique, such as the Refined Method described in (Och and Ney, 2003) (the intersection of two IBM Viterbi alignments, forward and reverse, enriched with alignments from the union) and then generate bi-phrases by combining together individual alignments that co-occur in the same pair of sentences.
J03-1002 P03-1021
Instead, and as suggested by Och (2003), we chose to maximize directly the quality of the translations produced by the system, as measured with a machine translation evaluation metric.
J03-1002 P03-1021
This is the strategy that is usually adopted in other phrase-based MT approaches (Zens and Ney, 2003; Och and Ney, 2004).
J04-4002 N04-1033
A second family of libraries was built using alignments “B” produced with the method in (Goutte et al., 2004): these are the B libraries.
P04-1064
While in traditional word-based statistical models (Brown et al., 1993) the atomic unit that translation operates on is the word, phrase-based methods acknowledge the significant role played in language by multiword expressions, thus incorporating in a statistical framework the insight behind Example-Based Machine Translation (Somers, 1999).
J93-2003
Unfortunately, this is not the case for such widely used MT evaluation metrics as BLEU (Papineni et al., 2002) and NIST (Doddington, 2002).
P02-1040
Possibly the most remarkable evolution of recent years in statistical machine translation is the step from word-based models to phrase-based models (Och et al., 1999; Marcu and Wong, 2002; Yamada and Knight, 2002; Tillmann and Xia, 2003).
J03-1002 N03-2036 P02-1039 P03-1021 W02-1018 W99-0604
• The compositional bi-phrase feature function hcomp: this is introduced to compensate for 1Recent work from Chiang (Chiang, 2005) addresses similar concerns to those motivating our work by introducing a Synchronous CFG for bi-phrases.
P05-1033
Again, this is consistent with results observed with other systems (Tillmann and Xia, 2003).
N03-2036
As a point of comparison, we also trained an IBM-4 translation model with the GIZA++ toolkit (Och and Ney, 2000), using the combined bi-phrase building and training sets, and translated the test set using the ReWrite decoder (Germann et al., 2001)5.
P00-1056 P01-1030
A first family of libraries was based on a word alignment “A”, produced using the Refined method described in (Och and Ney, 2003) (combination of two IBM-Viterbi alignments): we call these the A libraries.
J03-1002 P03-1021
The second strategy is to rely on a wordalignment method that naturally produces many-tomany alignments between non-contiguous words, such as the method described in (Goutte et al., 2004).
P04-1064
