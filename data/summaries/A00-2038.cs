Somers (1998) proposed a special algorithm for aligning children's articulation data with the adult model.
P98-2200
In a follow-up paper (Covington, 1998), he extended the algorithm to align words from more than two languages.
P98-1043
Gildea and Jurafsky (1996) set it at one fourth of the maximum substitution cost.
J96-4003
Nerbonne and Heeringa (1997) experimented with weighting each feature by information gain but found it had an adverse effect on the quality of the alignments.
W97-1102
Gildea and Jurafsky (1996) applied the DP algorithm to pre-align input and output phonetic strings in order to improve the performance of their transducer induction system.
J96-4003
The new algorithm performs better, in terms of accuracy and efficiency, than comparable algorithms reported by Covington (1996) and Somers (1999).
J96-4002 J99-2005
Covington (1996) used depth-first search and a special distance function to align words for historical comparison.
J96-4002
The function is often extended to cover pairs consisting of a segment and the null character, which correspond to the opera288 Algorithm Calculation Calculation Dynamic Phonological of alignment of distance programming features Covington (1996) Somers (1998) Nerbonne and Heeringa (1997) Gildea and Jurafsky (1996) explicit explicit implicit explicit Table 1: Comparison of lions of insertion and deletion (also called indels).
J96-4002 J96-4003 P98-1043 P98-2200 W97-1102
Somers (1999) tests one version of his algorithm, CAT, on the same set of cognates.
J99-2005
2Nerbonne and Heeringa (1997) fix the penalty for indels as half the average of the values of all substitutions.
W97-1102
Nerbonne and Heeringa (1997) employed a similar procedure to compute relative distance between words from various Dutch dialects.
W97-1102
Gildea and Jurafsky (1996) and Nerbonne and Heeringa (1997) use distance functions based on binary features.
J96-4003 W97-1102
Since neither Gildea and Jurafsky (1996) nor Nerbonne and Heeringa (1997) present their feature vectors in sufficient detail to perform the calculations, I adopted a fairly standard set of 17 binary features from Hartman (1981).
J96-4003 W97-1102
This system has been adapted by Connolly (1997) and implemented by Somers (1998).
P98-2200
Covington (1998) acknowledges that his distance function is "just a stand-in for a more sophisticated, perhaps feature-based, system".
P98-1043
Feature-Based Metrics Covington (1996), for his cognate alignment algorithm, constructed a special distance function.
J96-4002
5 (Covington, 1996) The efficiency of the algorithm might not be relevant in the simple case of comparing two words, but if the algorithm is to be of practical use, it will have to operate on large bilingual wordlists.
J96-4002
