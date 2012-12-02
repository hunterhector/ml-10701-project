If we assign a probability a15a17a16a19a18 a12 a13a7a21a20a4a6a5a7a23a22 to each pair of strings a18 a12a14a13a7a25a24 a4 a5a7 a22, then according to Bayes’ decision rule, we have to choose the target string that maximizes the product of the target language model a15a17a16a19a18 a12a14a13a7 a22 and the string translation model a15a17a16a19a18a26a4a6a5 a7 a20 a12 a13 a7 a22 . Many existing systems for statistical machine translation (Berger et al., 1994; Wang and Waibel, 1997; Tillmann et al., 1997; Nießen et al., 1998) make use of a special way of structuring the string translation model like proposed by (Brown et al., 1993): The correspondence between the words in the source and the target string is described by alignments that assign one target word position to each source word position.
H94-1028 J93-2003 P97-1037 P97-1047
The resulting model has an exponential form with free parameters a102 a91 a24a94a93 a8 a87 a24 a10a11a10a11a10 a24a46a95 . The parameter values which maximize the likelihood for a given training corpus can be computed with the socalled GIS algorithm (general iterative scaling) or its improved version IIS (Pietra et al., 1997; Berger et al., 1996).
J96-1002
That is obtained using the Viterbi alignment provided by a translation model as described in (Brown et al., 1993).
J93-2003
Similar techniques are used in (Papineni et al., 1996; Papineni et al., 1998) for socalled direct translation models instead of those proposed in (Brown et al., 1993).
J93-2003
Berger et al.(1996) use the words that surround a specific word pair a18 a12 a24 a4 a22 as contextual information.
J96-1002
(Foster, 2000) describes two methods for incorporating information about the relative position of bilingual word pairs into a maximum entropy translation model.
W00-0707
We use the program GIZA++ (Och and Ney, 2000b; Och and Ney, 2000a), which is an extension of the training program available in EGYPT (Al-Onaizan et al., 1999).
P00-1056
In this work we use the following contextual information: a3 Target context: As in (Berger et al., 1996) we consider a window of 3 words to the left and to the right of the target word considered.
J96-1002
(Berger et al., 1996) applies this approach to the so-called IBM Candide system to build context dependent models, compute automatic sentence splitting and to improve word reordering in translation.
J96-1002
Och. 1999.
E99-1010
We use the top-10 list of hypothesis provided by the translation system described in (Tillmann and Ney, 2000) for rescoring the hypothesis using the ME models and sort them according to the new maximum entropy score.
C00-2123
This is exactly the standard lexicon probability a27a28a18a26a4 a20a12 a22 employed in the translation model described in (Brown et al., 1993) and in Section 2.
J93-2003
The word classes are computed automatically using another statistical training procedure (Och, 1999) which often produces word classes including words with the same semantic meaning in the same class.
E99-1010
