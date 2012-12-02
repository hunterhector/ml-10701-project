In addition, to allow for the possibility of valid lexical differences between the translation and the references, we follow Kauchak and Barzilay (2006) in adding a number of synonyms in the process of evaluation to raise the number of matches between the translation and the reference, leading to a higher score.
N06-1058
Kauchak and Barzilay (2006) and Owczarzak et al.(2006) use paraphrases during BLEU and NIST evaluation to increase the number of matches between the translation and the reference; the paraphrases are either taken from WordNet4 in Kauchak and Barzilay (2006) or derived from the test set itself through automatic word and phrase alignment in Owczarzak et al.(2006). Another metric making use of synonyms is the linear regression model developed by Russo-Lassner et al.(2005), which makes use of stemming, WordNet synonymy, verb class synonymy, matching noun phrase heads, and proper name matching.
N06-1058
(Rosario and Hearst, 2001; Moldovan et al., 2004; Kim and Baldwin, 2005) use supervised methods and explore classification features from a simple structured type hierarchy.
W04-0841
We present a comparative study on the behavior of several metric representatives from each linguistic level in the context of some of the cases reported by Koehn and Monz (2006) and Callison-Burch et al.(2006) (see Section 3).
N06-1003
However, recent work suggests that Bleu?s correlation with human judgments may not be as strong as previously thought (Callison-Burch et al., 2006).
N06-1003
c2007 Association for Computational Linguistics Linguistic Features for Automatic Evaluation of Heterogenous MT Systems Jesus Gimenez and Llus M`arquez TALP Research Center, LSI Department Universitat Polit`ecnica de Catalunya Jordi Girona Salgado 1??, E-08034, Barcelona {jgimenez,lluism}@lsi.upc.edu Abstract Evaluation results recently reported by Callison-Burch et al.(2006) and Koehn and Monz (2006), revealed that, in certain cases, the BLEU metric may not be a reliable MT quality indicator.
N06-1003
Chris Callison-Burch, Miles Osborne and Philipp Koehn, 2006.
N06-1003
Quirk et al.(2004) also generate sentential paraphrases using a monolingual corpus.
W04-3219
3 3 Related work 3.1 String-based metrics The insensitivity of BLEU and NIST to perfectly legitimate syntactic and lexical variation has been raised, among others, in Callison-Burch et al.(2006), but the criticism is widespread.
N06-1003
Although widely popular thanks to their speed and efficiency, both BLEU and NIST have been criticized for inadequate accuracy of evaluation at the segment level (Callison-Burch et al., 2006).
N06-1003
The efficacy of this approach has been well-established in many areas, including automated evaluation of machine translation systems (Kauchak and Barzilay, 2006), text summarization (Kittredge, 2002), question answering (Rinaldi et al., 2003), document retrieval (Zukerman and Raskutti, 2002), and many others.
C02-1161 N03-1003 N06-1058 W03-1604
To address this complexity, many biomedical IE systems (Alphonse et al., 2004; Rinaldi et al., 2004; Fundel et al., 2007) and annotated corpora (Kim et al., 2003; Aubin, 2005; Pyysalo et al., 2007) incorporate full syntactic analysis.
W03-1604
Callison-Burch. 2006.
N06-1003
We analyze some of the cases reported by Koehn and Monz (2006) and Callison-Burch et al.(2006). We distinguish different evaluation contexts.
N06-1003
Recent years have seen several studies investigating MT evaluation at the sentence level (Liu et al., 2005,2006; Quirk, 2004).
W04-3219
Most of the reported work on paraphrase generation from arbitrary input sentences uses machine learning techniques trained on sentences that are known or can be inferred to be paraphrases of each other (Bannard and Callison-Burch, 2005; Barzilay and Lee, 2003; Barzilay and McKeown, 2001; Callison-Burch et al., 2006; Dolan et al., 2004; Ibrahim et al., 2003; Lin and Pantel, 2001; Pang et al., 2003; Quirk et al., 2004; Shinyama et al., 2002).
C04-1051 N03-1003 N03-1024 N06-1003 P01-1008 P05-1074 W03-1608 W04-3219
As suggested by Callison-Burch et al.(2006) we perform a focussed manual analysis of the output to see what changes have occurred.
N06-1003
At the sentence level, (Barzilay and Lee, 2003) employed an unsupervised learning approach to cluster sentences and extract lattice pairs from comparable monolingual corpora.
N03-1003
We performed the same experiment joining the Answer Validation Exercise4 (AVE) 2006 English data set (Pe?nas et al., 2006) and the Microsoft Research Paraphrase Corpus5 (MSRPC) (Dolan et al., 2004) to the previous corpora (RTE-1 and RTE2) resulting a total of 8585 entailment pairs filtering pairs with a text or a hypothesis with more than 1 sentence.
C04-1051
3.2 Multiple-reference Scenario We study the case reported by Callison-Burch et al.(2006) in the context of the Arabic-to-English exercise of the ??005 NIST MT Evaluation Campaign??
N06-1003
However, automatic measures also have big disadvantages; (Callison-Burch et al., 2006) describes some of them.
N06-1003
A number of other approaches rely on parallel monolingual data and, additionally, require parsing of the training sentences (Ibrahim et al., 2003; Pang et al., 2003).
N03-1024 W03-1608
Most previous work on paraphrase has focused on high quality rather than coverage (Barzilay and Lee, 2003; Quirk et al., 2004), but generating artificial references for MT parameter tuning in our setting has two unique properties compared to other paraphrase applications.
N03-1003 W04-3219
Barzilay and McKeown (2001) identify multi-word paraphrases from a sentence-aligned corpus of monolingual parallel texts.
P01-1008
Following Bannard and Callison-Burch (2005), we first identify English-to-F correspondences, then map from English to English by following translation units from English to F and back.
P05-1074
Although automatic semantic parsing is a large and growing field (Moldovan et al., 2004; Litkowski, 2004; Baldewein et al., 2004), two problems present themselves.
W04-0803 W04-0817 W04-0841
This can take the form of identifying or substituting equivalent multi-word strings, e.g., (Bosma and Callison-Burch, 2006).
N06-1003
Dolan. 2004.
C04-1051
??ParaEval precision and ParaEval recall (Zhou et al., 2006)?ParaEval matches hypothesis and reference translations using paraphrases that are extracted from parallel corpora in an unsupervised fashion (Bannard and Callison-Burch, 2005).
P05-1074
For instance, Callison-Burch et al.(2006) and Koehn and Monz (2006) reported and analyzed several cases of strong disagreement between system rankings provided by human assessors and those produced by the BLEU metric (Papineni et al., 2001).
N06-1003
Quirk, Training a Sentence-Level Machine Translation Condence Measure, In Proceedings of LREC, 2004.
W04-3219
Callison-Burch et al.(2006) extract phrase-level paraphrases by mapping input phrases into a phrase table and then mapping back to the source language.
N06-1003
