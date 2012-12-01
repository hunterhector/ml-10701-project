(In section 4.4, we discuss an alternative similarity measure, for which we re-tuned these parameters.) Note that we learned a single set of shared parameters for all authors, whereas (Pang and Lee, 2005) tuned k and α on a per-author basis.
P05-1015
Pang and Lee (2005) trained a Na¨ıve Bayes classifier.
P05-1015
(Pang and Lee, 2005) found that their metric labeling method, when applied to the 4-class data we are using, was not statistically better than regression, though they observed some improvement for authors (c) and (d).
P05-1015
Pang and Lee (2005) suggested that doing so should be useful.
P05-1015
In particular Pang and Lee proposed the rating-inference problem (2005).
P05-1015
We experiment with positive-sentence percentage (PSP) based similarity which is proposed in (Pang and Lee, 2005), and mutual-information modulated word-vector cosine similarity.
P05-1015
Before moving on to experiments, we note an interesting connection to the supervised learning method in (Pang and Lee, 2005), which formulates rating inference as a metric labeling problem (Kleinberg and Tardos, 2002).
P05-1015
|L| = 0.9n is included to match 10-fold cross validation used by (Pang and Lee, 2005).
P05-1015
2. Optionally, we are given numerical rating predictions ˆyl+1,..., ˆyn on the unlabeled documents from a separate learner, for instance epsilon1-insensitive support vector regression (Joachims, 1999; Smola and Sch¨olkopf, 2004) used by (Pang and Lee, 2005).
P05-1015
We identified positive sentences using SVM instead of Na¨ıve Bayes, but the trend is qualitatively the same as in (Pang and Lee, 2005).
P05-1015
We compare our graph-based semi-supervised method with two previously studied methods: regression and metric labeling as in (Pang and Lee, 2005).
P05-1015
We performed experiments using the movie review documents and accompanying 4-class (C = {0,1,2,3}) labels found in the “scale dataset v1.0” available at http://www.cs.cornell.edu/people/pabo/ movie-review-data/ and first used in (Pang and Lee, 2005).
P05-1015
For example, several positive sentences followed by a few concluding negative sentences could indicate an overall negative review, as observed in prior work (Pang and Lee, 2005).
P05-1015
This paper contains three contributions: • We present a novel adaptation of graph-based semi-supervised learning (Zhu et al., 2003) 45 to the sentiment analysis domain, extending past supervised learning work by Pang and Lee (2005); • We design a special graph which encodes our assumptions for rating-inference problems (section 2), and present the associated optimization problem in section 3; • We show the benefit of semi-supervised learning for rating inference with extensive experimental results in section 4.
P05-1015
It corresponds exactly to the supervised, non-transductive version of metric labeling, except we use squared difference while (Pang and Lee, 2005) used absolute difference.
P05-1015
In an attempt to reproduce the findings in (Pang and Lee, 2005), we tuned c,α with cross validation.
P05-1015
PSPi is defined in (Pang and Lee, 2005) as the percentage of positive sentences in review xi.
P05-1015
Sentiment analysis of text documents has received considerable attention recently (Shanahan et al., 2005; Turney, 2002; Dave et al., 2003; Hu and Liu, 2004; Chaovalit and Zhou, 2005).
P02-1053
For consistency with (Pang and Lee, 2005), supervised metric labeling results with this measure are reported under ‘reg+PSP.’ Note this method does not use unlabeled data for training either.
P05-1015
