Bilingual word alignment is first introduced as an intermediate result in statistical machine translation (SMT) (Brown et al.1993). Besides being used in SMT, it is also used in translation lexicon building (Melamed 1996), transfer rule learning (Menezes and Richardson 2001), example-based machine translation (Somers 1999), etc.
J93-2003 W01-1406
This method calculates word similarity by using a bilingual dictionary, which is first introduced by Wu and Zhou (2003).
W03-1610
For example, the statistical word alignment in IBM translation models (Brown et al.1993) can only handle word to word and multi-word to word alignments.
J93-2003
In addition, Wu (1997) used a stochastic inversion transduction grammar to simultaneously parse the sentence pairs to get the word or phrase alignments.
J97-3002
Word Alignment Statistical translation models (Brown, et al.1993) only allow word to word and multi-word to word alignments.
J93-2003
The row “IBM Refined” shows the results by refining the results of “IBM Inter” as described in Och and Ney (2000).
P00-1056
Experimental Results There are several different evaluation methods for word alignment (Ahrenberg et al.2000). In our evaluation, we use evaluation metrics similar to those in Och and Ney (2000).
P00-1056
In previous alignment methods, some researches modeled the alignments as hidden parameters in a statistical translation model (Brown et al.1993; Och and Ney 2000) or directly modeled them given the sentence pairs (Cherry and Lin 2003).
J93-2003 P00-1056 P03-1012
Some researchers used preprocessing steps to identity multi-word units for word alignment (Ahrenberg et al.1998; Tiedemann 1999; Melamed 2000).
J00-2004 P98-1004
According to the definition of the alignment error rate (AER) in Och and Ney (2000), AER can be calculated with Equation (5).
P00-1056
Och and Ney (2000) performed translation in both directions (source to target and target to source) to extend word alignments.
P00-1056
Some researchers used similarity and association measures to build alignment links (Ahrenberg et al.1998; Tufis and Barbu 2002).
P98-1004
The similarity of two words is estimated through their feature vectors with the cosine measure as shown in (Wu and Zhou 2003).
W03-1610
In order to tackle this problem, we perform translation in two directions (English to Chinese and Chinese to English) as described in Och and Ney (2000).
P00-1056
