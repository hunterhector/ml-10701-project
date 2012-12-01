To some extent, this supports the findings of Curran and Moens (2002), who investigated a number of weight functions for distributional similarity and showed that the t-test performed better than a number of other weight functions including MI.
W02-0908
α-skew Divergence Measure The α-skew divergence measure (Lee 1999, 2001) is a popular approximation to the Kullback-Leibler divergence measure 8 (Kullback and Leibler 1951; Cover and Thomas 1991).
P99-1004
In earlier work (Weeds and Weir 2003b), we saw that using MI to weight features gave improved performance on the two evaluation tasks over typebased or token-based CRMs.
W03-1011
Weeds, Weir, and McCarthy (2004) give preliminary results on the the use of precision and recall to distinguish between hypernyms and hyponyms in sets of distributionally related words.
C04-1146 P04-1036
The data used for all our experimental work was noun-verb direct-object data extracted from the BNC by a Robust Accurate Statistical Parser (RASP) (Briscoe and Carroll 1995; Carroll and Briscoe 1996).
W96-0209
The development set is used to optimize parameters and the test set 10 Unlike Lee (1999), we do not delete instances from the test data that occur in the training data.
P99-1004
4.5 Hindle’s Measure Hindle (1990) proposed an MI-based measure, which he used to show that nouns could be reliably clustered based on their verb co-occurrences.
P90-1034
Similarity-based smoothing (Hindle 1990; Brown et al.1992; Dagan, Marcus, and Markovitch 1993; Pereira, Tishby, and Lee 1993; Dagan, Lee, and Pereira 1999) provides an intuitively appealing approach to language modeling.
J92-4003 J93-1005 P90-1034 P93-1022 P93-1024 P99-1004
One approach (Resnik 1993; Li and Abe 1998; Clark and Weir 2000) is to induce probability distributions over semantic classes rather than lexical items.
C00-1029 J98-2002
Our results in this section are comparable to those of Curran and Moens (2002), who showed that combining the t-test with Jaccard’s coefficient outperformed combining MI with Jaccard’s coefficient by approximately 10% in a comparison against a gold-standard thesaurus.
W02-0908
5.2 Pseudo-Disambiguation Task Pseudo-disambiguation tasks have become a standard evaluation technique (Gale, Church, and Yarowsky 1992; Sch ¨utze 1992; Pereira, Tishby, and Lee 1993; Sch ¨utze 1998; Lee 1999; Dagan, Lee, and Pereira 1999; Golding and Roth 1999; Rooth et al.1999; EvenZohar and Roth 2000; Lee 2001; Clark and Weir 2002) and, in the current setting, we may use a noun’s neighbors to decide which of two co-occurrences is the most likely.
J02-2003 P93-1024 P99-1004 P99-1014
also experimented with optimizing a similarity threshold t, but found that optimizing k gave better results (Weeds 2003).
W03-1011
The first of these approaches is taken by Curran and Moens (2002), who evaluate a number of different distributional similarity measures and weight functions against a gold standard thesaurus compiled from Roget’s,theMacquarie thesaurus, and the Moby thesaurus.
W02-0908
An underlying assumption of this approach is that WordNet is a gold standard for semantic similarity, which, as is discussed by Weeds (2003), is unrealistic.
W03-1011
In previous work (Weeds and Weir 2003b), we experimented with weight functions based on combinatorial, probabilistic, and mutual information (MI).
W03-1011
In previous work (Weeds and Weir 2003b), having computed the similarity between neighbor sets for each noun according to each pair of measures under consideration, we computed the mean similarity across all high-frequency nouns and all low-frequency nouns.
W03-1011
A further problem for distributional similarity methods for automatic thesaurus generation is that they do not offer any obvious way to distinguish between linguistic relations such as synonymy, antonymy, and hyponymy (see Caraballo [1999] and Lin et al.[2003] for work on this).
P99-1016
However, there is a large body of work on distributional similarity measures; for a more extensive review, see Weeds (2003).
W03-1011
Pantel and Lin (2000) report performance of 84.3% using an unsupervised approach to prepositional phrase attachment based on distributional similarity 2 The Moby Thesaurus is a product of the Moby Project, which was released into the public domain by Grady Ward in 1996.
A00-2011
This hypothesized relationship between distributional similarity and semantic similarity has given rise to a large body of work on automatic thesaurus generation (Hindle 1990; Grefenstette 1994; Lin 1998a; Curran and Moens 2002; Kilgarriff 2003).
J98-2002 P90-1034 P98-2127 W02-0908
The differenceweighted token-based CRM achieves a fairly close approximation to dist α,butthe 9 This is what Weeds (2003) refers to as dist α1 . 457 Computational Linguistics Volume 31, Number 4 Table 4 Optimized similarities between CRMs and dist α and corresponding parameter settings.
W03-1011
The α-skew divergence measure retains the asymmetry of the Kullback-Leibler divergence, and Weeds (2003) discusses the significance in the direction in which it is calculated.
W03-1011
Some previous work on distributional similarity between nouns has used only a single grammatical relation (e.g., Lee 1999), whereas other work has considered multiple grammatical relations (e.g., Lin 1998a).
J98-2002 P98-2127 P99-1004
6. Conclusions and Future Directions Our main contribution is the development of a framework, first presented in a preliminary form in Weeds and Weir (2003b), that is based on the concept of lexical substi469 Computational Linguistics Volume 31, Number 4 Table 7 Summary of results on pseudo-disambiguation task when optimizing β, γ and k.
W03-1011
McCarthy et al.(2004) investigate using distributional similarity methods to find predominant word senses within a corpus, making it possible to tailor an existing resource (WordNet) to specific domains.
P04-1036
Brown et al.(1992) report that one can expect 14.7% of the word triples in any new English text to be unseen in a training corpus of 366 million English words.
J92-4003
We use a neighbor set comparison technique adapted from Lin (1997).
P97-1009
Other arguments for using semantic classes over distributional classes can similarly be disputed (Weeds 2003).
W03-1011
As discussed in Weeds and Weir (2003b), the Dice Coefficient and Jaccard’s Coefficient are exactly simulated by γ= 1 in the additive type-based model and Lin’s Measure is almost equivalent to the harmonic mean of precision and recall in the additive MI-based model.
W03-1011
Hindle and Rooth (1993) note that the correct decision depends on all four lexical events (the verb, the object, the preposition, and the prepositional object).
J93-1005
This is discussed in detail in (Weeds 2003), but our main justification for this approach is that a single co-occurrence of (n, v 1 ) compared to zero co-occurrences of (n, v 2 ) is not necessarily sufficient evidence to conclude that the population probability of (n, v 1 ) is greater than that of (n, v 2 ).
W03-1011
First, although the set of CRMs defined here is more extensive than that defined in Weeds and Weir (2003b), it is still not exhaustive, and other models might be proposed.
W03-1011
However, high performance in one application area is not necessarily correlated with high performance in another application area (Weeds and Weir 2003a).
W03-1011
Weeds, Weir, and McCarthy (2004) report an average overlap of 0.4 between neighbor sets produced using dist α and Jaccard’s Measure and an average overlap of 0.48 between neighbor sets produced using dist α and Lin’s similarity measure.
C04-1146 P04-1036
Giving such weight to these shared non-occurrences seems unintuitive and has been shown by Lee (1999) to be undesirable in the calculation of distributional similarity.
P99-1004
We consider the variant of 458 Weeds and Weir Co-occurrence Retrieval Figure 1 Variation (with parameters β and γ) in development set mean similarity between neighbor sets of the additive t-test based CRM and of dist α . Hindle’s Measure proposed by (Lin 1998a), which overcomes the problem associated with calculating MI for word-feature combinations that do not occur: sim hind (w 1, w 2 ) = summationdisplay T(w 1 )∩T(w 2 ) min(I(c, w 1 ), I(c, w 2 )) (38) where T(w 1 ) ={c : I(c, n) > 0}.
J98-2002 P98-2127
In previous work (Weeds and Weir 2003b), we used the WordNet-based similarity measure first proposed in Lin (1997) and used in Lin (1998a): wn sim lin (w 1, w 2 ) = max c 1 ∈S(w 1 )∧c 2 ∈S(w 2 ) parenleftbigg max c∈sup(c 1 )∩sup(c 2 ) 2logP(c) log (P(c 1 )) + log (P(c 2 )) parenrightbigg (49) where S(w) is the set of senses of the word w in WordNet, sup(c) is the set of possibly indirect super-classes of concept c in WordNet, and P(c) is the probability that a randomly selected word refers to an instance of concept c (estimated over some corpus such as SemCor [Miller et al.1994]). However, in other research (Budanitsky and Hirst 2001; Patwardhan, Banerjee, and Pedersen 2003; McCarthy, Koeling, and Weeds 2004), it has been shown that the distance measure of Jiang and Conrath (1997) (referred to herein as the “JC measure”) is a superior WordNet-based semantic similarity measure: wn dist JC (w 1, w 2 ) = max c 1 ∈S(w 1 )∧c 2 ∈S(w 2 ) parenleftbigg max c∈sup(c 1 )∩sup(c 2 ) 2log(c) − log P(c 1 ) − log P(c 2 ) parenrightbigg (50) In our work, we make an empirical comparison of neighbors derived using a WordNet-based measure and each of the distributional similarity measures using the technique discussed in Section 3.
C04-1146 H94-1046 J98-2002 P04-1036 P97-1009 P98-2127 W03-1011
5. Application-Based Evaluation As discussed by Weeds (2003), evaluation is a major problem in this area of research.
W03-1011
Kullback-Leibler divergence measure is also often referred to as “relative entropy.” 456 Weeds and Weir Co-occurrence Retrieval would result in the actual Kullback-Leibler divergence measure being equal to ∞.Itis defined (Lee 1999) as: dist α (q, r) = D(r||α.q + (1 −α).r) (35) for 0 ≤ α ≤ 1, and where: D(p||q) = summationdisplay x p(x)log p(x) q(x) (36) In effect, the q distribution is smoothed with the r distribution, which results in it always being non-zero when the r distribution is non-zero.
P99-1004
In previous work (Weeds 2003), we found that considering the subject relation as well as the direct-object relation did not improve performance on a pseudo-disambiguation task.
W03-1011
There are inherent problems in evaluating automatic thesaurus extraction techniques, and much research assumes a gold standard that does not exist (see Kilgarriff [2003] and Weeds [2003] for more discussion of this).
W03-1011
4.6 Lin’s Measure Lin (1998a) proposed a measure of lexical distributional similarity based on his information-theoretic similarity theorem (Lin 1997, 1998b): The similarity between A and B is measured by the ratio between the amount of information needed to state the commonality of A and B and the information needed to fully describe what A and B are.
J98-2002 P97-1009 P98-2127
In our own experiments with grammatical relation data extracted by a Robust Accurate Statistical Parser (RASP) (Briscoe and Carroll 1995; Carroll and Briscoe 1996) from the British National Corpus (BNC), we found that 14% of noun-verb direct-object co-occurrence tokens and 49% of noun-verb direct-object co-occurrence types in one half of the data set were not seen in the other half.
W96-0209
Through our experimental work, which is more thorough than that presented in Weeds and Weir (2003b), we have shown that the kind of neighbor preferred appears to depend on the application in hand.
W03-1011
