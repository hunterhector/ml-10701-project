We use Naive Bayes, since it was previously shown that in combination with the features we consider, can lead to a state-of-the-art disambiguation system (Lee and Ng, 2002).
W02-1006
The fact that no improvement was obtained agrees with previous observations that classifiers that are too accurate cannot be improved with bootstrapping (Pierce and Cardie, 2001).
W01-0501
A comparative analysis of words that benefit from basic/smoothed co-training with global parameter settings, versus words with little or no improvement obtained through bootstrapping reveals several observations: (1) Words with accurate basic classifiers cannot be improved through co-training, which agrees with previous observations (Pierce and Cardie, 2001).
W01-0501
(Ng and Cardie, 2003) define self-training as a “single-view weakly supervised algorithm”, build by training a committee of classifiers using bagging, combined with majority voting for final label selection.
N03-1023
(Clark et al., 2003) provide a different definition: self-training is performed using “a tagger that is retrained on its own labeled cache on each round”.
W03-0407
However, as theoretically shown in (Abney, 2002), and then empirically in (Clark et al., 2003), co-training still works under a weaker independence assumption, and the results we obtain concur with these previous observations.
P02-1046 W03-0407
In recent work, (Abney, 2002) shows that the independence assumption can be relaxed, and co-training is still effective under a weaker independence assumption.
P02-1046
This is fundamentally different from the approach proposed in (Ng and Cardie, 2003), where they also apply majority voting in a bootstrapping framework, but in a different setting.
N03-1023
Abney. 2002.
P02-1046
In natural language learning, co-training was applied to statistical parsing (Sarkar, 2001), reference resolution (Ng and Cardie, 2003), part of speech tagging (Clark et al., 2003), and others, and was generally found to bring improvement over the case when no additional unlabeled data are used.
N01-1023 N03-1023 W03-0407
As previously noticed (Ng and Cardie, 2003), there is no principled method for selecting optimal values for these parameters, which is an important disadvantage of these algorithms.
N03-1023
Table 1 lists commonly used features in word sense disambiguation (list drawn from a larger set of features compiled by (Mihalcea, 2002)).
C02-1039
Moreover, (Clark et al., 2003) show that a naive co-training process that does not explicitly seek to maximize agreement on unlabelled data can lead to similar performance, at a much lower computational cost.
W03-0407
