However, there is a rule–based post–processing approach consisting of a set of entirely hand– designed rules (Campbell, 2004) which has better 9As above, we consider only that work which both inputs and outputs phrase–structure trees.
P04-1082
Categories: Discussion We have shown that a PSLB post–processing approach can outperform the state–of–the–art integrated approach of Dienes and Dubey.15 Given that their modifications to Collins’s parser caused a decrease in local phrase structure parsing accuracy due to sparse data difficulties (Dienes and Dubey, 2003a), our post–processing approach seems to be an especially attractive choice.
P03-1055 W03-1005
We have kept the Precision and Recall and recalculated the F-measures, adjustingtheSemanticscoreupwardsfrom79.15%to79.81%and the Overall score downward from 88.63% to 88.28%. 7And the (Charniak, 2000) parser that (Blaheta, 2003) used has a reported F-measure of 89.5, higher than the Bikel parser used here.
A00-2018
The accuracy of the first-stage parser on the standard Parseval metric matches that of the (Collins, 2003) parser on which it is based, despite the data fragmentation caused by the greatly enriched space of possible node labels.
J03-4003
Note that our system’s parsed scores were obtained using our modified version of Bikel’s implementation of Collins’s thesis parser which assigns function tags, while the other PSLB post–processing systems use Charniak’s parser (Charniak, 2000) and Dienes and Dubey integrate empty category recovery directly into a variant of Collins’s parser.
A00-2018
The linguistic sophistication of the work of (Musillo and Merlo, 2005) then provides an added boost in performance over simple integration.
W05-1509
Modern statistical parsers such as (Collins, 2003) and (Charniak, 2000) however ignore much of this information and return only an We would like to thank Fernando Pereira, Dan Bikel, Tony Kroch and Mark Liberman for helpful suggestions.
A00-2018 J03-4003
Categories: Approach Most learning–based, phrase–structure–based (PSLB) work9 on recovering empty categories has fallen into two classes: those which integrate empty category recovery into the parser (Dienes and Dubey, 2003a; Dienes and Dubey, 2003b) and those which recover empty categories from parser output in a post–processing step (Johnson, 2002; Levy and Manning, 2004).
P02-1018 P03-1055 P04-1042 W03-1005
23] are internally 186 — Overall — — Breakdown by Function Tag Group — w/CLR w/o CLR Syn Sem Top Misc CLR Tag Group Frequency 55.87% 36.40% 2.60% 1.03% 5.76% Model2-Ftags 88.95 90.78 95.76 84.56 93.89 17.31 65.86 88.28 95.16 79.81 93.72 39.44 Blaheta, 2003 (95.89) (83.37) Jijkoun and de Rijke, 2004 88.50 Musillo and Merlo, 2005 96.5 85.6 Table 1: Overall Results (F-measure) and Breakdown by Function Tag Groups Even though our tagging system results from only eliminating a few lines of code from the Collins parse, it has a higher overall score than (Blaheta, 2003), and a large increase over Blaheta’s nonspecialized Semantic score (79.81).
J03-4003 P04-1040 W05-1509
The second stage achieves stateof-the-artperformanceontherecoveryofemptycategories by combining the linguistically-informed architecture of (Campbell, 2004) and a rich feature set with the power of modern machine learning methods.
P04-1082
It does seem clear, though, that by integrating the function tags into the lexicalized parser, the results are roughly comparable with the post-processing work, and it is much simpler, without the need for a separate post-processing level or for specialized feature trees for the different tag groups.8 Our results clarify, we believe, the recent results of (Musillo and Merlo, 2005), now state-of-the-art, which extends the parser of report a significant modification of the Henderson parser to incorporate strong notions of linguistic locality.
W05-1509
For purposes of comparison, we have calculated our overall score both with and without CLR.5 The (Blaheta, 2003) numbers in parentheses in Table 1 are from hisfeaturetreesspecializedfortheSyntacticandSemantic groups, while all his other numbers, including the overall score, are from using a single feature set for his four function tag groups.6 5(Jijkoun and de Rijke, 2004) do not state whether they are including CLR, but since they are comparing their results to (Blaheta and Charniak, 2000), we are assuming that they do.
A00-2018 A00-2031 P04-1040
The accuracy of the first-stage parser on the standard Parseval metric matches that of the (Collins, 2003) parser on which it is based, despite the data fragmentation caused by the greatly enriched space of possible node labels for the Collins statistical model.
J03-4003
This notably excludes Jijkoun and de Rijke (Jijkoun and de Rijke, 2004), who have a system which seems to match the performance of Dienes and Dubey.
P04-1040
Finally, it is not clear that their numbers are in fact comparable to those of Dienes and Dubey on parsed data because the metrics used are not quite equivalent, particularly for (NP *)s: among other differences, unlike Jijkoun and de Rijke’s metric (taken from (Johnson, 2002)), Dienes and Dubey’s is sensitive to the string extent of the antecedent node, penalizing them if the parser makes attachment errors involving the antecedent even if the system recovered the long–distance dependency itself correctly.
P02-1018
This therefore extends (Collins, 2003)’s use of function tags for excluding potential argument to also use them for including arguments.4 The parser is then trained as before.
J03-4003
The importance of returning this information for most real applications of parsing has been greatly obscured by the Parseval metric (Black et al., 1991), which explicitly ignores both function tags and null elements.
H91-1060
(Johnson, 2002; Dienes and Dubey, 2003a; Dienes and Dubey, 2003b), only one system currently available, the dependency graph parser of (Jijkoun and de Rijke, 2004), recovers some representation of both these aspects of the Treebank representation; its output, however, cannot be inverted to recover the original tree structures.
P02-1018 P03-1055 P04-1040 W03-1005
An early exception to this was (Collins, 1997) itself, where Model 2 used function tags during the training process for heuristics to identify arguments (e.g., the TMP tag on the NP in Figure 1 disqualifies the NP-TMP from being treated as an argument).
P97-1003
