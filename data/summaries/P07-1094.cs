Hyperparameter Experiments 3.1 Method Our initial experiments follow in the tradition begun by Merialdo (1994), using a tag dictionary to constrain the possible parts of speech allowed for each word.
J94-2001
Where direct comparison is possible, we list the scores reported by Smith and Eisner (2005) for their conditional random field model trained using contrastive estimation (CRF/CE).2 For all experiments, we ran our Gibbs sampling algorithm for 20,000 iterations over the entire data set.
P05-1044
Smith and Eisner (2005) also present results using a diluted dictionary, where infrequent words may have any tag.
P05-1044
Non-model-based approaches have also been proposed (Brill (1995); see also discussion in Banko and Moore (2004)).
W95-0101
To determine the effects of reduced or absent dictionary information, we ran a set of experiments inspired by those of Smith and Eisner (2005).
P05-1044
Distributional clustering and dimensionality reduction techniques are typically applied when linguistically meaningful classes are desired (Sch¨utze, 1995; Clark, 2000; Finch et al., 1995); probabilistic models have been used to find classes that can improve smoothing and reduce perplexity (Brown et al., 1992; Saul and Pereira, 1997).
J92-4003 W00-0717 W97-0309
Haghighi and Klein (2006) use a small list of labeled prototypes and no dictionary.
N06-1041
Following Smith and Eisner (2005), we trained on four different corpora, consisting of the first 12k, 24k, 48k, and 96k words of the WSJ corpus.
P05-1044
Our model has the structure of a standard trigram HMM, yet its accuracy is closer to that of a state-of-the-art discriminative model (Smith and Eisner, 2005), up to 14 percentage points better than MLE.
P05-1044
Perhaps the most well-known is that of Merialdo (1994), who used MLE to train a trigram hidden Markov model (HMM).
J94-2001
Recently, several new model-based approaches have improved performance on a variety of tasks (Klein and Manning, 2002; Smith and ∗This work was supported by grants NSF 0631518 and ONR MURI N000140510388.
P02-1017
More recent work has shown that improvements can be made by modifying the basic HMM structure (Banko and Moore, 2004), using better smoothing techniques or added constraints (Wang and Schuurmans, 2005), or using a discriminative model rather than an HMM 744 (Smith and Eisner, 2005).
P05-1044
Its accuracy in some cases is close to that of Smith and Eisner’s (2005) discriminative model.
P05-1044
However, as noted by Johnson et al.(2007), this choice of β leads to difficulties with MAP estimation.
N07-1018
