Work Japanese Many previously proposed segmentation methods for Japanese text make use of either a pre-existing lexicon (Yamron et al., 1993; Matsumoto and Nagao, 1994; Takeuchi and Matsumoto, 1995; Nagata, 1997; Fuchi and Takagi, 1998) or pre-segmented training data (Nagata, 1994; Papa: georgiou, 1994; Nagata, 1996a; Kashioka et al., 1998; Mori and Nagao, 1998).
C94-1032 C94-1101 C96-2136 H93-1037 P98-1068 P98-1108 W96-0205 W97-0120
Proposed applications of segmentation technology include extracting new technical terms, indexing documents for information retrieval, and correcting optical character recognition (OCR) errors (Wu and Tseng, 1993; Nagao and Mori, 1994; Nagata, 1996a; Nagata, 1996b; Sproat et al., 1996; Fung, 1998).
C94-1101 C96-2136 J96-3004 W96-0205
Nagao and Mori (1994) propose using the heuris246 tic that high-frequency character n-grams may represent (portions of) new collocations and terms, but the results are not experimentally evaluated, nor is a general segmentation algorithm proposed.
C94-1101
Other approaches bootstrap from an initial segmentation provided by a baseline algorithm such as Juman (Matsukawa et al., 1993; Yamamoto, 1996).
H93-1045 W96-0113
To our knowledge, the Chinese segmenter most similar to ours is that of Sun et al.(1998). They also avoid using a lexicon, determining whether a given location constitutes a word boundary in part by deciding whether the two characters on either side tend to occur together; also, they use thresholds and several types of local minima and maxima to make segmentation decisions.
P98-2206
In contrast, previously proposed supervised approaches have used segmented training sets ranging from 1000-5000 sentences (Kashioka et al., 1998) to 190,000 sentences (Nagata, 1996a).
C96-2136 P98-1108 W96-0205
Computing n-gram statistics for all possible values of n simultaneously can be done in O(m log m) time using suffix arrays, where m is the training corpus size (Manber and Myers, 1993; Nagao and Mori, 1994).
C94-1101
In a later paper, Palmer (1997) presents a transformation-based algorithm, which requires pre-segmented training data.
P97-1041
This analysis is aided by the fact that there are three types of Japanese characters, kanji, hiragana, and katakana: changes in character type often indicate word boundaries, although using this heuristic alone achieves less than 60% accuracy (Nagata, 1997).
W97-0120
Chinese According to Sproat et al.(1996), most prior work in Chinese segmentation has exploited lexical knowledge bases; indeed, the authors assert that they were aware of only one previously published instance (the mutual-information method of Sproat and Shih (1990)) of a purely statistical approach.
J96-3004
The first, a crossing bracket, is a proposed bracket that overlaps but is not contained within an annotation bracket (Grishman et al., 1992).
A92-1022
