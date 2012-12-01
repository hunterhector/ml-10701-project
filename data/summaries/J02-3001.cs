The FrameNet project (Baker, Fillmore, and Lowe 1998) proposes roles that are neither as general as the 10 abstract thematic roles, nor as specific as the thousands of potential verb-specific roles.
P98-1013
For example, in communication frames, the Speaker is likely to appear as a noun phrase, Topic as a prepositional phrase or noun phrase, and Medium as a prepositional phrase, as in: “[ Speaker We ] talked [ Topic about the proposal ] [ Medium over the phone ] .” The phrase type feature we used indicates the syntactic category of the phrase expressing the semantic roles, using the set of syntactic categories of the Penn Treebank project, as described in Marcus, Santorini, and Marcinkiewicz (1993).
J93-2004
Semantic roles could also act as an important intermediate representation in statistical machine translation or automatic text summarization and in the emerging field of text data mining (TDM) (Hearst 1999).
P99-1001
Collins (1997) reports 88% labeled precision and recall on individual parse constituents on data from the Penn Treebank, roughly consistent with our finding of at least 13% error.
P97-1003
For example, in the context of the Air Traveler Information System (ATIS) for spoken dialogue, Miller et al.(1996) computed the probability that a constituent such as Atlanta filled a semantic slot such as Destination in a semantic frame for air travel.
P96-1008
(For other natural language processing [NLP] applications of the probabilistic clustering algorithm, see, e.g., Rooth [1995], Rooth et al.[1999]; for application to language modeling, see Gildea and Hofmann [1999].
P99-1014
Systems for booking airplane information use domain-specific frames with slots like origcity, destcity,ordepart time (Stallard 2000).
A00-1010
(Tables 22 and 23 in the Appendix provides a listing of Penn Treebank’s part-of-speech tags and constituent labels.) We used Collins’ (1997) statistical parser trained on examples from the Penn Treebank to generate parses of the same format for the sentences in our data.
P97-1003
In a data-driven approach to information extraction, Riloff (1993) builds a dictionary of patterns for filling slots in a specific domain such as terrorist attacks, and Riloff and Schmelzenbach (1998) extend this technique to derive automatically entire “case frames” for words in the domain.
W98-1106
More recently, a domain-independent system has been trained by Blaheta and Charniak (2000) on the function tags, such as Manner and Temporal, included in the Penn Treebank corpus.
A00-2031
Although most statistical parsing work measures performance in terms of syntactic trees without semantic information, an assignment of role fillers has been incorporated into a statistical parsing model by Miller et al.(2000) for the domain-specific templates of the Message Understanding Conference (Defense Advanced Research Projects Agency 1998) task.
A00-2030
Recent lexicalized stochastic parsers such as Collins (1999), Charniak (1997), and others add additional features to each constituent, the most important being the head word of the parse constituent.
P97-1003
After some experimentation, we settled on a version of the path feature that collapses the various part-of-speech tags for verbs, including past-tense verb (VBD), third-person singular present-tense verb (VBZ), other present-tense verb (VBP), and past participle (VBN), into a single verb tag denoted “VB.” Our path feature is dependent on the syntactic representation used, which in our case is the Treebank-2 annotation style (Marcus et al.1994), as our parser is trained on this later version of the Treebank data.
H94-1020
To do this, counts of training data were percolated up the semantic hierarchy in a technique similar to that of, for example, McCarthy (2000).
A00-2034
For example, Lapata and Brew (1999) and others have shown that the different syntactic subcategorization frames of a verb such as serve can be used to help disambiguate a particular instance of the word.
W99-0632
Our statistical algorithms are trained on a hand-labeled data set: the FrameNet database (Baker, Fillmore, and Lowe 1998; Johnson et al.2001). The FrameNet database defines a tag set of semantic roles called frame elements and included, at the time of our experiments, roughly 50,000 sentences from the British National Corpus hand-labeled with these frame elements.
P98-1013
We used the direct object (following other clustering work such as Pereira, Tishby, and Lee [1993]) because it is particularly likely to exhibit semantically significant selectional restrictions.
P93-1024
