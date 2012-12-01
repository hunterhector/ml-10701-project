As we noted in Section 5, we are able to significantly outperform basic structural correspondence learning (Blitzer et al., 2006).
W06-1615
Sentiment detection and classification has received considerable attention recently (Pang et al., 2002; Turney, 2002; Goldberg and Zhu, 2004).
P02-1053 W02-1011
Thomas et al.(2006) use discourse structurepresentincongressionalrecordstoperform more accurate sentiment classification.
W06-1639
While movie reviews have been the most studied domain, sentiment analysis has extended to a number of new domains, ranging from stock message boards to congressional floor debates (Das and Chen, 2001; Thomas et al., 2006).
W06-1639
440 respondence learning (SCL) domain adaptation algorithm (Blitzer et al., 2006) for use in sentiment classification.
W06-1615
In particular, Chelba and Acero (2004) showed how this technique can be effective for capitalization adaptation.
W04-3237
The work most similar in spirit to ours that of Turney (2002).
P02-1053
Finally we note that while Blitzer et al.(2006) did combine SCL with labeled target domain data, they only compared using the label of SCL or non-SCL source classifiers as features, following the work of Florian et al.(2004). By only adapting the SCLrelated part of the weight vector v, we are able to make better use of our small amount of unlabeled data than these previous techniques.
N04-1001 W06-1615
After this conversion, we had 1000 positive and 1000 negative examples for each domain, the same balanced composition as the polarity dataset (Pang et al., 2002).
W02-1011
Then, it models the correlations between the pivot features and all other features by training linear pivot predictors to predict occurrences of each pivot in the unlabeled data from both domains (Ando and Zhang, 2005; Blitzer et al., 2006).
W06-1615
Work Sentiment classification has advanced considerably since the work of Pang et al.(2002), which we use as our baseline.
W02-1011
For the part of speech tagging problem studied by Blitzer et al.(2006), frequently-occurring words in both domains were good choices, since they often correspond to function words such as prepositions and determiners, which are good indicators of parts of speech.
W06-1615
This may also be the reason that the model of Chelba and Acero (2004) did not aid in adaptation.
W04-3237
Pang and Lee (2005) treat sentiment analysis as an ordinal ranking problem.
P05-1015
While we do not have a direct comparison, we note that Turney (2002) performs worse on movie reviews than on his other datasets, the same type of data as the polarity dataset.
P02-1053
Ando and Zhang (2005) and Blitzeretal.(2006)suggestλ = 10−4,µ = 0,which we have used in our results so far.
W06-1615
We also note that while Florian et al.(2004) and Blitzer et al.(2006) observe that including the label of a source classifier asa featureon smallamounts of target data tends to improve over using either the source alone or the target alone, we did not observe that for our data.
N04-1001 W06-1615
We augment each labeled target instance xj with the label assigned by the source domain classifier (Florian et al., 2004; Blitzer et al., 2006).
N04-1001 W06-1615
First, we showed that for a given source and target domain, we can significantly improve for sentiment classification the structural correspondence learning model of Blitzer et al.(2006). We chose pivot features using not only common frequency among domains but also mutual information with the source labels.
W06-1615
2004). On the polarity dataset, this model matches the results reported by Pang et al.(2002). When we reportresultswithSCLandSCL-MI,werequirethat pivots occur in more than five documents in each domain.
W02-1011
