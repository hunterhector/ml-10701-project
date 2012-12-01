In Rada Mihalcea and Ted Pedersen, editors, HLT-NAACL 2003 Workshop: Building and Using Parallel Texts.
W03-0301
Germann (2001) describes the cost of building a Tamil-English parallel corpus from scratch, and finds that using professional translations is prohibitively high.
W01-1409
Design To perform our experiments with word-level alignements we modified GIZA++, an existing and freely available implementation of the IBM models and HMM variants (Och and Ney, 2003).
J03-1002
The phrase-based decoder extracts phrases from the word alignments produced by GIZA++, and computes translation probabilities based on the frequency of one phrase being aligned with another (Koehn et al., 2003).
N03-1017
Describe how the parameter estimation framework of Brown et al.(1993) can be adapted to incorporate word-level alignments; 2.
J93-2003
Machine translation systems based on probabilistic translation models (Brown et al., 1993) are generally trained using sentence-aligned parallel corpora.
J93-2003
Rather than choosing e∗ that directly maximizes p(e|f), Brown et al.(1993) apply Bayes’ rule and select the source sentence: e∗ = argmaxe p(e)p(f|e).
J93-2003
Approaches such as harvesting parallel corpora from the web (Resnik and Smith, 2003) address the creation of data.
J03-3002
Mihalcea and Pedersen (2003) described a shared task where the goal was to achieve the best AER.
W03-0301
For this experiment we allowed a bilingual dictionary to constrain which words can act as translations of each other during the initial estimates of translation probabilities (as described in Och and Ney (2003)).
J03-1002
In order to measure the accuracy of the predictions that the statistical translation models make under our various experimental settings, we choose the alignment error rate (AER) metric, which is defined in Och and Ney (2003).
J03-1002
Work Och and Ney (2003) is the most extensive analysis to date of how many different factors contribute towards improved alignments error rates, but the inclusion of word-alignments is not considered.
J03-1002
A series of increasingly sophisticated translation models, referred to as the IBM Models, was defined in Brown et al.(1993). The translation model, p(f|e) defined as a marginal probability obtained by summing over word-level alignments, a, between the source and target sentences: p(f|e) = summationdisplay a p(f,a|e).
J93-2003
