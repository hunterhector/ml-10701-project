translation system We constructed and evaluated our case prediction model in the context of a treelet-based translation system, described in Quirk et al.(2005).2 In this approach, translation is guided by treelet translation pairs, where a treelet is a connected subgraph of a dependency tree.
P05-1034
The case markers we used for the prediction task are the same as those defined in Suzuki and Toutatnova (2006), and are summarized in Table 1: in addition to the case markers in a strict sense, the topic marker wa is also included as well as the combination of a case marker plus the topic marker for the case markers with the column +wa checked in the table.
P06-1132
The target language treelets are then joined to form a single tree, and the ordering of all the nodes is determined, using the method described in Quirk et al.(2005). Translations are scored according to a linear combination of feature functions: ( ) ( )j j j score t f tλ= ∑ (1) 2 Though this paper reports results in the context of a treelet system, the model is also applicable to other syntax-based or phrase-based SMT systems.
P05-1034
Such an approach has been taken by Och et al.(2004) for integrating sophisticated syntax-informed models in a phrasebased SMT system.
N04-1021
Most stateof-the-art SMT systems treat grammatical elements in exactly the same way as content words, and rely on general-purpose phrasal translations and target language models to generate these elements (e.g., Och and Ney, 2002; Koehn et al., 2003; Quirk et al., 2005; Chiang, 2005; Galley et al., 2006).
N03-1017 P02-1038 P03-1021 P05-1033 P05-1034 P06-1121
Using the pair-wise statistical test design described in Collins et al.(2005), the BLEU improvement (35.53 vs.
P05-1066
of case marker prediction Our definition of the case marker prediction task follows Suzuki and Toutanova (2006).
P06-1132
A common approach of integrating new models with a statistical MT system is to add them as new feature functions which are used in decoding or in models which re-rank n-best lists from the MT system (Och et al., 2004).
N04-1021
Aligned English-Japanese sentence pair 51 3.2 Model features and feature selection The features of our model are similar to the ones described in Suzuki and Toutanova (2006).
P06-1132
# sent pairs # of words (average sent length in words) data set English Japanese train-500K 500K 7,909,198 (15.81) 9,379,240 (18.75) lambda-1K 1,000 15,219(15.2) 20,660 (20.7) dev-1K 1,000 15,397(15.4) 21,280 (21.3) test-2K 2,000 30,198(15.1) 41,269 (20.6) Table 2: Data set characteristics 3 Statistical Models for Case Prediction in MT 3.1 Case prediction model Our model of case marker prediction closely follows our previous work of case prediction in a non-MT context (Suzuki and Toutanova, 2006).
P06-1132
1: Standard n-best re-ranking This method is a straightforward application of the n-best re-ranking approach described in Och et al.(2004). As described in Section 2.2, our baseline SMT system is a linear model which weighs the values of ten feature functions.
N04-1021
We also show that integrating our case prediction model improves the quality of translation according to BLEU (Papineni et al., 2002)g2 and human evaluation.
P02-1040
This independence assumption may seem strong, but the results presented in our previous work (Suzuki and Toutanova, 2006) showed that a joint model did not result in large improvements over a local one in predicting case markers in a nonMT context.
P06-1132
Previous work has discussed the building of special-purpose classifiers which generate grammatical elements such as prepositions (Hajič et al.2002), determiners (Knight and Chander, 1994) and case markers (Suzuki and Toutanova, 2006) with an eye toward improving MT output.
P06-1132
First, the corpus is wordaligned using GIZA++ (Och and Ney, 2000); then the source sentences are parsed into a dependency structure, and the dependency is projected onto the target side following the heuristics described in Quirk et al.(2005). Figure 2 shows an example of an aligned sentence pair: on the source (English) side, POS tags and word dependency structure are assigned (solid arcs); the word alignments between English and Japanese words are indicated by the dotted lines.
P00-1056 P05-1034
There are ten feature functions in the treelet system, including log-probabilities according to inverted and direct channel models estimated by relative frequency, lexical weighting channel models following Vogel et al.(2003), a trigram target language model, an order model, word count, phrase count, average phrase size functions, and whole-sentence IBM Model 1 logprobabilities in both directions (Och et al.2004). The weights of these models are determined using the max-BLEU method described in Och (2003).
N04-1021 P03-1021
