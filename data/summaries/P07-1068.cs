We then infer the SC of a common noun as follows: (1) we compute the probability that the common noun co-occurs with each of the eight NE types6 based on the extracted appositive relations, and (2) if the most likely NE type has a co-occurrence probability above a certain threshold (we set it to 0.7), we create a INDUCED CLASS fea1This is motivated by Lin’s (1998c) observation that a coreference resolver that employs only the rst WordNet sense performs slightly better than one that employs more than one sense.
M98-1006 P98-2127
These keywords are potentially useful features because some of them are subclasses of the ACE SCs shown in the left column of Table 1, while others appear to be correlated with these ACE SCs.2 (6) INDUCED CLASS: Since the rst-sense heuristic used in the previous feature may not be accurate in capturing the SC of an NP, we employ a corpusbased method for inducing SCs that is motivated by research in lexical semantics (e.g., Hearst (1992)).
C92-2082
We experiment with four learners commonly employed in language learning: Decision List (DL): We use the DL learner as described in Collins and Singer (1999), motivated by its success in the related tasks of word sense disambiguation (Yarowsky, 1995) and NE classi cation (Collins and Singer, 1999).
W99-0613
More importantly, the ACE participants do not evaluate the role of induced SC knowledge in coreference resolution: many of them evaluate coreference performance on perfect mentions (e.g., Luo et al.(2004)); and for those that do report performance on automatically extracted mentions, they do not explain whether or how the induced SC information is used in their coreference algorithms.
P04-1018
However, learning-based resolvers have not been able to bene t from having an SC agreement feature, presumably because the method used to compute the SC of an NP is too simplistic: while the SC of a proper name is computed fairly accurately using a named entity (NE) recognizer, many resolvers simply assign to a common noun the rst (i.e., most frequent) WordNet sense as its SC (e.g., Soon et al.(2001), Markert and Nissim (2005)).
J01-4004 J05-3004
Mitkov. 1998.
P98-2143
Each instance is represented by 33 lexical, grammatical, semantic, and 540 positional features that have been employed by highperforming resolvers such as Ng and Cardie (2002) and Yang et al.(2003), as described below.
P02-1014 P03-1023
In knowledge-lean approaches, coreference resolvers employ only morpho-syntactic cues as knowledge sources in the resolution process (e.g., Mitkov (1998), Tetreault (2001)).
J01-4003 P98-2143
While these approaches have been reasonably successful (see Mitkov (2002)), Kehler et al.(2004) speculate that deeper linguistic knowledge needs to be made available to resolvers in order to reach the next level of performance.
N04-1037
Following Soon et al.(2001), we select as the antecedent of each NP, NPj, the closest preceding NP that is classi ed as coreferent with NPj.
J01-4004
Following Ponzetto and Strube (2006), we consider an anaphoric reference, NPi, correctly resolved if NPi and its closest antecedent are in the same coreference chain in the resulting partition.
N06-1025
Many ACE participants have also adopted a corpus-based approach to SC determination that is investigated as part of the mention detection (MD) task (e.g., Florian et al.(2006)). Brie y, the goal of MD is to identify the boundary of a mention, its mention type (e.g., pronoun, name), and its semantic type (e.g., person, location).
P06-1060
We report performance in terms of two metrics: (1) the Fmeasure score as computed by the commonly-used MUC scorer (Vilain et al., 1995), and (2) the accuracy on the anaphoric references, computed as the fraction of anaphoric references correctly resolved.
M95-1005
Motivated by Soon et al.(2001), we have a semantic feature that tests whether one NP is a name alias or acronym of the other.
J01-4004
We use Lin’s (1998b) MINIPAR dependency parser to extract grammatical relations.
M98-1006 P98-2127
Following Soon et al.(2001), we represent SCA as a binary value that indicates whether the induced SCs of the two NPs involved are the same or not.
J01-4004
To get a better sense of how strong our baseline is, we re-implement the Soon et al.(2001) coreference resolver.
J01-4004
(7) NEIGHBOR: Research in lexical semantics suggests that the SC of an NP can be inferred from its distributionally similar NPs (see Lin (1998a)).
M98-1006 P98-2127
Following previous work (e.g., Soon et al.(2001) and Ponzetto and Strube (2006)), we generate training instances as follows: a positive instance is created for each anaphoric NP, NPj, and its closest antecedent, NPi; and a negative instance is created for NPj paired with each of the intervening NPs, NPi+1, NPi+2, . . ., NPj−1.
J01-4004 N06-1025
As a result, researchers have re-adopted the once-popular knowledge-rich approach, investigating a variety of semantic knowledge sources for common noun resolution, such as the semantic relations between two NPs (e.g., Ji et al.(2005)), their semantic similarity as computed using WordNet (e.g., Poesio et al.(2004)) or Wikipedia (Ponzetto and Strube, 2006), and the contextual role played by an NP (see Bean and Riloff (2004)).
H05-1003 N04-1038 N06-1025 P04-1019
