There have been several attempts at extracting features for polarity classification from dependency parses, but most focus on extracting specific types of information such as adjective-noun relations (e.g., Dave et al.(2003), Yi et al.(2003)) or nouns that enjoy a dependency relation with a polarity term (e.g., Popescu and Etzioni (2005)).
H05-1043
Setup Like several previous work (e.g., Mullen and Collier (2004), Pang and Lee (2004), Whitelaw et al.(2005)), we view polarity classification as a supervised learning task.
P04-1035 W04-3253
20A newly generated feature could be misleading for the learner if the contextual polarity (i.e., polarity in the presence of context) of the adjective involved differs from its prior polarity (see Wilson et al.(2005)). The motivation behind merging with the bigrams is to create a feature set that is more robust in the face of potentially misleading generalizations.
H05-1044
Classification There is a large body of work on classifying the polarity of a document (e.g., Pang et al.(2002), Turney (2002)), a sentence (e.g., Liu et al.(2003), Yu and Hatzivassiloglou (2003), Kim and Hovy (2004), Gamon et al.(2005)), a phrase (e.g., Wilson et al.(2005)), and a specific object (such as a product) mentioned in a document (e.g., Morinaga et al.(2002), Yi et al.(2003), Popescu and Etzioni (2005)).
C04-1200 H05-1043 H05-1044 P02-1053 W02-1011 W03-1017
Two notable exceptions are the work of Dave et al.(2003) and Pang et al.(2002). Interestingly, while Dave et al.report good performance on classifying reviews using bigrams or trigrams alone, Pang et al.show that bigrams are not useful features for the task, whether they are used in isolation or in conjunction with unigrams.
W02-1011
Indeed, recent work has shown that benefits can be made by first separating facts from opinions in a document (e.g, Yu and Hatzivassiloglou (2003)) and classifying the polarity based solely on the subjective portions of the document (e.g., Pang and Lee (2004)).
P04-1035 W03-1017
All learning parameters are set to their default values.6 Each document is first tokenized and downcased, and then represented as a vector of unigrams with length normalization.7 Following Pang et al.(2002), we use frequency as presence.
W02-1011
Admittedly, the high accuracy achieved using such a simple set of features is somewhat surprising, although it is consistent with previous results on document-level subjectivity classification in which accuracies of 94-97% were obtained (Yu and Hatzivassiloglou, 2003; Wiebe et al., 2004).
J04-3002 W03-1017
Similar results were also obtained by Pang et al.(2002). It is possible that the worse result is due to the presence of a large number of irrelevant bigrams.
W02-1011
The negative results that Pang et al.(2002) obtained when using bigrams as features for their polarity classifier seem to suggest that high-order n-grams are not useful for polarity classification.
W02-1011
Next, we learn our polarity classifier using positive and negative reviews taken from two movie 611 review datasets, one assembled by Pang and Lee (2004) and the other by ourselves.
P04-1035
As a sanity check, we duplicated Pang et al.’s (2002) baseline in which all unigrams that appear four or more times in the training documents are used as features.
W02-1011
However, recent research in the related (but arguably simpler) task of text classification shows that a bigrambased text classifier outperforms its unigrambased counterpart (Peng et al., 2003).
N03-1025
For instance, instead of representing the polarity of a term using a binary value, Mullen and Collier (2004) use Turney’s (2002) method to assign a real value to represent term polarity and introduce a variety of numerical features that are aggregate measures of the polarity values of terms selected from the document under consideration.
P02-1053 W04-3253
Note that our result on Dataset A is as strong as that obtained by Pang and Lee (2004) via their subjectivity summarization algorithm, which retains only the subjective portions of a document.
P04-1035
Unlike most previous work on polarity classification, which has largely focused on exploiting adjective-noun (AN) relations (e.g., Dave et al.(2003), Popescu and Etzioni (2005)), we hypothesized that subject-verb (SV) and verb-object (VO) relations would also be useful for the task.
H05-1043
Much work has been performed on learning to identify and classify polarity terms (i.e., terms expressing a positive sentiment (e.g., happy) or a negative sentiment (e.g., terrible)) and exploiting them to do polarity classification (e.g., Hatzivassiloglou and McKeown (1997), Turney (2002), Kim and Hovy (2004), Whitelaw et al.(2005), Esuli and Sebastiani (2005)).
C04-1200 P02-1053 P97-1023
There have been attempts on tackling this so-called document-level subjectivity classification task, with very encouraging results (see Yu and Hatzivassiloglou (2003) and Wiebe et al.(2004) for details).
J04-3002 W03-1017
1http://www.wjh.harvard.edu/∼inquirer/ spreadsheet guid.htm 2Wilson et al.(2005) have also manually tagged a list of terms with their polarity, but this list is not publicly available.
H05-1044
Wilson et al.(2005) extract a larger variety of features from dependency parses, but unlike us, their goal is to determine the polarity of a phrase, not a document.
H05-1044
