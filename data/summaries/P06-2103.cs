In contrast, the greedy algorithm of Lapata (2003) makes grave search errors.
P03-1069
Also, salient entities are differentiated from casually occurring entities, based on the widely used assumption that occurrence frequency correlates with discourse prominence (Morris and Hirst, 1991; Grosz et al., 1995).
J91-1002 J95-2003
Algorithms for Coherent Discourses and Utility-Based Training The algorithms we propose use as input representation the IDL-expressions formalism (Nederhof and Satta, 2004; Soricut and Marcu, 2005).
P05-1009
Various theories of discourse coherence (Mann and Thompson, 1988; Grosz et al., 1995) have been applied successfully in discourse analysis (Marcu, 2000; Forbes et al., 2001) and discourse generation (Scott and de Souza, 1990; Kibble and Power, 2004).
J04-4001 J95-2003
One of the most frequently used metrics for the automatic evaluation of document coherence is Kendall’s a0 (Lapata, 2003; Barzilay and Lee, 2004).
N04-1015 P03-1069
setting The task on which we conduct our evaluation is information ordering (Lapata, 2003; Barzilay and Lee, 2004; Barzilay and Lapata, 2005).
N04-1015 P03-1069 P05-1018
First, it needs a search algorithm that is able to produce ranked a22 -best lists of the most promising candidates in a reasonably fast manner (Huang and Chiang, 2005).
W05-1506
BLEU. One of the most successful metrics for judging machine-generated text is BLEU (Papineni et al., 2002).
P02-1040
of Search Algorithms We evaluated the performance of several search algorithms across four stochastic models of document coherence: the IBMa0 a3 and IBM a15 a3 coherence models, the content model of Barzilay and Lee (2004) (CM), and the entity-based model of Barzilay and Lapata (2005) (EB) (Section 2).
N04-1015 P05-1018
We are able to provide this comparison based on the TAU figures reported in (Barzilay and Lee, 2004).
N04-1015
Data. For training and testing, we use documents from two different genres: newspaper articles and accident reports written by government officials (Barzilay and Lapata, 2005).
P05-1018
The large difference on the EARTHQUAKEScorpus between the performance of Barzilay and Lee (2004) and our reproduction of their model is responsible for the overall lower performance (0.47) of our log-lineara10a13a12a15a14a17a16a9a18a20a19 model and IDL-CH-HBa3 a56a72a56 search algorithm, which is nevertheless higher than that of its component model CM (0.39).
N04-1015
On the other hand, we reproduced successfully the model of Barzilay and Lapata (2005), and the average TAU figure is .19 for EARTHQUAKES, and .12 for ACCIDENTS3.
P05-1018
And the methods that utilize manually annotated corpora (Carlson et al., 2003; Karamanis et al., 2004) and supervised learning algorithms have high costs associated with the annotation procedure, and cannot be easily adapted to different domains and genres.
P04-1050
There are two necessary ingredients to implement Och’s (2003) training procedure.
P03-1021
In Figure 2, we show the IDL-graph corresponding to IDL-expression a15 . 3.2 Search Algorithms Algorithms that operate on IDL-graphs have been recently proposed by Soricut and Marcu (2005).
P05-1009
We first note that, unfortunately, we failed to accurately reproduce the model of Barzilay and Lee (2004).
N04-1015
The solution we employ here is the discriminative training procedure of Och (2003).
P03-1021
Barzilay and Lapata (2005) recently proposed an entity-based coherence model that aims to learn abstract coherence properties, similar to those stipulated by Centering Theory (Grosz et al., 1995).
J95-2003 P05-1018
Lapata (2003) 0.48 0.07 Barzilay & Lee (2004) 0.81 0.44 Barzilay & Lee (reproduced) 0.39 0.36 Barzilay & Lapata (2005) 0.19 0.12 IBMa0 a3, IDL-CH-HB a23 a25a26a25 0.38 0.41 Log-lina10a13a12a15a14a22a16a9a18a20a19, IDL-CH-HB a23 a25a26a25 0.47 0.50 Table 3: Comparison of overall performance (affected by both model & search procedure) of our framework with previous results.
N04-1015 P03-1069 P05-1018
(A similar intuition holds for the Machine Translation models generically known as the IBM models (Brown et al., 1993), which assume that certain words in a source language sentence tend to trigger the usage of certain words in a target language translation of that sentence.) We train models able to recognize local recurring patterns of word usage across sentences in an unsupervised manner, by running an ExpectationMaximization (EM) procedure over pairs of consecutive sentences extracted from a large collection of training documents1.
J93-2003
At the other end of the spectrum, the exhaustive search of Barzilay and Lee (2004), while ensuring optimal solutions, is prohibitively expensive, and cannot be used to perform utility-based training.
N04-1015
We exclude the coreference information from this model, as the discourse ordering problem cannot accommodate current coreference solutions, which assume a pre-specified order (Ng, 2005).
P05-1020
Their algorithm, however, cannot handle models with hidden states, cannot compute a22 -best lists, and does not have the representation flexibility provided by 3Note that these figures cannot be compared directly with the figures reported in (Barzilay and Lapata, 2005), as they use a different type of evaluation.
P05-1018
We compare our algorithms against the greedy algorithm used by Lapata (2003).
P03-1069
In contrast, more recent research has focused on stochastic approaches that model discourse coherence at the local lexical (Lapata, 2003) and global levels (Barzilay and Lee, 2004), while preserving regularities recognized by classic discourse theories (Barzilay and Lapata, 2005).
N04-1015 P03-1069 P05-1018
Models of Discourse Coherence Barzilay and Lee (2004) propose a document content model that uses a Hidden Markov Model 804 (HMM) to capture more global aspects of coherence.
N04-1015
The second collection (henceforth called ACCIDENTS) consists of aviation accident reports from the National Transportation Safety 807 Search Algorithm IBMa0 a3 IBM a15 a3 CM EB ESE TAU BLEU ESE TAU BLEU ESE TAU BLEU ESE TAU BLEU EARTHQUAKES IDL-CH-Aa1 0% .39 .12 0% .33 .13 0% .39 .12 0% .19 .05 IDL-CH-HBa3 a56a72a56 0% .38 .12 0% .32 .13 0% .39 .12 0% .19 .06 IDL-CH-HBa3 4% .37 .13 13% .34 .14 36% .32 .11 16% .18 .05 Lapata, 2003 90% .01 .04 58% .02 .06 97% .05 .04 46% -.05 .00 ACCIDENTS IDL-CH-Aa1 a32 0% .41 .21 0% .40 .21 0% .37 .15 0% .13 .10 IDL-CH-HBa3 a56a72a56 0% .41 .20 0% .40 .21 2% .36 .15 0% .12 .10 IDL-CH-HBa3 0% .38 .19 12% .32 .20 13% .34 .13 33% -.04 .06 Lapata, 2003 86% .11 .03 67% .12 .05 85% .18 .00 24% -.05 .06 Table 1: Evaluation of search algorithms for document coherence, for both EARTHQUAKES and ACCIDENTS genres, across the IBMa0 a3, IBM a15 a3, CM, and EB models.
P03-1069
A frequently used testbed for coherence models is the discourse ordering problem, which occurs often in text generation, complex question answering, and multi-document summarization: given a0 discourse units, what is the most coherent ordering of them (Marcu, 1996; Lapata, 2003; Barzilay and Lee, 2004; Barzilay and Lapata, 2005)?
N04-1015 P03-1069 P05-1018
The genetic algorithms of Mellish et al.(1998) and Karamanis and Manarung (2002), as well as the greedy algorithm of Lapata (2003), provide no theoretical guarantees on the optimality of the solutions they propose.
P03-1069 W98-1411
On the other hand, we achieve the highest accuracy figure (0.50) on the ACCIDENTS corpus, outperforming the previous-highest figure (0.44) of Barzilay and Lee (2004).
N04-1015
In the jargon of (Barzilay and Lapata, 2005), the model we implemented is called Syntax+Salience.
P05-1018
They unfold an input IDLgraph on-the-fly, as follows: starting from the initial vertex a25 a40, the input graph is traversed in an IDL-specific manner, by creating states which 2Following Barzilay and Lee (2004), proper names, dates, and numbers are replaced with generic tokens.
N04-1015
