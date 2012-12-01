In this paper we used a logical feature structure called GLARF proposed by Meyers et al.(2001a). A GLARF converter takes a syntactic tree as an input and augments it with several 306 Katrina hit coast SBJ OBJ Louisiana T-POS ’s SUFFIX Figure 3: GLARF structure of the sentence “Katrina hit Louisiana’s coast.” features.
W01-1511
Hasegawa et al.(2004) tried to extract multiple relations by choosing entity types.
P04-1053
There are many existing works on obtaining extraction patterns for pre-defined relations (Riloff, 1996; Yangarber et al., 2000; Agichtein and Gravano, 2000; Sudo et al., 2003).
A00-1039 P03-1029
For the details of GLARF representation and its conversion, see Meyers et al.(2001b). 3.3 NE Tagging and Coreference Resolution In parallel with parsing and GLARFing, we also apply NE tagging and coreference resolution for each article in a basic cluster.
W01-1511
and GLARFing After getting a set of basic clusters, we pass them to an existing statistical parser (Charniak, 2000) and rule-based tree normalizer to obtain a GLARF structure for each sentence in every article.
A00-2018
Several existing works have tried to extract a certain type of relation by manually choosing different pairs of entities (Brin, 1998; Ravichandran and Hovy, 2002).
P02-1006
