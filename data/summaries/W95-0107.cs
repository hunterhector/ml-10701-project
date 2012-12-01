Static Rule Elements In earlier work on transformational part-of-speech tagging (Ramshaw and Marcus, 1994), we noted that it is possible to greatly speed up the learning process by constructing a full, bidirectional index linking each candidate rule to those locations in the corpus at which it applies and each location in the corpus to those candidate rules that apply there.
H94-1020 W94-0111
However, the sample NPtool analysis given in the appendix of (Voutilainen, 1993), appears to be less accurate than claimed in general, with 5 apparent mistakes (and one unresolved ambiguity) out of the 32 NP chunks in that sample, as listed in Table 1.
W93-0306
The distributed version of Brill's tagger (Brill, 1993c) makes use of 26 templates, involving various mixes of word and part-of-speech tests on neighboring words.
H93-1047
On the grammar-based side, Bourigault (1992) describes a system for extracting "terminological noun phrases" from French text.
C92-3150
Marcus. 1994.
H94-1020
NPtool parse Apparent correct parse less \[time\] \[less time\] the other hand the \[other hand\] many \[advantages\] \[many advantages\] \[b!nary addressing\] \[binary addressing and and \[instruction formats\] instruction formats\] a purely \[binary computer\] a \[purely binary computer\] Table 1: Apparent errors made by Voutilainen's NPtool Kupiec (1993) also briefly mentions the use of finite state NP recognizers for both English and French to prepare the input for a program that identified the correspondences between NPs in bilingual corpora, but he does not directly discuss their performance.
P93-1003 W93-0306
One way to do this would be to have patterns match tree fragments and actions modify tree geometries, as in Brill's transformational parser (1993a).
H93-1047
The source texts were then run through Brill's part-of-speech tagger (Brill, 1993c), and, as a baseline heuristic, chunk structure tags were assigned to each word based on its part-of-speech tag.
H93-1047
In Brill's tagger (Brill, 1993c), an initial calculation in each pass computes the confusion matrix for the current tag assignments and sorts the entries of that \[old-tag x new-tag\] matrix, so that candidate rules can then be processed in decreasing order of the maximum possible benefit for any rule changing, say, old tag I to new tag J.
H93-1047
In this study, training and test sets marked with two different types of chunk structure were derived algorithmically from the parsed data in the Penn Treebank corpus of Wall Street Journal 82 text (Marcus et al., 1994).
H94-1020
Using statistical methods, Church's Parts program (1988), in addition to identifying parts of speech, also inserted brackets identifying core NPs.
A88-1019
In this paper, we target a somewhat higher level of chunk structure using Brill's (1993b) transformation-based learning mechanism, in which a sequence of transformational rules is learned from a corpus; this sequence iteratively improves upon a baseline model for some interpretive feature of the text.
H93-1047
At about the same time, Ejerhed (1988), working with Church, performed comparisons between finite state methods and Church's stochastic models for identifying both non-recursive clauses and non-recursive NPs in English text.
A88-1030
The part-of-speech tags used by this baseline heuristic, and then later also matched against by transformational rule patterns, were derived by running the raw texts in a prepass through Brill's transformational part-of-speech tagger (Brill, 1993c).
H93-1047
This technique has previously been used not only for part-of-speech tagging (Brill, 1994), but also for prepositional phrase attachment disambiguation (Brill and Resnik, 1994), and assigning unlabeled binary-branching tree structure to sentences (Brill, 1993a).
C94-2195 H93-1047
