In contrast, in the work of Galley et al.(2004; 2006), a rule is defined to be minimal when it is necessary in order to explain a (pi,F,A) tuple.
N04-1035 P06-1121
The decoder is capable of producing nbest derivations and nbest lists (Knight and Graehl, 2005), which are used for Maximum Bleu training (Och, 2003).
P03-1021
The parameters of the SPMT models presented in this paper are easier to estimate than those of Galley et al’s (2006) and can easily exploit and expand on previous research in phrase-based machine translation.
P06-1121
To obtain the non-lexicalized xRS rules, we compute the set of all minimal rules (lexicalized and non-lexicalized) by applying the algorithm proposed by Galley et al.(2006) and then remove the lexicalized rules.
P06-1121
We concatenate the lists and we learn a new combination of weights that maximizes the Bleu score of the combined nbest list using the same development corpus we used for tuning the individual systems (Och, 2003).
P03-1021
44 language models (Och and Ney, 2004; Tillman, 2004), are too weak to help a phrase-based decoder reorder the target phrases into grammatical outputs.
J04-4002
We use the same training corpus, 138.7M words of parallel Chinese-English data released by LDC, in order to train several statistical-based MT systems: PBMT, a strong state of the art phrase-based system that implements the alignment template model (Och and Ney, 2004); this is the system ISI has used in the 2004 and 2005 NIST evaluations.
J04-4002
The decoder uses a binarized representation of the rules, which is obtained via a syncronous binarization procedure (Zhang et al., 2006).
N06-1033
The SPMT models are similar to the models proposed by Chiang (2005) and Galley et al.(2006). If we analyze these three models in terms of expressive power, the Galley et al.(2006) model is more expressive than the SPMT models, which in turn, are more expressive than Chiang’s model.
P05-1033 P06-1121
Recent models that exploit syntactic information of the source language (Quirk et al., 2005) have been shown to produce better outputs than phrase-based systems when evaluated on relatively small scale, domain specific corpora.
P05-1034
Pr(pi,F,A) = summationdisplay θi∈Θ,c(Θ)=(pi,F,A) productdisplay rj∈θi p(rj) (4) In order to acquire the rules specific to our model and to induce their probabilities, we parse the English side of our corpus with an in-house implementation (Soricut, 2005) of Collins parsing models (Collins, 2003) and we word-align the parallel corpus with the Giza++2 implementation of the IBM models (Brown et al., 1993).
J03-4003 J93-2003
The xRS formalism utilized by Galley et al.(2006) allows for the use of translation rules that have multi-level target tree annotations and discontinuous source language phrases.
P06-1121
with multiple SPMT models Combining multiple MT outputs to increase performance is, in general, a difficult task (Matusov et al., 2006) when significantly different engines compete for producing the best outputs.
E06-1005
The weights of the models are computed automatically using a variant of the Maximum Bleu training procedure proposed by Och (2003).
P03-1021
During the last four years, various implementations and extentions to phrase-based statistical models (Marcu and Wong, 2002; Koehn et al., 2003; Och and Ney, 2004) have led to significant increases in machine translation accuracy.
J04-4002 N03-1017 W02-1018
The phrase-based-like submodels have been proved useful in phrase-based approaches to SMT (Och and Ney, 2004).
J04-4002
And syntax-inspired formal models (Chiang, 2005), in spite of being trained on significantly less data, have shown promising results when compared on the same test sets with mature phrase-based systems.
P05-1033
