The only technique for mapping between more disparate languages that has been rigorously evaluated (Wu 1994) relies on length correlations sprinkled with some lexical information.
P94-1012
Hard constraints are necessary for alignment algorithms that use dynamic programming, in order to maintain an acceptable running time on longer bitexts(Gale & Church 1991, Simard et al.1992). SIMR produced bitext maps for 200 megabytes of the Canadian Hansards.
P91-1023
\[Church 1993\] K.
P93-1001
As the search rectangle grows, it will eventually pick up the TBM's trail, even if 2 the discontinuity is quite large (Melamed 1996).
C96-2129
Such robustness has enabled at least one new commercial-quality application -automatic detection of omissions in translations (Melamed 1996).
C96-2129
\[Melamed 1996\] I.
C96-2129
Some multilingual NLP tasks, such as automatic validation of terminological consistency (Macklovitch 1995) and automatic detection of omissions in translations (implemented for the first time in (Melamed 1996)), have been technologically impossible until now, because they are highly sensitive to large errors in the bitext map.
C96-2129
\[Gale & Church 1991\] W.
P91-1023
Like char_.align (Church 1993), SIMR infers bitext maps from likely points of correspondence between the two texts, points that are plotted in a two-dimensional space of possibilities.
P93-1001
The LCSR of a token pair is the number of characters that appear in the same order in both tokens divided by the length of the longer token (Melamed 1995).
W95-0115
errors, given errors, not given bitext algorithm hard constraints hard constraints "easy" Hansard (n = 7123) "hard" Hansard (n = 2693) Gale & Church (1991) Simard et al.(1992) SIMR/GSA SIMR/GSA with MRBD Gale & Church (1991) Simard et al.(1992) SIMR/GSA SIMR/GSA with MRBD not applicable 114 (1.6%) 104 (1.5%) 80 (1.1%) not applicable 50 (1.9%) 50 (1.9%) 45 (:.7%) 128 (1.8%) 171 (2.4%) :15 (:.6%) 90 (1.3%) 80 (3.0%) 102 (3.8%) 61 (2.3%) 48 (1.8%) least some of these sentences are mutual translations, despite SIMR's failure to find any points of correspondence between them.
P91-1023
In other cases, they can be induced automatically using any of several existing methods (Dagan et al.1993, Fung ~ Church 1991, Melamed 1995).
W93-0301 W95-0115
\[Brown et al.1991\] P.
P91-1022
Table 1 compares SIMR's error distribution on these bitexts with that of the previous front-runner, char._al:i.gn, as reported by Church 7 (1993).
P93-1001
\[Wu 1994\] D.
P94-1012
One interesting observation is that aligned sentences can be used to induce translation lexicons, and translation lexicons are an important information source for bitext mapping and alignment (Kay & RSscheisen 1993, Chen 1993).
J93-1006 P93-1002
\[Dagan et al.1993\] I.
W93-0301
\[Chen 1993\] S.
P93-1002
\[Melamed 1995\] I.
W95-0115
Like Gale & Church (1991) and Brown et al.(1991), SIMR relies on the high correlation between the lengths of mutual translations.
P91-1022 P91-1023
For example, in the non-technical Canadian Hansards (parliamentary debate transcripts available in English and French), cognates can be found for roughly one quarter of all text tokens (Melamed 1995).
W95-0115
Michel Simard of CITI graciously provided me with several such reference sets for French-English bitexts, including the same "easy" and "hard" Hansard bitexts that have been used to evaluate other bitext mapping and alignment algorithms in the literature (Church 1993, Simard et al.1992, Dagan et al.1993). A non-Hansard reference set was used for SIMR's development.
P93-1001 W93-0301
Oui. Source: (Chen 1993) The only way to ensure a correct alignment in such regions is to look at the words.
P93-1002
However, most of these methods address only the sub-problem of alignment (Catizone et al.1989, Brown et al.1991, Gale & Church 1991, Debili & Sammouda 1992, Simard et al.1992, Kay & RSscheisen 1993, Wu 1994).
J93-1006 P91-1022 P91-1023 P93-1001 P94-1012
The only published solution to the more difficult general bitext mapping problem (Church 1993) can err by several typeset pages.
P93-1001
Other bitext mapping algorithms mitigate this source of noise either by assigning lower weights to correspondence points associated with frequent token types (Church 1993) or by simply deleting frequent token types from the bitext (Dagan et al.1993). However, a frequent token type can be rare in some parts of the text.
P93-1001 W93-0301
For this reason, Chen (1993) adds a statistical translation model to the Brown et al.alignment algorithm, and Wu (1994) adds a translation lexicon to the Gale & Church alignment algorithm.
P93-1002 P94-1012
Such discontinuities can be automatically detected with high reliability (Melamed 1996).
C96-2129
\[Kay & RSscheisen 1993\] M.
J93-1006
Church (1993) did not specify which metric he used.
P93-1001
To combat such errors, GSA re-aligns any aligned block that is not lxl, using the Gale & Church lengthbased alignment algorithm (Gale & Church 1991, Simard 1995).
P91-1023
The algorithms that seem to work best rely on the high correlation between the lengths of corresponding sentences (Brown et al.1991, Gale & Church 1991).
P91-1022 P91-1023
I plan to explore an interactive loop between SIMR, GSA and my algorithm for inducing translation lexicons (Melamed 1995).
W95-0115
