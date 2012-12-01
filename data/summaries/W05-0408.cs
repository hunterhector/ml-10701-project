Turney (2002): “Thumbs up or thumbs down?
P02-1053
Given a set of terms with unknown sentiment orientation, Turney (2002) then uses the PMI-IR algorithm (Turney 2001) to issue queries to the web and determine, for each of these terms, its pointwise mutual information (PMI) with the two seed words across a large set of documents.
P02-1053
It is worth noting, however, that even in Turney (2002) the choice of seed words is explicitly motivated by domain properties of movie reviews.
P02-1053
Turney (2002) starts from a small (2 word) set of terms with known orientation (excellent and poor).
P02-1053
We can then use this newly identified set to: (1) use Turney’s method to find the orientation for the terms and employ the terms and their scores in a classifier, and (2) use Turney’s method to find the orientation for the terms and add the new terms as additional seed terms for a second iteration As opposed to Turney (2002), we do not use the web as a resource to find associations, rather we apply the method directly to in-domain data.
P02-1053
Yu and Hatzivassiloglou (2003) extend this approach by (1) applying it at the sentence level (instead of the document-level), (2) taking into account non-adjectival parts-of-speech, and (3) 1 For domain-specificity of sentiment classification see Engström (2004) and Aue and Gamon (2005).
W03-1017
Results on the movie domain We also performed a small set of experiments on the movie domain using Pang and Lee’s 2004 data set.
P04-1035
The field of sentiment classification has received considerable attention from researchers in recent years (Pang and Lee 2002, Pang et al.2004, Turney 2002, Turney and Littman 2002, Wiebe et al.2001, Bai et al.2004, Yu and Hatzivassiloglou 2003 and many others).
P02-1053 P04-1035 W02-1011 W03-1017
Chinchor (1995): Statistical significance of MUC-6 results.
M95-1004
Pang and Lee (2004) report 87.15% accuracy using a unigram-based SVM classifier combined with subjectivity detection.
P04-1035
accuracy Training data Turney (2002) 66% unsupervised Pang & Lee (2004) 87.15% supervised Aue & Gamon (2005) 91.4% supervised SO 73.95% unsupervised SM+SO to increase seed words, then SO 74.85% weakly supervised Table 7: Classification accuracy on the movie review domain Turney (2002) achieves 66% accuracy on the movie review domain using the PMI-IR algorithm to gather association scores from the web.
P02-1053 P04-1035
Hong Yu and Vasileios Hatzivassiloglou (2003): “Towards Answering opinion Questions: Separating Facts from Opinions and Identifying the Polarity of Opinion Sentences”.
W03-1017
Chinchor 1995), but time constraints prohibited us from implementing any of those more computationally costly tests.
M95-1004
c©2005 Association for Computational Linguistics Automatic identification of sentiment vocabulary: exploiting low association with known sentiment terms Michael Gamon Anthony Aue Natural Language Processing Group Natural Language Processing Group Microsoft Research Microsoft Research mgamon@microsoft.com anthaue@microsoft.com Abstract We describe an extension to the technique for the automatic identification and labeling of sentiment terms described in Turney (2002) and Turney and Littman (2002).
P02-1053
Movie and product reviews have been the main focus of many of the recent studies in this area (Pang and Lee 2002, Pang et al.2004, Turney 2002, Turney and Littman 2002).
P02-1053 P04-1035 W02-1011
103-134. Bo Pang, Lillian Lee and Shivakumar Vaithyanathan (2002): “Thumbs up?
W02-1011
Turney (2002) and Turney and Littman (2002) exploit the first two generalizations for unsupervised sentiment classification of movie reviews.
P02-1053
