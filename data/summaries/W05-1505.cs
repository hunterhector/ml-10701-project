The technique proposed in this paper is similar to that of recent parser reranking approaches (Collins, 2000; Charniak and Johnson, 2005); however, while reranking approaches allow a parser to generate a likely candidate set according to a generative model, we consider a set of candidates based on local perturbations of the single most likely tree generated.
P05-1022
For a more detailed introduction to maximum entropy estimation see (Berger et al., 1996).
J96-1002
tures we use in the current model are similar to those proposed by Levy and Manning (2004).
P04-1042
use Zhang Lee’s implementation of the 7 We have used PDT 1.0 (2002) data for the Charniak experiments and PDT 2.0 (2005) data for the Collins experiments.
P05-1022
(Bilexical models were also proposed by Eisner (Eisner, 1996)).
C96-1058
47 Feature Type Id Description Form F the fully inflected word form as it appears in the data Lemma L the morphologically reduced lemma MTag T a subset of the morphological tag as described in (Collins et al., 1999) POS P major part-of-speech tag (first field of the morphological tag) ParserGov G true if candidate was proposed as governor by parser ChildCount C the number of children Agreement A(x,y) check for case/number agreement between word x and y Table 2: Description of the classes of features used In all models, we include features containing the form, the lemma, the morphological tag, and the ParserGov feature.
P99-1065
Recent work by Smith and Eisner (2005) on contrastive estimation suggests similar techniques to generate local neighborhoods of a parse; however, the purpose in their work is to define an approximation to the partition function for log-linear estimation (i.e., the normalization factor in a MaxEnt model).
P05-1044
We examine two state-of-the-art constituencybased parsers in this work: the Collins Czech parser (1999) and a version of the Charniak parser (2001) that was modified to parse Czech.
P01-1017 P99-1065
In an attempt to extend a constituency-based parsing model to train on dependency trees, Collins transforms the PDT dependency trees into constituency trees (Collins et al., 1999).
P99-1065
The corrective algorithm proposed in this paper shares the motivation of the transformation-based learning work (Brill, 1995).
J95-4004
The trees are then transformed into Penn Treebank style constituencies using the technique described in (Collins et al., 1999).
P99-1065
Work Recent work by Nivre and Nilsson introduces a technique where the projectivization transformation is encoded in the non-terminals of constituents during parsing (Nivre and Nilsson, 2005).
P05-1013
Although the results presented in (Collins et al., 1999) used the reordering technique, we have experimented with his parser using the governor–raising technique and observe an increase in dependency accuracy.
P99-1065
The computational complexity advantages of dynamic programming techniques along with efficient search techniques (Caraballo and Charniak, 1998; Klein and Manning, 2003) allow for richer predictive models which include local contextual information.
J98-2004
Alternative efforts to recover dependency structure from English are based on reconstructing the movement traces encoded in constituency trees (Collins, 2003; Levy and Manning, 2004; Johnson, 2002; Dubey and Keller, 2003).
J03-4003 P02-1018 P03-1013 P04-1015 P04-1042
We mentioned above that our approach appears to be similar to that of reranking for statistical parsing (Collins, 2000; Charniak and Johnson, 2005).
P05-1022
An alternative method, used by Charniak in the adaptation of his parser for Czech 6 and used by Nivre and Nilsson (2005), alters the dependency links by raising the governor to a higher node in the tree whenever 5 Bilexical dependencies are components of both the Collins and Charniak parsers and effectively model the types of syntactic subordination that we wish to extract in a dependency tree.
P05-1013 P05-1022
Collins (1999) explicitly added features to his parser to improve punctuation dependency parsing accuracy.
P99-1065
Parsing for Dependency Trees A pragmatic justification for using constituencybased parsers in order to predict dependency structures is that currently the best Czech dependencytree parser is a constituency-based parser (Collins et al., 1999; Zeman, 2004).
P04-1015 P99-1065
Statistical parsing models have been shown to be successful in recovering labeled constituencies (Collins, 2003; Charniak and Johnson, 2005; Roark and Collins, 2004) and have also been shown to be adequate in recovering dependency relationships (Collins et al., 1999; Levy and Manning, 2004; Dubey and Keller, 2003).
J03-4003 P03-1013 P04-1015 P04-1042 P05-1022 P99-1065
