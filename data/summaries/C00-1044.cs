302 (Marcus et al., 1993) was nlanually annotated with subjeciivity chlssifications.
J93-2004
299 Ct' Number of Number of Average nnmber Ratio o1' average adjectives in links in of links for Accuracy test set (IAc~l) test set (IL~I) each adjective group frequencies 730 2,568 7.04 78.08% 1.8699 516 2,159 8.37 82.56% 1.9235 369 1,742 9.44 87.26% 1.3486 236 1,238 10.49 92.37% 1.4040 Table 1: Evaluation o1' the adjective orientation classification and labeling methods (from (Hatzivassiloglou and McKeown, 1997)).
P97-1023
Specifically, each sentence was assigned a subjective or objective classitication, according to concensus lags derived by a slalistical analysis of lhe chisses assigned by three human judges (see (Wiebe et al., 1999) for further infornmtion).
P99-1032
For the present study, we use tile set of all adjectives automatically identified in tile corpt, s by Wiebc et al.(1999) (Section 4.1 ); the set of dynamic adjectives Ill,{Inually identified by Bruce and Wiebe (2000) (Section 4.1); tile set of scnmntic orientation labels assigned by Hatzivassiloglou and McKeown (1997), both manually and automatically with our extension described in Section 2; and the set of gradability labels, both manually and atttomatically assigned according to the revised log-linear model of Section 3.
P97-1023
Hatzivassiloglou and McKeown (1997) presented a method for autonmtically assigning a + or orientation label to adjectives known to have some semantic orientation.
P97-1023
The features developed in lhis paper are not only good clues of subjectivity, lhey can be Mentilied automatically from corpora (see (Hatzivassiloglou and McKeown, 1997), and Section 3 in the present paper).
P97-1023
We use a shallow parser to retrieve from a large corpus tagged for part-of-speech with Church's PARTS tagger (Church, 1988) all adjectives and their modifiers.
A88-1019
work on subjectivity recognition In work by Wiebc, Bruce, and O'Hara (Wiebe ct al., 1999; Bruce and Wicbe, 2000), a corpus of 1,001 sentences 3 of the Wall Street Journal TreeBank Corpus 3Conlpoutld sentences were manually segmented into their conjuncts, and each conjtmct treated as a scparale sentence.
P99-1032
We also pla n l7 incorporate the new features presented here in machine learning models for tile prediction of subjectivity (e.g., (Wiebe ct al., 1999)) and lest lheir interaclions wilh olhcr proposed features.
P99-1032
In this paper, we use the model labels assigned by hand by Hatzivassiloglou and McKeown, and tile labels automatically obtained by their method and reported in (Hatzivassiloglou and McKeown, 1997) with the following extension: An adjective that appears in k conjunctions will receive (possibly different) labels when analyzed together with all adjectives appearing in at least 2, 3..... k conjunctions; since performance generally increases with the number of conjunctions per adjective, we select as the orientation label the one assigned by the experi,nent t, sing the highest applicable conjunctions threshold.
P97-1023
