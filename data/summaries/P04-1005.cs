First, we demonstrate that using a syntactic parser-based language model Charniak (2001) instead of bi/trigram language models signi cantly improves the accuracy of repair detection and correction.
N01-1016 P01-1017
We use two language models here: a bigram language model, which is used in the search process, and a syntactic parser-based language model Charniak (2001), which is used to rescore a set of the most likely analysis obtained using the bigram model.
N01-1016 P01-1017
As mentioned earlier, following Charniak and Johnson (2001) our test data consisted of all Penn III Switchboard tree-bank sw4[01]*.mrg les.
N01-1016 P01-1017
It would also be interesting to combine this probabilistic model of speech repairs with the word classi er approach of Charniak and Johnson (2001).
N01-1016 P01-1017
Heeman and Allen (1999) describe a noisy channel model of speech repairs, but leave \extending the model to incorporate higher level syntactic. ..processing" to future work.
J99-4003
CJ010 Bigram Trigram Parser Precision 0.951 0.776 0.774 0.820 Recall 0.631 0.736 0.763 0.778 F-score 0.759 0.756 0.768 0.797 The noisy channel model using a bigram language model does a slightly worse job at identifying reparandum and interregnum words than the classi er proposed in Charniak and Johnson (2001).
N01-1016 P01-1017
TAG channel model The TAG channel model de nes a stochastic mapping of source sentences X into observed sentences Y . There are several ways to dene transducers using TAGs such as Shieber and Schabes (1990), but the following simple method, inspired by nite-state transducers, su ces for the application here.
C90-3045
For comparison we include the results of running the word-by-word classi er described in Charniak and Johnson (2001), but where partial words and punctuation have been removed from the training and test data.
N01-1016 P01-1017
The previous work most closely related to the current work is Charniak and Johnson (2001), who used a boosted decision stub classier to classify words as edited or not on a word by word basis, but do not identify or assign a probability to a repair as a whole.
N01-1016 P01-1017
We followed Charniak and Johnson (2001) and split the corpus into main training data, heldout training data and test data as follows: main training consisted of all sw[23]*.dps les, heldout training consisted of all sw4[5-9]*.dps les and test consisted of all sw4[0-1]*.mrg les.
N01-1016 P01-1017
