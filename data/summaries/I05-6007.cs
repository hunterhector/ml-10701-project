Still, the results and discussion from (Soricut and Marcu, 2003) provide some useful perspective on our results.
N03-1030
+ a0 Prec Rec Basic 1497 215 0.874 Backwards 700 4 0.994 According-to 87 1 0.989 Total 2284 220 0.912 0.938 Figure 4: Breakdown of system results (Training corpus) + a0 Prec Rec Basic 193 33 0.854 Backwards 90 0 1.000 According-to 4 0 1.000 Total 286 33 0.897 0.994 Figure 5: Breakdown of system results (Test corpus) 60 5 Related Work Soricut and Marcu (2003) describe a Discourse Parser – a system that uses Penn Treebank syntax to identify intra-sentential discourse relations in the RST Treebank.
N03-1030
Syntactic criteria are relevant, but clearly not decisive, as can be observed in (Marcu and Echihabi, 2002).
P02-1047
Soricut and Marcu (2003) note that human annotator agreement receives comparable f-scores, of .719 and .77 respectively.
N03-1030
We examine the Attribution relation, which is of particular interest for the following reasons: a2 It appears quite frequently in the RST Treebank (15% of all relations, according to Marcu et al.(1999)) a2 It always appears within, rather than across, sentence boundaries a2 It conflicts with Penn Treebank syntax, always relating text spans that do not correspond to nodes in the syntax tree We describe a system that identifies Attributions by simple, clearly defined syntactic features.
W99-0307
The system performs dramatically better than the results reported in (Soricut and Marcu, 2003) for automatic identification of such relations, where the precision and recall were reported at below .76.
N03-1030
(Soricut and Marcu, 2003) In what follows, we first describe Attributions as they are understood in the RST Treebank project.
N03-1030
Since the texts in the RST Treebank are taken from the syntactically annotated Penn Treebank (Marcus et al., 1993), it is natural to ask what the relation is between the discourse structures in the RST Treebank and the syntactic structures of the Penn Treebank.
J93-2004
Soricut and Marcu (2003) evaluate their Discourse Parser under a variety of scenarios; the most favorable has human-corrected syntax trees and discourse segmentation.
N03-1030
