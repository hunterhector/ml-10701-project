Other related work is concerned with determining subjectivity (Hatzivassiloglou & Wiebe, 2000; Wiebe, 2000; Wiebe et al., 2001).
C00-1044 W01-1626
Hatzivassiloglou, V., & Wiebe, J.M. 2000.
C00-1044
This algorithm uses mutual information as a measure of the strength of semantic association between two words (Church & Hanks, 1989).
P89-1010
Hatzivassiloglou and McKeown (1997) have also developed an algorithm for predicting semantic orientation.
P97-1023
Hatzivassiloglou, V., & McKeown, K.R. 1997.
P97-1023
Another area for future work is to empirically compare PMI-IR and the algorithm of Hatzivassiloglou and McKeown (1997).
P97-1023
The second step is to estimate the semantic orientation of each extracted phrase (Hatzivassiloglou & McKeown, 1997).
P97-1023
Hatzivassiloglou and McKeown (1997) use a four-step supervised learning algorithm to infer the semantic orientation of adjectives from constraints on conjunctions: 1.
P97-1023
The Pointwise Mutual Information (PMI) between two words, word1 and word2, is defined as follows (Church & Hanks, 1989): p(word1 & word2) PMI(word1, word2) = log2 p(word1) p(word2) (1) Here, p(word1 & word2) is the probability that word1 and word2 co-occur.
P89-1010
Extracted Phrase Part-of-Speech Tags Semantic Orientation little difference JJ NN -1.615 clever tricks JJ NNS -0.040 programs such NNS JJ 0.117 possible moment JJ NN -0.668 unethical practices JJ NNS -8.484 low funds JJ NNS -6.843 old man JJ NN -2.566 other problems JJ NNS -2.748 probably wondering RB VBG -1.830 virtual monopoly JJ NN -2.050 other bank JJ NN -0.850 extra day JJ NN -0.286 direct deposits JJ NNS 5.771 online web JJ NN 1.936 cool thing JJ NN 0.395 very handy RB JJ 1.349 lesser evil RBR JJ -2.288 Average Semantic Orientation -1.218 3 Related Work This work is most closely related to Hatzivassiloglou and McKeown’s (1997) work on predicting the semantic orientation of adjectives.
P97-1023
On the other hand, it would be interesting to evaluate PMI-IR on the collection of 1,336 hand-labeled adjectives that were used in the experiments of Hatzivassiloglou and McKeown (1997).
P97-1023
As an example, they present the following three sentences (Hatzivassiloglou & McKeown, 1997): 1.
P97-1023
Wiebe et al.(2001) list a variety of potential applications for automated subjectivity tagging, such as recognizing “flames” (Spertus, 1997), classifying email, recognizing speaker role in radio broadcasts, and mining reviews.
W01-1626
Past work has demonstrated that adjectives are good indicators of subjective, evaluative sentences (Hatzivassiloglou 2 http://www.epinions.com & Wiebe, 2000; Wiebe, 2000; Wiebe et al., 2001).
C00-1044 W01-1626
Previous work on determining the semantic orientation of adjectives has used a complex algorithm that does not readily extend beyond isolated adjectives to adverbs or longer phrases (Hatzivassiloglou and McKeown, 1997).
P97-1023
