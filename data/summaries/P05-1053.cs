Evaluation on the ACE corpus shows that our system outperforms Kambhatla (2004) by about 3 F-measure on extracting 24 ACE relation subtypes.
P04-3022
Complicated relation extraction tasks may also impose a big challenge to the modeling approach used by Miller et al (2000) which integrates various tasks such as part-of-speech tagging, named entity recognition, template element extraction and relation extraction, in a single model.
A00-2030
Compared with Kambhatla (2004), we separately incorporate the base phrase chunking information, which contributes to most of the performance improvement from syntactic aspect.
P04-3022
# of other mentions in between # of relations 0 1 2 3 >=4 Overall 0 3991 161 11 0 0 4163 1 2350 315 26 2 0 2693 2 465 95 7 2 0 569 3 311 234 14 0 0 559 4 204 225 29 2 3 463 5 111 113 38 2 1 265 >=6 262 297 277 148 134 1118 # of the words in between Overall 7694 1440 402 156 138 9830 Table 3: Distribution of relations over #words and #other mentions in between in the training data Type Subtype #Testing Instances #Correct #Error P R F AT 392 224 105 68.1 57.1 62.1 Based-In 85 39 10 79.6 45.9 58.2 Located 241 132 120 52.4 54.8 53.5 Residence 66 19 9 67.9 28.8 40.4 NEAR 35 8 1 88.9 22.9 36.4 Relative-Location 35 8 1 88.9 22.9 36.4 PART 164 106 39 73.1 64.6 68.6 Part-Of 136 76 32 70.4 55.9 62.3 Subsidiary 27 14 23 37.8 51.9 43.8 ROLE 699 443 82 84.4 63.4 72.4 Citizen-Of 36 25 8 75.8 69.4 72.6 General-Staff 201 108 46 71.1 53.7 62.3 Management 165 106 72 59.6 64.2 61.8 Member 224 104 36 74.3 46.4 57.1 SOCIAL 95 60 21 74.1 63.2 68.5 Other-Professional 29 16 32 33.3 55.2 41.6 Parent 25 17 0 100 68.0 81.0 Table 4: Performance of different relation types and major subtypes in the test data Relation Detection RDC on Types RDC on Subtypes System P R F P R F P R F Ours: feature-based 84.8 66.7 74.7 77.2 60.7 68.0 63.1 49.5 55.5 Kambhatla (2004):feature-based 63.5 45.2 52.8 Culotta et al (2004):tree kernel 81.2 51.8 63.2 67.1 35.0 45.8 Table 5: Comparison of our system with other best-reported systems on the ACE corpus Error Type #Errors False Negative 462 Detection Error False Positive 165 Cross Type Error 154 Characterization Error Inside Type Error 83 Table 6: Distribution of errors 6 Discussion and Conclusion In this paper, we have presented a feature-based approach for relation extraction where diverse lexical, syntactic and semantic knowledge are employed.
P04-1054 P04-3022
Culotta et al (2004) extended this work to estimate kernel functions between augmented dependency trees and achieved 63.2 F-measure in relation detection and 45.8 F-measure in relation detection and classification on the 5 ACE relation types.
P04-1054
Miller et al (2000) augmented syntactic full parse trees with semantic information corresponding to entities and relations, and built generative models for the augmented trees.
A00-2030
Tree kernel-based approaches proposed by Zelenko et al (2003) and Culotta et al (2004) are able to explore the implicit feature space without much feature engineering.
P04-1054
It also shows that our system outperforms tree kernel-based systems (Culotta et al 2004) by over 20 F-measure on extracting 5 ACE relation types.
P04-1054
Kambhatla (2004) employed Maximum Entropy models for relation extraction with features derived from word, entity type, mention level, overlap, dependency tree and parse tree.
P04-3022
The tree kernels developed in Culotta et al (2004) are yet to be effective on the ACE RDC task.
P04-1054
