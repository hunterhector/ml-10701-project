Thus, the weight a138a138 a129a13a151a90a139a139a116a9a90a142a13a22 associated by a129a26a151 to a string a142 can be interpreted as a73a68a62a166a63a53a65 of the conditional probability a163 a9a76a142 a210 a205 a151a101a22 . Each class a205 a151 defines a weighted transduction: a129 a151 a73a66a125 a205 a151 This can be viewed as a specific obligatory weighted context-dependent rewrite rule where the left and right contexts are not restricted (Kaplan and Kay, 1994; Mohri and Sproat, 1996).
J94-3001 P96-1031
In many applications, it is natural and convenient to construct class-based language models, that is models based on classes of words (Brown et al., 1992).
J92-4003
Figure 1 shows the transducer a97 in the particular case of a100a42a3a181a43a23a28a66a12a32a67a23a47 . 1There exist a general weighted determinization and weight pushing algorithms that can be used to create a deterministic and pushed automaton equivalent to an input word or phone lattice (Mohri, 1997).
J97-2003
The utilities of the GRM Library can be used to compile such a batch set of rewrite rules efficiently (Mohri and Sproat, 1996).
P96-1031
Thus, these a2 classes can be viewed as a set of batch rewrite rules (Kaplan and Kay, 1994) which can be compiled into weighted transducers.
J94-3001
The corpus can be represented as a finite automaton a134 . To apply the rules defining the classes to the input corpus, we just need to compose the automaton a134 with a97 and project the result on the output: a88 a134a113a3a92a182a24a201a27a9a76a134a127a220a91a97a13a22 a88 a134 can be made stochastic using a pushing algorithm (Mohri, 1997).
J97-2003
We present a simple and more general approach to class-based language models based on general weighted context-dependent rules (Kaplan and Kay, 1994; Mohri and Sproat, 1996).
J94-3001 P96-1031
The proposition gives a simple algorithm for computing the expected counts of a134 in a weighted automaton a129 based on two general algorithms: composition (Mohri et al., 1996) and projection of weighted transducers.
P96-1031
