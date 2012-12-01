In (Chen et al., 1999), three other models were proposed, but the mixed model achieved the highest accuracy.
E99-1025
We first use the fast TBL (Ngai and Florian, 2001), a Transformation Based Learning algorithm, to repeat Ramshaw and Marcus’ experiment, and then apply the same program to our new dataset.
N01-1006
(Chen et al., 1999) combined the traditional trigram model and head trigram model in their trigram mixed model.
E99-1025
(Collins, 2002) proposed a new algorithm for parameter estimation as an alternate to CRF.
W02-1001
(Ramshaw and Marcus, 1995) approached chucking by using Transformation Based Learning(TBL).
W95-0107
Both training and test data are first tagged by Brill’s POS tagger (Brill, 1995).
J95-4004
The previous best result on chunking in literature was achieved by Regularized Winnow (Zhang et al., 2001), which took some of the parsing results given by an English Slot Grammar-based parser as input to the chunker.
P01-1069
2This number is based on footnote 1 of (Chen et al., 1999).
E99-1025
In our first experiment, we use the same dataset as that of (Chen et al., 1999) for our experiments.
E99-1025
Compared with this program, our algorithm achieves an error reduction of a22a23a5a26a9a12a11 . (Chen et al., 1999) achieved an accuracy of a2a4a3a6a5a26a9a27a2a16a11 by combination of 5 distinct supertaggers.
E99-1025
We first run the Brill POS tagger (Brill, 1995) on both the training and the test data, and use POS tags as part of the input.
J95-4004
On the dataset used in (Chen et al., 1999), our supertagger achieves an accuracy of a2a4a3a6a5a8a7a10a9a12a11 . We then apply our supertagger to NP chunking.
E99-1025
We repeat Ramshaw and Marcus’ Transformation Based NP chunking (Ramshaw and Marcus, 1995) algorithm by substituting supertags for POS tags in the dataset.
W95-0107
Then we combine the results via pairwise voting as in (van Halteren et al., 1998; Chen et al., 1999) as the final supertag.
E99-1025 P98-1081
We test our supertagger on both the hand-coded supertags used in (Chen et al., 1999) as well as the supertags extracted from Penn Treebank(PTB) (Marcus et al., 1994; Xia, 2001).
E99-1025
Many machine learning techniques have been successfully applied to chunking tasks, such as Regularized Winnow (Zhang et al., 2001), SVMs (Kudo and Matsumoto, 2001), CRFs (Sha and Pereira, 2003), Maximum Entropy Model (Collins, 2002), Memory Based Learning (Sang, 2002) and SNoW (Mu˜noz et al., 1999).
N01-1025 N03-1028 P01-1069 W02-1001
The number of Srinivas(97) is based on footnote 1 of (Chen et al., 1999).
E99-1025
On the same dataset as that of (Chen et al., 1999), our new supertagger achieves an accuracy of a2a4a3a6a5a8a7a10a9a12a11 . Compared with the supertaggers with the same decoding complexity (Chen, 2001), our algorithm achieves an error reduction of a22a23a5a26a9a12a11 . We repeat Ramshaw and Marcus’ Transformation Based NP chunking (Ramshaw and Marcus, 1995) test by substituting supertags for POS tags in the dataset.
E99-1025 W95-0107
We use the same pairwise voting algorithm as in (Chen et al., 1999).
E99-1025
We have tested our algorithms on both the handcoded tag set used in (Chen et al., 1999) and supertags extracted for Penn Treebank(PTB).
E99-1025
As a first attempt, we use fast TBL (Ngai and Florian, 2001), a TBL program, to repeat Ramshaw and Marcus’ experiment on the standard dataset.
N01-1006
In Lexicalized Tree-Adjoining Grammar (LTAG) (Joshi and Schabes, 1997; XTAG-Group, 2001), each word in a sentence is associated with an elementary tree, or a supertag (Joshi and Srinivas, 1994).
C94-1024
Work (Chen, 2001) implemented an MEMM model for supertagging which is analogous to the POS tagging model of (Ratnaparkhi, 1996).
W96-0213
