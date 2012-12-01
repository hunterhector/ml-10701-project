These weights are estimated by an online procedure as in McDonald (2006), and are not intended to define a probability distribution.
E06-1011
Goodman. 1996.
P96-1024
Standard methods for converting weighted CFGs to equivalent PCFGs can be used if required (Chi, 1999).
J99-1004
We provided one grammar which captures horizontal second-order dependencies (McDonald, 2006), and another which captures vertical second-order head-to-head-to-head dependencies.
E06-1011
CFG schemata sentences parsed / second Naive O(n5) CFG 45.4 O(n4) CFG 406.2 O(n3) CFG 3580.0 6 An O(n3) adjacent-head grammar This section shows how to further transform the O(n3) grammar described above into a form that encodes second-order dependencies between adjacent dependent heads in much the way that a Markov PCFG does (McDonald, 2006; McDonald and Pereira, 2006).
E06-1011
This paper investigates the relationship between Context-Free Grammar (CFG) parsing and the Eisner/Satta PBDG parsing algorithms, including their extension to second-order PBDG parsing (McDonald, 2006; McDonald and Pereira, 2006).
E06-1011
It is straight-forward to extend the split-head CFG to encode the additional state information required by the head automata of Eisner and Satta (1999); this corresponds to splitting the non-terminals Lu and uR.
P99-1059
The O(n3) split-head grammar is closely related to the O(n3) PBDG parsing algorithm given by Eisner and Satta (1999).
P99-1059
Goodman (1996) observed that the Viterbi parse is in general not the optimal parse for evaluation metrics such as f-score that are based on the number of correct constituents in a parse.
P96-1024
First, because they capture bilexical head-tohead dependencies they are capable of producing extremely high-quality parses: state-of-the-art discriminatively trained PBDG parsers rival the accuracy of the very best statistical parsers available today (McDonald, 2006).
E06-1011
For example, incremental CFG parsing algorithms can be used with the CFGs produced by this transform, as can the Inside-Outside estimation algorithm (Lari and Young, 1990) and more exotic methods such as estimating adjoined hidden states (Matsuzaki et al., 2005; Petrov et al., 2006).
P05-1010 P06-1055
The steps involved in CKY parsing with this grammar correspond closely to those of the McDonald (2006) second-order PBDG parsing algorithm.
E06-1011
Second, Eisner-Satta O(n3) PBDG parsing algorithms are extremely fast (Eisner, 1996; Eisner and Satta, 1999; Eisner, 2000).
C96-1058 P99-1059
