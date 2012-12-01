The first is identifying words and phrases that are associated with subjectivity, for example, that think is associated with private states and that beautiful is associated with positive sentiments (e.g., (Hatzivassiloglou and McKeown, 1997; Wiebe, 2000; Kamps and Marx, 2002; Turney, 2002; Esuli and Sebastiani, 2005)).
P02-1053 P97-1023
and question answering (e.g., (Yu and Hatzivassiloglou, 2003; Stoyanov et al., 2005)).
H05-1116 W03-1017
Note, however, that (McCarthy et al., 2004) used the information about distributionally similar words to approximate corpus frequencies for word senses, whereas we target the estimation of a property of a given word sense (the “subjectivity”).
P04-1036
The features are integrated in a Naive Bayes classifier, which was selected mainly for its performance in previous work showing that it can lead to a state-of-the-art disambiguation system given the features we consider (Lee and Ng, 2002).
W02-1006
This is in agreement with the finding of (McCarthy et al., 2004) that, in their word sense ranking method, a larger set of neighbors did not influence the algorithm accuracy.
P04-1036
Second, a number of methods for subjectivity or sentiment analysis start with a set of seed words and then search through WordNet to find other subjective words (Kamps and Marx, 2002; Yu and Hatzivassiloglou, 2003; Hu and Liu, 2004; Kim and Hovy, 2004; Esuli and Sebastiani, 2005).
C04-1200 W03-1017
This idea relates to the unsupervised word sense ranking algorithm described in (McCarthy et al., 2004).
P04-1036
The experiments are performed on the set of ambiguous nouns from the SENSEVAL-3 English lexical sample evaluation (Mihalcea et al., 2004).
W04-0807
This feature set is similar to the one used by (Ng and Lee, 1996), as well as by a number of SENSEVAL systems.
P96-1006
The second is subjectivity classification of sentences, clauses, phrases, or word instances in the context of a particular text or conversation, either subjective/objective classifications or positive/negative sentiment classifications (e.g.,(Riloff and Wiebe, 2003; Yu and Hatzivassiloglou, 2003; Dave et al., 2003; Hu and Liu, 2004)).
W03-1014 W03-1017
We use the rule-based subjective sentence classifier of (Riloff and Wiebe, 2003) to assign an S, O, or B label to all the training and test examples pertaining to these ambiguous words.
W03-1014
Starting with a given ambiguous word w, we first find the distributionally similar words using the method of (Lin, 1998) applied to the automatically parsed texts of the British National Corpus.
P98-2127
Although a large number of such word-to-word similarity measures exist, we chose to use the (Jiang and Conrath, 1997) measure, since it was found both to be efficient and to provide the best results in previous experiments involving word sense ranking (McCarthy et al., 2004)5.
P04-1036
The third exploits automatic subjectivity analysis in applications such as review classification (e.g., (Turney, 2002; Pang and Lee, 2004)), mining texts for product reviews (e.g., (Yi et al., 2003; Hu and Liu, 2004; Popescu and Etzioni, 2005)), summarization (e.g., (Kim and Hovy, 2004)), information extraction (e.g., (Riloff et al., 2005)), 1Note that sentiment, the focus of much recent work in the area, is a type of subjectivity, specifically involving positive or negative opinion, emotion, or evaluation.
C04-1200 H05-1043 P02-1053 P04-1035
