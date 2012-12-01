We also observe that the automatically acquired patterns in Riloff (1996), Yangarber (2003), Sudo et al.(2003), Greenwood and Stevenson (2006) cannot be directly used as relation extraction rules because the relation-specific argument role information is missing.
P03-1029 P03-1044 W06-0202 W06-0204
Stevenson. 2006.
W06-0202
In Riloff (1996) and Sudo et al.(2003), the relevance of a pattern is mainly dependent on its occurrences in the relevant documents vs.
P03-1029
Therefore, our method is much more efficient than the subtree model of Sudo et al., (2003), where all subtrees containing verbs are taken into account.
P03-1029
Stevenson and Greenwood (2006) present a systematic investigation of the pattern representation models and point out that substructures of the linguistic representation and the access to the embedded structures are important for obtaining a good coverage of the pattern acquisition.
W06-0202 W06-0204
Current semior unsupervised approaches to automatic pattern acquisition are either limited to a certain linguistic representation (e.g., subject-verb-object), or only deal with binary relations, or cannot assign slot filler roles to the extracted arguments, or do not have good selection and filtering methods to handle the large number of tree patterns (Riloff, 1996; Agichtein and Gravano, 2000; Yangarber, 2003; Sudo et al., 2003; Greenwood and Stevenson, 2006; Stevenson and Greenwood, 2006).
P03-1029 P03-1044 W06-0202 W06-0204
The rule representation models for automatic or unsupervised pattern rule extraction discussed by 586 Stevenson and Greenwood (2006) do not account for these considerations.
W06-0202 W06-0204
Validation: Ranking and Filtering Our ranking strategy has incorporated the ideas proposed by Riloff (1996), Agichtein and Gravano (2000), Yangarber (2003) and Sudo et al.(2003). We take two properties of a pattern into account: • domain relevance: its distribution in the relevant documents and irrelevant documents (documents in other domains); • trustworthiness of its origin: the relevance score of the seeds from which it is extracted.
P03-1029 P03-1044
Architecture This architecture has been inspired by several existing seed-oriented minimally supervised machine learning systems, in particular by Snowball (Agichtein and Gravano, 2000) and ExDisco (Yangarber et al., 2000).
C00-2136
Evaluation of 20 and 55 seeds tests Our result with 20 seeds (precision of 48.4% and recall of 34.2%) is comparable with the best result reported by Greenwood and Stevenson (2006) with the linked chain model (precision of 0.434 and recall of 0.265).
W06-0202 W06-0204
Greenwood. 2006.
W06-0204
In the calculation of the trustworthiness of the origin, we follow Agichtein and Gravano (2000) and Yangarber (2003).
P03-1044
