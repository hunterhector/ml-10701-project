The computation involves an O(|D|n) dynamic programming algorithm, the output of which is passed to Huang and Chiang’s (2005) algorithm to generate the L-best list.
W05-1506
McDonald et al., 2005).
H05-1066
Alshawi. 1996.
P96-1023
Smith and Eisner, 2006).
P06-2101 P06-2101
dence between the left yield and the right yield of a given head, given the head (Eisner, 1997).3 The best known parsing algorithm for such a model is O(n3) (Eisner and Satta, 1999).
P99-1059
3). 3 Unlabeled Parsing The first component of our system is an unlabeled parser that, given a sentence, finds the U best unlabeled trees under a probabilistic model using a bottom-up dynamic programming algorithm.2 The model is a probabilistic head automaton grammar (Alshawi, 1996) that assumes conditional indepen1We used words and fine tags in our parser and labeler, with coarse tags in one backoff model.
P96-1023
The U-best list is generated using Algorithm 3 of Huang and Chiang (2005).
W05-1506
2The execution model we use is best-first, exhaustive search, as described in Eisner et al.(2004). All of our dynamic programming algorithms are implemented concisely in the Dyna language.
P04-3032
Standard state-of-the-art parsing systems (e.g., Charniak and Johnson, 2005) typically involve two passes.
P05-1022
