Work in combining linguistic analysis with patterns include Weischedel et al.(2004) and Jijkoun et al.(2004) where manually constructed patterns are used to augment linguistic features.
C04-1188
We use Rouge, an automatic evaluation metric that was originally used for summarization evaluation (Lin and Hovy, 2003) and was recently found useful for evaluating definitional question answering (Xu et al., 2004).
N03-1020
Work Ravichandran and Hovy (2002) presents a method that learns patterns from online data using some seed questions and answer anchors.
P02-1006
Linguistic Analysis We use SERIF (Ramshaw et al., 2001), a linguistic analysis engine, to perform full parsing, name entity detection, relation detection, and co-reference resolution.
H01-1024
However, manual pattern construction critically depends on the domain knowledge of the pattern designer and often has low coverage (Jijkoun et al., 2004).
C04-1188
Coreference is determined using an information extraction engine, SERIF (Ramshaw et al., 2001).
H01-1024
Recently, researchers have started automatic question answering evaluation (Xu et al., 2004; Lin and Demner-Fushman, 2005; Soricut and Brill, 2004).
H05-1117 P04-1078
Hildebrandt et al.(2004) uses manual surface patterns for target extraction to augment database and dictionary lookup.
N04-1007
A detailed description of the algorithm is documented 308 Question Classification Document Retrieval Linguistic Analysis Semantic Processing Phrase Ranking Redundancy Remove Lists of Response Answer Annotation Name Tagging Parsing Preposition finding Co−reference Relation Extraction Training data TreeBank Name Annotation Linguistic motivated Pattern motivated Question Pattern MatchingPattern Learning Figure 1: Question answering system structure in (Ramshaw et al., 2001).
H01-1024
Deep linguistic analysis has been found useful in factoid question answering (Moldovan et al., 2002) and has been used for definitional questions (Xu et al., 2004; Harabagiu et al., 2003).
P02-1005
Automatic pattern derivation is more appealing (Ravichandran and Hovy, 2002).
P02-1006
To answer these questions, we perform extensive experiments on Chinese TDT4 data (Linguistic Data Consortium, 2002-2003).
N03-1020
