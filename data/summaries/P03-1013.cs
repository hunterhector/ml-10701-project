Treebank-based probabilistic parsing has been the subject of intensive research over the past few years, resulting in parsing models that achieve both broad coverage and high parsing accuracy (e.g., Collins 1997; Charniak 2000).
A00-2018 P97-1003
Section 5 presents an error analysis for Collins’s (1997) lexicalized model, which shows that the head-head dependencies used in this model fail to cope well with the flat structures in Negra.
P97-1003
Using cascaded Markov models, Brants (2000) reports an improved performance on the same task (LR 84.4%, LP 88.3%).
A00-1031
While Negra has been used to build probabilistic chunkers (Becker and Frank, 2002; Skut and Brants, 1998), the research reported in this paper is the first attempt to develop a probabilistic full parsing model for German trained on a treebank (to our knowledge).
C02-1093 W98-1117
The reader is referred to Schmid (2000) and Collins (1997) for details.
P97-1003
In Experiment 1, we applied three standard parsing models from the literature to Negra: an unlexicalized PCFG model (the baseline), Carroll and Rooth’s (1998) head-lexicalized model, and Collins’s (1997) model based on head-head dependencies.
P97-1003
We used TnT (Brants, 2000), trained on the Negra training set.
A00-1031
The Collins (1997) model does not use context-free rules, but generates the next category using zeroth order Markov chains (see Section 3.3), hence no information about the previous sisters is included.
P97-1003
TnT tagging Perfect tagging ∆LR ∆LP ∆LR ∆LP PP −3.45 −1.60 −4.21 −3.35 S −1.28 0.11 −2.23 −1.22 Coord −1.87 −0.39 −1.54 −0.80 VP −0.72 0.18 −0.58 −0.30 AP −0.57 0.10 0.08 −0.07 AV P −0.32 0.44 0.10 0.11 NP 0.06 0.78 −0.15 0.02 Table 6: Change in performance when reverting to head-head statistics for individual categories ter information (Charniak, 2000), as illustrated in Table 4.
A00-2018
Lexicalization can increase parsing performance dramatically for English (Carroll and Rooth, 1998; Charniak, 1997, 2000; Collins, 1997), and the lexicalized model proposed by Collins (1997) has been successfully applied to Czech (Collins et al., 1999) and Chinese (Bikel and Chiang, 2000).
A00-2018 P97-1003 P99-1065 W00-1201
The head-lexicalized model of Carroll and Rooth (1998) has been applied to German by Beil et al.3 It is unclear what effect bi-lexical statistics have on the sister-head model; while Gildea (2001) shows bi-lexical statistics are sparse for some grammars, Hockenmaier and Steedman (2002) found they play a greater role in binarized grammars.
P02-1043 W01-0521
Collins et al.(1999) and Bikel and Chiang (2000) do not compare their models with an unlexicalized baseline; hence it is unclear if lexicalization really improves parsing performance for these languages.
P99-1065 W00-1201
The present paper addresses this question by proposing a probabilistic parsing model trained on Negra (Skut et al., 1997), a syntactically annotated corpus for German.
A97-1014
Neither Collins et al.(1999) nor Bikel and Chiang (2000) compare the lexicalized model to an unlexicalized baseline model, leaving open the possibility that lexicalization is useful for English, but not for other languages.
P99-1065 W00-1201
Prominent among these properties is the semi-free Language Size LR LP Source English 40,000 87.4% 88.1% (Collins, 1997) Chinese 3,484 69.0% 74.8% (Bikel and Chiang, 2000) Czech 19,000 —80.0% —(Collins et al., 1999) Table 1: Results for the Collins (1997) model for various languages (dependency precision for Czech) wordorder, i.e., German wordorder is fixed in some respects, but variable in others.
P97-1003 P99-1065 W00-1201
For non-recursive NPs, Collins (1997) does not use the probability function in (5), but instead substitutes P r (and, by analogy, P l ) by: P r (R i ;t(R i );l(R i )jP;R i−1 ;t(R i−1 );l(R i−1 );d(i))(8) Here the head H is substituted by the sister R i−1 (and L i−1 ).
P97-1003
Charniak’s (2000) model extends this to higher order Markov chains (first to third order), and therefore includes category information about previous sisters.The current model differs from all these proposals: it does not use any information about the head sister, but instead includes the category, head word, and head tag of the previous sister, effectively treating it as the head.
A00-2018
sister head tag X Table 4: Linguistic features in the current model compared to the models of Carroll and Rooth (1998), Collins (1997), and Charniak (2000) Negra, based on Collins’s (1997) model for nonrecursive NPs in the Penn Treebank (which are also flat).
A00-2018 P97-1003
The lexicalized model proposed by Collins (1997) (henceforth Collins model) was re-implemented by one of the authors.
P97-1003
Section 3 describes two standard lexicalized models (Carroll and Rooth, 1998; Collins, 1997), as well as an unlexicalized baseline model.
P97-1003
Parsing Models 3.1 Probabilistic Context-Free Grammars Lexicalization has been shown to improve parsing performance for the Penn Treebank (e.g., Carroll and Rooth 1998; Charniak 1997, 2000; Collins 1997).
A00-2018 P97-1003
The progression in the probabilistic parsing literature has been to start with lexical head-head dependencies (Collins, 1997) and then add non-lexical sis2 This result generalizes to Ss, which are also flat in Negra (see Section 2.2).
P97-1003
3.3 Collins’s Head-Lexicalized Model In contrast to Carroll and Rooth’s (1998) approach, the model proposed by Collins (1997) does not compute rule probabilities directly.
P97-1003
The annotation scheme (Skut et al., 1997) is modeled to a certain extent on that of the Penn Treebank (Marcus et al., 1993), with crucial differences.
A97-1014 J93-2004
However, most of the existing models have been developed for English and trained on the Penn Treebank (Marcus et al., 1993), which raises the question whether these models generalize to other languages, and to annotation schemes that differ from the Penn Treebank markup.
J93-2004
Skut and Brants (1998) used Negra to train a maximum entropy-based chunker, and report LR and LP of 84.4% for NP and PP chunking.
W98-1117
Becker and Frank (2002) train an unlexicalized PCFG on Negra to perform a different chunking task, viz., the identification of topological fields (sentence-based chunks).
C02-1093
The work by Collins et al.(1999) and Bikel and Chiang (2000) has demonstrated the applicability of the Collins (1997) model for Czech and Chinese.
P97-1003 P99-1065 W00-1201
We first added sister-head dependencies for NPs (following Collins’s (1997) original proposal) and then for PPs, which are flat in Negra, and thus similar in structure to NPs (see Section 2.2).
P97-1003
However, the learning curve for Negra (see Figure 1) indicates that the performance of the Collins (1997) model is stable, even for small training sets.
P97-1003
Table 4 shows the linguistic features of the resulting model compared to the models of Carroll and Rooth (1998), Collins (1997), and Charniak (2000).
A00-2018 P97-1003
