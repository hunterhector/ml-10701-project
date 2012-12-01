This part of the paper is essentially an extension and generalization of the line of work described in (Rayner, 1988; Rayner and Samuelsson, 1990; Samuelsson and Rayner, 1991; Rayner and Samuelsson, 1994; Samuelsson, 1994b).
C94-1062 H90-1051 H94-1040 P94-1026
(DeRose, 1988; Cutting et al., 1992; Church, 1988).
A88-1019 A92-1018 J88-1003
Samuelsson. 1994.
C94-1062 P94-1026
For example, (Briscoe and Carroll, 1993) train an LR parser based on a general grammar to be able to distinguish between likely and unlikely sequences of parsing actions; (Andry et al., 1994) automatically infer sortal constraints, that can be used to rule out otherwise grammatical constituents; and (Grishman et al., 1984) describes methods that reduce the size of a general grammar to include only rules actually useful for parsing the training corpus.
C94-1099 J93-1002 P84-1023
The result is a "specialized" grammar; this has a larger number of rules, but a simpler structure, allowing it in practice to be parsed very much more quickly using an LRbased method (Samuelsson, 1994a).
C94-1062 P94-1026
Thirdly, our method is a generalization of the strategy employed by (McCord, 1993).
H93-1025
In the second phase, the resulting set of "chunked" rules is converted into LR table form, using the method of (Samuelsson, 1994a).
C94-1062 P94-1026
The basic corpus used was a set of 16,000 utterances from the Air Travel Planning (ATIS; (Hemphill et al., 1990)) domain.
H90-1021
That is, an assumption of full statistical dependence (Yarowsky, 1994), rather than the more common full independence, is made3 When llf events El, E2,..., E,~ are fully independent, then the joint probability P(E1 A...
P94-1013
The 16,000 sentence corpus was analysed by the SRI Core Language Engine (Alshawi (ed), 1992), using a lexicon extended to cover the ATIS domain (Rayner, 1994).
H94-1040
The scheme is fully implemented within a version of the Spoken Language Translator system (Rayner et al., 1993; Agniis et al., 1994), and is normally applied to input in the form of small lattices of hypotheses produced by a speech recognizer.
H93-1042 H94-1040
Our current scheme is an extension of the one from (Rayner and Samuelsson, 1994), where the rulechunks are trees of non-phrasal rules whose roots and leaves are categories of the following possible types: full utterances, utterance units, imperative VPs, NPs, relative clauses, VP modifiers and PPs.
C94-1062 H94-1040 P94-1026
A more elaborate scheme is given in (Samuelsson, 1994b), where the "chunking criteria" are learned automatically by an entropy-minimization method; the results, however, do not appear to improve on the earlier ones.
C94-1062 P94-1026
The experiment was carried out using both the chunking criteria from (Rayner and Samuelsson, 1994) (the "Old" scheme), and the chunking criteria described in Section 3 above (the "New" scheme).
C94-1062 H94-1040 P94-1026
Care was taken to ensure not just that the utterances themselves, but also the speakers of the utterances were disjoint between test and training data; as pointed out in (Rayner et al., 1994a), failure to observe these precautions can result in substantial spurious improvements in test data results.
H94-1040
In (Rayner and Samuelsson, 1994), a simple scheme is given, which creates rules corresponding to four possible units: full utterances, recursive NPs, PPs, and non-recursive NPs.
C94-1062 H94-1040 P94-1026
