We compared our model with the probabilistic model for phrase structures (Miyao and Tsujii, 2005).
P05-1011
In the experiments, we compared our model with other two types of probabilistic models using a supertagger (Ninomiya et al., 2006).
W06-1619
They filter out unlikely lexical entries just to help parsing (Clark and Curran, 2004a), or the probabilistic models for phrase structures were trained independently of the supertagger’s probabilistic models (Wang and Harper, 2004; Ninomiya et al., 2006).
C04-1041 P04-1014 W04-0307 W06-1619
Wang and Harper (2004) also demonstrated the effects of supertagging with a statistical constraint dependency grammar (CDG) parser by showing accuracy as high as the state-of-the-art parsers, and Foth et al.(2006) and Foth and Menzel (2006) reported that accuracy was significantly improved by incorporating the supertagging probabilities into manually tuned Weighted CDG.
P06-1037 P06-1041 W04-0307
In the experiments, we compared our model with the probabilistic HPSG with a unigram reference distribution (Miyao and Tsujii, 2005) and the probabilistic HPSG with supertagging (Ninomiya et al., 2006).
P05-1011 W06-1619
The concept of supertagging is simple and interesting, and the effects of this were recently demonstrated in the case of a CCG parser (Clark and Curran, 2004a) with the result of a drastic improvement in the parsing speed.
C04-1041 P04-1014
When we sacrifice parsing speed, our model achieved around 2.9 points higher F-score than Miyao and Tsujii (2005)’s model and around 0.8 points higher F-score than Ninomiya et al.(2006)’s model 3.
P05-1011 W06-1619
time (%) (%) (%) (%) (%) (%) (ms) Miyao and Tsujii (2005)’s model 87.26 86.50 86.88 90.73 89.93 90.33 604 Ninomiya et al.(2006)’s model 1 87.23 86.47 86.85 90.05 89.27 89.66 129 Ninomiya et al.(2006)’s model 3 89.48 88.58 89.02 92.33 91.40 91.86 152 our model 1 89.78 89.28 89.53 92.58 92.07 92.32 234 our model 2 90.03 89.60 89.82 92.82 92.37 92.60 1379 Section 23 (POS tagger) LP LR LF UP UR UF Avg.
P05-1011 W06-1619
time (%) (%) (%) (%) (%) (%) (ms) Miyao and Tsujii (2005)’s model 84.96 84.25 84.60 89.55 88.80 89.17 674 Ninomiya et al.(2006)’s model 1 85.00 84.01 84.50 88.85 87.82 88.33 154 Ninomiya et al.(2006)’s model 3 87.35 86.29 86.82 91.24 90.13 90.68 183 Matsuzaki et al.(2007)’s model 86.93 86.47 86.70 30 our model 1 87.28 87.05 87.17 91.62 91.38 91.50 260 our model 2 87.56 87.46 87.51 91.88 91.77 91.82 1821 Table 4: Experimental results for Section 23.
P05-1011 W06-1619
Yusuke Miyao, Takashi Ninomiya, and Jun’ichi Tsu-jii, 2005.
P05-1011 W05-1511
The only difference between our model and Miyao and Tsujii (2005)’s model is that our model uses sequences of word and POS tags as n-gram features for selecting lexical entries in the same way as supertagging does.
P05-1011
An interesting approach to the problem of parsing efficiency was using supertagging (Clark and Cur60 ran, 2004b; Clark and Curran, 2004a; Wang, 2003; Wang and Harper, 2004; Nasr and Rambow, 2004; Ninomiya et al., 2006; Foth et al., 2006; Foth and Menzel, 2006), which was originally developed for lexicalized tree adjoining grammars (LTAG) (Bangalore and Joshi, 1999).
C04-1041 J99-2004 P04-1014 P06-1037 P06-1041 W04-0307 W06-1619
This means that syntactic structures are almost determined by supertags as is claimed by Bangalore and Joshi (1999).
J99-2004
‘our model 1’ was around 2.6 times faster and had around 2.65 points higher F-score than Miyao and Tsujii (2005)’s model.
P05-1011
This evaluation scheme was the same as used in previous evaluations of lexicalized grammars (Hockenmaier, 2003; Clark The HPSG treebank is used for training the probabilistic model for lexical entry selection, and hence, those lexical entries that do not appear in the treebank are rarely selected by the probabilistic model.
P03-1046
Miyao and Tsujii (2005) also introduced a preliminary probabilistic model p0(T|w) whose estimation does not require the parsing of a treebank.
P05-1011
Abney. 1997.
J97-4005
To make the model estimation tractable, Geman and Johnson (Geman and Johnson, 2002) and Miyao and Tsujii (Miyao and Tsujii, 2002) proposed a dynamic programming algorithm for estimating p(T|w).
P02-1036
On the other hand, Ninomiya et al.(2006)’s model 3 uses the supertagger as an external module.
W06-1619
We must admit that the difference between our models and Ninomiya et al.(2006)’s model 3 was not as great as the difference from Miyao and Tsujii (2005)’s model, but ‘our model 1’ achieved 0.56 points higher F-score, and ‘our model 2’ achieved 0.8 points higher F-score.
P05-1011 W05-1511 W06-1619
fsptag is a feature template set for calculating the probabilities of selecting lexical entries in Ninomiya et al.(2006)’s model 1 and 3.
W06-1619
We also compared with a probabilistic model in (Ninomiya et al., 2006).
W06-1619
Details of the parameters are written in (Ninomiya et al., 2005).
W05-1511
Ninomiya et al.(2006) showed the parsing model using only supertagging probabilities could achieve accuracy as high as the probabilistic model for phrase structures.
W06-1619
flex is a feature template set for calculating the unigram reference distribution and is used in Miyao and Tsujii (2005)’s model.
P05-1011
Miyao and Tsujii (2005)’s model also uses a reference distribution, but with word and POS unigram features, as is explained in the previous section.
P05-1011
This model is introduced as a reference distribution (Jelinek, 1998; Johnson and Riezler, 2000) of the probabilistic HPSG model; i.e., the computation of parse trees given low probabilities by the model is omitted in the estimation stage (Miyao and Tsujii, 2005), or a probabilistic model can be augmented by several distributions estimated from the larger and simpler corpus (Johnson and Riezler, 2000).
A00-2021 P00-1061 P05-1011
(Probabilistic HPSG with an n-gram reference distribution) pnref(T|w) = 1 Znref pmodel1(T|w)exp parenleftBiggsummationdisplay u λufu(T) parenrightBigg Znref = summationdisplay Tprime pmodel1(Tprime|w)exp parenleftBiggsummationdisplay u λufu(Tprime) parenrightBigg. In our model, Ninomiya et al.(2006)’s model 1 is used as a reference distribution.
W06-1619
This was overcome by a probabilistic model which provides probabilities of discriminating a correct parse tree among candidates of parse trees in a log-linear model or maximum entropy model (Berger et al., 1996) with many features for parse trees (Abney, 1997; Johnson et al., 1999; Riezler et al., 2000; Malouf and van Noord, 2004; Kaplan et al., 2004; Miyao and Tsujii, 2005).
A00-2021 J96-1002 J97-4005 N04-1013 P00-1061 P05-1011 P99-1069
‘our model 3The beam thresholding parameters for ‘our model 1’ are α0 = 10,∆α = 5,αlast = 30,β0 = 5.0,∆β = 2.5,βlast = 15.0,δ0 = 10,∆δ = 5,δlast = 30, κ0 = 5.0,∆κ = 2.5,κlast = 15.0, θ0 = 6.0,∆θ = 3.5, and θlast = 20.0. 65 83.00% 83.50% 84.00% 84.50% 85.00% 85.50% 86.00% 86.50% 87.00% 87.50% 88.00% 0 100 200 300 400 500 600 700 800 900 Parsing time (ms/sentence) F-sco re Miyao and Tsujii(2005)'s model Ninomiya et al.(2006)'s model 1 Ninomiya et al.(2006)'s model 3 our model Figure 3: F-score versus average parsing time for sentences in Section 24 of ≤ 100 words.
P05-1011 W06-1619
In Figure 3, the line of our model crosses the line of Ninomiya et al.(2006)’s model.
W06-1619
Our model had around 2.65 points higher F-score than Miyao and Tsujii (2005)’s model and around 0.56 points higher F-score than the Ninomiya et al.(2006)’s model 3.
P05-1011 W06-1619
This advantage of Ninomiya et al.(2006)’s model can apparently be implemented in our model, but this requires many parts of rewriting of the implemented parser.
W06-1619
and Curran, 2004b; Miyao and Tsujii, 2005).
P05-1011
This is an extension of Miyao and Tsujii (2005)’s model by replacing the unigram reference distribution with an n-gram reference distribution.
P05-1011
‘our model 2’ was around 2.3 times slower but had around 2.9 points higher F-score than Miyao and Tsujii (2005)’s model.
P05-1011
Though our model was not as fast as Ninomiya et al.(2006)’s models, it achieved the highest accuracy among them.
W06-1619
Their parser ran around 6 times faster than Ninomiya et al.(2006)’s model 3, 9 times faster than ‘our model 1’ and 60 times faster than ‘our model 2.’ Instead, our models achieved better accuracy.
W06-1619
The probabilistic model of lexical entry selection and its feature templates are the same as defined in Ninomiya et al.(2006)’s model 1.
W06-1619
Previous studies (Abney, 1997; Johnson et al., 1999; Riezler et al., 2000; Malouf and van Noord, 2004; Kaplan et al., 2004; Miyao and Tsujii, 2005) defined a probabilistic model of unification-based grammars including HPSG as a log-linear model or maximum entropy model (Berger et al., 1996).
A00-2021 J96-1002 J97-4005 N04-1013 P00-1061 P05-1011 P99-1069
(Ninomiya et al.(2006)’s model 1) pmodel1(T|w) = nproductdisplay i=1 p(li|w,i), where li is a lexical entry assigned to word wi in T and p(li|w,i) is the probability of selecting lexical entry li for wi.
W06-1619
The formula of our model is the same as Ninomiya et al.(2006)’s model 3.
W06-1619
The upper half of the table shows the performance using the correct POSs in the Penn Treebank, and the lower half shows the performance using the POSs given by a POS tagger (Tsuruoka and Tsujii, 2005).
H05-1059
Following this discriminative approach, techniques for efficiency were investigated for estimation (Geman and Johnson, 2002; Miyao and Tsujii, 2002; Malouf and van Noord, 2004) and parsing (Clark and Curran, 2004b; Clark and Curran, 2004a; Ninomiya et al., 2005).
C04-1041 P02-1036 P04-1014 W05-1511
The probabilities are given as the product of Ninomiya et al.(2006)’s model 1 and the probabilistic HPSG.
W06-1619
We evaluated the speed and accuracy of parsing by using Enju 2.1, the HPSG grammar for English (Miyao et al., 2005; Miyao and Tsujii, 2005).
P05-1011
We used beam thresholding, global thresholding (Goodman, 1997), preserved iterative parsing (Ninomiya et al., 2005) and quick check (Malouf et al., 2000).
W05-1511 W97-0302
In the case of supertagging of Weighted CDG (Foth et al., 2006), parameters for Weighted CDG are manually tuned, i.e., their model is not a well-defined probabilistic model.
P06-1037 P06-1041
The model parameters, λu, are estimated using numerical optimization methods (Malouf, 2002) to maximize the log-likelihood of the training data.
W02-2018
In (Miyao and Tsujii, 2005), p0(T|w) is defined as the product of probabilities of selecting lexical entries with word and POS unigram features: (Miyao and Tsujii (2005)’s model) puniref(T|w) = p0(T|w) 1Z w exp parenleftBiggsummationdisplay u λufu(T) parenrightBigg Zw = summationdisplay Tprime p0(Tprime|w)exp parenleftBiggsummationdisplay u λufu(Tprime) parenrightBigg p0(T|w) = nproductdisplay i=1 p(li|wi), where li is a lexical entry assigned to word wi in T and p(li|wi) is the probability of selecting lexical entry li for wi.
P05-1011
(Ninomiya et al.(2006)’s model 3) pmodel3(T|w) = pmodel1(T|w)phpsg(T|w) In the experiments, we compared our model with Miyao and Tsujii (2005)’s model and Ninomiya et fbinary = angbracketleftBigg r,d,c, spl,syl,hwl,hpl,hll, spr,syr,hwr,hpr,hlr angbracketrightBigg funary = 〈r,sy,hw,hp,hl〉 froot = 〈sy,hw,hp,hl〉 flex = 〈wi,pi,li〉 fsptag = angbracketleftbigg wi−1,wi,wi+1, pi−2,pi−1,pi,pi+1,pi+2 angbracketrightbigg r name of the applied schema d distance between the head words of the daughters c whether a comma exists between daughtersand/or inside daughter phrases sp number of words dominated by the phrase sy symbol of the phrasal category hw surface form of the head word hp part-of-speech of the head word hl lexical entry assigned to the head word wi i-th word pi part-of-speech for wi li lexical entry for wi Table 1: Feature templates.
P05-1011 W06-1619
The terms α and β are the thresholds of the number and the beam width of lexical entries, and θ is the beam width for global thresholding (Goodman, 1997).
W97-0302
