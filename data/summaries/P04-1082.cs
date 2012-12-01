Higgins’ method, like Johnson’s (2002) and the present one, involves post-processing of trees.
P02-1018
Charniak, 2000) have focused on labeled bracketing of the input string, ignoring aspects of structure that are not reflected in the string, such as phonetically null elements and long-distance dependencies, many of which provide important semantic information such as predicate-argument structure.
A00-2018
As mentioned in Section 4, it is believed that the results of the current method on parser output would improve if that output were reliably assigned function tags, perhaps along the lines of Blaheta and Charniak (2000).
A00-2018 A00-2031
Following Johnson (2002), the system was evaluated on two different kinds of input: first, on perfect input, i.e., PTB annotations stripped of all empty categories and information related to them; and second, on imperfect input, in this case the output of Charniak’s (2000) parser.
A00-2018 P02-1018
Johnson (2002) reports 93% precision and 83% recall (F 1 = 88%) for the detection task alone, and 80% precision and 70% recall (F 1 = 75%) for detection plus resolution.
P02-1018
In the Penn Treebank (Marcus et al., 1993), null elements, or empty categories, are used to indicate non-local dependencies, discontinuous constituents, and certain missing elements.
J93-2004
Dienes and Dubey (2003a), on the other hand, claim this as one of the strengths of their learning-based system.
P03-1055 W03-1005
Charniak’s parser (Charniak, 2000), however, does not include function tags, so in order for the algorithm to work properly on parser output (see Section 5), additional functions were written to approximate the required tags.
A00-2018
Johnson (2002) proposes a pattern-matching algorithm, in which the minimal connected tree fragments containing an empty node and its antecedent(s) are extracted from the training corpus, and matched at runtime to an input tree.
P02-1018
Previous approaches to the problem (Collins, 1997; Johnson, 2002; Dienes and Dubey, 2003a,b; Higgins, 2003) have all been learning-based; the primary difference between the present algorithm and earlier ones is that it is not learned, but explicitly incorporates principles of GovernmentBinding theory (Chomsky, 1981), since that theory underlies the annotation.
E03-1049 P02-1018 P03-1055 P97-1003 W03-1005
In contrast to Johnson (2002) and the present work, Dienes and Dubey (2003a) take a POS-tagged string, rather than a tree, as input; they report 86.5% precision and 72.9% recall (F 1 = 79.1%) on the detection task.
P02-1018 P03-1055 W03-1005
Presumably, the accuracy of the algorithm on parser output would be enhanced by accurate prior assignment of the tags to all relevant nodes, as in Blaheta and Charniak (2000) (see also Section 5).
A00-2018 A00-2031
The label and string position method is useful if one sees the task as inserting empty nodes into a string, and thus is quite useful for evaluating systems that detect empty categories without parse trees, as in Dienes and Dubey (2003a).
P03-1055 W03-1005
output The system was also run using as input the output of Charniak’s parser (Charniak, 2000).
A00-2018
Using linguistic principles to recover empty categories Richard CAMPBELL Microsoft Research One Microsoft Way Redmond, WA 98052 USA richcamp@microsoft.com Abstract This paper describes an algorithm for detecting empty nodes in the Penn Treebank (Marcus et al., 1993), finding their antecedents, and assigning them function tags, without access to lexical information such as valency.
J93-2004
Using Johnson’s (2002) evaluation metric, Dienes and Dubey present results on the detection task alone (i.e., inserting empty categories into the POS-tagged string), as well as on the combined detection and resolution tasks in combination with their parser.
P02-1018
Dienes and Dubey (2003b) integrate the results of their detection task into their own PCFG parser, and report 81.5% precision and 68.7% recall (F 1 = 74.6%) on the combined task of detection and resolution.
P03-1055 W03-1005
Charniak. 2000.
A00-2018
categories however seem different, in that, for the most part, their location and existence is determined, not by observable data, but by explicitly constructed linguistic principles, which 1 Both Collins (1997: 19) and Higgins (2003: 100) are explicit about this predisposition.
E03-1049 P97-1003
Using the string-based evaluation metric proposed by Johnson (2002), the current system outperforms previously published algorithms on detection alone, as well as on detection combined with resolution, both on perfect input and in combination with parsing.
P02-1018
Collins’ (1997) Model 3 integrates the detection and resolution of WH-traces in relative clauses into a lexicalized PCFG.
P97-1003
Using the evaluation metric proposed by Johnson (2002), this approach outperforms previously published approaches on both detection of empty categories and antecedent identification, given either annotated input stripped of empty categories or the output of a parser.
P02-1018
Dienes and Dubey (2003a,b), on the other hand, integrate their empty node resolution algorithm into their own PCFG parser.
P03-1055 W03-1005
Following Johnson (2002) and Dienes and Dubey (2003a), the compound empty SBAR consisting of an empty complementizer followed by *T* of category S is treated as a single item for purposes of evaluation.
P02-1018 P03-1055 W03-1005
Charniak, 2000) typically provide a labeled bracketing only; i.e., a parse tree without empty categories.
A00-2018
Johnson (2002) reports 85% precision and 74% recall (F 1 = 79%) for detection and 73% precision and 63% recall (F 1 = 68%) for detection plus resolution on the output of Charniak’s parser.
P02-1018
