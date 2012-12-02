For the experiments, we apply a maximumentropy based tagger which has been successfully evaluated on natural language understanding and named entity recognition (Bender et al., 2003).
E03-1055
representation, we extract n-best lists as described in (Zens and Ney, 2005).
W05-0834
A detailed definition of these additional features is given in (Zens et al., 2005).
W05-0834
(Bender et al., 2003).
E03-1055
As methodologies deriving well-formedness of a sentence we use supertagging (Bangalore and Joshi, 1999) with lightweight dependency analysis (LDA)1 (Bangalore, 2000), link grammars (Sleator and Temperley, 1993) and a maximumentropy (ME) based chunk parser (Bender et al., 2003).
E03-1055 J99-2004
Using a log-linear model (Och and Ney, 2002), we obtain Pr(eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 λmhm(e I1,fJ1 ) parenrightBig summationtext eprimeIprime1 exp parenleftBigsummationtextM m=1 λmhm(eprime Iprime1,fJ 1 ) parenrightBig, (2) where λm are the scaling factors of the models denoted by feature functions hm(·).
P02-1038
Although the improvement on the IWSLT’04 set is only moderate, the results are nevertheless comparable or better to the ones from (Och et al., 2004), where, starting from IBM model 1 baseline, an additional improvement of only 0.4% BLEU was achieved using more complex methods.
N04-1021
For the experiments, we use the translation system described in (Zens et al., 2005).
W05-0834
We employ the 11 chunk types as defined for the CoNLL-2000shared task (Tjong Kim Sang and Buchholz, 2000).
W00-0726
3.2 Supertagging/LDA Supertagging(BangaloreandJoshi, 1999)usesthe Lexicalized Tree Adjoining Grammar formalism (LTAG) (XTAG Research Group, 2001).
J99-2004
work In (Och et al., 2004), the effects of integrating syntactic structure into a state-of-the-art statistical machine translation system are investigated.
N04-1021
Alternatively, one can train them with respect to the final translation quality measured by an error criterion (Och, 2003).
P03-1021
In (Bangalore and Joshi, 1999), a trigram supertagger with smoothing and back-off is reported that achieves an accuracy of 92.2% when trained on one million running words.
J99-2004
