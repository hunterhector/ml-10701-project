There, with a baseline of 62.40%, only 4 out of 26 systems performed above the baseline, with the two best systems (Mihalcea and Faruque, 2004; Decadt et al., 2004) achieving an F-score of 65.2% (2.8% improvement, 7.45% error reduction).
W04-0827 W04-0838
We also experimented with the Senseval-3 English all-words tasks data (Snyder and Palmer, 2004), here called “SE3”.
W04-0811
We define a tagset based on Wordnet’s lexicographers classes, or supersenses (Ciaramita and Johnson, 2003), cf.
W03-1022
1: Initialize w0 =vector0 2: for t = 1....,T do 3: Choose xi 4: Compute ˆy = argmaxy∈Y F(xi,y;w) 5: if yinegationslash= ˆy then 6: wt+1←wt + Φ(xi,yi)−Φ(xi, ˆy) 7: end if 8: w = 1T summationtexttwt 9: end for 10: return w the perceptron performance is comparable to that of Conditional Random Field models (Sha and Pereira, 2003), The tendency to overfit of the perceptron can be mitigated in a number of ways including regularization and voting.
N03-1028
Most of the work in WSD, instead, has focused on labeling each word individually, possibly revising the assignments of senses at the document level; e.g., following the “one sense per discourse” hypothesis (Gale et al., 1992).
H92-1045
(McCarthy et al., 2004)).
P04-1036
(Rosario and Hearst, 2004)).
P04-1055
e. Hidden Markov Models, have been overcome by discriminative approaches proposed in recent years (McCallum et al., 2000; Lafferty et al., 2001; Collins, 2002; Altun et al., 2003).
W02-1001
In syntactic parse re-ranking supersenses have been used to build useful latent semantic features (Koo and Collins, 2005).
H05-1064
To this extent, we cast the supersense tagging problem as a sequence labeling task and train a discriminative Hidden Markov Model (HMM), based on that of Collins (2002), on the manually annotated Semcor corpus (Miller et al., 1993).
H93-1061 W02-1001
In two experiments we evaluate the accuracy of the tagger on the Semcor corpus itself, and on the English “all words” Senseval 3 shared task data (Snyder and Palmer, 2004).
W04-0811
We use the perceptron algorithm for sequence tagging (Collins, 2002).
W02-1001
80s (Carreras et al., 2002; Florian et al., 2003), while Bio-NER accuracy ranges between the low 70s and 80s, depending on the data-set used for training/evaluation (Dingare et al., 2005).
W02-2004 W03-0425
Segond et al.(1997) are possibly the first to have applied an HMM tagger to semantic disambiguation.
W97-0811
As far as applications are concerned, it has been shown that supersense information can support supervised WSD, by providing a partial disambiguation step (Ciaramita et al., 2003).
W03-1022
The system based on the HMM tagger (Molina et al., 2004), 6Scoring was performed with a re-implementation of the “conlleval” script. achieved an F-score of 60.9%.
W04-0842
The Semcor corpus (Miller et al., 1993), a fraction of the Brown corpus (Ku˘cera and Francis, 1967) which has been manually annotated with Wordnet synset labels.
H93-1061
More recently, variants of the generative HMM have been applied to WSD (Molina et al., 2002; Molina et al., 2004) and evaluated also on Senseval data, showing performance comparable to the first sense baseline.
W04-0842
In this paper we apply perceptron trained HMMs originally proposed in (Collins, 2002).
W02-1001
Previous work on prediction at the supersense level(CiaramitaandJohnson, 2003; Curran, 2005) has focused on lexical acquisition (nouns exclusively), thus aiming at word type classification rather than tagging.
P05-1004 W03-1022
Since each lexicographer category groups together many synsets they have been also called supersenses (Ciaramita and Johnson, 2003).
W03-1022
Experiments with augmented tagsets in the biomedical domain alsoshowperformancelosswithrespecttosmaller tagsets; e.g., Kazama et al.(2002) report an Fscore of 56.2% on a tagset of 25 Genia classes, compared to the 75.9% achieved on the simplest binary case.
W02-0301
However, in (Segond et al., 1997) the tagset is used differently, by defining equivalence classes of words with the same set of senses.
W97-0811
