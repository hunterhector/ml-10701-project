Mann and Yarowsky (2003) have proposed a Web based clustering technique relying on a feature space combining biographic facts and associated names, whereas Bagga and Baldwin (1998) have looked for coreference chains within each document, take the context of these chains for creating summaries about each entity and convert these summaries into a bag of words.
P98-1012 W03-0405
Unlexicalized parsers, on the other hand, achieved accuracies almost equivalent to those of lexicalized parsers (Klein and Manning, 2003; Matsuzaki et al., 2005; Petrov et al., 2006).
W03-0405
Here, we adopt the policy of ?one person per document??(all mentions of the ambiguous personal name in one web page are assumed to refer to the same personal entity in reality) as in Bagga & Baldwin (1998), Mann & Yarowsky (2003) and Gooi & Allan (2004).
N04-1002 P98-1012 W03-0405
Similar approachwas developedby (Bagga andBaldwin, 1998), who created first order context vectors that represent the instance in which the ambiguous name occurs.
P98-1012
Manning. 2003.
W03-0405 W03-0405 W03-0405 W03-0405
105 2 Data sets and feature construction The data we have used for training our system were made available in the framework of the SemEval (task 13: Web People Search) competition (Artiles et al., 2007).
W07-2012
Given an English sentence, we parse it with the Stanford parser (Klein and Manning, 2003) and then generate paraphrases using the following syntactic transformations: 1.
W03-0405
First, we seek to go beyond the kind of bag-ofwords features employed in earlier systems (Bagga & Baldwin, 1998; Gooi & Allan, 2004; Pedersen et al., 2005), and attempt to exploit deep semantic features beyond the work of Mann & Yarowsky (2003).
N04-1002 P98-1012 W03-0405
The goal of the Web People Search task (Artiles et al.2007) is to assign Web pages to groups, where each group contains all (and only those) pages that refer to one unique entity.
W07-2012
Work Klein and Manning presented an unlexicalized PCFG parser that eliminated all the lexicalized parameters (Klein and Manning, 2003).
W03-0405
Initially we assume when judging the entailment relation that it holds for each T-H pair 1 We are using Minipar (Lin, 1998) and Stanford Parser (Klein and Manning, 2003) as preprocessors, see also sec.
W03-0405
Much of the gain in statistical parsing using lexicalized models comes from the use of a small set of function words (Klein and Manning, 2003).
W03-0405
(Klein and Manning, 2003). Lastly, for the WSJ40
W03-0405
Inthispaper, wepresentanewtextsemanticsimilarityapproachforfine-grainedpersonnamecategorization and discrimination which is similar to those of (Pedersen et al., 2005) and (Bagga and Baldwin, 1998), but instead of simple word co-occurrences, we consider the whole text segment and relate the deduced semantic information of Latent Semantic Analysis (LSA) to trace the text cohesion between thousands of sentences containing named entities which belong to different fine-grained categories or individuals.
P98-1012
Mann and David Yarowsky 2003.
W03-0405
An alternative approach by Mann andYarowsky(2003)isbasedonarichfeaturespace of automatically extracted biographic information.
W03-0405
Although the clustering results with the best settings for hierarchical and agglomerative clustering were very close with regard to F-score (combining purity and inverse purity, see (Artiles et al., 2007) for a more detailed description), manual inspection of the content of the clusters has revealed big differences between the two approaches.
W07-2012
extraction and similarity matrix learning Most of the previous work (Bagga & Baldwin, 1998; Gooi & Allan; 2004; Pedersen et al., 2005) uses token information in the given documents.
N04-1002 P98-1012
A strictly statistically, corpus-based approach that only contemplates strings of words in view to produce lexicon entries (Manning and Schtze 2003) cannot but fail to put in relation such formal variants of equivalent expressions.
W03-0405
Manning, 2003; Petrov et al., 2006).
W03-0405
Comparison with other parsers: TEST2 40 words LP(%) LR(%) F1(%) Bikel & Chiang 2000 77.2 76.2 76.7 Chiang & Bikel 2002 81.1 78.8 79.9 Levy & Manning 2003 78.4 79.2 78.8 Collins parser 86.4 85.5 85.9 4.2 Semantic parsing using Collins parses In the test set of 113 sentences, there are 3 sentences in which target verbs are given the wrong POS tags, so they can not be used for semantic parsing.
W03-0405
Dan Klein and Christopher D. Manning. 2003. Accurate unlexicalized parsing. In Proceedings of the Association of Computational Linguistics (ACL).
W03-0405
An early work in name disambiguation (Bagga and Baldwin, 1998) uses the similarity between documents in a Vector Space using a ?bag of words?? representation.
P98-1012
Collins parser for Chinese The Collins parser is a state-of-the-art statistical parser that has high performance on English (Collins, 1999) and Czech(Collins et al.1999). There have been attempts in applying other algorithms in Chinese parsing (Bikel and Chiang, 2000; Chiang and Bikel 2002; Levy and Manning 2003), but there has been no report on applying the Collins parser on Chinese.
W03-0405
Manning, 2003), which was hand annotated with the
W03-0405
Simultaneously, multiple identical mentions refer to distinct entities (Bagga and Baldwin, 1998).
P98-1012
The resulting strings are fed to the Stanford Parser (de Marneffe et al., 2006; Klein and Manning, 2003) with its included pretrained model and options ??retainTmpSubcategories??and ??splitTMP 1??
W03-0405
There are two results in Table 1: One is gotten from the evaluation of Semeval Web People Track (SemEval), and the other is evaluated with B-cubed evaluation (Bagga and Baldwin, 1998).
P98-1012
Our system was not built specifically for the web people search task WePS (Artiles et al., 2007), but is an early version of an IE system that has the more general goal to discover relations between NEs.
W07-2012
Ravin. 1999.
W99-0202