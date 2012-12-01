At the Shared Task on Word Alignment organized by the ACL2005 Workshop on “Building and Using Parallel Corpora: Data-driven Machine Translation and Beyond” (Martin, et al.2005), we participated (on the Romanian-English track) with the two aligners and the combined one (COWAL).
W05-0809
The alignments produced by MEBA were compared to the ones produced by YAWA and evaluated against the Gold Standard (GS)1 annotations used in the Word Alignment Shared Tasks (Romanian-English track) organized at HLT-NAACL2003 (Mihalcea and Pedersen 2003).
W03-0301
The implementation of MEBA was strongly influenced by the notorious five IBM models described in (Brown et al.1993). We used GIZA++ (Och and Ney 2000; Och and Ney, 2003) to estimate different parameters of the MEBA aligner.
J03-1002 J93-2003 P00-1056
words and punctuation 94.74% 59.48% 73.08% Probable links 92.05% 71.00% 80.17% Table 2: MEBA evaluation The score of a candidate link (LS) between a source token i and a target token j is computed by a linear function of several features scores (Tiedemann, 2003).
E03-1026
