Online learning algorithms have been shown to be robust even with approximate rather than exact inference in problems such as word alignment (Moore, 2005), sequence analysis (Daum´e and Marcu, 2005; McDonald et al., 2005a) and phrase-structure parsing (Collins and Roark, 2004).
P04-1015
The second-order model allows us to condition onthe mostrecent parsing decision, thatis, the last dependent picked up by a particular word, which is analogous to the the Markov conditioning of in the Charniak parser (Charniak, 2000).
A00-2018
Previous work has shown that conditioning on neighboring decisions can lead to significant improvements in accuracy (Yamada and Matsumoto, 2003; Charniak, 2000).
A00-2018
Collins. 2002.
W02-1001
Results For the Czech data, we used the predefined training, development and testing split of the Prague Dependency Treebank (Hajiˇc et al., 2001), and the automatically generated POS tags supplied with the data, which we reduce to the POS tag set from Collins et al.(1999). On average, 23% of the sentences in the training, development and test sets have at least one non-projective dependency, though, less than 2% of total edges are ac86 Danish Precision Recall F-measure 2nd-order-projective 86.4 81.7 83.9 2nd-order-non-projective 86.9 82.2 84.4 2nd-order-non-projective w/ multiple parents 86.2 84.9 85.6 Table 3: Dependency parsing results for Danish.
P99-1065
Charniak. 2000.
A00-2018
We use the common method of setting the final weight vector as the average of the weight vectors after each iteration (Collins, 2002), which has been shown to alleviate overfitting.
W02-1001
This algorithm can thus be viewed as a large-margin version of the perceptron algorithm for structured outputs Collins (2002).
W02-1001
