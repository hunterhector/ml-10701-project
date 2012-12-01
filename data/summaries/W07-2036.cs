Joshi, Supertagging: an approach to almost parsing, Computational Linguistics, v.25 n.2, p.237-265, June 1999 19 Manfred Stede, A generative perspective on verb alternations, Computational Linguistics, v.24 n.3, September 1998
P98-2127
Kauchak and Barzilay (2006) and Owczarzak et al.(2006) use paraphrases during BLEU and NIST evaluation to increase the number of matches between the translation and the reference; the paraphrases are either taken from WordNet4 in Kauchak and Barzilay (2006) or derived from the test set itself through automatic word and phrase alignment in Owczarzak et al.(2006). Another metric making use of synonyms is the linear regression model developed by Russo-Lassner et al.(2005), which makes use of stemming, WordNet synonymy, verb class synonymy, matching noun phrase heads, and proper name matching.
N06-1058
There exists already many interesting approaches to this problem, see (Dagan et al., 2005; Bar-Haim et al., 2006) for various recent efforts and our paper wont try to fully reinvent the wheel.
P06-1057
It is our first attempt to RTE and we have taken profit of an analysis of the approaches followed in previous challenges (see (Dagan et al., 2005), and (Bar-Haim et al., 2006) for overviews of RTE-1 and RTE-2).
P06-1057
However, dependency schemes have been suggested to be preferable in IE, as they represent the semantic structure of the sentences more directly (see, e.g., de Marneffe et al.(2006)). Further, Lin (1998) argues for dependency-based evaluation of both dependency and constituency parsers since it allows evaluation metrics that are more relevant to semantic interpretation as well as intuitively more meaningful.
P98-2127
Resnik, David Yarowsky, Distinguishing systems and distinguishing senses: new evaluation methods for Word Sense Disambiguation, Natural Language Engineering, v.5 n.2, p.113-133, June 1999 11 Hinrich Schtze, Automatic word sense discrimination, Computational Linguistics, v.24 n.1, March 1998
P98-2127
Finding alternative words that can occur in given contexts would potentially be useful to many applications such as question answering, summarisation, paraphrase acquisition (Dagan et al., 2006), text simplification and lexical acquisition (McCarthy, 2002).
P06-1057
The results obtained, using the accuracy measure that is the fraction of correct responses according to (Dagan et al., 2006), are shown in table 1.
P06-1057
22 Ruslan Mitkov, Robust pronoun resolution with limited knowledge, Proceedings of the 36th annual meeting on Association for Computational Linguistics, p.869-875, August 10-14, 1998, Montreal, Quebec, Canada 23 Ruslan Mitkov, Multilingual Anaphora Resolution, Machine Translation, v.14 n.3-4, p.281-299, December 1999 24 Wee Meng Soon, Hwee Tou Ng., and Chung Yong Lim.
P98-2127
References Bar-Haim, R., Dagan, I., Dolan, B., Ferro, L., Giampiccolo, D., Magnini, B., et al.(2006). The Second PASCAL Recognising Textual Entailment Challenge.
P06-1057
Like Lin (1999), we generate lexical variants of the target automatically by replacing either the verb or the noun constituent by a semantically similar word from the automatically-built thesaurus of Lin (1998).
P98-2127
[Bar-Haim, Dagan, et al.2006] We do recognize that some of our metrics have already been employed by other teams [Jijkoun and Rijke, 2005] and that our results may be different because of the thesaurus corpus we employed and the classification strategy we used.
P06-1057
Schtze, Automatic word sense discrimination, Computational Linguistics, v.24 n.1, March 1998 14 Mark Stevenson, Yorick Wilks, The interaction of knowledge sources in word sense disambiguation, Computational Linguistics, v.27 n.3, p.321-349, September 2001 15 Michael Sussna, Word sense disambiguation for free-text indexing using a massive semantic network, Proceedings of the second international conference on Information and knowledge management, p.67-74, November 01-05, 1993, Washington, D.C., United States 16 Hans van Halteren, Jakub Zavrel, Walter Daelemans, Improving data driven wordclass tagging by system combination, Proceedings of the 36th annual meeting on Association for Computational Linguistics, August 10-14, 1998, Montreal, Quebec, Canada 17 Ellen M.
P98-2127
Initially we assume when judging the entailment relation that it holds for each T-H pair 1 We are using Minipar (Lin, 1998) and Stanford Parser (Klein and Manning, 2003) as preprocessors, see also sec.
P98-2127
The efficacy of this approach has been well-established in many areas, including automated evaluation of machine translation systems (Kauchak and Barzilay, 2006), text summarization (Kittredge, 2002), question answering (Rinaldi et al., 2003), document retrieval (Zukerman and Raskutti, 2002), and many others.
N06-1058
Building on Lin (1998), McCarthy et al.(2003) measure the semantic similarity between expressions (verb particles) as a whole and their component words (verb).
P98-2127
Dagan. 2006b.
P06-1057
(iii) Dependency parsing, using Minipar (Lin, 1998b).
P98-2127
Dependency trees are provided by the MINIPAR dependency parser (Lin, 1998).
P98-2127
In addition, to allow for the possibility of valid lexical differences between the translation and the references, we follow Kauchak and Barzilay (2006) in adding a number of synonyms in the process of evaluation to raise the number of matches between the translation and the reference, leading to a higher score.
N06-1058
Most of the reported work on paraphrase generation from arbitrary input sentences uses machine learning techniques trained on sentences that are known or can be inferred to be paraphrases of each other (Bannard and Callison-Burch, 2005; Barzilay and Lee, 2003; Barzilay and McKeown, 2001; Callison-Burch et al., 2006; Dolan et al., 2004; Ibrahim et al., 2003; Lin and Pantel, 2001; Pang et al., 2003; Quirk et al., 2004; Shinyama et al., 2002).
P01-1008
Barzilay and McKeown (2001) extracted paraphrases using multiple translations of literature works.
P01-1008
Lin?s similarity measure (Lin, 1998) was shown to be best overall measures.
P98-2127
In Proceedings of the 36th Annual Meeting of the ACL and the 17th International Conference on Computational Linguistics (COLING-ACL 1998), pages 14931495, Montreal, Canada.
P98-2127
Their method uses Lin?s (1998) automatically generated thesaurus to compute a metric of lexical fixedness.
P98-2127
The lexical substitution (Glickman et al., 2006a) can be regarded as a subtask of the lexical entailment, in which for a given word in context the system is asked to select an alternative word that can be replaced in that context preserving the meaning.
W06-2907
The available 107 resources are: WordNet-derived (Fellbaum, 1998) synonymy, meronymy, membership, and hypernymy; a filtered version of Dekang Lin?s word similarity list (Lin, 1998) (only the ten highest-scored entries for each word); and a resource based on a lexical comparison of WordNet glosses.
P98-2127
Finally, there are approaches focused on the memory demands imposed by ?distance??between dependent words (Lin, 1996; Gibson, 1998).
P98-2127
The approach we present here is inspired by (Mihalcea and Moldovan 1999;Brill 2003; Rosso et al.2005; Dagan et al.2006; McCarthy 2002).
P06-1057
This is because identical words occur more often in coordinate head words than in other lexical dependencies (there were 43 pairs with identical words in the coordination set, compared to 3 such pairs in the 150 SimTest ncoord xcoord SDcoord nnonCoord xnonCoord SDnonCoord 95% CI p-value coordDistrib 503 0.11 0.13 485 0.06 0.09 [0.04 0.07] 0.000 (Resnik, 1995) 444 3.19 2.33 396 2.43 2.10 [0.46 1.06] 0.000 (Lin, 1998) 444 0.27 0.26 396 0.19 0.22 [0.04 0.11] 0.000 (Jiang and Conrath, 1997) 444 0.13 0.65 395 0.07 0.08 [-0.01 0.11] 0.083 (Wu and Palmer, 1994) 444 0.63 0.19 396 0.55 0.19 [0.06 0.11] 0.000 (Leacock and Chodorow, 1998) 444 1.72 0.51 396 1.52 0.47 [0.13 0.27] 0.000 (Hirst and St-Onge, 1998) 459 1.599 2.03 447 1.09 1.87 [0.25 0.76] 0.000 (Banerjee and Pedersen, 2003) 451 114.12 317.18 436 82.20 168.21 [-1.08 64.92] 0.058 (Patwardhan and Pedersen, 2006) 459 0.67 0.18 447 0.66 0.2 [-0.02 0.03] 0.545 random 483 0.89 0.17 447 0.88 0.18 [-0.02 0.02] 0.859 Table 1: Summary statistics for 9 different word similarity measures (plus one random measure):ncoord and nnonCoord are the sample sizes for the coordinate and non-coordinate noun pairs samples, respectively; xcoord, SDcoord and xnonCoord, SDnonCoord are the sample means and standard deviations for the two sets.
P98-2127
Figure 1 shows how 1 http://www.pascal-network.org/Challenges/RTE3/ the pre-processing is realized with the MINIPAR (Lin, 1998) and LingPipe2 modules which provide the input for the core module.
P98-2127
As for substitute scoring, various methods have been investigated, among which the classification method is the most widely used (Dagan et al., 2006; Kauchak and Barzilay, 2006).
N06-1058 P06-1057
Otherwise, Score(l) is the maximal Lin dependency-basedsimilarityscorebetweenlandthe lemmas of p (Lin, 1998a) (synonyms and hypernyms/hyponyms are handled by the lexical rules).
P98-2127
The commitment of the first two submodules is to generate an internal representation of the syntactic dependency trees generated by MINIPAR (Lin, 1998).
P98-2127
Both Lin (1996) and Gibson (1998) showed that human performance on sentence processing tasks could be predicted with measures of this sort.
P98-2127
In Proceedings of the 17th International Conference on Computational Linguistics: COLING-98, pages 867--880, 1998.
P98-2127
In previous RTE challenges (Dagan et al., 2006; Bar-Haimetal., 2006), severalmachine-learningapproaches appeared, but their results showed that significant improvements were still necessary.
P06-1057
Wu and Zhou (2003) extracted synonyms with multiple resources, including a monolingual dictionary, a bilingual corpus, and a monolingual corpus.
W03-1610
We rely on MiniPar (Lin, 1998) to find the question?s head verb, e.g.
P98-2127
Besides, Edmonds (1997) has also demonstrated in his paper that short-distance collocations with neighboring words are more useful in lexical choice than long ones.
P97-1067
Barzilay and McKeown (2001) identify multi-word paraphrases from a sentence-aligned corpus of monolingual parallel texts.
P01-1008
1In the literature, slight variations of this problem have been also referred to as sense matching (Dagan et al., 2006).
P06-1057
To overcome this problem several approaches have been studied, being the Recognising Textual Entailment Challenge (RTE) (BarHaim et al., 2006; Dagan et al., 2006) the most referred source for determining which one is the most accurate.
P06-1057
For example, Lin (1998) clustered words with similar meanings by calculating the dependency similarity.
P98-2127
Harabagiu, Dan Moldovan, Marius Pasca, Rada Mihalcea, Mihai Surdeanu, Razvan Bunescu, Roxana Grju, Vasile Rus, Paul Morarescu, The role of lexico-semantic feedback in open-domain textual question-answering, Proceedings of the 39th Annual Meeting on Association for Computational Linguistics, p.282-289, July 06-11, 2001, Toulouse, France 4 Irene Langkilde, Kevin Knight, Generation that exploits corpus-based statistical knowledge, Proceedings of the 36th annual meeting on Association for Computational Linguistics, August 10-14, 1998, Montreal, Quebec, Canada 5 Dekang Lin, Automatic retrieval and clustering of similar words, Proceedings of the 17th international conference on Computational linguistics, p.768-774, August 10-14, 1998, Montreal, Quebec, Canada 6 Steven Lytinen, Noriko Tomuro, and Tom Repede.
P98-2127
Next, each sentence is tokenized and syntactically parsed using the Minipar parser (Lin, 1998).
P98-2127
Textual Entailment Recognition (RTE) (Dagan et al., 2006) has recently been proposed as an application independent task to capture such inferences.
P06-1057
Lexical Entailment, and in particular lexical reference (Glickman et al., 2006b)1, is in turn a subtask of textual entailment, which is formally de ned as a relationship between a coherent text T and a language expression, the hypothesis H.
W06-2907
Both Jiang and Conrath (1997) and Lin (1998) propose extentions of Resnik?s measure.
P98-2127
We also produced best and oot baselines using the distributional similarity measures l1, jaccard, cosine, lin (Lin, 1998) and SD (Lee, 1999) 4.
P98-2127
In RTE2 the most popular sentence structure was generated by Minipar (Lin, 1998), perhaps because it is also one of the fastest parsers.
P98-2127
POS and relation labels are based on Minipar (Lin, 1998b) If a complete proof is found (h was generated), the prover concludes that entailment holds.
P98-2127
Glickman et al.(2006) proposed a Bayesian model and a Neural Network model, which estimate the probability of a word may occur in a given context.
W06-2907
In order to correctly determine the scope of valence shifters in a sentence, we introduced into the system the analysis of the parse trees produced by MiniPar (Lin, 1998).
P98-2127
References 1 Petra Barg, Markus Walther, Processing unknown words in HPSG, Proceedings of the 36th annual meeting on Association for Computational Linguistics, August 10-14, 1998, Montreal, Quebec, Canada 2 Lou Burnard.
P98-2127
??Dependency analysis: a dependency tree of each text and hypothesis is obtained using Lin?s Minipar (Lin, 1998).
P98-2127
