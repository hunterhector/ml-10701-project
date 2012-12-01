Training Set We choose a single correct path from each training parse tree, and the training examples correspond to all candidate inferences considered in every state along this path.4 In the deterministic setting there is only one correct path, so example generation is identical to that of Sagae and Lavie (2005).
W05-1513
(Bikel, 2004) 4.
J04-4004
Even though the baseline training made progress more quickly than the kitchen sink, the kitchen sink’s F1 surpassed the baseline’s F1 early in training, and at 6.3K active parameters it achieved a development set F1 of 90.55%. 4.3 Test Set Results To situate our results in the literature, we compare our results to those reported by Taskar et al.(2004) and Turian and Melamed (2005) for their discriminative parsers, which were also trained and tested on ≤ 15 word sentences.
W04-3201 W05-1515
We evaluated our parser using the standard PARSEVAL measures (Black et al., 1991): labelled precision, labelled recall, and labelled F-measure (Prec., Rec., and F1, respectively), which are based on the number of nonterminal items in the parser’s output that match those in the gold-standard parse.5 As mentioned in Section 2, items are inferred bottom-up and the parser cannot infer any item that crosses an item already in the state.
H91-1060
All features are all of the form given earlier, except for length features (Eisner & Smith, 2005).
W05-1504
Successful discriminative parsers have relied on generative models to reduce training time and raise accuracy above generative baselines (Collins & Roark, 2004; Henderson, 2004; Taskar et al., 2004).
P04-1013 P04-1015 W04-3201
In future work, we plan to try linguistically more sophisticated features (Charniak & Johnson, 2005) as well as sub-tree features (Bod, 2003; Kudo et al., 2005).
E03-1005 P05-1022 P05-1024
Henderson, 2004).
P04-1013
Although generating training examples in advance without a working parser (Turian & Melamed, 2005) is much faster than using inference (Collins & Roark, 2004; Henderson, 2004; Taskar et al., 2004), our training time can probably be decreased further by choosing a parsing strategy with a lower branching factor.
P04-1013 P04-1015 W04-3201 W05-1515
(This convention was established by Magerman (1995).) 3.
P95-1037
Other papers (Clark & Curran, 2004; Kaplan et al., 2004, e.g). have applied log-linear models to parsing.
N04-1013 P04-1014
We follow Taskar et al.(2004) in training and testing on ≤ 15 word sentences in the English Penn Treebank (Taylor et al., 2003).
W04-3201
For example, Taskar et al.(2004) took several months to train on the ≤ 15 word sentences in the English Penn Treebank (Dan Klein, p.c.).
W04-3201
Collins and Roark (2004) saw a LFMS improvement of 0.8% over their baseline discriminative parser after adding punctuation features, one of which encoded the sentence-final punctuation.
P04-1015
In this way, instead of choosing the best λ heuristically, we can optimize it during a single training run (Turian & Melamed, 2005).
W05-1515
We estimate loss gradients (Equation 13) using a sample of the inference set, which gives a 100-fold increase in training speed (Turian & Melamed, 2006).
W06-3603
Like our work, Ratnaparkhi (1999) and Sagae and Lavie (2005) generate examples off-line, but their parsing strategies are essentially shift-reduce so each sentence generates only O(n) training examples.
W05-1513
The left-to-right parser would likely improve if we were to use a left-corner transform (Collins & Roark, 2004).
P04-1015
(Bikel, 2004) 5.
J04-4004
The initial state contains terminal items, whose labels are the POS tags given by the tagger of Ratnaparkhi (1996).
W96-0213
7. POS tag the text using the tagger of Ratnaparkhi (1996).
W96-0213
As far as we know, we present the first discriminative parser that does not use information from a generative model to beat a 8Bikel (2004) is a “clean room” reimplementation of the Collins (1999) model with comparable accuracy.
J04-4004
Collins and Roark (2004) and Taskar et al.(2004) beat the generative baseline only after using the standard trick of using the output from a generative model as a feature.
P04-1015 W04-3201
We then determine the accuracy of the parser on a held-out development set using the previous λ value (before it was decreased), and stop training when this 2Turian and Melamed (2005) reported that decision trees applied to parsing have higher accuracy and training speed than decision stumps, so we build full decision trees rather than stumps.
W05-1515
aAs pointed out by an anonymous reviewer of Collins (2003), removing outermost punctuation might discard useful information.
J03-4003
Turian and Melamed (2005) observed that uniform example biases b(i) produced lower accuracy as training progressed, because the induced classifiers minimized the error per example.
W05-1515
Black, E., Abney, S., Flickenger, D., Gdaniec, C., Grishman, R., Harrison, P., et al.(1991). A procedure for quantitatively comparing the syntactic coverage of English grammars.
H91-1060
Henderson (2004) finds that discriminative training was too slow, and reports accuracy higher than generative models by discriminatively reranking the output of his generative model.
P04-1013
F1 Turian and Melamed (2005) 86.47 87.80 87.13 Bikel (2004) 87.85 88.75 88.30 Taskar et al.(2004) 89.10 89.14 89.12 kitchen sink 89.26 89.55 89.40 parser (Bikel, 2004)8, the only one that we were able to train and test under exactly the same experimental conditions (including the use of POS tags from the tagger of Ratnaparkhi (1996)).
J04-4004 W04-3201 W05-1515 W96-0213
