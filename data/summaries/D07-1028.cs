In addition, uniform conditioning on mother grammatical function is more general than the case-phenomena specific generation grammar transform of (Cahill and van Genabith, 2006), in that it applies to each and every sub-part of a recursive input f-structure driving generation, making available relevant generation history (context) to guide local generation decisions.
P06-1130
The up-arrows and down-arrows are shorthand for φ(M(ni)) = φ(ni) where ni is the c-structure node annotated with the equation.2 Treebest := argmaxTreeP(Tree|F-Str) (1) P(Tree|F-Str) := productdisplay X → Y in Tree Feats = {ai|∃vj(φ(X))ai = vj} P(X → Y |X, Feats) (2) The generation model of (Cahill and van Genabith, 2006) maximises the probability of a tree given an f-structure (Eqn.
P06-1130
In this way, the generation model resembles history-based models for parsing (Black et al., 1992; Collins, 1999; Charniak, 2000).
A00-2018 H92-1026
average number average length (Chieu and Ng, 2003) 0.61 2.40 Stanford MWE Project 0.10 2.48 BBN Corpus 1.15 2.66 Table 9: Average number of MWUs per sentence and average MWU length in the WSJ treebank grouped by MWU source.
W03-0423
To solve the problem, Cahill and van Genabith (2006) apply an automatic generation grammar transformation to their training data: they automatically label CFG nodes with additional case information and the model now learns the new improved generation rules of Tables 4 and 5.
P06-1130
Insofar as it is a broad coverage generator, which has been trained and tested on sections of the WSJ corpus, our generator is closer to the generators of (Bangalore and Rambow, 2000; Langkilde-Geary, 2002; Nakanishi et al., 2005) than to those designed for more restricted domains such as weather forecast (Belz, 2007) and air travel domains (Ratnaparkhi, 2000).
A00-2026 C00-1007 N07-1021 W05-1510
Realisation from f-Structures Cahill and van Genabith (2006) present a probabilistic surface generation model for LFG (Kaplan, 1995).
P06-1130
We take the generator of (Cahill and van Genabith, 2006) as our baseline generator.
P06-1130
This additional conditioning has the effect of making the choice of generation rules sensitive to the history of the generation process, and, we argue, provides a simpler, more uniform, general, intuitive and natural probabilistic generation model obviating the need for CFG-grammar transforms in the original proposal of (Cahill and van Genabith, 2006).
P06-1130
The baseline generation algorithm, following Kay (1996)’s work on chart generation, already contains the hard constraint that when combining two chart edges they must cover disjoint sets of words.
P96-1027
Langkilde-Geary (2002) re274 Section 24 (1346 sentences) Model MWUs BLEU StringEd Coverage HB Model 65.85 69.93 99.93 type 1 (Chieu and Ng, 2003) 65.81 70.34 99.93 (training and test data chunked) +Stanford MWEs 64.81 69.67 99.93 BBN 67.24 71.46 99.93 type 2 (Chieu and Ng, 2003) 66.37 70.26 99.93 (test data chunked) +Stanford MWEs 66.28 70.21 99.93 BBN 66.84 70.74 99.93 type 3 (Chieu and Ng, 2003) 66.30 70.12 100 (internal generation constraint) +Stanford MWEs 66.07 70.02 99.93 BBN 66.45 70.14 99.93 Table 11: Results on Section 24, all sentence lengths.
W03-0423
For example, the named entity recogniser of (Chieu and Ng, 2003) achieves an accuracy of 88.3% on section 23 of the Penn Treebank.
W03-0423
In an error analysis of type 1 experiments with (Chieu and Ng, 2003) concatenated MWUs, we inspected those sentences where accuracy had decreased from the baseline.
W03-0423
It is an important and growing field of natural language processing with applications in areas such as transferbased machine translation (Riezler and Maxwell, 2006) and sentence condensation (Riezler et al., 2003).
N03-1026 N06-1032
In Table 10, Baseline gives the results of the generation algorithm of (Cahill and van Genabith, 2006).
P06-1130
F-Struct Feats Grammar Rules {PRED=PRO,NUM=SG PER=3, GEN=FEM} PRP-nom(↑=↓) → she {PRED=PRO,NUM=SG PER=3, GEN=FEM} PRP-acc(↑=↓) → her Table 5: Lexical item rules with case markings 4 A History-Based Generation Model The automatic generation grammar transform presented in (Cahill and van Genabith, 2006) provides a solution to coarse-grained and (in fact) inappropriate independence assumptions in the basic generation model.
P06-1130
First, MWUs came from the automatic NE recogniser of (Chieu and Ng, 2003), then we added the MWUs from the Stanford list and finally we ran tests with MWUs extracted from the BBN corpus.
W03-0423
Nakanishi et al.(2005) describe a treebankextracted HPSG-based chart generator.
W05-1510
In the LFG-based generation algorithm presented by Cahill and van Genabith (2006) complex named entities (i.e.
P06-1130
One possible reason for the low accuracy scores in the type 1 experiments with the (Chieu and Ng, 2003) MWU chunked data could be noisy MWUs which negatively affect the grammar.
W03-0423
In order to compare our system with those of (Nakanishi et al., 2005) and (Langkilde-Geary, 2002) we report our best results with automatically acquired MWUs for sentences of ≤ 20 words in length on section 23: our system gets coverage of 100% and a BLEU score of 71.39.
W05-1510
For the same test set Nakanishi et al.(2005) achieved coverage of 90.75 and a BLEU score of 77.33.
W05-1510
This history-based approach has worked well in parsing (Collins, 1999; Charniak, 2000) and we show that it also improves PCFG-based generation.
A00-2018
First, we use the output of the maximum entropy-based named entity recognition system of (Chieu and Ng, 2003).
W03-0423
As with Nakanishi et al.(2005) we find the ‘permute,no dir’ type of input is most comparable to the level of information contained in our input f-structures.
W05-1510
These were achieved using experiment type 2, described in Section 5, with the MWUs produced by (Chieu and Ng, 2003).
W03-0423
While recent work on generation in restricted domains, such as (Belz, 2007), has shown promising results there remains much room for improvement particularly for broad coverage and robust generators, like those of Nakanishi et al.(2005) and Cahill ∗ Now at the Institut f¨ur Maschinelle Sprachverarbeitung, Universit¨at Stuttgart, Azenbergstrae 12, D-70174 Stuttgart, Germany.
N07-1021 W05-1510
Cahill and van Genabith (2006) note that conditioning f-structure annotated generation rules on local features (Eqn.
P06-1130
Note, that for our example the effect of the uniform additional conditioning on mother grammatical function has the same effect as the generation grammar transform of (Cahill and van Genabith, 2006), but without the need for the gramF-Struct Feats Grammar Rules {PRED=PRO,NUM=SG PER=3, GEN=FEM, SUBJ} PRP(↑=↓) → she {PRED=PRO,NUM=SG PER=3, GEN=FEM, OBJ} PRP(↑=↓) → her Table 7: Lexical item rules.
P06-1130
Unlike, say, the parent annotation for parsing of (Johnson, 1998) the parent GF feature for a particular node expansion is not merely extracted from the parent node in the c-structure tree, but is sometimes extracted from an ancestor node further up the c-structure tree via intervening ↑=↓ functional annotations.
J98-4004
These rules can be handcrafted grammar rules, such as those of (LangkildeGeary, 2002; Carroll and Oepen, 2005), created semi-automatically (Belz, 2007) or, alternatively, extracted fully automatically from treebanks (Bangalore and Rambow, 2000; Nakanishi et al., 2005; Cahill and van Genabith, 2006).
C00-1007 N07-1021 P06-1130 W05-1510
While Belz (2007) and Humphreys et al.(2001) mention the use of contextual features for the rules in their generation models, they do not provide details nor do they provide a formal probability model.
N07-1021 W01-0812
As can be seen from Table 11 the best score for automatically chunked MWUs are with the (Chieu and Ng, 2003) MWUs.
W03-0423
The LFG annotation algorithm of (Cahill et al., 2004) was used to produce the f-structures for development, test and training sets.
P04-1041
As in (Cahill and van Genabith, 2006) fstructures are generated from the (now altered) treebank and from this data, along with the treebank trees, the PCFG-based grammar, which is used for training the generation model, is extracted.
P06-1130
