7. Discussion That interesting bilingual lexical correlations can be extracted automatically from a large bilingual corpus was pointed out by Brown et al.(1988). The algorithm that they describe is, roughly speaking, equivalent to carrying out the first iteration of the EM algorithm for our Model 1 starting from an initial guess in which each French word is equally probable as a translation for each English word.
C88-1016
In Section 5, we present results obtained by estimating the parameters for these models from a large collection of aligned pairs of sentences from the Canadian Hansard data (Brown, Lai, and Mercer 1991).
H91-1025 P91-1022 P91-1034
We have already used this algorithm successfully as a part of a system to assign senses to English and French words on the basis of the context in which they appear (Brown et al.1991a, 1991b).
H91-1025 P91-1022 P91-1034
Brown et al.(1990) assert, and Brown, Lai, and Mercer (1991) and Gale and Church (1991b) both show, that it is possible to obtain such aligned pairs of sentences without inspecting the words that the sentences contain.
H91-1025 H91-1026 J90-2002 P91-1022 P91-1023 P91-1034
But many of the correlations speak in a softer voice: to hear them clearly, we must model the translation process, as 295 Computational Linguistics Volume 19, Number 2 Brown et al.(1988) suggest and as Brown et al.(1990) and the current paper actually do.
C88-1016 J90-2002
In a later paper, Brown et al.(1990) describe a model that is essentially the same as our Model 3.
J90-2002
More recently, Gale and Church (1991a) describe an algorithm similar to the one described in Brown et al.(1988). Like Brown et al., they consider only the simultaneous appearance of words in pairs of sentences that are translations of one another.
C88-1016 H91-1026 P91-1023
In recent papers, Brown et al.(1988, 1990) propose a statistical approach to machine translation from French to English.
C88-1016 J90-2002
Brown et al.(1990) introduce the idea of an alignment between a pair of strings as an object indicating for each word in the French string that word in the English string from which it arose.
J90-2002
Brown, Lai, and Mercer (1991) have described an algorithm with which one can reliably extract French and English sentences that are translations of one another from parallel corpora.
H91-1025 P91-1022 P91-1034
For example, in Figure 9, we see that t(lelthe ) = 0.497 while the corresponding number from Figure 4 of Brown et al.(1990) is 0.610.
J90-2002
For example, a number of recent papers deal with the problem of automatically obtaining pairs of aligned sentences from parallel corpora (Warwick and Russell 1990; Brown, Lai, and Mercer 1991; Gale and Church 1991b; Kay 1991).
H91-1025 H91-1026 P91-1022 P91-1023 P91-1034
Brown et al.(1990) describe an algorithm for dividing a vocabulary into classes so as to preserve mutual information between adjacent classes in running text.
J90-2002
