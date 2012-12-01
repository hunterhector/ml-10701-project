al. (1997) 84.1 No WASPS 85.1 No Li & Abe (1998) 85.2 Yes Stetina & Nagao (1997) 88.1 Yes Table 3: Accuracy of various attachment models using WordNet or automatic clustering algorithms ilarity score.
P98-2124 W97-0109
Many kinds of syntactic ambiguity can be resolved using structural information alone (Briscoe and Carroll, 1995; Lin, 1998a; Klein and Manning, 2003), but in this case both candidate structures are perfectly grammatical and roughly equally likely.
P03-1054 P98-2124
We use the similarity metric described in Weeds (2003).
W03-1011
For example, Lin’s similarity metric (Lin, 1998b) used in this paper is based on an informationtheoretic comparison between a pair of co-occurrence probability distributions.
P98-2124
The Collins and Brooks (1995) model scores 84.5% accuracy on this task, and is one of the most accurate models that do not use additional supervision.
W95-0103
A benchmark dataset of 27,937 such quadruples was extracted from the Wall Street Journal corpus by Ratnaparkhi et al.(1994) and has been the basis of many subsequent studies comparing machine learning algorithms and lexical resources.
H94-1048
Lexical information has a lot of promise for parse selection in theory, but there are practical problems such as sparse data and genre effects (Gildea, 2001).
W01-0521
The first two are large-scale generic thesauruses, both constructed using the similarity metric described in (Lin, 1998b), but based on different corpora.
P98-2124
Here we use the back-off model described in (Collins and Brooks, 1995) but with maximum likelihood estimates smoothed using similar PPs discovered using a thesaurus.
W95-0103
For example the class-based language model of (Brown et al., 1992) is defined as: p(w2|w1) = p(w2|c2)p(c2|c1) (1) This helps solve the sparse data problem since the number of classes is usually much smaller than the number of words.
J92-4003
Our baseline model is Collins and Brooks (1995) model, which implements the popular and effective backingoff smoothing technique.
W95-0103
Ratnaparkhi et al.(1994) trained a maximum entropy model on (v,n1,p,n2) quadruples extracted from the Wall Street Journal corpus and achieved 81.6% accuracy.
H94-1048
The current state of the art is 88% reported by Stetina and Nagao (1997) using the WSJ text in conjunction with WordNet.
W97-0109
However, work by Whittemore et al.(1990) and Hindle and Rooth (1993) showed that simple lexical preferences alone can deliver reasonable accuracy.
J93-1005 P90-1004
Ratnaparkhi (1994) established a human upper bound of 88.2% but subsequent research has put this as low as 78.3% (Mitchell, 2003).
H94-1048
Li and Abe (1998) use both WordNet and an automatic clustering algorithm to achieve 85.2% accuracy on the WSJ dataset.
P98-2124
The memory-based learning approach of (Zavrel et al., 1997) is the closest point of contact and shares many of the same ideas, although the details are quite different.
W97-1016
Previous research has found that using more data leads to better quality thesauruses (Curran and Moens, 2002).
P02-1030
For our experiments we use the Wall Street Journal dataset created by Ratnaparkhi et al.(1994). This is divided into a training set of 20,801 words, a development set of 4,039 words and a test set of 3,097 words.
H94-1048
The maximum entropy approach of Ratnaparkhi et al.(1994) uses the mutual information clustering algorithm described in (Brown et al., 1992).
H94-1048 J92-4003
Similarity-based methods have also been successfully applied word sense disambiguation (Dagan et al., 1997) and extraction of grammatical relations (Grishman and Sterling, 1994).
C94-2119 P97-1008
Each word was reduced to its morphological root using the morphological analyser described in (Minnen et al., 2000).
W00-1427
Default: noun attachment Figure 1: Collins and Brooks (1995) backing off algorithm.
W95-0103
A wide range of different techniques have been proposed (Chen and Goodman, 1996) including the backing-off technique used by Collins’ model (see Section 3).
P96-1041
But our model does have a natural preference for the most frequent sense in the thesaurus training corpus, which is a useful heuristic for word sense disambiguation (Pedersen and Bruce, 1997).
W97-0322
