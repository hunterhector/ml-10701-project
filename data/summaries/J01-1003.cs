Johnson (1984) presents a scheme for inducing phonological rules from surface data, mainly in the context of studying certain aspects of language acquisition.
P84-1070
Analyzer Architecture We adopt the general approach advocated by Karttunen (1994) and build the morphological analyzer as the combination of several finite-state transducers, some of which are constructed directly from the elicited information, and others of which are constructed from the output of the machine learning stage.
C94-1066
The morphographemic rules describing changes in spelling as a result of affixation operations are induced from the examples provided by using transformation-based learning (Brill 1995; Satta and Henderson 1997).
J95-4004 P97-1057
67 Computational Linguistics Volume 27, Number 1 . . expression language of the XRCE finite-state tools \[Karttunen et al.1996\]). l° The example base of the paradigm generated in step 2 is then used by a learning algorithm to generate a sequence of morphographemic rules (Kaplan and Kay 1994) that handle the morphographemic phenomena.
J94-3001
Furthermore, since the language informant provides only a small number of examples, statistically motivated approaches like the one suggested by Theron and Cleoete (1997) are not applicable.
A97-1016
More recently, Theron and Cloete (1997) have presented a scheme for obtaining two-level morphology rules from a set of aligned segmented and surface pairs.
A97-1016
in the sense in which it is used in transformation-based learning (Brill 1995).
J95-4004
On the other hand, this approach as such is inapplicable to languages like Arabic, which have radically different word formation processes (for which a number of other finite-state approaches have been proposed; (see, for example, Beesley \[1996\] and Kiraz \[2000\]).
C96-1017 J00-1006
This list is then processed by a transformation-based learning paradigm (Brill 1995; Satta and Henderson 1997), as illustrated in Figure 4.
J95-4004 P97-1057
Currently the provisions we have for such constraints are limited to writing regular expressions (albeit at a much higher level than standard regular expressions); however, capturing such constraints using a more natural language (e.g., Ranta 1998) can be incorporated into future versions.
W98-1308
Our approach is as follows: we use the resulting morphological analyzer with an error-tolerant finite-state recognizer engine (Oflazer 1996).
J96-1003
These rules are then composed into one finite-state transducer (Kaplan and Kay 1994).
J94-3001
Since language informants are not expected or required to be well-versed in computational linguistics in general, or in recent approaches to building morphological analyzers (e.g., Koskenniemi 1983; Antworth 1990; Karttunen, Kaplan, and Zaenen 1992; Karttunen 1994) and the operation of state-of-the-art finite-state tools (e.g., Karttunen 1993; Karttunen and Beesley 1992; Karttunen et al.1996; Mohri, Pereira, and Riley 1998; van Noord 1999; van Noord and Gerdemann 1999) in particular, the generation of the morphological analyzer component has to be accomplished semiautomatically.
C92-1025 C94-1066 C96-1017 J94-3001
