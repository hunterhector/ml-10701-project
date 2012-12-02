Deterministic parsing has emerged as an attractive alternative to probabilistic parsing, offering accuracy just below the state-of-the-art in syntactic analysis of English, but running in linear time (Sagae and Lavie, 2005; Yamada and Matsumoto, 2003; Nivre and Scholz, 2004).
C04-1010 W05-1513
Luo (2003) and Fung et al.(2004) addressed the issue of Chinese text segmentation in their work by constructing characterbased parsers.
W03-1025
A simple transformation process as described in (Sagae and Lavie, 2005) is employed to convert between arbitrary branching trees and binary trees.
W05-1513
Maximum-entropy models have been used for Chinese character-based parsing (Fung et al., 2004; Luo, 2003) and POS tagging (Ng and Low, 2004).
W03-1025 W04-3236
In Sun and Jurafsky (2004)’s work on Chinese shallow semantic parsing, they also applied Collin’s parser to Chinese.
N04-1032
Chiang and Bikel (2002) used inside-outside unsupervised learning algorithm to augment the rules for finding heads, and achieved an improved LR/LP of 78.8%/81.1%.
C02-1126
Model LR LP F1 Bikel’s Thesis 2004 80.9% 84.5% 82.7% Jiang’s Thesis 2004 84.5% 88.0% 86.2% DTree model 80.5% 83.9% 82.2% Maxent model 81.4% 82.8% 82.1% SVM model 87.2% 88.3% 87.8% Stacked classifier model 88.3% 88.1% 88.2% Table 4: Comparison with related work on the test set for sentence ≤ 40 words, using gold-standard POS To measure efficiency, we ran two publicly available parsers (Levy and Manning’s PCFG parser (2003) and Bikel’s parser (2004)) on the standard test set and compared the runtime4.
P03-1056
In the meta-classifier approach, we first collect the output from each classifier trained on sec429 MODEL ≤ 40 words ≤ 100 words UnlimitedLR LP F1 POS LR LP F1 POS LR LP F1 POS Bikel & Chiang 2000 76.8% 77.8% 77.3% 73.3% 74.6% 74.0% Levy & Manning 2003 79.2% 78.4% 78.8% Xiong et al.2005 78.7% 80.1% 79.4% Bikel’s Thesis 2004 78.0% 81.2% 79.6% 74.4% 78.5% 76.4% Chiang & Bikel 2002 78.8% 81.1% 79.9% 75.2% 78.0% 76.6% Jiang’s Thesis 2004 80.1% 82.0% 81.1% 92.4% Sun & Jurafsky 2004 85.5% 86.4% 85.9% 83.3% 82.2% 82.7% DTree model 71.8% 76.9% 74.4% 92.5% 69.2% 74.5% 71.9% 92.2% 68.7% 74.2% 71.5% 92.1% SVM model 78.1% 81.1% 79.6% 92.5% 75.5% 78.5% 77.0% 92.2% 75.0% 78.0% 76.5% 92.1% Stacked classifier model 79.2% 81.1% 80.1% 92.5% 76.7% 78.4% 77.5% 92.2% 76.2% 78.0% 77.1% 92.1% Table 3: Comparison with related work on the test set using automatically generated POS tion 1-210 (roughly 3/4 of the entire training set).
C02-1126 N04-1032 P03-1056 W00-1201
with Related Work Bikel and Chiang (2000) constructed two parsers using a lexicalized PCFG model that is based on Collins’ model 2 (Collins, 1999), and a statistical Tree-adjoining Grammar(TAG) model.
W00-1201
We used the TinySVM toolkit (Kudo and Matsumoto, 2000), with a degree 2 polynomial kernel.
W00-0730
Xiong et al.(2005) used a similar model to the BBN’s model in (Bikel and Chiang, 2000), and augmented the model by semantic categorical information and heuristic rules.
W00-1201
In our approach, which is based on the shift-reduce parser for English reported in (Sagae and Lavie, 2005), the parsing task is transformed into a succession of classification tasks.
W05-1513
Levy and Manning (2003) used a factored model that combines an unlexicalized PCFG model with a dependency model.
P03-1056
Sagae and Lavie (2005) have shown that this algorithm has linear time complexity, assuming that classification takes constant time.
W05-1513
Sun and Jurafsky (2003) studied the distributional property of rhythm in Chinese, and used the rhythmic feature to augment a PCFG model for a practical shallow parsing task.
W03-1706
An alternative way of doing simple voting is to let the parsers vote on membership of constituents after each parser has produced its own parse tree (Henderson and Brill, 1999), instead of voting at each step during parsing.
W99-0623
