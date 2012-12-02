According to the statistical machine translation formalism (Brown et al., 1993), the translation process is to search for the best sentence bE such that bE = arg max E P(EjJ) = arg maxE P(JjE)P(E) where P(JjE) is a translation model characterizing the correspondence between E and J; P(E), the English language model probability.
J93-2003
The training of IBM model 4 was implemented by the GIZA++ package (Och and Ney, 2003).
J03-1002 P03-1021
The following four metrics were used speci cally in this study: BLEU (Papineni et al., 2002): A weighted geometric mean of the n-gram matches between test and reference sentences multiplied by a brevity penalty that penalizes short translation sentences.
P02-1040
We adopted an N-best hypothesis approach (Och, 2003) to train. For each input speech utterance, N K candidate translations were generated, where N is the number of generated recognition hypotheses and K is the number of translation hypotheses.
J03-1002 P03-1021
(Casacuberta et al., 2002) used a nite-state transducer where scores from acoustic information sources and lexicon translation models were integrated together.
W02-0706
Indeed, the proposed speech translation paradigm of log-linear models have been shown e ective in many applications (Beyerlein, 1998) (Vergyri, 2000) (Och, 2003).
J03-1002 P03-1021
Jump weight: Jump width for adjacent cepts in Model 4 (Marcu and Wong, 2002).
W02-1018
The Powell’s algorithm used in this work is similar as the one from (Press et al., 2000) but we modi ed the line optimization codes, a subroutine of Powell’s algorithm, with reference to (Och, 2003).
J03-1002 P03-1021
