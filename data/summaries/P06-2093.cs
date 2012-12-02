The classical Bayes relation is used to introduce a target language model (Brown et al., 1993): ˆe = argmaxe Pr(e|f) = argmaxe Pr(f|e)Pr(e) where Pr(f|e) is the translation model and Pr(e) is the target language model.
J93-2003
This approach was successfully used in large vocabulary speech recognition (Schwenk and Gauvain, 2005), and we are interested here if similar ideas can be applied to statistical machine translation.
H05-1026
Promising candidates are random forest LMs (Xu and Jelinek, 2004), random cluster LMs (Emami and Jelinek, 2005) and the neural network LM (Bengio et al., 2003).
W04-3242
These n-best lists are then rescored using a log-linear combination of feature functions (Och and Ney, 2002): ˆe ≈ argmaxe Pr(e)λ1 Pr(f|e)λ2 (1) where the coefficients λi are optimized on a development set, usually maximizing the BLEU score.
P02-1038
Many different feature functions were explored in (Och et al., 2004).
N04-1021
the continuous space language model The continuous space language model was trained on exactly the same data than the back-off reference language model, using the resampling algorithm described in (Schwenk and Gauvain, 2005).
H05-1026
Several algorithms have been proposed in the literature that try to find the best splits, see for instance (Berger et al., 1996).
J96-1002
Translation Engine A word-based translation engine is used based on the so-called IBM-4 model (Brown et al., 1993).
J93-2003
Training is done using a resampling algorithm (Schwenk and Gauvain, 2005).
H05-1026
Tuning It is nowadays common practice to optimize the coefficients of the log-linear combination of feature functions by maximizing the BLEU score on the development data (Och and Ney, 2002).
P02-1038
In another study, a factored LM using POS information achieved the same results as the 4-gram LM (Kirchhoff and Yang, 2005).
W05-0821
