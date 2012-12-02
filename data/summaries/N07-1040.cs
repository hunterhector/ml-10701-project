We do not distinguish between the two types of links stated above, but only identify which citation(s) a linguistic expression is attributable 1We use a list of around 40 research methodology related nouns from Teufel and Moens (2002), such as e.g., “study, account, investigation, result” etc.
J02-4002
Our best results of Kappa=0.48 and Macro-F=0.53 are better than the best previously published results on task (Kappa=0.45 and Macro-F=0.50 in Teufel and Moens (2002)).
J02-4002
Our results improve on the results of Teufel and Moens (2002) (reproduced in Table 7) – both overall and for each individual category.
J02-4002
Another difference is that we use around 1700 additional cue phrases acquired from previous work on another discourse task4 (Teufel et al., 2006).
W06-1613
And automatic citation classification (Nanba and Okumura, 1999; Teufel et al., 2006) determines the function that a citation plays in the discourse.
W06-1613
We evaluate intrinsically by comparing to human-annotated attribution, and extrinsically by showing that automatically acquired knowledge about scientific attribution improves performance on a discourse classification task— Argumentative Zoning (Teufel and Moens, 2002), where sentences are labelled as one of fOwn, Other, Background, Textual, Aim, Basis, Contrastg according to their role in the author’s argument.
J02-4002
The learners we used (with default Weka settings) are: NB: Naive Bayes learner HNB: Hidden Naive Bayes learner IBk: Memory based learner J48: Decision tree based learner STACKING: combining NB and J48 classifiers with the stacking method As mentioned under History feature above, we run each learner twice, the second time including the machine learning prediction for the previous sentence (as we found in Teufel and Moens (2002) for NB, we noticed a slight improvement in performance when using the history feature (between .005 and .01 on both κ and MacroF for all learners)).
J02-4002
MUC-6/MUC-7 Metric The MUC-6/MUC-7 Co-reference evaluation metric (Vilain et al., 1995) works by comparing co-reference classes across two annotated 318 files.
M95-1005
The large improvements in Aim and 322 Aim Ctr Txt Own Bkg Bas Oth P .44 .34 .57 .84 .40 .37 .52 R .65 .20 .66 .88 .50 .40 .39 F .52 .26 .61 .86 .44 .38 .44 Correctly Classified Instances 72.5% Kappa statistic 0.45 Macro-F 0.50 Table 7: Teufel and Moens (2002)’s best AZ results (Naive Bayes Classifier).
J02-4002
Following Teufel and Moens (2002), we used supervised ML using features extracted by shallow processing (POS tagging and pattern matching): Lexical (cue phrase) features consist of three features: the first models occurrence of about 1700 manually identified scientific cue phrases (such as “in this paper”).
J02-4002
Evaluation To demonstrate the use of automatic scientific attribution classification, we studied its utility for one well known discourse annotation task: Argumentative Zoning (Teufel and Moens, 2002).
J02-4002
Data The evaluation corpus used is the one from Teufel and Moens (2002).
J02-4002
