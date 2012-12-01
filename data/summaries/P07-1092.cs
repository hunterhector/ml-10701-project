The translation models and lexical scores were estimated on the training corpus whichwasautomaticallyalignedusingGiza++(Och et al., 1999) in both directions between source and target and symmetrised using the growing heuristic (Koehn et al., 2003).
N03-1017 W99-0604
As with conventional smoothing methods (Koehn et al., 2003; Foster et al., 2006), triangulation increases the robustness of phrase translation estimates.
N03-1017 W06-1607
Callison-Burch et al.(2006) propose the use of paraphrases as a means of dealing with unseen source phrases.
N06-1003
In contrast to Utiyama and Isahara (2007), we employ a large number of intermediate languages and demonstrate how triangulated phrase-tables can be combined with standard phrase-tables to improve translation output.
N07-1061
This often leads to poor choices of target phrasesandreducesthecoherenceoftheoutput.Unfortunately, parallel corpora are not readily available in large quantities, except for a small subset of the world’s languages (see Resnik and Smith (2003) for discussion), therefore limiting the potential use of current SMT systems.
J03-3002
A single translation is then selected by finding the candidate that yields the best overall score (Och and Ney, 2001; Utiyama and Isahara, 2007) or by cotraining (Callison-Burch and Osborne, 2003).
N07-1061 P03-1021 W03-0310
This ties in with recent work on ensemble combinations of SMT systems, which have used alignment techniques (Matusov et al., 2006) or simple heuristics (Eisele, 2005) to guide target sentence selection and generation.
E06-1005 W05-0828
Although related to Callison-Burch et al.(2006) our method is conceptually simpler and more general.
N06-1003
The parameters, λj, were trained using minimum error rate training (Och, 2003) to maximise the BLEU score (Papineni et al., 2002) on a 150 sentence development set.
P02-1040 P03-1021
Statistical machine translation (Brown et al., 1993) has seen many improvements in recent years, most notably the transition from wordto phrase-based models (Koehn et al., 2003).
J93-2003 N03-1017
Decoding Pharaoh (Koehn, 2003), a beamsearch decoder, was used to maximise: T∗ = argmax T productdisplay j fj(T,S)λj (4) where T and S denote a target and source sentence respectively.
N03-1017
The joint distribution is now conditionalised to yield p(s|t) and p(t|s), which are bothusedasfeaturesinthedecoder.Notethattheresulting conditional distribution will be drawn solely from one input distribution when the conditioning contextisunseenintheremainingdistributions.This may lead to an over-reliance on unreliable distributions, which can be ameliorated by smoothing (e.g., Foster et al.(2006)). As an alternative to linear interpolation, we also employ a weighted product for phrase-table combination: p(s|t) ∝ productdisplay j pj(s|t)λj (3) This has the same form used for log-linear training of SMT decoders (Och, 2003), which allows us to treateachdistributionasafeature,andlearnthemixing weights automatically.
P03-1021 W06-1607
Och. 2003.
P03-1021
This represents the translation probability of a phrase when it is decomposed into a series of independent word-for-word translation steps (Koehn et al., 2003), and has proven a very effective feature (Zens and Ney, 2004; Foster et al., 2006).
N03-1017 N04-1033 W06-1607
