We use the equivalence classes proposed by Freeman et al.(2006) to normalize Arabic and English word forms.
N06-1060
The two results are not comparable because: (a) Ittycheriah and Roukos (2005) used additional gold aligned data that was not released and (b) they use an additional 500K sentences from the LDC UN corpus for Giza training that was created by adapting to the source side of the test set – the details of such adaptation were not provided and thus it is not clear how to replicate them to compare fairly.
H05-1012
6.1 Experimental Data and Metrics The gold standard alignments we use here are part of the IBM Arabic-English aligned corpus (IBMAC)4 (Ittycheriah and Roukos, 2005).
H05-1012
NULL links are not included in the evaluation (Ayan, 2005; Ittycheriah and Roukos, 2005).
H05-1012
The standard evaluation metric within word alignment is the Alignment Error Rate (AER) (Och and Ney, 2000), which requires gold alignments that are marked as ’sure’ or ’probable’.
P00-1056
As such, the set of possible preprocessing schemes is rather large (Habash and Sadat, 2006).
N06-2013 P06-1001
We match the preprocessing and normalizations on our additional data to that of IBMAC’s Arabic and English preprocessing (Ittycheriah and Roukos, 2005).
H05-1012
With the exception of Fraser and Marcu (2006), these previous publications do not entirely discard the generative models in that they integrate IBM model predictions as features.
P06-1097
Ittycheriah and Roukos (2005) used only the top 50 sentences in IBMAC test data.
H05-1012
Sadat. 2006.
P06-1001
To create these schemes, we use MADA, an off-the-shelf resource for Arabic morphological disambiguation (Habash and Rambow, 2005), and TOKAN, a general Arabic tokenizer (Habash and Sadat, 2006).
N06-2013 P05-1071 P06-1001
The baseline we measure against in all of these experiments is the state-of-the-art grow-diag-final (gdf ) alignment refinement heuristic commonly used in phrase-based SMT (Koehn et al., 2003).
N03-1017
In other related work, Tillmann et al.(1997) use several preprocessing strategies on both source and target language to make them more alike with regards to sentence length and word order.
P97-1037
The intuition here is similar to the combination of different preprocessing schemes for a morphologically rich language as part of SMT (Sadat and Habash, 2006) except that the focus is on improving the alignment quality.
N06-2013 P06-1001
Schemes for Alignment Using a preprocessing scheme for word alignment breaks the process of applying Giza++ (Och and Ney, 2003) on some parallel text into three steps: preprocessing, alignment and remapping.
J03-1002
Since the IBMAC gold alignments we use are not marked as such, AER reduces to 1 F-score (Ittycheriah and Roukos, 2005): Pr = |A∩S||A| Rc = |A∩S||S| AER = 1 − 2PrRcPr+Rc where A links are proposed and S links are gold.
H05-1012
Lee (2004) only changes the word segmentation of the morphologically complex language (Arabic) to induce morphological and syntactic symmetry between the parallel sentences.
N04-4015
Word alignments over parallel corpora have become an essential supporting technology to a variety of natural language processing (NLP) applications most prominent among which is statistical machine translation (SMT).1 Although phrasebased approaches to SMT tend to be robust to wordalignment errors (Lopez and Resnik, 2006), improving word-alignment is still useful for other NLP research that is more sensitive to alignment quality, e.g., projection of information across parallel corpora (Yarowsky et al., 2001).
H01-1035
Habash. 2006.
N06-2013
Work Recently, several successful attempts have been made at using supervised machine learning for word alignment (Liu et al., 2005; Taskar et al., 2005; Ittycheriah and Roukos, 2005; Fraser and Marcu, 2006).
H05-1010 H05-1012 P05-1057 P06-1097
