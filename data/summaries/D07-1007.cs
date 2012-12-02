On the one hand, in previous work (Carpuat and Wu, 2005b) we obtained disappointing results when using the predictions of a Senseval WSD system in conjunction with a standard word-based SMT system: we reported slightly lower BLEU scores despite trying to incorporate WSD using a number of apparently sensible methods.
I05-2021 P05-1048
Assuming a standard phrase-based SMT system (e.g., Koehn et al.(2003)), WSD senses are thus either words or phrases, as learned in the SMT phrasal translation lexicon.
N03-1017
On the contrary, it remains a real WSD task, defined just as in the Senseval Multilingual Lexical Sample tasks (e.g., Chklovski et al.(2004)). Ourmodelmakesuse of typical WSD features that are almost never used in SMT systems, and requires a dynamically created translation lexicon on a per-sentence basis.
W04-0802
The phrase bilexicon is derived from the intersection of bidirectional IBM Model 4 alignments, obtained with GIZA++ (Och and Ney, 2003), augmented to improve recall using the grow-diag-final heuristic.
J03-1002 P03-1021
While there are many evaluations of WSD quality, in particular the Senseval series of shared tasks (Kilgarriff and Rosenzweig (1999), Kilgarriff (2001), Mihalcea et al.(2004)), very little work has been done to address the actual integration of WSD in realistic SMT applications.
W04-0807
The main difference between this approach and several of our earlier approaches as described in Carpuat and Wu (2005b) and subsequently Carpuat et al.(2006) lies in the fact that we focus on repurposing the WSD system for multi-word phrase-based SMT.
I05-2021 P05-1048
Vickrey et al.(2005) train a logistic regression WSD model on data extracted from automaticallywordalignedparallelcorpora, butevaluate on a blank filling task, which is essentially an evaluation of WSD accuracy.
H05-1097
For instance, incorporating WSD predictions into an MT decoder based on inversion transduction grammars (Wu, 1997)—such as the Bracketing ITG based models of Wu (1996), Zens et al.(2004), or CherryandLin(2007)—wouldpresentanintriguing comparison with the present work.
P04-1081 W07-0403
61 and unsupervised, on a Senseval WSD task (Carpuat and Wu, 2005a), and therefore suggest that WSD should have a role to play in state-of-the-art SMT systems.
I05-2021 P05-1048
However, most of previous research has focused on using multilingual resources typically used in SMT systems to improve WSD accuracy, e.g., DaganandItai(1994), LiandLi(2002), 63 Diab (2004).
J94-4003 P02-1044 P04-1039
WSD system The word sense disambiguation subsystem is modeled after the best performing WSD system in the Chinese lexical sample task at Senseval-3 (Carpuat et al., 2004).
W04-0822
The second model is a maximum entropy model (Jaynes, 1978), since Klein and Manning (Klein and Manning, 2002) found that this model yielded higher accuracy than na¨ıve Bayes in a subsequent comparison of WSD performance.
W02-1002
We employ supervised WSD systems, since Senseval results have amply demonstrated that supervised models significantly outperform unsupervised approaches (see for instance the English lexical sample tasks results described by Mihalcea et al.(2004)). Training examples are annotated using the phrase alignments learned during SMT training.
W04-0807
The fourth model is a Kernel PCA-based model (Wu et al., 2004).
P04-1081
It would also be interesting to assess whether a more grammatically structured statistical MT model that is less reliant on an n-gram language model, such as the syntactic ITG based “grammatical channel” translation model of (Wu and Wong, 1998), could make more effective use of WSD predictions.
P98-2230
In contrast with Brown et al.(1991), our approach incorporates the predictions of state-of-theart WSD models that use rich contextual features for any phrase in the input vocabulary.
P91-1034
In Proceedings of the 40th Annual Meeting of the Association for Computational Linguistics, 2002.
P02-1044
In Proceedings of the 40th Annual Meeting of the Association for Computational Linguistics, pages 343–351, 2002.
P02-1044
In addition to the consistency requirements for integration, this requirement is also motivated by empirical studies, which show that predefined translations derived from sense distinctions defined in monolingual ontologies do not match translation distinction made by human translators (Specia et al., 2006).
P06-3010 W06-2505
Specia (2006) describes an inductive logic programming-based WSD system,whichwasspecificallydesignedforthepurpose of Portuguese to English translation, but this system was also only evaluated on WSD accuracy, and not integratedinafull-scalemachinetranslationsystem.
P06-3010 W06-2505
• Although it is embedded in a real SMT system, the WSD task is exactly the same as in recent and coming Senseval Multilingual Lexical Sample tasks (e.g., Chklovski et al.(2004)), where sense inventories represent the semantic distinctions made by another language.
W04-0802
The loglinear model weights are learned using Chiang’s implementation of the maximum BLEU training algorithm (Och, 2003), both for the baseline, and the WSD-augmented system.
J03-1002 P03-1021
For instance, Vickrey et al.(2005) and Specia (2006) proposed WSD systems designed for French to English, and Portuguese to English translation respectively, and present a more optimistic outlook for the use of WSD in MT, although these WSD systems have not yet been integrated nor evaluated in full-scale machine translation systems.
H05-1097 P06-3010 W06-2505
In addition to the widely used BLEU (Papineni et al., 2002) and NIST (Doddington, 2002) scores, we also evaluate translation quality with the recently proposed Meteor (Banerjee and Lavie, 2005) and four edit-distance style metrics, Word Error Rate (WER), Positionindependent word Error Rate (PER) (Tillmann et al., 1997), CDER, which allows block reordering (Leusch et al., 2006), and Translation Edit Rate (TER) (Snover et al., 2006).
E06-1031 P02-1040 W05-0909
Rather than using a generic Senseval WSD model as we did in Carpuat and Wu (2005b), here both the WSD training and the WSD predictions are integrated into the phrase-based SMT framework.
I05-2021 P05-1048
Ng et al.(2003) show that it is possible to use automatically word aligned parallel corpora to train accurate supervised WSD models.
P03-1058
