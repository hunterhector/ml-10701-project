In Clark and Curran (2004b) we use a cluster of 45 machines, together with a parallel implementation of BFGS, to solve this problem, but need up to 20 GB of RAM.
C04-1041 P04-1014
For the log-linear parsing model in Clark and Curran (2004b), the inside-outside algorithm is used to calculate feature expectations, which are then used by the BFGS algorithm to optimise the likelihood function.
C04-1041 P04-1014
Supertags were introduced by Bangalore (1999) as a way of increasing parsing efficiency by reducing the number of structures assigned to each word.
J99-2004
training time and accuracy of (Taskar et al., 2004).
W04-3201
Both corpora were lemmatised, tagged and parsed with RASP (Briscoe et al., 2006).
P06-4020
Taskar 2004 89.7 90.2 90.0    89.1 89.1 89.1   
W04-3201
Previous discriminative models for CCG (Clark and Curran, 2004b) required cluster computing resources to train.
C04-1041 P04-1014
Baldridge. 2004.
W04-3202
M. Collins. 2002. Discriminative Training Methods for Hidden Markov Models: Theory and Experiments with Perceptron Algorithms. In Proceedings of EMNLP, pages 18.
W02-1001
In the tagging domain, Collins (2002) compared log-linear and perceptron training for HMM-style tagging based on dynamic programming.
W02-1001
We chose the perceptron for the training algorithm because it has shown good performance on other NLP tasks; in particular, Collins (2002) reported good performance for a perceptron tagger compared to a Maximum Entropy tagger.
W02-1001
Collinsetal.(2005)suggestamethodtoreorder the German input before translating using a set of manually crafted rules.
J05-1003
tron (Freund and Schapire, 1999; Collins, 2002),
W02-1001
with Other Work Taskar et al.(2004) investigate discriminative training methods for a phrase-structure parser, and also use dynamic programming for the decoder.
W04-3201
The key idea is to exploit the properties of lexicalized grammars by using a finite-state supertagger prior to parsing (Bangalore and Joshi, 1999; Clark and Curran, 2004a).
C04-1041 J99-2004 P04-1014
The part-of-speech tagging uses the Curran and Clark POS tagger (Curran and Clark, 2003) trained on MedPost data (Smith et al., 2004), whilst the other preprocessing stages are all rule based.
C04-1041 P04-1014
Like Collins (2002), the decoder is the same for both the perceptron and the log-linear parsing models; the only change is the method for setting the weights.
W02-1001
In taskmanipulation situations where the listener manipulates objects by following the speaker?s instructions, correct task manipulation by the listener serves as more direct evidence of understanding (Brennan 2000, Clark and Krych 2004), and affects the speaker?s dialogue control strategies.
C04-1041 P04-1014
The concept of combining the distributions of a set of expert models via a weighted product has previously been used in a range of different application areas, including economics and management science (Bordley, 1982), and NLP (Osborne and Baldridge, 2004).
W04-3202
A recent development in data-driven parsing is the use of discriminative training methods (Riezler et al., 2002; Taskar et al., 2004; Collins and Roark, 2004; Turian and Melamed, 2006).
P02-1035 P04-1015 P06-1110 W04-3201
In this paper, we use reranking architecture, which was successfully applied to the task of natural language parsing (Collins, 2000; Charniak and 209 Johnson, 2005), to address the problem.
J05-1003
Clark and Curran (2004b) describe how a set of CCG derivations can be represented as a feature forest.
C04-1041 P04-1014
Corston-Oliver et al.(2006) motivate model averaging for the perceptron in terms of Bayes Point Machines.
N06-1021
One popular approach is to use a log-linear parsing model and maximise the conditional likelihood function (Johnson et al., 1999; Riezler et al., 2002; Clark and Curran, 2004b; Malouf and van Noord, 2004; Miyao and Tsujii, 2005).
C04-1041 P02-1035 P04-1014 P05-1011 P99-1069
Jason M. Eisner. 1996. Three new probabilistic models for dependency parsing: An exploration. In Proceedings of COLING, pages 340345.
C96-1058 P96-1011
The system tokenizes, tags, lemmatizes and parses input sentences using the recent (second) release of the RASP (Robust Accurate Statistical Parsing) system (Briscoe et al., 2006) which parses arbitrary English text with state-of-the-art levels of accuracy.
P06-4020
The existing work most similar to ours is Collins and Roark (2004).
P04-1015
We use the same feature representation (x,y) as in Clark and Curran (2004b), to allow comparison with the log-linear model.
C04-1041 P04-1014
We use a lexicalized phrase-structure parser, the CCG parser of Clark and Curran (2004b), together with a DP-based decoder.
C04-1041 P04-1014
The number of categories assigned to each word is determined by a parameter  in the supertagger: all categories are assigned whose forward-backward probabilities are within  of the highest probability category (Curran et al., 2006).
P06-1088
Ratnaparkhi, 1996).
W96-0213
Koo and Collins, 2005; Petrov et al., 2006; Titov
J05-1003
(Taskar et al., 2004), they saw only small gains from
W04-3201
Collins (2002) introduced the averaged perceptron, as a way of reducing overfitting, and it has been shown to perform better than the non-averaged version on a number of tasks.
W02-1001
In contrast, methods based on Maximum Entropy (Ratnaparkhi, 1996), Conditional Random Field (Shrivastav, 2006) etc.
W96-0213
Curran School of Information Technologies University of Sydney NSW 2006, Australia james@it.usyd.edu.au Abstract The limited coverage of lexical-semantic resources is a significant problem for NLP systems which can be alleviated by automatically classifying the unknown words.
P06-1088
There is work on discriminative models for dependency parsing (McDonald, 2006); since there are efficient decoding algorithms available (Eisner, 1996b), complete resources such as the Penn Treebank can used for estimation, leading to accurate parsers.
C96-1058 P96-1011
Training The parsing problem is to find a mapping from a set of sentences x ??X to a set of parses y ??Y. We assume that the mapping F is represented through a feature vector (x,y) ??Rd and a parameter vector  ??Rd in the following way (Collins, 2002): F(x) = argmax y?GEN(x) (x,y) (1) where GEN(x) denotes the set of possible parses for sentence x and (x,y)   = summationtexti ii(x,y) is the inner product.
W02-1001
A. Ratnaparkhi. 1996. A Maximum Entropy Model for Part-Of-Speech Tagging. In Proceedings of EMNLP, pages 133142.
W96-0213
These distributions are then used to assign a set of lexical categories to each word (Curran et al., 2006).
P06-1088
Its main components are the Conditional Random Fields toolkit MALLET2 (McCallum, 2002) and the RASP syntactic parsing toolkit3 (Briscoe et al., 2006), which are both publicly available.
P06-4020
Following Clark and Curran (2004b), accuracy is measured using F-score over the goldstandard predicate-argument dependencies in CCGbank.
C04-1041 P04-1014
In an experiment on 16,800 sentences of Chinese-English newswire text with segment-level human evaluation from the Linguistic Data Consortium?s (LDC) Multiple Translation project, we compare the LFG-based evaluation method with other popular metrics like BLEU, NIST, General Text Matcher (GTM) (Turian et al., 2003), Translation Error Rate (TER) (Snover et al., 2006)1, and METEOR (Banerjee and Lavie, 2005), and we show that combining dependency representations with synonyms leads to a more accurate evaluation that correlates better with human judgment.
P06-1110
A feature forest is essentially a packed chart with only the feature information retained (see Miyao and Tsujii (2002) and Clark and Curran (2004b) for the details).
C04-1041 P04-1014
We use the noun similarities produced by Gorman and Curran (2006) using the weighted Jaccard measure and the t-test weight and grammatical relations extracted from their LARGE corpus, the method found to perform best against their goldstandard evaluation.
P06-1088
And third, given the significantly shorter training time compared to other discriminative parsing models (Taskar et al., 2004), we provide a practical framework for investigating discriminative training methods more generally.
W04-3201
Unlike (Taskar et al., 2004), our algorithm has the
W04-3201
A. Ratnaparkhi, 1996.
W96-0213
work In their psychological study, Clark and Krych (2004) showed that speakers alter their utterances midcourse while monitoring not only the listener?s vocal signals, but also the listener?s gestural signals as well as through other mutually visible events.
C04-1041 P04-1014
others, Eisner (1996), McDonald et al. (2005a), and
C96-1058 P96-1011
Joseph Turian and I. Dan Melamed. 2006. Advances in discriminative parsing. In ACL 44, pages 873880. 
P06-1110
Ben Taskar, Dan Klein, Michael Collins, Daphne Koller, and Christopher D. Manning. 2004. Max-margin parsing. In Proceedings of the Conference on Empirical Methods in Natural Language Processing (EMNLP).
P04-1015 W04-3201
The evaluation in this paper was based solely on CCGbank, but we have shown in Clark and Curran (2007) that the CCG parser gives state-of-the-art performance, outperforming the RASP parser (Briscoe et al., 2006) by over 5% on DepBank.
P06-4020 P07-1032
Parsing research has also begun to adopt discriminative methods from the Machine Learning literature, such as the perceptron (Freund and Schapire, 1999; Collins and Roark, 2004) and the largemargin methods underlying Support Vector Machines (Taskar et al., 2004; McDonald, 2006).
P04-1015 W04-3201
T. Koo and M. Collins. 2005. Hidden-Variable Models for Discriminative Reranking. In Proceedings of HLTEMNLP, pages 507514.
J05-1003
Supertagging has been especially successful for CCG: Clark and Curran (2004a) demonstrates the considerable increases in speed that can be obtained through use of a supertagger.
C04-1041 P04-1014
In brief, the abstracts of 16,609 articles curated by FlyBase were retrieved and tokenized by RASP (Briscoe et al., 2006).
P06-4020
Briscoe. 2006.
P06-4020
We used Cowan and Collins (2005)?s parser for Spanish, Arun and Keller (2005)?s for French, Dubey (2005)?s for German, and Bikel (2002)?s for English.
J05-1003
Clark and Curran (2004a) also shows how the supertagger can reduce the size of the packed charts to allow discriminative log-linear training.
C04-1041 P04-1014
It uses a log-linear model to define a distribution over the lexical category set for each word and the previous two categories (Ratnaparkhi, 1996) and the forward backward algorithm efficiently sums over all histories to give a distibution for each word.
W96-0213
Though taggers based on dependency networks (Toutanova et al., 2003), SVM (Gimenez and M`arquez, 2003), MaxEnt (Ratnaparkhi, 1996), CRF (Smith et al., 2005), and other methods may reach slightly better results, their train/test cycle is orders of magnitude longer.
W96-0213
In a survey of the idiomatic phrases listed in the Collins Cobuild Dictionary of Idioms, Villavicencio and Copestake (2002) found this kind of idiom to account for more of the entries than any other.
W02-1001
Hockenmaier and Steedman (2002) describe a generative model for CCG, which only requires a non-iterative counting process for training, but it is generally acknowledged that discriminative models provide greater flexibility and typically higher performance.
P02-1043
There is also work on discriminative models for parse reranking (Collins and Koo, 2005).
J05-1003
In the algorithm, parsing states are represented by triples ?S,I,A?? where S is the stack that keeps the words being under consideration, I is the list of reDA RA CR (Yamada and Matsumoto, 2003) 90.3 91.6 38.4 (Nivre and Scholz, 2004) 87.3 84.3 30.4 (Isozaki et al., 2004) 91.2 95.7 40.7 (McDonald et al., 2005) 90.9 94.2 37.5 (McDonald and Pereira, 2006) 91.5 N/A 42.1 (Corston-Oliver et al., 2006) 90.8 93.7 37.6 Our Base Parser 90.9 92.6 39.2 Table 2: Comparison of parser performance.
N06-1021
It is interesting to note that the inclusion of prefix and suffix for all words gives better result instead of using only for rare words as is described in Ratnaparkhi (1996).
W96-0213
Curran School of Information Technologies University of Sydney NSW 2006, Australia james@it.usyd.edu.au Abstract This paper investigates perceptron training for a wide-coverage CCG parser and compares the perceptron with a log-linear model.
P06-1088
Ratnaparkhi. 1996.
W96-0213 W96-0213
The CCG supertagger (Clark, 2002; Clark and Curran, 2004) was provided with the C&C Language Processing Tools3.
C04-1041 P04-1014
T. Matsuzaki, Y. Miyao, and J. Tsujii. 2005. Probabilistic CFG with Latent Annotations. In Proceedings of ACL, pages 7582.
P05-1011
small gains over (Taskar et al., 2004).
W04-3201
Supertagging was first defined for LTAG (Bangalore and Joshi, 1999), and was designed to increase parsing speed for lexicalized grammars by allowing a finite-state tagger to do some of the parsing work.
J99-2004
In Clark and Curran (2004b) we use a cluster of 45 machines, together with a parallel implementation of the BFGS training algorithm, to solve this problem.
C04-1041 P04-1014
This report uses an iterative procedure to demonstrate that what appears to be near magical could result mostly from mechanisms that do not require the existence of innate principles of grammar, as they are based on children?s inherent capacities for perception, 7; Saffran, Johnson, Aslin, & Newport, 1999).
P99-1069
(Charniak, 2000; Briscoe et al., 2006), have wide coverage and yield grammatical representations capable of supporting various applications (e.g.
P06-4020
Hence 10 Bangalore and Joshi (1999) refer to supertagging as almost parsing.
J99-2004
cording to (Turian and Melamed, 2006)) made fea-
P06-1110
Curran School of IT University of Sydney NSW 2006, Australia james@it.usyd.edu.au Abstract At present, most biomedical Information Retrieval and Extraction tools process abstracts rather than full-text articles.
P06-1088
Curran School of Information Technologies University of Sydney NSW 2006, Australia {jgorman2,james}@it.usyd.edu.au Abstract Semantic networks have been used successfully to explain access to the mental lexicon.
P06-1088
Curran. 2006.
P06-1088
For example, ?amerika32 ??wa:Ken22?? is used as the feature of the given pair ?Ken22??and ?amerika32?? 2.5 Classification Algorithm There are several structure-based learning algorithms proposed so far (Collins and Duffy, 2001; Suzuki et al., 2003; Kudo and Matsumoto, 2004).
P04-1015
2http://www.gate.ac.uk 3http://nlp.stanford.edu/software/tagger.shtml 166 We adopted a similar strategy with the domain independent full parsing system RASP (Briscoe et al., 2006).
P06-4020
Applied both in the training and decoding step, Collins et al.(2005) describe a method for introducing syntactic information for reordering in SMT.
J05-1003
Used The experiments reported in this paper were carried out with the News Commentary (NC) corpus as made available for the SMT workshop4 of the ACL 2007 conference.5 The Czech part of the corpus was tagged and lemmatized using the tool by Haji?c and Hladka (1998), the English part was tagged MXPOST (Ratnaparkhi, 1996) and lemmatized using the Morpha tool (Minnen et al., 2001).
W96-0213
Dependency parsing has been actively studied in recent years (Yamada and Matsumoto, 2003; Nivre and Scholz, 2004; Isozaki et al., 2004; McDonald et al., 2005; McDonald and Pereira, 2006; Corston-Oliver et al., 2006).
N06-1021
We applied the same normal-form restrictions used in Clark and Curran (2004b): categories can 12 only combine if they have been seen to combine in Sections 2-21 of CCGbank, and only if they do not violate the Eisner (1996a) normal-form constraints.
C04-1041 C96-1058 P04-1014 P96-1011
In Clark and Curran (2004b) we use cluster computing resources to solve this problem.
C04-1041 P04-1014
Taskar et al. (2004) took a large margin approach
W04-3201
CCG Parser Clark and Curran (2004b) describes the CCG parser.
C04-1041 P04-1014
