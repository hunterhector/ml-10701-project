Then P = mt R = mg and F1 = 2PRP+R = 2mg+t In Sporleder and Lapata (2005), they were primarily interested in labeled segmentation, where the segment initial boundary was labeled with the segment type.
H05-1033
Whereas most sentences correspond to a well-formed subtree, Sporleder and Lascarides (2004) report that over 20% of the paragraph boundaries in the RST-DT do not correspond to a well-formed subtree in the human annotated discourse parse for that document.
C04-1007
For those trials, the 951 sentence subset from Soricut and Marcu (2003) is used.
N03-1030
Recent work has shown promising preliminary results for recognizing and labeling relations of GraphBank structures (Wellner et al., 2006), in the case that the algorithm is provided with 494 manually segmented sentences.
W06-1317
We also use evalb when reporting labeled and unlabeled discourse parsing results in Section 3.2. 2.3 Baseline SPADE setup The publicly available SPADE package, which encodes the approach in Soricut and Marcu (2003), is taken as the baseline for this paper.
N03-1030
See Collins (2002) for more details on this approach.
W02-1001
The syntactic parser we use for all context-free syntactic parses used in either SPADE or our classifier is the Charniak parser with reranking, as described in Charniak and Johnson (2005).
P05-1022
Thus, in section 2.3, for comparison with reported results in Sporleder and Lapata (2005), ourF1-scoreisdefinedaccordingly, i.e.,segSegmentation system F1 Sporleder and Lapata best (reported) 88.40 SPADE Sporleder and Lapata configuration (reported): 87.06 current configuration: 91.04 Table 1: Segmentation results on the Sporleder and Lapata (2005)dataset, withaccuracydefinedtoincludesentenceinitial segmentation boundaries.
H05-1033
We used a loglinear model with no Markov dependency between adjacent tags,3 and trained the parameters of the model with the perceptron algorithm, with averaging to control for over-training (Collins, 2002).
W02-1001
All statistical significance testing is done via the stratified shuffling test (Yeh, 2000).
C00-2137
Sporleder and Lapata (2005) went further and established a smaller subset of 608 sentences, which omitted sentences with only one segment, i.e., sentences which themselves are atomic edus.
H05-1033
We annotate tag sequences onto the word sequence via a competitive discriminatively trained tagger (Hollingshead et al., 2005), trained for each of two kinds of tag sequences: part-of-speech (POS) tags and shallow parse tags.
H05-1099
Soricut and Marcu (2003) 2A small number of document final parentheticals are in the RST-DT and not in the Penn WSJ Treebank, which our alignment approach takes into account.
N03-1030
In this paper we take up the question posed by the results of Sporleder and Lapata (2005): how much, if any, accuracy reduction should we expect if we choose to use only finite-state derived features, rather than those derived from full contextfree parses?
H05-1033
Segment boundary accuracy is for sentence internal boundaries only, following Soricut and Marcu (2003).
N03-1030
Human agreement for this segmentation task is quite high, with agreement between two annotators at an F-score of 98.3 for unlabeled segmentation (Soricut and Marcu, 2003).
N03-1030
While Sporleder and Lapata (2005) demonstrated thattheirfinite-statesystemcouldperformaswellas the SPADE system, which uses context-free parse trees, this does not directly answer the question of the utility of context-free derived features for this task.
H05-1033
While most work on textual discourse parsing has made use of the RST-DT corpus, the Discourse GraphBank corpus provides a competing annotation that is not constrained to tree structures (Wolf and Gibson, 2005).
J05-2005
This label set has been shown to be of particular utility for indicating which segments are more important to include in an automatically created summary or compressed sentence (Sporleder and Lapata, 2005; Marcu, 1998; Marcu, 1999; Cristea et al., 2005).
H05-1033 W98-1124
Our experiments also confirm that increased segmentation accuracy yields significantly better discourse parsing accuracy, as previously shown to be the case when providing reference segmentations to a parser (Soricut and Marcu, 2003).
N03-1030
The shallow parse tags define nonhierarchical base constituents (“chunks”), as defined for the CoNLL-2000 shared task (Tjong Kim Sang and Buchholz, 2000).
W00-0726
parsing It has been shown that accurate discourse segmentation within a sentence greatly improves the overall parsing accuracy to near human levels (Soricut and Marcu, 2003).
N03-1030
Using the RST Treebank as training and evaluation data, Soricut and Marcu (2003) demonstrated that their automatic sentence-level discourse parsing system could achieve near-human levels of accuracy, if it was provided with manual segmentations and manual parse trees.
N03-1030
In addition, we will report unlabeled bracketing precision, recall and F1-score, as defined in the PARSEVAL metrics (Black et al., 1991) and evaluated via the widely used evalb package.
H91-1060
First, in Section 2.3, we compare SPADE results under our configuration with results from Sporleder and Lapata (2005) in order to establish comparability, and this is done on their 608 sentence subset.
H05-1033
There are a number of corpora annotated with discourse structure, including the well-known RST Treebank (Carlson et al., 2002); the Discourse GraphBank (Wolf and Gibson, 2005); and the Penn Discourse Treebank (Miltsakaki et al., 2004).
J05-2005
Secondly, Charniak and Johnson (2005) showed how reranking of the 50best output of the Charniak (2000) parser gives substantial improvements in parsing accuracy.
A00-2018 P05-1022
This feature set is very close to that used in Sporleder and Lapata (2005), but not identical.
H05-1033
493 Segmentation Unlabeled Nuc/Sat SPADE 76.9 70.2 Classifier: Full finite state 78.1 71.1 Classifier: All features 83.5 76.1 Table 3: Discourse parsing results on the 951 sentence Soricut and Marcu (2003) evaluation set, using SPADE for parsing, and various methods for segmentation.
N03-1030
Discourse structure annotations have been demonstrated to be of high utility for a number of NLP applications, including automatic text summarization (Marcu, 1998; Marcu, 1999; Cristea et al., 2005), sentence compression (Sporleder and Lapata, 2005), natural language generation (Prasad et al., 2005) and question answering (Verberne et al., 2006).
H05-1033 W98-1124
Sporleder and Lapata (2005) also used the RST Treebank as training data for data-driven discourse parsing algorithms, though their focus, in contrast to Soricut and Marcu (2003), was to avoid contextfree parsing and rely exclusively on features in their model that could be derived via finite-state chunkers andtaggers.
H05-1033 N03-1030
Journal (WSJ) Treebank (Marcus et al., 1993).
J93-2004
Hence Soricut and Marcu (2003) evaluate with respect to sentence internal segmentationboundaries, i.e., withindicesj suchthat0<j<k for a sentence of length k.
N03-1030
Table 1 compares segmentation results of three systems on the Sporleder and Lapata (2005) 608 sentence subset of the evaluation data: (1) their best reported system; (2) the SPADE system results reported in that paper; and (3) the SPADE system results with our current configuration.
H05-1033
Their models and algorithm – subsequently packaged together into the publicly available SPADE discourse parser1 – make use of the output of the Charniak (2000) parser to derive syntactic indicator features for segmentation and discourse parsing.
A00-2018
