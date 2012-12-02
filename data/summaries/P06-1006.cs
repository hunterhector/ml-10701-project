In Proceedings of the 40th Annual Meeting of the Association 7As in their pulic reports on Section 23 of WSJ TreeBank, Charniak (2000)’s parser achieves 89.6% recall and 89.5% precision with 0.88 crossing brackets (words ≤ 100), against Collins (1999)’s 88.1% recall and 88.3% precision with 1.06 crossing brackets.
A00-2018
Resolution Framework Our pronoun resolution system adopts the common learning-based framework similar to those by Soon et al.(2001) and Ng and Cardie (2002).
J01-4004 P02-1014
Indeed, using kernel methods to mine structural knowledge has shown success in some NLP applications like parsing (Collins and Duffy, 2002; Moschitti, 2004) and relation extraction (Zelenko et al., 2003; Zhao and Grishman, 2005).
P02-1034 P04-1043 P05-1052
We can see that Charniak (2000)’s parser leads to higher success rates for NPaper and BNews, while Collins (1999)’s achieves better results for NWire.
A00-2018
The performance is similar to other published results like those by Keller and Lapata (2003), who adopted a similar feature set and reported around 75% success rates on the ACE data set.
J03-3005
Lappin and Leass (1994) reported a pronoun resolution algorithm which uses the syntactic representation output by McCord’s Slot Grammar parser.
J94-4002
Different from Lappin and Leass (1994)’s algorithm, they employed a maximum entropy based model to automatically compute the importance (in terms of weights) of the features extracted from the trees.
J94-4002
The texts were parsed using the maximum-entropybased Charniak parser (Charniak, 2000), based on which the structured features were computed automatically.
A00-2018
Kernel and Composite Kernel To calculate the similarity between two structured features, we use the convolution tree kernel that is defined by Collins and Duffy (2002) and Moschitti (2004).
P02-1034 P04-1043
We also tested the flat syntactic feature set proposed in Luo and Zitouni (2005)’s work.
H05-1083
In line with the reports in (Luo and Zitouni, 2005) we do observe the performance improvement against the baseline (NORM) for all the domains.
H05-1083
with Different Parsers As mentioned, the above reported results were based on Charniak (2000)’s parser.
A00-2018
For learning, the SVM-Light software (Joachims, 1999) was employed with the convolution tree kernel implemented by Moschitti (2004).
P04-1043
These features are calculated by mining the parse trees, and then could be used for resolution by using manually designed rules (Lappin and Leass, 1994; Kennedy and Boguraev, 1996; Mitkov, 1998), or using machine-learning methods (Aone and Bennett, 1995; Yang et al., 2004; Luo and Zitouni, 2005).
C96-1021 H05-1083 J94-4002 P04-1017 P95-1017 P98-2143
Luo and Zitouni (2005) proposed a coreference resolution approach which also explores the information from the syntactic parse trees.
H05-1083
