Some researchers use similarity and association measures to build alignment links (Ahrenberg et al., 1998; Tufis and Barbu, 2002).
P98-1004
Overall Performance We use evaluation metrics similar to those in (Och and Ney, 2000).
P00-1056
In order to filter some noise caused by the error alignment links, we only retain those translation pairs whose translation probabilities are above a threshold 1 D 1 δ or co-occurring frequencies are above a threshold 2 δ . When we train the IBM statistical word alignment model with a limited bilingual corpus in the specific domain, we build another translation dictionary with the same method as for the dictionary . But we adopt a different filtering strategy for the translation dictionary . We use log-likelihood ratio to estimate the association strength of each translation pair because Dunning (1993) proved that log-likelihood ratio performed very well on small-scale data.
J93-1003
When the large-scale bilingual corpus is not available, some researchers use existing dictionaries to improve word alignment (Ker and Chang, 1997).
J97-2004
2 2.1 Word Alignment Adaptation Bi-directional Word Alignment In statistical translation models (Brown et al., 1993), only one-to-one and more-to-one word alignment links can be found.
J93-2003
In order to deal with this problem, we perform translation in two directions (English to Chinese, and Chinese to English) as described in (Och and Ney, 2000).
P00-1056
In previous alignment methods, some researchers modeled the alignments with different statistical models (Wu, 1997; Och and Ney, 2000; Cherry and Lin, 2003).
J97-3002 P00-1056 P03-1012
According to the definition of the alignment error rate (AER) in (Och and Ney, 2000), AER can be calculated with Equation (4).
P00-1056
Bilingual word alignment is first introduced as an intermediate result in statistical machine translation (SMT) (Brown et al., 1993).
J93-2003
The alignment links in this intersection set are extended by iteratively adding word alignment links into it as described in (Och and Ney, 2000).
P00-1056
