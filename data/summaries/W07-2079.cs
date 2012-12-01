Mann and Yarowsky (2003) have proposed a Web based clustering technique relying on a feature space combining biographic facts and associated names, whereas Bagga and Baldwin (1998) have looked for coreference chains within each document, take the context of these chains for creating summaries about each entity and convert these summaries into a bag of words.
P98-1012 W03-0405
Unlexicalized parsers, on the other hand, achieved accuracies almost equivalent to those of lexicalized parsers (Klein and Manning, 2003; Matsuzaki et al., 2005; Petrov et al., 2006).
W03-0405
Here, we adopt the policy of ?one person per document??(all mentions of the ambiguous personal name in one web page are assumed to refer to the same personal entity in reality) as in Bagga & Baldwin (1998), Mann & Yarowsky (2003) and Gooi & Allan (2004).
P98-1012 W03-0405
Similar approachwas developedby (Bagga andBaldwin, 1998), who created first order context vectors that represent the instance in which the ambiguous name occurs.
P98-1012
Manning. 2003.
W03-0405 W03-0405 W03-0405 W03-0405
This is also the objective of the Web People Search (WePS) task (Artiles et al., 2007).
W07-2012
105 2 Data sets and feature construction The data we have used for training our system were made available in the framework of the SemEval (task 13: Web People Search) competition (Artiles et al., 2007).
W07-2012
Given an English sentence, we parse it with the Stanford parser (Klein and Manning, 2003) and then generate paraphrases using the following syntactic transformations: 1.
W03-0405
First, we seek to go beyond the kind of bag-ofwords features employed in earlier systems (Bagga & Baldwin, 1998; Gooi & Allan, 2004; Pedersen et al., 2005), and attempt to exploit deep semantic features beyond the work of Mann & Yarowsky (2003).
P98-1012 W03-0405
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
Bagga A., Baldwin B.,(1998) Entity-Based cross-document-referencing using vector space model, In proceedings of 17th International Conference on Computational Linguistics Magnini B., Pianta E., Popescu O.
P98-1012
An alternative approach by Mann andYarowsky(2003)isbasedonarichfeaturespace of automatically extracted biographic information.
W03-0405
Work Early work in the field of name disambiguation is that of (Bagga and Baldwin, 1998) who proposed cross-document coreference resolution algorithm which uses vector space model to resolve the ambiguities between people sharing the same name.
P98-1012
Although the clustering results with the best settings for hierarchical and agglomerative clustering were very close with regard to F-score (combining purity and inverse purity, see (Artiles et al., 2007) for a more detailed description), manual inspection of the content of the clusters has revealed big differences between the two approaches.
W07-2012
Mann and Yarowski (2003) developed an unsu338            HTML/XML cleaning Search Web Retrieved Documents Preprocessing Title Context information Body Text Proper names Links Clusters K-means Cluster analysis WEKA LSA matrix transformation Clustering On the basis of name disambiguation Matrix from context Figure 1: Architecture of the WePS System pervised approach to name discrimination where biographical features (age, date of birth), familiar relationships (wife, son, daughter) and associations (country, company, organization) are considered.
W03-0405
extraction and similarity matrix learning Most of the previous work (Bagga & Baldwin, 1998; Gooi & Allan; 2004; Pedersen et al., 2005) uses token information in the given documents.
P98-1012
A strictly statistically, corpus-based approach that only contemplates strings of words in view to produce lexicon entries (Manning and Schtze 2003) cannot but fail to put in relation such formal variants of equivalent expressions.
W03-0405
People Search task In this section we will explain in more detail how we implemented the general schema described in the previous section to the ?Web People Search?? task (Artiles et al., 2007).
W07-2012
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
Our proposal is to rely on special N-grams for coreference and it is a variant of agglomerative clustering based on social networks(Bagga&Baldwin 1998, Malin 2005). The terms the N-grams contain are crucial.
P98-1012
This system achieved a value of 66% for F=0.2 and a value of 48% for F=0.5 in the Web People Search Task at SemEval-2007 (Artiles et al., 2007).
W07-2012
Manning, 2003), which was hand annotated with the
W03-0405
Simultaneously, multiple identical mentions refer to distinct entities (Bagga and Baldwin, 1998).
P98-1012
Regarding the information type, Malin (2006) identifies personal information like biographical facts (Bagga and Baldwin, 1998; Mann and Yarowsky, 2003) or relational information (Bekkerman and McCallum, 05), collocations with other entities.
P98-1012 W03-0405
In this paper, we described our participating system in the SemEval-2007 Web People Search Task (Artiles et al., 2007).
W07-2012
Work (Mann and Yarowsky, 2003) first extract biographical information, such as birthdates, birthplaces, occupations, and so on.
W03-0405
The resulting strings are fed to the Stanford Parser (de Marneffe et al., 2006; Klein and Manning, 2003) with its included pretrained model and options ??retainTmpSubcategories??and ??splitTMP 1??
W03-0405
There are two results in Table 1: One is gotten from the evaluation of Semeval Web People Track (SemEval), and the other is evaluated with B-cubed evaluation (Bagga and Baldwin, 1998).
P98-1012
Our system was not built specifically for the web people search task WePS (Artiles et al., 2007), but is an early version of an IE system that has the more general goal to discover relations between NEs.
W07-2012
Names are ambiguous items (Artiles, Gonzalo and Sekine 2007).
W07-2012
Sections 3 and 4 presents in more detail the implementation of the framework for the Semeval2007 WEPS task (Artiles et al., 2007) and Semeval2007 sense induction task (Agirre and Soroa, 2007), respectively.
W07-2012
Mann and David Yarowsky 2003.
W03-0405
(Wan et al., 2005) employ an approach similar to that of (Mann and Yarowsky, 2003), and have developed a system called WebHawk.
W03-0405
