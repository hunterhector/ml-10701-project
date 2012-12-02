representation A tree structure representation incorporated with semantic and syntactic information is named semantically augmented parse tree (SAPT) (Ge and Mooney, 2005).
W05-0602
As defined in (Ge and Mooney, 2005), in an SAPT, each internal node in the parse tree is annotated with a semantic label.
W05-0602
The procedure of generating a logical form using a SAPT structure originally proposed by (Ge and Mooney, 2005) and it is expressed as Algorithm 1.
W05-0602
Ensemble for Semantic Parsing Although the bagging and boosting techniques have known to be effective for improving the performance of syntactic parsing (Henderson and Brill, 2000), in this section we focus on our ensemble learning of SSVM for semantic parsing and propose a new effective switching model for either bagging or boosting model.
A00-2005
622 Input: The root node N of a SAPT Predicate knowledge K Notation: XMR is the MR of node X Output: NMR Begin Ci= the ith child node of N Ch= GETsemanticHEAD(N) ChMR =BuildMR(Ch,K) for each other child Ci where inegationslash= h do CiMR =BuildMR(Ci,K) ComposeMR(ChMR,CiMR,K) end NMR=ChMR End Algorithm 1: BuildMR(N,K): Computing a logical form form an SAPT(Ge and Mooney, 2005) Input: S = (xi;yi;zi),i = 1,2,...,l in which xi is1 the sentence and yi, zi is the pair of tree structure and its logical form Output: SSVM model2 repeat3 for i = 1 to n do4 5 SVM∆s1 : H(y,z)≡(1−〈δψi(y),w〉)∆(zi,z) SVM∆s2 : H(y,z)≡(1−〈δψi(y),w〉) radicalbig ∆(zi,z) SVM∆m1 : H(y,z)≡(∆(zi,z)−〈δψi(y),w〉) SVM∆m2 : H(y,z)≡( radicalbig ∆(zi,z)−〈δψi(y),w〉) compute <y∗,z∗ >= argmaxy,z∈Y,Z H(Y,Z);6 compute ξi = max0,maxy,z∈Si H(y,z)};7 if H(y∗,z∗) >ξi +ε then8 Si←Si∪y∗,z∗;9 solving optimization with SVM;10 end11 end12 until no Si has changed during iteration;13 Algorithm 2: Algorithm of SSVM learning for semantic parsing.
W05-0602
For this problem, we can apply a boosting technique presented in (Kudo and Matsumoto, 2004).
W04-3239
precision = #correct−representation#completed−representation recall = #correct−representation#sentences Table 4 shows the results of SSVM, the SCSISSOR system (Ge and Mooney, 2005), and the SILT system (Kate et al., 2005) on the CLANG corpus, respectively.
W05-0602
Ge and Mooney also presented a statistical method (Ge and Mooney, 2005) by merging syntactic and semantic information.
W05-0602
