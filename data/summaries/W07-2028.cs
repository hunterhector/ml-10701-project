For automatic parsing, we made use of the wellknownCharniakparser(Charniak,2000).
A00-2018
In 10-fold crossvalidation with this data we achieved an average fscore of 70.6, based on features similar to the subset trees used for semantic role labeling in (Moschitti 2004).
P04-1043
Kernels In (Giuliano et al., 2006), we used the local context kernel to infer semantic information on the candidate entities (i.e., roles played by the entities).
E06-1051
Results 5.1 Experimental Setup We implemented the novel cross-similarity kernel in the SVM-light-TK (Moschitti, 2006) that encodes the basic syntactic kernel KT in SVM-light (Joachims, 1999).
W06-2909
Although the CHILDES annotation scheme proposed by Sagae et al.(2004) has been used in practice for automatic parsing of child language transcripts (Sagae et al., 2004; Sagae et al., 2005), such work relied mainly on a statistical parser (Charniak, 2000) trained on the Wall Street Journal portion of the Penn Treebank, since a large enough corpus of annotated CHILDES data was not available to train a domain-specific parser.
A00-2018
Another group (Zanzotto and Moschitti, 2006) utilized a tree kernel method for cross-pair similarity, which showed an improvement, and this has motivated us to investigate kernel-based methods.
W06-2909
For this task, we defined an ad-hoc class of structured features (Moschitti et al., 2006), the Reduced Tree (RT), which can be derived from a sentence parse tree t by the following steps: (1) remove all the terminal nodes but those labeled as relation entities and those POS tagged as verbs, auxiliaries, prepositions, modals or adverbs; (2) remove all the internal nodes not covering any remaining terminal; (3) replace the entity words with placeholders that indicate the direction in which the relation should hold.
W06-2909
145 2 Related Work There has been much recent interest in extracting PPIs from abstracts and full text papers (Bunescu and Mooney, 2006; Giuliano et al., 2006; Plake et al., 2005; Blaschke and Valencia, 2002; Donaldson et al., 2003).
E06-1051
Moschitti (2006).
W06-2909
In contrast, Zanzotto&Moschitti (2006) proposed a machine-learning based approach which reaches a high accuracy by only using the available RTE data.
W06-2909
(Charniak, 2000; Briscoe et al., 2006), have wide coverage and yield grammatical representations capable of supporting various applications (e.g.
A00-2018
A tree kernel (Moschitti, 2004) is used to exploit the deep syntactic processing obtained using the Charniak parser (Charniak, 2000).
A00-2018 P04-1043
Eugene Charniak. 2000. A maximum-entropy-inspired parser. In Proceedings of NAACL, pages 132139.
A00-2018
The starting point of our research is an approach for identifying relations between named entities exploiting only shallow linguistic information, such as tokenization, sentence splitting, part-of-speech tagging and lemmatization (Giuliano et al., 2006).
E06-1051
The algorithm we used in our final submission is similar to recent systems which discover textual entailment relationships (Haghighi, Ng et al.2005; Zanzotto and Moschitti 2006).
W06-2909
This result is particularly interesting as a supersense tagger can easily provide a satisfactory accuracy (Ciaramita and Altun, 2006).
W06-1670
Generally, the syntactic structure of a sentence is represented as a tree, and parsing is carried out by maximizing the likelihood of the tree (Charniak, 2000; Uchimoto et al., 1999).
A00-2018
In recent years, many accurate phrase-structure parsers have been developed (e.g., (Collins, 1999; Charniak, 2000)).
A00-2018
142 ual design of attribute-value syntactic features (Moschitti, 2004).
P04-1043
One the best two teams in RTE-2 (Tatu et al., 2006) proposed a knowledge representation model which achieved about 10% better performance than the third (Zanzotto and Moschitti, 2006) based on their logic prover.
W06-2909
2 Cross-pair similarity and its limits 2.1 Learning entailment rules with syntactic cross-pair similarity The cross-pair similarity model (Zanzotto and Moschitti, 2006) proposes a similarity measure aiming at capturing rewrite rules from training examples, computing a cross-pair similarity KS((Tprime,Hprime),(Tprimeprime,Hprimeprime)).
W06-2909
that used in the Charniak parser (Charniak, 2000) or the various CCG parsers (Hockenmaier, 2006)).
A00-2018
Context Kernel Bunescu and Mooney (2005) and Giuliano et al.(2006) successfully exploited the fact that relations between named entities are generally expressed using only words that appear simultaneously in one of the following three contexts.
E06-1051
That work relied on a phrase-structure statistical parser (Charniak, 2000) trained on the Penn Treebank, and the output of that parser had to be converted into CHILDES grammatical relations.
A00-2018
For comparison, Sagae et al.(2005) report 86.9% LAS on about 2,000 words of Eve data, using the Charniak (2000) parser with a separate dependency-labeling step.
A00-2018
E. Charniak, D. Blaheta, N. Ge, K. Hall, and M. Johnson. 2000. BLLIP 198789 WSJ Corpus Release 1, LD No. LDC2000T43. Linguistic Data Consortium.
A00-2018
We have also begun to experiment with the tree kernels of Moschitti (2006), but are not yet in a position to report results.
W06-2909
Finally, we would like to experiment with more sophisticated kernels, the tree kernels described in (Moschitti, 2004), i.e. models that have shown a lot of promise for the English SRL process.
P04-1043
For classification we applied the updated tree-kernel package (Moschitti 2006), distributed with the svm-light tool (Joachims 1999) for learning Support Vector Machines (SVMs).
W06-2909
This parser uses a discriminative reranker that selects the most probable parse from the 50-best parses returned by a generative parser based on Charniak (2000).
A00-2018
parse trees as in (Moschitti, 2004)) would be more successful.
P04-1043
BLLIP corpus (Charniak et al., 2000), which con-
A00-2018
