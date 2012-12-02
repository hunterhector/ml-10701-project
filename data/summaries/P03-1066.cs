Similarly, dependency-based models (e.g., Collins, 1996; Chelba et al., 1997) use a dependency structure D of W instead of a parse tree T, where D is extracted from syntactic trees.
P96-1025
The EM-like method for learning dependency relations described in Section 3.3 has also been applied to other tasks such as hidden Markov model training (Rabiner, 1989), syntactic relation learning (Yuret, 1998), and Chinese word segmentation (Gao et al., 2002a).
W02-1032
It reads a sentence left to right; after reading each new word 2 For parsers that use bigram lexical dependencies, Eisner and Satta (1999) presents parsing algorithms that are O(n 4 ) or O(n 3 ).
P99-1059
To deal with the data sparseness problem of MLE, we used the backoff estimation strategy similar to the one proposed in Collins (1996), which backs off to estimates that use less conditioning context.
P96-1025
For both DLM_1 and DLM_2, models with the parsing weight achieve better performance; we 7 For a detailed description of the baseline trigram model, see Gao et al.(2002a). therefore discuss only DLMs with the parsing weight for the rest of this section.
W02-1032
Following the work in Gao et al.(2002b), we used the unigram estimate for word category probabilities, (i.e., P(H j |Φ(W j-1, D j-1 )) ≈ P(H j ) and P(F j | Φ(W j-1, D j-1 )) ≈ P(F j )), and the standard trigram estimate for function word probability (i.e., P(w j |Φ(W j-1,D j-1 ),F j ) ≈ P(w j | w j-2, w j-1, F j )).
W02-1032
Many recent studies (e.g., Chelba and Jelinek, 2000; Charniak, 2001; Roark, 2001) adopt this approach.
J01-2004 P01-1017
