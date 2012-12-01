In the former, patterns for a certain answer type are either crafted manually (Soubbotin and Soubbotin, 2001) or acquired from training examples automatically (Ittycheriah et al., 2001; Ravichandran et al., 2003; Licuanan and Weischedel, 2003).
N03-2029
Smith and Eisner (2006) for machine translation.
W06-3104
Smith and Eisner, 2006), and parameterized by mixtures of a robust nonlexical syntax/alignment model with a(n optional)lexical-semantics-drivenlog-linear model.
W06-3104
Work To model the syntactic transformation process, researchers in these fields—especially in machine translation—have developed powerful grammatical formalisms and statistical models for representing and learning these tree-to-tree relations (Wu and Wong, 1998; Eisner, 2003; Gildea, 2003; Melamed, 2004; Ding and Palmer, 2005; Quirk et al., 2005; Galley et al., 2006; Smith and Eisner, 2006, inter alia).
P03-1011 P03-2041 P04-1083 P05-1034 P05-1067 P06-1121 P98-2230 W05-1205 W06-3104
Examples of 22 cases where the bag-of-words approach fails abound inQAliterature; hereweborrowanexampleusedby Echihabi and Marcu (2003).
P03-1003
3 Quasi-Synchronous Grammar For a formal description of QG, we recommend Smith and Eisner (2006).
W06-3104
The tree is produced by a state-of-the-art dependency parser (McDonald et al., 2005) trained on the Wall Street Journal Penn Treebank (Marcus et al., 1993).
J93-2004 P05-1012
Echihabi and Marcu (2003) presented a noisychannel approach in which they adapted the IBM model 4 from statistical machine translation (Brown etal.,1990; Brownetal.,1993)andappliedittoQA. Similarly, Murdock and Croft (2005) adopted a simple translation model from IBM model 1 (Brown et al., 1990; Brown et al., 1993) and applied it to QA.
H05-1086 J90-2002 J93-2003 P03-1003
Porting the translation model to QA is not straightforward; it involves parse-tree pruning heuristics (the first two deterministic steps in Echihabi and Marcu, 2003) and also replacing the lexical translation table with a monolingual “dictionary” which simply encodes the identity relation.
P03-1003
We tokenized sentences using the standard treebank tokenization script, and then we performed part-of-speech tagging using MXPOST tagger (Ratnaparkhi, 1996).
W96-0213
Here, following Smith and Eisner (2006), we use a weighted, quasi-synchronous dependency grammar.
W06-3104
We propose Smith and Eisner’s (2006) quasi-synchronous grammar (Section 3) as a general solution and the Jeopardy model (Section 4) as a specific instance.
W06-3104
The resulting POS-tagged sentences were then parsed using MSTParser (McDonald et al., 2005), trained on the entire Penn Treebank to produce labeled dependency parse trees (we used a coarse dependency label set that includes twelve label types).
P05-1012
We follow a similar setup to Shen and Klakow (2006) by automatically selecting answer candidate sentences and then comparing against a human-judged gold standard.
P06-1112
Shen and Klakow (2006) extend the idea further through the use of log-linear models to learn a scoring function for relation pairs.
P06-1112
At a high level, the QA task boils down to only twoessentialsteps(EchihabiandMarcu, 2003).
P03-1003
We can also observe a trend in recent work in textual entailment that more emphasis is put on explicit learning of the syntactic graph mapping between the entailed and entailed-by sentences (MacCartney et al., 2006).
N06-1006
This model is very similar to Smith and Eisner (2006).
W06-3104
The same story has been told for machine translation (Yamada and Knight, 2001, inter alia), in which a target language sentence (the desired output) has undergone semantic transformation (word to word translation) and syntactic transformation (syntax divergence across languages) to generate the source language sentence (noisy-channel model).
P01-1067
Similar stories can also be found in paraphrasing (Quirk et al., 2004; Wu, 2005) and textual entailment (Harabagiu and Hickl, 2006; Wu, 2005).
P05-1034 P06-1114 W04-3219 W05-1205
