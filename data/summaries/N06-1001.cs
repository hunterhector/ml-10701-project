Obviously, the NPA is a special case of the phrase extractor in (Och and Ney, 2004) in that it considers only one phrase alignment rather than all possible ones.
J04-4002
For example, Lita et al.(2003) use a trigram language model estimated from a corpus with case information; Chelba and Acero (2004) use a maximum entropy Markov model (MEMM) combining features involving words and their cases.
P03-1020 W04-3237
It is also called truecasing (Lita et al., 2003).
P03-1020
To this end, the translational correspondence is described within a translation rule, i.e., (Galley et al., 2004) (or a synchronous production), rather than a translational phrase pair; and the training data will be derivation forests, instead of the phrase-aligned bilingual corpus.
N04-1035
4In our experiment, we use an empirical value σ = 0.5 as in (Roark et al., 2004).
P04-1007
A 1-gram capitalizer is usually used as a baseline for capitalization experiments (Lita et al., 2003; Kim and Woodland, 2004; Chelba and Acero, 2004).
P03-1020 W04-3237
The trigram-based baseline is similar to the one in (Lita et al., 2003) except that we used Kneser-Ney smoothing instead of a mixture.
P03-1020
The choice of LLR as an objective function can be justified as maximum a-posteriori (MAP) training within a Bayesian approach (Roark et al., 2004).
P04-1007
An aligned phrase pair is consistent with the word alignment if neither phrase contains any word aligning to a word outside the other phrase (Och and Ney, 2004).
J04-4002
Based on this capitalization model, the decoder in the capitalizer looks for the best E∗ such that E∗ = arg maxE∈GEN(e,F) Isummationdisplay i=1 λifi(E,F,A) (4) 4.2 Parameter Estimation Following Roark et al.(2004), Lafferty et al.(2001) and Chen and Rosenfeld (1999), we are looking for the set of feature weights λ maximizing the regularized log-likelihood LLR(λ) of the training data fE(n),F (n),A(n),n = 1,...,Ng.
P04-1007
Chelba and Acero (2004) frame capitalization as a sequence labeling problem, where, for each lowMT Decoder Train Monolingual Capitalization Model Monolingual Cap Model Capitalization Lower Case Lower Case f Lower Case e Finput Eoutput Train Translation Model Train Language Model Translation Model Languagel Model {F} {E} {f} {e} Figure 1: The monolingual capitalization scheme employed by most statistical MT systems.
W04-3237
A phrase-based SMT system (Marcu and Wong, 2002) was trained on the bitext.
W02-1018
In contrast, Kim and Woodland (2004) and Roark et al.(2004) use “fine-grained” features.
P04-1007
Mikheev (1999) performs capitalization using simple positional heuristics.
P99-1021
Lita et al.(2003) view capitalization as a lexical ambiguity resolution problem, where the lexical choices for each lowercased word happen to be its different surface forms.
P03-1020
